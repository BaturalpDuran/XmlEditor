   M S B A M L   `   `   `  ����D  @XmlEditor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:XmlEditor	XmlEditor  5   	       XmlEditor.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:XmlEditor     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	         _ListBoxItemStyle �� 
TargetType �� Property �� Value �� 
TargetType �� Padding J� SnapsToDevicePixels �� Triggers	 P� Property
 P� Value �� 
TargetName��%�  &	        �� 5
   
   " ��6*   .�5      ��  � ��$ Center=�6;   �� 5       � ��$
 Auto��6&   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $��_Border��6!   $ 2q�5   !   
���   �$��0q�5   !   $
 true��5   !   ._�5      �� 5       5      P� 5      	 �@��
IsSelected$

 true��6<   . �5   "   �� $ _Border��6)    � �� �#F1F5F46T   �� 5   "    � ��$ 1q�6D   �� 5   "    � ��
 �   �6@   �� 5   "    � ��
 �   �6?   5      P� 5      	 �@��
IsSelected$
 False��6<   . �5   "   �� $ _Border��6)    � ��
 ���� 6T   �� 5    "    � ��
 �   �6?   5!      5#      5%      5&      5'      .��5(      � -   5         �Name$ MainGrid��5(      .+�5)   
   � -   5        $ content��5)       � ColumnDefinitions 5*      �� 5+      �� 5,      �� 5-      .+�5Q      � $��1��6    � RowDefinitions 5R      �� 5S      $	��100 �6$   �� 5T      $	��335 �6$   .+�5V      �� -   5        $��Center=�5V      $	��Top=�66   $��30q�6N   $��Read Xml File��6Z   6r   5`      5l      5m      5n      