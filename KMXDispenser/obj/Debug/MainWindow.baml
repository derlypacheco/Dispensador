   M S B A M L   `   `   `  ����G  CKMXDispenser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:KMXDispenserKMXDispenser  5   	       KMXDispenser.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   &localclr-namespace:KMXDispenser  5   	     � Title$  
MainWindow��5	   	    � WindowStyle$
 None=�6   ���	#FF3F3E3E � WindowState$ 	Maximized=�6F   $��868.8��6^   $��1257.6��6m   .��5      � -   5         �Name$
 Main��5      ���	#FF453F3F.+�5   
   � -   5        $ MainDispenserTitle��5      $��55��6+   $	��Top=�67   ���	#FF282828$��
0,0,-0.4,0q�6f   .+�5      �� -   5         ��Name$ DispenserTextTitle��5      $8��2Dispensador de pines Kufferath México S.A de C.V.��64    �� TextAlignment$ Center=�6m   $��Center=�6�   $��20(�6�   
�������$��0,14,3.6,14q�6�   $
��Bold"�6�   �� 5      $��/Img/KufferathLogo.png��6   $	��212��64   $��42��6@   $
��Left=�6L   $��Bottom=�6g   $��	29,0,0,10q�6�   F� 5      +������    �`�K`O�Ѡ[/`O�Ѡ[/�^��	$	��100��6C   $	��250��6S   $��0,-5.8,-1.5,0q�6b    �� Stretch$
 Fill=�6y   
���   �$	��Top=�6�   $��Right=�6�   ���	#FFE1E203$
��60.8��6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      5      � 5      -   5        $ WinControls��5      $��50��6(   $	��150��64   $��Right=�6@    � ColumnDefinitions 5      �� 5      6)   �� 5      6)   .+�5      �� -   5        	 ��Name$	 MinimizeButton��5      
 � ToolTip$
 Minimizar ventana��61   $��0��6M   $��50��6]   
������ 
������ .��5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]   Kind$ WindowMinimize=�6.   
���   �$��45��6W   $��50��6b   $��Center=�6n   6�   5      �� 5      -   5        $	 CloseButton��5      $
 Cerrar ventana��6.   $��1��6G   $��50��6W   
������ 
������ .��5        $ Close=�6.   
���   �$��45��6N   $��50��6Y   $��Center=�6e   5      5      5       � 5"   
   -   5        $ MenuSelectionBar��5"      $	��120��6)   $
��Left=�65   $��-1,55,0,-0.2q�6P   ���	#FF353535.+�5#      �� $��Center=�6   .+�5$      �� -   5         ��Name$ ListBarMenu��5$      ��5%      �� 5&       �� 
TargetType" ��6    .�5'      ��  �� Property � �� �� Value 5(   "   �� 5)   &    �� 
TargetType" ��66   .R�5*   *   � '  !System.Windows.VisualStateManager   VisualStateGroups 5+   .   %  System.Windows.VisualStateGroup  5,   2   CommonStates��   States. 5-   6      System.Windows.VisualState  
Normal��6B   5.   3     5/   2   SelectionStates��. 50   6     Selected��   
Storyboard. 51   :   �� .��52   >   ��  g� Duration$ 0:00:00D�6M    �� 
TargetName$ contentControl��6`    �� TargetProperty$2 ,(Control.Foreground).(SolidColorBrush.Color)�6�   	 �� To$ WhiteX�6�   53   ;   54   7     55   6   
Unselected��. 56   :   �� .��57   >   �� $ 0:00:00D�6M   $ myback��6`   $1 +(Border.Background).(SolidColorBrush.Color)�6   $ TransparentX�6�   58   ;   59   7     5:   6   SelectedUnfocused��. 5;   :   �� .��5<   >   �� $ 0:00:00D�6M   $ myback��6`   $1 +(Border.Background).(SolidColorBrush.Color)�6   $ BlackX�6�   5=   ;   5>   7   5?   3   .+�5A   .   ��  ��Name$ myback��65   
���   � 5B   2     5C   6      ShadowDepth$ 3Q�6G   ._�5F   2   ��  ��Name$ contentControl��6A   #��z��6Y   #��z��6�   #��z��6�   5G   /   5H   +   5I   '   5K      5L      .@�5N      �� -	   5         ��Name$ DashboardItem��5N   #   $	��120��6:   
�������$
 Menú Principal��6Z   $	��116��6s   $	��Top=�6   $��0q�6�   .��5O      �� .+�5P        $ MonitorDashboard=�66   $	��100��6N   $	��120��6Z   
�������$��Center=�6z   $��Center=�6�   $��	0,-10,0,0q�6�   5Q      5R      �� 5S      -
   5        $ UsuarioItem��5S   #   $	��120��68   $
 Usuarios��6F   $	��115��6Y   $	��Top=�6e   
�������.��5T      �� .+�5U        $ UserMultiple=�66   $	��100��6J   $	��120��6V   
�������$��Center=�6v   $��Center=�6�   $��	0,-10,0,0q�6�   5V      5W      �� 5X      -   5        $ 
BuscarItem��5X   #   $	��120��67   $
 Buscar��6E   $	��115��6V   
�������.��5Y      �� .+�5Z        $ Search=�66   $	��100��6D   $	��120��6P   
�������$��Center=�6p   $��Center=�6�   $��	0,-10,0,0q�6�   5[      5\      �� 5]      -   5        $ DispensarItem��5]   #   $	��120��6:   $
 	Dispensar��6G   $	��115��6[   
�������.��5^      �� .+�5_        $ CartPlus=�66   $	��100��6F   $	��120��6R   
�������$��Center=�6r   $��Center=�6�   $��	0,-10,0,0q�6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   z�5`   "   V� 5a   &   .~�5b   *   ��  �� ScaleY$ 1Q�69    �� ScaleX$ -1Q�6D   �� 5c   *    �� AngleY$ 0Q�68     �� AngleX$  0Q�6C   �� 5d   *   ! �� Angle$! 0Q�6:   T� 5e   *   5f   '   5h      5i      5j      �� 5k      -   5        $ 
SurtirItem��5k   #   $	��120��67   $
 Surtir material��6E   $	��115��6_   
�������.��5l      �� .+�5m        $ 
LibraryAdd=�66   $	��100��6H   $	��120��6T   
�������$��Center=�6t   $��Center=�6�   $��	0,-10,0,0q�6�   5n      5o      5p      5q      � 5r      -   5        $ 
Sliderline��5r      $��10��6'   $��Right=�62   ���	#FF1A1A1A$��0,0,-4,-0.4q�6e   6|   5s      � 5t   
   -   5        $ Content��5t      ���	#FF434343$��125,55,-0.4,-0.2q�67   .+�5v       � -   5        "  �Name$" ContentMultiScreen��5v      $��Stretch=�5w      $
��auto��5x      $
��auto��5y      $��Stretch=�5z      #  � NavigationUIVisibility$# Hidden=�5{      $��0,0,0.6,-0.4q�63   5|      5~      5      5�      