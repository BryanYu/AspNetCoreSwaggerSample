using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreSwaggerSample.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetCoreSwaggerSample.Controllers
{
    /// <summary>
    /// 使用者服務
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private List<UserInfo> _userInfos = new List<UserInfo>
        {
            new UserInfo {Id = 1, Account = "Test1", Name = "Test1Name", Phone = "123456"},
            new UserInfo {Id = 2, Account = "Test2", Name = "Test2Name", Phone = "789123"},
            new UserInfo {Id = 3, Account = "Test3", Name = "Test3Name", Phone = "012345"},
        };
        
        /// <summary>
        /// 取得使用者清單
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<UserInfo> Get()
        {
            return this._userInfos;
        }

        /// <summary>
        /// 取得單一使用者
        /// </summary>
        /// <param name="id">編號</param>
        /// <returns></returns>

        [HttpGet("{id}")]
        public UserInfo Get(int id)
        {
            return this._userInfos.FirstOrDefault(item => item.Id == id);
        }

        /// <summary>
        /// 新增使用者
        /// </summary>
        /// <param name="userInfo">使用者資訊</param>
        [HttpPost]
        public void Post([FromBody]UserInfo userInfo)
        {
            this._userInfos.Add(userInfo);
        }

        /// <summary>
        /// 更新使用者名稱
        /// </summary>
        /// <param name="id">編號</param>
        /// <param name="name">名稱</param>
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string name)
        {
            var user = this._userInfos.FirstOrDefault(item => item.Id == id);
            user.Name = name;
        }

        /// <summary>
        /// 刪除使用者
        /// </summary>
        /// <param name="id">編號</param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            this._userInfos.RemoveAll(item => item.Id == id);
        }
    }
}
