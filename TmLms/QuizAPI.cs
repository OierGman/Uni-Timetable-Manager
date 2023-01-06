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
    public partial class QuizAPI : Form
    {
        public QuizAPI()
        {
            
            InitializeComponent();

            foreach ( var i in Categories.categories)
            {
                checkedListBoxCategories.Items.Add(i.name);
            }
        }
    }
}
