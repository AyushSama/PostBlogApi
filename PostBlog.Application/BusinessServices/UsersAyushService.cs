using PostBlog.Application.BusinessInterfaces;
using PostBlog.Core.DBEntities;
using PostBlog.Data.EFData.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostBlog.Application.BusinessServices
{
    public class UsersAyushService : IUsersAyushService
    {
        private readonly IUsersAyushRepo _usersAyushRepo;

        public UsersAyushService(IUsersAyushRepo usersAyushRepo)
        {
            _usersAyushRepo = usersAyushRepo;
        }

        public List<UsersAyush> GetAll()
        {
            var result = _usersAyushRepo.ListAll();
            return result;
        }
    }
}
