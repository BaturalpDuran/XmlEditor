   M S B A M L   `   `   `  ����D  @XmlEditor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:XmlEditor.UserControlsXmlEditor.UserControls  5      1    +XmlEditor.UserControls.XmlEditorUsercontrol   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:XmlEditor.UserControls     5        � 	Resources  5	         _ListBoxItemStyle �� 
TargetType �� Property �� Value �� 
TargetType �� Padding J� SnapsToDevicePixels �� Triggers P� Property	 P� Value
 �� 
TargetName��%�  &	        �� 5
   
   " ��6*   .�5      ��  � ��$ Center=�6;   �� 5       � ��$
 Auto��6&   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $��_Border��6!   $ 2q�5   !   
���   �$��0q�5   !   $
 true��5   !   ._�5      �� 5       5      P� 5       �@��
IsSelected$
	 true��6<   . �5   "   �� $
 _Border��6)    � �� �#F1F5F46T   �� 5   "    � ��$ 1q�6D   �� 5   "    � ��
 �   �6@   �� 5   "    � ��
 �   �6?   5      P� 5       �@��
IsSelected$	 False��6<   . �5   "   �� $
 _Border��6)    � ��
 ���� 6T   �� 5    "    � ��
 �   �6?   5!      5#      5%      5&      5'      .��5(      � -   5         �Name$ MainGrid��5(      .+�5)   
   � -   5        $ EditGrid��5)   "   
������� � ColumnDefinitions 5*      �� 5+      �� 5,      .+�5.      � $��0��6   .+�5/      �� -   5        $��listbox1��5/   �   $��1��6G   
������ #���   6m   $��Hidden=�6�   $��0q�6�   $y�Visible=�6�   57      58      �� 59      -   5         ��Name$ 
MainViewer��59   +   $��1��6   .��5:      � .+�5<      � -   5        $ PropertyNameGrid��5<      .+�5=      �� -   5         ��Name$ PropertyStackPanel��5=   %   5?      5@      5A      5B      5D      5E      5G      