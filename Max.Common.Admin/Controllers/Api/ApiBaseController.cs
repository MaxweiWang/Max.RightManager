using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Max.DataProvider.DbContext.SqlServer;
using Max.Utilities.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Controllers.Api
{

    [ApiExplorerSettings(GroupName = nameof(ApiVersionsEnum.WebApi))]
    [Route(nameof(ApiVersionsEnum.WebApi) + "/[controller]")]
    //[ApiController]
    public class ApiBaseController : ControllerBase
    {

        /// <summary>
        /// 数据访问对象
        /// </summary>
        protected DbContextSqlServer db => Max.Service.Class.AppBase.db;

        [NonAction]
        public IActionResult Json(object Data)
        {
            return new JsonResult(Data);
        }





    }
}