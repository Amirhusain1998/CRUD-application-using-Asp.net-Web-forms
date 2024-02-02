using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Crud_using_Gridview
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            SqlDataSource1.InsertParameters["Prod_name"].DefaultValue = ((TextBox)GridView1.FooterRow.FindControl("footerProductName")).Text;

            SqlDataSource1.InsertParameters["Prod_Price"].DefaultValue = ((TextBox)GridView1.FooterRow.FindControl("footerPrice")).Text;
            SqlDataSource1.InsertParameters["Prod_catagory"].DefaultValue = ((TextBox)GridView1.FooterRow.FindControl("footerCatagory")).Text;
            int a = SqlDataSource1.Insert();
            if(a> 0)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Script", "<script>alert('Inserted success')</script>");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Script", "<script>alert('Inserted failed')</script>");

            }


        }
    }
}