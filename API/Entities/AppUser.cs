using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Extensions;

namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        public string Username { get; set; }

        public byte[] PasswordHash {get; set;}
        public byte[] PasswordSalt { get; set; }

        public string Race { get; set; }
        public string Fullname {get; set;}
        public string Alias {get; set;}
        public DateTime Created {get; set;} = DateTime.Now;
        public DateTime LastActive {get; set;} = DateTime.Now;
        public string Gender { get; set;}
        public string Occupation { get; set; }
        public string Publisher { get; set; }
        public string GroupAffiliation { get; set; }
        public string Relatives { get; set; }
        public string Intelligence { get; set; }
        public string Strength { get; set; }
        public string Speed { get; set; }
        public string Durability { get; set; }
        public string Power { get; set; }
        public string Combat { get; set; }
        public ICollection<Photo> Photos { get; set; }
        // public int GetAge()
        // {
        //     return DateOfBirth.CalculateAge();
        // }
        
    }
}