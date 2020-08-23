namespace Common.MapStyle
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Reflection;
    public class XamarinMapStyle
    {
        public string Text;

        public XamarinMapStyle()
        {
            Read();
        }

        private void Read()
        {
            try
            {
                var assembly = IntrospectionExtensions.GetTypeInfo(typeof(XamarinMapStyle)).Assembly;
                Stream stream = assembly.GetManifestResourceStream("ronaldris.Maps.MapStyle.MapStyleBrot.json");

                using (var reader = new System.IO.StreamReader(stream))
                {
                    var json = reader.ReadToEnd();

                    this.Text = json;
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
