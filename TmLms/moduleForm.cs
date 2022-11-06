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
    public partial class moduleForm : Form
    {
        public moduleForm()
        {
            InitializeComponent();
        }

        private void moduleForm_Load(object sender, EventArgs e)
        {
            comboBoxCredits.SelectedIndex = 0;
            comboBoxLevel.SelectedIndex = 0;

            for (int i = 0; i < Users.Administrator.administrators.Count; i++)
            {
                comboBoxAdmin.Items.Add(Users.Administrator.administrators[i].name);
            }
        }

        private void AddModuleButton_Click(object sender, EventArgs e)
        {
            int level = Int32.Parse(comboBoxLevel.SelectedItem.ToString());
            int credits = Int32.Parse(comboBoxCredits.SelectedItem.ToString());

            try
            {
                TM.Module newModule = new TM.Module(GenerateCode(textBoxName.Text), Users.Administrator.administrators[comboBoxAdmin.SelectedIndex]);
                newModule.Name = textBoxName.Text;
                newModule.Description = textBoxDesc.Text;
                newModule.Credits = (TM.Module.CreditEnum)credits;
                newModule.Level = (TM.Module.LevelEnum)level;

                TMEngine.Instance.ModuleDictionary.Add((TMEngine.Instance.ModuleDictionary.Count) + 1 , newModule);

                MessageBox.Show("Module Successfully Added");
                SetToZero();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Must Select Admin Person");
            }
        }

        
        public string GenerateCode(string s)
        {
            // generate random module code usinf first letter of everyword and appending a large random int
            string code = null;
            int randomNumber = new Random().Next(100000, 999999);

            string[] strings = s.Split(' ');

            foreach (string str in strings)
            {
                code += str.Substring(0,1);
            }

            code += randomNumber.ToString();

            return code;
        }

        public void SetToZero()
        {
            textBoxName.Text = "";
            textBoxDesc.Text = "";
            comboBoxAdmin.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
