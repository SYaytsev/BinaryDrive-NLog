using Drive.WebHost.Infrastructure.Context;
using NLog;
using NLog.Targets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Drive.WebHost.Controllers
{
    public class HomeController : Controller
    {
        private Logger logger;
        private DriveContext context;
        public HomeController()
        {
            /*
            DatabaseTarget target = new DatabaseTarget();
            DatabaseParameterInfo param;
            target.ConnectionStringName = "DriveContext";
            target.DBDatabase = "DriveDB";
            target.CommandText = "insert into LogEntries(Date, Level, Logger, Message) values(@Date, @Level, @Logger, @Message);";

            param = new DatabaseParameterInfo();
            param.Name = "@Date";
            param.Layout = "${Date}";
            target.Parameters.Add(param);

            param = new DatabaseParameterInfo();
            param.Name = "@Level";
            param.Layout = "${Level}";
            target.Parameters.Add(param);

            param = new DatabaseParameterInfo();
            param.Name = "@Logger";
            param.Layout = "${Logger}";
            target.Parameters.Add(param);

            param = new DatabaseParameterInfo();
            param.Name = "@Message";
            param.Layout = "${Message}";
            target.Parameters.Add(param);

            NLog.Config.SimpleConfigurator.ConfigureForTargetLogging(target, LogLevel.Info);
            */

            context = new DriveContext();
            logger = LogManager.GetCurrentClassLogger();
            logger.Info("Home Controller");
            context.SaveChanges();         
        }

        public ActionResult Index()
        {
            logger.Info("Index action");
            return View();
        }
    }
}