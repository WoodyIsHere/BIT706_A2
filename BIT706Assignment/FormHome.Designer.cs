namespace BIT706Assignment
{
    partial class FormHome
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
            this.labelMenu = new System.Windows.Forms.Label();
            this.buttonManageCustomers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::BIT706Assignment.Properties.Resources.mybank;
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.BackColor = System.Drawing.Color.Transparent;
            this.labelMenu.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.Location = new System.Drawing.Point(85, 116);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(85, 32);
            this.labelMenu.TabIndex = 1;
            this.labelMenu.Text = "Menu";
            // 
            // buttonManageCustomers
            // 
            this.buttonManageCustomers.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManageCustomers.Location = new System.Drawing.Point(52, 169);
            this.buttonManageCustomers.Name = "buttonManageCustomers";
            this.buttonManageCustomers.Size = new System.Drawing.Size(144, 64);
            this.buttonManageCustomers.TabIndex = 2;
            this.buttonManageCustomers.Text = "Manage Customers";
            this.buttonManageCustomers.UseVisualStyleBackColor = true;
            this.buttonManageCustomers.Click += new System.EventHandler(this.ButtonManageCustomers_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(268, 362);
            this.Controls.Add(this.buttonManageCustomers);
            this.Controls.Add(this.labelMenu);
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.Controls.SetChildIndex(this.pictureBoxLogo, 0);
            this.Controls.SetChildIndex(this.labelMenu, 0);
            this.Controls.SetChildIndex(this.buttonManageCustomers, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Button buttonManageCustomers;
    }
}