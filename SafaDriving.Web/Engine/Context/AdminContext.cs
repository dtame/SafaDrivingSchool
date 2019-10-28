
namespace SafaDriving.Web.Engine.Context
{
    public class AdminContext : BaseContext
    {
        public AdminContext()
        {
            Role = UserRole.Admin;
        }        
    }
}
