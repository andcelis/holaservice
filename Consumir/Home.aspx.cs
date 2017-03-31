using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consumir
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WebDB.BDSoapClient ws = new WebDB.BDSoapClient();
            DataSet ds = ws.GetData();
            gridDB.DataSource = ds.Tables[0];
            gridDB.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            WebDB.BDSoapClient ws = new WebDB.BDSoapClient();
            DataSet ds = ws.GetData();
            gridDB.DataSource = ds.Tables[0];
            gridDB.DataBind();
        }

        protected void gridDB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}