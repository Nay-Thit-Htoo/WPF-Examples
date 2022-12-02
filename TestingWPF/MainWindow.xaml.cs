using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;
using System.ComponentModel;

namespace TestingWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> studentList = new List<Student>();
        int regStudentId = 0;
        int studentId;
        public MainWindow()
        {
            InitializeComponent();           
        }
     
        private void NumberKeyPress(object sender, TextCompositionEventArgs e)
        {
                Regex regex = new Regex("[^0-9]+");
                e.Handled = regex.IsMatch(e.Text);
         }
        private void saveBtn_Click(object sender, RoutedEventArgs e)
        { 
             if(String.IsNullOrEmpty(txtUserName.Text) || String.IsNullOrWhiteSpace(txtUserName.Text))
            {
                txtUserName.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtAge.Text) || String.IsNullOrWhiteSpace(txtAge.Text))
            {
                txtAge.Focus();
                return;
            }

            if (String.IsNullOrEmpty(txtAddress.Text) || String.IsNullOrWhiteSpace(txtAddress.Text))
            {
                txtAddress.Focus();
                return;
            }

            if (String.IsNullOrEmpty(txtClassName.Text) || String.IsNullOrWhiteSpace(txtClassName.Text))
            {
                txtClassName.Focus();
                return;
            }
                     
            //create student object
            Student student = new Student()
            {
                Id = ++regStudentId ,
                Name = txtUserName.Text,
                Age = Convert.ToInt32(txtAge.Text),
                Address = txtAddress.Text,
                ClassName = txtClassName.Text
            };

            //declare student list           
            studentList.Add(student);//add student
            stGrid.ItemsSource = null;//main
            stGrid.ItemsSource = studentList;
            clearBtn_Click(sender, e);
        }
        private void clearBtn_Click(object sender, RoutedEventArgs e)
        {          
            txtUserName.Clear();
            txtAge.Clear();
            txtAddress.Clear();
            txtClassName.Clear();
            updateBtn.Visibility = Visibility.Collapsed;
            saveBtn.Visibility = Visibility.Visible;
        }
        private void grdBtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
             studentId =Convert.ToInt32(button.CommandParameter.ToString());

            Student? student = studentList.FirstOrDefault(x => x.Id ==studentId );
            txtUserName.Text = student.Name;
            txtClassName.Text = student.ClassName;
            txtAge.Text = student.Age.ToString();
            txtAddress.Text = student.Address;
           //To show hide buttons
            saveBtn.Visibility = Visibility.Collapsed;
            updateBtn.Visibility = Visibility.Visible;
        }
        private void grdBtnDelete_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string? userName = button.CommandParameter.ToString();
            Student? student = studentList.FirstOrDefault(student => student.Name == userName);
            studentList.Remove(student);

            stGrid.ItemsSource = null;
            stGrid.ItemsSource = studentList;
        }
        private void updateBtn_Click(object sender, RoutedEventArgs e)
        {
            int index = studentList.FindIndex(x => x.Id == studentId);//get index

            //update student
            Student updateStudent = new Student();
            updateStudent.Id = studentId;
            updateStudent.Name = txtUserName.Text;
            updateStudent.ClassName = txtClassName.Text;
            updateStudent.Age = Convert.ToInt32(txtAge.Text);
            updateStudent.Address = txtAddress.Text;

            studentList[index]= updateStudent;
            stGrid.ItemsSource = null;
            stGrid.ItemsSource = studentList;
            clearBtn_Click(sender, e);
        }
    }
}
