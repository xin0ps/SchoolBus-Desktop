   M S B A M L   `   `   `  ���� J  FSchoolBusAppWpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:SchoolBusAppWpf.WindowsSchoolBusAppWpf.Windows  (    "SchoolBusAppWpf.Windows.MainWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     7local%clr-namespace:SchoolBusAppWpf.Windows     _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � Title$  
MainWindow��$	��700��$
��1100�� [� ShowsNavigationUI$ False�� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=� � WindowStyle$
 None=�
������  � AllowsTransparency$
 True������  �� CornerRadius$ 20��
�������._�� $��5q� � RowDefinitions �� $��40 ��� .+�� $��1������  �� ImageSource$ /Statics/bus3.png��	 j� Stretch$
	 Fill=�.+� � 
  � Source$#
 ../Views/Pages/LoginView.xaml?��� $��0�� �� Orientation$ 
Horizontal=�$��Right=�$��0,0,20,0q�.+��� -   $��40��$��50��
��� ��� &  "MaterialDesignFloatingActionButton#��[  {��� *DataContext.ControlsEnabled+ �� RelativeSource �� *FindAncestor+ �� AncestorType
 Window.��'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Minimize=�$��40��$��40���� -   $��40��$��50��$��20,0,0,0q�
���  ��#��[  {��� *DataContext.ControlsEnabled+ �� *FindAncestor+
 Window.��  $ Close=�$��40��$��40��