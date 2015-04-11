using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_Lesson13_Part1
{
    public partial class MovieForm : Form
    {
        //private instance variable
        private int _movieIndex;

        //movies array
        //public MovieClass[] movies = new MovieClass[20];

        public List<MovieClass> movies = new List<MovieClass>();

        public MovieForm()
        {
            InitializeComponent();
            InitializeMovieList();

            InitializeMovieComboBox();
        }

        private void InitializeMovieList()
        {
            //movies[0] = new MovieClass("Season", "Sci-Fi", 2.99);
            movies.Add(new MovieClass("Season", "Sci-Fi", 2.99));
            movies.Add(new MovieClass("Dilemma", "Action", 2.99));
            movies.Add(new MovieClass("Green", "Sci-Fi", 1.99));
            movies.Add(new MovieClass("Race2", "Sci-Fi2", 1.99));
            movies.Add(new MovieClass("Race3", "Sci-Fi3", 1.99));
            movies.Add(new MovieClass("Race4", "Sci-Fi4", 1.99));
            movies.Add(new MovieClass("Race5", "Sci-Fi5", 1.99));
            movies.Add(new MovieClass("Race6", "Sci-Fi6", 1.99));
            
        }

        private void InitializeMovieComboBox()
        {
            foreach (var movie in movies)
            {
                //add items of InitializeMovieList() to MovieComboBox
                MovieComboBox.Items.Add(movie.Title);
            
            }
            
        }
        private void MovieComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //showing the inedx
            //MovieTitleTextBox.Text = MovieComboBox.SelectedIndex.ToString();
            this._movieIndex = MovieComboBox.SelectedIndex;

            movies.Sort();

            //movies.Sort(movies[movieIndex].Title); //sort
            MovieTitleTextBox.Text = movies[this._movieIndex].Title;
            CategoryTextBox.Text = movies[this._movieIndex].Category;
            CostTextBox.Text = movies[this._movieIndex].Cost.ToString();
            //TextBox2.Text = movies.Select.ToString();
            //showing the item
            //TextBox2.Text = MovieComboBox.SelectedItem.ToString();
            
        }

        //form load
        private void MovieForm_Load(object sender, EventArgs e)
        {
            //when the form load, the 0 index will be showing on combobox
            MovieComboBox.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EndForm newEndForm = new EndForm(movies[this._movieIndex]);
            this.Hide();
            newEndForm.Owner = this;
            newEndForm.Show();
        }

       

    }
}
