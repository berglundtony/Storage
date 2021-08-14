using Microsoft.AspNetCore.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Storage.htmlHelpers
{
    public class BootstrapHtml
    {
        public static HtmlString Dropdown(string id, List<SelectListItem> selectListItems, string label)
        {
            var button = new TagBuilder("button")
            {
                Attributes =
            {
                {"id", id},
                {"type", "button"},
                {"data-toggle", "dropdown"}
            }
            };

            button.AddCssClass("btn");
            button.AddCssClass("btn-default");
            button.AddCssClass("dropdown-toggle");

            button.SetInnerText(label);
            // button.InnerHtml.Append(" " + label);
            // button.InnerHtml.AppendHtml(BuildCaret());

            button.InnerHtml += " " + BuildCaret();

            var wrapper = new TagBuilder("div");
            wrapper.AddCssClass("dropdown");

            //wrapper.InnerHtml.AppendHtml(button);
            //wrapper.InnerHtml.AppendHtml(BuildDropdown(id, selectListItems));

            wrapper.InnerHtml += button;
            wrapper.InnerHtml += BuildDropdown(id, selectListItems);

            return new HtmlString(wrapper.ToString());


        }

        private static TagBuilder BuildCaret()
        {
            var caret = new TagBuilder("span");
            caret.AddCssClass("caret");

            return caret;
        }

        private static TagBuilder BuildDropdown(string id, IEnumerable<SelectListItem> items)
        {
            var list = new TagBuilder("ul")
            {
                Attributes =
            {
                {"class", "dropdown-menu"},
                {"role", "menu"},
                {"aria-labelledby", id}
            }
            };

            var listItem = new TagBuilder("li");
            listItem.Attributes.Add("role", "presentation");

            foreach (var item in items)
            {
                list.InnerHtml += "<li role=\"presentation\">" + BuildListRow(item) + "</li>";
            }
            //items.ForEach(x => list.InnerHtml += "<li role=\"presentation\">" + BuildListRow(x) + "</li>");

            return list;
        }

        private static string BuildListRow(SelectListItem item)
        {
            var anchor = new TagBuilder("a")
            {
                Attributes =
            {
                {"role", "menuitem"},
                {"tabindex", "-1"},
                {"href", item.Value}
            }
            };

            anchor.SetInnerText(item.Text);
            return anchor.ToString();

        }
    }
}



