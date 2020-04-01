using My.Bom.Software.Helpers;
using System.IO;
using System.Reflection;
using System.Xml.Serialization;

namespace My.Bom.Software.Settings
{
    public class MainSettings
    {
        public string ConnectionString { get; set; }

        public static MainSettings ReadSettings()
        {
            string dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? Directory.GetCurrentDirectory();
            var loc = Path.Combine(dir, "Settings/settings.xml");

            if (!File.Exists(loc))
            {
                MessageHelper.DisplayError($"File with settings {loc} not found");
                throw new FileNotFoundException(loc);
            }
            var xml = new XmlSerializer(typeof(MainSettings));

            using (var stream = File.OpenRead(loc))
            {
                return (MainSettings)xml.Deserialize(stream);
            }
        }
    }
}
