using System;
using System.Collections.Generic;
using System.Text;
using StackExchange;
using StackExchange.Redis;

namespace Common
{
    public class RedisCommon
    {
        private ConnectionMultiplexer redis { get; set; }
        private IDatabase db { get; set; }
        public RedisCommon(string connection)
        {
            redis = ConnectionMultiplexer.Connect(connection);
            db = redis.GetDatabase();
        }
        public bool SetValue(string key, string value)
        {
            return db.StringSet(key,value);
        }
        public string GetValue(string key)
        {
            return db.StringGet(key);
        }
        public bool DeleteKey(string key)
        {
            return db.KeyDelete(key);
        }
        public string SubMessage()
        {
            ISubscriber sub = redis.GetSubscriber();
            string msg = "";
            sub.Subscribe("message", (channel, message) =>
            {
                msg =  $"[{DateTime.Now:HH:mm:ss}]{message}";
            });
            return msg;
        }
    }
}
