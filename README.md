# CyberBot WPF Application

**CyberBot** is a WPF desktop application that combines a simple **task manager**, a **cybersecurity quiz game**, and an interactive **chat-like assistant interface**. Users can add, view, delete, and toggle tasks, while also learning about cybersecurity through a multiple-choice game.

---

## ✨ Features

### 🧠 Intelligent Chat Interface
- Greets users and stores their name
- Responds to freeform inputs
- Offers command-based interaction (`add task`, `play game`, etc.)

### ✅ Task Management
- Add tasks with a title, description, and optional reminder date
- View all tasks with details
- Delete tasks by number (e.g. `delete 2`)
- Toggle completion status (e.g. `toggle 1`)

### 🔐 Cybersecurity Quiz Game
- Interactive multiple-choice game
- Tracks and scores answers
- Provides instant feedback

### 📝 Activity Log
- Logs task creations and deletions
- Shows system actions and game activity via `view log`

---

## 🚀 How to Run

1. Open the solution in **Visual Studio**
2. Ensure `.NET Desktop Development` is installed
3. Press `F5` or click **Start** to run the application

---

## 🛠 Project Structure

- `MainWindow.xaml`: UI layout
- `MainWindow.xaml.cs`: Main logic and event handlers
- `Task.cs`: Task model with a static task list
- `Game.cs`: Quiz logic and questions
- `ActivityLog.cs`: Logger for system actions
- `Utilities.cs`: Additional helper methods
- `MainLogic.cs`: Handles generic chatbot replies

---

## 💬 Example Commands

| Command           | Description                      |
|------------------|----------------------------------|
| `add task`        | Start the task creation process |
| `view tasks`      | Show all saved tasks            |
| `play game`       | Start the cybersecurity quiz    |
| `view log`        | View activity log               |
| `exit` or `quit`  | Close the application           |

---

## 📸 Screenshot

> Add a screenshot of the app running here (optional)

---

## 📌 License

This project is for educational and demonstration purposes. Free to use and modify.

---

## 🙌 Acknowledgements

Built with 💻 using C# and WPF for interactive desktop experiences.
