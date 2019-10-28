using SafaDriving.Web.Engine.Context;

namespace SafaDriving.Web.Engine.Validators
{
    public abstract class BaseRule
    {
        protected BaseContext Context { get; set; }
        public string Description { get; set; }
        public virtual bool IsValid() { return false; } 
    }
}
