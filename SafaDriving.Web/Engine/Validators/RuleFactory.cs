using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SafaDriving.Web.Engine.Validators
{
    public static class RuleFactory
    {        
        public static List<BaseRule> GetRule(UserRole role, ILogger _logger)
        {
            List<BaseRule> rules = new List<BaseRule>();
            switch (role)
            {
                case UserRole.Student:
                    rules.Add(new LoggedRule(new CreateHollydayEventRule(), _logger));
                    break;
                case UserRole.Admin:
                    break;
                case UserRole.Instructor:
                    break;
            }

            return rules;
        }
    }
}
