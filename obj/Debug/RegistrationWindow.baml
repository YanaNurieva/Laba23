   M S B A M L   `   `   `  ����E  AWpfLabaTsi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WpfLabaTsi
WpfLabaTsi  5   	   #    WpfLabaTsi.RegistrationWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WpfLabaTsi     5   	     � Title$  RegistrationWindow��5   	   $	��450��6$   $	��800��61    � 	Resources 5	       �� 
TargetType 	  MyBtn �� CornerRadius �� Padding �� Triggers P� Property P� Value �� 
TargetName	 �� Property
 �� Value�� 5
   
   %y  &	        �� 5      " ��6   .R�5      �� $��	borderBtn��6u   $ 8��6   
�������$��1q�6=   # z��6Q   ._�5      �� $��textBtn��6I   #��z��6%   $��Center=�6X   5       5      P� 5       �@J�IsMouseOver . . �5      �� $ 	borderBtn��6R   	 � ��

 �   ��� 5      $ textBtn��6R   	 � ��

 �����5      5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��70 �6   �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5       �� 5!      .+�5#   
   �� $��0��6   $��Center=�6"   $��1��6=   .+�5$      �� $��Регистрация��6   $��Center=�6+   $��24(�6H   5%      �� 5&   
   $��1��6    �� Orientation$ 
Horizontal=�6"   .+�5'      �� $	��240��6   $��
10 10 0 10q�6%   $��Center=�69   .+�5(      �� $��Login��6   
�������$��0 0 0 5q�6;   �� 5)      -   5         ��Name$ logBox��5)      5*      5+      �� 5,   
   $	��240��6   $��2��6!   $��1��61   $��Center=�6>   .+�5-      �� $��Password��6   
�������$��0 0 0 5q�6:   �� 5.      -   5        $ pasBox��5.      5/      �� 50   
   $��2��6   $��1��6"   .+�51      �� -   5        $��SignUp��51   a   $��Создать��6   #��[  6'   $	��240��6I   $��25��6U   6o   52      53      54      