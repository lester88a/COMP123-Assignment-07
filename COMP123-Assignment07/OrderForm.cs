using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_Assignment07
{
    public partial class OrderForm : Form
    {
        //private properties+++++++++++++++++++++++++++++++++++++++++++++++++++
        private MovieClass _selectMovie;
        

        //constructor++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public OrderForm(MovieClass selectMovie)
        {
            InitializeComponent();

            //asign the properties of selectd movie to the order form
            this._selectMovie = selectMovie;
            TitleTextBox.Text = selectMovie.MovieName;
            CategoryTextBox.Text = selectMovie.Category;
            PictureBoxOrderForm.Image = selectMovie.Picture;
            CostTextBox.Text = "$"+Convert.ToString(selectMovie.Cost);
            SubTotalTextBox.Text = "$" + Convert.ToString(selectMovie.Cost);
            SaleTaxTextBox.Text = "$" + Convert.ToString(selectMovie.Cost * 0.13);
            GrandTotalTextBox.Text = "$" + Convert.ToString(selectMovie.Cost * 1.13);
            
        }

        //Back Button function+++++++++++++++++++++++++++++++++++++++++++++++++
        private void BackButton_Click(object sender, EventArgs e)
        {
            SelectionForm newSelectionForm = new SelectionForm();
            //hide the current form
            this.Hide();

            //show the selectionForm
            newSelectionForm.Owner = this;
            newSelectionForm.Show();
        }

        //cancel button+++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //CheckBox++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //the checkBOx is checked, then the AdditionalChargeTextBox become visible
                if (CheckBox.Checked == true)
                {
                    AdditionalChargeLabel.Visible = true;
                    AdditionalChargeTextBox.Visible = true;
                    //add addtional charge to the subtotal and grand total
                    SubTotalTextBox.Text = "$" + Convert.ToString(this._selectMovie.Cost + 10);
                    GrandTotalTextBox.Text = "$" + Convert.ToString(this._selectMovie.Cost * 1.13+10);
                }
                else if (CheckBox.Checked == false)
                {
                    AdditionalChargeLabel.Visible = false;
                    AdditionalChargeTextBox.Visible = false;

                    //calculate sub and grand total without addtional charge
                    SubTotalTextBox.Text = "$" + Convert.ToString(this._selectMovie.Cost);
                    GrandTotalTextBox.Text = "$" + Convert.ToString(this._selectMovie.Cost * 1.13);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(Convert.ToString( error));
            }
            
        }
        
        private void StreamButton_Click(object sender, EventArgs e)
        {
            StreamForm newStreamForm = new StreamForm(this);

            //hide the current form
            this.Hide();
            //show the streamForm
            newStreamForm.Owner = this;
            newStreamForm.Show();
        }

        //public propertiess++++++++++++++++++++++++++++++++++++++++++++++++++
        public string GrandTotal { get { return GrandTotalTextBox.Text; } }
        public string MovieName { get { return TitleTextBox.Text; } }
    }
}
