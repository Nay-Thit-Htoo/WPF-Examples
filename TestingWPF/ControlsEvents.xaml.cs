using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for ControlsEvents.xaml
    /// </summary>
    public partial class ControlsEvents : Window
    {

        List<String> gender = new List<string>() { "Male", "Female","Gay","LGBT","Other" };
        public ControlsEvents()
        {
            InitializeComponent();
        }        

        private void btnSaveUserInfo_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(txtUserName.Text) || String.IsNullOrWhiteSpace(txtUserName.Text))
            {
                txtUserName.Focus();
                return;
            }

            if (String.IsNullOrEmpty(txtPassword.Text) || String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.Focus();
                return;
            }

            ComboBoxItem item = (ComboBoxItem)cboGender.SelectedItem;
            if (item ==null)
            {
                MessageBox.Show("Please,choose gender!");
                return;
            }

            MessageBox.Show($"User Name : {txtUserName.Text} Password : {txtPassword.Text} Gender : {item.Content}");           
        }

        private void btnClearTextboxes_Click(object sender, RoutedEventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            cboGender.SelectedIndex= 0;
        }

        private void cboGender_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem item = (ComboBoxItem)cboGender.SelectedItem;
            //MessageBox.Show($"Your gender is {item.Name}");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cboGender.Items.Clear();
            cboGender.ItemsSource = gender;
        }

        private void txtAge_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mainWindow=new MainWindow();
            mainWindow.Show();
        }
    }
}
