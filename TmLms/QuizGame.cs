using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        PictureBox seperator = new PictureBox();

        public QuizGame()
        {
            InitializeComponent();
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

        public void startQuiz()
        {

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
        }

        public void QuestionContainer(int counter)
        {
            questionLayout = new TableLayoutPanel
            {
                RowCount = 3,
                Dock = DockStyle.Fill,
                RowStyles = { new RowStyle(SizeType.Percent, 35F),
                    new RowStyle(SizeType.Percent, 55F),
                    new RowStyle(SizeType.Percent, 10F)}
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

            x = new TableLayoutPanel
            {
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
            questionLayout.Controls.Add(seperator, 0, 2);

            var rand1 = new Random();
            if (activeQuiz.QuizBuild[counter].Type == "multiple choice")
            {
                // multiple choice questions
                x.Controls.Add(new Button
                {
                    Name = counter.ToString(),
                    Text = HttpUtility.HtmlDecode(activeQuiz.QuizBuild[counter].Correct_Ans[0]),
                    Font = new Font("Arial", 20),
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
                    Font = new Font("Arial", 20),
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
                    Font = new Font("Arial", 20),
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
                    Font = new Font("Arial", 20),
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

            foreach(var i in x.Controls.OfType<Button>())
            {
                if (Int32.Parse(i.Name) == index)
                {
                    i.BackColor = Color.White;
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
    }
}
