   M S B A M L   `   `   `  ����c  _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity  5      G CSafinExamWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:SafinExamWPFSafinExamWPF 5      !   SafinExamWPF.Views.MainView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      XiPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity  5      +
viewmodelsclr-namespace:SafinExamWPF  5        � Title$  MainView��5      $	��600��5      $
��1080��6   
������� � WindowStartupLocation$ CenterScreen=�64    � WindowStyle$
 None=�6Y    � 
ResizeMode$ NoResize=�5      ���#FFFFFF � DataContext 5         SafinExamWPF.MainViewModel  5   
    � 	Resources 5         OpenMenu �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime	 O� Value  	CloseMenu��%�  &	        &	 �     �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $	 70Q�63     5      $ 0:0:0.2��6'   $		 200Q�69   5      5      �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $		 200Q�63     5      $ 0:0:0.2��6'   $	 70Q�69   5      5       5!      
 � Triggers
 5"      :� 5#   
    :� RoutedEvent$ ButtonBase.Click��6    :� 
SourceName$ ButtonOpenMenu��66   .[�5$      �� #��[  6   5%      :� 5&   
   $ ButtonBase.Click��6   $ ButtonCloseMenu��66   .[�5'      �� #��[ 6   5(      .��5*      � ���	#FFDEDEDE.+�5+   
    � -   5          �Name$ 	FrameMain��5+      $��Right=�6#   $��Bottom=�6?   $	��540��6Z   $
��1010��6g     � NavigationUIVisibility$ Hidden=�5,      ���#FFFFFF��60   �� *CurrentPage+ J� Opacity 6P   �� *FrameOpacity+6q   � 5-   
   -   5         �Name$ 
HeadWindow��5-      $��60��6#   $	��Top=�6/   ���	#FF5C99D6 J� Effect 5.      3  -System.Windows.Media.Effects.DropShadowEffect  5/         
BlurRadius$ 1Q�6#      ShadowDepth$ 1Q�62      Color$ 	#FFACACAC��6B   .+�51      ��  �� Orientation$ 
Horizontal=�6   $��Right=�62   $��5q�6N   .+�52      �� -   5         ��Name$ closeWindow��52      
���  ��.��53      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�6.   54      55      �� 56      $��Center=�6   $��Center=�65   $��22(�6P   Коробки6g   57      � 58   
   -   5        $ GridMenu��58      $��70��6!   $
��Left=�6,   ���	#FF31577E 59        5:      $ 2Q�6#   $ 1Q�62   $ 	#FFAEAEAE��6B   .+�5<      �� .+�5=      � $��60��6   
������� J� RenderTransformOrigin$ 0.5,0.5&�66   z�5>      V� 5?      .~�5@      �� �� 5A      �� 5B      T� 5C      5D      .+�5F      �� -   5        $ ButtonOpenMenu��5F      $��60��65   $��60��6A   $��5q�6L   $
��Left=�6W   $	��Top=�6r    0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 6�   ���	#FF31577E��6�   Z� ��6�   Z� .��5G        $
 Menu=�62   $��25��6>   $��25��6I   5H      �� 5I      -   5        $ ButtonCloseMenu��5I      $y�	Collapsed=�66   $��60��6M   $��60��6Y   $��5q�6d   $
��Left=�6o   $	��Top=�6�   #��[ 6�   ���	#FF31577E��6�   Z� ��6�   Z� .��5J        $ 	ArrowLeft=�62   $��25��6C   $��25��6N   5K      �� 5M      -   5         ��Name$ 	menuLabel��5M       $��Меню��63   $��Center=�6?   ���	#FF31577E$��70, 5, 5, 0q�6q   $��20(�6�   �� 5O      $��80��6   $��Bottom=�6(   5P      �� 5Q      -   5         ��Name$ ListViewMenu��5Q      ���	#FF5C99D6$��Disabled=�6H   .@�5R      �� -	   5         ��Name$ ItemList��5R   #   $��60��65   .��5S      �� $ 
Horizontal=�6%   .+�5T        $ ClipboardList=�66   $��25��6K   $��25��6W   $��10q�6b   �� 5U      $��
Обзор��6(   $��Center=�65   $��20 10q�6P   5V      5W      �� 5X      -
   5        $ ItemDictionary��5X   #   $��60��6;   .��5Y      �� $ 
Horizontal=�6%   .+�5Z        $ Search=�66   $��25��6D   $��25��6P   $��10q�6[   �� 5[      $��
Поиск��6(   $��Center=�65   $��20 10q�6P   5\      5]      .   (System.Windows.Interactivity.Interaction   Triggers 5_      /   )System.Windows.Interactivity.EventTrigger  5`         	EventName$ SelectionChanged��6)   .   (System.Windows.Interactivity.TriggerBase   Actions. 5a      6   0System.Windows.Interactivity.InvokeCommandAction     Command 64   �� *SelectedPageCommand+    CommandParameter  5b   4   �� ! �� ElementName$! ListViewMenu��5c      5e      5f      5g      5h      5i      