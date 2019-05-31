using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TequaCreek.OnBaseDIPFileCommitDriver
{
    class OBConnection
    {

            string g_datasource = "OnBase";
            string g_url = "http://localhost/AppServer/Service.asmx";

            public Hyland.Unity.Application Connect(string username, string password)
            {
                try
                {

                    Hyland.Unity.OnBaseAuthenticationProperties authProps = Hyland.Unity.Application.CreateOnBaseAuthenticationProperties(g_url, username, password, g_datasource);
                    Hyland.Unity.Application app = Hyland.Unity.Application.Connect(authProps);

                    return app;
                }
                catch (InvalidLoginException ex)
                {
                    throw new Exception("The credentials entered are invalid.", ex);
                }
                catch (UserAccountLockedException ex)
                {
                    throw new Exception("The user account is locked.", ex);
                }
                catch (AuthenticationFailedException ex)
                {
                    throw new Exception("Authentication failed.", ex);
                }
                catch (MaxConcurrentLicensesException ex)
                {
                    throw new Exception("All licenses are currently in use, please try again later.", ex);
                }
                catch (NamedLicenseNotAvailableException ex)
                {
                    throw new Exception("Your license is not availble, please insure you are logged out of other OnBase clients.", ex);
                }
                catch (SystemLockedOutException ex)
                {
                    throw new Exception("The system is currently locked, please try back later.", ex);
                }
                catch (UnityAPIException ex)
                {
                    throw new Exception("There was an unhandled exception with the Unity API.", ex);
                }
                catch (Exception ex)
                {
                    throw new Exception("There was an unhandled exception.", ex);
                }
            }

            public void Disconnect(Hyland.Unity.Application app)
            {

                if (app != null)
                {
                    app.Dispose();
                }

            }
    }
}

