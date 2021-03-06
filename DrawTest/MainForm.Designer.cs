﻿namespace DrawTest
{
    partial class MainForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.drawOthers = new System.Windows.Forms.Button();
            this.drawLine = new System.Windows.Forms.Button();
            this.FrontPage = new System.Windows.Forms.Button();
            this.Flasks = new System.Windows.Forms.Button();
            this.picturePanel = new System.Windows.Forms.Panel();
            this.pbPageImage = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.fromLocation = new System.Windows.Forms.ToolStripStatusLabel();
            this.toLocation = new System.Windows.Forms.ToolStripStatusLabel();
            this.hitCheck = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.picturePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPageImage)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.23043F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.76957F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.picturePanel, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1036, 472);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.drawOthers);
            this.flowLayoutPanel1.Controls.Add(this.drawLine);
            this.flowLayoutPanel1.Controls.Add(this.FrontPage);
            this.flowLayoutPanel1.Controls.Add(this.Flasks);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(11, 23);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(127, 426);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // drawOthers
            // 
            this.drawOthers.AutoSize = true;
            this.drawOthers.Dock = System.Windows.Forms.DockStyle.Top;
            this.drawOthers.Location = new System.Drawing.Point(3, 3);
            this.drawOthers.Name = "drawOthers";
            this.drawOthers.Size = new System.Drawing.Size(96, 23);
            this.drawOthers.TabIndex = 2;
            this.drawOthers.Text = "General Drawing";
            this.drawOthers.UseVisualStyleBackColor = true;
            this.drawOthers.Click += new System.EventHandler(this.drawOthers_Click);
            // 
            // drawLine
            // 
            this.drawLine.AutoSize = true;
            this.drawLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.drawLine.Location = new System.Drawing.Point(3, 32);
            this.drawLine.Name = "drawLine";
            this.drawLine.Size = new System.Drawing.Size(96, 23);
            this.drawLine.TabIndex = 1;
            this.drawLine.Text = "Draw A Line";
            this.drawLine.UseVisualStyleBackColor = true;
            this.drawLine.Click += new System.EventHandler(this.drawLine_Click);
            // 
            // FrontPage
            // 
            this.FrontPage.Location = new System.Drawing.Point(3, 61);
            this.FrontPage.Name = "FrontPage";
            this.FrontPage.Size = new System.Drawing.Size(96, 23);
            this.FrontPage.TabIndex = 1;
            this.FrontPage.Text = "Front Page";
            this.FrontPage.UseVisualStyleBackColor = true;
            this.FrontPage.Click += new System.EventHandler(this.FrontPage_Click);
            // 
            // Flasks
            // 
            this.Flasks.Location = new System.Drawing.Point(3, 90);
            this.Flasks.Name = "Flasks";
            this.Flasks.Size = new System.Drawing.Size(96, 23);
            this.Flasks.TabIndex = 0;
            this.Flasks.Text = "Flasks";
            this.Flasks.UseVisualStyleBackColor = true;
            this.Flasks.Click += new System.EventHandler(this.Flasks_Click);
            // 
            // picturePanel
            // 
            this.picturePanel.Controls.Add(this.pbPageImage);
            this.picturePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picturePanel.Location = new System.Drawing.Point(144, 23);
            this.picturePanel.Name = "picturePanel";
            this.picturePanel.Size = new System.Drawing.Size(867, 426);
            this.picturePanel.TabIndex = 1;
            // 
            // pbPageImage
            // 
            this.pbPageImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbPageImage.Location = new System.Drawing.Point(12, 13);
            this.pbPageImage.Name = "pbPageImage";
            this.pbPageImage.Size = new System.Drawing.Size(182, 170);
            this.pbPageImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPageImage.TabIndex = 0;
            this.pbPageImage.TabStop = false;
            this.pbPageImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbPageImage_MouseDown);
            this.pbPageImage.MouseEnter += new System.EventHandler(this.pbPageImage_MouseEnter);
            this.pbPageImage.MouseLeave += new System.EventHandler(this.pbPageImage_MouseLeave);
            this.pbPageImage.MouseHover += new System.EventHandler(this.pbPageImage_MouseHover);
            this.pbPageImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbPageImage_MouseMove);
            this.pbPageImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbPageImage_MouseUp);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusMessage,
            this.fromLocation,
            this.toLocation,
            this.hitCheck});
            this.statusStrip1.Location = new System.Drawing.Point(0, 450);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1036, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusMessage
            // 
            this.statusMessage.Name = "statusMessage";
            this.statusMessage.Size = new System.Drawing.Size(118, 17);
            this.statusMessage.Text = "toolStripStatusLabel1";
            // 
            // fromLocation
            // 
            this.fromLocation.Name = "fromLocation";
            this.fromLocation.Size = new System.Drawing.Size(38, 17);
            this.fromLocation.Text = "From:";
            this.fromLocation.Visible = false;
            // 
            // toLocation
            // 
            this.toLocation.Name = "toLocation";
            this.toLocation.Size = new System.Drawing.Size(21, 17);
            this.toLocation.Text = "to:";
            this.toLocation.Visible = false;
            // 
            // hitCheck
            // 
            this.hitCheck.Name = "hitCheck";
            this.hitCheck.Size = new System.Drawing.Size(82, 17);
            this.hitCheck.Text = "outside image";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1036, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 472);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.picturePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPageImage)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel picturePanel;
        private System.Windows.Forms.PictureBox pbPageImage;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusMessage;
        private System.Windows.Forms.ToolStripStatusLabel fromLocation;
        private System.Windows.Forms.ToolStripStatusLabel toLocation;
        private System.Windows.Forms.ToolStripStatusLabel hitCheck;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button drawOthers;
        private System.Windows.Forms.Button drawLine;
        private System.Windows.Forms.Button FrontPage;
        private System.Windows.Forms.Button Flasks;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    }
}

