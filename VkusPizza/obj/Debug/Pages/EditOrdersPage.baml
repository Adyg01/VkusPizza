   M S B A M L   `   `   `  ����D  @VkusPizza, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:VkusPizza.PagesVkusPizza.Pages  5      $    VkusPizza.Pages.EditOrdersPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:VkusPizza.Pages     5      X TXceed.Wpf.Toolkit, Version=4.1.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5      -   5          N� Title$  EditOrdersPage��5
      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $	��250 �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��24(�6!   $��Имя заказчика��6/   6F   �� 5   
   $��1��6   $��24(�6!   $!��Номер телефона��6/   6G   �� 5   
   $��2��6   $��24(�6!   $��Адрес(улица)��6/   6E   �� 5   
   $��3��6   $��24(�6!   $��Адрес(дом)��6/   6C   �� 5    
   $��6��6   $��24(�6!   $��Стоимость��6/   6B   �� 5!   
   $��4��6   $��24(�6!   $&�� Дата\время заказа��6/   6J   �� 5"   
   $��5��6   $��24(�6!   $!��Вариант оплаты��6/   6G   �� 5#   
   $��7��6   $��24(�6!   $��
Товар��6/   6>   �� 5$   
   -   5        $��txtBoxOrderName��5$      $��1��6G   $��0��6W   $	��450��6d   ��6)   �� *CustomerName+6s   %  Xceed.Wpf.Toolkit.MaskedTextBox  5%   
   -   5        $��txtBoxOrderPhone��5%      $��1��6T   $��1��6d   $	��450��6q   $��30��6}      Mask$ +7(000)-000-0000��6�   ��65   �� *CustomerPhone+6�   �� 5&   
   -   5        $��txtBoxOrderStreet��5&      $��1��6K   $��2��6[   $	��450��6h   ��6+   �� *DeliveryStreet+6v   �� 5'   
   -   5        $��txtBoxOrderHouse��5'      $��1��6H   $��3��6X   $	��450��6e   ��6*   �� *DeliveryHome+6s   �� 5(   
   -   5        $��txtBoxOrderCost��5(      $��1��6?   $��6��6O   $	��450��6\   ��6)   �� *Cost+6j     5)   
   -   5        $��txtBoxOrderDateTime��5)      $��1��6t   $��4��6�   $	��450��6�   $ 00/00/0000 00:00:00��6�   $��30��6�   ��68   �� *
DateTime+ �� StringFormat$ dd.MM.yyyy HH:mm:ss��6�   �� 5*   
   -   5        $��comboBoxOrderPaymenth��5*       �� DisplayMemberPath$ Payments��60   $��1��6t   $��5��6�   $	��450��6�    �� SelectedItem 6M   �� *PaymentMethod+6�   �� 5+   
    �� Orientation$ 
Horizontal=�6   $��1��6.   $��7��6>   $��Center=�6K   .+�5,      �� -	   5        $��txtBoxOrderProduct��5,   (   {�.  $	��250��6[   ��6B   �� *	Product+6j   �� 5-      -
   5        $��btnAddProduct��5-      $!��Добавить товар��6F   6a   5.      �� 5/   
   -   5        $��btnUserSaveChanges��5/      $��Сохранить��6+   $��1��6?   $��8��6O   6   50      51      