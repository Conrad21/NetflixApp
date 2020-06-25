//
// BusinessTier:  business logic, acting as interface between UI and data store.
//
//
//
// Conrad Ptasznik
// U. of Illinois, Chicago
// CS341, Spring 2018
// Final Project
//
using System;
using System.Collections.Generic;
using System.Data;


namespace BusinessTier
{

  //
  // Business:
  //
  public class Business
  {
    //
    // Fields:
    //
    private string _DBFile;
    private DataAccessTier.Data dataTier;


    //
    // Constructor:
    //
    public Business(string DatabaseFilename)
    {
      _DBFile = DatabaseFilename;

      dataTier = new DataAccessTier.Data(DatabaseFilename);
    }


    //
    // TestConnection:
    //
    // Returns true if we can establish a connection to the database, false if not.
    //
    public bool TestConnection()
    {
      return dataTier.TestConnection();
    }


        public IReadOnlyList<Movie> GetAllMovies()
        {
            List<Movie> allMovies = new List<Movie>();

            string sql = string.Format(@"Select * From Movies Order by MovieName");
            var data = dataTier.ExecuteNonScalarQuery(sql);

            if (data == null)
            {
                return null;
            }

            else
            {
                foreach (DataRow r in data.Tables[0].Rows)
                {
                    //Movie(int movieId, string movieName)
                    int movieID = Convert.ToInt32(r.ItemArray[0]);
                    string movieName = Convert.ToString(r.ItemArray[1]);
                    Movie movie = new Movie(movieID, movieName);
                    allMovies.Add(movie);
                }
            }
            return allMovies;
        }
        //
        // GetNamedUser:
        //
        // Retrieves User object based on USER NAME; returns null if user is not
        // found.
        //
        // NOTE: there are "named" users from the Users table, and anonymous users
        // that only exist in the Reviews table.  This function only looks up "named"
        // users from the Users table.
        //
        public User GetNamedUser(string UserName)
    {
            //
            // TODO!
            //
            
            string sql = string.Format(@"Select * From Users Where UserName ='" + UserName.Replace("'", "''") + "';"); 
            var data = dataTier.ExecuteNonScalarQuery (sql);

            if (data.Tables[0].Rows.Count == 0)
            {
                return null;
            }


            else
            { 
                int userId = Convert.ToInt32(Convert.ToString(data.Tables[0].Rows[0].ItemArray[0]));
                string userName = Convert.ToString(data.Tables[0].Rows[0].ItemArray[1]);
                string occupation = Convert.ToString(data.Tables[0].Rows[0].ItemArray[2]);
                var NewUserName = new User(userId, userName, occupation);
                return NewUserName; 
            }
    }


    //
    // GetAllNamedUsers:
    //
    // Returns a list of all the users in the Users table ("named" users), sorted 
    // by user name.
    //
    // NOTE: the database also contains lots of "anonymous" users, which this 
    // function does not return.
    //
    public IReadOnlyList<User> GetAllNamedUsers()
    {
      List<User> users = new List<User>();
      string sql = string.Format(@"Select * From Users Order by UserName");
      var data = dataTier.ExecuteNonScalarQuery(sql);
       if (data.Tables[0].Rows.Count == 0)
            {
                return null; 
            }
        else
            {
                foreach (DataRow r in data.Tables[0].Rows)
                {

                    int userId = Convert.ToInt32(Convert.ToString(r.ItemArray[0]));
                    string userName = Convert.ToString(r.ItemArray[1]); 
                    string occupation = Convert.ToString(Convert.ToString(r.ItemArray[2]));
                    users.Add(new User(userId, userName, occupation));
                }
                return users;
            }
           
    }


