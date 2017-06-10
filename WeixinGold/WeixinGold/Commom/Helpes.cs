using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace WeixinGold.Commom
{
    public class Helpes
    {
        /// <summary>
        /// 抽奖算法
        /// </summary>
        /// <returns></returns>
        public static int getCode()
        {
            int reStr = -1;
            List<int> intlist = new List<int>();
            for (int i = 0; i < 1000; i++)
            {
                intlist.Add(i);
            }
            Random ran = new Random();
            int RandKey = getrannum(1000);
            int page = 1;
            int count = 999;
            try
            {
                foreach (var item in getCodeList())
                {
                    for (int i = 0; i < item; i++)
                    {
                        if (reStr == -1)
                        {
                            int nex1 = getrannum(count - i);
                            if (RandKey == intlist[nex1])
                            {
                                reStr = page;
                            }
                            else
                            {
                                intlist.Remove(intlist[nex1]);
                            }
                        }
                        else
                        {
                            break;
                        }
                        count--;
                    }
                    page++;
                }
            }
            catch { reStr = 12; }
            return reStr;
        }

        public static int getrannum(int num)
        {
            Random ran = new Random();
            int RandKey = 0;
            if (num != 0)
            {
                RandKey = ran.Next(10000, 1000000) % num;

            }
            return RandKey;
        }

        public static string getGoldName(int id)
        {
            string Str = "";
            switch (id)
            {
                case 1: Str = "1000银子"; break;
                case 2: Str = "5000银子"; break;
                case 3: Str = "50元宝"; break;
                case 4: Str = "100元宝"; break;
                case 5: Str = "10万银子"; break;
                case 6: Str = "500元宝"; break;
                case 7: Str = "10元话费"; break;
                case 8: Str = "100万银子"; break;
                case 9: Str = "1000元宝"; break;
                case 10: Str = "20元话费"; break;
                default: Str = "1000银子"; break;
            }
            return Str;
        }

        public static int getGoldAngle(int id)
        {
            int Str = 0;
            switch (id)
            {
                case 1: Str = 285; break;
                case 2: Str = 15; break;
                case 3: Str = 315; break;
                case 4: Str = 45; break;
                case 5: Str = 105; break;
                case 6: Str = 135; break;
                case 7: Str = 255; break;
                case 8: Str = 195; break;
                case 9: Str = 225; break;
                case 10: Str = 345; break;
                default: Str = 285; break;
            }
            return Str;
        }

        /// <summary>
        /// 中奖几率控制器
        /// </summary>
        /// <returns></returns>
        public static List<int> getCodeList()
        {
            List<int> li = new List<int>();
            li.Add(500);//1000银子
            li.Add(300);//5000银子
            li.Add(55);//50元宝
            li.Add(55);//100元宝
            li.Add(45);//10万银子
            li.Add(35);//500元宝
            li.Add(7);//10元话费
            li.Add(1);//100万银子
            li.Add(1);//1000元宝
            li.Add(1);//20元话费
            return li;
        }


        /// <summary>
        /// Md5加解密
        /// </summary>
        /// <param name="str"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        public static string md5(string str, int code)
        {
            if (code == 16)
            {
                return System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(str, "MD5").ToLower().Substring(8, 16);
            }
            if (code == 32)
            {
                return System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(str, "MD5").ToLower();
            }
            return "00000000000000000000000000000000";
        }


        #region 下载图片
        /// <summary>
        /// 下载图片
        /// </summary>
        /// <param name="picUrl">图片Http地址</param>
        /// <param name="savePath">保存路径</param>
        /// <param name="timeOut">Request最大请求时间，如果为-1则无限制,单位为毫秒</param>
        /// <returns></returns>
        public static bool DownloadPicture(string picUrl, string savePath, int timeOut)
        {
            bool value = false;
            WebResponse response = null;
            Stream stream = null;
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(picUrl);
                if (timeOut != -1) request.Timeout = timeOut;
                response = request.GetResponse();
                stream = response.GetResponseStream();
                if (!response.ContentType.ToLower().StartsWith("text/"))
                    value = SaveBinaryFile(response, savePath);
            }
            catch 
            {
                value = true ;
            }
            finally
            {
                if (stream != null) stream.Close();
                if (response != null) response.Close();
            }
            return value;
        }

        private static bool SaveBinaryFile(WebResponse response, string savePath)
        {
            bool value = false;
            byte[] buffer = new byte[1024];
            Stream outStream = null;
            Stream inStream = null;
            try
            {
                if (File.Exists(savePath)) File.Delete(savePath);
                outStream = System.IO.File.Create(savePath);
                inStream = response.GetResponseStream();
                int l;
                do
                {
                    l = inStream.Read(buffer, 0, buffer.Length);
                    if (l > 0) outStream.Write(buffer, 0, l);
                } while (l > 0);
                value = true;
            }
            finally
            {
                if (outStream != null) outStream.Close();
                if (inStream != null) inStream.Close();
            }
            return value;
        }
        #endregion

        #region 图片转换
        /// <summary>
        /// 图片转换为byte
        /// </summary>
        /// <param name="imagePath"></param>
        /// <returns></returns>
        public static byte[] GetPictureData(string imagePath)
        {
            FileStream fs = new FileStream(imagePath, FileMode.Open);
            byte[] byteData = new byte[fs.Length];
            fs.Read(byteData, 0, byteData.Length);
            fs.Close();
            return byteData;
        }

        /// <summary>
        /// 将Image转换成流数据，并保存为byte[] 
        /// </summary>
        /// <param name="imgPhoto"></param>
        /// <returns></returns>
        public static byte[] PhotoImageInsert(System.Drawing.Image imgPhoto)
        {
            MemoryStream mstream = new MemoryStream();
            imgPhoto.Save(mstream, System.Drawing.Imaging.ImageFormat.Bmp);
            byte[] byData = new Byte[mstream.Length];
            mstream.Position = 0;
            mstream.Read(byData, 0, byData.Length); mstream.Close();
            return byData;
        }
        #endregion

    }
}