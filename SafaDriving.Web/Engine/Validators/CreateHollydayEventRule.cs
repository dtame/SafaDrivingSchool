namespace SafaDriving.Web.Engine.Validators
{
    public class CreateHollydayEventRule : BaseRule
    {
         
        public CreateHollydayEventRule()
        {            
            Description = "CreateHollydayEventRule";
        }
        public override bool IsValid()
        {            
            if (Context.Role == UserRole.Admin) return true;
            else  return false;
        }
    }
}
