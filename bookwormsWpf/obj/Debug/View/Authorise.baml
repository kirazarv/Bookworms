   M S B A M L   `   `   `  ����G  CbookwormsWpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:bookwormsWpf.ViewbookwormsWpf.View  5   	   !    bookwormsWpf.View.Authorise   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:bookwormsWpf.View     5   	     � Title$  	Authorise��5   	   $	��450��6   $	��800��6(   $	��500��64   $	��460��6D   $	��600��6S   $
��1400��6c   .��5	      � ���#EEEEEE � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   .+�5      �� $��0��6   $��\Resources/logo.png��6$   $��60��6A   �� 5      $��1��6   $��Authorisation��6(      
headerText#��[  6=   �� 5      -   5         ��Name$ fromAuthorisetoMain��5      $��2��62     simpleButton#��[ 6e   ��5      �� 5       �� Orientation$ 
Horizontal=�6!   .+�5      �� $��	Main menu��6$     anyTextBlock#��[ 65   �� 5      $��\Resources/exit.png��6    $��50��6=   5      5      5       � 5!   
   $��1��6    5"      �� 5#      $��* �6#   �� 5$      $��* �6#   .+�5&      �� $��0��6   
�������$��5q�6<   $��80 20q�6P   ._�5'      �� -   5        $��loginTextbox��5'      6.   5(      �� 5)      $��1��6   $��login��6(   $
��Left=�65   #��[ 6P   5+      � 5,   
   $��2��6    5-      �� 5.      $��* �6#   �� 5/      $��* �6#   .+�51      �� $��0��6   
�������$��5q�6<   $��80 20q�6P   ._�52      G� -   5         G�Name$ 
passwordPb��52      63   53      �� 54      $��1��6   $��password��6(   $
��Left=�68   #��[ 6S   55      � 56   
   $��3��6    57      �� 58      $��* �6#   �� 59      $��* �6#   .+�5;      �� $��0��6   
�������$��5q�6<    �� CornerRadius$ 40��6P   $��80 20q�6b   ._�5<      �� -   5        $ loginButton��5<      $��1��6.   $��login��6>     roundedButton#��[ 6i   5=      5?      5A      5B      