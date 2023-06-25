// not need to do anything with the controller
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace coustom
{
    public static class CoustomHelpers // for coustomHtmlHelper the class and the method must be static
    {
        public static IHtmlString Image(string src, string alt) //1st way to create img_Html_helper
        {
            return new MvcHtmlString(string.Format("<img src='{0}' alt='{1}'> </img>", src, alt));
        }
        public static IHtmlString Img(this HtmlHelper helper, string src, string alt) //2nd way to create img_Html_helper
        {
            return new MvcHtmlString(string.Format("<img src='{0}' alt='{1}'> </img>", src, alt));
        }
        public static IHtmlString ImgTag(this HtmlHelper helper, string src, string alt)//3rd way to create img_Html_helper
        { 
            TagBuilder tag = new TagBuilder("img");
            tag.Attributes.Add("src", src);
            tag.Attributes.Add("alt", alt);
            return new MvcHtmlString(tag.ToString());
        }
    }
}
