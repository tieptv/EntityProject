   M S B A M L   `   `   `  ����@  <Sales, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Sales.Acc_TranSales.Acc_Tran  5   	   !    Sales.Acc_Tran.Acc_TranList   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Sales.Acc_Tran     5   	   V RMaterialDesignThemes.Wpf, Version=2.4.1.1101, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
        � Title$  Acc_TranList��5   	   $	��300��6   $	��600��6+      MaterialDesignPaper#���   5	   
     MaterialDesignBody#���  5      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignFont#���  5      .��5      �� $��1q�6   
���   �$��0,0,0,0q�66   ._�5   
   � $��9,9,0,0q�6    � RowDefinitions 5      �� 5      $
��Auto �6    60   �� 5      $
��Auto �6    60   �� 5      $
��Auto �6    60   �� 5      $
��Auto �6    60   .+�5      &   System.Windows.Controls.DataGrid  -   5        $��	grproduct��5   L      SelectionMode$ Single=�6      AutoGenerateColumns .  $
��Auto��6^   $��	10,10,0,0q�6k   $��1��6~   $��2��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$	 Mã��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6T   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 65   �� *
product_cd+6T     5      $ Số tiền��6)   	 6:   �� *type+  5      $ FUNDS AVAIL DATE��6)   	 6C   �� *name+  5       $ TXN_DATE��6)   $
 Auto 6Z   	 6;   �� *
date_offer+6Z     5!      $ TXN_TYPE_CD��6)   $
 Auto 6_   	 6>   �� *date_retire+6_     5"      $ 	ACOUNT ID��6)   $
 Auto 6[   	 6<   �� *
date_offer+6[     5#      $ 
Chi nhánh��6)   $
 Auto 6]   	 6<   �� *date_retire+6]     5$      $ Nhân viên��6)   $
 Auto 6]   	 6<   �� *date_retire+6]   5&      �� 5'      $��Giao dịch tài khoản��6   $��Center=�62   $��30,7,0,0q�6O   $	��200��6a   $��20(�6m   $��0��6{   5(      � 5)      $��1��6   .+�5*      �� $��31��6   $
��Left=�6&   $��	10,10,0,0q�6A   
 �� TextWrapping$

 Wrap=�6T   $��Tìm Kiếm��6h   $	��250��6x   $��0��6�   $��Center=�6�   �� 5+      $��Tìm Kiếm ��6   $
��Left=�6-    " MaterialDesignRaisedDarkButton#��[ 6H   $��29��6�   $��
300,15,0,0q�6�   $	��113��6�   $��1��6�   $��Center=�6�   5,      �� 5-      $��Thêm��6   #��[ 6$   $��3��6\   $
��Left=�6i   $��
100,10,0,0q�6�   $��29��6�   $	��100��6�   �� 5.      $��Sửa��6   #��[ 6$   $��3��6\   $
��Left=�6i   $��
220,10,0,0q�6�   $��29��6�   $	��100��6�   �� 5/      $
��Xóa��6   #��[ 6$   $��3��6\   $
��Left=�6i   $��
340,10,0,0q�6�   $��29��6�   $	��100��6�   50      51      52      