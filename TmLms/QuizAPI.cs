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
    public partial class QuizAPI : Form
    {
        public QuizAPI()
        {
            
            InitializeComponent();
            Thread.Sleep(3000);
            foreach ( var i in Categories.categories)
            {
                checkedListBoxCategories.Items.Add(i.name);
            }
        }
    }
}
