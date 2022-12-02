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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestingWPF
{
    /// <summary>
    /// Interaction logic for MesssageImage.xaml
    /// </summary>
    public partial class MesssageImage : UserControl
    {
        public MesssageImage()
        {
            InitializeComponent();
        }
        public Uri? imageUrl { get; set; }

        private void msgImgUrl_Loaded(object sender, RoutedEventArgs e)
        {
            msgImgUrl.Source = new BitmapImage(this.imageUrl); 
        }

        private void msgImgUrl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ViewImage viewImage=new ViewImage();
            viewImage.imageUrl = this.imageUrl;
            viewImage.ShowDialog();
        }
    }
}
