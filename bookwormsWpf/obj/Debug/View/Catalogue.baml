   M S B A M L   `   `   `  ����G  CbookwormsWpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:bookwormsWpf.ViewbookwormsWpf.View  5   	   !    bookwormsWpf.View.Catalogue   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:bookwormsWpf.View     5   	     � Title$  	Catalogue��5   	   $	��450��6   $	��800��6(   $	��500��64   $	��460��6D   $	��600��6S   $
��1400��6c   .��5	      � ���#EEEEEE � RowDefinitions 5
   
   �� 5      $	��18* �6   �� 5      $	��10* �6   �� 5      $
��150* �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   .+�5      �� $��0��6   $��\Resources/logo.png��6$   $��60��6A   �� 5      $��1��6   $��	Catalogue��6(      
headerText#��[  69   �� 5      -   5         ��Name$ fromAuthorisetoMain��5      $��2��62     simpleButton#��[ 6e   ��5      �� 5       �� Orientation$ 
Horizontal=�6!   .+�5      �� $��	Main menu��6$     anyTextBlock#��[ 65   �� 5      $��\Resources/exit.png��6    $��50��6=   5      5       5!      � 5"   
   $��1��6    5#      �� 5$      $��* �6#   �� 5%      $��* �6#   �� 5&      $��* �6#   .+�5(      �� -   5        $��cbSort��5(      $��0��6%   $��2��6`   $
��Left=�6t   $	��267��6�   .@�5)      �� $/��)без сортировки по цене��6   �� 5*      $+��%по возрастанию цены ��6   �� 5+      $$��по убыванию цены��6   5,      �� 5-      -   5        $��cbGenre��5-      $��1��6&   $��2��6c   $
��Left=�6w   $	��267��6�   5.      �� 5/      -   5         ��Name$ tbSearch��5/      $��2��6(   68   51      � 52   
   $��2��6   .+�53      &   System.Windows.Controls.DataGrid  -   5          Name$ dgItem��53      $��2��6'      AutoGenerateColumns .     
IsReadOnly . 	   Columns	 54      0  *System.Windows.Controls.DataGridTextColumn  55      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Title��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$	 200 68   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6E   �� *
ItemName+  56      $
 Genre��6)   $	 180 68    6D   �� *Genre.GenreName+  57      $
 Author's name��6)   $ * 6@    6J   �� *Author.AuthorName+  58      $
 Surname��6)   $ * 6:    6D   �� *Author.AuthorSurname+  59      $
 Price��6)   $ * 68    6B   �� *
ItemCost+5;      5<      5L      5M      