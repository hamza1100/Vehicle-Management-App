using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Search : Form
    {
        private DataRetrieval data_ret;
        public Search()
        {
            InitializeComponent();
            data_ret = new DataRetrieval();
        }


    /*    private void ShowMakeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Display_Box form5 = new Display_Box();
            form5.ShowByMake(ShowMakeList.Text);
            form5.ShowDialog();
            
        }*/


        private void ShowModelList_Click(object sender, EventArgs e)
        {
            var values = data_ret.Get_Number_Plate();
            ShowModelList.DataSource = values;
        }

     /*   private void ShowModelList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Display_Box form5 = new Display_Box();
            form5.ShowByModel(ShowModelList.Text);
            form5.ShowDialog();
        }*/

     /*   private void ShowYearList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Display_Box form5 = new Display_Box();
            form5.ShowByYear(ShowYearList.Text);
            form5.ShowDialog();
        }*/

   /*     private void ShowRatingList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Display_Box form5 = new Display_Box();
            form5.ShowByRating(ShowRatingList.Text);
            form5.ShowDialog();
        }*/

     /*   private void ShowRatingList_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Display_Box form5 = new Display_Box();
                form5.ShowByRating(ShowRatingList.Text);
                form5.ShowDialog();
            }
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            Display_Box form5 = new Display_Box();
            form5.ShowByMake(ShowMakeList.Text);
            form5.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Display_Box form5 = new Display_Box();
            form5.ShowByYear(ShowYearList.Text);
            form5.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Display_Box form5 = new Display_Box();
            form5.ShowByModel(ShowModelList.Text);
            form5.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Display_Box form5 = new Display_Box();
            form5.ShowByRating(ShowRatingList.Text);
            form5.ShowDialog();
        }

     }

}

    

