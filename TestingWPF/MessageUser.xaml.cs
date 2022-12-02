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
    /// Interaction logic for MessageUser.xaml
    /// </summary>
    public partial class MessageUser : UserControl
    {
        public MessageUser()
        {
            InitializeComponent();
        }
        public MessageConversation messageConversation { get; set; }    
        private void StackPanel_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Message.ReceiverId = messageConversation.ReceiverID;

            Window parentWindow = Window.GetWindow(this);
            object obj = parentWindow.FindName("msgDetailPanel");
            System.Windows.Controls.StackPanel stackPanel = (System.Windows.Controls.StackPanel)obj;
            stackPanel.Children.Clear();

            foreach (MessageConversationDetail mcd in this.messageConversation.MessageConversationDetails)
            {
                MessageDetail md = new MessageDetail();
                if (mcd.SenderID == this.messageConversation.SenderID)
                {
                    md.ProfileName = this.messageConversation.SenderName;
                    md.ProfileImage = this.messageConversation.SenderProfileImage;
                    md.IsSender = true;
                }
                else
                {
                    md.ProfileName = this.messageConversation.ReceiverName;
                    md.ProfileImage = this.messageConversation.ReceiverProfileImage;
                    md.IsSender = false;
                }
                md.imageList = mcd.ImageList;
                md.MessageBody = this.messageConversation.MessageConversationDetails.LastOrDefault()?.MessageBody;
                md.MessageDate = this.messageConversation.MessageConversationDetails.LastOrDefault()?.MessageDate.ToString();
                stackPanel.Children.Add(md);
            }

            object uNameObj = parentWindow.FindName("txtMsgUserName");
            System.Windows.Controls.TextBlock txtUserName = (System.Windows.Controls.TextBlock)uNameObj;
            txtUserName.Text = this.messageConversation.ReceiverName;

            object mesgListGrdObj = parentWindow.FindName("msgBody");
            System.Windows.Controls.Grid grdMesgList = (System.Windows.Controls.Grid)mesgListGrdObj;
            grdMesgList.Visibility = Visibility.Visible;
        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            profileImg.ImageSource = new BitmapImage(this.messageConversation.ReceiverProfileImage);
            userName.Text = this.messageConversation.ReceiverName;
            messageBody.Text = this.messageConversation.MessageConversationDetails.LastOrDefault()?.MessageBody;
            msgDate.Text = this.messageConversation.MessageConversationDetails.LastOrDefault()?.MessageDate.ToString();
        }
    }
}
