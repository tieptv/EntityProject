   M S B A M L   `   `   `  ����@  <Sales, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Sales.BranchSales.Branch  5   	       Sales.Branch.BranchList   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Sales.Branch     5   	   V RMaterialDesignThemes.Wpf, Version=2.4.1.1101, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
      -   5        $��
Branchlist��5   	     � Title$  
BranchList��5   	   $
��Auto��6   $	��800��6*      MaterialDesignPaper#���   5	   
     MaterialDesignBody#���  5      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignFont#���  5      .��5      �� $��1q�6   
���   �$��0,0,0,0q�66   ._�5   
   � $��9,9,0,0q�6    � RowDefinitions 5      �� 5      $
��Auto �6    60   �� 5      $
��Auto �6    60   �� 5      $
��Auto �6    60   �� 5      $
��Auto �6    60   .+�5      �� -   5        $��lvbranch��5   .    �� SelectionMode$ Single=�6   $
��Auto��6?   $��0,10,0,0q�6L   $��2��6_   ��6l   �� *BranchLists+ �� SelectedItem 6�   �� *	BranchObj+ �� Mode$ TwoWay=� �� View 5      �� 5      .P�5      �� $��	BRANCH ID��6)    �� Width$	 100��6<   	 �� DisplayMemberBinding	 6H   �� *	BRANCH_ID+�� 5       $
��NAME��6)   $	 150��67   	 6C   �� *NAME+�� 5!      $
��CITY��6)   $	 100��67   	 6C   �� *CITY+�� 5"      $��ADDRESS��6)   $	 150��6:   	 6F   �� *	ADDRESS+�� 5#      $��STATE��6)   $	 150��68   	 6D   �� *STATE+�� 5$      $��ZIP CODE��6)   $	 150��6;   	 6G   �� *
ZIP_CODE+5%      5'      �� 5(      $��Branch��6   $��Center=�6%   $��0,0,0,0q�6B   $	��Top=�6S   $	��135��6k   $��20(�6w   $��0��6�   5)      � 5*      -   5        $��grCondition��5*       $��1��6   .+�5+      �� -   5        $��	txtSearch��5+      $��31��6+   $
��Left=�67   $��	10,10,0,0q�6R   
 �� TextWrapping$

 Wrap=�6e   $��Tìm Kiếm��6y   $	��150��6�   $��0��6�   $��Center=�6�   �� 5,      -   5        $��Search��5,      $��Tìm Kiếm ��6'   $
��Left=�6;    " MaterialDesignRaisedDarkButton#��[ 6V   $��29��6�   $��
180,10,0,0q�6�   $
��Auto��6�   $��1��6�   $��Center=�6�   ��5-      �� *FindCommand+$ OneWay=���6B   ��  �� ElementName$ grCondition��5.      � 5/      $��3��6    � ColumnDefinitions 50      �� 51      $��* �6'   63   �� 52      $	��280 �6'   65   �� 53      $��* �6'   63   .+�55      �� -   5        $��	btnInsert��55      $��Thêm��6*   #��[ 69   $��1��6q   $
��Left=�6�   $��0,10,0,0q�6�   $��29��6�   $��80��6�   ��56      �� *NewFormCommand+��6>   �� $ 
Branchlist���� 57      -   5        $��	btnUpdate��57      $��Sửa��6*   #��[ 69   $��1��6q   $
��Left=�6�   $��
100,10,0,0q�6�   $��29��6�   $��80��6�   ��58      �� *EditFormCommand+��6=   �� *SelectedItem+$ lvbranch���� 59      -   5        $��	btnDelete��59      $
��Xóa��6*   #��[ 69   $��1��6q   $
��Left=�6�   $��
200,10,0,0q�6�   $��29��6�   $��80��6�   ��5:      �� *DeleteRowCommand+��6?   �� *SelectedItem+$ lvbranch��5;      5<      5=      5>      