   M S B A M L   `   `   `  ����E  ATranslator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Translator
Translator  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	       Translator.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Translator     5   	   9System&clr-namespace:System;assembly=mscorlib     5   	     � Title$  
Translator��5	   	   $	��300��6   $	��650��6)    � 	Resources 5
         textBlockStyle �� 
TargetType �� Property �� Value  comboBoxStyle��%�  &	        &	 E    �� 5   
   " ��6'   .�5      ��  � ��$ 30(�6)   �� 5       � ��$ SemiBold"�6+   �� 5       � ��
 �����6+   �� 5       � ��
 ���� 6+   �� 5       � ��$ 10q�6'   �� 5       �@��TextWrapping$
 Wrap=�6-   �� 5       �@��AcceptsReturn . 6.   5      �� 5   
   " ��6&   .�5      ��  � ��$ Center=�64   �� 5       � ��$ Center=�62   �� 5       � ��$	 100��6&   �� 5       � ��
 ���� 6+   �� 5       � ��
 ���� 6,   �� 5       �@��
IsReadOnly . 6+   �� 5       �@�OverridesDefaultStyle .  66   5      5      .��5      � $��10q�6    � RowDefinitions 5   
   �� 5       $��* �6   �� 5!      $��3* �6    � ColumnDefinitions 5#   
   �� 5$      $��2* �6   �� 5%      $��* �6   �� 5&      $��* �6   �� 5'      $��2* �6   .+�5)   
   �� 
������� �� CornerRadius$ 10��6)   $��1q�6;   $��4��6O   $��2��6c   �� 5*   
   
�������$��0,0,0,1q�6)   $��4��6C   �� 5+   
   $��1��6   $��2��6   $��0,0,1,0q�62   
�������6L   �� 5,   
   -   5        $��languageFrom��5,   :   #��[ 6    �� SelectedIndex$ 0��6N   5/      �� 50   
   -   5        $��
languageTo��50   :   #��[ 6   $��3��6L   $ 0��6\   52        Translator.Switcher  53   
      Translator.Switcher	   Click$	 Switcher_Click��6�   
������ 
������ $��1��6L   $��2��6\   $��Center=�6p   $��Center=�6�   $��30��6�   6�   �� 54   
   -   5        
 ��Name$

 text��54   ,   
������ $��1��6:   $��2��6G   #��[  6[    �� SelectionBrush
 ���� 6�   �� 56   
   -   5        $
 translation��56   ,   
������ $��2��6A   $��1��6Q   $��2��6^   #��[  6r    �� AutoWordSelection .  �� 
IsReadOnly . 
 �����$��1q�6  58      59      