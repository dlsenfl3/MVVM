using MVVM_Basics.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Basics.Models
{
    public class UserList
    {

        private readonly List<User> _userList;

        public UserList()
        {
            _userList = new List<User>();
        }

        public IEnumerable<User> GetUser(string userName)
        {
            return _userList.Where(r => r.UserName == userName);
        }

        public void AddUser(User user)
        {
            foreach (var existUser in _userList)
            {
                if (Exist(existUser, user))
                {
                    throw new UserException(existUser, user);
                }

            }
            _userList.Add(user);
        }

        public bool Exist(User existUser, User user)
        {
            if (existUser.UserName == user.UserName)
            {
                return true;
            }
            return false;
        }
    }
}
