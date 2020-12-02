using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;
namespace DavinaJamesFinal
{
    class Games
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [MaxLength(10)]

        public string Gname { get; set; }
        [MaxLength(70)]
        public string Description { get; set; }
        [MaxLength(70)]

        public string Console { get; set; }
        [MaxLength(70)]

        public string Rating { get; set; }

        public Games(string cGname,string cDescription, string cConsole, string cRating)
        {
            Gname = cGname;
            Description = cDescription;
            Console = cConsole;
            Rating = cRating;
        }
        public Games ()
        {

        }
    }
}
