using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Website.Models
{
    public class Clothing
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }


        public string ImageName
        {
            get
            {
                return (Name.Replace(" ", "-") + Size.Replace(" ", "-")).ToLower() + ".jpg";
            }
        }



    }
}