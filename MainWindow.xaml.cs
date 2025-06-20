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
            InitializeChat();
        }
        private void InitializeChat()
        {
            //utilities.Greeting();
            ChatListBox.Items.Add("🤖 Hello! Welcome to CyberBot.");
            ChatListBox.Items.Add("🤖 Please enter your name:");
        }
        private void subBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!IsUserInputValid()) return;

            if (string.IsNullOrEmpty(userName))
            {
                //SetUserName();
                Task();
                return;
            }

            //HandleConversation();
            
        }

        private bool IsUserInputValid()
        {
            if (string.IsNullOrWhiteSpace(UserInput.Text))
            {
                MessageBox.Show("🤖 Please enter something.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }
            return true;
        }

        private void SetUserName()
        {
            userName = UserInput.Text.Trim();
            ChatListBox.Items.Add($"👤 {userName}");
            ChatListBox.Items.Add($"🤖 Nice to meet you {userName}. What would you like to talk about?");
            UserInput.Clear();
        }

        private void HandleConversation()
        {
            responseText = UserInput.Text.Trim();
            ChatListBox.Items.Add($"👤 {responseText}");

            logic.Answer = responseText.ToLower();
            logic.Response();

            ChatListBox.Items.Add($"🤖 {logic.botRes}");
            ChatListBox.Items.Add("🤖 What do you want to know about cyber security?");

            UserInput.Clear();
        }

        private void Task()
        {
            TaskItem task = new TaskItem
            {
                Title = "Sample Task",
                Description = "This is a sample task description.",
                ReminderDate = DateTime.Now.AddDays(1),
                IsCompleted = false
            };
            // Here you can add logic to display or manage the task as needed
            MessageBox.Show($"Task Created: {task.Title}\nDescription: {task.Description}\nReminder: {task.ReminderDate}", "Task Created", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}