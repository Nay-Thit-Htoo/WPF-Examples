using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TestingWPF
{
    /// <summary>
    /// Interaction logic for ViewImage.xaml
    /// </summary>
    public partial class ViewImage : Window
    {
        public ViewImage()
        {
            InitializeComponent();
        }
        public Uri? imageUrl { get; set; }

        private void ViewImage_Loaded(object sender, RoutedEventArgs e)
        {
            imgVPhoto.Source = new BitmapImage(this.imageUrl);
            imgVPhoto.Visibility= Visibility.Visible;   
        }
    }
}
