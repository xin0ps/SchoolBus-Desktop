   M S B A M L   `   `   `  ����J  FSchoolBusAppWpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:SchoolBusAppWpf.Views.PagesSchoolBusAppWpf.Views.Pages  5      0    *SchoolBusAppWpf.Views.Pages.CreateRideView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:SchoolBusAppWpf.Views.Pages     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  CreateRideView��5
      .��5      � 
������� � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��2* �6   .+�5   
   � $��0��6   .+�5      �� $��10q�6   .+�5      �� $
��Ride��6   $��24(�6$   $
��Bold"�62   �� 5      -   5        $��fullnamelbl��5      $��20(�6'   $��	Fullname:��65   �� 5      -   5        $��
carnamelbl��5      $��20(�6(   $��	Car Name:��66   �� 5      -   5        $��carnumberlbl��5      $��20(�6(   $��Car Number:��67   �� 5      -   5        $��Studentsattendlbl��5      $��20(�6-   $��Student Attend:��6<   �� 5      -   5        $��maxseatslbl��5      $��20(�6(   $��
Max Seats:��66   �� 5      -   5        $��ridescmb��5   �    �� SelectedItem 6   �� *SelectedRide+ �� UpdateSourceTrigger$ PropertyChanged=���6�   �� *Rides+��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6)   .+�5   "   �� ��6,   �� *	StartTime+�� 5   "   $	�� - ��6,   �� 5    "   ��6,   �� *	EndTime+5!      5"      5$      5,      5-      � 52   
   $��1��6    � RowDefinitions 53      �� 55      �� 56      .+�5:      &   System.Windows.Controls.DataGrid  $��0��6   $��5q�5;         AutoGenerateColumns$ False��5<         CanUserDeleteRows$
 True��5?      ��5=      �� *AllStudents+$ PropertyChanged=� �� Mode$ TwoWay=� 5>      �� *SelectedItem+$ PropertyChanged=�$ TwoWay=�	   Columns	 5@      0  *System.Windows.Controls.DataGridTextColumn  5A      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Id��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *Id+  5B      $
 	Firstname��6)    6<   �� *	FirstName+$ PropertyChanged=�$ TwoWay=�  5C      $
 Lastname��6)    6;   �� *
LastName+$ PropertyChanged=�$ TwoWay=�  5D      $
 Class��6)    68   �� *
Class.Name+$ PropertyChanged=�$ TwoWay=�4  .System.Windows.Controls.DataGridTemplateColumn  5E      $
 Parents��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6>      CellTemplate 5F      �� 5G      .R�5H   "   �� 
��� ���$��0��6@    �� DisplayMemberPath$ Parent.FirstName��5I   +    �� SelectedIndex$ 0��5J   )   $	��120��5K   )   ��5L   )   �� *ParentStudents+5M      5O        5Q      $	
 Add��6-    5R      �� 5S      .R�5T   "   � $	��100��6'   $��30��63    5U   &   �� 5V   *   �� 5W   *   .+�5Y   &   �� -   5        $��0��5Y   -   $��2q�5Z   )   $��25��5[   )   $��25��5\   )   $��-3q�5]   )   ���#97a97c���#97a97c "  MaterialDesignRaisedDarkButton#��[  5a   )   ��5`   )   0  *MaterialDesignThemes.Wpf.PackIconExtension     Kind$	 Add=�5a   )   5b   #   5c      5e      5g        5j      $��1��6   $��5q�5k      $ False��5l      $
 True��5o      ��5m      �� *InRideStudents+$ PropertyChanged=�$ TwoWay=� 5n      �� *SelectedItem2+$ PropertyChanged=�$ TwoWay=�	 5p        5q      $
 Id��6)    65   �� *Id+  5r      $
 	Firstname��6)    6<   �� *	FirstName+$ PropertyChanged=�$ TwoWay=�  5s      $
 Lastname��6)    6;   �� *
LastName+$ PropertyChanged=�$ TwoWay=�  5t      $
 Class��6)    68   �� *
Class.Name+$ PropertyChanged=�$ TwoWay=�  5u      $
 Parents��6-   $	 100 6>    5v      �� 5w      .R�5x   "   �� 
��� ���$��0��6@   $ Parent.FirstName��5y   #   $ 0��5z   !   $	��120��5{   !   ��5|   !   �� *ParentStudents+5}      5        5�      $
 Remove��6-    5�      �� 5�      .R�5�   "   � $	��100��6'   $��30��63    5�   &   �� 5�   *   �� 5�   *   .+�5�   &   �� -   5        $��0��5�   -   $��2q�5�   !   $��25��5�   !   $��25��5�   !   $��-3q�5�   !   ���#97a97c���#97a97c#��[  5�   !   ��5�   !     $ Remove=�5�   !   5�   #   5�      5�      5�      5�      5�      5�      