   M S B A M L   `   `   `  ����D  @VkusPizza, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:VkusPizza.PagesVkusPizza.Pages  5          VkusPizza.Pages.UsersPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:VkusPizza.Pages     5      -   5          N� Title$  	UsersPage��5	      .��5
      �  � RowDefinitions 5   
   �� 5      $��80 �6   6*   �� 5      $��* �6   6)   �� 5      $��50 �6   6*   .+�5   
   �� $��0��6   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��Поиск:��6   $��Center=�6*   6G   �� 5      -   5         ��Name$ txtBoxSearch��5      $��33,0,0,0q�60   6k   5      �� 5      $ 
Horizontal=�6   .+�5      �� $��Сортировка:��6   $��Center=�6/   6L   �� 5      -   5        $��comboFilter��5   3   $	��175��6   $��30��6'   6x   5      5      �� 5   
   -   5        $��labelSearchBad��5   �   $��1��6   $��Center=�6   $��Center=�6:   $H��BПо вашему запросу ничего не найдено!��6U   6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��	dGridUser��5   /      AutoGenerateColumns .     
IsReadOnly . $	��Top=�6R   $��1��6j      RowHeaderWidth$ 0Q�6w      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$% Имя пользователя��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6]   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6?   �� *	FirstName+6i     5      $- 'Фамилия пользователя��6%   $	 * 6_   
 6C   �� *	Surname+6k     5      $ 
Логин��6%   $	 * 6N   
 64   �� *Login+6Z     5       $ Пароль��6%   $	 * 6R   
 65   �� *
Password+6^     5!      $% Тип пользователя��6%   $	 * 6]   
 6?   �� *	Role.Name+6i   4  .System.Windows.Controls.DataGridTemplateColumn  5"         CellTemplate 5#      �� 5$      .R�5%      �� $��btnRePassUser��6?   -   5        $#��Изменить данные��5%   %   6r   5&      5(      5*      �� 5+   
   -   5        $��btnEditUser��5+      $��2��6   $��Bottom=�61   $
��Left=�6L   $��Добавить��6g   6�   �� 5,   
   -   5        $��btnDeleteUser��5,      $��2��6   $��Bottom=�63   $��Right=�6N   $��Удалить��6j   6�   5-      5.      