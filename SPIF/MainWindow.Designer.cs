﻿using CMIF;

namespace SPIF
{
    partial class MainWindow : ThemedForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hydraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewChangelogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFile = new System.Windows.Forms.SaveFileDialog();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanelAdd = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxProject = new System.Windows.Forms.ComboBox();
            this.comboBoxWork = new System.Windows.Forms.ComboBox();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.tableLayoutPanelSettings = new System.Windows.Forms.TableLayoutPanel();
            this.btnViewStatistics = new System.Windows.Forms.Button();
            this.btnViewRecords = new System.Windows.Forms.Button();
            this.lblView = new System.Windows.Forms.Label();
            this.nudTimer = new System.Windows.Forms.NumericUpDown();
            this.labelTimer = new System.Windows.Forms.Label();
            this.cbCloseOnAdd = new System.Windows.Forms.CheckBox();
            this.cbFilter = new System.Windows.Forms.CheckBox();
            this.labelQuicksettings = new System.Windows.Forms.Label();
            this.cbMinimizeOnStartup = new System.Windows.Forms.CheckBox();
            this.btnResetTimer = new System.Windows.Forms.Button();
            this.tableLayoutPanelDate = new System.Windows.Forms.TableLayoutPanel();
            this.button_left = new System.Windows.Forms.Button();
            this.button_right = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tlpWorkspace = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip.SuspendLayout();
            this.tableLayoutPanelAdd.SuspendLayout();
            this.tableLayoutPanelSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimer)).BeginInit();
            this.tableLayoutPanelDate.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.tlpWorkspace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.White;
            this.menuStrip.Font = new System.Drawing.Font("Verdana", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.hydraToolStripMenuItem,
            this.preferencesToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.menuStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip.Size = new System.Drawing.Size(1000, 26);
            this.menuStrip.Stretch = false;
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // hydraToolStripMenuItem
            // 
            this.hydraToolStripMenuItem.Name = "hydraToolStripMenuItem";
            this.hydraToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.hydraToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.hydraToolStripMenuItem.Text = "Hydra";
            this.hydraToolStripMenuItem.Click += new System.EventHandler(this.hydraToolStripMenuItem_Click);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themeToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(103, 21);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setColorToolStripMenuItem});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.themeToolStripMenuItem.Text = "Theme";
            // 
            // setColorToolStripMenuItem
            // 
            this.setColorToolStripMenuItem.Name = "setColorToolStripMenuItem";
            this.setColorToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.setColorToolStripMenuItem.Text = "Set Color";
            this.setColorToolStripMenuItem.Click += new System.EventHandler(this.setColorToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.feedbackToolStripMenuItem,
            this.viewChangelogToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(52, 21);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // feedbackToolStripMenuItem
            // 
            this.feedbackToolStripMenuItem.Name = "feedbackToolStripMenuItem";
            this.feedbackToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.feedbackToolStripMenuItem.Text = "Feedback";
            this.feedbackToolStripMenuItem.Click += new System.EventHandler(this.feedbackToolStripMenuItem_Click);
            // 
            // viewChangelogToolStripMenuItem
            // 
            this.viewChangelogToolStripMenuItem.Name = "viewChangelogToolStripMenuItem";
            this.viewChangelogToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.viewChangelogToolStripMenuItem.Text = "View Changelog";
            this.viewChangelogToolStripMenuItem.Click += new System.EventHandler(this.ShowChangelogToolStripMenuItem_Click);
            // 
            // newFile
            // 
            this.newFile.DefaultExt = "libtw";
            this.newFile.Filter = "\"Linux is better than Windows files\"|*.libtw|\"All files\"|*.*";
            this.newFile.Title = "Name and location of worklog";
            // 
            // openFile
            // 
            this.openFile.AddExtension = false;
            this.openFile.DefaultExt = "libtw";
            this.openFile.Filter = "\"Linux is better than Windows files\"|*.libtw|\"All files\"|*.*";
            // 
            // tableLayoutPanelAdd
            // 
            this.tableLayoutPanelAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tableLayoutPanelAdd.ColumnCount = 4;
            this.tableLayoutPanelAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanelAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanelAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelAdd.Controls.Add(this.comboBoxProject, 0, 0);
            this.tableLayoutPanelAdd.Controls.Add(this.comboBoxWork, 2, 0);
            this.tableLayoutPanelAdd.Controls.Add(this.textBoxTime, 0, 0);
            this.tableLayoutPanelAdd.Controls.Add(this.buttonAdd, 3, 0);
            this.tableLayoutPanelAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelAdd.Location = new System.Drawing.Point(270, 0);
            this.tableLayoutPanelAdd.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelAdd.Name = "tableLayoutPanelAdd";
            this.tableLayoutPanelAdd.RowCount = 1;
            this.tableLayoutPanelAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanelAdd.Size = new System.Drawing.Size(730, 33);
            this.tableLayoutPanelAdd.TabIndex = 11;
            // 
            // comboBoxProject
            // 
            this.comboBoxProject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxProject.BackColor = System.Drawing.Color.White;
            this.comboBoxProject.Enabled = false;
            this.comboBoxProject.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxProject.Font = new System.Drawing.Font("Verdana", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProject.ForeColor = System.Drawing.Color.Black;
            this.comboBoxProject.FormattingEnabled = true;
            this.comboBoxProject.Location = new System.Drawing.Point(78, 4);
            this.comboBoxProject.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxProject.Name = "comboBoxProject";
            this.comboBoxProject.Size = new System.Drawing.Size(169, 25);
            this.comboBoxProject.TabIndex = 4;
            this.comboBoxProject.SelectedIndexChanged += new System.EventHandler(this.comboBoxProject_SelectedIndexChanged);
            // 
            // comboBoxWork
            // 
            this.comboBoxWork.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxWork.Enabled = false;
            this.comboBoxWork.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxWork.Font = new System.Drawing.Font("Verdana", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxWork.FormattingEnabled = true;
            this.comboBoxWork.Location = new System.Drawing.Point(250, 4);
            this.comboBoxWork.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxWork.Name = "comboBoxWork";
            this.comboBoxWork.Size = new System.Drawing.Size(380, 25);
            this.comboBoxWork.TabIndex = 5;
            this.comboBoxWork.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxWork_KeyDown);
            // 
            // textBoxTime
            // 
            this.textBoxTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTime.Enabled = false;
            this.textBoxTime.Font = new System.Drawing.Font("Verdana", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTime.Location = new System.Drawing.Point(0, 4);
            this.textBoxTime.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(75, 25);
            this.textBoxTime.TabIndex = 3;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.BackColor = System.Drawing.Color.White;
            this.buttonAdd.Enabled = false;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Verdana", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAdd.Location = new System.Drawing.Point(633, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(94, 25);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // tableLayoutPanelSettings
            // 
            this.tableLayoutPanelSettings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanelSettings.AutoSize = true;
            this.tableLayoutPanelSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelSettings.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanelSettings.ColumnCount = 5;
            this.tableLayoutPanelSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanelSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanelSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanelSettings.Controls.Add(this.btnViewStatistics, 3, 7);
            this.tableLayoutPanelSettings.Controls.Add(this.btnViewRecords, 1, 7);
            this.tableLayoutPanelSettings.Controls.Add(this.lblView, 0, 6);
            this.tableLayoutPanelSettings.Controls.Add(this.nudTimer, 3, 1);
            this.tableLayoutPanelSettings.Controls.Add(this.labelTimer, 1, 1);
            this.tableLayoutPanelSettings.Controls.Add(this.cbCloseOnAdd, 1, 2);
            this.tableLayoutPanelSettings.Controls.Add(this.cbFilter, 1, 3);
            this.tableLayoutPanelSettings.Controls.Add(this.labelQuicksettings, 0, 0);
            this.tableLayoutPanelSettings.Controls.Add(this.cbMinimizeOnStartup, 1, 4);
            this.tableLayoutPanelSettings.Controls.Add(this.btnResetTimer, 1, 5);
            this.tableLayoutPanelSettings.Font = new System.Drawing.Font("Verdana", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanelSettings.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanelSettings.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanelSettings.Name = "tableLayoutPanelSettings";
            this.tableLayoutPanelSettings.RowCount = 9;
            this.tableLayoutPanelSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanelSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanelSettings.Size = new System.Drawing.Size(220, 284);
            this.tableLayoutPanelSettings.TabIndex = 3;
            // 
            // btnViewStatistics
            // 
            this.btnViewStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewStatistics.BackColor = System.Drawing.Color.DarkGray;
            this.btnViewStatistics.FlatAppearance.BorderSize = 0;
            this.btnViewStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewStatistics.ForeColor = System.Drawing.Color.Black;
            this.btnViewStatistics.Location = new System.Drawing.Point(114, 249);
            this.btnViewStatistics.Margin = new System.Windows.Forms.Padding(0);
            this.btnViewStatistics.Name = "btnViewStatistics";
            this.btnViewStatistics.Size = new System.Drawing.Size(89, 25);
            this.btnViewStatistics.TabIndex = 15;
            this.btnViewStatistics.Text = "Statistics";
            this.btnViewStatistics.UseVisualStyleBackColor = false;
            this.btnViewStatistics.Click += new System.EventHandler(this.btnViewStatistics_Click);
            // 
            // btnViewRecords
            // 
            this.btnViewRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewRecords.BackColor = System.Drawing.Color.DarkGray;
            this.btnViewRecords.FlatAppearance.BorderSize = 0;
            this.btnViewRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewRecords.ForeColor = System.Drawing.Color.Black;
            this.btnViewRecords.Location = new System.Drawing.Point(15, 249);
            this.btnViewRecords.Margin = new System.Windows.Forms.Padding(0);
            this.btnViewRecords.Name = "btnViewRecords";
            this.btnViewRecords.Size = new System.Drawing.Size(89, 25);
            this.btnViewRecords.TabIndex = 14;
            this.btnViewRecords.Text = "Records";
            this.btnViewRecords.UseVisualStyleBackColor = false;
            this.btnViewRecords.Click += new System.EventHandler(this.btnViewRecords_Click);
            // 
            // lblView
            // 
            this.lblView.BackColor = System.Drawing.Color.Red;
            this.tableLayoutPanelSettings.SetColumnSpan(this.lblView, 5);
            this.lblView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblView.Font = new System.Drawing.Font("Verdana", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblView.ForeColor = System.Drawing.Color.White;
            this.lblView.Location = new System.Drawing.Point(10, 217);
            this.lblView.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(200, 22);
            this.lblView.TabIndex = 16;
            this.lblView.Text = "View";
            this.lblView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudTimer
            // 
            this.nudTimer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudTimer.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudTimer.Location = new System.Drawing.Point(117, 43);
            this.nudTimer.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudTimer.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudTimer.Name = "nudTimer";
            this.nudTimer.Size = new System.Drawing.Size(78, 22);
            this.nudTimer.TabIndex = 7;
            this.nudTimer.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // labelTimer
            // 
            this.labelTimer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTimer.AutoSize = true;
            this.tableLayoutPanelSettings.SetColumnSpan(this.labelTimer, 2);
            this.labelTimer.Location = new System.Drawing.Point(18, 46);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(89, 16);
            this.labelTimer.TabIndex = 0;
            this.labelTimer.Text = "Timer (min):";
            // 
            // cbCloseOnAdd
            // 
            this.cbCloseOnAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbCloseOnAdd.AutoSize = true;
            this.tableLayoutPanelSettings.SetColumnSpan(this.cbCloseOnAdd, 3);
            this.cbCloseOnAdd.Location = new System.Drawing.Point(18, 79);
            this.cbCloseOnAdd.Name = "cbCloseOnAdd";
            this.cbCloseOnAdd.Size = new System.Drawing.Size(112, 20);
            this.cbCloseOnAdd.TabIndex = 8;
            this.cbCloseOnAdd.Text = "Close on add";
            this.cbCloseOnAdd.UseVisualStyleBackColor = true;
            // 
            // cbFilter
            // 
            this.cbFilter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbFilter.AutoSize = true;
            this.tableLayoutPanelSettings.SetColumnSpan(this.cbFilter, 3);
            this.cbFilter.Location = new System.Drawing.Point(18, 114);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(182, 20);
            this.cbFilter.TabIndex = 9;
            this.cbFilter.Text = "Filter subject by Project Code";
            this.cbFilter.UseVisualStyleBackColor = true;
            // 
            // labelQuicksettings
            // 
            this.labelQuicksettings.AutoSize = true;
            this.labelQuicksettings.BackColor = System.Drawing.Color.Red;
            this.tableLayoutPanelSettings.SetColumnSpan(this.labelQuicksettings, 5);
            this.labelQuicksettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelQuicksettings.Font = new System.Drawing.Font("Verdana", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuicksettings.ForeColor = System.Drawing.Color.White;
            this.labelQuicksettings.Location = new System.Drawing.Point(10, 10);
            this.labelQuicksettings.Margin = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.labelQuicksettings.Name = "labelQuicksettings";
            this.labelQuicksettings.Size = new System.Drawing.Size(200, 22);
            this.labelQuicksettings.TabIndex = 12;
            this.labelQuicksettings.Text = "Quicksettings";
            this.labelQuicksettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbMinimizeOnStartup
            // 
            this.cbMinimizeOnStartup.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbMinimizeOnStartup.AutoSize = true;
            this.tableLayoutPanelSettings.SetColumnSpan(this.cbMinimizeOnStartup, 3);
            this.cbMinimizeOnStartup.Location = new System.Drawing.Point(18, 149);
            this.cbMinimizeOnStartup.Name = "cbMinimizeOnStartup";
            this.cbMinimizeOnStartup.Size = new System.Drawing.Size(161, 20);
            this.cbMinimizeOnStartup.TabIndex = 11;
            this.cbMinimizeOnStartup.Text = "Autostart: Load last";
            this.cbMinimizeOnStartup.UseVisualStyleBackColor = true;
            // 
            // btnResetTimer
            // 
            this.btnResetTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetTimer.BackColor = System.Drawing.Color.DarkGray;
            this.tableLayoutPanelSettings.SetColumnSpan(this.btnResetTimer, 3);
            this.btnResetTimer.FlatAppearance.BorderSize = 0;
            this.btnResetTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetTimer.ForeColor = System.Drawing.Color.Black;
            this.btnResetTimer.Location = new System.Drawing.Point(15, 182);
            this.btnResetTimer.Margin = new System.Windows.Forms.Padding(0);
            this.btnResetTimer.Name = "btnResetTimer";
            this.btnResetTimer.Size = new System.Drawing.Size(188, 25);
            this.btnResetTimer.TabIndex = 13;
            this.btnResetTimer.Text = "Reset Timer";
            this.btnResetTimer.UseVisualStyleBackColor = false;
            this.btnResetTimer.Click += new System.EventHandler(this.btnResetTimer_Click);
            // 
            // tableLayoutPanelDate
            // 
            this.tableLayoutPanelDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tableLayoutPanelDate.ColumnCount = 3;
            this.tableLayoutPanelDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelDate.Controls.Add(this.button_left, 0, 0);
            this.tableLayoutPanelDate.Controls.Add(this.button_right, 2, 0);
            this.tableLayoutPanelDate.Controls.Add(this.dateTimePicker, 1, 0);
            this.tableLayoutPanelDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelDate.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelDate.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelDate.Name = "tableLayoutPanelDate";
            this.tableLayoutPanelDate.RowCount = 1;
            this.tableLayoutPanelDate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelDate.Size = new System.Drawing.Size(270, 33);
            this.tableLayoutPanelDate.TabIndex = 8;
            // 
            // button_left
            // 
            this.button_left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_left.Enabled = false;
            this.button_left.FlatAppearance.BorderSize = 0;
            this.button_left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_left.Font = new System.Drawing.Font("Wingdings", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button_left.ForeColor = System.Drawing.Color.White;
            this.button_left.Location = new System.Drawing.Point(3, 3);
            this.button_left.Name = "button_left";
            this.button_left.Size = new System.Drawing.Size(29, 27);
            this.button_left.TabIndex = 0;
            this.button_left.Text = "ß";
            this.button_left.UseVisualStyleBackColor = true;
            this.button_left.Click += new System.EventHandler(this.button_left_Click);
            // 
            // button_right
            // 
            this.button_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_right.Enabled = false;
            this.button_right.FlatAppearance.BorderSize = 0;
            this.button_right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_right.Font = new System.Drawing.Font("Wingdings", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button_right.ForeColor = System.Drawing.Color.White;
            this.button_right.Location = new System.Drawing.Point(238, 3);
            this.button_right.Name = "button_right";
            this.button_right.Size = new System.Drawing.Size(29, 27);
            this.button_right.TabIndex = 2;
            this.button_right.Text = "à";
            this.button_right.UseVisualStyleBackColor = true;
            this.button_right.Click += new System.EventHandler(this.button_right_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.Highlight;
            this.dateTimePicker.Enabled = false;
            this.dateTimePicker.Font = new System.Drawing.Font("Verdana", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(41, 4);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(188, 25);
            this.dateTimePicker.TabIndex = 1;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 270F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanelDate, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanelAdd, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.statusStrip, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.tlpWorkspace, 0, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 26);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1000, 360);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel.SetColumnSpan(this.statusStrip, 2);
            this.statusStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusStrip.Font = new System.Drawing.Font("Verdana", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.statusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip.Location = new System.Drawing.Point(0, 335);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1000, 25);
            this.statusStrip.TabIndex = 14;
            this.statusStrip.Text = "statusStrip";
            // 
            // tlpWorkspace
            // 
            this.tlpWorkspace.AutoSize = true;
            this.tlpWorkspace.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpWorkspace.ColumnCount = 2;
            this.tableLayoutPanel.SetColumnSpan(this.tlpWorkspace, 2);
            this.tlpWorkspace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.tlpWorkspace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpWorkspace.Controls.Add(this.dataGridView, 1, 0);
            this.tlpWorkspace.Controls.Add(this.tableLayoutPanelSettings, 0, 0);
            this.tlpWorkspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpWorkspace.Location = new System.Drawing.Point(3, 36);
            this.tlpWorkspace.Name = "tlpWorkspace";
            this.tlpWorkspace.RowCount = 1;
            this.tlpWorkspace.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpWorkspace.Size = new System.Drawing.Size(994, 296);
            this.tlpWorkspace.TabIndex = 15;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridView.Location = new System.Drawing.Point(235, 5);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView.RowHeadersWidth = 47;
            this.dataGridView.RowTemplate.ReadOnly = true;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView.Size = new System.Drawing.Size(754, 286);
            this.dataGridView.TabIndex = 11;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(110F, 110F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 386);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Verdana", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(1000, 375);
            this.Name = "MainWindow";
            this.Text = "Never Forget Hydra - Closed Alpha";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Shown += new System.EventHandler(this.MainWindow_Shown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tableLayoutPanelAdd.ResumeLayout(false);
            this.tableLayoutPanelAdd.PerformLayout();
            this.tableLayoutPanelSettings.ResumeLayout(false);
            this.tableLayoutPanelSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimer)).EndInit();
            this.tableLayoutPanelDate.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.tlpWorkspace.ResumeLayout(false);
            this.tlpWorkspace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feedbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewChangelogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hydraToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog newFile;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAdd;
        private System.Windows.Forms.ComboBox comboBoxWork;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Button buttonAdd;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDate;
        private System.Windows.Forms.Button button_left;
        private System.Windows.Forms.Button button_right;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox comboBoxProject;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanelSettings;
        private System.Windows.Forms.CheckBox cbCloseOnAdd;
        private System.Windows.Forms.NumericUpDown nudTimer;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.CheckBox cbFilter;
        public System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.CheckBox cbMinimizeOnStartup;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        public System.Windows.Forms.TableLayoutPanel tlpWorkspace;
        private System.Windows.Forms.Label labelQuicksettings;
        private System.Windows.Forms.Button btnResetTimer;
        private System.Windows.Forms.Label lblView;
        private System.Windows.Forms.Button btnViewStatistics;
        private System.Windows.Forms.Button btnViewRecords;
    }
}

