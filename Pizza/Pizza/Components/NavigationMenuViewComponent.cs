﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pizza.Models;

namespace Pizza.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IStoreRepository repository;

        public NavigationMenuViewComponent(IStoreRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            return View(repository.Products
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }

        
    }
}
