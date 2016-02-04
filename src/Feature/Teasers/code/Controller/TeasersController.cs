﻿namespace Sitecore.Feature.Teasers.Controller
{
  using System.Web.Mvc;
  using Sitecore.Feature.Teasers.Models;
  using Sitecore.Mvc.Presentation;

  public class TeasersController : Controller
  {
    public ActionResult AccordeonTeaser()
    {
      var model = new AccordeonModel();
      return this.View("AccordeonTeaser", model);
    }
  }
}