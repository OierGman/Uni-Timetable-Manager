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
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // create course
            AddCourse();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // create module
            AddModule();
        }

        #region dynamic UI
        public void AddModule()
        {
            Form form = new Form();

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
            Container2.Controls.Add(
                new TextBox() { Dock = DockStyle.Fill }, 0, 1);

            Container2.Controls.Add(
                new Label() { Text = "Module Description:", Font = new Font("Arial", 18), TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 1, 0);
            Container2.Controls.Add(
                new TextBox() { Dock = DockStyle.Fill }, 1, 1);

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

        
    }
}