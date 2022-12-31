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
    public partial class Timetable : Form
    {
        public Timetable()
        {
            InitializeComponent();
        }

        private void Timetable_Load(object sender, EventArgs e)
        {
            // comboBoxCourses.SelectedIndex = 0;
            
            for (int i = 0; i < TMEngine.Instance.CourseDictionary.Count; i++)
            {
                comboBoxCourses.Items.Add(TMEngine.Instance.CourseDictionary[i + 1].Name);
            }
        }
    }
}
