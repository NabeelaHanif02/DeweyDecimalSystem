
namespace DeweyDecimalSystem
{
    partial class Replacing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Replacing));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblPnts = new System.Windows.Forms.Label();
            this.upPictureBox = new System.Windows.Forms.PictureBox();
            this.downPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.listBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(83, 164);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(317, 324);
            this.listBox1.TabIndex = 0;
            this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDown);
            // 
            // listBox2
            // 
            this.listBox2.AllowDrop = true;
            this.listBox2.BackColor = System.Drawing.SystemColors.ControlText;
            this.listBox2.ForeColor = System.Drawing.SystemColors.Info;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(545, 164);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(327, 324);
            this.listBox2.TabIndex = 1;
            this.listBox2.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox2_DragDrop);
            this.listBox2.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox2_DragEnter);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.Transparent;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheck.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCheck.Location = new System.Drawing.Point(800, 83);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(113, 47);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check Order";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(458, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(590, 326);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBack.Location = new System.Drawing.Point(30, 83);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(110, 47);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Return";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblPnts
            // 
            this.lblPnts.AutoSize = true;
            this.lblPnts.BackColor = System.Drawing.Color.Transparent;
            this.lblPnts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPnts.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPnts.Location = new System.Drawing.Point(458, 310);
            this.lblPnts.Name = "lblPnts";
            this.lblPnts.Size = new System.Drawing.Size(23, 28);
            this.lblPnts.TabIndex = 6;
            this.lblPnts.Text = "0";
            // 
            // upPictureBox
            // 
            this.upPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.upPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.upPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("upPictureBox.Image")));
            this.upPictureBox.Location = new System.Drawing.Point(888, 242);
            this.upPictureBox.Name = "upPictureBox";
            this.upPictureBox.Size = new System.Drawing.Size(60, 59);
            this.upPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.upPictureBox.TabIndex = 7;
            this.upPictureBox.TabStop = false;
            this.upPictureBox.Click += new System.EventHandler(this.upPictureBox_Click);
            // 
            // downPictureBox
            // 
            this.downPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.downPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.downPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("downPictureBox.Image")));
            this.downPictureBox.Location = new System.Drawing.Point(888, 344);
            this.downPictureBox.Name = "downPictureBox";
            this.downPictureBox.Size = new System.Drawing.Size(60, 56);
            this.downPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.downPictureBox.TabIndex = 8;
            this.downPictureBox.TabStop = false;
            this.downPictureBox.Click += new System.EventHandler(this.downPictureBox_Click);
            // 
            // Replacing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(960, 543);
            this.Controls.Add(this.downPictureBox);
            this.Controls.Add(this.upPictureBox);
            this.Controls.Add(this.lblPnts);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Replacing";
            this.Text = "Replacing";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblPnts;
        private System.Windows.Forms.PictureBox upPictureBox;
        private System.Windows.Forms.PictureBox downPictureBox;
    }
}