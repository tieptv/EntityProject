   M S B A M L   `   `   `  ����@  <Sales, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Sales.Product_typeSales.Product_type  5   	   (    "Sales.Product_type.ProductTypeList   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Sales.Product_type     5   	   V RMaterialDesignThemes.Wpf, Version=2.4.1.1101, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
        � Title$  ProductTypeList��5   	   $
��Auto��6!   $	��800��6/      MaterialDesignPaper#���   5	   
     MaterialDesignBody#���  5      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignFont#���  5      .��5      �� $��1q�6   
���   �._�5   
   �  � RowDefinitions 5      �� 5      $
��Auto �6    60   �� 5      $
��Auto �6    60   �� 5      $
��Auto �6    60   �� 5      $
��Auto �6    60   .+�5      �� -   5        $��lvproduct_type��5       �� SelectionMode$ Single=�6.   $
��Auto��6F   $��	10,10,0,0q�6S   $��1��6f   $��2��6z   ��6�   �� *Product_typeLists+ �� SelectedItem 6�   �� *Product_typeObj+ �� Mode$ TwoWay=� �� View 5      �� 5      .P�5      �� $��Product__type CD��6)    �� Width$	 300��6C   	 �� DisplayMemberBinding	 6O   �� *PRODUCT_TYPE_CD+�� 5      $
��NAME��6)   $	 500��67   	 6C   �� *NAME+5!      5#      �� 5$      $��Product type��6   $��Center=�6+   $
��Auto��6J   $��20(�6W   $��0��6e   5%      � 5&      -   5        $��grCondition��5&      $��1��6&   .+�5'      �� -   5        $��	txtSearch��5'      $��31��6+   $
��Left=�67   $��	10,10,0,0q�6R   
 �� TextWrapping$

 Wrap=�6e   $��Tìm Kiếm��6y   $	��150��6�   $��0��6�   �� 5(      -   5        $��	btnSearch��5(      $��Tìm Kiếm ��6*   $
��Left=�6>    " MaterialDesignRaisedDarkButton#��[ 6Y   $��29��6�   $��
180,10,0,0q�6�   $
��Auto��6�   $��1��6�   ��5)      �� *FindCommand+$ OneWay=���6E   ��  �� ElementName$ grCondition��5*      � 5+      $��3��6    � ColumnDefinitions 5,      �� 5-      $��* �6'   63   �� 5.      $	��280 �6'   65   �� 5/      $��* �6'   63   .+�51      �� -   5        $��	btnInsert��51      $��Thêm��6*   #��[ 69   $��1��6q   $
��Left=�6�   $��0,10,0,0q�6�   $��29��6�   $��80��6�   ��52      �� *NewFormCommand+��6>   �� $ product_typelist���� 53      -   5        $��	btnUpdate��53      $��Sửa��6*   #��[ 69   $��1��6q   $
��Left=�6�   $��
100,10,0,0q�6�   $��29��6�   $��80��6�   ��54      �� *EditFormCommand+��6=   �� *SelectedItem+$ lvproduct_type���� 55      -   5        $��	btnDelete��55      $
��Xóa��6*   #��[ 69   $��1��6q   $
��Left=�6�   $��
200,10,0,0q�6�   $��29��6�   $��80��6�   ��56      �� *DeleteRowCommand+��6>   �� *SelectedItem+$ lvproduct_type��57      58      59      5:      