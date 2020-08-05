using System;
using System.Collections.Generic;
using System.Text;

namespace FilmeMania.Models
{
    /**
     * {
  "Title": "Avenger",
  "Year": "2006",
  "Rated": "Not Rated",
  "Released": "09 Apr 2006",
  "Runtime": "92 min",
  "Genre": "Thriller",
  "Director": "Robert Markowitz",
  "Writer": "Alan Sharp (teleplay), Frederick Forsyth (novel)",
  "Actors": "Sam Elliott, Timothy Hutton, James Cromwell, William Hope",
  "Plot": "A C.I.A. Agent steps in to stop a former Special Forces Operative on a for-hire mission that poses a global threat.",
  "Language": "English",
  "Country": "USA",
  "Awards": "N/A",
  "Poster": "https://m.media-amazon.com/images/M/MV5BMTMzMjMwMjcyNl5BMl5BanBnXkFtZTcwNTA1NDgzMQ@@._V1_SX300.jpg",
  "Ratings": [
    {
      "Source": "Internet Movie Database",
      "Value": "5.7/10"
    }
  ],
  "Metascore": "N/A",
  "imdbRating": "5.7",
  "imdbVotes": "908",
  "imdbID": "tt0473445",
  "Type": "movie",
  "DVD": "25 Oct 2005",
  "BoxOffice": "N/A",
  "Production": "Warner Home Video",
  "Website": "N/A",
  "Response": "True"
}
    */
    public class Movie
    {
        public string Title { get; set; }
        public string Year { get; set; }
        public string Release { get; set; }
        public string Runtime { get; set; }
        public string Genre { get; set; }
        public string Language { get; set; }
        public string Director { get; set; }
        public string Writer { get; set; }
        public string Actors { get; set; }
        public string Production { get; set; }
        public string Poster { get; set; }
        public string imdbID { get; set; }
        public string Type { get; set; }
    }
}
