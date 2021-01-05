using System;
using System.Collections.Generic;
using System.Linq;
using LiteDB;

namespace testnet.Models.Services
{
    public class UserInfoService
    {
        private readonly LiteDatabase _liteDb;

        public UserInfoService(TestnetContext liteDbContext)
        {
            _liteDb = liteDbContext.Context;
        }

        public IEnumerable<UserInfo> FindAll()
        {
            return _liteDb.GetCollection<UserInfo>("UserInfo")
                .FindAll();
        }

        public bool Insert(UserInfo userdetails)
        {
            try
            {
                _liteDb.GetCollection<UserInfo>("UserInfo")
                    .Insert(userdetails);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public int Delete()
        {
            return _liteDb.GetCollection<UserInfo>("UserInfo")
                .DeleteAll();
        }
    }
}
