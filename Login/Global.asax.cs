using Login.Entity;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.IO;
using System.Configuration;

namespace Login
{
    public class Global : HttpApplication
    {
        public string pathFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ConfigurationManager.AppSettings["Path"]); // path saved users.

        void Application_Start(object sender, EventArgs e)
        {

            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //CREACION DEL ARCHIVO DE USUARIOS REGISTRADOS.

            //loadValidUsersFile(new List<User>() { new User("mauro", "1234"), new User("jorge", "1111"), new User("Tester", "Tester"), new User("Tester2", "Tester2") }); //LA LINEA VIENE COMENTADA PORQUE EL ARCHIVO YA ESTA CARGADO.
                                                                                                          //  SI DESEA CARGAR NUEVOS USUARIOS DESCOMENTE LA LINEA Y AGREGUE UN NUEVO OBJ USER CON SUS RESPECTIVOS DATOS.
            //--------------------------------------------------------------------------
            //APERTURA DEL ARCHIVO DE USUARIOS REGISTRADOS.

            StreamReader userCredentialsFile = new StreamReader(pathFile); // SE ABRE EL ARCHIVO
            List<User> userCredentialsList = new List<User>(); // SE CREA UN LIST USER
            string username;
            string password;

            while ((username = userCredentialsFile.ReadLine()) != null) // HASTA QUE NO SE LLEGUE AL FINAL DEL ARCHIVO. Y  SU VEZ SE GUARDA EL USERNAME
            {
                password = userCredentialsFile.ReadLine(); // SE GUARDA EL PASSWORD

                userCredentialsList.Add(new Entity.User(username, password)); // SE CREA EL USER CON LOS DATOS RECIBIDOS Y SE GUARDA EN LA LIST USER
            }

            userCredentialsFile.Close();

            Application["userCredentials"] = userCredentialsList; // VARIABLE GLOBAL CON LA LISTA DE USUARIOS.
        }
        void loadValidUsersFile(List<User> usersToLoad) // FUNCION QUE EDITA O CREA EL ARCHIVO DE USUARIOS VALIDOS.
        {
            using (TextWriter tw = new StreamWriter(pathFile)) // SE GUARDA EN ESE PATH CON EL STREAM WRITER.
            {
                foreach (User user in usersToLoad)
                {
                    tw.WriteLine(string.Format(user.username));
                    tw.WriteLine(string.Format(user.password));
                }
            }
        }
    }
}

