   M S B A M L   `   `   `  ����@  <Sales, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Sales.IndividualSales.Individual  5   	   %    Sales.Individual.IndividualEdit   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Sales.Individual     5   	   V RMaterialDesignThemes.Wpf, Version=2.4.1.1101, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
        � Title$  IndividualEdit��5   	   $	��300��6    $	��600��6-      MaterialDesignPaper#���   5	   
     MaterialDesignBody#���  5      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignFont#���  5      .��5      �� $��1q�6   
���   �._�5   
   �  � RowDefinitions 5      �� 5      $
��Auto �6    60   �� 5      $
��Auto �6    61   �� 5      $
��Auto �6    61   .+�5      � $��0��6    � ColumnDefinitions 5      �� 5      6)   �� 5      6)   �� 5      6)   �� 5      6)   .+�5      �� $��Cust ID��6   $
��Left=�6,   $��10,0,0,0q�6G   $��0��6Z   $��29��6j   �� 5       -   5        $��	txtCustID��5       $
��Left=�6+   $��10,0,0,0q�6F   $	��120��6X   $��1��6d   $��29��6t   �� 5!      $��
Ngày sinh��6   $
��Left=�6.   $��10,0,0,0q�6I   $��2��6\   $��29��6l   (  "System.Windows.Controls.DatePicker  5"      -   5        $��	Birthdate��5"      $
��Left=�6.   $��10,0,0,0q�6I   $	��120��6[   $��3��6g   $��29��6w   5#      � 5$      $��1��6    5%      �� 5&      6)   �� 5'      6)   �� 5(      6)   �� 5)      6)   .+�5+      �� $
��Họ��6   $
��Left=�6%   $��10,0,0,0q�6@   $��0��6T   �� 5,      $
��Tên��6   $
��Left=�6'   $��10,0,0,0q�6B   $��2��6X   �� 5-      -   5        $��txtFirstname��5-      $��23��6.    �� TextWrapping$
 Wrap=�6:   $
��Left=�6N   $	��120��6j   $��10,0,0,0q�6v   $��1��6�   �� 5.      -   5        $��txtLastname��5.      $��23��6-   $
 Wrap=�69   $
��Left=�6M   $	��120��6i   $��10,0,0,0q�6u   $��3��6�   5/      � 50      $��2��6    51      �� 52      6)   �� 53      6)   .+�55      �� -   5        $��btnOK��55      $��OK��6&   $��80��64   $��29��6?   $��0,10,0,0q�6K   $��0��6]   $��Right=�6m   6�   �� 56      -   5        $��	btnCancel��56      $��CANCEL��6*   $��80��6<   $��29��6G   $��	10,10,0,0q�6S   $��1��6f   $
��Left=�6v   $	��Top=�6�   6�   57      58      59      5:      