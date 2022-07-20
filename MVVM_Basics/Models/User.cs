using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Basics.Models
{
    public class User
    {
        public string UserName { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }

        public User(string userName, int phoneNumber, string email)
        {
            UserName = userName;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }
}
