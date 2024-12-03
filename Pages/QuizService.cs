namespace Synaptica.Pages
{
    public static class QuizService
    {
        public static List<QuizQuestion> GetQuestionsByQuizId(int quizId)
        {
            return quizId switch
            {
              
                1 => new List<QuizQuestion>
                {
                    new QuizQuestion { Question = "What is the output of `print(2 ** 3)` in Python?", Options = new List<string> { "6", "8", "9", "5" }, CorrectAnswer = 1 },
                    new QuizQuestion { Question = "Which of these is a mutable data type in Python?", Options = new List<string> { "Tuple", "String", "List", "Integer" }, CorrectAnswer = 2 },
                    new QuizQuestion { Question = "What keyword is used to define a function in Python?", Options = new List<string> { "func", "function", "def", "define" }, CorrectAnswer = 2 },
                    new QuizQuestion { Question = "Which Python library is used for data analysis?", Options = new List<string> { "NumPy", "pandas", "matplotlib", "scipy" }, CorrectAnswer = 1 },
                    new QuizQuestion { Question = "What is the correct file extension for Python files?", Options = new List<string> { ".py", ".python", ".p", ".pyth" }, CorrectAnswer = 0 },
                },

           
                2 => new List<QuizQuestion>
                {
                    new QuizQuestion { Question = "What does HTML stand for?", Options = new List<string> { "Hyper Text Markup Language", "Hyperlinks and Text Markup Language", "Home Tool Markup Language", "Hyperlink Text Management Language" }, CorrectAnswer = 0 },
                    new QuizQuestion { Question = "What is the purpose of CSS in web development?", Options = new List<string> { "Structure content", "Style content", "Add interactivity", "Manage server requests" }, CorrectAnswer = 1 },
                    new QuizQuestion { Question = "Which JavaScript method is used to select an element by its ID?", Options = new List<string> { "getElementById()", "querySelector()", "getElementByClass()", "findById()" }, CorrectAnswer = 0 },
                },

                
            };
        }

        public static string GetQuizTitle(int quizId)
        {
            return quizId switch
            {
                1 => "Python Basics",
                2 => "Web Development Essentials",
                _ => "Default Quiz"
            };
        }
    }
}