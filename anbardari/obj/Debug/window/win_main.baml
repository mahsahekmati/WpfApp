   M S B A M L   `   `   `  ����D  @anbardari, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:anbardari.windowanbardari.window  5   	   U QPersianDateControls, Version=1.2.4495.22344, Culture=neutral, PublicKeyToken=nullbDclr-namespace:Arash.PersianDateControls;assembly=PersianDateControlsArash.PersianDateControls 5   Y       anbardari.window.win_main   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35` \RibbonControlsLibrary, Version=3.5.41019.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:anbardari.window     5   	   MCustom@http://schemas.microsoft.com/winfx/2006/xaml/presentation/ribbon  5   	   ^PersianDateControlsDclr-namespace:Arash.PersianDateControls;assembly=PersianDateControls  6Y   -   5          � Title$  win_main��5	   	   $	��495��6   $	��826��6'   .��5      � $��0,0,2,-6q�6   .+�5   
   .  (Microsoft.Windows.Controls.Ribbon.Ribbon  $��RightToLeft=�6   $��
0,10,0,294q�64      QuickAccessToolBar 5      @  :Microsoft.Windows.Controls.Ribbon.RibbonQuickAccessToolBar  5      .@�5      9  3Microsoft.Windows.Controls.Ribbon.RibbonSplitButton  8  2Microsoft.Windows.Controls.Ribbon.RibbonMenuButton   SmallImageSource$ /img/advanced.tiff��6/   .@�5      ;  5Microsoft.Windows.Controls.Ribbon.RibbonSplitMenuItem  $��درباره ما ��65   6  0Microsoft.Windows.Controls.Ribbon.RibbonMenuItem   ImageSource$ /img/44.png��6I     5      $��ارتباط با ما  ��65   $ /img/12.png��6M     5      -   5        $��	خروج ��5   5   $ /img/advanced.tiff��6D   6e   5      5         ApplicationMenu 5      =  7Microsoft.Windows.Controls.Ribbon.RibbonApplicationMenu  5      .@�5      F  @Microsoft.Windows.Controls.Ribbon.RibbonApplicationSplitMenuItem  -   5        $��تعریف کاربران��5   <   $ /img/12.png��6S   6m     5      $-��' تعریف دسترسی کاربران��6<   $ /img/12.png��6[     5      -   5          Name$ system_part��5   <   $'��! تعریف اجزای سیستم��6Q   $ /img/12.png��6m   6�     5      $"��تغییر کلمه عبور��6<   $ /img/12.png��6U     5      -   5        $4��.کنترل ورود و خروج کاربران��5   <   $ /img/12.png��6_   6y     5       -   5        $��تعریف مشتریان��5    <   $ /img/12.png��6S   6m     5!      $'��!تهیه فایل پشتیبان ��6<   $ /img/12.png��6X   5"      .@�5%      1	  +Microsoft.Windows.Controls.Ribbon.RibbonTab	  $��کالاها��6   .@�5&      3
  -Microsoft.Windows.Controls.Ribbon.RibbonGroup
  $��نمایش کالاها ��6%   $��70��6<   $��0,0,0,10q�6H   .@�5'      4  .Microsoft.Windows.Controls.Ribbon.RibbonButton  -   5           Label$ نمایش کالاها��5'   *      LargeImageSource$ ../img/product2.gif��6?   6f   5(      
  5*      $��بخش کالاها ��6%   $��70��6:   $��0,0,0,10q�6F   .@�5+        $ مدیریت قیمت��6*      SmallImageSource$ ../img/13.png��6>   $��0,0,0,5q�6_     5,      $ موجودی کالاا��6*   $ ../img/4.png��6?     5-      $ نمودار فروش��6*   $ ../img/nemudar.jpg��6>   5/      
  50      52      	  54      $��فروش��6   $
��80px��6-   .@�55      
  $��نمایش فاکتور ��6%   $��70��6<   $��0,0,0,10q�6H   .@�56        -   5        	  Name$	 createfactor��56   *   $ ثبت سفارش��6@   $ ../img/product2.gif��6R   6y   57      58      	  5:      $��انبارداری��6   $
��80px��62   	  5<      $��گزارشات��6   $��	64,0,-2,0q�60   5>      �� 5?   
   $
��Left=�6   $	��100��6/   $��
14,331,0,0q�6<   
���   �$	��Top=�6_   $	��784��6w   ��5@      �� 5A      
 �� EndPoint$
 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5B      �  � Color$ 	#FFEFF0F3��6#   � 5C      $ 	#FF9DB2F3��6#    � Offset$ 1Q�65   5D      5I      �� 5J   
   $��نام کاربر��6   $
��Left=�6$   $��706,360,0,0q�6?   $	��Top=�6T   $��20(�6l   �� 5K   
   $(��"نام خانوادگی کاربر��6   $
��Left=�6-   $��497,362,0,0q�6H   $	��Top=�6]   $��20(�6u   �� 5L   
   $��ساعت ورود��6   $
��Left=�6$   $��312,360,0,0q�6?   $	��Top=�6T   $��20(�6l   �� 5M   
   $0��*سیستم فروش و انبار داری��6   $
��Left=�62   $��
21,358,0,0q�6M   $	��Top=�6a   $��20(�6y   �� 5N   
   -	   5         ��Name$ lbl_name��5N      $�� ��6"   $
��Left=�6-   $��658,347,0,0q�6H   $	��Top=�6]   $��48��6u   $��54��6�   $��20(�6�   �� 5O   
   -
   5        $ 
lbl_family��5O      $�� ��6$   $
��Left=�6/   $��441,343,0,0q�6J   $	��Top=�6_   $��48��6w   $��54��6�   $��20(�6�   �� 5P   
   -   5        $ lbl_time��5P      $�� ��6"   $
��Left=�6-   $��252,354,0,0q�6H   $	��Top=�6]   $��48��6u   $��54��6�   $��20(�6�   1  +Arash.PersianDateControls.PersianDatePicker  5V   
   -   5          Name$ tarikh��5V   0   $y�Hidden=�6@   $
��Left=�6T   $��318,276,0,0q�6o   $	��Top=�6�   5\      5]      