using System;
using System.Collections.Generic;
using System.Text;

namespace DierenasielTongelreDAL.DTO
{
    public class AccountDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Sex { get; set; }
        public DateTime Age { get; set; }
        public string Role { get; set; }
    }
}
