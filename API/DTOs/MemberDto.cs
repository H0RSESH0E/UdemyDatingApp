using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class MemberDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string PhotoUrl { get; set; }
        public string Race { get; set; }
        public string Fullname {get; set;}
        public string Alias {get; set;}
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }        
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
        public ICollection<PhotoDto> Photos { get; set; }
    }
}