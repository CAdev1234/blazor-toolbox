using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blz.FormBuilder.Services
{
    public class AppData
    {
        public List<string> g_headerControlName { get; set; }
        public string g_headerControlBg { get; set; }
        public List<string> g_textEntryName { get; set; }
        public string g_textEntryBg { get; set; }

        public AppData()
        {
            this.g_headerControlName = new List<string>();
            this.g_textEntryName = new List<string>();
        }

        public event Action OnChange;

        public void SetHeaderBg(string bg_color) {
            g_headerControlBg = bg_color;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
