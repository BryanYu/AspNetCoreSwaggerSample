using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreSwaggerSample.Models
{
    /// <summary>
    /// 使用者資訊
    /// </summary>
    public class UserInfo
    {
        /// <summary>
        /// 編號
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 帳號
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// 名稱
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 電話號碼
        /// </summary>
        public string Phone { get; set; }
    }
}
