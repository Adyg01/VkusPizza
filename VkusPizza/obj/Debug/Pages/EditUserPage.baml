   M S B A M L   `   `   `  ����D  @VkusPizza, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:VkusPizza.PagesVkusPizza.Pages  5      "    VkusPizza.Pages.EditUserPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:VkusPizza.Pages     5        N� Title$  EditUserPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $	��250 �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��24(�6!   $��Имя��6/   6<   �� 5   
   $��1��6   $��24(�6!   $��Фамилия��6/   6@   �� 5   
   $��2��6   $��24(�6!   $��
Логин��6/   6>   �� 5   
   $��3��6   $��24(�6!   $��Пароль��6/   6?   �� 5   
   $��4��6   $��24(�6!   $%��Тип пользователя��6/   6I   �� 5   
   -   5        $��txtBoxUserFirstName��5      $��1��6H   $��0��6X   $	��450��6e   ��6-   �� *	FirstName+6t   �� 5   
   -   5        $��txtBoxUserSurname��5      $��1��6D   $��1��6T   $	��450��6a   ��6+   �� *	Surname+6o   �� 5   
   -   5        $��txtBoxUserLogin��5      $��1��6@   $��2��6P   $	��450��6]   ��6)   �� *Login+6k   �� 5    
   -   5        $��txtBoxUserPass��5       $��1��6B   $��3��6R   $	��450��6_   ��6(   �� *
Password+6m   �� 5!   
   -   5        $��comboBoxUserType��5!       �� DisplayMemberPath$
 Name��6+   $��1��6b   $��4��6r   $	��350��6   $��35��6�    �� SelectedItem 6D   �� *Role+6�   �� 5"   
   -   5        $��btnUserSaveChanges��5"      $��Сохранить��6+   $��1��6?   $��5��6O   6   5#      5$      