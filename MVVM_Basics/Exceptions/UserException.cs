using MVVM_Basics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Basics.Exceptions
{
    public class UserException : Exception
    {
        public User ExistingUser { get; set; }
        public User ComingUser { get; set; }
        public UserException(User existingUser = null, User comingUser = null)
        {
            ExistingUser = existingUser;
            ComingUser = comingUser;
        }

        public UserException(string? message, User existingUser, User comingUser) : base(message)
        {
            ExistingUser = existingUser;
            ComingUser = comingUser;
        }

        public UserException(string? message, Exception? innerException, User existingUser, User comingUser) : base(message, innerException)
        {
            ExistingUser = existingUser;
            ComingUser = comingUser;
        }
    }
}
