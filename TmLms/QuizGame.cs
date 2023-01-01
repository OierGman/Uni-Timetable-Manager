using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace TmLms
{
    public partial class QuizGame : Form
    {
        Quiz activeQuiz;
        TableLayoutPanel quizLayout = new TableLayoutPanel();
        TableLayoutPanel questionLayout = new TableLayoutPanel();
        TableLayoutPanel x = new TableLayoutPanel();
        TableLayoutPanel submit = new TableLayoutPanel();
        PictureBox seperator = new PictureBox();

        int result;
        string answers;

        public QuizGame()
        {
            InitializeComponent();
            AllocConsole();
        }

        private void QuizGame_Load(object sender, EventArgs e)
        {
            label1.Text = Timetable.moduleCode + " -- " + Timetable.courseCode;
            this.panel1.AutoScroll = true;
            this.quizLayout.AutoScroll = true;

            foreach (var i in TMEngine.Instance.CourseDictionary.Values)
            {
                if (i.Code == Timetable.courseCode)
                {
                    foreach ( var j in TMEngine.Instance.ModuleDictionary.Values)
                    {
                        if (j.Code == Timetable.moduleCode)
                        {
                            activeQuiz = j.Quiz;
                        }
                    }
                }
            }
            panel1.Controls.Add(quizLayout);
            AddQuestions();
        }

        public void AddQuestions()
        {
            quizLayout.Dock = DockStyle.Fill;

            for (int i = 0; i < activeQuiz.QuizBuild.Count; i++)
            {
                quizLayout.RowCount += 1;

                quizLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 300));

                QuestionContainer(i);
            }
            SubmitUtillity();
        }

        public void SubmitUtillity()
        {
            submit = new TableLayoutPanel
            {
                ColumnCount = 2,
                Dock = DockStyle.Fill,
                ColumnStyles = { new ColumnStyle(SizeType.Percent, 50F),
                    new ColumnStyle(SizeType.Percent, 50F) }
            };

            quizLayout.Controls.Add(submit);

            Button check = new Button
            {
                Text = "Check Answers",
                Font = new Font("Arial", 15),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.LightGreen,
                FlatAppearance =
                    { BorderSize = 0, MouseDownBackColor = Color.Transparent, MouseOverBackColor = Color.Green },
                     
            };
            Button submitAns = new Button
            {
                Text = "Submit Answers",
                Font = new Font("Arial", 15),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.LightGreen,
                FlatAppearance =
                    { BorderSize = 0, MouseDownBackColor = Color.Transparent, MouseOverBackColor = Color.Green }
            };

            submit.Controls.Add(check, 0, 0);
            submit.Controls.Add(submitAns, 1, 0);

            foreach (var button in submit.Controls.OfType<Button>())
            {
                button.Click += specialButton_Click;
            }
        }

        private void specialButton_Click(object? sender, EventArgs e)
        {
            if (((Button)sender).Text == "Check Answers")
            {
                // sum up totals of answers
                foreach (var row in quizLayout.Controls.OfType<TableLayoutPanel>())
                {
                    foreach (var questions in row.Controls.OfType<TableLayoutPanel>())
                    {
                        foreach (var answer in questions.Controls.OfType<Button>())
                        {
                            if (answer.BackColor == Color.LightBlue && answer.Text == activeQuiz.QuizBuild[Int32.Parse(row.Name)].Correct_Ans[0])
                            {
                                result += activeQuiz.QuizBuild[Int32.Parse(row.Name)].Marks;
                            }
                            answers += "Q" + row.Name + ": " + activeQuiz.QuizBuild[Int32.Parse(row.Name)].Correct_Ans[0] + "\n";
                        }
                    }
                }
                MessageBox.Show(result.ToString() + "/" + activeQuiz.MaximumMarks() + "\n\n" + answers);
                result = 0;
                answers = "";
            }
            else
            {
                // store result and same to user profile
                foreach (var row in quizLayout.Controls.OfType<TableLayoutPanel>())
                {
                    foreach (var questions in row.Controls.OfType<TableLayoutPanel>())
                    {
                        foreach (var answer in questions.Controls.OfType<Button>())
                        {
                            if (answer.BackColor == Color.LightBlue && answer.Text == activeQuiz.QuizBuild[Int32.Parse(row.Name)].Correct_Ans[0])
                            {
                                result += activeQuiz.QuizBuild[Int32.Parse(row.Name)].Marks;
                            }
                            answers += "Q" + row.Name + ": " + activeQuiz.QuizBuild[Int32.Parse(row.Name)].Correct_Ans[0] + "\n";
                        }
                    }
                }
                Timetable.currentUser.results.Add(Timetable.moduleCode, ((result / activeQuiz.MaximumMarks()) * 100).ToString());
                this.Close();
            }
        }

        public void QuestionContainer(int counter)
        {
            questionLayout = new TableLayoutPanel
            {
                Name = counter.ToString(),
                RowCount = 3,
                Dock = DockStyle.Fill,
                RowStyles = { new RowStyle(SizeType.Percent, 35F),
                    new RowStyle(SizeType.Percent, 55F),
                    new RowStyle(SizeType.Percent, 5F),
                    new RowStyle(SizeType.Percent, 5F)}
            };

            seperator = new PictureBox
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Gray,
            };
    
            Label question = new Label
            {
                Text = HttpUtility.HtmlDecode(activeQuiz.QuizBuild[counter].Question),
                Font = new Font("Arial", 24),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.Transparent
            };

            Label result = new Label
            {
                Font = new Font("Arial", 10),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Right,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.Transparent
            };

            x = new TableLayoutPanel
            {
                Name = counter.ToString(),
                RowCount = 2,
                ColumnCount = 2,
                Dock = DockStyle.Fill,

                ColumnStyles = { new ColumnStyle(SizeType.Percent, 50F),
                    new ColumnStyle(SizeType.Percent, 50F) },

                RowStyles = { new RowStyle(SizeType.Percent, 50F),
                    new RowStyle(SizeType.Percent, 50F) }
            };
 
            quizLayout.Controls.Add(questionLayout);
            questionLayout.Controls.Add(question, 0, 0);
            questionLayout.Controls.Add(x, 0, 1);
            questionLayout.Controls.Add(result, 0, 2);
            questionLayout.Controls.Add(seperator, 0, 3);

            var rand1 = new Random();
            if (activeQuiz.QuizBuild[counter].Type == "Multiple Choice")
            {
                result.Text = "/" + activeQuiz.QuizBuild[counter].Marks.ToString();
                // multiple choice questions
                x.Controls.Add(new Button
                {
                    Name = counter.ToString(),
                    Text = HttpUtility.HtmlDecode(activeQuiz.QuizBuild[counter].Correct_Ans[0]),
                    Font = new Font("Arial", 15),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill,
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.Coral,
                    FlatAppearance =
                    { BorderSize = 0, MouseDownBackColor = Color.Transparent, MouseOverBackColor = Color.Green }
                }, rand1.Next(0, 2), rand1.Next(0, 2));

                x.Controls.Add(new Button
                {
                    Name = counter.ToString(),
                    Text = HttpUtility.HtmlDecode(activeQuiz.QuizBuild[counter].Incorrect_Ans[0]),
                    Font = new Font("Arial", 15),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill,
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.WhiteSmoke,
                    FlatAppearance =
                    { BorderSize = 0, MouseDownBackColor = Color.Transparent, MouseOverBackColor = Color.Green }
                });

                x.Controls.Add(new Button
                {
                    Name = counter.ToString(),
                    Text = HttpUtility.HtmlDecode(activeQuiz.QuizBuild[counter].Incorrect_Ans[1]),
                    Font = new Font("Arial", 15),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill,
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.WhiteSmoke,
                    FlatAppearance =
                    { BorderSize = 0, MouseDownBackColor = Color.Transparent, MouseOverBackColor = Color.Green }
                });

                x.Controls.Add(new Button
                {
                    Name = counter.ToString(),
                    Text = HttpUtility.HtmlDecode(activeQuiz.QuizBuild[counter].Incorrect_Ans[2]),
                    Font = new Font("Arial", 15),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill,
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.WhiteSmoke,
                    FlatAppearance =
                    { BorderSize = 0, MouseDownBackColor = Color.Transparent, MouseOverBackColor = Color.Green }
                });
            }
            foreach (var button in x.Controls.OfType<Button>())
            {
                button.Click += button_Click;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            int index = Int32.Parse(((Control)sender).Name);
            
            foreach (var row in quizLayout.Controls.OfType<TableLayoutPanel>())
            {
                foreach (var questions in row.Controls.OfType<TableLayoutPanel>())
                {
                    foreach (var answer in questions.Controls.OfType<Button>())
                    {
                        if (Int32.Parse(answer.Name) == index)
                        {
                            answer.BackColor = Color.White;
                        }
                    }
                }
            }
            
            ((Button)sender).BackColor = Color.LightBlue;

            if (((Button)sender).Text == activeQuiz.QuizBuild[index].Correct_Ans[0])
            {
                label3.Text = "CORRECT";
            }
            else
            {
                label3.Text = "INCORRECT";
            }
        }
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool AllocConsole();
    }
}
