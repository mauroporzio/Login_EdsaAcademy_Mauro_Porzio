using System;

namespace Login
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtInfo.Text = Convert.ToString(Request.Cookies["LoggedUser"]["Username"]); // AGREGO A LAS CAJAS DE TEXTOS LOS VALORES DE LAS COOKIES RECIBIDAS.
            txtinfo2.Text = Convert.ToString(Request.Cookies["LoggedUser"]["DateOfLogIn"]);
        }
    }
}