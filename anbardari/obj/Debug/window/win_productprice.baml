   M S B A M L   `   `   `  ����D  @anbardari, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:anbardari.windowanbardari.window  5   	   U QPersianDateControls, Version=1.2.4495.22344, Culture=neutral, PublicKeyToken=nullbDclr-namespace:Arash.PersianDateControls;assembly=PersianDateControlsArash.PersianDateControls 5   	   '    !anbardari.window.win_productprice   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35` \RibbonControlsLibrary, Version=3.5.41019.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:anbardari.window     5   	   dPersianDateControlsDclr-namespace:Arash.PersianDateControls;assembly=PersianDateControls     5   	   -   5          � Title$  win_productprice��5	   	   $	��300��6"   $	��500��60   $��RightToLeft=�6<   
������  � AllowsTransparency .  � WindowStyle$
 None=�6�    � WindowStartupLocation$ CenterScreen=�6�   .��5
      � .+�5   
   �� ���	#FFF4F4F5$
��Left=�6%   $	��300��6@   
���   �$	��Top=�6\   $	��500��6t   $��RightToLeft=�6�    �� RadiusY$ 10��6�    �� RadiusX$ 10��6�   $��	0,0,-10,0q�6�   �� 5   
   -   5        $
��Left=�5      $��48��6/   $
 27.5��6;   $
 27.5��6J   
�������$	��Top=�6h   $	��446��6�   $��34,1,0,0q�6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ -0.073Q�6&   T� 5      5       J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      ��5      �� 5      	 �� EndPoint$	 0.5,1&�6&   
 �� 
StartPoint$
 0.5,0&�67   .��5      �  � Color$ White��6#    � Offset$ 0Q�61   � 5      $ 	#FFC875D4��6#   $ 1Q�65   5      5      �� 5   
   $
��Left=�6   $��57��6/   $��	0,189,0,0q�6;   $ 10��6N   $ 10��6[   
�������$	��Top=�6w   $	��490��6�    5         5!      ��5#      �� 5$      $	 0.5,1&�6&   $
 0.5,0&�67   .��5%      � $ White��6#   $ 0Q�61   � 5&      $ 	#FFC875D4��6#   $ 1Q�65   5'      5)      �� 5*   
   $
��Left=�6   $��1��6/   $��
174,49,0,0q�6:   $ 10��6N   $ 10��6[   
�������$	��Top=�6w   $��3��6�   ��5+      �� 5,      $	 0.5,1&�6&   $
 0.5,0&�67   .��5-      � $ White��6#   $ 0Q�61   � 5.      $ 	#FFC875D4��6#   $ 1Q�65   5/      51      �� 52   
   -   5         ��Name$ label��52      $ ��مدیریت قیمت ها��6   $
��Left=�68   $��	156,4,0,0q�6S   $	��Top=�6f   $	��169��6~   $��42��6�   $��Center=�6�   $��21(�6�   &   System.Windows.Controls.DataGrid  53   
   -   5          Name$ DataGrid_productprice��53      $��Center=�62   $��0,89,0,0q�6O   $	��Top=�6a   $��96��6y   $	��490��6�   $��10(�6�      AutoGenerateColumns .  $��B yekan)�6�      Columns 54      0  *System.Windows.Controls.DataGridTextColumn  55      ,  &System.Windows.Controls.DataGridColumn   Header$ قیمت خرید��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   �� *productpricepurch+   HeaderStyle 56      �� 57       �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6    .�58      ��  �� Property � �� �� Value
 �  ��6I   �� 59       � ��$
 Bold"�6;   6J   5:         ElementStyle 5=      �� 5>      " ��6    .�5?      ��  � ��
 � � �6K   5@      5B        5C      $ قیمت فروش��6%    68   �� *productpricesell+  5D      $ توضیحات��6%    66   �� *productpricedesc+  5E      $ تاریخ ثبت��6%    68   �� *productpricedate+  5G      $ کابرثبت کننده��6%    6<   �� *
fullname+5L      �� 5M   
   -   5        $
 azta��5M      $��از تاریخ:��6   $
��Left=�62   $��
20,189,0,0q�6M   $	��Top=�6a   �� 5N   
   -   5        $ label1_Copy��5N      $��تا تاریخ��6%   $
��Left=�68   $��
20,218,0,0q�6S   $	��Top=�6g   �� 5O   
   -   5        $ label1��5O      $!��کابر ثبت کننده:��6    $
��Left=�6:   $��189,220,0,0q�6U   $	��Top=�6j   $ 0,0.542&�6�   �� 5P   
   -   5         ��Name$ 	textBlock��5P      $
��Left=�6'   $
��Wrap=�6B   $	��Top=�6V   �� 5Q   
   -	   5         ��Name$ Txt_username��5Q      $
��Left=�6(   $��26��6C   $��276,216,0,0q�6O    �� TextWrapping$
 Wrap=�6d   $	��Top=�6y   $	��120��6�   �� 5S   
   -
   5         ��Name$ image1��5S      $
��Left=�6    $��25��6;   $	��Top=�6G   $��29��6_   $��
414,13,0,0q�6j   $ -0.172,0.116&�6~   $��../img/exit.png��6�    � Cursor$
 Hand��6�   6�   �� 5T   
   -   5         ��Name$ btn_create_productprice��5T      $��ثبت قیمت جدید��62   $
��Left=�6J   $��22��6e   $��185,268,0,0q�6q   $	��Top=�6�   $	��111��6�   6�   �� 5U   
   -   5        $ image��5U      $
��Left=�6   $��26��6:   $	��Top=�6F   $��38��6^   $��453,216,0,0q�6i   $��../img/search.ico��6~   6�   1  +Arash.PersianDateControls.PersianDatePicker  5X   
   -   5          Name$ aztarikh��5X   0   $
��Left=�6B   $��33��6]   $��
66,185,0,0q�6i   $	��Top=�6}   $	��110��6�      DisplayDateF BPersianDate, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null   Arash.PersianDateConverter$ 1400/1/1 6�       SelectedDate$  1400/1/1 6�     5Y   
   -   5        $ tatarikh��5Y   0   $
��Left=�6B   $��
66,218,0,0q�6]   $	��Top=�6q   �� 5Z   
   $1��+قیمت های مربوط به کالای:��6   $
��Left=�63   $��
105,55,0,0q�6N   $	��Top=�6b   �� 5[   
   -   5        $ lbl_productname��5[      $�� ��6)   $
��Left=�64   $��
240,58,0,0q�6O   $	��Top=�6c   $	��156��6{   5^      5_      