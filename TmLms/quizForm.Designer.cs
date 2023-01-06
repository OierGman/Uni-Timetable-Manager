namespace TmLms
{
    partial class quizForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownMarks = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.buttonAddQuestion = new System.Windows.Forms.Button();
            this.buttonIncorrectDel = new System.Windows.Forms.Button();
            this.buttonCorrectDel = new System.Windows.Forms.Button();
            this.buttonAddCorrect = new System.Windows.Forms.Button();
            this.buttonAddIncorrect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.textBoxIncorrect = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBoxCorrect = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonImport = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonAddToModule = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxModules = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkedListBoxQuestions = new System.Windows.Forms.CheckedListBox();
            this.textBoxQuizName = new System.Windows.Forms.TextBox();
            this.buttonLoadAPIQuiz = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMarks)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.numericUpDownMarks);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxQuestion);
            this.groupBox1.Controls.Add(this.buttonAddQuestion);
            this.groupBox1.Controls.Add(this.buttonIncorrectDel);
            this.groupBox1.Controls.Add(this.buttonCorrectDel);
            this.groupBox1.Controls.Add(this.buttonAddCorrect);
            this.groupBox1.Controls.Add(this.buttonAddIncorrect);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.listBox2);
            this.groupBox1.Controls.Add(this.textBoxIncorrect);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.textBoxCorrect);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 228);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Question Builder";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(691, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Marks";
            // 
            // numericUpDownMarks
            // 
            this.numericUpDownMarks.Location = new System.Drawing.Point(691, 84);
            this.numericUpDownMarks.Name = "numericUpDownMarks";
            this.numericUpDownMarks.Size = new System.Drawing.Size(66, 23);
            this.numericUpDownMarks.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Question";
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Location = new System.Drawing.Point(184, 37);
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(573, 23);
            this.textBoxQuestion.TabIndex = 13;
            // 
            // buttonAddQuestion
            // 
            this.buttonAddQuestion.Location = new System.Drawing.Point(6, 199);
            this.buttonAddQuestion.Name = "buttonAddQuestion";
            this.buttonAddQuestion.Size = new System.Drawing.Size(765, 23);
            this.buttonAddQuestion.TabIndex = 12;
            this.buttonAddQuestion.Text = "Add Question";
            this.buttonAddQuestion.UseVisualStyleBackColor = true;
            this.buttonAddQuestion.Click += new System.EventHandler(this.buttonAddQuestion_Click);
            // 
            // buttonIncorrectDel
            // 
            this.buttonIncorrectDel.Location = new System.Drawing.Point(550, 142);
            this.buttonIncorrectDel.Name = "buttonIncorrectDel";
            this.buttonIncorrectDel.Size = new System.Drawing.Size(68, 23);
            this.buttonIncorrectDel.TabIndex = 11;
            this.buttonIncorrectDel.Text = "Delete";
            this.buttonIncorrectDel.UseVisualStyleBackColor = true;
            this.buttonIncorrectDel.Click += new System.EventHandler(this.buttonIncorrectDel_Click);
            // 
            // buttonCorrectDel
            // 
            this.buttonCorrectDel.Location = new System.Drawing.Point(550, 82);
            this.buttonCorrectDel.Name = "buttonCorrectDel";
            this.buttonCorrectDel.Size = new System.Drawing.Size(68, 23);
            this.buttonCorrectDel.TabIndex = 10;
            this.buttonCorrectDel.Text = "Delete";
            this.buttonCorrectDel.UseVisualStyleBackColor = true;
            this.buttonCorrectDel.Click += new System.EventHandler(this.buttonCorrectDel_Click);
            // 
            // buttonAddCorrect
            // 
            this.buttonAddCorrect.Location = new System.Drawing.Point(218, 82);
            this.buttonAddCorrect.Name = "buttonAddCorrect";
            this.buttonAddCorrect.Size = new System.Drawing.Size(68, 23);
            this.buttonAddCorrect.TabIndex = 9;
            this.buttonAddCorrect.Text = "Add";
            this.buttonAddCorrect.UseVisualStyleBackColor = true;
            this.buttonAddCorrect.Click += new System.EventHandler(this.buttonAddCorrect_Click);
            // 
            // buttonAddIncorrect
            // 
            this.buttonAddIncorrect.Location = new System.Drawing.Point(218, 142);
            this.buttonAddIncorrect.Name = "buttonAddIncorrect";
            this.buttonAddIncorrect.Size = new System.Drawing.Size(68, 23);
            this.buttonAddIncorrect.TabIndex = 8;
            this.buttonAddIncorrect.Text = "Add";
            this.buttonAddIncorrect.UseVisualStyleBackColor = true;
            this.buttonAddIncorrect.Click += new System.EventHandler(this.buttonAddIncorrect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Incorrect Answer ( Add minimum 3)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Correct Answer";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(292, 142);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(252, 49);
            this.listBox2.TabIndex = 5;
            // 
            // textBoxIncorrect
            // 
            this.textBoxIncorrect.Location = new System.Drawing.Point(5, 142);
            this.textBoxIncorrect.Name = "textBoxIncorrect";
            this.textBoxIncorrect.Size = new System.Drawing.Size(207, 23);
            this.textBoxIncorrect.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(292, 83);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(252, 49);
            this.listBox1.TabIndex = 3;
            // 
            // textBoxCorrect
            // 
            this.textBoxCorrect.Location = new System.Drawing.Point(5, 83);
            this.textBoxCorrect.Name = "textBoxCorrect";
            this.textBoxCorrect.Size = new System.Drawing.Size(207, 23);
            this.textBoxCorrect.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Question Type";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Multiple Choice",
            "Multiple Answer",
            "Boolean",
            "Short Answer",
            "Essay",
            "Matching"});
            this.comboBox1.Location = new System.Drawing.Point(6, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 23);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonLoadAPIQuiz);
            this.groupBox2.Controls.Add(this.buttonImport);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.buttonAddToModule);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.comboBoxModules);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.checkedListBoxQuestions);
            this.groupBox2.Controls.Add(this.textBoxQuizName);
            this.groupBox2.Location = new System.Drawing.Point(12, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(784, 214);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quiz Builder";
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(5, 120);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(175, 23);
            this.buttonImport.TabIndex = 17;
            this.buttonImport.Text = "Import Questions";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(220, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Select Questions:";
            // 
            // buttonAddToModule
            // 
            this.buttonAddToModule.Location = new System.Drawing.Point(6, 185);
            this.buttonAddToModule.Name = "buttonAddToModule";
            this.buttonAddToModule.Size = new System.Drawing.Size(765, 23);
            this.buttonAddToModule.TabIndex = 15;
            this.buttonAddToModule.Text = "Add Quiz To Module";
            this.buttonAddToModule.UseVisualStyleBackColor = true;
            this.buttonAddToModule.Click += new System.EventHandler(this.buttonAddToModule_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Select Module";
            // 
            // comboBoxModules
            // 
            this.comboBoxModules.FormattingEnabled = true;
            this.comboBoxModules.Location = new System.Drawing.Point(5, 86);
            this.comboBoxModules.Name = "comboBoxModules";
            this.comboBoxModules.Size = new System.Drawing.Size(175, 23);
            this.comboBoxModules.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Quiz Name";
            // 
            // checkedListBoxQuestions
            // 
            this.checkedListBoxQuestions.FormattingEnabled = true;
            this.checkedListBoxQuestions.Location = new System.Drawing.Point(218, 42);
            this.checkedListBoxQuestions.Name = "checkedListBoxQuestions";
            this.checkedListBoxQuestions.Size = new System.Drawing.Size(539, 130);
            this.checkedListBoxQuestions.TabIndex = 0;
            // 
            // textBoxQuizName
            // 
            this.textBoxQuizName.Location = new System.Drawing.Point(6, 42);
            this.textBoxQuizName.Name = "textBoxQuizName";
            this.textBoxQuizName.Size = new System.Drawing.Size(175, 23);
            this.textBoxQuizName.TabIndex = 15;
            // 
            // buttonLoadAPIQuiz
            // 
            this.buttonLoadAPIQuiz.Location = new System.Drawing.Point(6, 149);
            this.buttonLoadAPIQuiz.Name = "buttonLoadAPIQuiz";
            this.buttonLoadAPIQuiz.Size = new System.Drawing.Size(175, 23);
            this.buttonLoadAPIQuiz.TabIndex = 20;
            this.buttonLoadAPIQuiz.Text = "Load API Questions";
            this.buttonLoadAPIQuiz.UseVisualStyleBackColor = true;
            this.buttonLoadAPIQuiz.Click += new System.EventHandler(this.buttonLoadAPIQuiz_Click);
            // 
            // quizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "quizForm";
            this.Text = "quizForm";
            this.Load += new System.EventHandler(this.quizForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMarks)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private ListBox listBox1;
        private TextBox textBoxCorrect;
        private Label label1;
        private ComboBox comboBox1;
        private Button buttonAddCorrect;
        private Button buttonAddIncorrect;
        private Label label3;
        private Label label2;
        private ListBox listBox2;
        private TextBox textBoxIncorrect;
        private Button buttonIncorrectDel;
        private Button buttonCorrectDel;
        private Label label4;
        private TextBox textBoxQuestion;
        private Button buttonAddQuestion;
        private GroupBox groupBox2;
        private CheckedListBox checkedListBoxQuestions;
        private Label label6;
        private ComboBox comboBoxModules;
        private Label label5;
        private TextBox textBoxQuizName;
        private Label label7;
        private Button buttonAddToModule;
        private Label label8;
        private NumericUpDown numericUpDownMarks;
        private Button buttonImport;
        private Button buttonLoadAPIQuiz;
    }
}