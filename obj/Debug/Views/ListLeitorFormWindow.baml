   M S B A M L   `   `   `  ����L  HSystem-Biblioteca, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:System_Biblioteca.ViewsSystem_Biblioteca.Views  5   	   2    ,System_Biblioteca.Views.ListLeitorFormWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:System_Biblioteca.Views     5   	   _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignBody#���   5	   	   $��Regular"�5
   	   $��10(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$ ListLeitorFormWindow��5   	   $	��600��6&   $
��1000��63   .��5      � 
����� � � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��* �6   .+�5   
   �� $��0��6   .+�5      �� $��Lista de Leitores��6   $��22(�61   ���	#FFC0DAF7 $  MaterialDesignHeadline4TextBlock#��[ 5       �� Padding$ 1q�5      5      &   System.Windows.Controls.DataGrid  5    
   -   5          Name$ dataGridLeitor��5       $��1��6+      
IsReadOnly . 
�������   AutoGenerateColumns .  	   Columns	 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      ,  &System.Windows.Controls.DataGridColumn
   Header$

 Nome��6%      
Foreground
 �   �   FontSize$ 18Q�6e      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6s   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *
NomeLeitor+6s     5#      $
 Email��6%   
 �   �$ 18Q�6g   $	 100 6u    64   �� *EmailLeitor+6u     5$      $	
 Cpf��6%   
 �   �$ 18Q�6c   $	 100 6q    62   �� *	CpfLeitor+6q     5%      $
 Rg��6%   
 �   �$ 18Q�6a   $	 100 6o    61   �� *
RgLeitor+6o     5&      $
 Telefone��6%   
 �   �$ 18Q�6m   $	 100 6{    67   �� *TelefoneLeitor+6{   5(      5)      5*      