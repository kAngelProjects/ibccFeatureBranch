   M S B A M L   `   `   `  ����  IBCCProject.1    IBCCProject._1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Wartime Memories��5   	   $	��700��6"   $	��800��6/    � 
ResizeMode$ NoResize=�5   	   .��5      � ��5   
   !� 5	       !� Visual 5
      r� 5       r� Source$e _C:\Users\Katkin\Desktop\ibccCode\ibccCode\0.1\IBCCProject.1\IBCCProject.1\Images\filmEffect.wmv?�6#   $	��800��6�   $	��700��6�    r� Stretch$
 Fill=�6�   5      5      .+�5   
   �� -   5        $��button1��5   ]   $��START��6   $��71��6!   $
��Left=�6-   $��127,578,0,0q�6H   $	��Top=�6l   $	��532��6�   6�   �� 5   
   -   5        $��image1��5   L   $	��181��6   $
��Left=�6   $��
238,12,0,0q�68   $
��Fill=�6Z   $	��Top=�6i   $	��308��6�   $:��4/IBCCProject.1;component/Images/IBCCTransparent2.png��6�    K� ZIndex$ 10��6�   �� 5   
   -   5         ��Name$ border1��5      ���	#FF9A9A9A$��5q�6:    �� CornerRadius$ 50��6N   $��63,202,519,316q�6`   ���	#A09A9A9A._�5      �� -   5         ��Name$ canvas1��5      $	��150��6&   $	��100��62   .+�5      r� -   5        	 r�Name$	 channel1��5      $d ^C:\Users\Katkin\Desktop\ibccCode\ibccCode\0.1\IBCCProject.1\IBCCProject.1\Images\airForce1.mp4?�61   $��60,120,200,30q�6�   
 �� Left$	
 -60��6�   
 �� Top$
 -120��6�   $
 Fill=�6�   $	��100��6�   $	��150��6�   $ 10��6�    r� Volume$ 0Q�6  6  5      5      �� 5   
   -   5        $ border2��5      ���	#FF9A9A9A$��5q�6:   $ 50��6N   $��508,202,74,316q�6`   ���	#A09A9A9A._�5      �� -   5        $ canvas2��5      $	��150��6&   $	��100��62   .+�5      r� -   5        $	 secondChannel��5      $d ^C:\Users\Katkin\Desktop\ibccCode\ibccCode\0.1\IBCCProject.1\IBCCProject.1\Images\airForce2.mp4?�66   $��60,120,200,30q�6�   $	
 -60��6�   $
 -120��6�   $
 Fill=�6�   $	��100��6�   $	��150��6�   $ 10��6  $ 0Q�6  6   5      5      �� 5!   
   -	   5        $ border3��5!      ���	#FF9A9A9A$��5q�6:   $ 50��6N   $��288,246,294,272q�6`   ���	#A09A9A9A._�5"      �� -
   5        $ canvas3��5"      $	��150��6&   $	��100��62   .+�5#      r� -   5        $	 thirdChannel��5#      $d ^C:\Users\Katkin\Desktop\ibccCode\ibccCode\0.1\IBCCProject.1\IBCCProject.1\Images\airForce3.mp4?�65   $��60,120,200,30q�6�   $	
 -60��6�   $
 -120��6�   $
 Fill=�6�   $	��100��6�   $	��150��6�   $ 10��6   $ 0Q�6  6  5$      5%      �� 5&   
   -   5        $��title��5'   C   $��WARTIME MEMORIES��5&      $��84��6+   $��48(�67   $��Century)�6E   $��Center=�5'      $��117,395,97,0q�6-   $	��Top=�6P   $	��564��6h   �� 5)   
   -   5        $��AnimatedText��5)      $��64,457,74,104q�6(   $	��640��6?   $	��100��6K   $��32(�6X   $
��Bold"�6f   
���   � �� TextAlignment$ Center=�6�   $��Century)�5*      $
��Wrap=�6)   75Read memories in the words of the veterans themselves � Triggers 5-      :� 5.       :� RoutedEvent$ TextBlock.Loaded��6   .[�5/      �� .��50      �� .��51      W�  �� 
TargetName$ AnimatedText��52       �� TargetProperty$ (TextBlock.Opacity)�53       W� From$	 1.0X�54      	 W� To$	 0.0X�6$    g� Duration$ 0:0:5D�6-    g� AutoReverse .  g� RepeatBehavior$ Forever��55   ,   56      58      59      5;      5?      5@      