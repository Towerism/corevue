// //-----------------------------------------------------------------------
// // <copyright file="TasksController.cs" company="ImprovingEnterprises">
// //     Copyright (c) ImprovingEnterprises. All rights reserved.
// // </copyright>
// // <author>Martin Fracker</author>
// //-----------------------------------------------------------------------

using System.Collections;
using System.Collections.Generic;
using Corevue.Models;
using Microsoft.AspNetCore.Mvc;

namespace Corevue.Controllers
{
    [Route("api/tasks")]
    public class TasksController : ApiController
    {
        private static readonly ICollection<Task> Tasks = new List<Task>();

        [HttpGet]
        public IActionResult Get()
        {
            return new JsonResult(Tasks);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Task task)
        {
            Tasks.Add(task);

            return new JsonResult("ok") { StatusCode = 200 };
        }
    }


}