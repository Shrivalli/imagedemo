using ImageDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageDemo.Filters
{
    public class CustomActionFilter : Attribute, IActionFilter
    {
       // public int Order { get; set; }
        public void OnActionExecuting(ActionExecutingContext context)
        {
            //var param = context.ActionArguments.SingleOrDefault(p => p.Value is Student);
          
           // if (param.Value == null)
           // {
           //     context.Result = new BadRequestObjectResult("Object is null");
           //     return;
           // }

           // if (!context.ModelState.IsValid)
           // {
           //     context.Result = new BadRequestObjectResult(context.ModelState);
           // }
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            //To do : after the action executes  
        }
    }
}
