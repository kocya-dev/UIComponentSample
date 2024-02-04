using UIComponent;

namespace UIComponentSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void _checkBox_CheckStateChanged(object sender, EventArgs e)
        {
            TestValueType type = _checkBox.Checked ? TestValueType.Hex : TestValueType.Decimal;
            _textValueBox1.TestValueType = type;
            _textValueBox2.TestValueType = type;
        }
    }
}