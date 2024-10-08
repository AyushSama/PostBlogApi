﻿using PostBlog.Core.DBEntities;

namespace PostBlog.Application.BusinessInterfaces
{
    public interface IUsersAyushService
    {
        public List<UsersAyush> GetAll();
        public UsersAyush GetSingle(string userName, string password);

        public void InsertUser(UsersAyush user);
    }
}
