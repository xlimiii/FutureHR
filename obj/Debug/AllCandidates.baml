   M S B A M L   `   `   `  ����C  ?FutureHR, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:FutureHRFutureHR  5          FutureHR.AllCandidates   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:FutureHR     5      
�������.��5	      �   � ColumnDefinitions  5
   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��3* �6   �� 5      $
��0.5* �6   .+�5   
   �� $��4��6   $��	Kandydaci��6(    �� TextAlignment$ Center=�69   $��Center=�6P   $��70(�6k   �� 5   
   -   5        $��homeBtn��5   %   $��4��6   $��0��65   $��40��6B   $��30��6M   $��Right=�6p   $	��Top=�6�   ��6Z   Z� ��6�   Z� .��5      � -   5        $
��home��5      5      �� 5   
   $��0��6   $��1��6     J� RenderTransformOrigin$ 0.5,0.5&�6.   $��Images/human.png��6N   $	��300��6h   $��Bottom=�6u   {�.  z�5      V� 5      .~�5       ��  �� ScaleY$ 1Q�6%    �� ScaleX$ -1Q�60   �� 5!       �� AngleY$ 0Q�6$    �� AngleX$ 0Q�6/   �� 5"       �� Angle$ 0Q�6&   T� 5#      5$      5&      �� 5'   
   -   5        	 ��Name$	 
human_list��5'      $��1��6(   $��1��65   $��16(�6E   $
��auto��6S   $	��360��6`   $��Bottom=�6m   $��Lucida Console)�6�   $��Disabled=�6�   
���   �
 �� View
 5(      �� 5)      .P�5*      ��  �� Width$ 70��6%   $��Imię��60    �� DisplayMemberBinding 6>   �� *	FirstName+5,      �� 5-      $	 120��6%   $��Nazwisko��61    6C   �� *
LastName+5.      51      �� 52   
   $��1��6   $��3��6   $��Images/robot.png��6-   $��Bottom=�6G   �� 53   
   -   5        $	 
robot_list��53      $��1��6(   $��2��65   $��16(�6E   $
��auto��6S   $	��360��6`   $��Bottom=�6m   $��Lucida Console)�6�   $��Disabled=�6�   
���   �
 54      �� 55      .P�56      �� $ 80��6%   $��Model��60    6?   �� *Model+58      �� 59      $	 110��6%   $��Numer serii��61    6F   �� *SerialNumber+5:      5<      �� 5=   
   -   5        $��4��5=      $��2��6%   $��Bottom=�62   $��30��6M   $��5 0 5 20q�6Y   $	��200��6k   $��Przeprowadź rozmowę��6w   $��Lucida Console)�6�   6�   5>      5?      