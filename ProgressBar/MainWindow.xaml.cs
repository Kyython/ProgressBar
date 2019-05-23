using System;
using System.Windows;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace ProgressBar
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = secondRectangle.Width;
            animation.To = firstRectangle.Width;
            animation.Duration = new Duration(TimeSpan.FromSeconds(3));

            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(animation);
            Storyboard.SetTargetName(animation, secondRectangle.Name);
            Storyboard.SetTargetProperty(animation, new PropertyPath(Rectangle.WidthProperty));
            storyboard.Completed += (o, s) => MessageBox.Show("ВСЁ!");
            storyboard.Begin(this);

            
        }
    }
}
