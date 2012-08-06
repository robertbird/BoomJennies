namespace Mello.ImageGallery.Models.Plugins.BootstrapLightbox 
{
    public class BootstrapLightbox : ImageGalleryPlugin 
    {
        private readonly BootstrapLightboxSettings _settings;

        public BootstrapLightbox(BootstrapLightboxSettings bootstrapLightboxSettings)
        {
            _settings = bootstrapLightboxSettings;
        }

        public override string ToString(string cssSelector) {
            return ""; //string.Format("$('{0}').prettyPhoto({1});", cssSelector, _settings);
        }


        public override string AdditionalHrefMarkup(string imageGalleryName) {
          return string.Format("rel='gallery'"); 
        }
        
        public override string ImageGalleryTemplateName {
          get { return "Parts/Plugins/BootstrapLightbox"; }
        }
    }
}