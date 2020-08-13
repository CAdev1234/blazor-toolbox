using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blz.FormBuilder.Controls
{
    public interface IEditorControl
    //:IFormControl
    {
        [Parameter]
        public int Index { get; set; }

        [Parameter]
        public FormControl CurrentForm { get; set; }

        bool IsDroppableArea_Above_EditorControl { get; set; }
        bool IsDroppableArea_Below_EditorControl { get; set; }
        void OnDragStart();

    }
}
