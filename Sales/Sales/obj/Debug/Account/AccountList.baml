   M S B A M L   `   `   `  ����@  <Sales, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Sales.AccountSales.Account  5   	       Sales.Account.AccountList   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   
   'localclr-namespace:Sales.Account  5   	   V RMaterialDesignThemes.Wpf, Version=2.4.1.1101, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5        $��accountlist��5   	     � Title$  AccountList��5	   	   $	��650��6   $	��800��6*      MaterialDesignPaper#���   5
   
     MaterialDesignBody#���  5      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignFont#���  5      .��5      �� $��1q�6   
���   �._�5   
   � -   5        $��spPanel��5       $��0,0,0,0q�6    � RowDefinitions 5      �� 5      $
��Auto �6    60   �� 5      $
��Auto �6    60   �� 5      $
��Auto �6    60   �� 5      $
��Auto �6    60   �� 5      $
��Auto �6    60   �� 5      $
��Auto �6    60   .+�5      � $��0��6   .+�5      �� $��
Customer: ��6   $
��Left=�6-   $��15(�6H   $��0,0,0,0q�6V   �� 5       �� 
IsReadOnly . $
��Left=�6]   $��	100,0,0,0q�6x   $��40��6�   ��6   �� *!AccountViewObj.customer.CUST_ID+6�   �� 5        . $
��Left=�6U   $��	200,0,0,0q�6p   $	��100��6�   ��6   �� *AccountViewObj.NameCus+6�   5!      � 5"      $��1��6   .+�5#      �� $��
Employee: ��6   $
��Left=�6-   $��15(�6H   $��0,0,0,0q�6V   �� 5$       . $
��Left=�6]   $��	100,0,0,0q�6x   $��40��6�   ��6   �� * AccountViewObj.employee.EMP_ID+6�   �� 5%       . $
��Left=�6T   $��	200,0,0,0q�6o   $	��100��6�   ��6   �� *AccountViewObj.NameEm+6�   5&      � 5'      $��2��6    � ColumnDefinitions 5(      �� 5)      $
��249* �6'   �� 5*      $
��541* �6'    5,      �� 5-      $
��Auto �6$   64   �� 5.      $
��Auto �6$   64   �� 5/      $
��Auto �6$   64   �� 50      $
��Auto �6$   64   .+�52      �� $��Hóa đơn: ��6   
����  �$
��Left=�6>   $��0��6Y   $��20(�6f   $��0,10,0,0q�6t   � 53      -   5        $��grCondition��53   $   $��1��6   $��2��67   .+�54      �� -   5        $��	txtSearch��54      $��31��6/   $
��Left=�6;   $��10,0,0,0q�6V    �� TextWrapping$
 Wrap=�6h   $��Tìm Kiếm��6|   $	��120��6�   $��0��6�   $��Center=�6�   �� 55      -   5        $��Search��55      $��Tìm Kiếm ��6+   $
��Left=�6?    " MaterialDesignRaisedDarkButton#��[ 6Z   $��29��6�   $��	150,0,0,0q�6�   $
��Auto��6�   $��1��6�   $��Center=�6�   ��56      �� *FindCommand+ �� Mode$ OneWay=���6B   ��  �� ElementName$ grCondition��57      �� 58      -   5        $��	lvaccount��58   �   $	��300��6   $��Disabled=�6+   $��Stretch=�6b   	 �� SelectionMode$	 Single=�6~   $
��Auto��6�   $��2��6�   $��2��6�   ��6�   �� *AccountViewLists+
 �� SelectedItem
 6   �� *AccountViewObj+$ TwoWay=�.  (System.Windows.Interactivity.Interaction   Triggers 59      /  )System.Windows.Interactivity.EventTrigger  5:         	EventName$ SelectionChanged��6)   .  (System.Windows.Interactivity.TriggerBase   Actions. 5;      6  0System.Windows.Interactivity.InvokeCommandAction     Command 64   �� *SelectedItemCommand+   CommandParameter 6\   �� *SelectedItem+$ 	lvaccount��5<      ��5?      �� 5@       �� 
TargetType" ��6    .�5A      ��  �� Property � �� �� Value$ Stretch=�6K   5B       �� View 5D      �� 5F      -   5        	GridView1��.P�5G      �� $��
Account ID��6-    �� DisplayMemberBinding 6B   �� *id+�� 5H      $��Product��6-    6>   �� *	product+�� 5I      $��Avail Balance��6-    6E   �� *avail_balance+�� 5J      $��
Close date��6-    6A   �� *
close_date+�� 5K      $��Last activity date��6-    6J   �� *	last_date+�� 5L      $��	Open date��6-    6A   �� *	open_date+�� 5M      $��Pending balance��6-    6G   �� *pending_balance+�� 5N      $��Status��6-    6>   �� *status+�� 5O      $��Open Branch��6-    6C   �� *branch+5Q      5S      � 5T      $��3��6   $��2��6$    5U      �� 5V      6-   �� 5W      $	��270 �6+   69   �� 5X      6-   .+�5Z      �� $��>��6   $��60��6,   $
��Left=�67   $��	140,0,0,0q�6R   $��1��6g   $	��Top=�5[   �   ��6   �� *NextButtonCommand+��6C   �� *SelectedItem+$ 	lvaccount��6�   �� 5\      $��<��6   $��60��6,   $
��Left=�67   $��70,0,0,0q�6R   $��1��6f   ��5]      �� *PrevButtonCommand+��6D   �� *SelectedItem+$ 	lvaccount���� 5^      $��<<��6   $��60��60   $
��Left=�6;   $��0,0,0,0q�6V   $��1��6i   ��5_      �� *FirstButtonCommand+��6E   �� *SelectedItem+$ 	lvaccount���� 5`      $��>>��6   $��60��6*   $
��Left=�65   $��	210,0,0,0q�6P   $��1��6e   ��5a      �� *LastButtonCommand+��6D   �� *SelectedItem+$ 	lvaccount��5b      5c      � 5d      $��3��6    5e      �� 5f      6&   �� 5g      6&   .+�5i      �� $��Chi tiết: ��6   
����  �$
��Left=�6?   $��0��6Z   $��20(�6g   $��0,0,0,0q�6u   �� 5j      -   5        $��account_tranObj��5j   �   $
��Auto��6   $��Disabled=�6+   $��Stretch=�6a   $	 Single=�6}   $
��Auto��6�   $��0,10,0,0q�6�   $��1��6�   ��6�   �� *Account_tranLists+��5l      �� 5m      " ��6    .�5n      ��  � ��$ Stretch=�6K   5o       5q      �� 5s      -	   5        	GridView2��.P�5t      �� $��TXN ID��6-    6>   �� *txnid+�� 5u      $��Amount��6-    6=   �� *amount+�� 5v      $��Funds avail date��6-    6H   �� *	fund_date+�� 5w      $��TXN date��6-    6?   �� *	txndate+�� 5x      $��TXN Type CD��6-    6C   �� *	txntype+�� 5y      $��Branch��6-    6>   �� *branch+5z      5|      5}      � 5~      $��4��6    5      �� 5�      $��* �6'   63   �� 5�      $	��280 �6'   65   �� 5�      $��* �6'   63   .+�5�      �� -
   5        $��
btnInsert1��5�      $��Thêm��6+   #��[ 6:   $��1��6r   $
��Left=�6�   $��0,10,0,0q�6�   $��29��6�   $��80��6�   ��5�      �� *NewFormCommand+��6>   �� $ accountlist���� 5�      -   5        $��
btnUpdate1��5�      $��Sửa��6+   #��[ 6:   $��1��6r   $
��Left=�6�   $��
100,10,0,0q�6�   $��29��6�   $��80��6�   ��5�      �� *EditFormCommand+��6=   �� *SelectedItem+$ 	lvaccount���� 5�      -   5        $��btnDelet1e1��5�      $
��Xóa��6,   #��[ 6;   $��1��6s   $
��Left=�6�   $��
200,10,0,0q�6�   $��29��6�   $��80��6�   ��5�      �� *DeleteRowCommand+��6A   �� *SelectedItem+$ 	lvaccount��5�      5�      5�      5�      