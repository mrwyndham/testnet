using Microsoft.Extensions.Options;
using System;
using LiteDB;

namespace testnet.Models
{
    public class LiteDbConfig
    {
        public string DatabasePath { get; set; }
    }
    public class TestnetContext
    {
        public readonly LiteDatabase Context;
        public ILiteCollection<UserInfo> UserInfo { get; set; }
        public ILiteCollection<Products> Products { get; set; }
        public TestnetContext(IOptions<LiteDbConfig> configs)
        {
            try
            {
                var db = new LiteDatabase(configs.Value.DatabasePath);
                if (db != null)
                {
                    Context = db;
                    UserInfo = Context.GetCollection<UserInfo>("UserInfo");
                    Products = Context.GetCollection<Products>("Products");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Can find or create LiteDb database.", ex);
            }
        }
    }
}
