   M S B A M L   `   `   `  ����G  CKMXDispenser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:KMXDispenser.ViewsKMXDispenser.Views  5      %    KMXDispenser.Views.UpdateCavity   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      ,local clr-namespace:KMXDispenser.Views  5      -   5          � Title$  UpdateCavity��5	      $��633.626��6   $��756.838��6-    � AllowsTransparency .  � WindowStyle$
 None=�5
   !   
������  � WindowStartupLocation$ CenterScreen=�6M   .��5      �� ���	#FF3D3D3D
���   �$��3,3,3,3q�68    �� CornerRadius$ 30,30,30,30��6R   ._�5   
   � -   5         �Name$ GridMainUser��5      .+�5      �� ���	#FF3D3D3D
���   �$��1,1,1,1q�6@   $ 30,30,30,30��6Z   ._�5      � -   5        $ UserTitleBar��5      $��50��6-   $	��Top=�69   
������ .+�5      �� -   5         ��Name$ TxtCavDetTitle��5       $%��Actualizar Cavidad o Detección��68   $��30(�6^   
������� �� Padding$ 10,0,0,0q�6�   $��10,6,-12.2,-6q�6�   $
��Bold"�6�   5      5      � 5      -   5        $ NewUserContent��5      $��0,55,0,0q�6+   .+�5      �� -   5         ��Name$ 	LblNumero��5      $��28(�6+   
�������$��Número��6L   $
��Left=�6]   $��	71,36,0,0q�6x   $	��Top=�6�   �� 5      -   5        $ 	LblCavity��5      $��28(�6+   
�������$��Cavidad��6L   $
��Left=�6^   $��
74,116,0,0q�6y   $	��Top=�6�   �� 5      -   5        	 ��Name$	 TxtNum��5      $��Center=�6*   $
��Left=�6L   $��4q�6g   $��24(�6{   
�������$��70��6�   $��
194,36,0,0q�6�   $	��Top=�6�   $	��325��6�   $��5q�6�   �� 5      -	   5        $ LblIDCartucho��5      $��28(�6/   
�������$��Ubicación ID��6P   $
��Left=�6g   $��
67,212,0,0q�6�   $	��Top=�6�   �� 5      -
   5        $ 
LblCandado��5      $��28(�6,   
�������$��Candado��6M   $
��Left=�6_   $��
75,299,0,0q�6z   $	��Top=�6�   �� 5      -   5        $	 
TxtCandado��5      $
��Left=�6.   $��Center=�6I   
 �� TextAlignment$
 Center=�6k   $��24(�6�   
�������$��63��6�   $��195,289,0,0q�6�   $	��Top=�6�   $	��115��6�   �� 5      -   5         ��Name$ ComboIDCartucho��5      $��5q�64   $��Center=�6@   
�������$��59��6u   $
��Left=�6�   $��233,201,0,0q�6�   $	��Top=�6�   $	��286��6�   $��24(�6�   5      �� 5      -   5         ��Name$ BtnUpdateCavDet��5       � ToolTip$ Guardar��62   $
��Left=�6D   $��524,481,0,0q�6_   $	��Top=�6t   $	��170��6�   $��80��6�   ���	#FF404040���	#FFF0DE21.��5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]   Kind$ ContentSave=�6.   $��0,0,0,0q�6A   $��Stretch=�6S   $��Stretch=�6o   $��80��6�   $��80��6�   5       �� 5!      -   5        $ btnCloseForm��5!      $
��Left=�6/   $ Cancelar��6J   $��333,481,0,0q�6]   $	��Top=�6r   $	��170��6�   $��80��6�   ���	#FF404040���	#FFF0DE21.��5"        $ CloseCircleOutline=�6.   $��0,0,0,0q�6H   $��Stretch=�6Z   $��Stretch=�6v   $��80��6�   $��80��6�   5#      �� 5$      -   5        $ BtnShowImage��5$      $
��Left=�6/   $ Cancelar��6J   $��
71,481,0,0q�6]   $	��Top=�6q   $	��170��6�   $��80��6�   ���	#FF404040���	#FFF0DE21.��5%        $ Image=�6.   $��0,0,0,0q�6;   $��Stretch=�6M   $��Stretch=�6i   $��80��6�   $��80��6�   5&      �� 5'      -   5        $	 	TxtCavity��5'      $��5q�6-   $��Center=�69   $
��Left=�6[   $��24(�6v   
�������$��70��6�   $��194,116,0,0q�6�   $	��Top=�6�   $	��325��6�   �� 5(      -   5        $ LblContador��5(      $��28(�6-   
�������$��Contador��6N   $
��Left=�6a   $��394,299,0,0q�6|   $	��Top=�6�   �� 5)      -   5        $	 TxtContador��5)      $��Center=�6/   $
 Center=�6Q   $
��Left=�6h   $��24(�6�   
�������$��63��6�   $��524,289,0,0q�6�   $	��Top=�6�   $	��138��6�   �� 5*      -   5        $ LblStockMin��5*      $��28(�6-   
�������$��Stock mínimo��6N   $
��Left=�6e   $��
11,390,0,0q�6�   $	��Top=�6�   $��41��6�   �� 5+      -   5        $	 TxtStockMin��5+      $��Center=�6/   $
 Center=�6Q   $
��Left=�6h   $��24(�6�   
�������$��63��6�   $��194,380,0,0q�6�   $	��Top=�6�   $	��116��6�   �� 5,      -   5        $ LblStockMax��5,      $��28(�6-   
�������$��Stock Máximo��6N   $
��Left=�6e   $��368,390,0,0q�6�   $	��Top=�6�   �� 5-      -   5        $	 TxtStockMax��5-      $��Center=�6/   $
 Center=�6Q   $
��Left=�6h   $��24(�6�   
�������$��63��6�   $��552,380,0,0q�6�   $	��Top=�6�   $	��110��6�   �� 5.      -   5        $ BtnSearchNum��5.      $
��Left=�6/   $ Cancelar��6J   $��
552,35,0,0q�6]   $	��Top=�6q   $	��142��6�   $��71��6�   ���	#FF404040���	#FFF0DE21.��5/        $ 	SearchWeb=�6.   $��0,0,0,0q�6?   $��Stretch=�6Q   $��Stretch=�6m   $��70��6�   $��80��6�   50      52      53      54      55      