   M S B A M L   `   `   `  ����	  Sales    Sales.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   V RMaterialDesignThemes.Wpf, Version=2.4.1.1101, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	     � Title$  
MainWindow��5   	   $
��Auto��6   $	��800��6*      MaterialDesignPaper#���   5   	     MaterialDesignBody#���  5   	   $��Regular"�5	   	   $��13(�5
   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignFont#���  5   	   .��5      �� $��1q�6   
���   �._�5      � -   5        $��spPanel��5      $��0,0,0,0q�6    � RowDefinitions 5      �� 5      $
��Auto �6    60   �� 5      $
��Auto �6    60   �� 5      $
��Auto �6    60   �� 5      $
��Auto �6    60   �� 5      $
��Auto �6    60   �� 5      $
��Auto �6    60   .+�5      � $��0��6   .+�5      �� $��
Customer: ��6   $
��Left=�6-   $��15(�6H   $��0,0,0,0q�6V   �� 5      $��Id��6   $
��Left=�6$   $��	100,0,0,0q�6?   $��40��6R   �� 5      $
��Name��6   $
��Left=�6&   $��	200,0,0,0q�6A   $	��100��6T   5      � 5      $��1��6   .+�5      �� $��
Employee: ��6   $
��Left=�6-   $��15(�6H   $��0,0,0,0q�6V   �� 5      $��Id��6   $
��Left=�6$   $��	100,0,0,0q�6?   $��40��6R   �� 5       $
��Name��6   $
��Left=�6&   $��	200,0,0,0q�6A   $	��100��6T   5!      � 5"      $��2��6    5#      �� 5$      $
��Auto �6$   64   �� 5%      $
��Auto �6$   64   �� 5&      $
��Auto �6$   64   �� 5'      $
��Auto �6$   64   .+�5)      �� $��Hóa đơn: ��6   
����  �$
��Left=�6>   $��0��6Y   $��20(�6f   $��0,10,0,0q�6t   � 5*      -   5        $��grCondition��5*   $   $��1��6   .+�5+      �� -   5        $��	txtSearch��5+      $��31��6/   $
��Left=�6;   $��10,0,0,0q�6V    �� TextWrapping$
 Wrap=�6h   $��Tìm Kiếm��6|   $	��120��6�   $��0��6�   $��Center=�6�   �� 5,      -   5        $��Search��5,      $��Tìm Kiếm ��6+   $
��Left=�6?    " MaterialDesignRaisedDarkButton#��[ 6Z   $��29��6�   $��	150,0,0,0q�6�   $
��Auto��6�   $��1��6�   $��Center=�6�   ��5-      �� *FindCommand+ �� Mode$ OneWay=���6B   ��  �� ElementName$ grCondition��5.      �� 5/      -   5        $��	lvaccount��5/   �   $
��Auto��6   $��Disabled=�6+   $��Stretch=�6a    �� SelectionMode$ Single=�6}   $
��Auto��6�   $��1��6�   $��2��6�   ��6�   �� *AccountViewLists+ �� SelectedItem 6�   �� *AccountViewObj+$ TwoWay=�.  (System.Windows.Interactivity.Interaction	   Triggers	 50      /  )System.Windows.Interactivity.EventTrigger  51      
   	EventName$
 SelectionChanged��6)   .  (System.Windows.Interactivity.TriggerBase   Actions. 52      6  0System.Windows.Interactivity.InvokeCommandAction     Command 64   �� *SelectedItemCommand+   CommandParameter 6\   �� *SelectedItem+$ 	lvaccount��53      ��55      �� 56       �� 
TargetType" ��6    .�57      ��  �� Property � �� �� Value$ Stretch=�6K   58       �� View 5:      �� 5<      -   5        	GridView1��.P�5=      �� $��
Account ID��6-    �� DisplayMemberBinding 6B   �� *id+�� 5>      $��Product��6-    6>   �� *	product+�� 5?      $��Avail Balance��6-    6E   �� *avail_balance+�� 5@      $��
Close date��6-    6A   �� *
close_date+�� 5A      $��Last activity date��6-    6J   �� *	last_date+�� 5B      $��	Open date��6-    6A   �� *	open_date+�� 5C      $��Pending balance��6-    6G   �� *pending_balance+�� 5D      $��Status��6-    6>   �� *status+�� 5E      $��Branch��6-    6>   �� *branch+�� 5F      $��Employee��6-    6?   �� *
employee+5H      5J      � 5K      $��3��6    � ColumnDefinitions 5L      �� 5M      6-   �� 5N      $	��270 �6+   69   �� 5O      6-   .+�5Q      �� $��>��6   $��60��6,   $
��Left=�67   $��	140,0,0,0q�6R   $��1��6g   �� 5R      $��<��6   $��60��6,   $
��Left=�67   $��70,0,0,0q�6R   $��1��6f   �� 5S      $��<<��6   $��60��60   $
��Left=�6;   $��0,0,0,0q�6V   $��1��6i   �� 5T      $��>>��6   $��60��6*   $
��Left=�65   $��	210,0,0,0q�6P   $��1��6e   5U      5V      � 5W      $��3��6    5X      �� 5Y      6&   �� 5Z      6&   .+�5\      �� $��Chi tiết: ��6   
����  �$
��Left=�6?   $��0��6Z   $��20(�6g   $��0,0,0,0q�6u   �� 5]      -   5        $��lvaccount_tran��5]   �   $
��Auto��6   $��Disabled=�6+   $��Stretch=�6a   $ Single=�6}   $
��Auto��6�   $��0,10,0,0q�6�   $��1��6�   ��6�   �� *Account_tranLists+ 6  �� *Account_tranObj+$ TwoWay=�	 5^        5_      $
 SelectionChanged��6)   . 5`         64   �� *SelectedItemCommand1+ 6]   �� *SelectedItem+$ lvaccount_tran��5a      ��5c      �� 5d      " ��6    .�5e      ��  � ��$ Stretch=�6K   5f       5h      �� 5j      -   5        	GridView2��.P�5k      �� $��TXN ID��6-    6>   �� *txnid+�� 5l      $��Amount��6-    6=   �� *amount+�� 5m      $��Funds avail date��6-    6H   �� *	fund_date+�� 5n      $��TXN date��6-    6?   �� *	txndate+�� 5o      $��TXN Type CD��6-    6C   �� *	txntype+�� 5p      $��Branch��6-    6>   �� *branch+5q      5s      5t      � 5u      $��4��6    5v      �� 5w      $��* �6'   63   �� 5x      $	��280 �6'   65   �� 5y      $��* �6'   63   .+�5{      �� -	   5        $��
btnInsert1��5{      $��Thêm��6+   #��[ 6:   $��1��6r   $
��Left=�6�   $��0,10,0,0q�6�   $��29��6�   $��80��6�   ��5|      �� *NewFormCommand+��6>   �� $ accountlist���� 5}      -
   5        $��
btnUpdate1��5}      $��Sửa��6+   #��[ 6:   $��1��6r   $
��Left=�6�   $��
100,10,0,0q�6�   $��29��6�   $��80��6�   ��5~      �� *EditFormCommand+��6=   �� *SelectedItem+$ lvaccount_transaction���� 5      -   5        $��btnDelet1e1��5      $
��Xóa��6,   #��[ 6;   $��1��6s   $
��Left=�6�   $��
200,10,0,0q�6�   $��29��6�   $��80��6�   ��5�      �� *DeleteRowCommand+��6A   �� *SelectedItem+$ lvaccount_transaction��5�      5�      5�      5�      