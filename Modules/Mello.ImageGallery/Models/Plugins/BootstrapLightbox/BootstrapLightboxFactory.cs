
namespace Mello.ImageGallery.Models.Plugins.BootstrapLightbox
{
    public class BootstrapLightboxFactory : PluginFactory 
    {
        public BootstrapLightboxFactory()
        {
            _plugin = new BootstrapLightbox(new BootstrapLightboxSettings());
            _pluginResourceDescriptor = new BootstrapLightboxResourceDescriptor();
        }

        private readonly ImageGalleryPlugin _plugin;

        private readonly PluginResourceDescriptor _pluginResourceDescriptor;

        public override ImageGalleryPlugin Plugin {
            get { return _plugin; }
        }

        public override PluginResourceDescriptor PluginResourceDescriptor {
            get { return _pluginResourceDescriptor; }
        }
    }
}