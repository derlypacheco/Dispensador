   M S B A M L   `   `   `  ����G  CKMXDispenser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:KMXDispenser.ViewsKMXDispenser.Views  5          KMXDispenser.Views.Search   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      ,local clr-namespace:KMXDispenser.Views  5      -   5          N� Title$  Search��5
      .��5      � -   5         �Name$ SearchingGridMain��5      .+�5   
   � -   5        $ 	SearchBar��5      $	��100��6"   $	��Top=�6/   ���	#FF323232.+�5      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 62   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension     Kind$ FadeIn=�   Duration$ 00:00:01X�5        5       62     $ FadeIn=�$ 00:00:01X�.��5      �� $��Buscar��6   
�������$��60(�6=   $
��Bold"�6K   $
��Left=�6]   $��Center=�6x   $��	30,11,0,9q�6�    �� TextAlignment$ Center=�6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      5   *   5      5      � 5   
   -   5        $ SearchContent��5      .+�5      #  MaterialDesignThemes.Wpf.Card  -   5          Name$ 
SearchCard��5   "   $��Center=�66   $	��271��6S   $��59,136,37,9.8q�6`   $	��704��6w   $��Center=�6�   ��5      �� 5       �� EndPoint$ 0.5,1&�6*   	 �� 
StartPoint$	 0.5,0&�6;   .��5      � 
 � Color$
 	#FF6F6F6F��6'    � Offset$ 0.308Q�69   � 5      $
 	#FF483E3E��6'   $ 1Q�69   � 5      $
 	#FFA5A5A5��6'   $ 0.113Q�69   � 5      $
 DarkGray��6'   $ 0.718Q�68   5      .��5!      � -   5        $ CardContent��5!       5"        5#         Color$ 	#FFF0F0F0��6+   ��5%      �� 5&      $ 0.5,1&�6.   $	 0.5,0&�6?   .��5'      � $
 	#FF4C4C4C��6+   $ 0.006Q�6=   � 5(      $
 	#FF323232��6+   $ 1Q�6=   � 5)      $
 	#FF434343��6+   $ 0.716Q�6=   5*      .+�5,      �� -   5         ��Name$ SearchTitle��5,       $��70��65   $��Stretch=�6A   $	��Top=�6_   $��45(�6w   $��DemiBold"�6�   $��	0,0,0.4,0q�6�   ��5-      �� 5.      $ 0.5,1&�62   $	 0.5,0&�6C   .��5/   "   � $
 	#FFDADC02��6/   $ 0.931Q�6A   � 50   "   $
 Black��6/   $ 1Q�6=   � 51   "   $
 	#FF252525��6/   $ 0.006Q�6A   � 52   "   $
 	#FFDFE012��6/   $
 0.02Q�6A   53      !Buscar por número de proveedor54   Q   �� 55      -   5         ��Name$ TxtSearchBox��55      $��35(�64   ���	#FFF7F7F7$
��Left=�6Y   $	��446��6t   $��12,121,0,80.4q�6�   6�   �� 56      -	   5         ��Name$ SearchButton��56      $��69��63   $	��Top=�6?   $��464,121,10.4,0q�6W   ���	#fff0de21 � ToolTip$ Buscar��6�    57        58      .��5:      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]   Kind$ Search=�62   $��50��6@   $��50��6K   
���   �6W   5;      5<      5=      5>      5?      5@      