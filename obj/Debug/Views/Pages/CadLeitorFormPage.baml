   M S B A M L   `   `   `  ����L  HSystem-Biblioteca, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:System_Biblioteca.Views.PagesSystem_Biblioteca.Views.Pages  5      5    /System_Biblioteca.Views.Pages.CadLeitorFormPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =local+clr-namespace:System_Biblioteca.Views.Pages     5        N� Title$  CadLeitorFormPage��5	      .��5      � 
����� � � RowDefinitions 5   
   �� 5      $	��120 �6   �� 5      $��* �6   �� 5      $	��180 �6    � ColumnDefinitions 5   
   �� 5      $	��120 �6   �� 5      $��* �6   �� 5      $	��120 �6   .+�5   
   �� $��1��6   $��1��6"   $
��Left=�62    �� Orientation$ Vertical=�6M   .+�5      �� $��Nome Completo:��6   $��20(�6.   $��0 0 0 0q�6<   �� 5      -   5         ��Name$ 
txtNomeLei��5      $	��700��6*   $
��Left=�66   $��0 10 0 0q�6Q   $��8q�6c   �� 5      $��Email:��6   $��20(�6&   $��0 30 0 0q�64   �� 5      -   5        $ txtEmailLei��5      $	��700��6+   $
��Left=�67   $��0 10 0 0q�6R   $��8q�6d   �� 5      $��
Endereço:��6   $��20(�6)   $��0 30 0 0q�67   �� 5       -   5        $ txtEnderecoLei��5       $	��700��6.   $
��Left=�6:   $��0 10 0 0q�6U   $��8q�6g   �� 5"      $��	Telefone:��6   $��20(�6)   $��0 30 0 0q�67   �� 5#      -   5        $ txtTelefoneLei��5#      $	��550��6.   $
��Left=�6:   $��0 10 0 0q�6U   $��8q�6g   �� 5%      $��Sexo:��6   $��20(�6%   $��0 30 0 0q�63   �� 5&      $ 
Horizontal=�6   $��0 10 0 0q�62   .+�5'      	� -   5         	�Name$ rdbtFemininoLei��5'      $��Feminino��67   $��15(�6J   $��0 0 0 0q�6X   	� 5(      -   5        $ rdbtMasculinoLei��5(      $��	Masculino��68   $��15(�6L   $��50 0 0 0q�6Z   5)      5*      �� 5,   
   $��1��6   $��1��6"   $��Right=�62   $ Vertical=�6N   $��0 0 60 0q�6e   .+�5-      �� $
��CPF:��6   $��20(�6$   $��	110 0 0 0q�62   �� 5.      -   5        $ 	txtCpfLei��5.      $	��300��6)   $��Right=�65   $��0 10 0 0q�6Q   $��8q�6c   �� 50      $	��RG:��6   $��20(�6#   $��
110 30 0 0q�61   �� 51      -   5        $ txtRgLei��51      $	��300��6(   $��Right=�64   $��0 10 0 0q�6P   $��8q�6b   �� 53      $��Código de Acesso:��6   $��20(�61   $��
110 30 0 0q�6?   �� 54      -	   5        $ txtCodAcessLei��54      $	��300��6.   $��Right=�6:   $��0 10 0 0q�6V   $��8q�6h   �� 56      $��Data de Nascimento:��6   $��20(�63   $��0 30 0 0q�6A   (  "System.Windows.Controls.DatePicker  57      -
   5          Name$ dtpDataNascLei��57      
�������$	��409��6D   $��10q�6P   $
��Left=�6]   $��0 10 0 0q�6x   58      �� 5:   
   $��2��6   $��1��6"   $ 
Horizontal=�62   $��Right=�6K   .+�5;      �� $��Center=�6   $��Center=�62    �� CornerRadius$ 20��6M   ���	#FFCE1919$	��109��6w   $��44��6�   ._�5<      �� -   5         ��Name$ btnCancelarFun��5<      $��Cancelar��61   $��15(�6D   $��8q�6R   $��90��6^   	 � Cursor$
	 Hand��6i   ���	#FFCE1919$
��Bold"�6�   ���	#00707070
�������$��10,2,9,2q�6�   ��5=      �� 5>      
 �� 
TargetType"
 ��6*   .R�5?      ��  ��Name$ border��6%   #��z��65   #��z��6_   #��z��6�   ._�5@   "   �� $��Center=�63   $��Center=�6P   5A      5B      5D      5E      �� 5F      $��Center=�6   $��Center=�62   $ 20��6M   ���	#FF00E800$	��109��6w   $��44��6�   $��	50 0 60 0q�6�   ._�5G      �� -   5        $ btnSalvarLeitor��5G      ���	#FF00E800$��Salvar��6I   $��15(�6Z   $��8q�6h   $��90��6t   $��40��6   $
	 Hand��6�   $
��Bold"�6�   ���	#00707070
���������5H      �� 5I      "
 ��6*   .R�5J      �� $ border��6%   #��z��65   #��z��6_   #��z��6�   ._�5K   "   �� $��Center=�63   $��Center=�6P   5L      5M      5O      5P      5Q      5R      5S      