namespace SPIF
{
    partial class FormSettings
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpAll = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitel = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cbCloseOnAdd = new System.Windows.Forms.CheckBox();
            this.cbFilter = new System.Windows.Forms.CheckBox();
            this.cbShowQuickSettings = new System.Windows.Forms.CheckBox();
            this.cbShowJokes = new System.Windows.Forms.CheckBox();
            this.cbMinimizeOnStartup = new System.Windows.Forms.CheckBox();
            this.tblTimer = new System.Windows.Forms.TableLayoutPanel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.nudTimer = new System.Windows.Forms.NumericUpDown();
            this.cbDarkTheme = new System.Windows.Forms.CheckBox();
            this.tlpAll.SuspendLayout();
            this.tblTimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpAll
            // 
            this.tlpAll.ColumnCount = 4;
            this.tlpAll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlpAll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlpAll.Controls.Add(this.lblTitel, 0, 0);
            this.tlpAll.Controls.Add(this.btnSubmit, 1, 9);
            this.tlpAll.Controls.Add(this.cbCloseOnAdd, 1, 2);
            this.tlpAll.Controls.Add(this.cbFilter, 1, 3);
            this.tlpAll.Controls.Add(this.cbShowQuickSettings, 1, 4);
            this.tlpAll.Controls.Add(this.cbShowJokes, 1, 6);
            this.tlpAll.Controls.Add(this.cbMinimizeOnStartup, 1, 5);
            this.tlpAll.Controls.Add(this.tblTimer, 1, 1);
            this.tlpAll.Controls.Add(this.cbDarkTheme, 1, 7);
            this.tlpAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAll.Location = new System.Drawing.Point(0, 0);
            this.tlpAll.Name = "tlpAll";
            this.tlpAll.RowCount = 11;
            this.tlpAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlpAll.Size = new System.Drawing.Size(332, 306);
            this.tlpAll.TabIndex = 0;
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.tlpAll.SetColumnSpan(this.lblTitel, 4);
            this.lblTitel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitel.Font = new System.Drawing.Font("Verdana", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.Location = new System.Drawing.Point(0, 0);
            this.lblTitel.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(332, 40);
            this.lblTitel.TabIndex = 0;
            this.lblTitel.Text = "NFH Settings";
            this.lblTitel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSubmit
            // 
            this.tlpAll.SetColumnSpan(this.btnSubmit, 2);
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Verdana", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(8, 264);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(316, 34);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Close";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cbCloseOnAdd
            // 
            this.cbCloseOnAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbCloseOnAdd.AutoSize = true;
            this.tlpAll.SetColumnSpan(this.cbCloseOnAdd, 2);
            this.cbCloseOnAdd.Font = new System.Drawing.Font("Verdana", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCloseOnAdd.Location = new System.Drawing.Point(8, 74);
            this.cbCloseOnAdd.Name = "cbCloseOnAdd";
            this.cbCloseOnAdd.Size = new System.Drawing.Size(271, 21);
            this.cbCloseOnAdd.TabIndex = 2;
            this.cbCloseOnAdd.Text = "Minimize NFH after adding a record";
            this.cbCloseOnAdd.UseVisualStyleBackColor = true;
            // 
            // cbFilter
            // 
            this.cbFilter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbFilter.AutoSize = true;
            this.tlpAll.SetColumnSpan(this.cbFilter, 2);
            this.cbFilter.Font = new System.Drawing.Font("Verdana", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilter.Location = new System.Drawing.Point(8, 104);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(306, 21);
            this.cbFilter.TabIndex = 3;
            this.cbFilter.Text = "Filter subject list based on project code";
            this.cbFilter.UseVisualStyleBackColor = true;
            // 
            // cbShowQuickSettings
            // 
            this.cbShowQuickSettings.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbShowQuickSettings.AutoSize = true;
            this.tlpAll.SetColumnSpan(this.cbShowQuickSettings, 2);
            this.cbShowQuickSettings.Font = new System.Drawing.Font("Verdana", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShowQuickSettings.Location = new System.Drawing.Point(8, 134);
            this.cbShowQuickSettings.Name = "cbShowQuickSettings";
            this.cbShowQuickSettings.Size = new System.Drawing.Size(206, 21);
            this.cbShowQuickSettings.TabIndex = 4;
            this.cbShowQuickSettings.Text = "Show quicksettings panel";
            this.cbShowQuickSettings.UseVisualStyleBackColor = true;
            // 
            // cbShowJokes
            // 
            this.cbShowJokes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbShowJokes.AutoSize = true;
            this.tlpAll.SetColumnSpan(this.cbShowJokes, 2);
            this.cbShowJokes.Font = new System.Drawing.Font("Verdana", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShowJokes.Location = new System.Drawing.Point(8, 194);
            this.cbShowJokes.Name = "cbShowJokes";
            this.cbShowJokes.Size = new System.Drawing.Size(109, 21);
            this.cbShowJokes.TabIndex = 6;
            this.cbShowJokes.Text = "Show jokes";
            this.cbShowJokes.UseVisualStyleBackColor = true;
            // 
            // cbMinimizeOnStartup
            // 
            this.cbMinimizeOnStartup.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbMinimizeOnStartup.AutoSize = true;
            this.tlpAll.SetColumnSpan(this.cbMinimizeOnStartup, 2);
            this.cbMinimizeOnStartup.Font = new System.Drawing.Font("Verdana", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMinimizeOnStartup.Location = new System.Drawing.Point(8, 164);
            this.cbMinimizeOnStartup.Name = "cbMinimizeOnStartup";
            this.cbMinimizeOnStartup.Size = new System.Drawing.Size(132, 21);
            this.cbMinimizeOnStartup.TabIndex = 5;
            this.cbMinimizeOnStartup.Text = "Add to startup";
            this.cbMinimizeOnStartup.UseVisualStyleBackColor = true;
            // 
            // tblTimer
            // 
            this.tblTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tblTimer.ColumnCount = 2;
            this.tlpAll.SetColumnSpan(this.tblTimer, 2);
            this.tblTimer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblTimer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblTimer.Controls.Add(this.lblTimer, 0, 0);
            this.tblTimer.Controls.Add(this.nudTimer, 1, 0);
            this.tblTimer.Location = new System.Drawing.Point(5, 40);
            this.tblTimer.Margin = new System.Windows.Forms.Padding(0);
            this.tblTimer.Name = "tblTimer";
            this.tblTimer.RowCount = 1;
            this.tblTimer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblTimer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblTimer.Size = new System.Drawing.Size(322, 30);
            this.tblTimer.TabIndex = 9;
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Verdana", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(3, 6);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(144, 17);
            this.lblTimer.TabIndex = 7;
            this.lblTimer.Text = "Popup Timer (min):";
            // 
            // nudTimer
            // 
            this.nudTimer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudTimer.Font = new System.Drawing.Font("Verdana", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTimer.Location = new System.Drawing.Point(153, 3);
            this.nudTimer.Name = "nudTimer";
            this.nudTimer.Size = new System.Drawing.Size(88, 25);
            this.nudTimer.TabIndex = 8;
            // 
            // cbDarkTheme
            // 
            this.cbDarkTheme.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbDarkTheme.AutoSize = true;
            this.tlpAll.SetColumnSpan(this.cbDarkTheme, 2);
            this.cbDarkTheme.Font = new System.Drawing.Font("Verdana", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDarkTheme.Location = new System.Drawing.Point(8, 224);
            this.cbDarkTheme.Name = "cbDarkTheme";
            this.cbDarkTheme.Size = new System.Drawing.Size(158, 21);
            this.cbDarkTheme.TabIndex = 10;
            this.cbDarkTheme.Text = "Enable dark theme";
            this.cbDarkTheme.UseVisualStyleBackColor = true;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 306);
            this.Controls.Add(this.tlpAll);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.TopMost = true;
            this.tlpAll.ResumeLayout(false);
            this.tlpAll.PerformLayout();
            this.tblTimer.ResumeLayout(false);
            this.tblTimer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpAll;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.CheckBox cbCloseOnAdd;
        private System.Windows.Forms.CheckBox cbFilter;
        private System.Windows.Forms.CheckBox cbShowQuickSettings;
        private System.Windows.Forms.CheckBox cbMinimizeOnStartup;
        private System.Windows.Forms.CheckBox cbShowJokes;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.NumericUpDown nudTimer;
        private System.Windows.Forms.TableLayoutPanel tblTimer;
        private System.Windows.Forms.CheckBox cbDarkTheme;
    }
}