using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TmLms
{
    public partial class quizForm : Form
    {
        public quizForm()
        {
            InitializeComponent();
        }

        private void quizForm_Load(object sender, EventArgs e)
        {
            foreach (var i in TMEngine.Instance.ModuleDictionary)
            {
                comboBoxModules.Items.Add(i.Value.Name);
            }
            foreach (var i in Questions.questions)
            {
                checkedListBoxQuestions.Items.Add(i.Question);
            }
        }

        private void buttonAddCorrect_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBoxCorrect.Text);
            textBoxCorrect.Text = "";
        }

        private void buttonAddIncorrect_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBoxIncorrect.Text);
            textBoxIncorrect.Text = "";
        }

        private void buttonCorrectDel_Click(object sender, EventArgs e)
        {
            try { listBox1.Items.RemoveAt(listBox1.SelectedIndex); }
            catch { }
            
        }

        private void buttonIncorrectDel_Click(object sender, EventArgs e)
        {
            try { listBox2.Items.RemoveAt(listBox2.SelectedIndex); }
            catch { }
            
        }

        private void buttonAddQuestion_Click(object sender, EventArgs e)
        {
            Questions.questions.Add(new Questions(comboBox1.Text, textBoxQuestion.Text, 
                listBox1.Items.Cast<string>().ToList(), listBox2.Items.Cast<string>().ToList(), 
                (int)numericUpDownMarks.Value));

            checkedListBoxQuestions.Items.Clear();
            foreach (var i in Questions.questions)
            {
                checkedListBoxQuestions.Items.Add(i.Question);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateForm();
        }

        public void updateForm()
        {
            /*
             * case to meaning
             
                Multiple Choice
                Multiple Answer
                Boolean
                Short Answer
                Essay
                Matching
            */
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    textBoxCorrect.Visible = true;
                    textBoxIncorrect.Visible = true;
                    buttonAddCorrect.Visible = true;
                    buttonAddIncorrect.Visible = true;
                    buttonCorrectDel.Visible = true;
                    buttonIncorrectDel.Visible = true;
                    listBox1.Visible = true;
                    listBox2.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    break;
                case 1:
                    textBoxCorrect.Visible = true;
                    textBoxIncorrect.Visible = true;
                    buttonAddCorrect.Visible = true;
                    buttonAddIncorrect.Visible = true;
                    buttonCorrectDel.Visible = true;
                    buttonIncorrectDel.Visible = true;
                    listBox1.Visible = true;
                    listBox2.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label2.Text = "Correct Answer (Add minimum 2)";
                    break;
                case 2:
                    textBoxCorrect.Visible = true;
                    textBoxIncorrect.Visible = false;
                    buttonAddCorrect.Visible = true;
                    buttonAddIncorrect.Visible = false;
                    buttonCorrectDel.Visible = true;
                    buttonIncorrectDel.Visible = false;
                    listBox1.Visible = true;
                    listBox2.Visible = false;
                    label2.Visible = true;
                    label3.Visible = false;
                    break;
                case 3:
                    textBoxCorrect.Visible = true;
                    textBoxIncorrect.Visible = false;
                    buttonAddCorrect.Visible = true;
                    buttonAddIncorrect.Visible = false;
                    buttonCorrectDel.Visible = true;
                    buttonIncorrectDel.Visible = false;
                    listBox1.Visible = true;
                    listBox2.Visible = false;
                    label2.Visible = true;
                    label3.Visible = false;
                    break;
                case 4:
                    textBoxCorrect.Visible = false;
                    textBoxIncorrect.Visible = false;
                    buttonAddCorrect.Visible = false;
                    buttonAddIncorrect.Visible = false;
                    buttonCorrectDel.Visible = false;
                    buttonIncorrectDel.Visible = false;
                    listBox1.Visible = false;
                    listBox2.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    break;
                default:
                    textBoxCorrect.Visible = true;
                    textBoxIncorrect.Visible = true;
                    buttonAddCorrect.Visible = true;
                    buttonAddIncorrect.Visible = true;
                    buttonCorrectDel.Visible = true;
                    buttonIncorrectDel.Visible = true;
                    listBox1.Visible = true;
                    listBox2.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    break;

            }
        }

        private void buttonAddToModule_Click(object sender, EventArgs e)
        {
            var qlist = new List<Questions>();

            for (int i = 0; i < checkedListBoxQuestions.Items.Count; i++)
            {
                if (checkedListBoxQuestions.GetItemCheckState(i) == CheckState.Checked)
                {
                    qlist.Add(Questions.questions[i]);
                }
            }
            
            Quiz newQuiz = new Quiz(textBoxQuizName.Text, qlist);
            TMEngine.Instance.ModuleDictionary[comboBoxModules.SelectedIndex+1].Quiz = newQuiz;

            // testing
            MessageBox.Show(TMEngine.Instance.ModuleDictionary[1].Quiz.Name + "\n\r" + TMEngine.Instance.ModuleDictionary[1].Quiz.QuizBuild[0].Correct_Ans.ToString());
        }

        async Task GetQuizCategories(BackgroundWorker worker, DoWorkEventArgs e)
        {
            await TMEngine.GetCategories();
        }

        private async void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = (BackgroundWorker)sender;

            e.Result = GetQuizCategories(worker, e);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            QuizAPI x = new QuizAPI();
            x.Show();
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy != true)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }
    }
}
