namespace UIComponentSample
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            stackDataContainer1 = new UIComponent.StackDataContainer();
            _textValueBox1 = new UIComponent.TextValueBox();
            _checkBox = new CheckBox();
            _textValueBox2 = new UIComponent.TextValueBox();
            SuspendLayout();
            // 
            // stackDataContainer1
            // 
            stackDataContainer1.AutoSize = true;
            stackDataContainer1.Location = new Point(12, 12);
            stackDataContainer1.Name = "stackDataContainer1";
            stackDataContainer1.Size = new Size(311, 281);
            stackDataContainer1.TabIndex = 0;
            // 
            // _textValueBox1
            // 
            _textValueBox1.ForeColor = Color.Black;
            _textValueBox1.Location = new Point(509, 52);
            _textValueBox1.Name = "_textValueBox1";
            _textValueBox1.Size = new Size(100, 23);
            _textValueBox1.TabIndex = 1;
            _textValueBox1.TestValueType = UIComponent.TestValueType.Decimal;
            _textValueBox1.Text = "0";
            // 
            // _checkBox
            // 
            _checkBox.AutoSize = true;
            _checkBox.Location = new Point(509, 27);
            _checkBox.Name = "_checkBox";
            _checkBox.Size = new Size(74, 19);
            _checkBox.TabIndex = 2;
            _checkBox.Text = "16進表記";
            _checkBox.UseVisualStyleBackColor = true;
            _checkBox.CheckStateChanged += _checkBox_CheckStateChanged;
            // 
            // _textValueBox2
            // 
            _textValueBox2.ForeColor = Color.Black;
            _textValueBox2.Location = new Point(509, 81);
            _textValueBox2.Name = "_textValueBox2";
            _textValueBox2.Size = new Size(100, 23);
            _textValueBox2.TabIndex = 3;
            _textValueBox2.TestValueType = UIComponent.TestValueType.Decimal;
            _textValueBox2.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(_textValueBox2);
            Controls.Add(_checkBox);
            Controls.Add(_textValueBox1);
            Controls.Add(stackDataContainer1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private UIComponent.StackDataContainer stackDataContainer1;
        private UIComponent.TextValueBox _textValueBox1;
        private CheckBox _checkBox;
        private UIComponent.TextValueBox _textValueBox2;
    }
}