   M S B A M L   `   `   `  ����^  ZРеализация проекта, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:Реализация_проекта#Реализация_проекта  5   	   M    GРеализация_проекта.Рассчет_параметров   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Clocal1clr-namespace:Реализация_проекта     5   	     � Title$  Помощник Васи��5      $	��450��6'   $	��800��64   
���k���.��5	      �  � RowDefinitions 5
   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   .+�5   
   �� -   5         ��Name$	 tbA��5   /   $��2��6   $��1��6   $��Center=�6<   $��Center=�6^   $��16(�6�   6�   �� 5   
   $��2��6   $��Center=�6   $��Center=�6?   $��18(�6c   .��6q   A ->6w   �� 5   
   -   5        $	 tbB��5   /   $��2��6   $��3��6   $��Center=�6<   $��Center=�6^   $��16(�6�   6�   �� 5   
   $��2��6   $��2��6   $��Center=�6-   $��Center=�6O   $��18(�6s   .��6�   B->6�   �� 5   
   -   5        $	 tbD��5   /   $��2��6   $��5��6   $��Center=�6<   $��Center=�6^   $��16(�6�   6�   �� 5   
   $��2��6   $��4��6   $��Center=�6-   $��Center=�6O   $��18(�6s   .��6�   D->6�   �� 5    
   $��18(�6   $��6��6"   $��Center=�66   $��Center=�6Q   ��А - является высотой окна в см, B - шириной окна в см, D - диаметр головы Васи в см.6�   �� 5!   
   -   5        $��2��5!      $��3��6!   $��2��6.   $��10q�6B   $��16(�6N   .��6q   Расчитать6|   �� 5"   
   -   5        $��2��5"      $��4��6!   $��2��6.   $��10q�6B   $��16(�6N   .��6r   " Вывести на печать6�   �� 5#   
   -   5        $��2��5#      $��5��6!   $	��160��6.   $��2��6:   $��10q�6N   $��16(�6Z   .��6~   
Назад6�   5%      5&      