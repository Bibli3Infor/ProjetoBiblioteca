   M S B A M L   `   `   `  ����L  HSystem-Biblioteca, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:System_Biblioteca.ViewsSystem_Biblioteca.Views  5   	   &     System_Biblioteca.Views.CadLivro   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:System_Biblioteca.Views     5   	     � Title$  CadLivro��5   	   $
��1080��6   $
��1920��6(    � WindowState$ 	Maximized=�65   $��0,0,0,0q�6M   $��4,0,0,0q�6_    c� OverflowMode$ AsNeeded=�6p   .��5	      � 
������� � RowDefinitions 5
   
   �� 5      $	��120 �6   �� 5      $��* �6   �� 5      $	��180 �6    � ColumnDefinitions 5   
   �� 5      $	��120 �6   �� 5      $��* �6   �� 5      $	��120 �6   .+�5   
   �� $��1��6   $��1��6"   $
��Left=�62    �� Orientation$ Vertical=�6M   .+�5      �� $��Título:��6   $��20(�6'   $��0 0 0 0q�65   �� 5      -   5         ��Name$ txtTituloLivro��5      $	��800��6.   $
��Left=�6:   $��0 10 0 0q�6U   $��8q�6g   �� 5      $��Autor:��6   $��20(�6&   $��0 30 0 0q�64   �� 5      -   5        $ txtAutorLivro��5      $	��800��6-   $
��Left=�69   $��0 10 0 0q�6T   $��8q�6f   �� 5      $��Localização:��6   $��20(�6,   $��0 30 0 0q�6:   �� 5      -   5        $ txtLocalLivro��5      $	��800��6-   $
��Left=�69   $��0 10 0 0q�6T   $��8q�6f   �� 5       $��Sinopse:��6   $��20(�6(   $��0 30 0 0q�66   �� 5!      -   5        $ txtSinopiseLivro��5!      $
��1240��60   $
��Left=�6=   $��0 10 0 0q�6X   $��8q�6j   $	��119��6v   5#      �� 5%   
   $��1��6   $��1��6"   $��Right=�62   $ Vertical=�6N   $��0 0 60 0q�6e   .+�5)      �� $��Código:��6   $��20(�6'   $��	110 0 0 0q�65   �� 5*      -   5        $ txtCodLivro��5*      $	��300��6+   $��Right=�67   $��0 10 0 0q�6S   $��8q�6e   �� 5,      $��Data de Nascimento:��6   $��20(�63   $��0 30 0 0q�6A   (  "System.Windows.Controls.DatePicker  5-      -   5          Name$ dtpDataNascLei��5-      
�������$	��300��6D   $��10q�6P   $
��Left=�6]   $��0 10 0 0q�6x   �� 5/      $��	Edição:��6   $��20(�6'   $��
110 30 0 0q�65   �� 50      -   5        $ txtCodAcessLei��50      $	��300��6.   $��Right=�6:   $��0 10 0 0q�6V   $��8q�6h   51      �� 53   
   $��2��6   $��1��6"   $ 
Horizontal=�62   $��Right=�6K   .+�54      �� -   5         ��Name$ btnCancelarLivro��54      $��Cancelar��6/   $��15(�6B   $��8q�6P   $	��109��6\   $��44��6h   	 � Cursor$
	 Hand��6t   ���	#FF003DFF$
��Bold"�6�   �� 55      -	   5        $ btnSalvarLivro��55      ���	#FF00E800$��Salvar��6D   $��15(�6U   $��8q�6c   $	��109��6o   $��44��6{   $��	50 0 60 0q�6�   $
	 Hand��6�   $
��Bold"�6�   56      57      58      