using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyMasterPage
{
    public partial class Default : System.Web.UI.Page
    {
        /// <summary>
        /// kolejnosc (1)
        /// startuje na poczatku 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_PreInit(object sender, EventArgs e)
        {
            if (Session["master"] != null)
            {
                MasterPageFile = (string)Session["master"];
            }
        }

        /// <summary>
        /// kolejnosc (2)
        /// wyszukiwanie kontrolki i przypisanie jej do zmiennej MasterPage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            ((Label)Master.FindControl("Label1")).Text = this.TextBox1.Text;

            Label5.Text = DateTime.Now.ToString("HH:mm:ss");

            if (!Page.IsPostBack)//pierwsze wywolanie strony
            {
                ViewState["valueFirstLoad"] = Label5.Text;
                if (Session["master"] != null)
                    this.DropDownList1.SelectedValue = Session["master"].ToString();
            }
            else
            {//kolejne wywolania strony
                ViewState["valueSecondLoad"] = Label5.Text;
                Session["master"] = this.DropDownList1.SelectedValue;                
            }
        }

        /// <summary>
        /// kolejnosc (4) ewentualnie w przypadku użycia
        /// wykorzystanie mechanizmu sesji do przekazywania danych miedzy poszczegolnymi wywolaniami strony
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["master"] = this.DropDownList1.SelectedValue;
            Response.Redirect(Request.RawUrl);//przeladowanie całej strony
        }

        /// <summary>
        /// mechanizm ViewState
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (ViewState["valueFirstLoad"] != null)
                Label2.Text = ViewState["valueFirstLoad"].ToString();

            if (ViewState["valueSecondLoad"] != null)
                Label4.Text = ViewState["valueSecondLoad"].ToString();

        }

    }
}
