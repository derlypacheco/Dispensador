   M S B A M L   `   `   `  ����G  CKMXDispenser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:KMXDispenser.ViewsKMXDispenser.Views  5      !    KMXDispenser.Views.EditUser   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
   ,local clr-namespace:KMXDispenser.Views  5      -   5          � Title$  EditUser��5	      
������  � AllowsTransparency .  � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�6   $	��695��62   $	��435��6>   $��Center=�5   	   $��Center=�6&    � WindowStartupLocation$ CenterScreen=�6A   .��5      �� ���	#FF3D3D3D
���   �$��1,1,1,1q�68    �� CornerRadius$ 30,30,30,30��6R    J� Effect 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5      ._�5   
   � -   5         �Name$ MainEditUser��5      
������ .+�5      � -   5        $ GridEditUserTitle��5      $��50��6.   $	��Top=�6:   
������ $��10,0,0,0q�6k   .+�5      �� -   5         ��Name$ EditUserTitle��5      $��Editar usuario��63   
�������$��30(�6\   $��	10,8,0,-8q�6j   $
��Left=�6}   $
��Bold"�6�   5      � 5      -   5        $ GridEditUser��5      $��0,55,0,-0.4q�6)   .+�5      �� -   5        	 ��Name$	 label��5      $��24(�6'   ���	#DDFFFFFF$��Nombre de usuario��6L   $
��Left=�6h   $��20,45.076,0,0q�6�   $	��Top=�6�   �� 5      -   5        $	 
label_Copy��5      $��24(�6,   ���	#DDFFFFFF$��Nivel de acceso��6Q   $
��Left=�6k   $��45,121.5,0,0q�6�   $	��Top=�6�   �� 5      -   5        $	 label_Copy1��5      $��24(�6-   ���	#DDFFFFFF$��Clave de acceso��6R   $
��Left=�6l   $��
47,194,0,0q�6�   $	��Top=�6�   �� 5      -	   5        
 ��Name$
 txtName��5      $
��Left=�6+   $��50��6F   $��18(�6R   $��
240,39,0,0q�6`    �� TextWrapping$
 Wrap=�6t   $�� ��6�   $	��Top=�6�   $	��421��6�   
�������6�   G� 5      -
   5         G�Name$ txtPass��5      $
��Left=�6/   $��50��6K   $��18(�6W   $��240,194,0,0q�6e   $	��Top=�6{   $	��421��6�   
�������6�   �� 5      -   5        $
 comboAccess��5      $��18(�6/   $
��Left=�6=   $��50��6X   $��240,113,0,0q�6d   $	��Top=�6y   $	��421��6�   
�������6�   �� 5      -   5         ��Name$ btnSalveUser��5      $
��Left=�6/   $��491,268,0,0q�6J   $	��Top=�6_   $	��170��6w   $��80��6�   ���	#FF404040���	#FFF0DE21.��5       '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]   Kind$ ContentSave=�6.   $��0,0,0,0q�6A   $��Stretch=�6S   $��Stretch=�6o   $��70��6�   $��70��6�   5!      �� 5"      -   5        $ btnCloseForm��5"      $
��Left=�6/   $��289,268,0,0q�6J   $	��Top=�6_   $	��170��6w   $��80��6�   ���	#FF404040���	#FFF0DE21.��5#        $ CloseCircleOutline=�6.   $��0,0,0,0q�6H   $��Stretch=�6Z   $��Stretch=�6v   $��70��6�   $��70��6�   5$      5%      5'      5(      5)      