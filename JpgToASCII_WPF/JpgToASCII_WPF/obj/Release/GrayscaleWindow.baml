   M S B A M L   `   `   `  ���� I  EJpgToASCII_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:JpgToASCII_WPFJpgToASCII_WPF  $    JpgToASCII_WPF.GrayscaleWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:JpgToASCII_WPF     -     �Name$  grayScaleWindow�� � Title$! Image Converter - Grayscale��$	��768��$
��1024��$	��800��$	��600������  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ 	#FF1D0303�� � Offset$ 0Q�� $ White��$ 1Q�.���  � ColumnDefinitions �� $
��auto ��� $��* ��� $��15 � � RowDefinitions �� $
��auto ��� $��* ��� $
��auto ��� $
��auto ��� $��15 �.+�]� $��0��$��0��$
��Left=�.+�o� 
���   �$��2q�$��2��$��0,0,5,10q�.@�m� $��_Control��$��28(�$
��Bold"�$��Times New Roman)� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect  	   ShadowDepth$	 4Q�
   Opacity$	
 0.5Q�.@�m� -   $��_Exit��$��20(�$��SemiBold"�o� 
���   �$��2q�$��2��$��0,0,5,10q�.@�m� $��_File��$��28(�$
��Bold"�$��Times New Roman)�   $	 4Q�$	
 0.5Q�.@�m� -   $��_Save ASCII��$��20(�$��SemiBold"��� m� -   $��_Save Grayscale��$��20(�$��SemiBold"��� -   $��grayscaleImage��$��1��$��0��$��2��$��2��$��Center=�$��Center=�$
��20,0q��� -   $��ConvertButton��$��35,20q�$��3��$��0��$
��Bold"�$��24(�
�������$��50��$��20��$��Bottom=�$
��Left=�
���   �.���� $)��#Convert and save image to grayscale���� -   $��ConvertASCIIButton��$��35,20q�$��3��$��1��$
��Bold"�$��24(�
�������$��50��$��20��$��Bottom=�$��Right=�
���   �.���� $%��Convert and save image to ASCII��