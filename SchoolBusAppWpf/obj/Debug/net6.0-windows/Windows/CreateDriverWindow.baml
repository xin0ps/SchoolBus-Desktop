   M S B A M L   `   `   `  ����J  FSchoolBusAppWpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:SchoolBusAppWpf.WindowsSchoolBusAppWpf.Windows  5   	   0    *SchoolBusAppWpf.Windows.CreateDriverWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:SchoolBusAppWpf.Windows     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � WindowStartupLocation$  CenterScreen=�5
       � 
ResizeMode$ NoResize=�5       � WindowStyle$
 None=�5      
������  � AllowsTransparency$
 True��5       � Title$ CreateDriverWindow��5   	   $	��400��6$   $	��300��61   .��5      � .+�5   
   #  MaterialDesignThemes.Wpf.Card  
�������$	��300��5      $	��400��6      UniformCornerRadius$ 20Q�6   .��5      � 
������  � RowDefinitions 5      �� 5      $
��0.8* �6$   �� 5      $��* �6$   �� 5      $��* �6$   �� 5      $��* �6$   �� 5      $��* �6$   �� 5      $��* �6$   �� 5      $��* �6$   �� 5      $��* �6$   �� 5       $��* �6$   .+�5$      �� -   5        $��0��5$      $��20��6&   $��20��62   $��	260,0,0,0q�6=   
���  �� &  "MaterialDesignFloatingActionButton#��[  5'      {�5)      �� *DataContext.ControlsEnabled+ �� RelativeSource �� *FindAncestor+ �� AncestorType
 Window.��5*      '  !MaterialDesignThemes.Wpf.PackIcon  	   Kind$	 Close=�5+      $��20��5,      $��20��5-      5.      �� 50      $��0��6   $��Create Driver��6%   $��Center=�51      $��Center=�52      $��0,0,0,0q�53      $��24(�54      $��Sans-Sheriff)�55      $��	ExtraBold"�56      �� 59      -   5        $��FirstNameTextBox��5:      $��1��59      
��� ���$	��280��5;      $��50��5<      )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 	Firstname��5=         
Foreground
 � ��� ! MaterialDesignOutlinedTextBox#��[ 5>      ��5?      �� *	FirstName+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�.��6U   5A      �� 5C      -   5        $��LastNameTextBox��5D      $��2��5C      
��� ���$	��280��5E      $��50��5F      $
 Lastname��5G      
 � ���#��[ 5H      ��5I      �� *
LastName+$ TwoWay=�$ PropertyChanged=�.��6S   5J      �� 5L      -   5        $��PhoneTextBox��5M      $��3��5L      
��� ���$	��280��5N      $��50��5O      $
 Phone��5P      
 � ���#��[ 5Q      ��5R      �� *Phone+$ TwoWay=�$ PropertyChanged=�.��6P   5S      �� 5V      -   5        $��AddressTextBox��5W      $��4��5V      
��� ���$	��280��5X      $��50��5Y      $
 Address��5Z      
 � ���#��[ 5[      ��5\      �� *
HomeAdress+$ TwoWay=�$ PropertyChanged=�.��6U   5]      �� 5`      -   5        $��LicenceTextBox��5a      $��5��5`      
��� ���$	��280��5b      $��50��5c      $
 License��5d      
 � ���#��[ 5e      ��5f      �� *	License+$ TwoWay=�$ PropertyChanged=�.��6R   5g      �� 5i      -   5        $��UsernameTextBox��5j      $��6��5i      
��� ���$	��280��5k      $��50��5l      $
 Username��5m      
 � ���#��[ 5n      ��5o      �� *
Username+$ TwoWay=�$ PropertyChanged=�.��6O   5p      �� 5t      -   5        $��PasswordTextBox��5u      $��7��5t      
��� ���$	��280��5v      $��50��5w      $
 Password��5x      
 � ���#��[ 5y      ��5z      �� *
Password+$ TwoWay=�$ PropertyChanged=�.��6O   5{      �� 5�      -	   5        $��	AddButton��5�      
��� ���$��8��5�   -   $��40��5�      $	��170��5�      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5�      $��0q�5�      $��CREATE��5�      ��5�      �� *CreateDriver+��5�      ��  �� *FindAncestor+" �5�      5�      5�      5�      