using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCSO.GeoBlazor.Test
{
    public class AppSettings
    {
        public string ArcGISApiKey { get; set; } = null!;
        public GeoBlazorSettings GeoBlazor { get; set; } = null!;
    }
    public class GeoBlazorSettings
    {
        public string LicenseKey { get; set; } = null!;
        public string MauiAppName { get; set; } = null!;
    }
}
