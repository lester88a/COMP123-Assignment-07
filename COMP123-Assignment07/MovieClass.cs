using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    public class MovieClass : IComparable<MovieClass>
    {
        //private instance variabnles+++++++++++++++++++++++++++++++++++++++++++++++
        private string _movieName;
        private string _category;
        private double _cost;
        private Bitmap _picture;

        //public properties+++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public string MovieName { get { return this._movieName; } } // read only
        public string Category { get { return this._category; } } // read only
        public double Cost { get { return this._cost; } } // read only
        public Bitmap Picture{get {return this._picture;}}// read only

        //Constructor+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public MovieClass(string movieName, string category, double cost, Bitmap picture)
        {
            //assign values to instance variables
            this._movieName = movieName;
            this._category = category;
            this._cost = cost;
            this._picture = picture;
        }

        // public method++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        //default comparer for movie type -- compares the movie name property
        public int CompareTo(MovieClass compareMovie)
        {
            //a null value mens that this object is greater
            if (compareMovie == null)
            {
                return 1;
            }
            else
            {
                return this._movieName.CompareTo(compareMovie._movieName);
            }

        }
    }
}
