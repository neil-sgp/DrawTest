namespace DrawTest
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.drawLine = new System.Windows.Forms.Button();
            this.drawOthers = new System.Windows.Forms.Button();
            this.picturePanel = new System.Windows.Forms.Panel();
            this.pbPageImage = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.fromLocation = new System.Windows.Forms.ToolStripStatusLabel();
            this.toLocation = new System.Windows.Forms.ToolStripStatusLabel();
            this.hitCheck = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.picturePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPageImage)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.picturePanel, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(23, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(936, 384);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.drawLine, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.drawOthers, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(23, 23);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 338);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drawing Test Application";
            // 
            // drawLine
            // 
            this.drawLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawLine.Location = new System.Drawing.Point(3, 23);
            this.drawLine.Name = "drawLine";
            this.drawLine.Size = new System.Drawing.Size(194, 23);
            this.drawLine.TabIndex = 1;
            this.drawLine.Text = "Draw A Line";
            this.drawLine.UseVisualStyleBackColor = true;
            this.drawLine.Click += new System.EventHandler(this.drawLine_Click);
            // 
            // drawOthers
            // 
            this.drawOthers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawOthers.Location = new System.Drawing.Point(3, 52);
            this.drawOthers.Name = "drawOthers";
            this.drawOthers.Size = new System.Drawing.Size(194, 23);
            this.drawOthers.TabIndex = 2;
            this.drawOthers.Text = "General Drawing";
            this.drawOthers.UseVisualStyleBackColor = true;
            this.drawOthers.Click += new System.EventHandler(this.drawOthers_Click);
            // 
            // picturePanel
            // 
            this.picturePanel.Controls.Add(this.pbPageImage);
            this.picturePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picturePanel.Location = new System.Drawing.Point(229, 23);
            this.picturePanel.Name = "picturePanel";
            this.picturePanel.Size = new System.Drawing.Size(684, 338);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 472);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.picturePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPageImage)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button drawLine;
        private System.Windows.Forms.Button drawOthers;
        private System.Windows.Forms.Panel picturePanel;
        private System.Windows.Forms.PictureBox pbPageImage;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusMessage;
        private System.Windows.Forms.ToolStripStatusLabel fromLocation;
        private System.Windows.Forms.ToolStripStatusLabel toLocation;
        private System.Windows.Forms.ToolStripStatusLabel hitCheck;
    }
}

