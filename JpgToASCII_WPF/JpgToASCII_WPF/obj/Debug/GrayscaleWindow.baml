   M S B A M L   `   `   `  ����I  EJpgToASCII_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:JpgToASCII_WPFJpgToASCII_WPF  5   	   $    JpgToASCII_WPF.GrayscaleWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:JpgToASCII_WPF     5   	   -   5          �Name$  grayScaleWindow��5   	    � Title$! Image Converter - Grayscale��5	   	   $	��768��5
   	   $
��1024��6   $	��800��5   	   $	��600��6   ��5      �� 5   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5      �  � Color$ 	#FF1D0303��6    � Offset$ 0Q�6-   � 5      $ White��6   $ 1Q�6)   5      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��15 �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��15 �6   .+�5    
   ]� $��0��6   $��0��6$   $
��Left=�61   .+�5!      o� 
���   �$��2q�6'   $��2��6;   $��0,0,5,10q�6O   .@�5"      m� $��_Control��6   $��28(�6-   $
��Bold"�6;   $��Times New Roman)�6M    J� Effect 5#      3  -System.Windows.Media.Effects.DropShadowEffect  5$      	   ShadowDepth$	 4Q�6+   
   Opacity$	
 0.5Q�6;   .@�5&      m� -   5        $��_Exit��5&      $��20(�6.   $��SemiBold"�6<   6R   5'      5(      o� 5)      
���   �$��2q�6'   $��2��6;   $��0,0,5,10q�6O   .@�5*      m� $��_File��6   $��28(�6*   $
��Bold"�68   $��Times New Roman)�6J    5+        5,      $	 4Q�6+   $	
 0.5Q�6;   .@�5.      m� -   5        $��_Save ASCII��5.      $��20(�64   $��SemiBold"�6B   6X   �� 5/      m� 50      -   5        $��_Save Grayscale��50      $��20(�68   $��SemiBold"�6F   6\   51      52      53      �� 54   
   -   5        $��grayscaleImage��57      $��1��54      $��0��6   $��2��6-   $��2��6A   $��Center=�55      $��Center=�6+   $
��20,0q�56      57   %   �� 58   
   -   5        $��ConvertButton��5:   *   $��35,20q�59      $��3��5:      $��0��6   $
��Bold"�5;      $��24(�6   
�������$��50��5<      $��20��6   $��Bottom=�5=      $
��Left=�6(   
���   �.��5?      �� $)��#Convert and save image to grayscale��6   5@      �� 5A   
   -   5        $��ConvertASCIIButton��5C   *   $��35,20q�5B      $��3��5C      $��1��6   $
��Bold"�5D      $��24(�6   
�������$��50��5E      $��20��6   $��Bottom=�5F      $��Right=�6(   
���   �.��5H      �� $%��Convert and save image to ASCII��6   5I      5J      5K      