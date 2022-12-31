namespace TmLms
{
    partial class Timetable
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
            this.comboBoxCourses = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBoxOptMod = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timetablePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // comboBoxCourses
            // 
            this.comboBoxCourses.FormattingEnabled = true;
            this.comboBoxCourses.Location = new System.Drawing.Point(12, 24);
            this.comboBoxCourses.Name = "comboBoxCourses";
            this.comboBoxCourses.Size = new System.Drawing.Size(121, 23);
            this.comboBoxCourses.TabIndex = 0;
            this.comboBoxCourses.SelectedIndexChanged += new System.EventHandler(this.comboBoxCourses_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Course:";
            // 
            // checkedListBoxOptMod
            // 
            this.checkedListBoxOptMod.FormattingEnabled = true;
            this.checkedListBoxOptMod.Location = new System.Drawing.Point(164, 24);
            this.checkedListBoxOptMod.Name = "checkedListBoxOptMod";
            this.checkedListBoxOptMod.Size = new System.Drawing.Size(291, 94);
            this.checkedListBoxOptMod.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Optional Modules:";
            // 
            // timetablePanel
            // 
            this.timetablePanel.Location = new System.Drawing.Point(12, 124);
            this.timetablePanel.Name = "timetablePanel";
            this.timetablePanel.Size = new System.Drawing.Size(776, 314);
            this.timetablePanel.TabIndex = 5;
            // 
            // Timetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.timetablePanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkedListBoxOptMod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCourses);
            this.Name = "Timetable";
            this.Text = "Timetable";
            this.Load += new System.EventHandler(this.Timetable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBoxCourses;
        private Label label1;
        private CheckedListBox checkedListBoxOptMod;
        private Label label2;
        private Panel timetablePanel;
    }
}