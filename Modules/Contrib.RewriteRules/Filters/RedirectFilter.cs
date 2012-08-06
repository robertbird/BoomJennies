using System.Web.Mvc;
using Contrib.RewriteRules.Exceptions;
using Contrib.RewriteRules.Models;
using Contrib.RewriteRules.Services;
using Orchard;
using Orchard.ContentManagement;
using Orchard.Logging;
using Orchard.Mvc.Filters;
using Orchard.Services;

namespace Contrib.RewriteRules.Filters {
    public class RedirectFilter : FilterProvider, IActionFilter {
        private readonly IOrchardServices _services;
        private readonly IClock _clock;

        public RedirectFilter(IOrchardServices services, IClock clock) {
            _services = services;
            _clock = clock;
            Logger = NullLogger.Instance;
        }

        public ILogger Logger { get; set; }

        public void OnActionExecuted(ActionExecutedContext filterContext) { }

        public void OnActionExecuting(ActionExecutingContext filterContext) {

            var settings = _services.WorkContext.CurrentSite.As<RedirectSettingsPart>();
            
            if (settings == null || !settings.Enabled) {
                return;
            }

            try {
                var interpretter = new RulesInterpreter(_clock);
                filterContext.Result = interpretter.Interpret(filterContext.HttpContext, settings.Rules) ?? filterContext.Result;
            }
            catch(RuleEvaluationException e) {
                Logger.Error("Rewrite rule evaluation failed for url {0} on rule {1} with message: ", e.Url, e.Rule, e.Message);
            }
        }
    }
}