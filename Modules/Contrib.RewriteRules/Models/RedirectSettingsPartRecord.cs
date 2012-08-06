using Orchard.ContentManagement.Records;

namespace Contrib.RewriteRules.Models {
    public class RedirectSettingsPartRecord : ContentPartRecord {
        public virtual bool Enabled { get; set; }
        public virtual string Rules { get; set; }
    }
}