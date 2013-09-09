using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace ProjectName.Sessions
{
    public static class SessionHandler
    {
        #region < Atributos >

        private static string _id = "user_id";
        private static string _username = "user_name";
        private static string _email = "user_email";
        private static string _fullname = "user_fullname";
        private static string _rolename = "user_rolename";        

        #endregion < Atributos >

        #region < Propiedades >

        public static string Id
        {

            get
            {
                if (HttpContext.Current.Session[SessionHandler._id] == null)
                {
                    return string.Empty;
                }
                else
                {
                    return HttpContext.Current.Session[SessionHandler._id].ToString();
                }

            }
            set
            {
                HttpContext.Current.Session[SessionHandler._id] = value;
            }
        }

        public static string UserName
        {

            get
            {
                if (HttpContext.Current == null || HttpContext.Current.Session[SessionHandler._username] == null)
                {
                    return string.Empty;
                }
                else
                {
                    return HttpContext.Current.Session[SessionHandler._username].ToString();
                }

            }
            set
            {
                HttpContext.Current.Session[SessionHandler._username] = value;
            }
        }

        public static string Email
        {

            get
            {
                if (HttpContext.Current == null || HttpContext.Current.Session[SessionHandler._email] == null)
                {
                    return string.Empty;
                }
                else
                {
                    return HttpContext.Current.Session[SessionHandler._email].ToString();
                }

            }
            set
            {
                HttpContext.Current.Session[SessionHandler._email] = value;
            }
        }

        public static string FullName
        {

            get
            {
                if (HttpContext.Current == null || HttpContext.Current.Session[SessionHandler._fullname] == null)
                {
                    return string.Empty;
                }
                else
                {
                    return HttpContext.Current.Session[SessionHandler._fullname].ToString();
                }

            }
            set
            {
                HttpContext.Current.Session[SessionHandler._fullname] = value;
            }
        }

        public static string RoleName
        {

            get
            {
                if (HttpContext.Current == null || HttpContext.Current.Session[SessionHandler._rolename] == null)
                {
                    return string.Empty;
                }
                else
                {
                    return HttpContext.Current.Session[SessionHandler._rolename].ToString();
                }

            }
            set
            {
                HttpContext.Current.Session[SessionHandler._rolename] = value;
            }
        }        

        #endregion < Propiedades >


    }
}
