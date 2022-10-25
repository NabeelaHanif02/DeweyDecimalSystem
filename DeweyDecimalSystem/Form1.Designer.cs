
namespace DeweyDecimalSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnReplaceBooks = new System.Windows.Forms.Button();
            this.btnIdenAreas = new System.Windows.Forms.Button();
            this.btnFindCallNum = new System.Windows.Forms.Button();
            this.btnRwards = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblPoints = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReplaceBooks
            // 
            this.btnReplaceBooks.BackColor = System.Drawing.Color.Transparent;
            this.btnReplaceBooks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReplaceBooks.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReplaceBooks.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReplaceBooks.Location = new System.Drawing.Point(165, 349);
            this.btnReplaceBooks.Name = "btnReplaceBooks";
            this.btnReplaceBooks.Size = new System.Drawing.Size(189, 54);
            this.btnReplaceBooks.TabIndex = 0;
            this.btnReplaceBooks.Text = "Replacing Books";
            this.btnReplaceBooks.UseVisualStyleBackColor = false;
            this.btnReplaceBooks.Click += new System.EventHandler(this.btnReplaceBooks_Click);
            // 
            // btnIdenAreas
            // 
            this.btnIdenAreas.BackColor = System.Drawing.Color.Transparent;
            this.btnIdenAreas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIdenAreas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIdenAreas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIdenAreas.Location = new System.Drawing.Point(385, 349);
            this.btnIdenAreas.Name = "btnIdenAreas";
            this.btnIdenAreas.Size = new System.Drawing.Size(190, 54);
            this.btnIdenAreas.TabIndex = 1;
            this.btnIdenAreas.Text = "Identifying areas";
            this.btnIdenAreas.UseVisualStyleBackColor = false;
            this.btnIdenAreas.Click += new System.EventHandler(this.btnIdenAreas_Click);
            // 
            // btnFindCallNum
            // 
            this.btnFindCallNum.BackColor = System.Drawing.Color.Transparent;
            this.btnFindCallNum.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFindCallNum.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFindCallNum.Location = new System.Drawing.Point(606, 349);
            this.btnFindCallNum.Name = "btnFindCallNum";
            this.btnFindCallNum.Size = new System.Drawing.Size(188, 54);
            this.btnFindCallNum.TabIndex = 2;
            this.btnFindCallNum.Text = "Finding Call Numbers";
            this.btnFindCallNum.UseVisualStyleBackColor = false;
            this.btnFindCallNum.Click += new System.EventHandler(this.btnFindCallNum_Click);
            // 
            // btnRwards
            // 
            this.btnRwards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnRwards.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRwards.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRwards.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnRwards.Location = new System.Drawing.Point(485, 0);
            this.btnRwards.Name = "btnRwards";
            this.btnRwards.Size = new System.Drawing.Size(174, 65);
            this.btnRwards.TabIndex = 3;
            this.btnRwards.Text = "Rewards";
            this.btnRwards.UseVisualStyleBackColor = false;
            this.btnRwards.Click += new System.EventHandler(this.btnRwards_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnHome.Location = new System.Drawing.Point(305, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(174, 65);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(85, 132);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(17, 20);
            this.lblPoints.TabIndex = 5;
            this.lblPoints.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(954, 543);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnRwards);
            this.Controls.Add(this.btnFindCallNum);
            this.Controls.Add(this.btnIdenAreas);
            this.Controls.Add(this.btnReplaceBooks);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReplaceBooks;
        private System.Windows.Forms.Button btnIdenAreas;
        private System.Windows.Forms.Button btnFindCallNum;
        private System.Windows.Forms.Button btnRwards;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblPoints;
    }
}

