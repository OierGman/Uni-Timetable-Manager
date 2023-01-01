﻿using System;
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
        TableLayoutPanel timetable = new TableLayoutPanel();

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

            timetableAlloc();
        }

        private void comboBoxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var i in TMEngine.Instance.CourseDictionary[comboBoxCourses.SelectedIndex + 1].OptionalCourseList)
            {
                checkedListBoxOptMod.Items.Add(i.Name);
            }

            FillTimetable(comboBoxCourses.SelectedIndex + 1);
        }

        public void timetableAlloc()
        {
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
        }
        public void FillTimetable(int courseIndex)
        {
            timetablePanel.Controls.Clear();
            timetable.Controls.Clear();
            timetableAlloc();

            Random rnd = new Random();

            Button module1 = new Button
            {
                Text = getName(0, courseIndex),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.White,
                FlatAppearance =
                        { BorderSize = 0, MouseDownBackColor = Color.Transparent, MouseOverBackColor = Color.Green }
            };
            Button module2 = new Button
            {
                Text = getName(1, courseIndex),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.White,
                FlatAppearance =
                        { BorderSize = 0, MouseDownBackColor = Color.Transparent, MouseOverBackColor = Color.Green }
            };
            Button module3 = new Button
            {
                Text = getName(2, courseIndex),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.White,
                FlatAppearance =
                        { BorderSize = 0, MouseDownBackColor = Color.Transparent, MouseOverBackColor = Color.Green }
            };
            
            timetable.Controls.Add(module1, rnd.Next(2, 5), 1);
            timetable.Controls.Add(module2, 1, 1);
            timetable.Controls.Add(module3, rnd.Next(1, 5), 3);
        }

        public string getName(int index, int courseIndex)
        {
            if (TMEngine.Instance.CourseDictionary[courseIndex].GetAllModules()[index].Quiz != null)
            {
                return TMEngine.Instance.CourseDictionary[courseIndex].GetAllModules()[index].Name + "\n\n" + "Quiz: " +
                    TMEngine.Instance.CourseDictionary[courseIndex].GetAllModules()[index].Quiz.Name;
            }
            else
            {
                return TMEngine.Instance.CourseDictionary[courseIndex].GetAllModules()[index].Name;
            }
        }
    }
}
