using Esri.ArcGISRuntime.Mapping;
using Esri.ArcGISRuntime.UI.Controls;
using System.Configuration;
using System.Data;
using System.Windows;

namespace ArcGIS
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Esri.ArcGISRuntime.ArcGISRuntimeEnvironment.ApiKey = "<API Key>";

        }
    }

}
