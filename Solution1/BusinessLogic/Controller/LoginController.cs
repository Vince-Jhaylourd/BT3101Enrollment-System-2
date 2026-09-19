using BusinessLogic.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using BusinessLogic.Repository;

namespace BusinessLogic.Controller
{
   
    public class LoginController
    {
        private readonly UserRepository _userRepository;

        public LoginController()
        {
            _userRepository = new UserRepository();
        }

        public User? Login(string username, string password)
        {
            return _userRepository.Login(username, password);
        }
    }
}
