using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Blz.FormBuilder.Controls
{
    public class BaseEditorControl : ComponentBase
    {
        public void OnDragStart()
        {
            CurrentForm.CurrentDragIndex = this.Index;
            Console.WriteLine("CurrentDragIndex");
            Console.WriteLine(Index);
        }

        public void HandleDrop()
        {
            CSSClass = "";
            if (CurrentForm.CurrentDragIndex == -1) return;
            Console.WriteLine("Drop Index " + Index);
            Console.WriteLine("Drag Index " + CurrentForm.CurrentDragIndex);

            if (CurrentForm.CurrentDragIndex != Index && CurrentForm.CurrentDragIndex+1 != Index)
                CurrentForm.MovingControl(Index);
        }

        public bool IsDroppableArea_Above_EditorControl { get; set; }
        public bool IsDroppableArea_Below_EditorControl { get; set; }
        [Parameter]
        public int Index { get; set; }
        [Parameter]
        public FormControl CurrentForm { get; set; }

        public string CSSClass = "";
        public string HighlightCss = "";
        public void HandleDragEnter()
        {
            CSSClass = "dropzoneActive";
        }
        public void HandleDragLeave()
        {
            CSSClass = "";
        }
    }
}
