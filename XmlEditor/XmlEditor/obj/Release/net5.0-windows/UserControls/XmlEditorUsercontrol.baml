   M S B A M L   `   `   `  ���� D  @XmlEditor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:XmlEditor.UserControlsXmlEditor.UserControls  1    +XmlEditor.UserControls.XmlEditorUsercontrol   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     6local$clr-namespace:XmlEditor.UserControls       � 	Resources     _ListBoxItemStyle �� 
TargetType �� Property �� Value �� 
TargetType �� Padding J� SnapsToDevicePixels �� Triggers P� Property	 P� Value
 �� 
TargetName��%�  &	        �� " ��.���  � ��$ Center=���  � ��$
 Auto����  � �� �� " ��.R��� $��_Border��$ 2q�
���   �$��0q�$
 true��._���  P�  �@��
IsSelected$
	 true��. ��� $
 _Border�� � �� �#F1F5F4��  � ��$ 1q���  � ��
 �   ���  � ��
 �   �P�  �@��
IsSelected$	 False��. ��� $
 _Border�� � ��
 ���� ��  � ��
 �   �.��� -    �Name$ MainGrid��.+�� -   $ EditGrid��
������� � ColumnDefinitions �� �� .+�� $��0��.+��� -   $��listbox1��$��1��
������ #���   $��Hidden=�$��0q�$y�Visible=��� -    ��Name$ 
MainViewer��$��1��.��� .+�� -   $ PropertyNameGrid��.+��� -    ��Name$ PropertyStackPanel��