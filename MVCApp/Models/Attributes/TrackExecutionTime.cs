using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp.Models
{
    public class TrackExecutionTime : ActionFilterAttribute, IExceptionFilter
    {
        LogTable logTable = new LogTable();
        Stopwatch sw;
        private readonly IDAL bll = new MyDal();

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            sw = Stopwatch.StartNew();
            logTable.ActionName = filterContext.ActionDescriptor.ActionName;
            logTable.StartTime = DateTime.Now;
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            logTable.ActionRunningTime = sw.Elapsed;
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            sw = Stopwatch.StartNew();
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            logTable.ViewRenderingTime = sw.Elapsed;
            logTable.GetPostName = filterContext.HttpContext.Request.HttpMethod;

            bll.AddLogTable(logTable);        
        }

        public void OnException(ExceptionContext filterContext)
        {
            string message = filterContext.RouteData.Values["controller"].ToString() + " -> " +
               filterContext.RouteData.Values["action"].ToString() + " -> " +
               filterContext.Exception.Message + " \t- " + DateTime.Now.ToString() + "\n";
            LogExecutionTime(message);
        }

        private void LogExecutionTime(string message)
        {
            File.AppendAllText(HttpContext.Current.Server.MapPath("~/ErrorLogs/ErrorLogs.txt"), message);
        }
    }
}