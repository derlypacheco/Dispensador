   M S B A M L   `   `   `  ����G  CKMXDispenser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:KMXDispenser.ViewsKMXDispenser.Views  5      "    KMXDispenser.Views.Dashboard   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      ,local clr-namespace:KMXDispenser.Views  5        N� Title$  	Dashboard��5
       N� 
Background
 ���� .��5      � -   5         �Name$ DashboardGridMain��5      .+�5   
   ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6.   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension     Kind$ FadeIn=�   Duration$ 00:00:01X�.��5      �� $��Menú principal��6   
�������$��60(�6A   $
��Bold"�6O   $
��Left=�6a   $	��Top=�6|   $��	30,30,0,0q�6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      5   &   5      � 5   
   -   5        $ DashboardGridModules��5       � ColumnDefinitions 5      �� 5      $
��1.3* �6$   �� 5      $
��1.3* �6#   �� 5      $
��1.3* �6#    � RowDefinitions 5      �� 5      $
��0.3* �6    �� 5      �� 5      $
��0.3* �6    .+�5        $��0��6�   $��1��6�    62     $ FadeIn=�$ 
00:00:01.7X�.��5       �� -   5        	 ��Name$	 AddModulesButton��5       $��0��63   $��1��6C   $	��250��6P   $	��260��6\   
������ 
������  5!        5"      .��5$      � .+�5%      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]
   Kind$
 
ViewModule=�62   $	��250��6D   $	��200��6P   $��	0,0,10,30q�6]   $��Center=�6p   $��Center=�6�   �� 5&      -   5         ��Name$ ModulesTitle��5&   $   $��Módulos��6:   $��Bottom=�6I   $��Center=�6d   $��30(�6�   6�   5'      5(      5)        5*      $��1��62   $��1��6B    6O     $ FadeIn=�$ 
00:00:01.7X�.��5+      �� -   5        $	 ManualsButton��5+      $��1��60   $��1��6@   $	��250��6M   $	��260��6Y   
������ 
������  5,        5-      .��5/      � .+�50        $

 Book=�62   $	��250��6>   $	��200��6J   $��	0,0,10,30q�6W   $��Center=�6j   $��Center=�6�   6�   �� 51      -   5        $ ManualsTitle��51   $   $��Manuales��6:   $��Bottom=�6J   $��Center=�6e   $��30(�6�   6�   52      53      54        55      $��2��63   $��1��6C    6P     $ FadeIn=�$ 
00:00:01.7X�.��56      �� -   5        $	 ConfigButton��56      $��2��6/   $��1��6?   $	��250��6L   $	��260��6X   
������ 
������  57        58      .��5:      � .+�5;        $
 Settings=�62   $	��250��6B   $	��200��6N   $��	0,0,10,30q�6[   $��Center=�6n   $��Center=�6�   6�   �� 5<      -   5        $ ConfigTitle��5<   $   $��Configuración��69   $��Bottom=�6N   $��Center=�6i   $��30(�6�   6�   5=      5>      5?        5@       62     $ FadeIn=�$ 00:00:03X�.��5A       � -	   5          �Name$ FrameContent��5A      $��Stretch=�5B      $��Stretch=�5C      $
��auto��5D      $
��auto��5E        � NavigationUIVisibility$ Hidden=�5F      $��0,0,-530.6,-350.2q�61   5G      5I      5J      5K      