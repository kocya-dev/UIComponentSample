using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIComponent
{
    public enum TestValueType
    {
        Decimal,
        Hex,
    }
    public partial class TextValueBox : TextBox
    {
        private TestValueType _testValueType = TestValueType.Decimal;
        public TestValueType TestValueType
        {
            get => _testValueType;
            set
            {
                _testValueType = value;
                UpdateValue(Value);
            }
        }
        public ulong Value { get; private set; } = 0;
        private NumberStyles ConvertValueType => TestValueType == TestValueType.Decimal ? NumberStyles.Integer : NumberStyles.HexNumber;
        private bool IsInvalid => ForeColor == Color.Red;

        public TextValueBox()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            Text2Value();
        }


        public void UpdateValue(ulong value) {
            Value2Text(value);

        }
        private void Value2Text(ulong value)
        {
            Value = value;
            Text = (ConvertValueType == NumberStyles.HexNumber)
                    ? string.Format($"0x{value:X}")
                    : string.Format($"{value}");
        }
        private void Text2Value()
        {
            string target = ConvertValueType == NumberStyles.HexNumber ? Text.Replace("0x", null) : Text;
            ulong result = 0;
            if (ulong.TryParse(target, ConvertValueType, null, out result))
            {
                Value = result;
                ForeColor = Color.Black;
            }
            else
            {
                ForeColor = Color.Red;
            }
        }
    }
}
