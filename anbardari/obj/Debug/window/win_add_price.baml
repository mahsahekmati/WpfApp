   M S B A M L   `   `   `  ����D  @anbardari, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:anbardari.windowanbardari.window  5   	   U QPersianDateControls, Version=1.2.4495.22344, Culture=neutral, PublicKeyToken=nullbDclr-namespace:Arash.PersianDateControls;assembly=PersianDateControlsArash.PersianDateControls 5   	   $    anbardari.window.win_add_price   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35` \RibbonControlsLibrary, Version=3.5.41019.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:anbardari.window     5   	   dPersianDateControlsDclr-namespace:Arash.PersianDateControls;assembly=PersianDateControls     5   	   -   5          � Title$  win_add_price��5	   	   $	��450��6   $	��800��6,    � WindowStyle$
 None=�69    � WindowStartupLocation$ CenterScreen=�6c   .��5
      � .+�5   
   �� $
��Left=�6   $	��414��6/   
���   �$	��Top=�6K   $	��780��6c   $��3,15,0,0q�6o   ��5      �� 5       �� ImageSource$ /img/back22.jpg��6    �� Opacity$	 0.2Q�6;    j� Stretch$
 Fill=�6I   5      �� 5   
   $��قیمت خرید��6   $
��Left=�6$   $��614,148,0,0q�6?   $	��Top=�6T   $��22(�6l   $��42��6z   $	��134��6�   �� 5   
   $��قیمت فروش��6   $
��Left=�6$   $��606,196,0,0q�6?   $	��Top=�6T    J� RenderTransformOrigin$ -0.811,0.752&�6l   $��22(�6�   �� 5   
   $"��کاربر ثیت کننده��6   $
��Left=�6*   $��585,240,0,0q�6E   $	��Top=�6Z   $��22(�6r   $	��144��6�   �� 5   
   $��توضیحات��6   $
��Left=�6"   $��633,287,0,0q�6=   $	��Top=�6R   $��22(�6j   �� 5   
   $��
تاریخ��6   $
��Left=�6    $��659,373,0,0q�6;   $	��Top=�6P   $��22(�6h   �� 5   
   -   5         ��Name$ txt_productpurch��5      $��1��6,   $
��Left=�69   $��384,156,0,0q�6T    �� TextWrapping$
 Wrap=�6i   $	��Top=�6~   $	��201��6�   $��26��6�   .��6�   	 J� Effect	 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      .��5      ��5      �� 5      
 �� EndPoint$
 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ Black��6#   � 5      $ White��6#    � Offset$ 1Q�61   5      .��5   "   5      �� 5    
   -   5        $ txt_productsell��5       $��2��6+   $
��Left=�68   $��384,203,0,0q�6S   $
 Wrap=�6h   $	��Top=�6}   $	��201��6�   $��26��6�    �� 	MaxLength$ 11��6�   .��6�   	 5!        5"      .��5#      ��5$      �� 5%      $
 0.5,1&�6&   $ 0.5,0&�67   .��5&      � $ Black��6#   � 5'      $ White��6#   $ 1Q�61   5(      .��5)   "   5*      �� 5+   
   -   5        $ txt_productdesc��5+      $
��Left=�6+   $��384,300,0,0q�6G   $
 Wrap=�6\   $	��Top=�6q   $	��201��6�   $��58��6�   $��3��6�   .��6�   	 5,        5-      .��5.      ��5/      �� 50      $
 0.5,1&�6&   $ 0.5,0&�67   .��51      � $ Black��6#   � 52      $ White��6#   $ 1Q�61   53      .��54   "   55      �� 56   
   -   5         ��Name$ btn_create_newprice��56   )   $��ثبت قیمت جدید��6   $
��Left=�6F   $��109,265,0,0q�6a   $	��Top=�6v   $��42��6�   $	��120��6�   $��18(�6�   $
��Bold"�6�   $��Arial)�6�   $��5��6�   	 57        58      ��5:      �� 5;      $
 0.5,1&�6&   $ 0.5,0&�67   .��5<      � $ Black��6#   � 5=      $ White��6#   $ 1Q�61   5>      5@      �� 5A   
   $��Center=�6    �� RadiusX$ 20��61    �� RadiusY$ 20��6>   $��66��6K   $��0,18,0,0q�6W   
���   �$	��Top=�6x   $	��780��6�   ��5B      �� 5C      $
 0.5,1&�6&   $ 0.5,0&�67   .��5D      � $ Black��6#   � 5E      $ White��6#   $ 1Q�61   5F      5H      �� 5I   
   $+��%فرم افزودن قیمت جدید��6   $��Center=�6/   $��Center=�6S   $��0,28,0,0q�6p   $	��Top=�6�   $	��244��6�   $��24(�6�   $��56��6�   $��Arial)�6�   $
��Bold"�6�   �� 5J   
   $
��Left=�6   $	��154��6+   $��
92,102,0,0q�68   $	��Top=�6L   $	��162��6d   $��/img/mottakere.png��6p   �� 5K   
   -   5        $ btn_exit��5K       $��خروج��6   $
��Left=�62   $��109,337,0,0q�6M   $	��Top=�6b   $��42��6z   $	��120��6�   $��18(�6�   $
��Bold"�6�   $��Arial)�6�   $��6��6�   	 5L        5M      ��5O      �� 5P      $
 0.5,1&�6&   $ 0.5,0&�67   .��5Q      � $ Black��6#   � 5R      $ White��6#   $ 1Q�61   5S      5U      1  +Arash.PersianDateControls.PersianDatePicker  5W   
   -   5          Name$ tarikh��5W   0   $y�Hidden=�6@   $
��Left=�6U   $��253,381,0,0q�6p   $	��Top=�6�   $	��127��6�   $��34��6�   �� 5X   
   -   5         ��Name$ lbl_productname��5X      $�� ��6)   $
��Left=�64   $��
293,94,0,0q�6O   $	��Top=�6c   $��35��6{   $	��223��6�   �� 5Y   
   -	   5        $ lbl_date��5Y      $�� ��6"   $
��Left=�6-   $��388,383,0,0q�6H   $	��Top=�6]   $	��204��6u   �� 5Z   
   -
   5        $ lbl_username��5Z      $�� ��6&   $
��Left=�61   $��388,249,0,0q�6L   $	��Top=�6a   $	��203��6y   $��36��6�   5\      5]      