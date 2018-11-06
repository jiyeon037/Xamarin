﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MyWebService
{
    /// <summary>
    /// WebService1의 요약 설명입니다.
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // ASP.NET AJAX를 사용하여 스크립트에서 이 웹 서비스를 호출하려면 다음 줄의 주석 처리를 제거합니다. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public double Add(double num1, double num2)
        {
            double tot = num1 + num2;
            return tot;
        }

        [WebMethod]
        public double Sub(double num1, double num2)
        {
            double tot = num1 - num2;
            return tot;
        }

        [WebMethod]
        public double Mul(double num1, double num2)
        {
            double tot = num1 * num2;
            return tot;
        }

        [WebMethod]
        public double Dev(double num1, double num2)
        {
            double tot = num1 / num2;
            return tot;
        }

    }
}
