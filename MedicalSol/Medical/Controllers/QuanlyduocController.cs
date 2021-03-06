﻿using Medical.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Medical.Controllers
{
    public class QuanlyduocController : Controller
    {
        //
        // GET: /Quanlyduoc/

        public ActionResult Index()
        {
            return View();
        }

        #region Tiện Ích
        public ActionResult Khaibaokho()
        {
            //Data.RunAsync().Wait();
            ViewData["page"] = "page_duoc_khaibaokho";
            //return View(Data.Kho.GetAllObj());
            return View();
        }

        public ActionResult Khaibaothuoc()
        {
            ViewData["page"] = "page_duoc_khaibaothuoc"; 
            //return View(Data.Thuoc.GetAllObj());
            return View();
        }
        #endregion

        public ActionResult Nhapkho()        
        {
            ViewData["page"] = "page_duoc_nhapkho";
            //return View(Data.Nhapkho.GetAllObj());
            return View();
        }
        public ActionResult Xuatban()
        {
            ViewData["page"] = "page_duoc_xuatban";
            //return View(Data.Kho.GetAllObj());
            return View();
        }        
    }
}
