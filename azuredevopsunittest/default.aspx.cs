using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace azuredevopsunittest
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Add_Click(object sender, EventArgs e)
        {
            int a;
            int.TryParse(number1.Text, out a);
            int b;
            int.TryParse(number1.Text, out b);
         lblResult.Text= "Result is"+   service.add(a, b).ToString();
        }

        protected void Minus_Click(object sender, EventArgs e)
        {
            int a;
            int.TryParse(number1.Text, out a);
            int b;
            int.TryParse(number1.Text, out b);
            lblResult.Text = "Result is" + service.minus(a, b).ToString();
        }

        protected void Multi_Click(object sender, EventArgs e)
        {
            int a;
            int.TryParse(number1.Text, out a);
            int b;
            int.TryParse(number1.Text, out b);
            lblResult.Text = "Result is" + service.multi(a, b).ToString();
        }
    }
}