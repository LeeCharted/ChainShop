using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeixinGold.EFModels.QPGameUserDB;
using WeixinGold.Models.Home;

namespace WeixinGold.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(IndexView mode)
        {
            QPGameUserDB db = new QPGameUserDB();
            if (!ModelState.IsValid)
            {
                return View(mode);
            }
            string pwd = Commom.Helpes.md5(mode.Password, 32);
            var dbset = db.AccountsInfo.Where(x => x.Accounts == mode.Account && x.LogonPass == pwd).FirstOrDefault();
            if (dbset != null)
            {
                string CookieStr = Guid.NewGuid().ToString();
                if (Request.Cookies["weigoldcook"] != null)
                { Response.Cookies["weigoldcook"].Expires = DateTime.Now.AddDays(-1); }
                HttpCookie cookie = new HttpCookie("weigoldcook");
                cookie.Values.Add("uid", HttpUtility.UrlEncode(Commom.AES.getAesEncrypt(dbset.UserID.ToString())));
                cookie.Values.Add("nickname", HttpUtility.UrlEncode(dbset.NickName));
                Response.AppendCookie(cookie);
            }
            else
            {
                ModelState.AddModelError("Password", "账号或密码不正确");
                return View(mode);
            }
            return View();
        }

        public ActionResult LogionOut()
        {
            if (Request.Cookies["weigoldcook"] != null)
            { Response.Cookies["weigoldcook"].Expires = DateTime.Now.AddDays(-1); }
            return RedirectToAction("Index");
        }

        /// <summary>
        /// 用户图片
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public FileResult getuserimg(int? id)
        {
            string ImgStr = "/Content/UserImg/tuxiang.png";
            QPGameUserDB db = new QPGameUserDB();
            int gid = id.GetValueOrDefault();
            string m_fileName = "";
            var dbset = db.AccountsInfo.AsNoTracking().Where(x => x.UserID == gid).FirstOrDefault();
            if (dbset != null)
            {
                ImgStr = "http://192.168.1.132:8014/ChatServer/LocalUser/TestFtp/UserCustomerFace/" + dbset.GameID + "_" + dbset.CustomFaceVer + ".png";
                //正式服务器
                //ImgStr = "http://nanfangok.com:8080/ChatServer/UserCustomerFace/" + dbset.GameID + "_" + dbset.CustomFaceVer + ".png";
            }
            m_fileName = DateTime.Now.ToFileTime().ToString() + Guid.NewGuid().ToString() + ".png";
            string m_saveName = "/Content/images/UserImg/" + m_fileName;
            string m_savePath = Server.MapPath(m_saveName);
            byte[] img = null;
            try
            {
                Commom.Helpes.DownloadPicture(ImgStr, m_savePath, -1);
                img = Commom.Helpes.GetPictureData(m_savePath);
                FileInfo file = new FileInfo(m_savePath);
                file.Delete();
            }
            catch
            {
                ImgStr = "/Content/UserImg/tuxiang.png";
                m_savePath = Server.MapPath(ImgStr);
                img = Commom.Helpes.GetPictureData(m_savePath);
            }
            return new FileContentResult(img, "image/jpeg");
        }

        [HttpPost]
        public string getCount()
        {
            string Str = "";
            if (Request.Cookies["weigoldcook"] != null)
            {
                try
                {
                    int uid = int.Parse(Commom.AES.getAesDeciphering(HttpUtility.UrlDecode(Request.Cookies["weigoldcook"]["uid"]).ToString()));
                    QPGameUserDB db = new QPGameUserDB();
                    var dbset = db.wxGold.AsNoTracking().Where(x => x.UserId == uid).FirstOrDefault();
                    if (dbset != null)
                    {
                        if (dbset.typeid == 1)
                        {
                            Str += "{\"datetype\":\"1\",\"da\":\"" + Commom.Helpes.getGoldAngle(dbset.GoldName) + "\",\"info\":\"" + Commom.Helpes.getGoldName(dbset.GoldName) + "\"}";
                        }
                        else
                        {
                            //已抽过
                            Str += "{\"datetype\":\"2\"}";
                        }
                    }
                    else
                    {
                        var goid = Commom.Helpes.getCode();
                        wxGold data = new wxGold();
                        data.UserId = uid;
                        data.typeid = 1;
                        data.GoldName = goid;
                        data.CreateTime = DateTime.Now;
                        data.Ip = Commom.AdressIp.IP;
                        db.wxGold.Add(data);
                        db.SaveChanges();
                        Str += "{\"datetype\":\"1\",\"da\":\"" + Commom.Helpes.getGoldAngle(goid) + "\",\"info\":\"" + Commom.Helpes.getGoldName(goid) + "\"}";
                    }
                }
                catch
                {
                    Str += "{\"datetype\":\"3\"}";
                }
            }
            else
            {
                Str += "{\"datetype\":\"0\"}";
            }
            return Str;
        }

        public void dispose()
        {
            
        }
    }
}
