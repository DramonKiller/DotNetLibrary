using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dramonkiller.WindowsFormsLibrary
{
    public static class ControlExtensions
    {
        public static void ExecuteThreadSafe<T>(this T control, Action<T> action) where T : Control
        {
            if (control == null)
            {
                throw new ArgumentNullException("control");
            }

            if (control.InvokeRequired)
            {
                control.Invoke(action); 
            }
            else
            {
                action.Invoke(control); 
            }
        }
    }
}
