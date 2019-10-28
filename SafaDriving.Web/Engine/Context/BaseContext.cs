using SafaDriving.Web.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SafaDriving.Web.Engine.Context
{
    public abstract class BaseContext
    {
        public UserRole Role { get; set; }
        public ApplicationUser Profile { get; set; }
    }
}
