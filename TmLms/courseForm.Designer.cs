namespace TmLms
{
    partial class courseForm
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
            this.createCourse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDirector = new System.Windows.Forms.ComboBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonCreateModule = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonPeform = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAddOpt = new System.Windows.Forms.Button();
            this.buttonAddCore = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.checkedListBoxCourses = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxModules = new System.Windows.Forms.CheckedListBox();
            this.buttonExitEd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.createCourse);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxDirector);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Course";
            // 
            // createCourse
            // 
            this.createCourse.Location = new System.Drawing.Point(489, 43);
            this.createCourse.Name = "createCourse";
            this.createCourse.Size = new System.Drawing.Size(130, 23);
            this.createCourse.TabIndex = 8;
            this.createCourse.Text = "Create Course";
            this.createCourse.UseVisualStyleBackColor = true;
            this.createCourse.Click += new System.EventHandler(this.createCourse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Course Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Course Director";
            // 
            // comboBoxDirector
            // 
            this.comboBoxDirector.FormattingEnabled = true;
            this.comboBoxDirector.Location = new System.Drawing.Point(271, 44);
            this.comboBoxDirector.Name = "comboBoxDirector";
            this.comboBoxDirector.Size = new System.Drawing.Size(172, 23);
            this.comboBoxDirector.TabIndex = 1;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(15, 44);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(223, 23);
            this.textBoxName.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonExitEd);
            this.groupBox2.Controls.Add(this.buttonCreateModule);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.buttonPeform);
            this.groupBox2.Controls.Add(this.buttonDelete);
            this.groupBox2.Controls.Add(this.buttonAddOpt);
            this.groupBox2.Controls.Add(this.buttonAddCore);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.checkedListBoxCourses);
            this.groupBox2.Controls.Add(this.checkedListBoxModules);
            this.groupBox2.Location = new System.Drawing.Point(12, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 336);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Populate Courses";
            // 
            // buttonCreateModule
            // 
            this.buttonCreateModule.Location = new System.Drawing.Point(549, 37);
            this.buttonCreateModule.Name = "buttonCreateModule";
            this.buttonCreateModule.Size = new System.Drawing.Size(221, 21);
            this.buttonCreateModule.TabIndex = 10;
            this.buttonCreateModule.Text = "Create More Modules";
            this.buttonCreateModule.UseVisualStyleBackColor = true;
            this.buttonCreateModule.Click += new System.EventHandler(this.buttonCreateModule_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(549, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Modules";
            // 
            // buttonPeform
            // 
            this.buttonPeform.Location = new System.Drawing.Point(549, 297);
            this.buttonPeform.Name = "buttonPeform";
            this.buttonPeform.Size = new System.Drawing.Size(221, 33);
            this.buttonPeform.TabIndex = 8;
            this.buttonPeform.Text = "Accept";
            this.buttonPeform.UseVisualStyleBackColor = true;
            this.buttonPeform.Click += new System.EventHandler(this.buttonPeform_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(233, 261);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(158, 33);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Editor Mode";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAddOpt
            // 
            this.buttonAddOpt.Location = new System.Drawing.Point(233, 77);
            this.buttonAddOpt.Name = "buttonAddOpt";
            this.buttonAddOpt.Size = new System.Drawing.Size(158, 33);
            this.buttonAddOpt.TabIndex = 6;
            this.buttonAddOpt.Text = "Add Optional Modules";
            this.buttonAddOpt.UseVisualStyleBackColor = true;
            this.buttonAddOpt.Click += new System.EventHandler(this.buttonAddOpt_Click);
            // 
            // buttonAddCore
            // 
            this.buttonAddCore.Location = new System.Drawing.Point(233, 38);
            this.buttonAddCore.Name = "buttonAddCore";
            this.buttonAddCore.Size = new System.Drawing.Size(158, 33);
            this.buttonAddCore.TabIndex = 5;
            this.buttonAddCore.Text = "Add Core Modules";
            this.buttonAddCore.UseVisualStyleBackColor = true;
            this.buttonAddCore.Click += new System.EventHandler(this.buttonAddCore_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select a Course";
            // 
            // checkedListBoxCourses
            // 
            this.checkedListBoxCourses.FormattingEnabled = true;
            this.checkedListBoxCourses.Location = new System.Drawing.Point(6, 38);
            this.checkedListBoxCourses.Name = "checkedListBoxCourses";
            this.checkedListBoxCourses.Size = new System.Drawing.Size(221, 292);
            this.checkedListBoxCourses.TabIndex = 1;
            this.checkedListBoxCourses.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxCourses_ItemCheck);
            // 
            // checkedListBoxModules
            // 
            this.checkedListBoxModules.FormattingEnabled = true;
            this.checkedListBoxModules.Location = new System.Drawing.Point(549, 64);
            this.checkedListBoxModules.Name = "checkedListBoxModules";
            this.checkedListBoxModules.Size = new System.Drawing.Size(221, 220);
            this.checkedListBoxModules.TabIndex = 0;
            // 
            // buttonExitEd
            // 
            this.buttonExitEd.Location = new System.Drawing.Point(233, 297);
            this.buttonExitEd.Name = "buttonExitEd";
            this.buttonExitEd.Size = new System.Drawing.Size(158, 33);
            this.buttonExitEd.TabIndex = 11;
            this.buttonExitEd.Text = "Exit Editor Mode";
            this.buttonExitEd.UseVisualStyleBackColor = true;
            this.buttonExitEd.Click += new System.EventHandler(this.buttonExitEd_Click);
            // 
            // courseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "courseForm";
            this.Text = "courseForm";
            this.Load += new System.EventHandler(this.courseForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxName;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxDirector;
        private GroupBox groupBox2;
        private Label label3;
        private CheckedListBox checkedListBoxCourses;
        private CheckedListBox checkedListBoxModules;
        private Button buttonAddCore;
        private Button createCourse;
        private Button buttonPeform;
        private Button buttonDelete;
        private Button buttonAddOpt;
        private Label label4;
        private Button buttonCreateModule;
        private Button buttonExitEd;
    }
}