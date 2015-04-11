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
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void timerSplashForm_Tick(object sender, EventArgs e)
        {
            //Create a new SelectionForm
            SelectionForm SelectionForm = new SelectionForm();

            //hide the SplashForm
            this.Hide();

            //show the selectionForm
            SelectionForm.Show();

            //stop the timer
            timerSplashForm.Enabled = false;

        }
    }
}
