   M S B A M L   `   `   `  ����G  CKMXDispenser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:KMXDispenser.ViewsKMXDispenser.Views  5           KMXDispenser.Views.NewUser   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:KMXDispenser.Views     5      V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        � WindowStyle$
  None=�5	       � AllowsTransparency .  � Title$ NewUser��5      $	��410��6   $��783.2��6$    � 
ResizeMode$ NoResize=�62    � WindowStartupLocation$ CenterScreen=�6H   ��5      �� 5   
    �� Opacity$ 0Q�6    �� Color$ White��6&   .��5      �� ���	#FF3D3D3D
���   �$��3,3,3,3q�68    �� CornerRadius$ 30,30,30,30��6R   ._�5   
   � -   5         �Name$ GridMainUser��5      .+�5      �� ���	#FF3D3D3D
���   �$��1,1,1,1q�6@   $ 30,30,30,30��6Z   ._�5      � -   5        $ UserTitleBar��5      $��50��6-   $	��Top=�69   
������ .+�5      �� -   5        	 ��Name$	 TxtNewUserTitle��5       $��Nuevo Usuario��69   $��30(�6N   
�������
 �� Padding$
 10,0,0,0q�6p   $��10,6,-12.2,-6q�6�   $
��Bold"�6�   5      5      � 5      -   5        $ NewUserContent��5      $��0,55,0,0q�6+   .+�5      �� -   5         ��Name$ label��5      $��24(�6'   
�������$��Nombre de usuario��6H   $
��Left=�6d   $��	35,35,0,0q�6   $	��Top=�6�   �� 5      -   5        $ 
label_Copy��5      $��24(�6,   
�������$��Permiso de usuario��6M   $
��Left=�6j   $��
40,163,0,0q�6�   $	��Top=�6�   �� 5      -   5        $ label_Copy1��5      $��24(�6-   
�������$��Clave de usuario��6N   $
��Left=�6i   $��	60,99,0,0q�6�   $	��Top=�6�   �� 5      -   5         ��Name$ 	txtNombre��5      $
��Left=�6-   $��24(�6H   
�������$��40��6i   $��
256,37,0,0q�6u    �� TextWrapping$
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��325��6�    �� TextAlignment$
 Left=�6�   G� 5      -	   5         G�Name$ txtPass��5      $
��Left=�6/   $��24(�6J   
�������$��41��6k   $��256,100,0,0q�6w   $	��Top=�6�   $	��325��6�   �� 5      -
   5         ��Name$ comboPermiso��5      
�������$��40��6D   $
��Left=�6P   $��256,166,0,0q�6k   $	��Top=�6�   $	��325��6�   $��24(�6�   .@�5      �� $��Administrador��6"   �� 5      $��Tecnico��6"   �� 5       $��Calidad��6"   5!      �� 5"      -   5         ��Name$ 	btnHuella��5"       � ToolTip$ Registrar Huella��6,   $
��Left=�6G   $��613.08,46,0,0q�6b   
������ $	��Top=�6�   $��130.92��6�   $	��118��6�   ���	#FF404040$��0q�6�   .��5#      '  !MaterialDesignThemes.Wpf.PackIcon  -   5          Name$ FingerprintIcon��5#   .   �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]   Kind$ Fingerprint=�6G   $��0,0,0,0q�6Z   $��Stretch=�6l   $��Stretch=�6�   $	��100��6�   $	��100��6�   
�������6�   5$      �� 5%      -   5        $ label_Copy2��5%      $��24(�6-   
�������$��Capturar huella��6N   $
��Left=�6h   $��594,160.099,0,0q�6�   $	��Top=�6�   �� 5&      -   5        $ 	btnSaUser��5&      $ Guardar��6,   $
��Left=�6>   $��432,240,0,0q�6Y   $	��Top=�6n   $	��170��6�   $��80��6�   ���	#FF404040���	#FFF0DE21.��5'        $ ContentSave=�6.   $��0,0,0,0q�6A   $��Stretch=�6S   $��Stretch=�6o   $��80��6�   $��80��6�   5(      �� 5)      -   5        $ btnCloseForm��5)      $
��Left=�6/   $ Cancelar��6J   $��212,240,0,0q�6]   $	��Top=�6r   $	��170��6�   $��80��6�   ���	#FF404040���	#FFF0DE21.��5*        $ CloseCircleOutline=�6.   $��0,0,0,0q�6H   $��Stretch=�6Z   $��Stretch=�6v   $��80��6�   $��80��6�   5+      5,      5-      5.      5/      