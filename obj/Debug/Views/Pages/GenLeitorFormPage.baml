   M S B A M L   `   `   `  ����L  HSystem-Biblioteca, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:System_Biblioteca.Views.PagesSystem_Biblioteca.Views.Pages  5      5    /System_Biblioteca.Views.Pages.GenLeitorFormPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =local+clr-namespace:System_Biblioteca.Views.Pages     5        N� Title$  GenLeitorFormPage��5	      .��5      � 
����� � � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��* �6   .+�5   
   �� $��0��6   .+�5      �� $��Lista de Leitores��6   $��25(�61   $��0 10 0 0q�6?   
����� �$��Center=�5       $   MaterialDesignHeadline4TextBlock#��[  5       �� Padding$ 1q�5      5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGridLeitor��5      $��1��6+      
IsReadOnly . 
�������   AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Nome��6%      
Foreground
 �   �	   FontSize$	 18Q�6e   
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 300 6s   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *
NomeLeitor+6s     5      $ Email��6%   
 �   �$	 18Q�6g   $	
 300 6u    64   �� *EmailLeitor+6u     5      $	 Cpf��6%   
 �   �$	 18Q�6c   $	
 200 6q    62   �� *	CpfLeitor+6q     5      $ Rg��6%   
 �   �$	 18Q�6a   $	
 150 6o    61   �� *
RgLeitor+6o     5       $ Telefone��6%   
 �   �$	 18Q�6m   $	
 200 6{    67   �� *TelefoneLeitor+6{   4  .System.Windows.Controls.DataGridTemplateColumn  5"      $ Ações��6)   $	
 150 68      CellTemplate 5#      �� 5$      .R�5%      ��  �� Orientation$ 
Horizontal=�6)   .+�5&   "   ��  ��Name$ btnExcluirLeitor��6)   -   5        
�������$��14(�5&   V   $��80��6d   $��Deletar��5(   )    � ToolTip$ Excluir Registro��5)   )   5*      5+      5-      5/      50      51      