   M S B A M L   `   `   `  ����@  <Sales, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Sales.DepartmentSales.Department  5   	   3clr-namespace:Sales.DepartmentSales.Department  5   	   %    Sales.Department.DepartmentList   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Sales.Department     5   	   1vmListclr-namespace:Sales.Department     5   	   V RMaterialDesignThemes.Wpf, Version=2.4.1.1101, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5        $��departmenlist��5   	     � Title$  DepartmentList��5	   	   $
��Auto��6    $	��800��6.      MaterialDesignPaper#���   5
   
     MaterialDesignBody#���  5      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignFont#���  5       � DataContext 5      #   Sales.Department.DepartmentVM  5   
   6    .��5      �� $��1q�6   
���   �._�5   
   �  � RowDefinitions 5      �� 5      $
��Auto �6    60   �� 5      $
��Auto �6    60   �� 5      $
��Auto �6    60   �� 5      $
��Auto �6    60   .+�5      �� -   5        $��grdepartment��5   .    �� SelectionMode$ Single=�6   $
��Auto��6C   $��0,10,0,0q�6P   $��1��6b   $��2��6v   ��6�   �� *DeparmentLists+ �� SelectedItem 6�   �� *DeparmentObj+ �� Mode$ TwoWay=� �� View 5       �� 5!      .P�5"      �� $��DEP ID��6)   	 �� Width$		 300��69   
 �� DisplayMemberBinding
 6E   �� *	DEPT_ID+�� 5#      $
��NAME��6)   $		 500��67   
 6C   �� *NAME+5%      5'      �� 5(      $��
Phòng ban��6   $��Center=�6(   $��30,7,0,0q�6E   $	��135��6W   $��20(�6c   $��0��6q   5)      � 5*      -   5        $��grCondition��5*       $��1��6   .+�5+      �� -   5        $��	txtSearch��5+      $��31��6+   $
��Left=�67   $��	10,10,0,0q�6R    �� TextWrapping$
 Wrap=�6e   $��Tìm Kiếm��6y   $	��150��6�   $��0��6�   $��Center=�6�   �� 5,      -   5        $��Search��5,      $��Tìm Kiếm ��6'   $
��Left=�6;    " MaterialDesignRaisedDarkButton#��[ 6V   $��29��6�   $��
180,10,0,0q�6�   $
��Auto��6�   $��1��6�   $��Center=�6�   ��5-      �� *FindCommand+$ OneWay=���6B   ��  �� ElementName$ grCondition��5.      � 5/      $��3��6    � ColumnDefinitions 50      �� 51      $
��121* �6'   66   �� 52      $
��134* �6'   �� 53      $	��280 �6'   65   �� 54      $
��255* �6'   66   .+�56      �� -   5        $��	btnInsert��56      $��Thêm��6*   #��[ 69   $��2��6q   $
��Left=�6�   $��0,10,0,0q�6�   $��29��6�   $��80��6�   ��57      �� *NewFormCommand+��6>   �� $ departmentlist���� 58      -   5        $��	btnUpdate��58      $��Sửa��6*   #��[ 69   $��2��6q   $
��Left=�6�   $��
100,10,0,0q�6�   $��29��6�   $��80��6�   ��59      �� *EditFormCommand+��6=   �� *SelectedItem+$ grdepartment���� 5:      -   5        $��	btnDelete��5:      $
��Xóa��6*   #��[ 69   $��2��6q   $
��Left=�6�   $��
200,10,0,0q�6�   $��29��6�   $��80��6�   ��5;      �� *DeleteRowCommand+��6>   �� *SelectedItem+$ grdepartment��5<      5=      5>      5?      