   M S B A M L   `   `   `  ����O  KPopulation-Database2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Population_Database2Population_Database2  5   	   %    Population_Database2.MainWindow   5	      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5
   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Population_Database2     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5      �  � RowDefinitions 5   
   �� 5      $
��1.5* �6   �� 5      $��5* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $
��1.5* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��Population Database��6   $��0��6.   $��2��6;   $��Center=�6O   $��16(�6s   $��5q�6�   $
��Bold"�6�   
�������
���   �$��2q�6�   �� 5   
   -   5        $��BtnSortPopDesc��5      $ ��Sort Population Descending��6'   $��4��6L   $��0��6Y   $��10q�6i   6u   �� 5   
   -   5        $��BtnSortCityName��5      $��Sort by City Name��6(   $��4��6D   $��1��6Q   $��10q�6a   6m   �� 5    
   $��Average Population��6   $��2��6-   $��0��6:   $��Center=�6J   $
��Bold"�6n   �� 5!   
   $��Minimum Population��6   $��3��6-   $��0��6:   $��Center=�6J   $
��Bold"�6n   �� 5"   
   $��2��63   $��1��6@   ��6   �� *AvgPopulation+6@   �� 5#   
   $��3��63   $��1��6@   ��6   �� *MinPopulation+6@   �� 5$   
   -   5        $��LstDatabase��5$      $��1��6%   $��2��62   $��10q�6F   $��Stretch=�6s   $��2q�6�   
���   ���6R   �� *
CityList+��5%      �� 5&      .R�5'      �  5(      �� 5)      $��* �6/   6;   �� 5*      $��* �6/   6;   .+�5,      �� $��0��6    ��60   �� *City+�� 5-      $��1��6    ��60   �� *
Population+5.      5/      51      52      53      