   M S B A M L   `   `   `  ����F  BNotePad.wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:NotePad.wpfNotePad.wpf  5   	       NotePad.wpf.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:NotePad.wpf     5   	   -   5          �Name$  wndMainWindow��5   	    � Title$ Untitled - NotePad��5	   	   $	��720��6$   $
��1096��61    � WindowStartupLocation$ CenterScreen=�6>   .��5
      �  � RowDefinitions 5   
   �� 5      $��38 �6   �� 5      �� 5      -   5         ��Name$ 	rowFooter��5      $��32 �6/   .+�5   
   ��    MenuBackground#��[  6   o� 5   
   
������ $��Center=�6(   $��Center=�6C     BackgroundText#��[ 6e   .@�5      m� $��Center=�6   $
��File��62   .@�5      m� -   5         m�Name$ mnuNew��5      $	��New��6+    m� InputGestureText$ Ctrl+N��68   6R   m� 5      $��
New window��6   $ Ctrl+Shift+N��6/   m� 5      -   5        $ mnuOpen��5      $
��Open��6,   $ Ctrl+O��6:   6T   m� 5      -   5        $ mnuSave��5      $
��Save��6,   $ Ctrl+S��6:   6T   m� 5      -   5        $ 	mnuSaveAs��5      $��Save as��6.   $ Ctrl+Shift+S��6?   6_   �� 5      m� 5      $��
Page setup��6   m� 5       $��Print��6   $ Ctrl+P��6*   �� 5!      m� 5"      -   5        $ mnuExit��5"      $
��Exit��6,   6:   5#      m� 5%      $��Center=�6   $
��Edit��62   .@�5&      m� $
��Undo��6   $ Ctrl+Z��6)   ${�False��6C   �� 5'      m� 5(      $	��Cut��6   $ Ctrl+X��6(   ${�False��6B   m� 5)      $
��Copy��6   $ Ctrl+C��6)   ${�False��6C   m� 5*      $��Paste��6   $ Ctrl+V��6*   m� 5+      $��Delete��6   $	 Del��6+   ${�False��6B   �� 5,      m� 5-      $
��Find��6   $ Ctrl+F��6)   ${�False��6C   m� 5.      $��	Find next��6   $ F3��6.   ${�False��6D   m� 5/      $��Find previous��6   $ Shift+F3��62   ${�False��6N   m� 50      $��Replace��6   $ Ctrl+H��6,   ${�False��6F   m� 51      $��Go to��6   $ Ctrl+G��6*   �� 52      m� 53      $��
Select all��6   $ Ctrl+A��6/   m� 54      $��	Time/Date��6   $ F5��6.   �� 55      m� 56      $
��Font��6   57      m� 59      $��Center=�6   $
��View��62   .@�5:      m� $
��Zoom��6   .@�5;      m� $��Zoom in��6   $ 	Ctrl+Plus��60   m� 5<      $��Zoom out��6   $ 
Ctrl+Minus��61   m� 5=      $��Default zoom��6   $ Ctrl+0��65   5>      m� 5?      -   5        $ mnuStatusBar��5?      $��
Status bar��61    m� IsCheckable$
 True��6E    m� 	IsChecked$
 True��6X   6i   m� 5@      -	   5        $ mnuWordWrap��5@      $��	Word wrap��60   $
 True��6C   $
 True��6V   6g   5A      5B      �� 5E   
     MenuForeground#��[ 6   $��1��6;   �� 5F   
   $��1��6   $
��Auto=�6$   .��5G      �� -
   5        	 ��Name$	 
txtWordpad��5G      $��1��6*   
������   ForegroundText#��[ 6P   $��0q�5H      $��10q�6&   $��16(�63   $��Lucida Console)�6A   
 �� 
CaretBrush

 ����� �� AcceptsReturn$
 True��5I       �� TextWrapping$
 Wrap=�6'   6u   5J      �� 5M   
   #��[  6   $��2��6;   � 5O   
   $��2��6    � ColumnDefinitions 5P      �� 5Q      �� 5R      $	��120 �6#   �� 5S      $	��160 �6#   �� 5T      $	��120 �6#   .+�5X      ��  �� Orientation$ 
Horizontal=�6   $��Center=�62   $��10, 0q�6M   .+�5Y      �� $	��Ln ��6   #��[ 6'   �� 5Z      -   5         ��Name$ lblLineCount��5Z      $��1��62   #��[ 6;   �� 5[      $��, Col ��6   #��[ 6*   �� 5\      -   5        $ lblColumnCount��5\      $��0��64   #��[ 6=   5]      �� 5_      $��1��6   $��1��6(   $
��Left=�62   ���	#FF2323236M   �� 5`      $��1��6   $
��100%��6(   $��Center=�64   $��10, 0q�6O   #��[ 6^   �� 5b      $��2��6   $��1��6(   $
��Left=�62   ���	#FF2323236M   �� 5c      $��2��6   $��Windows (CRLF)��6(   $��Center=�6>   $��10, 0q�6Y   #��[ 6h   �� 5e      $��3��6   $��1��6(   $
��Left=�62   ���	#FF2323236M   �� 5f      $��3��6   $��UTF-8��6(   $��Center=�65   $��10, 0q�6P   #��[ 6_   5g      5h      5i      