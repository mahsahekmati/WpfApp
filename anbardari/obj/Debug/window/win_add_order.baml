   M S B A M L   `   `   `  ����D  @anbardari, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:anbardari.windowanbardari.window  5   	   U QPersianDateControls, Version=1.2.4495.22344, Culture=neutral, PublicKeyToken=nullbDclr-namespace:Arash.PersianDateControls;assembly=PersianDateControlsArash.PersianDateControls 5   	   $    anbardari.window.win_add_order   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35` \RibbonControlsLibrary, Version=3.5.41019.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:anbardari.window     5   	   dPersianDateControlsDclr-namespace:Arash.PersianDateControls;assembly=PersianDateControls     5   	     � Title$  win_add_order��5	   	   $	��450��6   $	��800��6,   
������  � AllowsTransparency .  � WindowStyle$
 None=�6k   .��5
      � .+�5   
   �� $��Center=�6   $	��450��61   $��0,2,0,0q�6>   
���   �$	��Top=�6^   $	��800��6v   ��5      �� 5       �� ImageSource$ /img/back23.jpg��6   5      �� 5   
   $��Center=�6   $	��100��61   $��0,20,0,0q�6>   
���   �$	��Top=�6_   $	��757��6w    �� RadiusX$ 20��6�    �� RadiusY$ 20��6�   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FFF7F2F6��6#   � 5      $ 	#FFE46DC9��6#   	 � Offset$	 1Q�65   5      5      �� 5   
   $��انتخاب مشتری:��6   $��RightToLeft=�6(   $
��Left=�6D   $��
617,44,0,0q�6_   $	��Top=�6s   $��20(�6�   $��46��6�   $	��139��6�   �� 5   
   $��تاریخ:��6   $��RightToLeft=�6!   $
��Left=�6=   $��
324,42,0,0q�6X   $	��Top=�6l   $��20(�6�   $��46��6�   $��65��6�   �� 5   
   -   5        
 ��Name$
 
btn_create��5      $��
ایجاد��6%   $
��Left=�65   $��537,138,0,0q�6P   $	��Top=�6e   $��18(�6}   $
��Bold"�6�   $��26��6�   $	��169��6�   ��5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5      � $ 	#FFFBF7FB��6#   � 5      $ 	#FFE659D3��6#   $	 1Q�65   5      5!      �� 5"   
   -   5        $
 btn_edit��5"      $��ویرایش��6#   $
��Left=�64   $��317,136,0,0q�6O   $	��Top=�6d   $��18(�6|   $
��Bold"�6�   $��26��6�   $	��169��6�   ��5#      �� 5$      $ 0.5,1&�6&   $ 0.5,0&�67   .��5%      � $ 	#FFFBF7FB��6#   � 5&      $ 	#FFE659D3��6#   $	 1Q�65   5'      5)      �� 5*   
   -   5        $
 
btn_delete��5*      $��حذف��6%   $
��Left=�63   $��108,139,0,0q�6N   $	��Top=�6c   $��18(�6{   $
��Bold"�6�   $��26��6�   $	��169��6�   ��5+      �� 5,      $ 0.5,1&�6&   $ 0.5,0&�67   .��5-      � $ 	#FFFBF7FB��6#   � 5.      $ 	#FFE659D3��6#   $	 1Q�65   5/      51      &   System.Windows.Controls.DataGrid  52   
   -   5          Name$ datagride_product��52      $��27,185,25,86q�6/   �� 53   
   -   5        $
 btn_register��53      $��ثبت نهایی��6'   $
��Left=�6;   $��452,394,0,0q�6V   $	��Top=�6k   $��18(�6�   $
��Bold"�6�   $��26��6�   $	��169��6�   ��54      �� 55      $ 0.5,1&�6&   $ 0.5,0&�67   .��56      � $ 	#FFFBF7FB��6#   � 57      $ 	#FFE659D3��6#   $	 1Q�65   58      5:      �� 5;   
   -   5        $
 
btn_cancel��5;      $��انصراف��6%   $
��Left=�66   $��206,394,0,0q�6Q   $	��Top=�6f   $��18(�6~   $
��Bold"�6�   $��26��6�   $	��169��6�   ��5<      �� 5=      $ 0.5,1&�6&   $ 0.5,0&�67   .��5>      � $ 	#FFFBF7FB��6#   � 5?      $ 	#FFE659D3��6#   $	 1Q�65   5@      5B      �� 5C   
   -   5         ��Name$ cmb_customername��5C      $
��Left=�6-   $��
426,49,0,0q�6H   $	��Top=�6\   $	��187��6t   $��RightToLeft=�6�   $��37��6�   1  +Arash.PersianDateControls.PersianDatePicker  5E   
   $
��Left=�60   $��
207,36,0,0q�6K   $	��Top=�6_   $��50��6w   $	��110��6�   5G      5H      