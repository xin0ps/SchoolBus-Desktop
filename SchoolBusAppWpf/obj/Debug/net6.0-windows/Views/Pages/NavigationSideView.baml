   M S B A M L   `   `   `  ����J  FSchoolBusAppWpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:SchoolBusAppWpf.Views.PagesSchoolBusAppWpf.Views.Pages  5      4    .SchoolBusAppWpf.Views.Pages.NavigationSideView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:SchoolBusAppWpf.Views.Pages     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  NavigationSideView��5
       � 	Resources 5         CustomButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius �� Triggers P� Property	 P� Value
 �� ScaleX �� ScaleY��%�  &	        �� 5   
   " ��6*   .�5      ��  � ��$ 0,20,0,0q�6'   �� 5       � ��
 � ���6+   �� 5       � ��$ SemiBold"�6+   �� 5       � ��$ 40��6'   �� 5       � ��$	 200��6&   �� 5       � ��
 �����6+   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   
�������$��2q�5      $ 	20,0,20,0��5      ._�5      �� $��Center=�6/   $��Center=�6L   5      5      5       5       P� 5!       � ��$
	 True��6/   . �5"      ��  � z� 5#      �� 5$      $	
 1.1Q�6-   $	 1.1Q�6:   5&      5'      5)      5*      .��5,      �  � ColumnDefinitions 5/   
   �� 50      $
��0.4* �6   �� 51      $��* �6   .+�54   
   � $��0��6   
������� � RowDefinitions 56      �� 57      $
��0.3* �6    �� 58      $��* �6    .+�5:      � $��0��6   
�������.+�5;      �� $
��Fill=�6   $��/Statics/busnav2.png��6(   6H   5<      �� 5>      $ 	40,40,0,0��6   $��
10,0,15,15q�6.   $��1��6B   
��� ���._�5A      �� $��0,25,0,0q�6   .+�5D      �� $��Create Rides��5E      #��[  5F      ��5H      �� *CreateRideCommand+��5I      ��  �� ElementName$ 
InnerFrame�� �� Path$ Content�5K      �� 5M      $��Rides��6   
��� ���#��[  5P      ��5R      �� *RidesCommand+��5S      �� $ 
InnerFrame��$ Content�5U      �� 5W      $��Class��6   #��[  5X      
��� ���$��0,20,0,0q�5[      ��5]      �� *ClassCommand+��5^      �� $ 
InnerFrame��$ Content�5`      �� 5b      $��Student��6   #��[  5c      ��5e      �� *StudentCommand+��5f      �� $ 
InnerFrame��$ Content�5h      �� 5j      $��Parent��6   #��[  6/   ��5k      �� *ParentCommand+��5l      �� $ 
InnerFrame��$ Content�5n      �� 5p      $��Driver��6   #��[  6/   ��5q      �� *DriverCommand+��5r      �� $ 
InnerFrame��$ Content�5t      �� 5v      $	��Car��6   #��[  6+   ��5w      �� *
CarCommand+��5x      �� $ 
InnerFrame��$ Content�5z      5~      5�      5�      � 5�   
   $��1��6   .+�5�       � -   5        $��
InnerFrame��5�      $��	3 10 3 10q�5�   
     � NavigationUIVisibility$ Hidden=�5�   
   ��5�   
   �� *CurrentView+ �� Mode$ TwoWay=�5�   
   5�      5�      5�      