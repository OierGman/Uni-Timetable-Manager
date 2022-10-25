namespace TmLms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            form.ShowDialog();

            TableLayoutPanel Container1 = new TableLayoutPanel()
            {
                RowCount = 5,
                Dock = DockStyle.Fill
            };
            this.Controls.Add(Container1);

            Container1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            Container1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            Container1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            Container1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            Container1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            Container1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
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
            this.Controls.Add(Container1);

            Container1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            Container1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            Container1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            Container1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            Container1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            Container1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        }

        #endregion
    }
}