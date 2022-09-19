namespace BIT706Assignment
{
    partial class FormManageCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageCustomers));
            this.listBoxCustomers = new System.Windows.Forms.ListBox();
            this.buttonAddCustomerForm = new System.Windows.Forms.Button();
            this.buttonEditCustomerForm = new System.Windows.Forms.Button();
            this.buttonDeleteCustomer = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.labelManageCustomers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::BIT706Assignment.Properties.Resources.mybank;
            // 
            // listBoxCustomers
            // 
            this.listBoxCustomers.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCustomers.FormattingEnabled = true;
            this.listBoxCustomers.ItemHeight = 16;
            this.listBoxCustomers.Location = new System.Drawing.Point(29, 171);
            this.listBoxCustomers.Name = "listBoxCustomers";
            this.listBoxCustomers.Size = new System.Drawing.Size(164, 132);
            this.listBoxCustomers.TabIndex = 1;
            // 
            // buttonAddCustomerForm
            // 
            this.buttonAddCustomerForm.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCustomerForm.Location = new System.Drawing.Point(230, 171);
            this.buttonAddCustomerForm.Name = "buttonAddCustomerForm";
            this.buttonAddCustomerForm.Size = new System.Drawing.Size(141, 36);
            this.buttonAddCustomerForm.TabIndex = 2;
            this.buttonAddCustomerForm.Text = "Add Customer";
            this.buttonAddCustomerForm.UseVisualStyleBackColor = true;
            this.buttonAddCustomerForm.Click += new System.EventHandler(this.ButtonAddCustomer_Click);
            // 
            // buttonEditCustomerForm
            // 
            this.buttonEditCustomerForm.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditCustomerForm.Location = new System.Drawing.Point(230, 222);
            this.buttonEditCustomerForm.Name = "buttonEditCustomerForm";
            this.buttonEditCustomerForm.Size = new System.Drawing.Size(141, 36);
            this.buttonEditCustomerForm.TabIndex = 3;
            this.buttonEditCustomerForm.Text = "Edit Customer";
            this.buttonEditCustomerForm.UseVisualStyleBackColor = true;
            this.buttonEditCustomerForm.Click += new System.EventHandler(this.ButtonEditCustomerForm_Click);
            // 
            // buttonDeleteCustomer
            // 
            this.buttonDeleteCustomer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteCustomer.Location = new System.Drawing.Point(230, 276);
            this.buttonDeleteCustomer.Name = "buttonDeleteCustomer";
            this.buttonDeleteCustomer.Size = new System.Drawing.Size(141, 36);
            this.buttonDeleteCustomer.TabIndex = 4;
            this.buttonDeleteCustomer.Text = "Delete Customer";
            this.buttonDeleteCustomer.UseVisualStyleBackColor = true;
            this.buttonDeleteCustomer.Click += new System.EventHandler(this.ButtonDeleteCustomer_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonReturn.BackgroundImage")));
            this.buttonReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonReturn.Location = new System.Drawing.Point(400, 12);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(36, 33);
            this.buttonReturn.TabIndex = 5;
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.ButtonReturn_Click);
            // 
            // labelManageCustomers
            // 
            this.labelManageCustomers.AutoSize = true;
            this.labelManageCustomers.BackColor = System.Drawing.Color.Transparent;
            this.labelManageCustomers.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManageCustomers.Location = new System.Drawing.Point(55, 108);
            this.labelManageCustomers.Name = "labelManageCustomers";
            this.labelManageCustomers.Size = new System.Drawing.Size(268, 32);
            this.labelManageCustomers.TabIndex = 6;
            this.labelManageCustomers.Text = "Manage Customers";
            // 
            // FormManageCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(448, 461);
            this.Controls.Add(this.labelManageCustomers);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonDeleteCustomer);
            this.Controls.Add(this.buttonEditCustomerForm);
            this.Controls.Add(this.buttonAddCustomerForm);
            this.Controls.Add(this.listBoxCustomers);
            this.Name = "FormManageCustomers";
            this.Text = "FormManageCustomers";
            this.Controls.SetChildIndex(this.pictureBoxLogo, 0);
            this.Controls.SetChildIndex(this.listBoxCustomers, 0);
            this.Controls.SetChildIndex(this.buttonAddCustomerForm, 0);
            this.Controls.SetChildIndex(this.buttonEditCustomerForm, 0);
            this.Controls.SetChildIndex(this.buttonDeleteCustomer, 0);
            this.Controls.SetChildIndex(this.buttonReturn, 0);
            this.Controls.SetChildIndex(this.labelManageCustomers, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCustomers;
        private System.Windows.Forms.Button buttonAddCustomerForm;
        private System.Windows.Forms.Button buttonEditCustomerForm;
        private System.Windows.Forms.Button buttonDeleteCustomer;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Label labelManageCustomers;
    }
}