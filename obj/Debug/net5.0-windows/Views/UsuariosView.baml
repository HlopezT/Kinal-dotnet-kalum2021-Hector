   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3ffCclr-namespace:MahApps.Metro.Controls.Dialogs;assembly=MahApps.MetroMahApps.Metro.Controls.Dialogs  5      D @kalum2021, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:kalum2021	kalum2021 5   	   V;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5	   	   "   kalum2021.Views.UsuariosView   5      R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   VDialogCclr-namespace:MahApps.Metro.Controls.Dialogs;assembly=MahApps.Metro     5      )localclr-namespace:kalum2021     5   	   Kmah;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5	   	     � Title$  Lista de Usurios��5   	    � WindowStartupLocation$ CenterScreen=�6"   $	��450��6G   $	��800��6T   8   2MahApps.Metro.Controls.Dialogs.DialogParticipation   Register 5      �� .��5      �  � RowDefinitions 5   
               �� 5                   �� 5      $��40 �6    � ColumnDefinitions 5   
               �� 5      .+�5   "   .+�5   
      &   System.Windows.Controls.DataGrid  $��10q�6      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6      CanUserAddRows$ False��6/   $��0��6l   $��0��6y      AutoGenerateColumns$ False��6�    �� SelectedItem 6F   �� *Seleccionado+��6�   �� *
usuarios+	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 	Apellidos��6K      
IsReadOnly$
 true��6^   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6-   �� *	Apellidos+6^     5      $
 Nombres��6I   $
 true��6Z    6-   �� *	Nombres+6Z   4  .System.Windows.Controls.DataGridCheckBoxColumn  5      $
 Activo��6M   $
 true��6]    61   �� *	Enabled+6]     5      $
 Username��6J   $
 true��6\    6-   �� *
Username+6\     5      $
 Email��6G   $
 true��6V    6-   �� *Email+6V   5      �� 5   
   $��1��6   $��0��6"    �� Orientation$ 
Horizontal=�62   .+�5      �� $��Nuevo��6   $��Nuevo��6H   $��5q�6a   ��6*   �� *	Instancia+6a   �� 5      $��Eliminar��6   $��Eliminar��6K   $��5q�6g   ��6-   �� *	Instancia+6g   �� 5       $��	Modificar��6   $��	Modificar��6L   $��5q�6i   ��6.   �� *	Instancia+6i   5!      5"      5#      