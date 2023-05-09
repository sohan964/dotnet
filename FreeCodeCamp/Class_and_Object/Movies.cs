using System;

namespace firstProgram{
    class Movie{
        public string Title;
        public string Director;
        private string rating;

        public Movie(string aTitle, string aDirector, string aRating){
            Title = aTitle;
            Director = aDirector;
            Rating = aRating;

        }

        public string Rating{
            get{
                return rating;
            }
            set{// here value builtine inside set
                if(value == "G" || value == "PG" || value =="PG-13" ){
                    rating = value;
                }
                else rating = "NR";
            }
        }
    }
}
