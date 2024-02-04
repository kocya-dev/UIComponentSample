namespace UIComponent
{
    partial class StackDataContainer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._flowLayoutPanelDataContainer = new System.Windows.Forms.FlowLayoutPanel();
            this._tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this._panelAddArea = new System.Windows.Forms.Panel();
            this._buttonAdd = new System.Windows.Forms.Button();
            this._tableLayoutPanelMain.SuspendLayout();
            this._panelAddArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // _flowLayoutPanelDataContainer
            // 
            this._flowLayoutPanelDataContainer.AutoSize = true;
            this._flowLayoutPanelDataContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._flowLayoutPanelDataContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flowLayoutPanelDataContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this._flowLayoutPanelDataContainer.Location = new System.Drawing.Point(3, 3);
            this._flowLayoutPanelDataContainer.Name = "_flowLayoutPanelDataContainer";
            this._flowLayoutPanelDataContainer.Size = new System.Drawing.Size(227, 1);
            this._flowLayoutPanelDataContainer.TabIndex = 0;
            // 
            // _tableLayoutPanelMain
            // 
            this._tableLayoutPanelMain.AutoSize = true;
            this._tableLayoutPanelMain.ColumnCount = 1;
            this._tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tableLayoutPanelMain.Controls.Add(this._flowLayoutPanelDataContainer, 0, 0);
            this._tableLayoutPanelMain.Controls.Add(this._panelAddArea, 0, 1);
            this._tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this._tableLayoutPanelMain.Name = "_tableLayoutPanelMain";
            this._tableLayoutPanelMain.RowCount = 2;
            this._tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this._tableLayoutPanelMain.Size = new System.Drawing.Size(233, 66);
            this._tableLayoutPanelMain.TabIndex = 1;
            // 
            // _panelAddArea
            // 
            this._panelAddArea.AutoSize = true;
            this._panelAddArea.Controls.Add(this._buttonAdd);
            this._panelAddArea.Dock = System.Windows.Forms.DockStyle.Top;
            this._panelAddArea.Location = new System.Drawing.Point(3, 9);
            this._panelAddArea.MinimumSize = new System.Drawing.Size(80, 48);
            this._panelAddArea.Name = "_panelAddArea";
            this._panelAddArea.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this._panelAddArea.Size = new System.Drawing.Size(227, 48);
            this._panelAddArea.TabIndex = 1;
            // 
            // _buttonAdd
            // 
            this._buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._buttonAdd.Location = new System.Drawing.Point(79, 11);
            this._buttonAdd.Name = "_buttonAdd";
            this._buttonAdd.Size = new System.Drawing.Size(63, 31);
            this._buttonAdd.TabIndex = 0;
            this._buttonAdd.Text = "+";
            this._buttonAdd.UseVisualStyleBackColor = true;
            this._buttonAdd.Click += new System.EventHandler(this._buttonAdd_Click);
            // 
            // StackDataContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this._tableLayoutPanelMain);
            this.Name = "StackDataContainer";
            this.Size = new System.Drawing.Size(233, 66);
            this._tableLayoutPanelMain.ResumeLayout(false);
            this._tableLayoutPanelMain.PerformLayout();
            this._panelAddArea.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel _flowLayoutPanelDataContainer;
        private TableLayoutPanel _tableLayoutPanelMain;
        private Panel _panelAddArea;
        private Button _buttonAdd;
    }
}