    //
    // GetMovie:
    //
    // Retrieves Movie object based on MOVIE ID; returns null if movie is not
    // found.
    //
    public Movie GetMovie(int MovieID)
    {
            
        string sql = string.Format(@"Select * From Movies Where MovieID ='" + MovieID + "'");
        var data = dataTier.ExecuteNonScalarQuery(sql);
            if (data.Tables[0].Rows.Count == 0)
            {
                return null;
            }
            
            else
            { 
                //Movie(int movieId, string movieName)
                int movieID = Convert.ToInt32(data.Tables[0].Rows[0].ItemArray[0]);
                string movieName = Convert.ToString(data.Tables[0].Rows[0].ItemArray[1]); 
                Movie movie = new Movie( movieID, movieName);
                return movie;
            }
          
             //   return null;      
    }


    //
    // GetMovie:
    //
    // Retrieves Movie object based on MOVIE NAME; returns null if movie is not
    // found.
    //
    public Movie GetMovie(string MovieName)
    {
     string sql = string.Format(@"Select * From Movies Where MovieName = '" + MovieName.Replace("'", "''") + "'");  
     var data = dataTier.ExecuteNonScalarQuery(sql);
            if (data.Tables[0].Rows.Count == 0)
            {
                return null;
            }
            else
            {
                int movieId = Convert.ToInt32(Convert.ToString(data.Tables[0].Rows[0].ItemArray[0]));
                string movieName = Convert.ToString(data.Tables[0].Rows[0].ItemArray[1]);
                Movie MoveName = new Movie((movieId), movieName);
                return MoveName; 
            }
    }


