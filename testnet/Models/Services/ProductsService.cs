using System;
using System.Collections.Generic;
using System.Linq;
using LiteDB;

namespace testnet.Models.Services
{
    public class ProductsService
    {
        private readonly LiteDatabase _liteDb;

        public ProductsService(TestnetContext liteDbContext)
        {
            _liteDb = liteDbContext.Context;
        }

        public IEnumerable<Products> FindAll()
        {
            return _liteDb.GetCollection<Products>("Products")
                .FindAll();
        }

        public bool Insert(Products productdetails)
        {
            try
            {
                _liteDb.GetCollection<Products>("Products")
                    .Insert(productdetails);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public int Delete()
        {
            return _liteDb.GetCollection<Products>("Products")
                .DeleteAll();
        }
    }
}
