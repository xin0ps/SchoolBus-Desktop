   M S B A M L   `   `   `  ���� J  FSchoolBusAppWpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:SchoolBusAppWpf.Views.PagesSchoolBusAppWpf.Views.Pages  4    .SchoolBusAppWpf.Views.Pages.NavigationSideView   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ;local)clr-namespace:SchoolBusAppWpf.Views.Pages     _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    N� Title$  NavigationSideView��.���  � ColumnDefinitions �� $
��0.4* ��� $��* �.+�� $��0��
������� � RowDefinitions �� $
��0.3* ��� $��* �.+�� $��0��
�������.+��� $
��Fill=�$��/Statics/busnav2.png����  �� CornerRadius$ 	40,40,0,0��$��
10,0,15,15q�$��1��
��� ���._��� $��0,25,0,0q�.+��� $��Create Rides��
��� ���$��0,20,0,0q�$��SemiBold"� "  MaterialDesignRaisedDarkButton#��[  $��40��$	��200��
�������+  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 	0,10,0,10�� � ToolTip$7 1MaterialDesignRaisedDarkButton with Round Corners������ *CreateRideCommand+����  �� ElementName$ 
InnerFrame�� �� Path$ Content��� $��Rides��
��� ���$��0,20,0,0q�$��SemiBold"�#��[  $��40��$	��200��
�������$ 	0,10,0,10��$7 1MaterialDesignRaisedDarkButton with Round Corners������ *RidesCommand+���� $ 
InnerFrame��$ Content��� $��Class��
��� ���$��0,20,0,0q�$��SemiBold"�#��[  $��40��$	��200��
�������$ 	0,10,0,10��$7 1MaterialDesignRaisedDarkButton with Round Corners������ *ClassCommand+���� $ 
InnerFrame��$ Content��� $��Student��
��� ���$��0,20,0,0q�$��SemiBold"�#��[  $��40��$	��200��
�������$ 	0,10,0,10��$7 1MaterialDesignRaisedDarkButton with Round Corners������ *StudentCommand+���� $ 
InnerFrame��$ Content��� $��Parent��
��� ���$��0,20,0,0q�$��SemiBold"�#��[  $��40��$	��200��
�������$ 	0,10,0,10��$7 1MaterialDesignRaisedDarkButton with Round Corners������ *ParentCommand+���� $ 
InnerFrame��$ Content��� $��Driver��
��� ���$��0,20,0,0q�$��SemiBold"�#��[  $��40��$	��200��
�������$ 	0,10,0,10��$7 1MaterialDesignRaisedDarkButton with Round Corners������ *DriverCommand+���� $ 
InnerFrame��$ Content��� $	��Car��
��� ���$��0,20,0,0q�$��SemiBold"�#��[  $��40��$	��200��
�������$ 	0,10,0,10��$7 1MaterialDesignRaisedDarkButton with Round Corners������ *
CarCommand+���� $ 
InnerFrame��$ Content�� $��1��.+� � -   $��
InnerFrame��$��	3 10 3 10q�  � NavigationUIVisibility$ Hidden=����� *CurrentView+	 �� Mode$	 TwoWay=