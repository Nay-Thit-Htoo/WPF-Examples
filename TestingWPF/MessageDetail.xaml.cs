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
    /// Interaction logic for MessageDetail.xaml
    /// </summary>
    public partial class MessageDetail : UserControl
    {
        public MessageDetail()
        {
            InitializeComponent();
        }
        public Uri? ProfileImage { get; set; }
        public String? ProfileName { get; set; }
        public String? MessageBody { get; set; }     
        public String? MessageDate { get; set; }
        public bool IsSender { get; set; }
        public List<String> imageList { get; set; }
        public bool SendImages { get; set; }
        private void StackPanel_Loaded(object sender, RoutedEventArgs e)
        {
            if (IsSender==true)
            {
                msgSenderPanel.Visibility = Visibility.Visible;
                msgReceiverPanel.Visibility = Visibility.Collapsed;
                senderProfileImg.ImageSource = new BitmapImage(this.ProfileImage);
                senderUserName.Text = this.ProfileName;
                senderMsgBody.Text = this.MessageBody;
                senderMsgDate.Text = this.MessageDate;      
                if(SendImages==true)
                {
                    if (this.imageList != null && this.imageList.Count() > 0)
                    {
                        senderMsgImages.Children.Clear();
                        foreach (String img in imageList)
                        {
                            MesssageImage msgImage = new MesssageImage();
                            msgImage.imageUrl = new Uri(img);
                            msgReceiverPanel.Visibility = Visibility.Collapsed;
                            msgSenderPanel.Visibility = Visibility.Visible;
                            senderMsgTextPanel.Visibility = Visibility.Collapsed;
                            senderImgPanel.Visibility = Visibility.Visible;                         
                            senderMsgImages.Children.Add(msgImage);
                        }
                    }
                }
                else
                {
                    if (this.imageList != null && this.imageList.Count() > 0)
                    {
                        senderImgPanel.Visibility = Visibility.Visible;
                        senderMsgImages.Children.Clear();
                        foreach (String item in this.imageList)
                        {
                            MesssageImage msgImg = new MesssageImage();
                            msgImg.imageUrl = new Uri(item);
                            senderMsgImages.Children.Add(msgImg);
                        }
                    }
                }
               
            }
            else if(IsSender == false)
            {
                msgSenderPanel.Visibility = Visibility.Collapsed;
                msgReceiverPanel.Visibility = Visibility.Visible;
                receiverProfileImg.ImageSource = new BitmapImage(this.ProfileImage);
                receiverUserName.Text = this.ProfileName;
                receiverMsgBody.Text = this.MessageBody;
                receiverMsgDate.Text = this.MessageDate;                
                if (this.imageList != null &&  this.imageList.Count() > 0)
                {
                    receiverImagePanel.Visibility = Visibility.Visible;
                    receiverMsgImages.Children.Clear();
                    foreach (String item in this.imageList)
                    {
                        MesssageImage msgImg = new MesssageImage();
                        msgImg.imageUrl = new Uri(item);
                        receiverMsgImages.Children.Add(msgImg);
                    }
                }
            }
            
        }
    }
   
}
