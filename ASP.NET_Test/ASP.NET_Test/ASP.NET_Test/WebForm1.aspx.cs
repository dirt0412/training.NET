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
    
    protected void Page_Load(object sender, EventArgs e)
    {
      Label5.Text = DateTime.Now.ToString("HH:mm:ss");

      if (!Page.IsPostBack)//pierwsze wywolanie strony
      {
        ViewState["valueFirstLoad"] = Label5.Text;
      }
      else
      {//kolejne wywolania strony
        ViewState["valueSecondLoad"] = Label5.Text;
      }
    }

    protected override void OnPreRender(EventArgs e)
    {
      //if (ViewState["valueFirstLoad"] != null)
      //  Label2.Text = ViewState["valueFirstLoad"].ToString();
      //if (ViewState["valueSecondLoad"] != null)
      //  Label4.Text = ViewState["valueSecondLoad"].ToString();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
      if (ViewState["valueFirstLoad"] != null)
        Label2.Text = ViewState["valueFirstLoad"].ToString();

      if (ViewState["valueSecondLoad"] != null)
        Label4.Text = ViewState["valueSecondLoad"].ToString();
     
    }
  }
}