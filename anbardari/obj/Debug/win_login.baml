   M S B A M L   `   `   `  ����D  @anbardari, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:anbardari	anbardari  5   	   U QPersianDateControls, Version=1.2.4495.22344, Culture=neutral, PublicKeyToken=nullbDclr-namespace:Arash.PersianDateControls;assembly=PersianDateControlsArash.PersianDateControls 5   	       anbardari.win_login   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35` \RibbonControlsLibrary, Version=3.5.41019.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:anbardari     5   	   dPersianDateControlsDclr-namespace:Arash.PersianDateControls;assembly=PersianDateControls     5   	   -   5          � Title$  	win_login��5	   	   $	��400��6   $	��650��6(   
������  � AllowsTransparency .  � WindowStyle$
 None=�6g   .��5
      � .+�5   
   �� $��Center=�6   $	��380��61   
���   �$��Center=�6M   $	��632��6h   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ Black��6#    � Offset$ 1Q�61   � 5      $ 	#FFC081E6��6#   $ 0Q�65   5      5      �� 5   
   -   5        $��Center=�5      $	��100��61   $��0,10,0,0q�6>    �� RadiusX$ 20��6P    �� RadiusY$ 20��6]   
���   �$	��Top=�6y   $	��630��6�   ��5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5      � $ Black��6#   � 5      $ 	#FF9280D2��6#   $ 1Q�65   5      5      �� 5   
   $/��)سیستم انبارداری و فروش��6   $��Center=�61   $��0,42,0,0q�6N   $	��Top=�6`   ���	#FFE8D3D3$��Microsoft Himalaya)�6�   $��22(�6�   $
��Bold"�6�   �� 5   
   $��نام کاربری:��6   $��RightToLeft=�6&   $
��Left=�6B   $��	224,0,0,0q�6]   $��Center=�6p   $��Microsoft Himalaya)�6�   $��16(�6�   $
��Bold"�6�   ���	#FF0A07076�   �� 5   
   $��رمزعبور:��6   $��RightToLeft=�6#   $
��Left=�6?   $��237,233,0,0q�6Z   $	��Top=�6o   $��Microsoft Himalaya)�6�   $��16(�6�   $
��Bold"�6�   ���	#FF0A07076�   �� 5   
   -   5        	 ��Name$	 txt_username��5      $
��Left=�6(   $��85,0,0,0q�6C   
 �� TextWrapping$

 Wrap=�6U   $��Center=�6j   $	��120��6�   $��26��6�   .��6�   ��5      �� 5       $ 0.5,1&�6&   $ 0.5,0&�67   .��5!      � $ Black��6#   � 5"      $ White��6#   $ 1Q�61   5#      .��5$   "   5%      G� 5&   
   -   5         G�Name$ txt_password��5&      $
��Left=�6,   $��
86,229,0,0q�6G   $	��Top=�6[   $	��120��6s   $��26��6   ��5'      �� 5(      $ 0.5,1&�6&   $ 0.5,0&�67   .��5)      � $ Black��6#   � 5*      $ White��6#   $ 1Q�61   5+      5-      �� 5.   
   -   5         ��Name$ 	btn_login��5.      $��ورود��6$   $
��Left=�63   $��224,291,0,0q�6N   $	��Top=�6c   $��26��6{   $��84��6�   ��5/      �� 50      $ 0.5,1&�6&   $ 0.5,0&�67   .��51      � $ Black��6#   � 52      $ White��6#   $ 1Q�61   53      55      �� 56   
   -   5        $ btn_exit��56      $��خروج��6#   $
��Left=�62   $��
85,291,0,0q�6M   $	��Top=�6a   $��26��6y   $��84��6�   ��57      �� 58      $ 0.5,1&�6&   $ 0.5,0&�67   .��59      � $ Black��6#   � 5:      $ White��6#   $ 1Q�61   5;      5=      �� 5@   
   $��/img/Login-icon.png��6   $
��Left=�6-   $	��100��6H   $��	27,10,0,0q�6U   $	��Top=�6h   $	��100��6�   �� 5A   
   -   5        $��/img/exit.png��5A      $
��Left=�6'   $��49��6B   $��
584,25,0,0q�6N   $	��Top=�6b   $��39��6z   6�   �� 5B   
   $��فرم ورود��6   $��Center=�6#   $��0,79,0,0q�6@   $	��Top=�6R   $��Microsoft Himalaya)�6j   $��20(�6�   $��31��6�   $	��113��6�   /  )Arash.PersianDateControls.PersianCalendar  5C   
   $
��Left=�6.   $��423,147,0,0q�6I   $	��Top=�6^   �� 5D   
   -   5         ��Name$ lbl_dayname��5D      $�� ��6%   $
��Left=�60   $��522,343,0,0q�6K   $	��Top=�6`   $��48��6x   �� 5E   
   -	   5        $ 
lbl_daynum��5E      $�� ��6$   $
��Left=�6/   $��496,343,0,0q�6J   $	��Top=�6_   �� 5F   
   -
   5        $ 	lbl_month��5F      $�� ��6#   $
��Left=�6.   $��407,351,0,0q�6I   $	��Top=�6^   �� 5G   
   -   5        $ lbl_year��5G      $�� ��6"   $
��Left=�6-   $��325,346,0,0q�6H   $	��Top=�6]   1  +Arash.PersianDateControls.PersianDatePicker  5H   
   -   5          Name$ tarikh��5H   0   $y�Hidden=�6A   $
��Left=�6U   $��256,350,0,0q�6p   $	��Top=�6�   5J      5K      