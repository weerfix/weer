using CoreTest.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreTest.Controllers
{
    public class SimpolesController: Controller
    {
        public IActionResult Index()

        {
            var simple = new List<Simpoles>();
            for (int i = 1; i < 30; i++)
            {
                simple.Add(new Simpoles {Id=i,Name=$"第{i}个名称",Context=$"{i}的内容",CreatBy="郭利锋",CreateDate=DateTime.Now.AddDays(-i) });
            }
            return View(new SimpolesViewModels { simpoles = simple });
        }
    }
}
