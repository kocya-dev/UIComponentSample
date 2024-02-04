using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIComponent
{
    public class StackDataEventArgs : EventArgs
    {
        public StackDataEventArgs(StackDataItem item)
        {
            Item = item;
        }

        public StackDataItem Item { get; set; }
    }
}
