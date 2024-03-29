﻿using LotusDijital.WebUI.Areas.Admin.Data;
using LotusDijital.WebUI.Data;
using LotusDijital.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace LotusDijital.WebUI.ViewComponents
{
    public class NavbarViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var pageList = await PageDAL.PageList();
            var categoryList = await CategoryDAL.GetCategoriesWithProducts();
            var settings = await SettingsDAL.GetSettings(1);
            var navbarModel = new NavbarModel()
            {
                Categories = categoryList,
                Pages = pageList,
                Settings = settings
            };
            return View(navbarModel);
        }
    }
}
