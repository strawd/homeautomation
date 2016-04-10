// Copyright (C) 2016 David Straw

using System.Web;
using System.Web.Http;

namespace HomeAutomation
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
