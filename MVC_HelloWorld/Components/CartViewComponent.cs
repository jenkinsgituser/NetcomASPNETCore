using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_HelloWorld.Components
{
    //[ViewComponent]
    //public class Cart
    //{

    //}

    [ViewComponent(Name ="CartView")]
    public class CartView:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var names = new List<string>
            { "Mona","Tim","James","Milind","Keren"};

            return View(names);
        }
        

    }

    //public class CartViewComponent
    //{
    //}
}
