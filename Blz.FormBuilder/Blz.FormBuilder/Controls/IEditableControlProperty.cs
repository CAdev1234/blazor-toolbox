using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blz.FormBuilder.Controls
{
    public class IEditableControlProperty : ComponentBase
    {
        [Parameter]
        public string IName { get; set; }
        [Parameter]
        public string IBgColor { get; set; }
        [Parameter]
        public int Index { get; set; }

        public void GetPropertyEditor_EditableProperties(string name, string bgcolor)
        {
            this.IName = name;
            this.IBgColor = bgcolor;
        }
    }
}
