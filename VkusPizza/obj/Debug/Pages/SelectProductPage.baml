   M S B A M L   `   `   `  ����D  @VkusPizza, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:VkusPizza.PagesVkusPizza.Pages  5      '    !VkusPizza.Pages.SelectProductPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:VkusPizza.Pages     5      -   5          N� Title$  SelectProductPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��80 �6   6*   �� 5      $��* �6   6)   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��Поиск:��6   $��Center=�6&   6C   �� 5      -   5         ��Name$ txtBoxSearch��5      $��28,0,0,0q�6,   6g   5      �� 5   
   -   5        $��btnAddOrderProduct��5      $��Добавить��6+   $��Right=�6>   6}   �� 5   
   -   5        $��labelSearchBad��5   �   $��1��6   $��Center=�6   $��Center=�6:   $H��BПо вашему запросу ничего не найдено!��6U   6�   �� 5   
   -   5        $��listViewProduct��5       $��1��6   $��Disabled=�67   $��Center=�6m   ��5      �� 5      .R�5      �  � Orientation$ 
Horizontal=�6    6;   5      ��5      �� 5      .R�5      � $��20q�6   $	��250��6'    5       �� 5!      6.   �� 5"      6.   �� 5#      6.   �� 5$      6.   �� 5%      6.   �� 5&      6.   �� 5'      6.   .+�5)      �� $	��250��6    $��1��6,   $��UniformToFill=�69   $
��Left=�6Q   $��5q�6l   ��5*      �� 5+   "    �� Path$ ProductPhoto.PhotoPath�6*   6J   5-      �� 5.      $ 
Horizontal=�6%   $��2��6>   .+�5/      �� $��Название: ��6(   $
��Left=�6:   6W   �� 50      $
��Left=�6?   ��6(   �� *Title+6\   51      �� 52      $ 
Horizontal=�6%   $��3��6>   .+�53      �� $��Описание: ��6(   $
��Left=�6:   6W   �� 54      $
��Left=�6E   ��6(   �� *Description+6b   55      �� 56      $��4��6%   $ 
Horizontal=�62   .+�57      �� $��
Цена: ��6(   $
��Left=�67   6T   �� 58      $
��Left=�6>   ��6(   �� *Cost+6[   59      5:      5;      5=      5>      5?      