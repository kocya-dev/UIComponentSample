namespace UIComponent
{
    public partial class StackDataContainer : UserControl
    {
        private int index = -1;
        public event EventHandler<StackDataEventArgs> ItemAdded = delegate { };
        public event EventHandler<StackDataEventArgs> ItemRemoved = delegate { };
        public event EventHandler<StackDataEventArgs> ItemSelectChanged = delegate { };

        public StackDataContainer()
        {
            InitializeComponent();
        }

        private void _buttonAdd_Click(object sender, EventArgs e)
        {
            var item = new StackDataItem(++index);
            ItemAdded(this, new StackDataEventArgs(item));
            item.RemoveRequested += Item_RemoveRequested;
            item.CheckedChanged += Item_CheckedChanged;
            _flowLayoutPanelDataContainer.Controls.Add(item);
        }

        private void Item_RemoveRequested(object? sender, StackDataEventArgs e)
        {
            _flowLayoutPanelDataContainer.Controls.Remove(e.Item);
            e.Item.RemoveRequested -= Item_RemoveRequested;
            ItemRemoved(this, new StackDataEventArgs(e.Item));
        }

        private void Item_CheckedChanged(object? sender, StackDataEventArgs e)
        {
            foreach (var control in _flowLayoutPanelDataContainer.Controls)
            {
                if (control == e.Item) continue;
                var item = control as StackDataItem;
                if (item != null) item.Checked = false;
            }
        }
    }
}