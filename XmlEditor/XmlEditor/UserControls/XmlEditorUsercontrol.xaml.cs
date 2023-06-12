using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Xml.Serialization;
using XmlEditor.Constants;

namespace XmlEditor.UserControls
{
    public partial class XmlEditorUsercontrol : UserControl
    {
        public string filePath = XmlEditorConstants.XmlBasePath;
        private bool isSaved = false;
        private WorkerListClass workerListClass;
        private string xmlFilePath = XmlEditorConstants.XmlFilePath;
        private WorkerListClass workerList = new WorkerListClass();
        public XmlEditorUsercontrol()
        {
            InitializeComponent();
        }
        public void LoadData(IList objList)
        {
            listbox1.Items.Clear();
            listbox1.ItemsSource = null;
            foreach (var item in objList)
            {
                listbox1.Items.Add(item);
            }
            listbox1.SelectedIndex = 0;
        }
        private void LoadEditingGrid(object worker)
        {
            CreateAndAddNewGrid(worker);
        }

        private TextBlock GenerateLabelTextBlock(PropertyInfo prop)
        {
            TextBlock propertyNameText = new TextBlock();
            propertyNameText.Text = prop.Name;
            propertyNameText.Height = 40;
            propertyNameText.HorizontalAlignment = HorizontalAlignment.Left;
            return propertyNameText;
        }

        private Tuple<Grid, FrameworkElement> GenerateGrid(string propertyName,object value)
        {
            Grid grid = new Grid();
            FrameworkElement fe = CreateControl(value);
            if (string.IsNullOrEmpty(propertyName))
            {
                fe.HorizontalAlignment = HorizontalAlignment.Left;
                grid.Children.Add(fe);
            }
            else
            {
                TextBlock propertyNameText = new TextBlock();
                propertyNameText.Text = propertyName;
                propertyNameText.Height = 40;
                propertyNameText.HorizontalAlignment = HorizontalAlignment.Left;
                grid.Children.Add(propertyNameText);

                fe.HorizontalAlignment = HorizontalAlignment.Right;
                grid.Children.Add(fe);
            }
            return new Tuple<Grid, FrameworkElement>(grid,fe);
        }
        private FrameworkElement CreateControl(object value)
        {
            if(value is string || value is int || value is double)
            {
                TextBox tb = new TextBox();
                tb.Text = value.ToString();
                tb.Height = 40;
                tb.Width = 120;
                tb.HorizontalAlignment = HorizontalAlignment.Right;
                return tb;
            }
            else if(value is bool)
            {
                CheckBox cb = new CheckBox();
                cb.IsChecked = (bool)value;
                cb.Height = 40;
                cb.HorizontalAlignment = HorizontalAlignment.Left;
                return cb;
            }

            return null;
        }
        private Grid GenerateValueTextBlock(PropertyInfo prop, object obj)
        {
            Grid horizontalSp = new Grid();
            horizontalSp.Children.Add(GenerateLabelTextBlock(prop));

            TextBlock propertyValueText = new TextBlock();
            propertyValueText.Text = prop.GetValue(obj, null).ToString();
            propertyValueText.Height = 40;
            propertyValueText.Width = 120;
            propertyValueText.HorizontalAlignment = HorizontalAlignment.Right;
            horizontalSp.Children.Add(propertyValueText);
            return horizontalSp;
        }

        private Grid GenerateValueComboBox(PropertyInfo prop, object obj)
        {
            Grid horizontalSp = new Grid();
            horizontalSp.Children.Add(GenerateLabelTextBlock(prop));
            ComboBox propertyComboBox = new ComboBox();
            propertyComboBox.ItemsSource = null;
            propertyComboBox.SelectedItem = (Enum)prop.GetValue(obj, null);
            Type enumType = prop.PropertyType;
            foreach (var item in Enum.GetValues(enumType))
            {
                propertyComboBox.Items.Add(item);
            }
            propertyComboBox.Height = 40;
            propertyComboBox.Width = 120;
            propertyComboBox.HorizontalAlignment = HorizontalAlignment.Right;
            horizontalSp.Children.Add((ComboBox)propertyComboBox);
            return horizontalSp;
        }

        private Grid GenerateValueCheckBox(PropertyInfo prop, object obj)
        {
            Grid horizontalSp = new Grid();
            horizontalSp.Children.Add(GenerateLabelTextBlock(prop));
            CheckBox propertyCheckBox = new CheckBox();
            propertyCheckBox.IsChecked = (bool)prop.GetValue(obj, null);
            propertyCheckBox.Height = 40;
            propertyCheckBox.Width = 120;
            propertyCheckBox.HorizontalAlignment = HorizontalAlignment.Right;
            horizontalSp.Children.Add(propertyCheckBox);
            return horizontalSp;
        }
        private Grid GenerateEditButton(PropertyInfo prop, object obj)
        {
            Grid horizontalSp = new Grid();
            horizontalSp.Children.Add(GenerateLabelTextBlock(prop));
            Button editButton = new Button() { Content = "Edit" };
            editButton.Tag = obj;
            editButton.Height = 40;
            editButton.Width = 120;
            editButton.HorizontalAlignment = HorizontalAlignment.Right;
            editButton.Click += EditButtonEvent;
            horizontalSp.Children.Add(editButton);
            return horizontalSp;
        }


