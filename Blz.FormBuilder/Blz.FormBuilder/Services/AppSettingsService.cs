using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blz.FormBuilder.Services
{
    public class AppSettingsService
    {
        private readonly IConfiguration _config;
        public AppSettingsService(IConfiguration config)
        {
            _config = config;
        }
        public string GetBaseUrl()
        {
            return _config.GetValue<string>("MySettings:BaseUrl");
        }
    }
}
