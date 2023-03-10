namespace TmLms
{
    partial class moduleForm
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
            this.buttonEdit = new System.Windows.Forms.Button();
            this.listBoxModules = new System.Windows.Forms.ListBox();
            this.buttonAddQuiz = new System.Windows.Forms.Button();
            this.AddModuleButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxLevel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxCredits = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxAdmin = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonEdit);
            this.groupBox1.Controls.Add(this.listBoxModules);
            this.groupBox1.Controls.Add(this.buttonAddQuiz);
            this.groupBox1.Controls.Add(this.AddModuleButton);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBoxLevel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBoxCredits);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxAdmin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxDesc);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 361);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create a Module";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(507, 262);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(114, 23);
            this.buttonEdit.TabIndex = 16;
            this.buttonEdit.Text = "Edit Module";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // listBoxModules
            // 
            this.listBoxModules.FormattingEnabled = true;
            this.listBoxModules.ItemHeight = 15;
            this.listBoxModules.Location = new System.Drawing.Point(6, 190);
            this.listBoxModules.Name = "listBoxModules";
            this.listBoxModules.Size = new System.Drawing.Size(495, 124);
            this.listBoxModules.TabIndex = 15;
            // 
            // buttonAddQuiz
            // 
            this.buttonAddQuiz.Location = new System.Drawing.Point(507, 291);
            this.buttonAddQuiz.Name = "buttonAddQuiz";
            this.buttonAddQuiz.Size = new System.Drawing.Size(114, 23);
            this.buttonAddQuiz.TabIndex = 14;
            this.buttonAddQuiz.Text = "Create Quiz";
            this.buttonAddQuiz.UseVisualStyleBackColor = true;
            this.buttonAddQuiz.Click += new System.EventHandler(this.buttonAddQuiz_Click);
            // 
            // AddModuleButton
            // 
            this.AddModuleButton.Location = new System.Drawing.Point(12, 113);
            this.AddModuleButton.Name = "AddModuleButton";
            this.AddModuleButton.Size = new System.Drawing.Size(600, 29);
            this.AddModuleButton.TabIndex = 8;
            this.AddModuleButton.Text = "Add Module";
            this.AddModuleButton.UseVisualStyleBackColor = true;
            this.AddModuleButton.Click += new System.EventHandler(this.AddModuleButton_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(3, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(618, 38);
            this.button1.TabIndex = 13;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Level";
            // 
            // comboBoxLevel
            // 
            this.comboBoxLevel.AutoCompleteCustomSource.AddRange(new string[] {
            "20"});
            this.comboBoxLevel.FormattingEnabled = true;
            this.comboBoxLevel.Items.AddRange(new object[] {
            "4",
            "5",
            "6"});
            this.comboBoxLevel.Location = new System.Drawing.Point(318, 84);
            this.comboBoxLevel.Name = "comboBoxLevel";
            this.comboBoxLevel.Size = new System.Drawing.Size(98, 23);
            this.comboBoxLevel.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Credits";
            // 
            // comboBoxCredits
            // 
            this.comboBoxCredits.AutoCompleteCustomSource.AddRange(new string[] {
            "20"});
            this.comboBoxCredits.FormattingEnabled = true;
            this.comboBoxCredits.Items.AddRange(new object[] {
            "20",
            "40",
            "60"});
            this.comboBoxCredits.Location = new System.Drawing.Point(432, 84);
            this.comboBoxCredits.Name = "comboBoxCredits";
            this.comboBoxCredits.Size = new System.Drawing.Size(98, 23);
            this.comboBoxCredits.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select Admin";
            // 
            // comboBoxAdmin
            // 
            this.comboBoxAdmin.FormattingEnabled = true;
            this.comboBoxAdmin.Location = new System.Drawing.Point(12, 84);
            this.comboBoxAdmin.Name = "comboBoxAdmin";
            this.comboBoxAdmin.Size = new System.Drawing.Size(164, 23);
            this.comboBoxAdmin.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Module Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Module Name";
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(254, 38);
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(358, 23);
            this.textBoxDesc.TabIndex = 2;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 38);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(164, 23);
            this.textBoxName.TabIndex = 1;
            // 
            // moduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 361);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(640, 400);
            this.MinimumSize = new System.Drawing.Size(640, 400);
            this.Name = "moduleForm";
            this.Text = "moduleForm";
            this.Load += new System.EventHandler(this.moduleForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox textBoxDesc;
        private TextBox textBoxName;
        private Label label3;
        private ComboBox comboBoxAdmin;
        private Button AddModuleButton;
        private Label label4;
        private ComboBox comboBoxCredits;
        private Label label5;
        private ComboBox comboBoxLevel;
        private Button button1;
        private ListBox listBoxModules;
        private Button buttonAddQuiz;
        private Button buttonEdit;
    }
}