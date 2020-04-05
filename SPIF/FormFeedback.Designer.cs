namespace SPIF
{
    partial class FormFeedback
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
            this.rtbFeedback = new System.Windows.Forms.RichTextBox();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.tlpAll.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpAll
            // 
            this.tlpAll.ColumnCount = 3;
            this.tlpAll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAll.Controls.Add(this.rtbFeedback, 1, 1);
            this.tlpAll.Controls.Add(this.lblFeedback, 0, 0);
            this.tlpAll.Controls.Add(this.btnSend, 1, 2);
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
            // rtbFeedback
            // 
            this.rtbFeedback.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbFeedback.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbFeedback.Location = new System.Drawing.Point(23, 43);
            this.rtbFeedback.MaxLength = 1000;
            this.rtbFeedback.Name = "rtbFeedback";
            this.rtbFeedback.Size = new System.Drawing.Size(448, 315);
            this.rtbFeedback.TabIndex = 0;
            this.rtbFeedback.Text = "";
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.tlpAll.SetColumnSpan(this.lblFeedback, 3);
            this.lblFeedback.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFeedback.Font = new System.Drawing.Font("Verdana", 9.163636F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedback.Location = new System.Drawing.Point(0, 0);
            this.lblFeedback.Margin = new System.Windows.Forms.Padding(0);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(494, 40);
            this.lblFeedback.TabIndex = 1;
            this.lblFeedback.Text = "Provide feedback in the textbox below (Max. 1000 chars):";
            this.lblFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSend
            // 
            this.btnSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Location = new System.Drawing.Point(23, 364);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(448, 34);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // FormFeedback
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 406);
            this.Controls.Add(this.tlpAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormFeedback";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Provide feedback to the developer";
            this.tlpAll.ResumeLayout(false);
            this.tlpAll.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpAll;
        public System.Windows.Forms.RichTextBox rtbFeedback;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Button btnSend;
    }
}