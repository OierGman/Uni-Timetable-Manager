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

        private void checkedListBoxCategories_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && checkedListBoxCategories.CheckedItems.Count > 0)
            {
                // only one check box active at any given time
                checkedListBoxCategories.ItemCheck -= checkedListBoxCategories_ItemCheck;
                checkedListBoxCategories.SetItemChecked(checkedListBoxCategories.CheckedIndices[0], false);
                checkedListBoxCategories.ItemCheck += checkedListBoxCategories_ItemCheck;
            }
        }

        private void checkedListBoxDiff_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && checkedListBoxDiff.CheckedItems.Count > 0)
            {
                // only one check box active at any given time
                checkedListBoxDiff.ItemCheck -= checkedListBoxDiff_ItemCheck;
                checkedListBoxDiff.SetItemChecked(checkedListBoxDiff.CheckedIndices[0], false);
                checkedListBoxDiff.ItemCheck += checkedListBoxDiff_ItemCheck;
            }
        }

        private void buttonGetQuiz_Click(object sender, EventArgs e)
        {
            string seed = "amount=10";
            if(checkedListBoxDiff.SelectedIndex >= 0 && checkedListBoxCategories.SelectedIndex < 0)
            {
                seed += "&difficulty=" + checkedListBoxDiff.Text.ToLower();
            }
            else if (checkedListBoxDiff.SelectedIndex < 0 && checkedListBoxCategories.SelectedIndex >= 0)
            {
                seed += "&category=" + Categories.categories[checkedListBoxCategories.SelectedIndex].id.ToString();
            }
            else
            {
                seed += "&category=" + Categories.categories[checkedListBoxCategories.SelectedIndex].id.ToString();
                seed += "&difficulty=" + checkedListBoxDiff.Text.ToLower();
            }
           TMEngine.GetQuiz(seed);

            this.Close();
        }
    }
}
