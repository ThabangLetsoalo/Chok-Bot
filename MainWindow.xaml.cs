using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static WpfApp1.Task;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainLogic logic = new MainLogic();
        Utilities utilities = new Utilities();

        private string userName;
        public string responseText;


        public MainWindow()
        {
            InitializeComponent();
            ChatListBox.Items.Add("🤖 Hello! Welcome to CyberBot.");
            ChatListBox.Items.Add("🤖 Please enter your name:");


        }

        private void subBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UserInput.Text))
            {
                MessageBox.Show("🤖 Please enter a valid name.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (string.IsNullOrEmpty(userName))
            {
                userName = UserInput.Text.Trim();
                ChatListBox.Items.Add($"👤 {userName}");
                ChatListBox.Items.Add($"🤖 Nice to meet you {userName}. How are you feeling today?");
                UserInput.Clear();
                UserInput.IsEnabled = true;
                return;
            }

            responseText = UserInput.Text.Trim().ToLower();
            logic.replie = responseText;
            UserInput.Clear();
            //move this to its own method in the main function class and add a method where i can ask the bot how it is
            logic.HUDResponse();
            //ChatListBox.Items.Add($"👤 {logic.Answer}");
            UserInput.Clear();
            logic.Response();
            ChatListBox.Items.Add("🤖 What do you want to know about cyber security?");
            responseText = UserInput.Text.Trim().ToLower();
            logic.Answer = responseText; 

        }
    }
}