    //
    // AddReview:
    //
    // Adds review based on MOVIE ID, returning a Review object containing
    // the review, review's id, etc.  If the add failed, null is returned.
    //
    public Review AddReview(int MovieID, int UserID, int Rating)
    {
            string sql = string.Format(@"
            Insert INTO Reviews VALUES({0}, {1}, {2});
            Select ReviewID From Reviews Where reviewid = SCOPE_IDENTITY();
            ", MovieID, UserID, Rating);

            var data = dataTier.ExecuteScalarQuery(sql);

            int reviewID = (Convert.ToInt32(data.ToString()));

            string sql2 = string.Format(@" Select * From reviews Where reviewid = '" + reviewID + "'"); 
            var data2 = dataTier.ExecuteNonScalarQuery(sql2);

            if (data == null)
            {
                return null; 
            }

            else
            {
                int reviewId = Convert.ToInt32(Convert.ToString(data2.Tables[0].Rows[0].ItemArray[0]));
                int movieId = Convert.ToInt32(Convert.ToString(data2.Tables[0].Rows[0].ItemArray[1]));
                int userId = Convert.ToInt32((Convert.ToString(data2.Tables[0].Rows[0].ItemArray[2])));
                int rating = Convert.ToInt32(Convert.ToString(data2.Tables[0].Rows[0].ItemArray[3]));

                Review Rev = new Review(reviewId, movieId, userId, rating);
                return Rev; 
            }

     //return null;
    }


    //
    // GetMovieDetail:
    //
    // Given a MOVIE ID, returns detailed information about this movie --- all
    // the reviews, the total number of reviews, average rating, etc.  If the 
    // movie cannot be found, null is returned.
    //
    public MovieDetail GetMovieDetail(int MovieID)
    {
            string sql = string.Format(@"Select * From Reviews where MovieID ='" + MovieID  +  "'  order by Rating desc, userId asc");
            var data = dataTier.ExecuteNonScalarQuery(sql);

            List<Review> reviews = new List<Review>();
            if (data.Tables[0].Rows.Count == 0)
            {
                return null; 
            }


            else
            {
               
                var data2 = dataTier.ExecuteScalarQuery(@"Select AVG(Convert(float, Rating)) from Reviews where MovieID = '"+ MovieID + "'");
                var movie = GetMovie(MovieID);
                double avgRating = Convert.ToDouble(Convert.ToString(data2));  //??
  
                var numReviews = reviews.Count;

                foreach (DataRow r in data.Tables[0].Rows)
                {

                    int reviewId = Convert.ToInt32(Convert.ToString(r.ItemArray[0]));
                    int movieId = Convert.ToInt32(Convert.ToString(r.ItemArray[1]));
                    int userId = Convert.ToInt32(Convert.ToString(r.ItemArray[2]));
                    int rating = Convert.ToInt32(Convert.ToString(r.ItemArray[3]));
                    var newReview = new Review(reviewId, movieId, userId, rating);
                    reviews.Add(newReview);
                    
                }

                // MovieDetail(Movie m, double avgRating, int numReviews, IReadOnlyList < Review > reviews)

   

                var movDetail =  new MovieDetail(movie, avgRating, numReviews, reviews);
                return movDetail; 

            }
            
        }


    //
    // GetUserDetail:
    //
    // Given a USER ID, returns detailed information about this user --- all
    // the reviews submitted by this user, the total number of reviews, average 
    // rating given, etc.  If the user cannot be found, null is returned.
    //
    public UserDetail GetUserDetail(int UserID)
    {
           
            string sql = string.Format(@"Select * From Reviews where UserID = '" + UserID + "' order by rating desc");
            var data = dataTier.ExecuteNonScalarQuery(sql);

            List<Review> reviews = new List<Review>();
           
            if (data == null )
            {
                return null;
            }


            else
            { 
                int Counter = 0; 
                foreach (DataRow r in data.Tables[0].Rows)
                {
                    int reviewId = Convert.ToInt32(Convert.ToString(r.ItemArray[0]));
                    int movieId = Convert.ToInt32(Convert.ToString(r.ItemArray[1]));
                    int userId = Convert.ToInt32((Convert.ToString(r.ItemArray[2])));
                    int rating = Convert.ToInt32(Convert.ToString(r.ItemArray[3]));

                    int RatingCount = Convert.ToInt32(Convert.ToString(r.ItemArray[3]));
                    Counter = Counter + RatingCount; 

                    Review Reviews = new Review(reviewId, movieId, userId, rating);
                    reviews.Add(Reviews); 

                }

                string sql2 = string.Format(@"Select * From Users where UserID = '" + UserID + "'");
                var data2 = dataTier.ExecuteNonScalarQuery(sql2);

                var name = Convert.ToString(data2.Tables[0].Rows[0].ItemArray[1]);
            
                var u = GetNamedUser(name);


                int Numofreviews = reviews.Count;

                if (Numofreviews == 0)
                {
                    Numofreviews = 1;
                    double avgRating = (Counter / Numofreviews);
                    return new UserDetail(u, avgRating, Numofreviews, reviews);
                }

                else
                {
                    double avgRating = (Counter / Numofreviews);

                    // UserDetail(User u, double avgRating, int numReviews, IReadOnlyList<Review> reviews)
                    return new UserDetail(u, avgRating, Numofreviews, reviews);

                }
            }
        }


    //
    // GetTopMoviesByAvgRating:
    //
    // Returns the top N movies in descending order by average rating.  If two
    // movies have the same rating, the movies are presented in ascending order
    // by name.  If N < 1, an EMPTY LIST is returned.
    //
    public IReadOnlyList<Movie> GetTopMoviesByAvgRating(int N)
    {
            List<Movie> movies = new List<Movie>();
         
            string sql = string.Format(@"Select top " + N + "  MovieID, AVG(Convert(float, Rating)) as avvg From Reviews " +
                "Group by MovieID " +
                "Order BY avvg desc");

            var data = dataTier.ExecuteNonScalarQuery(sql);
            if (N < 1)
            {
                return movies;
            }

            else
            {
                if (data.Tables[0].Rows.Count == 0)
                {
                    return null; 
                }

                else {
                    foreach (DataRow r in data.Tables[0].Rows)
                    {
                        int Details = Convert.ToInt32(Convert.ToString(r.ItemArray[0]));
                        var movie = GetMovie(Details); 
                        movies.Add(movie);
                    }
                    return movies; 
                }
            }

        }


  }//class
}//namespace
