   M S B A M L   `   `   `  ����L  HSystem-Biblioteca, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:System_Biblioteca.ViewsSystem_Biblioteca.Views  5   	   +    %System_Biblioteca.Views.CadFornecedor   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:System_Biblioteca.Views     5   	     � Title$  CadFornecedor��5   	   $
��1080��6   $
��1920��6-    � WindowState$ 	Maximized=�6:   $��0,0,0,0q�6R   $��4,0,0,0q�6d    c� OverflowMode$ AsNeeded=�6u   .��5	      � 
������� � RowDefinitions 5
   
   �� 5      $	��120 �6   �� 5      $��* �6   �� 5      $	��180 �6    � ColumnDefinitions 5   
   �� 5      $	��120 �6   �� 5      $��* �6   �� 5      $	��120 �6   .+�5   
   �� $��1��6   $��1��6"   $
��Left=�62    �� Orientation$ Vertical=�6M   .+�5      �� $��Nome da Empresa:��6   $��20(�60   $��0 0 0 0q�6>   �� 5      -   5         ��Name$ txtNomeEmpresa��5      $	��800��6.   $
��Left=�6:   $��0 10 0 0q�6U   $��8q�6g   �� 5      $��E-mail:��6   $��20(�6'   $��0 30 0 0q�65   �� 5      -   5        $ txtEmailEmpresa��5      $	��800��6/   $
��Left=�6;   $��0 10 0 0q�6V   $��8q�6h   �� 5      $��
Endereço:��6   $��20(�6)   $��0 30 0 0q�67   �� 5      -   5        $ txtEnderecoEmpresa��5      $
��1240��62   $
��Left=�6?   $��0 10 0 0q�6Z   $��8q�6l   �� 5       $��	Telefone:��6   $��20(�6)   $��0 30 0 0q�67   �� 5!      -   5        $ txtTelefoneEmpresa��5!      $	��650��62   $
��Left=�6>   $��0 10 0 0q�6Y   $��8q�6k   5"      �� 5$   
   $��1��6   $��1��6"   $��Right=�62   $ Vertical=�6N   $��0 0 60 0q�6e   .+�5%      �� $��CNPJ:��6   $��20(�6%   $��	180 0 0 0q�63   �� 5&      -   5        $ txtCnpjEmpresa��5&      $	��300��6.   $��Right=�6:   $��0 10 0 0q�6V   $��8q�6h   �� 5(      $��Razão Social:��6   $��20(�6-   $��
180 30 0 0q�6;   �� 5)      -   5        $ txtRazaoEmpresa��5)      $	��300��6/   $��Right=�6;   $��0 10 0 0q�6W   $��8q�6i   �� 5+      $��
Descricao:��6   $��20(�6*   $��	0 123 0 0q�68   �� 5,      -   5        $ txtDescEmpresa��5,      $	��480��6.   $
��Left=�6:   $��0 10 0 0q�6U   $��8q�6g   $��86��6s   5.      �� 50   
   $��2��6   $��1��6"   $ 
Horizontal=�62   $��Right=�6K   .+�51      �� -   5         ��Name$ btnCancelarFor��51      $��Cancelar��6-   $��15(�6@   $��8q�6N   $	��109��6Z   $��44��6f    � Cursor$
 Hand��6r   ���	#FF003DFF$
��Bold"�6�   �� 52      -	   5        $ btnSalvarFor��52      ���	#FF00E800$��Salvar��6B   $��15(�6S   $��8q�6a   $	��109��6m   $��44��6y   $��	50 0 60 0q�6�   $
 Hand��6�   $
��Bold"�6�   53      54      55      