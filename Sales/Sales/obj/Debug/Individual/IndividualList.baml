   M S B A M L   `   `   `  ����@  <Sales, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Sales.IndividualSales.Individual  5   	   %    Sales.Individual.IndividualList   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Sales.Individual     5   	   V RMaterialDesignThemes.Wpf, Version=2.4.1.1101, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
        � Title$  IndividualList��5   	   $
��Auto��6    $	��800��6.      MaterialDesignPaper#���   5	   
     MaterialDesignBody#���  5      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignFont#���  5      .��5      �� $��1q�6   
���   �._�5   
   �  � RowDefinitions 5      �� 5      $
��Auto �6    61   �� 5      $
��Auto �6    61   �� 5      $
��Auto �6!   62   �� 5      $
��Auto �6    62   .+�5      &   System.Windows.Controls.DataGrid  -   5        $��grindividual��5   L      SelectionMode$ Single=�6      AutoGenerateColumns .  $
��Auto��6a   $��	10,10,0,0q�6n   $��2��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Cus ID��6*      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6V   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6:   �� *	CUST_ID+6V     5      $
 Tên��6)   $ * 6U   	 66   �� *
FIRST_NAME+6U     5      $
 Họ��6)   $ * 6S   	 65   �� *	LAST_NAME+6S     5      $ 
Ngày sinh��6)   $ * 6[   	 6<   �� *
BIRTH_DATE+6[   5       �� 5!      $��	Cá nhân��6   $��Center=�6&   $��Center=�6C   $	��135��6_   $��20(�6k   $��0��6y   5"      � 5#      $��1��6   .+�5$      �� -   5        $��	txtSearch��5$      $��31��6+   $
��Left=�67   $��	10,10,0,0q�6R   
 �� TextWrapping$

 Wrap=�6e   $��Tìm Kiếm��6y   $	��150��6�   $��0��6�   $��Center=�6�   6�   �� 5%      -   5        $��Search��5%      $��Tìm Kiếm ��6'   $
��Left=�6;    " MaterialDesignRaisedDarkButton#��[ 6V   $��29��6�   $��
180,10,0,0q�6�   $
��Auto��6�   $��1��6�   $��Center=�6�   6�   5&      � 5'      $��3��6    � ColumnDefinitions 5(      �� 5)      $��* �6'   63   �� 5*      $	��280 �6'   65   �� 5+      $��* �6'   63   .+�5-      �� -   5        $��	btnInsert��5-      $��Thêm��6*   #��[ 69   $��1��6q   $
��Left=�6�   $��0,10,0,0q�6�   $��29��6�   $��80��6�   6�   �� 5.      -   5        $��	btnUpdate��5.      $��Sửa��6*   #��[ 69   $��1��6r   $��Center=�6�   $��Center=�6�   $��0,10,0,0q�6�   $��29��6�   $��80��6�   6�   �� 5/      -   5        $��	btnDelete��5/      $
��Xóa��6*   #��[ 69   $��1��6q   $
��Left=�6�   $��
200,10,0,0q�6�   $��29��6�   $��80��6�   6�   50      51      52      53      