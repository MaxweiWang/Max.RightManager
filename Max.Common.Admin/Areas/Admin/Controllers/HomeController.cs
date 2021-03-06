﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Areas.Admin.Controllers
{
    using Max.Service.SysClass;
    using Microsoft.Extensions.Configuration;
    using System.Text;

    public class HomeController : AdminBaseController
    {
        Sys_MenuLogic _Logic = new Sys_MenuLogic();

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            StringBuilder _StringBuilder = new StringBuilder();
            _Logic.CreateMenus(Guid.Empty, await _Logic.GetMenuByRoleIDAsync(this._Account), _StringBuilder);
            ViewBag.Menus = _StringBuilder.ToString();
            ViewBag.UsreName = this._Account.UserName;
            return View();
        }

        [HttpGet]
        public IActionResult Main()
        {
            return View();
        }

        /// <summary>
        /// 保持连接
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Connetct()
        {
            return this.Success();
        }



    }
}