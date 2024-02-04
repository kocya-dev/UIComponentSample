using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIComponent
{
    public partial class StackDataItem : UserControl
    {
        public int Index { get; private set; }
        public bool Checked
        {
            get => _checkBox.Checked;
            set => _checkBox.Checked = value;
        }
        public string ItemText
        {
            get => _checkBox.Text;
            set => _checkBox.Text = value;
        }

        public event EventHandler<StackDataEventArgs> CheckedChanged = delegate { };
        public event EventHandler<StackDataEventArgs> RemoveRequested = delegate { };
        public StackDataItem(int index)
        {
            InitializeComponent();
            Index = index;
        }

        private void _buttonRemove_Click(object sender, EventArgs e)
        {
            RemoveRequested(this, new StackDataEventArgs(this));
        }

        private void _checkBox_Click(object sender, EventArgs e)
        {
            if (Checked) return;
            CheckedChanged(this, new StackDataEventArgs(this));
        }
    }
}
