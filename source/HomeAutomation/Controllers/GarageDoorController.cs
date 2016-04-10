// Copyright (C) 2016 David Straw

using System.Web.Http;
using HomeAutomation.Models;

namespace HomeAutomation.Controllers
{
    [RoutePrefix("api/garage-door")]
    public class GarageDoorController : ApiController
    {
        [Route]
        public GarageDoor Get()
        {
            return new GarageDoor
            {
                IsOpen = false
            };
        }
    }
}