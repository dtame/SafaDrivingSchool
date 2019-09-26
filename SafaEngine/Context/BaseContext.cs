using SafaEngine.Core;
using System;
using System.Collections.Generic;
using System.Text;
using static SafaEngine.Core.Ennumarations;

namespace SafaEngine.Context
{
    public abstract class BaseContext
    {
        public UserRole Role { get; set; }
        public UserProfile Profile { get; set; }
    }
}
