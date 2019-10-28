using Microsoft.Extensions.Logging;
using System;

namespace SafaDriving.Web.Engine.Validators
{
    public class LoggedRule : BaseRule
    {
        private BaseRule rule;
        private readonly ILogger _logger;
        public LoggedRule(BaseRule baseRule, ILogger logger)
        {
            rule = baseRule;
        }

        public override bool IsValid()
        {
            try {
                return rule.IsValid();
            }catch(Exception ex) {
                _logger.LogError($"Error occur during rule validation for {rule.Description}" + ex.ToString());
                return false;
            }            
        }
    }
}
