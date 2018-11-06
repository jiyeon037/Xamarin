using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculatorWebService
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient s = new ServiceReference1.WebService1SoapClient();

            double answer = 0.0;
            string select = DropDownList1.SelectedValue;

            if (select.Equals("Add"))
            {
                answer = s.Add(double.Parse(TextBox1.Text), double.Parse(TextBox2.Text));
            }

            else if (select.Equals("Sub"))
            {
                answer = s.Sub(double.Parse(TextBox1.Text), double.Parse(TextBox2.Text));
            }

            else if (select.Equals("Mul"))
            {
                answer = s.Mul(double.Parse(TextBox1.Text), double.Parse(TextBox2.Text));
            }

            else if (select.Equals("Dev"))
            {
                answer = s.Dev(double.Parse(TextBox1.Text), double.Parse(TextBox2.Text));
            }

            Label1.Text = "Total is : " + answer.ToString();
        }
    }
}