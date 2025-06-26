using System.Diagnostics;
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
        Game game = new Game();
        private string userName;
        public string responseText;

        public string Title;
        public string Description;
        public DateTime? ReminderDate;
        public bool IsCompleted;
        private bool isCreatingTask = false;
        //private int currentQuestionIndex = 0;
        private bool isPlayingGame = false;
        int gameStep = 0;
        private bool isAnsweringQuestion = false;



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
            if (!IsUserInputValid())
                return;

            if (string.IsNullOrEmpty(userName))
            {
                SetUserName();
                return;
            }
            if (isCreatingTask)
            {
                ProcessUserInput();
                return;
            }

            string input = UserInput.Text.Trim().ToLower();

            if (isPlayingGame && isAnsweringQuestion)
            {
                HandleGameInput(input);
                return;
            }

            if (input == "add task")
            {
                isCreatingTask = true;
                ProcessUserInput();
            }
            else if (input == "play game")
            {
                StarGame();
            }
            else
            {
                HandleConversation();
            }
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
            ChatListBox.Items.Add("🤖 What would you like to talk about?");

            UserInput.Clear();
            return;
        }

        private int taskCreationStep = 0;
        private Task currentTaskItem = new Task();

        private void ProcessUserInput()
        {
            string input = UserInput.Text.Trim();
            ChatListBox.Items.Add($"👤 {input}");
            UserInput.Clear();

            switch (taskCreationStep)
            {
                case 0:
                    ChatListBox.Items.Add("🤖 Please enter a title for the task:");
                    taskCreationStep++;
                    break;

                case 1:
                    currentTaskItem.Title = input;
                    ChatListBox.Items.Add("🤖 Please enter a description for the task:");
                    taskCreationStep++;
                    break;

                case 2:
                    currentTaskItem.Description = input;
                    ChatListBox.Items.Add("🤖 Please enter a reminder date (optional, format: yyyy-MM-dd):");
                    taskCreationStep++;
                    break;

                case 3:
                    if (DateTime.TryParse(input, out DateTime reminderDate))
                    {
                        currentTaskItem.ReminderDate = reminderDate;
                        ChatListBox.Items.Add($"🤖 Reminder set for: {reminderDate.ToShortDateString()}");
                    }
                    else
                    {
                        currentTaskItem.ReminderDate = null;
                        ChatListBox.Items.Add("🤖 No reminder date set.");
                    }

                    currentTaskItem.IsCompleted = false;
                    taskCreationStep = 0;

                    MessageBox.Show(
                        $"Task Created: {currentTaskItem.Title}\nDescription: {currentTaskItem.Description}\nReminder: {currentTaskItem.ReminderDate}",
                        "Task Created", MessageBoxButton.OK, MessageBoxImage.Information);

                    //currentTaskItem = new TaskItem(); // reset for next task
                    break;
            }
            return;
        }

        private void StarGame()
        {
            isPlayingGame = true;
            gameStep = 0;
            game.score = 0;
            AskNextQuestion();
        }

        private void AskNextQuestion()
        {
            if (gameStep >= game.questions.Count)
            {
                ChatListBox.Items.Add($"\n🎉 Game Over! Your score is {game.score}/{game.questions.Count}.");
                isPlayingGame = false;
                return;
            }

            var q = game.questions[gameStep];
            ChatListBox.Items.Add($"\nQuestion {gameStep + 1}: {q.Text}");
            ChatListBox.Items.Add(q.OptionA);
            ChatListBox.Items.Add(q.OptionB);
            ChatListBox.Items.Add(q.OptionC);
            ChatListBox.Items.Add(q.OptionD);
            isAnsweringQuestion = true;
        }

        private void HandleGameInput(string input)
        {
            var correctAnswer = game.questions[gameStep].CorrectAnswer.ToString().ToLower();

            if (input == correctAnswer)
            {
                ChatListBox.Items.Add("✅ Correct!");
                game.score++;
            }
            else
            {
                ChatListBox.Items.Add($"❌ Incorrect. Correct answer was '{correctAnswer}'.");
            }

            gameStep++;
            isAnsweringQuestion = false;
            AskNextQuestion();
        }


    }
}