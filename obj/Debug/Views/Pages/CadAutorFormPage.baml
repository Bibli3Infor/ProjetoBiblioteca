   M S B A M L   `   `   `  ����L  HSystem-Biblioteca, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:System_Biblioteca.Views.PagesSystem_Biblioteca.Views.Pages  5      4    .System_Biblioteca.Views.Pages.CadAutorFormPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =local+clr-namespace:System_Biblioteca.Views.Pages     5        N� Title$  CadAutorFormPage��5	      .��5      � 
����� � � RowDefinitions 5   
   �� 5      $	��120 �6   �� 5      $��* �6   �� 5      $	��180 �6    � ColumnDefinitions 5   
   �� 5      $	��120 �6   �� 5      $��* �6   �� 5      $	��120 �6   .+�5   
   �� $��1��6   $��1��6"   $
��Left=�62    �� Orientation$ Vertical=�6M   .+�5      �� $��Nome do Autor:��6   $��20(�6.   $��0 0 0 0q�6<   �� 5      -   5         ��Name$ txtNomeAutor��5      $	��700��6,   $
��Left=�68   $��0 10 0 0q�6S   $��8q�6e   �� 5      $��Email:��6   $��20(�6&   $��0 30 0 0q�64   �� 5      -   5        $ txtEmailAutor��5      $	��700��6-   $
��Left=�69   $��0 10 0 0q�6T   $��8q�6f   �� 5       $��20(�6   $��0 30 0 0q�6&   �� 69    � Language$ pt-br�6=   $�Contato��6N   �� 6_   $�:��6c   6o   �� 5!      -   5        $ txtContatoAutor��5!      $	��550��6/   $
��Left=�6;   $��0 10 0 0q�6V   $��8q�6h   �� 5#      $��Sexo:��6   $��20(�6%   $��0 30 0 0q�63   �� 5$      $ 
Horizontal=�6   $��0 10 0 0q�62   .+�5%      	� -   5         	�Name$ rdbtFemininoAutor��5%      $��Feminino��69   $��15(�6L   $��0 0 0 0q�6Z   	� 5&      -   5        $ rdbtMasculinoAutor��5&      $��	Masculino��6:   $��15(�6N   $��50 0 0 0q�6\   5'      5(      �� 5*   
   $��1��6   $��1��6"   $��Right=�62   $ Vertical=�6N   $��0 0 60 0q�6e   .+�5,      �� $��Nacionalidade��6   $��20(�6-   $��	110 0 0 0q�6;   �� 5-      -   5        $ txtNacionalidadeAutor��5-      $	��300��65   $��Right=�6A   $��0 10 0 0q�6]   $��8q�6o   �� 5/      $��Data de Nascimento:��6   $��20(�63   $��0 30 0 0q�6A   (  "System.Windows.Controls.DatePicker  50      -   5          Name$ dtpDataNascAutor��50      
�������$	��300��6F   $��10q�6R   $
��Left=�6_   $��0 10 0 0q�6z   51      �� 53   
   $��2��6   $��1��6"   $ 
Horizontal=�62   $��Right=�6K   .+�54      �� $��Center=�6   $��Center=�62    �� CornerRadius$ 20��6M   ���	#FFCE1919$	��109��6w   $��44��6�   ._�55      �� -   5        	 ��Name$	 btnCancelarFun��55      $��Cancelar��61   $��15(�6D   $��8q�6R   $��90��6^   
 � Cursor$

 Hand��6i   ���	#FFCE1919$
��Bold"�6�   ���	#00707070
�������$��10,2,9,2q�6�   ��56      �� 57       �� 
TargetType" ��6*   .R�58      ��  ��Name$ border��6%   #��z��65   #��z��6_   #��z��6�   ._�59   "   �� $��Center=�63   $��Center=�6P   5:      5;      5=      5>      �� 5?      $��Center=�6   $��Center=�62   $ 20��6M   ���	#FF00E800$	��109��6w   $��44��6�   $��	50 0 60 0q�6�   ._�5@      �� -	   5        $	 btnSalvarAutor��5@      ���	#FF00E800$��Salvar��6H   $��15(�6Y   $��8q�6g   $��90��6s   $��40��6~   $

 Hand��6�   $
��Bold"�6�   ���	#00707070
���������5A      �� 5B      " ��6*   .R�5C      �� $ border��6%   #��z��65   #��z��6_   #��z��6�   ._�5D   "   �� $��Center=�63   $��Center=�6P   5E      5F      5H      5I      5J      5K      5L      