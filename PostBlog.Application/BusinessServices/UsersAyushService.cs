using DataHelper.HelperClasses;
using PostBlog.Application.BusinessInterfaces;
using PostBlog.Core.DBEntities;
using PostBlog.Core.ModelEntities;
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

        public UsersAyush GetSingle(string username, string password)
        {
            BaseSpecification<UsersAyush> spec = new BaseSpecification<UsersAyush>()
            {
                Criteria = e => e.userName == username && e.password == password
            };   
            var result = _usersAyushRepo.GetUniqueRecordBySpec(spec);
            return result; 
        }

        public void InsertUser(UsersAyush user)
        {
            _usersAyushRepo.Add(user);
        }
    }
}
