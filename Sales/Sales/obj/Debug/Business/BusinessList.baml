   M S B A M L   `   `   `  ����@  <Sales, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Sales.BusinessSales.Business  5   	   !    Sales.Business.BusinessList   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Sales.Business     5   	   V RMaterialDesignThemes.Wpf, Version=2.4.1.1101, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
        � Title$  BusinessList��5   	   $	��300��6   $	��600��6+      MaterialDesignPaper#���   5	   
     MaterialDesignBody#���  5      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignFont#���  5      .��5      �� $��1q�6   
���   �._�5   
   �  � RowDefinitions 5      �� 5      $
��Auto �6    60   �� 5      $
��Auto �6    60   �� 5      $
��Auto �6    60   �� 5      $
��Auto �6    60   .+�5      &   System.Windows.Controls.DataGrid  -   5        $��	grproduct��5   L      SelectionMode$ Single=�6      AutoGenerateColumns .  $
��Auto��6^   $��	10,10,0,0q�6k   $��1��6~   $��2��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã KH��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6W   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 68   �� *
product_cd+6W     5      $ Trạng thái��6)   	 6=   �� *type+  5      $
 Tên��6)   	 66   �� *name+  5       $ Ngày hợp tác��6)   $
 Auto 6^   	 6?   �� *
date_offer+6^   5#      �� 5$      $��
Kinh doanh��6   $��Center=�6)   $��30,7,0,0q�6F   $	��135��6X   $��20(�6d   $��0��6r   5%      � 5&      $��1��6   .+�5'      �� $��31��6   $
��Left=�6&   $��	10,10,0,0q�6A   
 �� TextWrapping$

 Wrap=�6T   $��Tìm Kiếm��6h   $	��250��6x   $��0��6�   $��Center=�6�   �� 5(      $��Tìm Kiếm ��6   $
��Left=�6-    " MaterialDesignRaisedDarkButton#��[ 6H   $��29��6�   $��
300,15,0,0q�6�   $	��113��6�   $��1��6�   $��Center=�6�   5)      �� 5*      $��Thêm��6   #��[ 6$   $��3��6\   $
��Left=�6i   $��
100,10,0,0q�6�   $��29��6�   $	��100��6�   �� 5+      $��Sửa��6   #��[ 6$   $��3��6\   $
��Left=�6i   $��
220,10,0,0q�6�   $��29��6�   $	��100��6�   �� 5,      $
��Xóa��6   #��[ 6$   $��3��6\   $
��Left=�6i   $��
340,10,0,0q�6�   $��29��6�   $	��100��6�   5-      5.      5/      