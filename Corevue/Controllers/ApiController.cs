// //-----------------------------------------------------------------------
// // <copyright file="ApiController.cs" company="ImprovingEnterprises">
// //     Copyright (c) ImprovingEnterprises. All rights reserved.
// // </copyright>
// // <author>Martin Fracker</author>
// //-----------------------------------------------------------------------

using Microsoft.AspNetCore.Mvc;

namespace Corevue.Controllers
{
    [Controller]
    public class ApiController
    {
        [ActionContext]
        public ActionContext ActionContext { get; set; }
    }
}