using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WeixinGold.Models.Home
{
    public class IndexView
    {
        [Required(ErrorMessage = "账号不能为空")]
        public string Account { get; set; }
        [Required(ErrorMessage = "密码不能为空")]
        public string Password { get; set; }
    }
}