        private void EditButtonEvent(object sender, RoutedEventArgs e)
        {
            if(sender is Button btn && btn.Tag != null)
            {
                EditGrid.Visibility = Visibility.Collapsed;
                XmlEditorUsercontrol uc = new XmlEditorUsercontrol();
                uc.LoadData((IList)btn.Tag);
                MainGrid.Children.Add(uc);
            }
  
        }

        private void CreateAndAddNewGrid(object worker)
        {
            Grid propertyGrid = new Grid();
            Type t = worker.GetType();
            List<Tuple<FrameworkElement, PropertyInfo>> controls = new List<Tuple<FrameworkElement, PropertyInfo>>();
            PropertyInfo[] properties = t.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                string propertyName = property.Name;
                object value = property.GetValue(worker, null);

                if (property.GetValue(worker, null) is IList)
                {
                    PropertyStackPanel.Children.Add(GenerateEditButton(property, property.GetValue(worker, null)));
                }
                else
                {
                    Tuple<Grid, FrameworkElement> result = GenerateGrid(propertyName, value);
                    controls.Add(new Tuple<FrameworkElement, PropertyInfo>(result.Item2, property));
                    PropertyStackPanel.Children.Add(result.Item1);
                }
            }

            object tag = new Tuple<object, List<Tuple<FrameworkElement, PropertyInfo>>>(worker, controls);
            Button saveButton = new Button() { Content = "Save" };
            saveButton.Tag = tag;
            saveButton.Height = 40;
            saveButton.Width = 120;
            saveButton.HorizontalAlignment = HorizontalAlignment.Right;
            saveButton.Click += Save;
            PropertyStackPanel.Children.Add(saveButton);
        }

        public void Save(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn && btn.Tag is Tuple<object, List<Tuple<FrameworkElement, PropertyInfo>>> data)
            {
                foreach (var control in data.Item2)
                {
                    if (control.Item1 is TextBox tb)
                    {
                        PropertyInfo propertyInfo = control.Item2;
                        if(propertyInfo.PropertyType == typeof(String))
                        {
                            control.Item2.SetValue(data.Item1, tb.Text);
                        }
                        else if(propertyInfo.PropertyType == typeof(int))
                        {
                            control.Item2.SetValue(data.Item1, Convert.ToInt32(tb.Text));
                        }
                        else if (propertyInfo.PropertyType == typeof(double))
                        {
                            control.Item2.SetValue(data.Item1, Convert.ToDouble(tb.Text));
                        }
                    }
                    else if (control.Item1 is CheckBox cb)
                    {
                        control.Item2.SetValue(data.Item1, cb.IsChecked);
                    }
                }
            }
        }

        private Border GenerateValueGrid(object obj)
        {
            Border border = new Border();
            border.BorderBrush = Brushes.Black;
            border.BorderThickness = new Thickness(2, 2, 2, 2);
            border.CornerRadius = new CornerRadius(5);
            Grid grid = new Grid();
            StackPanel valueSp = new StackPanel();
            grid.Children.Add(valueSp);
            TextBlock headerTextBlock = new TextBlock()
            {
                Text = obj.GetType().Name,
                HorizontalAlignment = HorizontalAlignment.Left,
                Margin = new Thickness(5, 5, 5, 10),
                FontWeight = FontWeights.Bold,
                FontSize = 18
            };
            valueSp.Children.Add(headerTextBlock);
            Type t = obj.GetType();
            PropertyInfo[] properties = t.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                if (property.GetValue(obj, null) is int)
                {
                    valueSp.Children.Add(GenerateValueTextBlock(property, obj));
                }
                else if (property.GetValue(obj, null) is Enum)
                {
                    valueSp.Children.Add(GenerateValueComboBox(property, obj));
                }
                else if (property.GetValue(obj, null) is string)
                {
                    valueSp.Children.Add(GenerateValueTextBlock(property, obj));
                }
                else if (property.GetValue(obj, null) is bool)
                {
                    valueSp.Children.Add(GenerateValueCheckBox(property, obj));
                }
                else if (property.GetValue(obj, null) is object)
                {
                    valueSp.Children.Add(GenerateValueGrid(property.GetValue(obj, null)));
                }
                else if (property.GetType().IsGenericType &&
                        property.GetType().GetGenericTypeDefinition() == typeof(List<>))
                {
                    Console.WriteLine();
                }
            }
            border.Child = grid;
            return border;
        }

        private void listbox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(listbox1.SelectedItem != null)
            {
                PropertyStackPanel.Children.RemoveRange(0, PropertyStackPanel.Children.Count);
                LoadEditingGrid(listbox1.SelectedItem);
            }
        }
    }
}
