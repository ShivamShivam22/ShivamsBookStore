﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShivamsBooks.Models.ViewModels
{
    public class ProductVM
    {
        public IEnumerable<SelectListItem> CoverTypeList;

        public Product Product { get; set;  }   // Displays all the product details.
        public IEnumerable<SelectListItem> CategoryList { get; set; }   //install package Microsoft.AspNetCore.Mvc.ViewFeatures.
        public IEnumerable<SelectListItem> CoverType { get; set; }
    }
}
