   M S B A M L   `   `   `  ����U  Q6T24_ludo_WPFAct3BisEvant2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:_6T24_ludo_WPFAct3BisEvant2_6T24_ludo_WPFAct3BisEvant2  5   	   ,    &_6T24_ludo_WPFAct3BisEvant2.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:_6T24_ludo_WPFAct3BisEvant2     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��700��6)   .��5	      � 
���  �� � ColumnDefinitions 5
   
   �� 5      $��1* �6   �� 5      $	��500 �6    � RowDefinitions 5   
   �� 5      $	��240 �6   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   �� $��Type de logement��6   $��16(�6-   
��� ���$��20,40,20,40q�6O   .��5   
   �� .+�5      	� $��16(�6   $	��Top=�6)   $
��Left=�6A   
��� ���$��chalet��6p   6�   	� 5      $��16(�6   $	��Top=�6)   $
��Left=�6A   
��� ���$��tente��6p   6�   5      5      �� 5   
   $��15,0,0,0q�6   $��1��6%   $��reservation��62   $��16(�6H   
��� ���$��Center=�6k   6�   �� 5   
   $��	resultats��6   $��16(�6&   
��� ���$��2��6H   $��10,10,10,10q�6U   .��5      �� .+�5      �� Prix a payer :6,   �� 5      Nombre de semaines :62   5       5!      �� 5"   
   $��18(�6   $��2��6   $��2��6/   $��30��6<   $	��150��6H   $��
180,0,0,60q�6T   $
��init��6h   6y   �� 5#   
   $��18(�6   $��2��6   $��2��6/   $��30��6<   $	��150��6H   $��
180,30,0,0q�6T   $��calculer��6h   6}   �� 5$   
   $��30,20,30,10q�6   $��caracteristique du sejour��6(   $��16(�6K   
��� ���$��2��6m   .��5%      �� .+�5&      ��  �� Orientation$ 
Horizontal=�6   $��20,10q�66   .+�5'      �� $��Nombre de Personnes:��6"   
��� ���6>   �� 5(      -   5         ��Name$ 
txtChiffre��5(      $	��100��64   5)      �� 5*      $ 
Horizontal=�6   $��20,10q�66   .+�5+      �� $��Date d'arrivée :��6"   
��� ���6:   (  "System.Windows.Controls.DatePicker  5,      -   5        $��arrivee��5,   "   $	��150��61   5-      �� 5.      $ 
Horizontal=�6   $��20,10q�66   .+�5/      �� $��Date de sortie :��6!   
��� ���69     50      -   5          Name$ sortie��50   !   $	��150��61   51      �� 52      $ 
Horizontal=�6   $��20,10q�66   .+�53      �� -   5        $��duree��53      $��Durée Sortie��6*   $	��150��6A   �� 54      -   5        $��temps��54       durée en semaine6?   55      58      5:      5>      5?      