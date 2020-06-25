//
// Netflix Database Application using N-Tier Design.
//
// Conrad Ptasznik
// U. of Illinois, Chicago
// CS341, Spring 2018
// Project 08
//


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BusinessTier;

namespace NetflixApp
{
    public partial class Form1 : Form
    {
        int moviecount = 0; 
        public Form1()
        {
            InitializeComponent();
            for (int i = 1; i < 6; i++) comboBox1.Items.Add(i);
            comboBox1.SelectedIndex = 0;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.lstMovies.Items.Clear();
            string dbfilename = this.txtDatabase.Text;
            BusinessTier.Business biztier = new BusinessTier.Business(dbfilename);

            foreach (BusinessTier.Movie movies in biztier.GetAllMovies())
            {
                this.lstMovies.Items.Add(string.Format ("{0}", movies.MovieName));
               
            }


            foreach (BusinessTier.Movie movies in biztier.GetAllMovies())
            {
                this.lstMovies.Items.Add(string.Format("{0}", movies.MovieName));

            }





        }

        private void lstMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtMovieID.Items.Clear();
            this.movieRating.Items.Clear();
            this.userID.Items.Clear();
            this.occupation.Items.Clear();
            this.secondBox.Items.Clear();

            string dbfilename = this.txtDatabase.Text;
            BusinessTier.Business biztier = new BusinessTier.Business(dbfilename);
            BusinessTier.User user = biztier.GetNamedUser(this.lstMovies.Text);
            BusinessTier.Movie movie = biztier.GetMovie(this.lstMovies.Text);

            if (user == null)
            {
                
                this.txtMovieID.Items.Add(string.Format("{0}", movie.MovieID));
                var details = biztier.GetMovieDetail(movie.MovieID);
                this.movieRating.Items.Add(string.Format("{0}", details.AvgRating));


                BusinessTier.MovieDetail detail = biztier.GetMovieDetail(movie.MovieID);

                foreach (BusinessTier.Review i in detail.Reviews)
                {
                 
                    this.secondBox.Items.Add(string.Format("{0}: {1}", i.UserID, i.Rating));
                }
            }

            if (movie == null)
            {
                
                this.userID.Items.Add(string.Format("{0}", user.UserID));
                this.occupation.Items.Add(string.Format("{0}", user.Occupation));

                BusinessTier.UserDetail detail = biztier.GetUserDetail(user.UserID);
                foreach (BusinessTier.Review i in detail.Reviews)
                {
                    var movieName= biztier.GetMovie(i.MovieID);
                    this.secondBox.Items.Add(string.Format("{0}-> {1}", movieName.MovieName, i.Rating));
                }
            }
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            this.lstMovies.Items.Clear();
            string dbfilename = this.txtDatabase.Text;
            BusinessTier.Business users = new BusinessTier.Business(dbfilename);

             foreach (BusinessTier.User i in users.GetAllNamedUsers())
            {
                this.lstMovies.Items.Add(string.Format("{0}", i.UserName));
            }



        }

        private void secondBox_SelectedIndexChanged(object sender, EventArgs e)
        {
    
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           // string username = this.namebox.Text;
            string rate = this.comboBox1.Text;
            string dbfilename = this.txtDatabase.Text;
            BusinessTier.Business biztier = new BusinessTier.Business(dbfilename);
            BusinessTier.Movie movie = biztier.GetMovie(this.movieBox.Text);
            BusinessTier.User user = biztier.GetNamedUser(this.namebox.Text);


            if (movie != null && user != null && (Convert.ToInt32(rate)) <= 5 && (Convert.ToInt32(rate)) > 0)
                biztier.AddReview(Convert.ToInt32(movie.MovieID), Convert.ToInt32(user.UserID), Convert.ToInt32(rate));

            else
                MessageBox.Show("invalid input");

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Connect_Click(object sender, EventArgs e)
        {
            this.lstMovies.Items.Clear();

            this.lstMovies.Items.Clear();
            string dbfilename = this.txtDatabase.Text;
            BusinessTier.Business biztier = new BusinessTier.Business(dbfilename);
            string dbfilename2 = this.txtDatabase.Text;
            BusinessTier.Business users = new BusinessTier.Business(dbfilename2);

            foreach (BusinessTier.Movie movies in biztier.GetAllMovies())
            {
                this.lstMovies.Items.Add(string.Format("{0}", movies.MovieName));

            }


            foreach (BusinessTier.Movie movies in biztier.GetAllMovies())
            {
                this.movieBox.Items.Add(string.Format("{0}", movies.MovieName));

            }

            foreach (BusinessTier.User i in users.GetAllNamedUsers())
            {
                this.namebox.Items.Add(string.Format("{0}", i.UserName));
            }



            //  movieBox.SelectedIndex = 0;
            //   namebox.SelectedIndex = 0;



        }

        private void eachRating_Click(object sender, EventArgs e)
        {
            this.secondBox.Items.Clear();
            string dbfilename = this.txtDatabase.Text;
            BusinessTier.Business biztier = new BusinessTier.Business(dbfilename);
            BusinessTier.User user = biztier.GetNamedUser(this.lstMovies.Text);
            BusinessTier.Movie movie = biztier.GetMovie(this.lstMovies.Text);
            


            if (user == null)
            {
                var bb = biztier.GetMovieDetail(biztier.GetMovie(Convert.ToInt32(movie.MovieID)).MovieID).Reviews;
                List<Review> ListRev = new List<Review>();
                foreach (var f in bb)
                {
                    ListRev.Add(f);
                }

                int one= 0, two= 0, three = 0, four =0, five =0; 

                foreach (var b in ListRev)
                {
                    if (b.Rating == 1)
                    {
                        one++; 
                    }

                    if (b.Rating == 2)
                    {
                        two++;
                    }

                    if (b.Rating == 3)
                    {
                        three++;
                    }

                    if (b.Rating == 4)
                    {
                        four++;
                    }

                    if (b.Rating == 5)
                    {
                        five++;
                    }
                }

                int totel = one + two + three + four + five;
                secondBox.Items.Add(string.Format("{0}", movie.MovieName ));
                secondBox.Items.Add(string.Format(" "));
                secondBox.Items.Add(string.Format("5: {0}", five));
                secondBox.Items.Add(string.Format("4: {0}", four));
                secondBox.Items.Add(string.Format("3: {0}", three));
                secondBox.Items.Add(string.Format("2: {0}", two));
                secondBox.Items.Add(string.Format("1: {0}", one));
                secondBox.Items.Add(string.Format("Totel: {0}", totel));

            }

            else
                MessageBox.Show("Please select a Movie from the movie list");
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void topNAvg_Click(object sender, EventArgs e)
        {
            this.secondBox.Items.Clear();
            int Nth = Convert.ToInt32(topN.Text);
            string dbfilename = this.txtDatabase.Text;
            BusinessTier.Business biztier = new BusinessTier.Business(dbfilename);
            BusinessTier.Movie movie = biztier.GetMovie(this.movieBox.Text);

            
            var list = (List<Movie>)biztier.GetTopMoviesByAvgRating(Nth);

            
            foreach (var i in list)
            {
                secondBox.Items.Add(string.Format("{0}: {1}", i.MovieName, (biztier.GetMovieDetail(i.MovieID).AvgRating)));

            }
        }
    }
}
