namespace PingerAssignment
{
    partial class ResetPinger
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
            this.label1 = new System.Windows.Forms.Label();
            this.LblResetPlugIn = new System.Windows.Forms.Label();
            this.BtnResetCancel = new System.Windows.Forms.Button();
            this.BtnResetConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(-1, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(530, 45);
            this.label1.TabIndex = 18;
            // 
            // LblResetPlugIn
            // 
            this.LblResetPlugIn.AutoSize = true;
            this.LblResetPlugIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResetPlugIn.Location = new System.Drawing.Point(23, 9);
            this.LblResetPlugIn.Name = "LblResetPlugIn";
            this.LblResetPlugIn.Size = new System.Drawing.Size(398, 20);
            this.LblResetPlugIn.TabIndex = 19;
            this.LblResetPlugIn.Text = "Do you want to delete all the data and reset the plugin?";
            // 
            // BtnResetCancel
            // 
            this.BtnResetCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnResetCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnResetCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnResetCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnResetCancel.ForeColor = System.Drawing.Color.White;
            this.BtnResetCancel.Location = new System.Drawing.Point(434, 46);
            this.BtnResetCancel.Name = "BtnResetCancel";
            this.BtnResetCancel.Size = new System.Drawing.Size(53, 33);
            this.BtnResetCancel.TabIndex = 20;
            this.BtnResetCancel.Text = "No";
            this.BtnResetCancel.UseVisualStyleBackColor = false;
            this.BtnResetCancel.Click += new System.EventHandler(this.BtnResetCancel_Click);
            // 
            // BtnResetConfirm
            // 
            this.BtnResetConfirm.BackColor = System.Drawing.Color.Green;
            this.BtnResetConfirm.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.BtnResetConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnResetConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnResetConfirm.ForeColor = System.Drawing.Color.White;
            this.BtnResetConfirm.Location = new System.Drawing.Point(368, 46);
            this.BtnResetConfirm.Name = "BtnResetConfirm";
            this.BtnResetConfirm.Size = new System.Drawing.Size(53, 33);
            this.BtnResetConfirm.TabIndex = 21;
            this.BtnResetConfirm.Text = "Yes";
            this.BtnResetConfirm.UseVisualStyleBackColor = false;
            this.BtnResetConfirm.Click += new System.EventHandler(this.BtnResetConfirm_Click);
            // 
            // ResetPinger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(527, 91);
            this.Controls.Add(this.BtnResetConfirm);
            this.Controls.Add(this.BtnResetCancel);
            this.Controls.Add(this.LblResetPlugIn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResetPinger";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblResetPlugIn;
        private System.Windows.Forms.Button BtnResetCancel;
        private System.Windows.Forms.Button BtnResetConfirm;
    }
}