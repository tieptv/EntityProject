   M S B A M L   `   `   `  ����@  <Sales, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Sales.Product_typeSales.Product_type  5   	   (    "Sales.Product_type.ProductTypeEdit   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Sales.Product_type     5   	   V RMaterialDesignThemes.Wpf, Version=2.4.1.1101, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
      -   5        $��Product_type_edit��5   	     � Title$  ProductTypeEdit��5   	   $	��300��6!   $	��600��6.      MaterialDesignPaper#���   5	   
     MaterialDesignBody#���  5      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignFont#���  5      .��5      �� $��1q�6   
���   �._�5   
   �  � RowDefinitions 5      �� 5      $
��Auto �6    60   �� 5      $
��Auto �6    61   .+�5      � $��0��6    � ColumnDefinitions 5      �� 5      6)   �� 5      6)   .+�5      �� $
��Mã ��6   $
��Left=�6(   $��
120,10,0,0q�6C   $��0��6X   $��29��6h   �� 5      -   5        $��txtProductTypecd��5      $
��Left=�6T   $��
160,10,0,0q�6o   $	��120��6�   $��0��6�   $��29��6�   ��62   �� *Product_type_cd+6�   �� 5      $
��Tên��6   $
��Left=�6(   $��	10,10,0,0q�6C   $��1��6W   $��29��6g   �� 5       -   5        $��txtName��5       $
��Left=�6@   $��	60,10,0,0q�6[   $	��120��6n   $��1��6z   $��29��6�   ��6)   �� *Name+6�   5!      � 5#      $��1��6    5$      �� 5%      6)   �� 5&      6)   .+�5(      �� -   5        $��btnOk��5(      $��OK��6&   $	��113��64   $��29��6@   $��0,10,0,0q�6L   $��0��6^   $��Right=�6n   ��5)      �� *	OKCommand+��68   ��  �� ElementName$ Product_type_edit���� 5*      -   5        $��	btnCancel��5*      $��CANCEL��6*   $	��113��6<   $��29��6H   $��	10,10,0,0q�6T   $��1��6g   $
��Left=�6w   $	��Top=�6�   ��5+      �� *CancelCommand+��6=   �� $ Product_type_edit��5,      5-      5.      5/      