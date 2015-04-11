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
    public partial class SelectionForm : Form
    {
        //private instance variabes+++++++++++++++++++++++++++++++++++++++++++++++++
        private int _movieIndex;

        //public properties+++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public List<MovieClass> movies = new List<MovieClass>();
        
        //Constructor+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public SelectionForm()
        {
            InitializeComponent();

            InitializeMovieList();

            InitializeMovieComboBox();
        }

        //Private methods+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private  void InitializeMovieList()
        {
            movies.Add(new MovieClass("Season of the Witch", "Sci-­‐Fi", 2.99,Properties.Resources.Season_of_the_Witch));
            movies.Add(new MovieClass("The Green Hornet", "Action", 2.99,Properties.Resources.TheGreenHornet));
            movies.Add(new MovieClass("The Dilemma", "Comedy", 1.99,Properties.Resources.TheDilemma));
            movies.Add(new MovieClass("Death Race 2", "Action", 2.99, Properties.Resources.DeathRace2));
            movies.Add(new MovieClass("Company Men", "Drama", 1.99, Properties.Resources.CompanyMen));
            movies.Add(new MovieClass("No Strings Attached", "Comedy", 1.99, Properties.Resources.NoStringsAttached));
            movies.Add(new MovieClass("The Way Back", "Drama", 1.99, Properties.Resources.thewayback));
            movies.Add(new MovieClass("The Mechanic", "Action", 2.99, Properties.Resources.TheMechanic));
            movies.Add(new MovieClass("The Rite", "Horror", 2.99, Properties.Resources.TheRite));
            movies.Add(new MovieClass("Sanctum", "Action", 2.99, Properties.Resources.Sanctum));
            movies.Add(new MovieClass("The Other Woman", "Action", 2.99, Properties.Resources.TheOtherWoman));
            movies.Add(new MovieClass("The Roommate", "Thriller", 2.99, Properties.Resources.TheRoommate));
            movies.Add(new MovieClass("Waiting for Forever", "Drama", 1.99, Properties.Resources.WaitingforForever));
            movies.Add(new MovieClass("Cedar Rapids", "Comedy", 1.99, Properties.Resources.CedarRapids));
            movies.Add(new MovieClass("Gnomeo and Juliet", "Family", 0.99, Properties.Resources.GnomeoAndJuliet));
            movies.Add(new MovieClass("Just Go With It", "Comedy", 1.99, Properties.Resources.Just_Go_with_It));
            movies.Add(new MovieClass("The Eagle", "Action", 2.99, Properties.Resources.TheEagle));
            movies.Add(new MovieClass("I am Number Four", "Sci-­‐Fi", 2.99, Properties.Resources.IamNumberFour));
            movies.Add(new MovieClass("Footloose", "New Release", 4.99, Properties.Resources.Footloose));
            movies.Add(new MovieClass("Real Stee", "New Release", 4.99, Properties.Resources.RealSteel));
        }

        private void InitializeMovieComboBox()
        {
            //add items of InitializeMovieList() to MovieComboBox
            foreach (var movie in movies)
            {
                MovieComboBox.Items.Add(movie.MovieName);
            }
        }

        private void MovieComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._movieIndex = MovieComboBox.SelectedIndex;

            //sort the name of moives
            movies.Sort();

            //asigns the value to each properties
            MovieComboBox.Text = movies[this._movieIndex].MovieName;
            MoviePictureBoxSelectionForm.Image = movies[this._movieIndex].Picture;
            TitleTextBox.Text = movies[this._movieIndex].MovieName;
            CategoryTextBox.Text = movies[this._movieIndex].Category;
            CostTextBox.Text = "$" + Convert.ToString(movies[this._movieIndex].Cost);
        }

        private void SelectionForm_Load(object sender, EventArgs e)
        {
            //when the form load, the ndex will be seted as 0
            MovieComboBox.SelectedIndex = 0;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            OrderForm newOrderForm = new OrderForm();
            this.Hide();
            newOrderForm.Owner = this;
            newOrderForm.Show();
        }

    }
}
