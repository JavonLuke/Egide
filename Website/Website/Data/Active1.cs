using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Website.Models;

namespace Website.Data
{

    public static class Active1
    {
        public static string IsActive(this HtmlHelper html,
                                      string control,
                                      string action)
        {
            var routeData = html.ViewContext.RouteData;

            var routeAction = (string)routeData.Values["action"];
            var routeControl = (string)routeData.Values["controller"];

            // both must match
            var returnActive = control == routeControl &&
                               action == routeAction;

            return returnActive ? "active" : "";
        }

        public static Clothing getSingleProduct(int id)
        {
            Clothing[] clothing = getProduct();
            return clothing[id];
        }
        public static Clothing[] getProduct()
        {
            Clothing[] clothing = new Clothing[]
            {
                new Clothing()
                {
                    Id = 1,
                    Name = "Second Clothing",
                    Size = "Extra Large"
                },
                  new Clothing()
                {
                    Id = 2,
                                        Name = "first",
                    Size = "Extra Large"

                },
                      new Clothing()
                {
                    Id = 3,
                    Name = "Second Clothing",
                    Size = "Extra Large"
                },
                  new Clothing()
                {
                    Id = 2,
                    Name = "Second Clothing",
                    Size = "Extra Large"
                },
                      new Clothing()
                {
                    Id = 1,
                    Name = "Second Clothing",
                    Size = "Extra Large"
                },
                  new Clothing()
                {
                    Id = 2,
                    Name = "Second Clothing",
                    Size = "Extra Large"
                },
                      new Clothing()
                {
                    Id = 1,
                    Name = "Second Clothing",
                    Size = "Extra Large"
                },
                  new Clothing()
                {
                    Id = 2,
                    Name = "Second Clothing",
                    Size = "Extra Large"
                }
        };

            return clothing;
        }

        public static List<Clothing> search(string searchString)
        {
            //the thing that it will search through is the whole site - all of the items that you are selecting 

            //it will compate them based on their name 

            List<Clothing> returnClothing = new List<Clothing>();
            foreach (Clothing cloth in getProduct())
            {
                if (cloth.Name.Equals(searchString))
                {
                    returnClothing.Add(cloth);
                }
            }
            return returnClothing;
        }
    }

    //what other 

}