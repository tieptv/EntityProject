   M S B A M L   `   `   `  ����	  Sales    Sales.Product.ProductList   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   V RMaterialDesignThemes.Wpf, Version=2.4.1.1101, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5        $��productlist��5   	     � Title$  ProductList��5   	   $
��Auto��6   $	��800��6+      MaterialDesignPaper#���   5   	     MaterialDesignBody#���  5      $��Regular"�5      $��13(�5	      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5
         TextRenderingMode$
 Auto=�5        MaterialDesignFont#���  5      .��5      �� $��1q�6   
���   �._�5   
   �  � RowDefinitions 5      �� 5      $
��Auto �6    60   �� 5      $
��Auto �6    60   �� 5      $
��Auto �6    60   �� 5      $
��Auto �6    60   .+�5      �� -   5        $��lvproductview��5   .    �� SelectionMode$ Single=�6   $
��Auto��6D   $��0,0,0,0q�6Q   $��1��6b   $��2��6v   ��6�   �� *ProductViewLists+ �� SelectedItem 6�   �� *ProductViewObj+ �� Mode$ TwoWay=� �� View 5      �� 5      .P�5      �� $��
Product CD��6)    �� Width$	 100��6=   	 �� DisplayMemberBinding	 6I   �� *
product_cd+�� 5      $
��Type��6)   $	 250��67   	 6C   �� *type+�� 5      $
��Name��6)   $	 200��67   	 6C   �� *name+�� 5      $��
Date Offer��6)   $	 100��6=   	 6I   �� *
date_offer+�� 5       $��Date Retire��6)   $	 100��6>   	 6J   �� *date_retire+5!      5#      �� 5$      $��Product��6   $��Center=�6&   $	��Top=�6C   $
��Auto��6[   
 J� RenderTransformOrigin$
 0.5,0.5&�6h   $��20(�6�   $��0��6�   5%      � 5&      -   5        $��grCondition��5&      $��1��6&   $��Bottom=�63   .+�5'      �� -   5        $��	txtSearch��5'      $��31��6+   $
��Left=�67   $��	10,10,0,0q�6R    �� TextWrapping$
 Wrap=�6e   $��Tìm Kiếm��6y   $	��150��6�   $��0��6�   $��Center=�6�   �� 5(      -   5        $��Search��5(      $��Tìm Kiếm ��6'   $
��Left=�6;    " MaterialDesignRaisedDarkButton#��[ 6V   $��29��6�   $��
180,10,0,0q�6�   $
��Auto��6�   $��1��6�   $��Center=�6�   ��5)      �� *FindCommand+$ OneWay=���6B   ��  �� ElementName$ grCondition��5*      � 5+      $��3��6    � ColumnDefinitions 5,      �� 5-      $��* �6'   63   �� 5.      $	��280 �6'   65   �� 5/      $��* �6'   63   .+�51      �� -   5        $��	btnInsert��51      $��Thêm��6*   #��[ 69   $��1��6q   $
��Left=�6�   $��0,10,0,0q�6�   $��29��6�   $��80��6�   ��52      �� *NewFormCommand+��6>   �� $ productlist���� 53      -   5        $��	btnUpdate��53      $��Sửa��6*   #��[ 69   $��1��6q   $
��Left=�6�   $��
100,10,0,0q�6�   $��29��6�   $��80��6�   ��54      �� *EditFormCommand+��6=   �� *SelectedItem+$ lvproductview���� 55      -   5        $��	btnDelete��55      $
��Xóa��6*   #��[ 69   $��1��6q   $
��Left=�6�   $��
200,10,0,0q�6�   $��29��6�   $��80��6�   ��56      �� *DeleteRowCommand+��6A   �� *SelectedItem+$ lvproductview��57      58      59      5:      