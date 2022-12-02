using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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
    /// Interaction logic for Message.xaml
    /// </summary>
    public partial class Message : Window
    {
        public Message()
        {
            InitializeComponent();
            GenerateMessages();    
        }
        List<MessageConversation> messageConversations = new List<MessageConversation>();
        public static int ReceiverId { get; set; }

        public void GenerateMessages()
        {
            #region mc_1
            List<MessageConversationDetail> md_1 = new List<MessageConversationDetail>();
           
            MessageConversationDetail mdObj_1 = new MessageConversationDetail();
            mdObj_1.SenderID = 1;
            mdObj_1.ReceiverID = 2;
            mdObj_1.MessageBody = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";
            mdObj_1.MessageDate = DateTime.Now;
            mdObj_1.MessageConverationId = 1;
            md_1.Add(mdObj_1);

            MessageConversationDetail mdObj_2 = new MessageConversationDetail();
        mdObj_2.SenderID = 2;
            mdObj_2.ReceiverID = 1;         
            mdObj_2.MessageBody = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";
            mdObj_2.MessageDate = DateTime.Now;
            mdObj_2.MessageConverationId = 1;
            md_1.Add(mdObj_2);

            MessageConversationDetail mdObj_3 = new MessageConversationDetail();
        mdObj_3.SenderID = 1;
            mdObj_3.ReceiverID = 2; 
            mdObj_3.MessageBody = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.";
            mdObj_3.MessageDate = DateTime.Now;
            mdObj_3.MessageConverationId = 1;
            md_1.Add(mdObj_3);

            MessageConversation mc_1 = new MessageConversation();
        mc_1.ID = 1;
            mc_1.SenderID = 1;
            mc_1.ReceiverID = 2;
            mc_1.SenderName = "Nay Thit Htoo";
            mc_1.SenderProfileImage = new Uri("https://cdn-icons-png.flaticon.com/128/3135/3135715.png");
        mc_1.ReceiverProfileImage = new Uri("https://cdn-icons-png.flaticon.com/512/2202/2202112.png");
        mc_1.ReceiverName = "Aung Aung";
            mc_1.MessageConversationDetails = md_1;
            messageConversations.Add(mc_1);
            #endregion

            #region mc_2
            List<MessageConversationDetail> md_2 = new List<MessageConversationDetail>();

        MessageConversationDetail md2Obj_1 = new MessageConversationDetail();
        md2Obj_1.SenderID = 1;
            md2Obj_1.ReceiverID = 3;         
            md2Obj_1.MessageBody = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";
            md2Obj_1.MessageDate = DateTime.Now;
            md2Obj_1.MessageConverationId = 2;
            md2Obj_1.ImageList= new List<String>()
            {
                "https://cdn.pixabay.com/photo/2015/04/23/22/00/tree-736885__480.jpg",
               "https://cdn.pixabay.com/photo/2015/04/23/22/00/tree-736885__480.jpg",
               "https://cdn.pixabay.com/photo/2015/04/23/22/00/tree-736885__480.jpg",
               "https://cdn.pixabay.com/photo/2015/04/23/22/00/tree-736885__480.jpg"
            };
    md_2.Add(md2Obj_1);

            MessageConversationDetail md2Obj_2 = new MessageConversationDetail();
    md2Obj_2.SenderID = 1;
            md2Obj_2.ReceiverID = 3;           
            md2Obj_2.MessageBody = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";
            md2Obj_2.MessageDate = DateTime.Now;
            md2Obj_2.MessageConverationId = 2;
            md_2.Add(md2Obj_2);

            MessageConversationDetail md2Obj_3 = new MessageConversationDetail();
    md2Obj_3.SenderID = 3;
            md2Obj_3.ReceiverID = 1; 
            md2Obj_3.MessageBody = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.";
            md2Obj_3.MessageDate = DateTime.Now;
            md2Obj_3.MessageConverationId = 2;
            md_2.Add(md2Obj_3);

            MessageConversation mc_2 = new MessageConversation();
    mc_2.ID = 1;
            mc_2.SenderID = 1;
            mc_2.ReceiverID = 3;
            mc_2.SenderName = "Nay Thit Htoo";
            mc_2.SenderProfileImage = new Uri("https://cdn-icons-png.flaticon.com/128/3135/3135715.png");
    mc_2.ReceiverProfileImage = new Uri("https://cdn-icons-png.flaticon.com/512/949/949508.png");
    mc_2.ReceiverName = "Maung Maung";
            mc_2.MessageConversationDetails = md_2;
            messageConversations.Add(mc_2);
            #endregion

            CreateMessageUserList();
        }
      public void CreateMessageUserList()
        {            
            messageUsersPanel.Children.Clear();
            foreach (MessageConversation mc in messageConversations)
            {
                if(mc.MessageConversationDetails.Count()>0)
                {
                    MessageUser mu = new MessageUser();
                    mu.messageConversation = mc;
                    messageUsersPanel.Children.Add(mu);
                }             
            }
            CreateMessageDeatil();
        }
        public void CreateMessageDeatil()
        {
            if(ReceiverId>0)
            {
                MessageConversation? messageConversation = messageConversations.Where(x => x.ReceiverID == ReceiverId).FirstOrDefault();

                     MessageConversationDetail? mcd = messageConversation?.MessageConversationDetails.LastOrDefault();                
                    MessageDetail md = new MessageDetail();
                    if (mcd?.SenderID == messageConversation?.SenderID)
                    {
                        md.ProfileName = messageConversation?.SenderName;
                        md.ProfileImage = messageConversation?.SenderProfileImage;
                        md.IsSender = true;
                    }
                    else
                    {
                        md.ProfileName = messageConversation?.ReceiverName;
                        md.ProfileImage = messageConversation?.ReceiverProfileImage;
                        md.IsSender = false;
                    }
                    md.imageList = mcd?.ImageList;
                    md.MessageBody = mcd?.MessageBody;
                    md.MessageDate = mcd?.MessageDate.ToString();
                    msgDetailPanel.Children.Add(md);                
               
                txtMsgUserName.Text = messageConversation?.ReceiverName;
                msgBody.Visibility = Visibility.Visible;
                msgBodyScroll.ScrollToBottom();
            }       
        }
        private void StackPanel_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if(String.IsNullOrEmpty(txtMessageText.Text) || String.IsNullOrWhiteSpace(txtMessageText.Text))
            {
                txtMessageText.Focus();
                return;
            }
            int index= messageConversations.FindIndex(x => x.ReceiverID == ReceiverId);
            if (index == -1) return;
            MessageConversation mc = messageConversations[index];
           MessageConversationDetail mcd = new MessageConversationDetail()
            {
                MessageBody = txtMessageText.Text,
                ReceiverID = ReceiverId,
                SenderID = 1,
                MessageDate = DateTime.Now,
                MessageConverationId = mc.ID,
                Id= mc.MessageConversationDetails.Count()+1,        
            };
            mc.MessageConversationDetails.Add(mcd);
            messageConversations[index] = mc;
            txtMessageText.Clear();
            CreateMessageUserList();
        }

        private void txtMessageText_KeyDown(object sender, KeyEventArgs e)
        {        
                if (e.Key == Key.Return)
                {
                   StackPanel_PreviewMouseDown(sender, null);
                }            
        }

        private void ImageChoose_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Multiselect = true;
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                MessageDetail msgDetail = new MessageDetail();
                msgDetail.SendImages = true;
                msgDetail.IsSender = true;
                msgDetail.MessageDate = DateTime.Now.ToString();
                msgDetail.ProfileName = "Nay Thit Htoo";
                msgDetail.ProfileImage = new Uri("https://cdn-icons-png.flaticon.com/128/3135/3135715.png");
                msgDetail.imageList= new List<string>();
                msgDetail.imageList.AddRange(op.FileNames);
                msgDetailPanel.Children.Add(msgDetail);
                msgBodyScroll.ScrollToBottom();
            }
        }
    }

    public class MessageConversation
    {
        public int ID { get; set; }
        public int SenderID { get; set; }
        public string? SenderName { get; set; }
        public Uri? SenderProfileImage { get; set; }
        public int ReceiverID { get; set; }
        public string? ReceiverName { get; set; }
        public Uri? ReceiverProfileImage { get; set; }
        public List<MessageConversationDetail> MessageConversationDetails { get; set; }
}
    public class MessageConversationDetail
    {
        public int Id { get; set; }
        public int MessageConverationId { get; set; }       
        public string? MessageBody { get; set; }
        public int SenderID { get; set; }
        public int ReceiverID { get; set; }
        public DateTime? MessageDate { get; set; }
        public List<String> ImageList { get; set; }
    }

}
