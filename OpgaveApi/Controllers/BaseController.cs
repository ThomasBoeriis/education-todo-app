﻿using OpgaveApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OpgaveApi.Controllers
{
    public class BaseController : ApiController
    {
        public TaskModel db = new TaskModel();
    }
}
