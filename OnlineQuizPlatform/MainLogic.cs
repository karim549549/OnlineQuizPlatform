using OnlineQuizPlatform.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineQuizPlatform
{
    public class MainLogic
    {
        private readonly  UserServices  _userServices;
        public MainLogic(UserServices userServices)
        {
            _userServices = userServices;
        }

    }
}
