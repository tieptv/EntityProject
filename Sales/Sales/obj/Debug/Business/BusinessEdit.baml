   M S B A M L   `   `   `  ����@  <Sales, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Sales.BusinessSales.Business  5   	   !    Sales.Business.BusinessEdit   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Sales.Business     5   	   V RMaterialDesignThemes.Wpf, Version=2.4.1.1101, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
        � Title$  BusinessEdit��5   	   $	��300��6   $	��600��6+      MaterialDesignPaper#���   5	   
     MaterialDesignBody#���  5      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignFont#���  5      .��5      �� $��1q�6   
���   �._�5   
   �  � RowDefinitions 5      �� 5      $
��Auto �6    60   �� 5      $
��Auto �6    61   �� 5      $
��Auto �6    60   .+�5      � $��0��6    � ColumnDefinitions 5      �� 5      6)   �� 5      6)   �� 5      6)   �� 5      6)   .+�5      �� $��Mã KH��6   $
��Left=�6*   $��10,0,0,0q�6E   $��0��6X   $��29��6h   �� 5       -   5        $��txtPRODUCT_CD��5       $
��Left=�6/   $��10,0,0,0q�6J   $	��120��6\   $��1��6h   $��29��6x   �� 5!      $
��Tên��6   $
��Left=�6(   $��10,0,0,0q�6C   $��2��6V   $��29��6f   �� 5"      -   5        $��
txtADDRESS��5"      $
��Left=�6,   $��10,0,0,0q�6G   $	��120��6Y   $��3��6e   $��29��6u   5#      � 5$      $��1��6    5%      �� 5&      6)   �� 5'      6)   �� 5(      6)   �� 5)      6)   .+�5+      �� $��Trạng thái��6   $
��Left=�6-   $��10,0,0,0q�6H   $��0��6\   �� 5,      $��Ngày hợp tác��6   $
��Left=�60   $��10,0,0,0q�6K   $��2��6a   �� 5-      -   5        $��txtCITY��5-      $��23��6)    �� TextWrapping$
 Wrap=�65   $
��Left=�6I   $	��120��6e   $��10,0,0,0q�6q   $��1��6�   �� 5.      -   5        $��txtCUSTYPECD��5.      $��23��6.   $
 Wrap=�6:   $
��Left=�6N   $	��120��6j   $��10,0,0,0q�6v   $��3��6�   5/      � 51      $��2��6    52      �� 53      6)   �� 54      6)   .+�56      �� $��OK��6   $	��113��6'   $��29��63   $��0,10,0,0q�6?   $��0��6Q   $��Right=�6a   �� 57      $��CANCEL��6   $	��113��6+   $��29��67   $��	10,10,0,0q�6C   $��1��6V   $
��Left=�6f   $	��Top=�6�   58      59      5:      5;      