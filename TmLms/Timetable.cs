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
            for (int i = 0; i < TMEngine.Instance.CourseDictionary.Count; i++)
            {
                comboBoxCourses.Items.Add(TMEngine.Instance.CourseDictionary[i + 1].Name);
            }

            #region TimeTable
            TableLayoutPanel timetable = new TableLayoutPanel();
            timetable.ColumnCount = 6;
            timetable.RowCount = 4;
            timetable.Dock = DockStyle.Fill;

            timetable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            timetable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            timetable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            timetable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            timetable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            timetable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));

            timetable.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            timetable.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            timetable.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            timetable.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));

            timetable.Controls.Add(
                new Label() { Text = "Monday", TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 1, 0);
            timetable.Controls.Add(
                new Label() { Text = "Tuesday", TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 2, 0);
            timetable.Controls.Add(
                new Label() { Text = "Wednesday", TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 3, 0);
            timetable.Controls.Add(
                new Label() { Text = "Thursday", TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 4, 0);
            timetable.Controls.Add(
                new Label() { Text = "Friday", TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 5, 0);

            timetable.Controls.Add(
                new Label() { Text = "AM", TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 0, 1);
            timetable.Controls.Add(
                new Label() { Text = "Lunch", TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 0, 2);
            timetable.Controls.Add(
                new Label() { Text = "PM", TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 0, 3);

            

            timetablePanel.Controls.Add(timetable);
            #endregion
        }

        private void comboBoxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var i in TMEngine.Instance.CourseDictionary[comboBoxCourses.SelectedIndex + 1].OptionalCourseList)
            {
                checkedListBoxOptMod.Items.Add(i.Name);
            }
        }
    }
}
