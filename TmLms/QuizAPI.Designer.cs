namespace TmLms
{
    partial class QuizAPI
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
            this.checkedListBoxCategories = new System.Windows.Forms.CheckedListBox();
            this.buttonGetQuiz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBoxDiff = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // checkedListBoxCategories
            // 
            this.checkedListBoxCategories.FormattingEnabled = true;
            this.checkedListBoxCategories.Location = new System.Drawing.Point(12, 31);
            this.checkedListBoxCategories.Name = "checkedListBoxCategories";
            this.checkedListBoxCategories.Size = new System.Drawing.Size(192, 364);
            this.checkedListBoxCategories.TabIndex = 0;
            this.checkedListBoxCategories.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxCategories_ItemCheck);
            // 
            // buttonGetQuiz
            // 
            this.buttonGetQuiz.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonGetQuiz.Location = new System.Drawing.Point(0, 401);
            this.buttonGetQuiz.Name = "buttonGetQuiz";
            this.buttonGetQuiz.Size = new System.Drawing.Size(800, 49);
            this.buttonGetQuiz.TabIndex = 1;
            this.buttonGetQuiz.Text = "Get Quiz";
            this.buttonGetQuiz.UseVisualStyleBackColor = true;
            this.buttonGetQuiz.Click += new System.EventHandler(this.buttonGetQuiz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select a Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Difficulty (Leave blank for random)";
            // 
            // checkedListBoxDiff
            // 
            this.checkedListBoxDiff.FormattingEnabled = true;
            this.checkedListBoxDiff.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.checkedListBoxDiff.Location = new System.Drawing.Point(261, 31);
            this.checkedListBoxDiff.Name = "checkedListBoxDiff";
            this.checkedListBoxDiff.Size = new System.Drawing.Size(192, 58);
            this.checkedListBoxDiff.TabIndex = 4;
            this.checkedListBoxDiff.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxDiff_ItemCheck);
            // 
            // QuizAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkedListBoxDiff);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGetQuiz);
            this.Controls.Add(this.checkedListBoxCategories);
            this.Name = "QuizAPI";
            this.Text = "QuizAPI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckedListBox checkedListBoxCategories;
        private Button buttonGetQuiz;
        private Label label1;
        private Label label2;
        private CheckedListBox checkedListBoxDiff;
    }
}