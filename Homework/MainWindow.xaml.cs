using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Homework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Ellipse ellipse = new Ellipse();
            ellipse.Fill = Brushes.Yellow;
            ellipse.Height = 100;
            ellipse.Width = 200;
            ellipse.StrokeThickness = 2;
            ellipse.Stroke = Brushes.Black;

            Ellipse ellipse2 = new Ellipse();
            ellipse2.Fill = Brushes.Yellow;
            ellipse2.Height = 100;
            ellipse2.Width = 200;
            ellipse2.StrokeThickness = 2;
            ellipse2.Stroke = Brushes.Black;

            Polyline polyline = new Polyline();
            polyline.Stroke = Brushes.Black;
            polyline.StrokeThickness = 5;
            polyline.Points = new PointCollection() { new Point(0, 50), new Point(30, 50) };

            StackPanel stackpanel = new StackPanel();
            stackpanel.Orientation = Orientation.Horizontal;
            stackpanel.HorizontalAlignment = HorizontalAlignment.Center;
            stackpanel.Children.Add(ellipse);
            stackpanel.Children.Add(polyline);
            stackpanel.Children.Add(ellipse2);

            viewbox.Child = stackpanel;

        }
    }
}
