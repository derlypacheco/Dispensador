   M S B A M L   `   `   `  ����G  CKMXDispenser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:KMXDispenser.ViewsKMXDispenser.Views  5           KMXDispenser.Views.Modules   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      ,local clr-namespace:KMXDispenser.Views  5        N� Title$  Modules��5
      $��Stretch=�5      $��Stretch=�5      .��5      � 
������ $��Stretch=�6$   $��Stretch=�6@   .+�5   
   � -   5         �Name$ 	ModuleBar��5      $	��100��6"   $	��Top=�6/   ���	#FF323232.+�5      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 62   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension     Kind$ FadeIn=�   Duration$ 00:00:01X�.��5      �� -   5         ��Name$ 
BackButton��5      $��Right=�6-   $��0,0,10,0q�6I   $	��Top=�6[   $	��309��6s   $��95��6   
������ 
������ $��0q�6�   .��5      � -   5        $ BackButtonContent��5      $��Stretch=�66   $��Stretch=�6T   $	��300��6p   $��90��6|    � ColumnDefinitions 5      �� 5      $��80 �6/   �� 5      $��50 �6/   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]   Kind$ MonitorDashboard=�62   $��80��6J   $��80��6U   $
��Left=�6a   $��
0,0,0,-0.4q�6|   6�   �� 5      -   5         ��Name$ 	BackTitle��5   $   $
��Left=�67   $��Center=�6R   $��70��6m   $��0.2,14,-141.8,16q�6y   $	��192��6�   $��1��6�   	 �� TextAlignment$	 Center=�6�   $��	ExtraBold"�6�   $��20(�6�   Volver�� 6�   al menú principal6  5      5      5        5       62     $ FadeIn=�$ 00:00:01X�.��5      �� $��Módulos��6   
�������$��60(�6>   $
��Bold"�6L   $
��Left=�6^   $��Center=�6y   $��	30,11,0,9q�6�   $	 Center=�6�   
 J� Effect
 5      3  -System.Windows.Media.Effects.DropShadowEffect  5       5!   *   5"      5#        5$   
    6.     $ SlideInFromRight=�$ 	00:00:0.5X�.��5%      � -   5        $ ModuleNavigationBar��5%      $��55��60   $	��Top=�6=   $��	0,100,0,0q�6U   ���	#FFE7D80A
 5&        5'         
BlurRadius$ 13Q�6'    � RowDefinitions 5)      �� 5*      $	��59* �6$   �� 5+       5-      �� 5.      $
��1.2* �6'   66   �� 5/      $
��1.2* �6'   66   .+�53      �� $��70��6   $��auto ��6)   .+�54      �� 
�������$��63��64   ��55      �� 56       �� 
TargetType" ��6$   .�57   "   ��  �� Property � �� �� Value 58   &   �� 59   *    �� 
TargetType" ��6:   .R�5:   .   � $��55��63   '  !System.Windows.VisualStateManager   VisualStateGroups 5;   2   %  System.Windows.VisualStateGroup  5<   6   CommonStates��   States. 5=   :    	  System.Windows.VisualState	  
Normal��6F   5>   7     5?   6   SelectionStates��. 5@   :   	  Selected�� 	  
Storyboard. 5A   >   �� .��5B   B   ��  g� Duration$ 0:00:00D�6Q    �� 
TargetName$ contentControl��6d    �� TargetProperty$2 ,(Control.Foreground).(SolidColorBrush.Color)�6�   	 �� To$ WhiteX�6�   5C   ?   5D   ;   	  5E   :   
Unselected��. 5F   >   �� .��5G   B   �� $ 0:00:00D�6Q   $ myback��6d   $1 +(Border.Background).(SolidColorBrush.Color)�6�   $ TransparentX�6�   5H   ?   5I   ;   	  5J   :   SelectedUnfocused��. 5K   >   �� .��5L   B   �� $ 0:00:00D�6Q   $ myback��6d   $1 +(Border.Background).(SolidColorBrush.Color)�6�   $ WhiteX�6�   5M   ?   5N   ;   5O   7   .+�5Q   2   ��  ��Name$ myback��69   
�������._�5S   6   ��  ��Name$ contentControl��6E   #��z��6]   #��z��6�   #��z��6�   5T   3   5U   /   5V   +   5X   #   5Y      .@�5[      �� -   5         ��Name$ AddModulesItem��5[   '   .��5]      �� $
��auto��6)   $��45��66   .+�5^   "     $ AddBox=�6:   $��30��5_   6   $��0,5,0,16q�5`   6   
���   �$��25��5b   6   5d   #   �� 5e   "   $��Alta de módulos��6,   $��Center=�5f   (   $
��Left=�5g   (   $	 Center=�5h   ,   $��
35,-55,0,0q�5i   &   
���   �$��28(�5k   (   $	��233��66   5l   #   5m      5n      5o      5p      �� 5q      $��60��6   $��auto ��6)   $��1��67   .+�5s      �� $��60��6    
���������5t      �� 5u      " ��6$   .�5v   "   ��  � �� 5w   &   �� 5x   *   " ��6:   .R�5y   .   � $��55��63    5z   2     5{   6   CommonStates��. 5|   :   	  
Normal��6F   5}   7     5~   6   SelectionStates��. 5   :   	  Selected��. 5�   >   �� .��5�   B   �� $ 0:00:00D�6Q   $ contentControl��6d   $2 ,(Control.Foreground).(SolidColorBrush.Color)�6�   $ WhiteX�6�   5�   ?   5�   ;   	  5�   :   
Unselected��. 5�   >   �� .��5�   B   �� $ 0:00:00D�6Q   $ myback��6d   $1 +(Border.Background).(SolidColorBrush.Color)�6�   $ TransparentX�6�   5�   ?   5�   ;   	  5�   :   SelectedUnfocused��. 5�   >   �� .��5�   B   �� $ 0:00:00D�6Q   $ myback��6d   $1 +(Border.Background).(SolidColorBrush.Color)�6�   $ WhiteX�6�   5�   ?   5�   ;   5�   7   .+�5�   2   �� $ myback��69   
�������._�5�   6   �� $ contentControl��6E   #��z��6]   #��z��6�   #��z��6�   5�   3   5�   /   5�   +   5�   #   5�      .@�5�      �� -   5        $ infoModulesItem��5�   '   .��5�      �� $
��auto��6)   $��45��66   .+�5�   "     $ Information=�6:   $��30��5�   6   $��0,5,0,16q�5�   6   
���   �$��25��5�   6   5�   #   �� 5�   "   $��Información de módulos��6,   $��Center=�5�   (   $
��Left=�5�   (   $
	 Left=�5�   ,   $��
40,-55,0,0q�5�   &   
���   �$��28(�5�   (   $	��311��66   5�   #   5�      5�      5�      5�       � 5�      -   5          �Name$ FrameContent��5�      $��Stretch=�5�      $��Stretch=�5�      
�������$��0,60,0,0q�5�   '     � NavigationUIVisibility$ Hidden=�5�      5�      5�      5�       � 5�   
   -	   5        $ ModuleFrameContent��5�      $��0,165,0,-0.4q�6,   5�      5�      