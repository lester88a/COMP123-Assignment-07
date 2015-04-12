using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Course Name: COMP123-Assignment07
 * Application Name: Movies Online Stream
 * Authoer: LI XU 300735072
 * App Creation Date: April 7, 2015
 * Date: April 11, 2015
 * 
 */
namespace COMP123_Assignment07
{
    public partial class StreamForm : Form
    {
        //private properties+++++++++++++++++++++++++++++++++++++++++++++++++++
        private OrderForm _selectMovie;

        //constructor++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public StreamForm(OrderForm selectMovie)
        {
            InitializeComponent();


            this._selectMovie = selectMovie;

            //asign the properties of selectd movie to the stream form
            CreditChargedLabel.Text = "Your Credit card will be charged [ " + Convert.ToString(selectMovie.GrandTotal)+" ].";
            BeginStreamingLabel.Text = "[ " + Convert.ToString(selectMovie.MovieName) + " ] will begin streaming shortly.";
            
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
