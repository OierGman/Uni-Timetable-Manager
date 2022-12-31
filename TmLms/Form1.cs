namespace TmLms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            // module test
            updateButton();
            TM.Module testModule = new TM.Module("SE1", "");
            testModule.Name = "Software Engineering";
            testModule.Description = "";
            testModule.Credits = (TM.Module.CreditEnum)20;
            testModule.Level = (TM.Module.LevelEnum)4;

            TMEngine.Instance.ModuleDictionary.Add(1, testModule);

            // admin test
            Users.Administrator.administrators.Add(new Users.Administrator("Admin1", "001"));
            Users.Administrator.administrators.Add(new Users.Administrator("Admin2", "002"));
            Users.Administrator.administrators.Add(new Users.Administrator("Admin3", "003"));
            Users.Administrator.administrators.Add(new Users.Administrator("Admin4", "004"));
            Users.Administrator.administrators.Add(new Users.Administrator("Admin5", "005"));

            //instructor test
            Users.Instructor.instructors.Add(new Users.Instructor("Tim", "001"));
            Users.Instructor.instructors.Add(new Users.Instructor("Joe", "002"));
            Users.Instructor.instructors.Add(new Users.Instructor("Alex", "003"));
            Users.Instructor.instructors.Add(new Users.Instructor("Bill", "004"));

            // quiz test
            var wrong_ans = new List<string>()
            {
                "not the answer", "anothernot the answer", "still not the answer"
            };
            var correct_ans = new List<string>()
            {
                "the answer"
            };
            Questions.questions.Add(new Questions("multiple choice", "is this a question?", correct_ans, wrong_ans, 5));
            // Quiz.questions.Add(new Quiz(TMEngine.Instance.ModuleDictionary[0].Code, 
            //    "multiple choice", "is this a question?", correct_ans, wrong_ans));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // create course
            courseForm x = new courseForm();
            x.Show();
            //button1.Text = TMEngine.Instance.ModuleDictionary[1].Name;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // create module
            moduleForm x = new moduleForm();
            x.Show();
        }
        private void comboBoxUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateButton();
        }

        private void updateButton()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;

            switch (comboBoxUserType.SelectedIndex)
            {
                case 0:
                    button1.Enabled = true;
                    goto case 1;
                case 1:
                    button2.Enabled = true;
                    goto case 2;
                case 2:
                    button3.Enabled = true;
                    break;
                default:
                    break;
            }     
        }
        // not in use
        #region dynamic UI
        public void AddModule()
        {
            Form form = new Form();
            TextBox modName = new TextBox()
            {
                Dock = DockStyle.Fill,
            };
            TextBox modDesc = new TextBox()
            {
                Dock = DockStyle.Fill,
            };

            TableLayoutPanel Container1 = new TableLayoutPanel()
            {
                RowCount = 5,
                Dock = DockStyle.Fill
            };
            form.Controls.Add(Container1);

            Container1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            Container1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            Container1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            Container1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            Container1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            Container1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));

            Container1.Controls.Add(
                new Label() { Text = "Create a New Module", Font = new Font("Arial", 18), TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 0, 0);

            TableLayoutPanel Container2 = new TableLayoutPanel()
            {
                RowCount = 2,
                ColumnCount = 2,
                Dock = DockStyle.Fill
            };
            Container1.Controls.Add(Container2, 0, 1);

            Container2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Container2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Container2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Container2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));

            Container2.Controls.Add(
                new Label() { Text = "Module Name:", Font = new Font("Arial", 18), TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 0, 0);
            Container2.Controls.Add(modName, 0, 1);

            Container2.Controls.Add(
                new Label() { Text = "Module Description:", Font = new Font("Arial", 18), TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 1, 0);
            Container2.Controls.Add(modDesc, 1, 1);

            form.ShowDialog();
        }

        public void AddCourse()
        {
            Form form1 = new Form();
            form1.ShowDialog();

            TableLayoutPanel Container1 = new TableLayoutPanel()
            {
                RowCount = 5,
                Dock = DockStyle.Fill
            };
            form1.Controls.Add(Container1);

            Container1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            Container1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            Container1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            Container1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            Container1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            Container1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));

            Container1.Controls.Add(
                new Label() { Text = "Create a New Course", Font = new Font("Arial", 18), TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 0, 0);
        }



        #endregion

        private void button3_Click(object sender, EventArgs e)
        {
            // show timetable
            Timetable x = new Timetable();
            x.Show();
        }
    }
}