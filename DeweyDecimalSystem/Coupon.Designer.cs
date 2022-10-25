
namespace DeweyDecimalSystem
{
    partial class Coupon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Coupon));
            this.btnTake = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCoupon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTake
            // 
            this.btnTake.BackColor = System.Drawing.Color.Transparent;
            this.btnTake.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTake.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTake.Location = new System.Drawing.Point(61, 428);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(135, 36);
            this.btnTake.TabIndex = 0;
            this.btnTake.Text = "Take Me";
            this.btnTake.UseVisualStyleBackColor = false;
            this.btnTake.Click += new System.EventHandler(this.btnTake_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExit.Location = new System.Drawing.Point(249, 428);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(135, 36);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCoupon
            // 
            this.lblCoupon.AutoSize = true;
            this.lblCoupon.BackColor = System.Drawing.Color.Transparent;
            this.lblCoupon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCoupon.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCoupon.Location = new System.Drawing.Point(75, 250);
            this.lblCoupon.Name = "lblCoupon";
            this.lblCoupon.Size = new System.Drawing.Size(91, 23);
            this.lblCoupon.TabIndex = 2;
            this.lblCoupon.Text = "label12345";
            // 
            // Coupon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(522, 493);
            this.Controls.Add(this.lblCoupon);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTake);
            this.Name = "Coupon";
            this.Text = "Coupon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTake;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCoupon;
    }
}