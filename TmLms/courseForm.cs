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
    public partial class courseForm : Form
    {
        bool isCore = false;

        public courseForm()
        {
            InitializeComponent();
        }

        private void courseForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Users.Instructor.instructors.Count; i++)
            {
                comboBoxDirector.Items.Add(Users.Instructor.instructors[i].name);
            }
        }

        private void createCourse_Click(object sender, EventArgs e)
        {
            try
            {
                TM.CourseInfo newCourse = new TM.CourseInfo(GenerateCode(textBoxName.Text), textBoxName.Text, Users.Instructor.instructors[comboBoxDirector.SelectedIndex]);

                TMEngine.Instance.CourseDictionary.Add((TMEngine.Instance.CourseDictionary.Count) + 1, newCourse);

                MessageBox.Show("Course Successfully Added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            foreach (var i in TMEngine.Instance.CourseDictionary)
            {
                checkedListBoxCourses.Items.Add(i.Value.Name);
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
                code += str.Substring(0, 1);
            }

            code += randomNumber.ToString();

            return code;
        }

        private void buttonCreateModule_Click(object sender, EventArgs e)
        {
            moduleForm x = new moduleForm();
            x.Show();
        }

        private void buttonAddCore_Click(object sender, EventArgs e)
        {
            isCore = true;
            checkedListBoxModules.Items.Clear();

            foreach (var i in TMEngine.Instance.ModuleDictionary)
            {
                checkedListBoxModules.Items.Add(i.Value.Name);
            }
        }

        private void buttonAddOpt_Click(object sender, EventArgs e)
        {
            isCore = false;
            checkedListBoxModules.Items.Clear();

            foreach (var i in TMEngine.Instance.ModuleDictionary)
            {
                checkedListBoxModules.Items.Add(i.Value.Name);
            }
        }

        private void buttonPeform_Click(object sender, EventArgs e)
        {
            if (checkedListBoxModules.CheckedItems.Count > 0)
            {
                for (int i = 0; i < checkedListBoxModules.CheckedItems.Count; i++)
                {
                    if (CheckAdd(i + 1, isCore))
                    {
                        if (isCore)
                        {
                            TMEngine.Instance.CourseDictionary[Int32.Parse((string)checkedListBoxCourses.CheckedItems[0])].CoreCourseList.
                                Add(TMEngine.Instance.ModuleDictionary[i]);
                        }
                    }
                }
            }
        }

        public static bool CheckAdd(int i, bool isCore)
        {
            var x = new TM.Course();
            if (x.AddModule(TMEngine.Instance.ModuleDictionary[i], isCore))
            {
                return true; 
            }
            else
            {
                return false;
            }
        }

        
    }
}
