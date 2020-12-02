using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace DavinaJamesFinal
{
	public class Account
	{
        //Account table to keep track of users and their information
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [MaxLength(10)]

        public string FName { get; set; }
        [MaxLength(70)]

        public string LName { get; set; }
        [MaxLength(70)]

        public string Address { get; set; }
        public string Card { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
    }

  
}
