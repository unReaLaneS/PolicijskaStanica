   M S B A M L   `   `   `  ����  PolicijskaStanica!    PolicijskaStanica.LoginPage   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          �Name$  	loginPage��5   	    � Title$ 	LoginPage��5   	    � 
ResizeMode$ NoResize=�5   	   $	��900��6   $	��600��6+    � WindowStartupLocation$ CenterScreen=�68   .��5      � -   5         �Name$ 
login_page��5       J� RenderTransformOrigin$ 0.5,0.5&�6   $��0,0,0,0q�6?   $	��600��6P    � ColumnDefinitions 5   
   �� 5      z�5
   
   V� 5      .~�5      �� �� 5      �� 5       �� Angle$ 0Q�6"   T� 5      5      ��5   
   �� 5       �� ImageSource$ Slike/pozadina.jpg��6   .+�5   
   �� -   5        	 ��Name$	 dugme_prijava��5      $��Prijava��6(   $
��Left=�6:   $��396,458,0,0q�6U   $	��Top=�6j   $	��137��6�   $��47��6�   $��14(�6�   ��5      �� 5      
 �� EndPoint$	
 0,1&�6&    �� 
StartPoint$	 0,0&�65   .��5      �  � Color$ 	#FF1977A2��6#   � 5      $ 	#FFEBEBEB��6#    � Offset$ 0.711Q�65   � 5      $ 	#FFDDDDDD��6#   $ 0.758Q�65   � 5      $ 	#FFD6D6D6��6#   $ 1Q�65   � 5      $ 	#FF40534F��6#   $ 0.102Q�65   5      5      �� 5    
   -   5         ��Name$ labela_username��5       $��korisničko ime:��6)   $
��Left=�6C   $��269,375,0,0q�6^   $	��Top=�6s   $	��111��6�   $��14(�6�   $
��Bold"�6�   $��29��6�   �� 5!   
   -   5        $ labela_password��5!      $��lozinka:��6)   $
��Left=�6<   $��319,418,0,0q�6W   $	��Top=�6l   $��28��6�   $��62��6�   $��14(�6�   $
��Bold"�6�   $ 0.5,0.5&�6�   �� 5"   
   -   5         ��Name$ textbox_username��5"      $
��Left=�6,   $��27��6G   $��396,377,0,0q�6S    �� TextWrapping$
 Wrap=�6h   $	��Top=�6|   $	��137��6�   G� 5#   
   -   5         G�Name$ password_box��5#      $
��Left=�6,   $��27��6G   $��396,420,0,0q�6S   $	��Top=�6h   $	��137��6�   �� 5$   
   $
��Left=�6   $	��270��6+   $��
297,93,0,0q�68   $	��Top=�6L   $	��325��6d   $��Slike/logo3,1.jpg��6p   $ 0.5,0.5&�6�   z�5%      �� 5&      -   5        TransScale1��5&   "    � Triggers 5(      :� 5)       :� RoutedEvent$ Image.Loaded��6   .[�5*      �� .��5+      �� .��5,      W�  �� TargetProperty$ ScaleX�5-       �� 
TargetName$ TransScale1��5.      	 W� To$ -1X�5/       g� Duration$ 0:0:3D�50       g� AutoReverse .  g� RepeatBehavior$ Forever��52       W� EasingFunction 53   "   -  'System.Windows.Media.Animation.SineEase  54   &   7  1System.Windows.Media.Animation.EasingFunctionBase   
EasingMode$ 	EaseInOut=�6/   56      57      58      59      5;      5<      5=      