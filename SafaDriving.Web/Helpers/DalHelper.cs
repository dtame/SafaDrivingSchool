using Microsoft.AspNetCore.Mvc.Rendering;
using SafaDriving.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SafaDriving.Web.Helpers
{
    public static class DalHelper
    {
        public static List<SelectListItem> ToListItems(this IEnumerable<DrivingProgram> programs)
        {
            List<SelectListItem> listItems = new List<SelectListItem>();
            foreach (var program in programs)
            {
                SelectListItem item = new SelectListItem { Value = program.ID.ToString(), Text = program.Name };
                listItems.Add(item);
            }
            return listItems;
        }
    }
}
