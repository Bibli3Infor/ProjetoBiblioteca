   M S B A M L   `   `   `  ����L  HSystem-Biblioteca, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:System_Biblioteca.Views.PagesSystem_Biblioteca.Views.Pages  5      5    /System_Biblioteca.Views.Pages.FavoritosFormPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =local+clr-namespace:System_Biblioteca.Views.Pages     5        N� Title$  FavoritosFormPage��5	      .��5      � 
����� � � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��* �6   �� 5      $	��120 �6    � ColumnDefinitions 5   
   �� 5      $	��180 �6   �� 5      $��* �6   �� 5      $	��180 �6   .+�5   
   �� $��1��6   $��1��6"   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��	FAVORITOS��6   $	��180��6,   $
��Bold"�68   $��22(�6J   $��80 0 0 0q�6X   $��46��6j   5      �� 5      $��80��6   $
��Bold"�6#   $��30(�65   $��0 0 0 10q�6C   $��80��6U   ��5      �� 5       �� ImageSource$ /Views/Pages/favorito.png��6%   5!      5"      �� 5%      $ Vertical=�6   $��Center=�60   $��Center=�6K   .+�5'      �� $��Center=�6   $ 
Horizontal=�6:   .+�5)      �� $��	150 0 0 0q�6!   $	��609��64   .+�5*      �� $��25(�6$   $��Center=�62   $��0 0 0 0q�6O   $��Normal"�6`   �� 6u    � Language$ pt-br�6y   $�Pesquisar Gênero:��6�   6�   �� 5+      -   5         ��Name$ 	cbmGenero��5+   #   $	��605��66   $��35��6B   $��Center=�6N   5,      �� 5-      $��Center=�6!   $��0 20 0 0q�6<   .+�5.      �� $��Center=�6!   $��Center=�6>    �� CornerRadius$ 20��6Y   $��70��6l   $��70��6w   $��	50 0 60 0q�6�   
�������._�5/      �� -   5         ��Name$ btnPesquisar��5/   %   $��15(�6<   $��8q�6J   $��60��6V   $��60��6a   	 � Cursor$
	 Hand��6n   $
��Bold"�6|   ���	#00707070$��0 0 0 0q�6�   
���������50   "   �� 51   &   $% /Views/Pages/pesquisar icon.png��61   ��53   "   �� 54   &   
 �� 
TargetType"
 ��66   .R�55   *   ��  ��Name$ border��61   #��z��6A   #��z��6k   #��z��6�   ._�56   .   �� $��Center=�6?   $��Center=�6\   57   +   58   '   5:      5;      5<      5>      �� 5?      $/��)Livros mais alugados com base no gênero:��6   $
��Left=�6K   $��24(�6f   $
��Bold"�6t   $��0 10 0 0q�6�   &   System.Windows.Controls.DataGrid  5@      $	��928��6   $	��349��6'   5B      5G      5J      5K      5L      