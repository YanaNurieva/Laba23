   M S B A M L   `   `   `  ����E  AWpfLabaTsi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WpfLabaTsi
WpfLabaTsi  5   	       WpfLabaTsi.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WpfLabaTsi     5   	     � Title$  
MainWindow��5   	   $	��600��6   $	��960��6*    � 	Resources 5	       �� 
TargetType 	  MyBtn �� CornerRadius �� Padding �� Triggers P� Property P� Value �� 
TargetName	 �� Property
 �� Value�� 5
   
   %y  &	        �� 5      " ��6   .R�5      �� $��	borderBtn��6u   $ 8��6   
�������$��1q�6=   # z��6Q   ._�5      �� $��textBtn��6I   #��z��6%   $��Center=�6X   5       5      P� 5       �@J�IsMouseOver . . �5      �� $ 	borderBtn��6R   	 � ��

 �   ��� 5      $ textBtn��6R   	 � ��

 �����5      5      5      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��0��6   $��Center=�6"   .+�5      �� $��\img\NatureLogo.png��6   $	��500��62   5      �� 5    
   $��1��6   $��Center=�6"   $	��400��6?   .+�5!      �� .+�5"      �� $��
Логин��6   $��24(�6)    J� Opacity$ .5Q�67   �� 5#      -   5        $��LogBox��5#   B   $��2q�6   $��5q�6.   $�� ��6:   6B   5$      �� 5%      $��Пароль��6   $��24(�6&   $ .5Q�64   G� 5&      -   5        $��PasBox��5&   :   $��2q�6   $��5q�6.   6:   �� 5'      -   5        #���   5'      $��10q�68   $	��220��6E   $��0 20 0 0q�6Q   $��
Войти��6~   �� 5)       �� Orientation$ 
Horizontal=�6   $��Center=�62   $��0 10 0 0q�6O   .+�5*      �� $%��Еще нет аккаунта?��6   
�������$��Center=�6G   �� 5+      -   5        $��BtnRegistration��5+   �   
������ 
������ $��Center=�6L   ��5,      �� 5-      $��Регистрация��6$   $��	Underline{�67   5/      50      51      52      53      