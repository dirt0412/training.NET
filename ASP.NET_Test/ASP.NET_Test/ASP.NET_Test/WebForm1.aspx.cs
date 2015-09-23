using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET_Test
{
  public partial class WebForm1 : System.Web.UI.Page
  {
    protected override void OnPreRender (EventArgs e)
    {
      if(ViewState["valueFirstLoad"]!=null)
      Label2.Text = ViewState["valueFirstLoad"].ToString();
      if (ViewState["valueSecondLoad"] != null)
        Label4.Text = ViewState["valueSecondLoad"].ToString();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
      Label5.Text = DateTime.Now.ToString("HH:mm:ss");
      if (!Page.IsPostBack)//pierwsze wywolanie strony
      {
        ViewState["valueFirstLoad"] = Label5.Text;
        Label2.Text = ViewState["valueFirstLoad"].ToString();
      }
      else
      {//kolejne wywolanie strony
        ViewState["valueSecondLoad"] = Label5.Text;
        Label4.Text = ViewState["valueSecondLoad"].ToString();
      }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
      //ViewState["valueFirstLoad"] = TextBox1.Text;
      //ViewState["valueSecondLoad"] = TextBox1.Text;
    }
  }
}