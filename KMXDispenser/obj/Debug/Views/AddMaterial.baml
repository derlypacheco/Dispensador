   M S B A M L   `   `   `  ����G  CKMXDispenser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:KMXDispenser.ViewsKMXDispenser.Views  5   	   $    KMXDispenser.Views.AddMaterial   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5   	   ,local clr-namespace:KMXDispenser.Views  5   	     N� Title$  AddMaterial��5
   	    N� 
Background �	#FF3F3E3E.��5      � .+�5   
   � -   5         �Name$ 	SurtirBar��5      $	��100��6"   $	��Top=�6/   ���	#FF323232.+�5      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 62   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension     Kind$ FadeIn=�   Duration$ 00:00:01X�.��5      �� $��Surtir��6   
�������$��60(�6=   $
��Bold"�6K   $
��Left=�6]   $��Center=�6x   $��	30,11,0,9q�6�    �� TextAlignment$ Center=�6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      5   *   5      5      � 5   
   -   5        $ MainContent��5      .+�5      "  FontAwesome.WPF.ImageAwesome     Icon$ Qrcode=�6   	   
Foreground
	 �����$��95��6?   $��177,149,553.6,548.8q�6K   $��Center=�6h   �� 5      -   5        
 ��Name$
 TxtQR��5      $��50��6%   $	��400��61   $��331,244,94.6,498.8q�6=   
�������$��30(�6l   $��Center=�6z   �� 5      -   5         ��Name$ 	lblScanQR��5      $��Escaneé QR��6'   $��36(�6<   
�������$��50��6]   $��120,244,510,498.8q�6i   $��Center=�6�   � 5      -   5        $ ScannedContent��5      .+�5      #  MaterialDesignThemes.Wpf.Card  -   5          Name$ CardInfo��5   &   $	��268��68   $��103,337,92.6,0q�6E   ��5      �� 5       �� EndPoint$ 0.5,1&�6.    �� 
StartPoint$ 0.5,0&�6?   .��5      �  � Color$ 	#FFE8E8E8��6+    � Offset$ 0.954Q�6=   � 5      $ White��6+   $ 0.112Q�69   � 5       $ 	#FFFEFF10��6+   $ 0.005Q�6=   � 5!      $ White��6+   $ 0.032Q�69   � 5"      $ 	#FFEFF031��6+   $ 0.993Q�6=   5#       5%        5&      .��5(      � .+�5)      �� -   5        $ lblFm��5)       
���   �$��36(�6B   $��FeinMetall ��6P   $
��Left=�6f   $	��Top=�6�   $��51��6�   $	��188��6�   �� 5*      -   5        $ lblLA��5*       
���   �$��36(�6B   $��
Número LA��6P   $
��Left=�6d   $	��Top=�6�   $��52��6�   $	��226��6�   $��0,81,0,0q�6�   �� 5+      -	   5        $ lblTipo��5+       
���   �$��36(�6D   $
��Tipo��6R   $
��Left=�6a   $	��Top=�6|   $��62��6�   $	��180��6�   $��	2,167,0,0q�6�   �� 5,      -
   5        $ lblStock��5,       
���   �$��36(�6E   $��Stock��6S   $��Right=�6c   $	��Top=�6�   $��51��6�   $	��204��6�   $��
0,0,62.4,0q�6�   �� 5-      -   5        $ lblFaltantes��5-       
���   �$��36(�6I   $��	Faltantes��6W   $��Right=�6k   $	��Top=�6�   $��51��6�   $	��256��6�   $��0,167,10.4,0q�6�   5.      5/      �� 50      -   5         ��Name$ 	btnImagen��50      
������ ���	#FF2F2F2F$
��Left=�6\   $��
66,663,0,0q�6w   $	��Top=�6�   $	��329��6�   $	��120��6�   $��36(�6�   $��0q�6�   .��51      � -   5        $ 	BtnImagen��51      .+�52        $ Image=�6*   
	 �����$��60��6J   $��60��6V   $
��Left=�6a   $��-32,26,0,26q�6|   6�   �� 53      -   5         ��Name$ 
TxtBlImage��53   $   $��40(�68   $��
44,0,0.2,0q�6F   
�������	Mostrar�� 6u   Imagen6�   54      55      �� 56      -   5        $ 	BtnSurtir��56      $��36(�6-   
������ 
�������$��Right=�6g   $��0,663,77.6,0q�6�   $	��Top=�6�   $	��310��6�   $	��120��6�   $��0q�6�   .��57      � -   5        $ BtnSurtirContent��57      .+�58      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]   Kind$ AddShoppingCart=�62   $	��100��6I   $	��100��6U   $��
-114,0,0,0q�6c   �� 59      $��Surtir��6$   $��Right=�62   $��Bottom=�6N   $��90��6i   $��
0,0,-115,0q�6u   $	��127��6�   $��48(�6�   5:      5;      �� 5<      -   5        $ BtnScan��5<      $��36(�6+   
������ 
�������$��Center=�6e   $��207,663,230.6,0q�6�   $	��Top=�6�   $	��388��6�   $	��120��6�   $��0q�6�   .��5=      � -   5        $ BtnScanContent��5=      .+�5>        $ Qrcode=�62   $	��100��6@   $	��100��6L   $��
-114,0,0,0q�6Z   �� 5?      $��Escanear��6$   $��Right=�64   $��Bottom=�6P   $��90��6k   $��
0,0,-181,0q�6w   $	��193��6�   $��48(�6�   5@      5A      5B      5D      5F      5G      