   M S B A M L   `   `   `  ����  PolicijskaStanica)    #PolicijskaStanica.ListaOsumnjicenih   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  ListaOsumnjicenih��5   	   $��640.5��6#   $	��926��62    � 
ResizeMode$ CanMinimize=�5   	    � WindowStartupLocation$ CenterScreen=�6"   .��5      � .+�5   
   � $
��Left=�6   $	��609��6*   $	��Top=�67   $	��918��6O    � ColumnDefinitions 5      �� 5	      .+�5      &   System.Windows.Controls.DataGrid  -   5        $��	dataGrid1��5      $
��Left=�6)   $	��Top=�6D   $	��542��6\   $	��918��6i      
IsReadOnly . 6�   �� 5      -   5         ��Name$ button_nazad��5      $��Nazad��6+   $
��Left=�6;   $��782,559,0,0q�6V   $	��Top=�6k   $��94��6�   $��31��6�   �� 5      -   5         ��Name$ textBox_pretraga��5      $
��Left=�60   $��32��6K   $��
26,559,0,0q�6W    �� TextWrapping$
 Wrap=�6k   $	��Top=�6   $	��126��6�   6�   �� 5      -   5        $ button_pretraga��5      $��Pretraga��6.   $
��Left=�6A   $��170,559,0,0q�6\   $	��Top=�6q   $��90��6�   $��31��6�   6�   5      5      5      