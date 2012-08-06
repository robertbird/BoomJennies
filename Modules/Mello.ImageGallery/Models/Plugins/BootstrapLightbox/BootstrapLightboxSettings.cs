using System.Text;

namespace Mello.ImageGallery.Models.Plugins.BootstrapLightbox
{
    public class BootstrapLightboxSettings
    {
        public override string ToString() 
        {
            StringBuilder stringBuilder = new StringBuilder("{");
            stringBuilder.AppendLine(string.Concat("slideshow: ", "false", " ,"));
            stringBuilder.Append(string.Concat("autoplay_slideshow: ", "false", ""));
            stringBuilder.Append("}");

            return stringBuilder.ToString();
        }
    }
}