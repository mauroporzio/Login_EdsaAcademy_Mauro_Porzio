using Login.Entity;
using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace Login
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void AuthenticateLogIn(object sender, AuthenticateEventArgs e)
        {
            User userLoggingIn = new User(IDControlLogin.UserName, IDControlLogin.Password); // GUARDO EL USER QUE SE ESTA INTENTADO LOGGEAR.

            List<User> userCredentialsList = (List<User>)Application["userCredentials"]; // RECIBO LA LISTA DEL ARCHIVO DE CREDENCIALES VALIDAS.

            foreach(User user in userCredentialsList)
            {
                if (user.username.Equals(userLoggingIn.username) && user.password.Equals(userLoggingIn.password)) // SI COINCIDEN LOS USERNAMES Y PASSWORDS
                {
                    Response.Cookies["LoggedUser"]["Username"] = user.username; // GUARDO EN LAS COOKIES LOS VALORES
                    Response.Cookies["LoggedUser"]["DateOfLogIn"] = DateTime.Now.ToShortDateString();

                    Response.Redirect("Redirect.aspx"); // REDIRIJO AL CLIENTE A LA PAGINA ENCARGADA DE CONTINUAR CON LA FUNCIONALDIAD.
                }
            }
        }
    }
}