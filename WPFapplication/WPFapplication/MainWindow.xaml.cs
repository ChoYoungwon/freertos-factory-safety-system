using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFapplication
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

        private void btn_doSomeThing_Click(object sender, RoutedEventArgs e)
        {
            List<User> userList1 = new List<User>();
            User userA = new User();
            userA.UserImg = @"C:\Users\lka11\OneDrive\Desktop\스마트팩토리 구현 sw\codes\WPFapplication\people.jpg";
            userA.Name = "Noah";
            userA.UserAge = 5;

            User userB = new User();
            userB.UserImg = @"C:\Users\lka11\OneDrive\Desktop\스마트팩토리 구현 sw\codes\WPFapplication\portrait.jpg";
            userB.Name = "Liam";
            userB.UserAge = 8;

            userList1.Add(userA);
            userList1.Add(userB);

            listView_user.ItemsSource = userList1;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {

        }
    }
}