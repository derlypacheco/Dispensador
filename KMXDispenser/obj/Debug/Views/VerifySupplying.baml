   M S B A M L   `   `   `  ����G  CKMXDispenser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:KMXDispenser.ViewsKMXDispenser.Views  5   	   (    "KMXDispenser.Views.VerifySupplying   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   ,local clr-namespace:KMXDispenser.Views  5   	     � Title$  VerifySupplying��5	   	   $	��450��6!   $	��800��6.    � WindowStyle$
 None=�6:   ���	#FF453F3F � WindowState$ 	Maximized=�6d   .��5
      � .+�5   
   �� $��	Surtiendo��6   $��50(�6%   
�������$��Center=�6F   $��203,50,203.6,135.2q�6c   �� 5   
   $��30(�6   
�������$��Center=�65   $��203,120,203.6,135.2q�6R    �� TextAlignment$ Center=�6o   No cierre la ventana�� 6�   Cantidad a surtir6�   �� 5   
   $��11��6   $	��150��6   $	��150��6*   $	��100(�67   $ Center=�6F   
�������$��0,0,0,0q�6p   � 5   
    %  !MaterialDesignCircularProgressBar#��[  6    � Value$ 0Q�6Q   $	��300��6[   $	��300��6g    � IsIndeterminate . 
��� ���$��3q�6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      5      �� 5   
   -   5         ��Name$ CancelButton��5      $	��120��6'   $��Bottom=�64   $��Center=�6O   
������ $��0q�6�   $��328,0,333.6,10.2q�6�   .��5      � $��98��6   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]   Kind$ CloseCircleOutline=�6*   $	��100��6D   $	��140��6P   
�������$	��Top=�6p   $��Center=�6�   $��0,-37,0,-21.4q�6�   �� 5      $��Cancelar��6   $��Bottom=�6,   $ Center=�6G   $��
0,0,0,-5.4q�6^   $��24(�6r   5      5      5      5      