﻿using System.Web.Mvc;

namespace AttributeRouting.Specs.Subjects
{
    [RouteArea("Area")]
    [RoutePrefix("Prefix")]
    public class TranslationController : Controller
    {
        [GET("Index")]
        public ActionResult Index()
        {
            return Content("content");
        }
    }

    [RouteArea("CustomArea", TranslationKey = "CustomAreaKey")]
    [RoutePrefix("CustomPrefix", TranslationKey = "CustomPrefixKey")]
    public class TranslationWithCustomKeysController : Controller
    {
        [GET("CustomIndex", TranslationKey = "CustomRouteKey")]
        public ActionResult CustomIndex()
        {
            return Content("content");
        }
    }

    [RoutePrefix("Translate/Actions")]
    public class TranslateActionsController : Controller
    {
        [GET("Index")]
        public ActionResult Index(int id = 1)
        {
            return Content("content");
        }
    }
}
