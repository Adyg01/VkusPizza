   M S B A M L   `   `   `  ����D  @VkusPizza, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:VkusPizza.PagesVkusPizza.Pages  5           VkusPizza.Pages.OrdersPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:VkusPizza.Pages     5      -   5          N� Title$  
OrdersPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��40 �6   6*   �� 5      $��* �6   6)   �� 5      $��50 �6   6*   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   .+�5      �� $ 
Horizontal=�6   .+�5      �� $��Поиск:��6   $��Center=�6*   6G   �� 5      -   5         ��Name$ txtBoxSearch��5      $��33,0,0,0q�60   6k   5      5      �� 5   
   -   5        $��labelSearchBad��5   �   $��1��6   $��Center=�6   $��Center=�6:   $H��BПо вашему запросу ничего не найдено!��6U   6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��
dGridOrder��5   <   $��1��6      AutoGenerateColumns .     
IsReadOnly . $	��Top=�6`      RowHeaderWidth$ 0Q�6x   ��5      �� 5       �� 
TargetType)  #System.Windows.Controls.DataGridRow"  6    �� Triggers 5      �� 5      	 �� Binding	 6&   �� *
IdStatus+
 �� Value
 16C   .a�5      ��  �� Property � �� �� Value
 �����6;   5      �� 5       	 6&   �� *
IdStatus+
 26C   .a�5!      ��  � �� �	#FFD63A246;   5"      �� 5#      	 6&   �� *
IdStatus+
 36C   .a�5$      ��  � �� �	#FF23E61A6;   5%      5'         Columns 5)      0  *System.Windows.Controls.DataGridTextColumn  5*      ,  &System.Windows.Controls.DataGridColumn   Header$ Номер заказа��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6R   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *Id+6^     5+      $ Имя заказчика��6%   $ * 6]    6<   �� *CustomerName+6i     5,      $! Номер телефона��6%   $ * 6_    6=   �� *CustomerPhone+6k   4  .System.Windows.Controls.DataGridTemplateColumn  5-      $! Адрес доставки��6)   $ * 6A      CellTemplate 5.      �� 5/      .R�50      �  51   "   �� 52   &   66   �� 53   &   66   �� 54   &   66   .+�56   "   �� $��0��6L   ��6,   �� *DeliveryStreet+6[   �� 57   "   $��1��6J   ��6,   �� *DeliveryHome+6Y   58      59      5;        5<      $ Стоимость��6%   $ * 6Q    68   �� *Cost+6]     5=      $&  Дата\время заказа��6%   $ * 6]    6@   �� *
DateTime+6i     5>      $! Вариант оплаты��6%   $ * 6h    6=   �� *PaymentMethod.Payments+6t     5?       5@      �� 5A      .R�5B      �� $��btnReEditOrder��6C   -   5        $+��%Редактировать заказ��5B   %   6x   5C      5E      5G      �� 5H   
   -   5        $��btnEditOrder��5H      $��2��6   $!��Добавить заказ��62   $��Bottom=�6K   $
��Left=�6f   6�   �� 5I   
   -   5        $��btnDeleteOrder��5I      $��2��6   $!��Отменить заказ��64   $��Bottom=�6M   $��Right=�6h   6�   �� 5J   
   -   5        $��btnCompleteOrder��5J      $��2��6   $#��Завершить заказ��66   $��Bottom=�6P   $��Center=�6k   6�   5K      5L      