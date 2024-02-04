namespace UIComponent
{
    partial class StackDataItem
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this._checkBox = new System.Windows.Forms.CheckBox();
            this._tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this._buttonRemove = new System.Windows.Forms.Button();
            this._tableLayoutPanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // _checkBox
            // 
            this._checkBox.Appearance = System.Windows.Forms.Appearance.Button;
            this._checkBox.AutoSize = true;
            this._checkBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._checkBox.Location = new System.Drawing.Point(0, 0);
            this._checkBox.Margin = new System.Windows.Forms.Padding(0);
            this._checkBox.Name = "_checkBox";
            this._checkBox.Size = new System.Drawing.Size(207, 48);
            this._checkBox.TabIndex = 0;
            this._checkBox.Text = "text";
            this._checkBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._checkBox.UseVisualStyleBackColor = true;
            this._checkBox.Click += new System.EventHandler(this._checkBox_Click);
            // 
            // _tableLayoutPanelMain
            // 
            this._tableLayoutPanelMain.ColumnCount = 2;
            this._tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.97536F));
            this._tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.02463F));
            this._tableLayoutPanelMain.Controls.Add(this._checkBox, 0, 0);
            this._tableLayoutPanelMain.Controls.Add(this._buttonRemove, 1, 0);
            this._tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this._tableLayoutPanelMain.Name = "_tableLayoutPanelMain";
            this._tableLayoutPanelMain.RowCount = 1;
            this._tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tableLayoutPanelMain.Size = new System.Drawing.Size(244, 48);
            this._tableLayoutPanelMain.TabIndex = 1;
            // 
            // _buttonRemove
            // 
            this._buttonRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this._buttonRemove.Location = new System.Drawing.Point(207, 0);
            this._buttonRemove.Margin = new System.Windows.Forms.Padding(0);
            this._buttonRemove.Name = "_buttonRemove";
            this._buttonRemove.Size = new System.Drawing.Size(37, 48);
            this._buttonRemove.TabIndex = 1;
            this._buttonRemove.Text = "×";
            this._buttonRemove.UseVisualStyleBackColor = true;
            this._buttonRemove.Click += new System.EventHandler(this._buttonRemove_Click);
            // 
            // StackDataItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._tableLayoutPanelMain);
            this.Name = "StackDataItem";
            this.Size = new System.Drawing.Size(244, 48);
            this._tableLayoutPanelMain.ResumeLayout(false);
            this._tableLayoutPanelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CheckBox _checkBox;
        private TableLayoutPanel _tableLayoutPanelMain;
        private Button _buttonRemove;
    }
}
