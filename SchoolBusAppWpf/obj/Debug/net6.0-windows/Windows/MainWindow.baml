   M S B A M L   `   `   `  ����J  FSchoolBusAppWpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:SchoolBusAppWpf.WindowsSchoolBusAppWpf.Windows  5   	   (    "SchoolBusAppWpf.Windows.MainWindow   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:SchoolBusAppWpf.Windows     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  
MainWindow��5	      $	��700��6   $
��1100��6,    [� ShowsNavigationUI$ False��5
       � WindowStartupLocation$ CenterScreen=�5   
    � 
ResizeMode$ NoResize=�5       � WindowStyle$
 None=�5      
������  � AllowsTransparency$
 True��5      ��5      �� 5   
    �� CornerRadius$ 20��6   
�������._�5   
   � $��5q�6    � RowDefinitions 5      �� 5      $��40 �6    �� 5      .+�5   
   � $��1��6   ��5      �� 5       �� ImageSource$ /Statics/bus3.png��6%   	 j� Stretch$
	 Fill=�6E   .+�5!       � 
  � Source$#
 ../Views/Pages/LoginView.xaml?�6   5#      5$      �� 5&      $��0��6    �� Orientation$ 
Horizontal=�6&   $��Right=�6?   $��0,0,20,0q�6[   .+�5)      �� -   5        $��40��5)      $��50��6&   
��� ��� &  "MaterialDesignFloatingActionButton#��[  5+      {�5-      �� *DataContext.ControlsEnabled+ �� RelativeSource �� *FindAncestor+ �� AncestorType
 Window.��5.   "   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Minimize=�5/      $��40��50      $��40��51      52      �� 55      -   5        $��40��55      $��50��6%   $��20,0,0,0q�60   
���  ��#��[  58      {�5:      �� *DataContext.ControlsEnabled+ �� *FindAncestor+
 Window.��5;   &     $ Close=�5<      $��40��5=      $��40��5>      5?      5E      5H      5K      5M      