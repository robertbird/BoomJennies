
namespace Mello.ImageGallery.Models.Plugins.BootstrapLightbox
{
    public class BootstrapLightboxResourceDescriptor : PluginResourceDescriptor 
    {
        public BootstrapLightboxResourceDescriptor()
        {
            AddStyle("css/ModalGallery.css");
            AddScript("js/load-image.js");
            AddScript("js/ModalGallery.js");
        }

        public override string PluginName {
            get { return "BootstrapLightbox"; }
        }
    }
}