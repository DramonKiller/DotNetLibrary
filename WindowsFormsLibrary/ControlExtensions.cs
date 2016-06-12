using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dramonkiller.WindowsFormsLibrary
{
    /// <summary>
    /// Class that contains the control extensions.
    /// </summary>
    public static class ControlExtensions
    {
        /// <summary>
        /// Executes the action checking if the current thread is the UI thread or not. 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="control"> The control. </param>
        /// <param name="action"> The action method. </param>
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
