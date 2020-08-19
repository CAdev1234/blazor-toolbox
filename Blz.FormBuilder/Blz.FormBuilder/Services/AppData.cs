using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blz.FormBuilder.Services
{
    public class AppData
    {
        public static List<string> g_headerControlName { get; set; }
        public static string g_headerControlBg { get; set; }
        public static List<string> g_textEntryName { get; set; }
        public static string g_textEntryBg { get; set; }
        public static int g_dropIndex { get; set; }
        public static Boolean g_dropActive { get; set; } = false;
    }
}
