   M S B A M L   `   `   `  ����D  @Reservoom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Reservoom.ViewsReservoom.Views  5      )    #Reservoom.Views.MakeReservationView   5      W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:Reservoom.Views     5      .��5	      �   � IsSharedSizeScope$
  True��6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��0��6    
  Header#��[  6!   $��Make Reservation��6A   � 5   
   $��1��6   $��0 25 0 0q�6    5      �� 5      $
��auto �6    �� 5      $
��auto �6    .+�5      �� $��0��6   $��Username��6%   �� 5      $��1��6   $��0 5 0 0q�6#   ��64   �� *
Username+ �� UpdateSourceTrigger$ PropertyChanged=�5      � 5!   
   $��2��6   $��0 10 0 0q�6    5"      �� 5#      $
��auto �6    �� 5$      $
��auto �6     � ColumnDefinitions 5&      �� 5'      $
��auto �6#    z� SharedSizeGroup$ FirstColumn��60   �� 5(      $
��auto �6#   $ SecondColumn��60   .+�5*      �� $��0��6   $��0��6%   $��	Floor No.��65   �� 5+      $��1��6   $��0��6#   $��0 5 0 0q�63   ��6D   �� *FloorNumber+$ PropertyChanged=��� 5-      $��0��6   $��1��6%   $��10 0 0 0q�65   $��Room No.��6G   �� 5.      $��1��6   $��1��6#   $��10 5 0 0q�63   ��6E   �� *
RoomNumber+$ PropertyChanged=�5/      � 54   
   $��3��6   $��0 10 0 0q�6    55      �� 56      $
��auto �6    �� 57      $
��auto �6     59      �� 5:      $
��auto �6#   $ FirstColumn��60   �� 5;      $
��auto �6#   $ SecondColumn��60   .+�5=      �� $��0��6   $��0��6%   $��
Start Date��65   (  "System.Windows.Controls.DatePicker  5>      $��1��6   $��0��6&   $��0 5 0 0q�66      SelectedDate 6G   �� *	StartDate+$ PropertyChanged=��� 5@      $��0��6   $��1��6%   $��10 0 0 0q�65   $��End Date��6G     5A      $��1��6   $��1��6&   $��10 5 0 0q�66    6H   �� *	EndDate+$ PropertyChanged=�5B      �� 5F   
   $��4��6   $��0 25 0 0q�6"    �� Orientation$ 
Horizontal=�64   .+�5G      �� $��Submit��67   ��6   �� *SubmitCommand+67   �� 5H      $��10 0 0 0q�67   $��Cancel��6I   ��6   �� *CancelCommand+6I   5J      5L      5M      