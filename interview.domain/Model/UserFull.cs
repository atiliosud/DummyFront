using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interview.domain.Model
{
    public class UserFull
    {
        public string id { get; set; }
        public string title { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public string email { get; set; }
        public string dateOfBirth { get; set; }
        public string registerDate { get; set; }
        public string phone { get; set; }
        public string picture { get; set; }
        public Location location { get; set; }
    }
}
