using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WcfPoc.Core.Proxies;

namespace WcfPoc.WebApplication
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRun_Click(object sender, EventArgs e)
        {
            FacadeServiceProxy proxy = ProxyFactory.GetServiceProxy();
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);

            txtSum.Text = proxy.Add(num1, num2).ToString();
        }
    }
}