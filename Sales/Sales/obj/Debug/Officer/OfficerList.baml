   M S B A M L   `   `   `  ����@  <Sales, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Sales.OfficerSales.Officer  5   	       Sales.Officer.OfficerList   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Sales.Officer     5   	   V RMaterialDesignThemes.Wpf, Version=2.4.1.1101, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
        � Title$  OfficerList��5   	   $
��Auto��6   $	��800��6+      MaterialDesignPaper#���   5	   
     MaterialDesignBody#���  5      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignFont#���  5      .��5      �� $��1q�6   
���   �._�5   
   �  � RowDefinitions 5      �� 5      $
��Auto �6    60   �� 5      $
��Auto �6    60   �� 5      $
��Auto �6    60   �� 5      $
��Auto �6    60   .+�5      &   System.Windows.Controls.DataGrid  -   5        $��	grofficer��5   L      SelectionMode$ Single=�6      AutoGenerateColumns .  $
��Auto��6^   $��	10,10,0,0q�6k   $��1��6~   $��2��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã NV��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6W   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 68   �� *
OFFICER_ID+6W     5      $
 Tên��6)   $ * 6V   	 66   �� *
FIRST_NAME+6V     5      $
 Họ��6)   $ * 6S   	 65   �� *	LAST_NAME+6S     5       $ Ngày bắt đầu��6)   $ * 6^   	 6?   �� *
START_DATE+6^     5!      $ Chức vụ��6)   $ * 6U   	 6:   �� *TITLE+6U     5"      $ Ngày nghỉ��6)   $ * 6Y   	 6<   �� *
END_DATE+6Y     5#      $ Cust ID��6)   $ * 6V   	 6:   �� *	CUST_ID+6V   5%      �� 5&      $��Nhân viên văn phòng��6   $��Center=�62   $	��200��6O   $��20(�6[   $��0��6i   5'      � 5(      $��1��6   .+�5)      �� -   5        $��	txtSearch��5)      $��31��6+   $
��Left=�67   $��	10,10,0,0q�6R   
 �� TextWrapping$

 Wrap=�6e   $��Tìm Kiếm��6y   $	��150��6�   $��0��6�   6�   �� 5*      -   5        $��Search��5*      $��Tìm Kiếm ��6'   $
��Left=�6;    " MaterialDesignRaisedDarkButton#��[ 6V   $��29��6�   $��
180,10,0,0q�6�   $
��Auto��6�   $��1��6�   6�   5+      � 5,      $��3��6    � ColumnDefinitions 5-      �� 5.      $��* �6'   63   �� 5/      $	��280 �6'   65   �� 50      $��* �6'   63   .+�52      �� -   5        $��	btnInsert��52      $��Thêm��6*   #��[ 69   $��1��6q   $
��Left=�6�   $��0,10,0,0q�6�   $��29��6�   $��80��6�   6�   �� 53      -   5        $��	btnUpdate��53      $��Sửa��6*   #��[ 69   $��1��6r   $��Center=�6�   $��Center=�6�   $��0,10,0,0q�6�   $��29��6�   $��80��6�   6�   �� 54      -   5        $��	btnDelete��54      $
��Xóa��6*   #��[ 69   $��1��6q   $
��Left=�6�   $��
200,10,0,0q�6�   $��29��6�   $��80��6�   6�   55      56      57      58      