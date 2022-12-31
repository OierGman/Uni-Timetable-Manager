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
        int courseIndex = 0;
        bool editorMode = false;
        bool isCore = true;

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

            checkedListBoxCourses.Items.Clear();

            foreach (var i in TMEngine.Instance.CourseDictionary)
            {
                checkedListBoxCourses.Items.Add(i.Value.Name);
            }

            textBoxName.Text = "";
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
            isCore |= false;
            checkedListBoxModules.Items.Clear();

            foreach (var i in TMEngine.Instance.ModuleDictionary)
            {
                checkedListBoxModules.Items.Add(i.Value.Name);
            }
        }

        // this logic does not work

        // logic now works
        private void buttonPeform_Click(object sender, EventArgs e)
        {
            if (editorMode == false)
            {
                if (totalCredits(courseIndex) == 120)
                {
                    MessageBox.Show("Cannot add anymore core or optional modules");
                    TMEngine.Instance.CourseDictionary[courseIndex + 1].RevoveAllOptionalModules();
                }
                else if (totalCredits(courseIndex) < 120)
                {
                    for (int i = 0; i < checkedListBoxModules.Items.Count; i++)
                    {
                        if (checkedListBoxModules.GetItemCheckState(i) == CheckState.Checked)
                        {
                            if (totalCredits(courseIndex) + (int)TMEngine.Instance.ModuleDictionary[i + 1].Credits <= 120)
                            {

                                if (TMEngine.Instance.CourseDictionary[courseIndex + 1].CoreCourseList.
                                    Contains(TMEngine.Instance.ModuleDictionary[i + 1]) || TMEngine.Instance.
                                    CourseDictionary[courseIndex + 1].OptionalCourseList.Contains(TMEngine.
                                    Instance.ModuleDictionary[i + 1]))
                                {
                                    MessageBox.Show("This module already exists in this course");
                                }
                                else if (isCore)
                                {
                                    TMEngine.Instance.CourseDictionary[courseIndex + 1].CoreCourseList.
                                            Add(TMEngine.Instance.ModuleDictionary[i + 1]);
                                    MessageBox.Show("Added core module " + TMEngine.Instance.ModuleDictionary[i + 1].Name);
                                }
                                else
                                {
                                    TMEngine.Instance.CourseDictionary[courseIndex + 1].OptionalCourseList.
                                            Add(TMEngine.Instance.ModuleDictionary[i + 1]);
                                    MessageBox.Show("Added optional module " + TMEngine.Instance.ModuleDictionary[i + 1].Name);
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < checkedListBoxModules.Items.Count; i++)
                {
                    if (checkedListBoxModules.GetItemCheckState(i) == CheckState.Checked)
                    {
                        if (TMEngine.Instance.CourseDictionary[courseIndex + 1].CoreCourseList.
                                    Contains(TMEngine.Instance.ModuleDictionary[i + 1]))
                        {
                            TMEngine.Instance.CourseDictionary[courseIndex + 1].CoreCourseList.Remove(TMEngine.Instance.ModuleDictionary[i + 1]);
                        }
                    }
                }
                buttonDelete.PerformClick();
            }
            /*
            if (checkedListBoxModules.CheckedItems.Count > 0)
            {
                for (int i = 0; i < checkedListBoxModules.Items.Count; i++)
                {
                    if (checkedListBoxModules.GetItemCheckState(i) == CheckState.Checked)
                    {
                        if (CheckAdd(i + 1, isCore))
                        {
                            if (isCore)
                            {
                                TMEngine.Instance.CourseDictionary[courseIndex+1].CoreCourseList.
                                    Add(TMEngine.Instance.ModuleDictionary[i + 1]);
                                MessageBox.Show("Added as core modules");
                            }
                            else
                            {
                                TMEngine.Instance.CourseDictionary[courseIndex+1].OptionalCourseList.
                                    Add(TMEngine.Instance.ModuleDictionary[i + 1]);
                                MessageBox.Show("Added as optional modules");
                            }
                        }
                    }
                }
            }
            */
        }

        public static int totalCredits(int courseIndex)
        {
            return TMEngine.Instance.CourseDictionary[courseIndex + 1].GetCreds();
        }

        private void checkedListBoxCourses_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && checkedListBoxCourses.CheckedItems.Count > 0)
            {
                // only one check box active at any given time
                checkedListBoxCourses.ItemCheck -= checkedListBoxCourses_ItemCheck;
                checkedListBoxCourses.SetItemChecked(checkedListBoxCourses.CheckedIndices[0], false);
                checkedListBoxCourses.ItemCheck += checkedListBoxCourses_ItemCheck;
            }
            courseIndex = e.Index;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            buttonPeform.Text = "Delete Module";
            editorMode = true;
            checkedListBoxModules.Items.Clear();
            buttonCreateModule.Enabled = false;
            label4.Text = "Module: " + TMEngine.Instance.CourseDictionary[courseIndex + 1].Name;

            foreach (var i in TMEngine.Instance.CourseDictionary[courseIndex + 1].GetAllModules())
            {
                checkedListBoxModules.Items.Add(i.Name);
            }
        }

        private void buttonExitEd_Click(object sender, EventArgs e)
        { 
            buttonPeform.Text = "Add Modules";
            editorMode = false;
            checkedListBoxModules.Items.Clear();
            buttonCreateModule.Enabled = true;
            label4.Text = "Modules";
        }
    }
}
