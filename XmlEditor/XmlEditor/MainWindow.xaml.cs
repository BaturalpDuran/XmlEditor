using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Xml;
using System.Xml.Serialization;
using XmlEditor.Class;
using XmlEditor.Constants;
using System.Collections;
using XmlEditor.UserControls;

namespace XmlEditor
{
    public class TestClass
    {
        public List<TestClass2> List { get; set; }
    }
    public class TestClass2
    {
        public string Property1 { get; set; }
        public string Property2 { get; set; }
        public string Property3 { get; set; }
        public bool Property4 { get; set; }
        public int Property5 { get; set; }
        public List<TestClass3> List { get; set; }
        public override string ToString()
        {
            return Property1 + " - " + Property2;
        }
    }
    public class TestClass3
    {
        public string Property1 { get; set; }
    }


    [Serializable]
    public class WorkerListClass
    {
        public List<Worker> WorkerList { get; set; }

        public WorkerListClass()
        {
            WorkerList = new List<Worker>();
        }
    }
    public partial class MainWindow : Window
    {
        private TestClass data;
        public MainWindow()
        {
            InitializeComponent();
            data = new TestClass()
            {
                List = new List<TestClass2>()
                {
                    new TestClass2()
                    {
                        Property1 = "1",
                        Property2 = "2",
                        Property3 = "3",
                        Property4 = true,
                        Property5 = 1,
                        List = new List<TestClass3>()
                        {
                            new TestClass3(){ Property1 = "1"},
                            new TestClass3(){ Property1 = "2"},
                        }
                    },
                    new TestClass2()
                    {
                        Property1 = "4",
                        Property2 = "5",
                        Property3 = "6",
                        Property4 = false,
                        Property5 = 2,
                        List = new List<TestClass3>()
                        {
                            new TestClass3(){ Property1 = "3"},
                            new TestClass3(){ Property1 = "4"},
                        }
                    }
                }
            };
        }


        private void btnRead_Click(object sender, RoutedEventArgs e)
        {
            uc.LoadData(data.List);
        }

        private void Test_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(data);
        }
    }
}
