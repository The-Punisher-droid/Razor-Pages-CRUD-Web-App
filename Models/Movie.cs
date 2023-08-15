using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        //The ID field is required by the Database fo the Primary Key
        public int Id { get; set; }
        //The ? after the string is to indicate that it is nullable
        public string? Title { get; set; }
        //A [DataType] Attribute that tells which type of data in ReleaseDate
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string? Genre{get; set;}
        public decimal Price{ get; set; }
    }
}
