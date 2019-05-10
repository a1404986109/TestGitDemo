using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace Ghy.Core.Web.Api.Models
{
    /// <summary>
    /// API返回JSON数据格式
    /// </summary>
    public class JsonResult<T> where T : class
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        public bool success { get; set; }

        /// <summary>
        /// 错误消息
        /// </summary>
        public string errmsg { get; set; }
        /// <summary>
        /// 数据总条数
        /// </summary>
        public int count { get; set; }
        /// <summary>
        /// 数据本体
        /// </summary>
        public T data { get; set; }



        /// <summary>
        /// 
        /// </summary>
        public JsonResult() { }


        /// <summary>
        /// 直接构造正确Result
        /// </summary>
        /// <param name="_data">数据本体</param>
        /// <param name="_totalcount">总条数</param>
        public JsonResult(T _data, int _totalcount = 0)
        {
            this.success = true;
            this.errmsg = "";
            this.count = _totalcount;
            this.data = _data;
        }

        /// <summary>
        /// 直接构造错误Result
        /// </summary>
        /// <param name="_errmsg"></param>
        public JsonResult(string _errmsg)
        {
            this.success = false;

            this.errmsg = _errmsg;
            this.count = 0;
            this.data = null;
        }

        /// <summary>
        /// 返回正确Result
        /// </summary>
        /// <param name="_data"></param>
        /// <param name="_totalcount"></param>
        public void Success(T _data, int _totalcount = 0)
        {
            this.success = true;
            this.errmsg = "";
            this.count = _totalcount;
            this.data = _data;
        }

        /// <summary>
        /// 返回错误Result
        /// </summary>
        /// <param name="_errmsg"></param>
        public void Fail(string _errmsg)
        {
            this.success = false;
            this.errmsg = _errmsg;
            this.count = 0;
            this.data = null;
        }
        
    }

    /// <summary>
    /// Json日期带T格式转换
    /// </summary>
    public class JsonDateTimeConverter : IsoDateTimeConverter
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            DateTime dataTime;
            if (DateTime.TryParse(reader.Value.ToString(), out dataTime))
            {
                return dataTime;
            }
            else
            {
                return existingValue;
            }
        }

        public JsonDateTimeConverter()
        {
            DateTimeFormat = "yyyy-MM-dd HH:mm:ss";
        }
    }
}