namespace SPIF
{
    partial class FormChangelog
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
            this.rtbChangelog = new System.Windows.Forms.RichTextBox();
            this.lblChangelog = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.tlpAll.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpAll
            // 
            this.tlpAll.ColumnCount = 3;
            this.tlpAll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAll.Controls.Add(this.rtbChangelog, 0, 1);
            this.tlpAll.Controls.Add(this.lblChangelog, 0, 0);
            this.tlpAll.Controls.Add(this.btnClose, 1, 2);
            this.tlpAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAll.Font = new System.Drawing.Font("Verdana", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpAll.Location = new System.Drawing.Point(0, 0);
            this.tlpAll.Name = "tlpAll";
            this.tlpAll.RowCount = 4;
            this.tlpAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlpAll.Size = new System.Drawing.Size(494, 406);
            this.tlpAll.TabIndex = 0;
            // 
            // rtbChangelog
            // 
            this.rtbChangelog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tlpAll.SetColumnSpan(this.rtbChangelog, 3);
            this.rtbChangelog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbChangelog.Location = new System.Drawing.Point(3, 43);
            this.rtbChangelog.MaxLength = 1000;
            this.rtbChangelog.Name = "rtbChangelog";
            this.rtbChangelog.Size = new System.Drawing.Size(488, 315);
            this.rtbChangelog.TabIndex = 0;
            this.rtbChangelog.Text = "";
            // 
            // lblChangelog
            // 
            this.lblChangelog.AutoSize = true;
            this.tlpAll.SetColumnSpan(this.lblChangelog, 3);
            this.lblChangelog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChangelog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblChangelog.Font = new System.Drawing.Font("Verdana", 9.163636F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangelog.Location = new System.Drawing.Point(0, 0);
            this.lblChangelog.Margin = new System.Windows.Forms.Padding(0);
            this.lblChangelog.Name = "lblChangelog";
            this.lblChangelog.Size = new System.Drawing.Size(494, 40);
            this.lblChangelog.TabIndex = 1;
            this.lblChangelog.Text = "Changelog:";
            this.lblChangelog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(23, 364);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(448, 34);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // FormChangelog
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 406);
            this.Controls.Add(this.tlpAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormChangelog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Changelog NFH";
            this.tlpAll.ResumeLayout(false);
            this.tlpAll.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpAll;
        private System.Windows.Forms.RichTextBox rtbChangelog;
        private System.Windows.Forms.Label lblChangelog;
        private System.Windows.Forms.Button btnClose;
    }
}