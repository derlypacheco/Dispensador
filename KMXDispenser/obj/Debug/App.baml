   M S B A M L   `   `   `  ����G  CKMXDispenser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:KMXDispenserKMXDispenser  5          KMXDispenser.App   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      ,localclr-namespace:KMXDispenser     5        �� 	Resources  5       �� MergedDictionaries �� Source   placeHolder �� 
TargetType �� BasedOn �� Property �� Value �� 
TargetType ��Name	 K� ZIndex
 �� Path �� RelativeSource �� Mode �� UpdateSourceTrigger
 � Tag �� Triggers �� Binding �� Source%  System.Windows.Markup.Reference �� Value % !MaterialDesignCircularProgressBar  PrimaryHueMidBrush � 	Resources  Key �� 
TargetName �� TargetProperty g� RepeatBehavior W� From	 W� To g� Duration O� KeyTime O� Value �Name �� ScaleX F�Name
 �� Top  �� Left! J� RenderTransformOrigin" E� 
StartPoint# �� ElementName  StartPointConverter$ �� 	Converter% �� SweepDirection& �� Size  ArcSizeConverter' �� 
IsLargeArc  LargeArcConverter( `� 	Converter) �� Point  ArcEndPointConverter* �� CenterX " RotateTransformCentreConverter+ �� CenterY, �� Triggers- ^� 
Conditions. �� Binding/ �� Value 	 NotZeroConverter0 N� EnterActions1 �� BeginStoryboardName2 ��Name 
 IsIndeterminateStoryboard3 N� ExitActions4 ]� 
Conditions5 �� Property ' #IsFullyIndeterminateScaleStoryboard�� 5   
    5	      �� 5
      $e _pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Light.xaml?�6%   5      �� 5      $h bpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Defaults.xaml?�6%   5      �� 5      $v ppack://application:,,,/MaterialDesignColors;component/Themes/Recommended/Primary/MaterialDesignColor.Indigo.xaml?�6%   5      �� 5      $s mpack://application:,,,/MaterialDesignColors;component/Themes/Recommended/Accent/MaterialDesignColor.Lime.xaml?�6%   5      %�  &	        7��&	 l    7  7  7  7  7  7  7 	 7 
 7  �� 5      " ��6(   8   .�5      ��  � �� 5      �� 5      " ��6*   .R�5      � .+�5   "   �� $ 
textSource��5   "   
������ $	 2��5    "   ��5   *   �� $

 Text� �� *TemplatedParent+$ TwoWay=�$ PropertyChanged=�5    "   �� 5!   "   #��z 6*   #��z��6G   $	 1��6q   .��6�   ��5"   &   �� 5#   *   " ��60   .�5$   .   ��  � ��
 ���� 6K    5%   .   �� 5&   2    6>   �� $

 Text�   *
textSource+  6}   .a�5'   6   ��  � ��
 �����6S   5(   3   5*   +   .��5+   5   5,   #   5-      5.      50      51      �� 52      " �6>   .�53      ��  � ��# �  6/   �� 54       � ��
 ���� 6/   �� 55       � ��$ 10��6*   �� 56       � ��$ 10��6+   �� 57       � �� 58      �� 59      " �6*    5:      ���� 5;   "   IsIndeterminateStoryboard $ RotateTransform��6O   $ Angle�6l   $ Forever��6�   .��5<   &   W� $ 0X�66   $	 359X�6?   $ 0:0:2D�6H   5=   #   �� 5>   "   '#IsFullyIndeterminateScaleStoryboard .��5?   &   U� $* $FullyIndeterminateGridScaleTransform��6D   $ ScaleX�5@   <   $ Forever��5A   <   .\�5B   *   �� $ 0��6?   $	 0.0Q�6K   �� 5C   *   $ 0:0:1��6?   $	 1.0Q�6O   �� 5D   *   $ 0:0:4��6?   $	 0.0Q�6O   5E   '   W� 5F   &   $ RotateTransform��66   $ Angle�5G   .   $ Forever��5H   .   $ 00X�5I   .   $	 359X�68   $ 0:0:1.25D�6A   5J   #   5K      .R�5L      � $ TemplateRoot��6#   }�.  .+�5M   "   � $ FullyIndeterminateGrid��6'   z�5N   &   �� 5O   *   ($FullyIndeterminateGridScaleTransform��$ 0Q�6g   5Q   #   � 5R   "   $ PathGrid��6'   $��2q�69   �� 5S   "   .+�5T   &   A� #��z��6.   #��z��6R   #��z��6r   F� 5U   &   $
 Path��6+   #��z��69   $��14��6_   $ 2��5V   #   $  2��62   $
! 0, 0&�5W   #   ��5X   *   B� 5Y   .   .��5Z   2   E� " 6=   �� $# PathGrid��$
 ActualWidth�8$   $ OneWay=�.��5[   6   �� $% 	Clockwise=�5\   9   & 5[   A   �� $# PathGrid��$
 ActualWidth�8$  $ OneWay=�' 5]   :   `� 5^   >   8(  .1�5_   B   �� $
 Value�6|    6J   �� *TemplatedParent+6|   �� 5`   B   $
 Minimum�6|    6J   �� *TemplatedParent+6|   �� 5a   B   $
 Maximum�6|    6J   �� *TemplatedParent+6|   �� 5b   B   $*# $FullyIndeterminateGridScaleTransform��6J   $
 ScaleX�6}   5c   ?   ) 5e   :   `� 5f   >   8(  .1�5g   B   �� $# PathGrid��6J   $
 ActualWidth�6a   �� 5h   B   $
 Value�6|    6J   �� *TemplatedParent+6|   �� 5i   B   $
 Minimum�6|    6J   �� *TemplatedParent+6|   �� 5j   B   $
 Maximum�6|    6J   �� *TemplatedParent+6|   �� 5k   B   $*# $FullyIndeterminateGridScaleTransform��6J   $
 ScaleX�6}   5l   ?   5n   7   5o   3   5p   /   z�5r   *   V� 5s   .   .~�5t   2   �� RotateTransform��* 5u   :   �� $# PathGrid��$
 ActualWidth�8$  $ OneWay=�+ 5v   :   �� $# PathGrid��$
 ActualWidth�8$  $ OneWay=�5w   /   5y   '   5z   #   5{      , 5|      ^� 5}   "   - 5~   &   �� 5   *   . 64   �� *IsIndeterminate+ �� *Self+/ True6~   �� 5�   *   . 64   �� *	IsVisible+ �� *Self+/ True6x   �� 5�   *   . 64   �� *Value+ �� *Self+8$  / True6�   0 5�   &   �� 5�   *   $$1 IsFullyIndeterminateStoryboard��6;   �� 5�   *   $2 IsIndeterminateStoryboard��5�   2   8�� 3 5�   &   �� 5�   *   $1 IsIndeterminateStoryboard��6;   5�   #   ]� 5�   "   4 5�   &   �� 5�   *   5 �@�IsIndeterminate/ . 6O   �� 5�   *   5 �@�Value$/ 0Q�6E   �� 5�   *   5 �@J�	IsVisible/ . 6I   0 5�   &   �� 5�   *   $1 IsIndeterminateStoryboard��6;   �� 5�   *   $$2 IsFullyIndeterminateStoryboard��5�   2   8�� 3 5�   &   �� 5�   *   $$1 IsFullyIndeterminateStoryboard��6;   5�   #   5�      5�      5�      5�      5�      