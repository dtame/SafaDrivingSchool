using static SafaEngine.Core.Ennumarations;

namespace SafaEngine.Context
{
    public class AdminContext : BaseContext
    {
        public AdminContext()
        {
            Role = UserRole.ADMIN;
        }        
    }
}
