   M S B A M L   `   `   `  ����@  <Sales, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Sales.EmployeeSales.Employee  5   	   !    Sales.Employee.EmployeeList   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Sales.Employee     5   	   V RMaterialDesignThemes.Wpf, Version=2.4.1.1101, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
      -   5        $��Employeelist��5   	     � Title$  EmployeeList��5   	   $	��600��6   $	��800��6+      MaterialDesignPaper#���   5	   
     MaterialDesignBody#���  5      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignFont#���  5      .��5      �� $��1q�6   
���   �._�5   
   �  � RowDefinitions 5      �� 5      $
��Auto �6    60   �� 5      $
��Auto �6    60   �� 5      $
��Auto �6    60   �� 5      $
��Auto �6    60   .+�5      �� -   5        $��
lvemployee��5   �   $	��400��6   $��Disabled=�6&   $��Stretch=�6\    �� SelectionMode$ Single=�6x   $
��Auto��6�   $��0,10,0,0q�6�   $��1��6�   $��2��6�   ��6�   �� *EmployeeViewLists+ �� SelectedItem 6  �� *EmployeeViewObj+ �� Mode$ TwoWay=���5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � ��	 �� Value$	 Stretch=�6G   5      
 �� View
 5       �� 5"      -   5        	GridView1��.P�5#      �� $��Emp ID��6)    �� DisplayMemberBinding 6:   �� *id+�� 5$      $��
Fisrt Name��6)    6>   �� *
first_name+�� 5%      $��	Last Name��6)    6<   �� *	last_name+�� 5&      $��Title��6)    69   �� *title+�� 5'      $��
Start Date��6)    6>   �� *
start_date+�� 5(      $��End Date��6)    6<   �� *
end_date+�� 5)      $��
Department��6)    6>   �� *
department+�� 5*      $��Branch��6)    6:   �� *branch+�� 5+      $��Superior Emp��6)    6?   �� *SupervisorEm+5,      5.      �� 5/      $��Employee��6   $��Center=�6'   $��30,7,0,0q�6D   $	��135��6V   $��20(�6b   $��0��6p   50      � 51      -   5        $��grCondition��51       $��1��6   .+�52      �� -   5        $��	txtSearch��52      $��31��6+   $
��Left=�67   $��	10,10,0,0q�6R    �� TextWrapping$
 Wrap=�6e   $��Tìm Kiếm��6y   $	��150��6�   $��0��6�   $��Center=�6�   �� 53      -   5        $��Search��53      $��Tìm Kiếm ��6'   $
��Left=�6;    " MaterialDesignRaisedDarkButton#��[ 6V   $��29��6�   $��
180,10,0,0q�6�   $
��Auto��6�   $��1��6�   $��Center=�6�   ��54      �� *FindCommand+$ OneWay=���6B   ��  �� ElementName$ grCondition��55      � 56      $��3��6    � ColumnDefinitions 57      �� 58      $��* �6'   63   �� 59      $	��280 �6'   65   �� 5:      $��* �6'   63   .+�5<      �� -   5        $��	btnInsert��5<      $��Thêm��6*   #��[ 69   $��1��6q   $
��Left=�6�   $��0,10,0,0q�6�   $��29��6�   $��80��6�   ��5=      �� *NewFormCommand+��6>   �� $ Employeelist���� 5>      -   5        $��	btnUpdate��5>      $��Sửa��6*   #��[ 69   $��1��6q   $
��Left=�6�   $��
100,10,0,0q�6�   $��29��6�   $��80��6�   ��5?      �� *EditFormCommand+��6=   �� *SelectedItem+$ 
lvemployee���� 5@      -	   5        $��	btnDelete��5@      $
��Xóa��6*   #��[ 69   $��1��6q   $
��Left=�6�   $��
200,10,0,0q�6�   $��29��6�   $��80��6�   ��5A      �� *DeleteRowCommand+��6A   �� *SelectedItem+$ 
lvemployee��5B      5C      5D      5E      