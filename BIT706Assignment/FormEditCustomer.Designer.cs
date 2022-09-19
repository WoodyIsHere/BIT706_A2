namespace BIT706Assignment
{
    partial class FormEditCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditCustomer));
            this.buttonCancelAddCustomer = new System.Windows.Forms.Button();
            this.buttonEditCustomer = new System.Windows.Forms.Button();
            this.labelEmployee = new System.Windows.Forms.Label();
            this.checkBoxEmployee = new System.Windows.Forms.CheckBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelEditCustomer = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::BIT706Assignment.Properties.Resources.mybank;
            // 
            // buttonCancelAddCustomer
            // 
            this.buttonCancelAddCustomer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelAddCustomer.Location = new System.Drawing.Point(12, 380);
            this.buttonCancelAddCustomer.Name = "buttonCancelAddCustomer";
            this.buttonCancelAddCustomer.Size = new System.Drawing.Size(141, 36);
            this.buttonCancelAddCustomer.TabIndex = 27;
            this.buttonCancelAddCustomer.Text = "Cancel";
            this.buttonCancelAddCustomer.UseVisualStyleBackColor = true;
            this.buttonCancelAddCustomer.Click += new System.EventHandler(this.ButtonCancelAddCustomer_Click);
            // 
            // buttonEditCustomer
            // 
            this.buttonEditCustomer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditCustomer.Location = new System.Drawing.Point(208, 380);
            this.buttonEditCustomer.Name = "buttonEditCustomer";
            this.buttonEditCustomer.Size = new System.Drawing.Size(141, 36);
            this.buttonEditCustomer.TabIndex = 26;
            this.buttonEditCustomer.Text = "Save Changes";
            this.buttonEditCustomer.UseVisualStyleBackColor = true;
            this.buttonEditCustomer.Click += new System.EventHandler(this.ButtonEditCustomer_Click);
            // 
            // labelEmployee
            // 
            this.labelEmployee.AutoSize = true;
            this.labelEmployee.BackColor = System.Drawing.Color.Transparent;
            this.labelEmployee.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployee.Location = new System.Drawing.Point(152, 332);
            this.labelEmployee.Name = "labelEmployee";
            this.labelEmployee.Size = new System.Drawing.Size(70, 16);
            this.labelEmployee.TabIndex = 25;
            this.labelEmployee.Text = "Employee:";
            // 
            // checkBoxEmployee
            // 
            this.checkBoxEmployee.AutoSize = true;
            this.checkBoxEmployee.Location = new System.Drawing.Point(225, 333);
            this.checkBoxEmployee.Name = "checkBoxEmployee";
            this.checkBoxEmployee.Size = new System.Drawing.Size(15, 14);
            this.checkBoxEmployee.TabIndex = 24;
            this.checkBoxEmployee.UseVisualStyleBackColor = true;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(123, 248);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(194, 20);
            this.textBoxAddress.TabIndex = 23;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.BackColor = System.Drawing.Color.Transparent;
            this.labelAddress.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(50, 250);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(60, 16);
            this.labelAddress.TabIndex = 22;
            this.labelAddress.Text = "Address:";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(123, 296);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(194, 20);
            this.textBoxPhone.TabIndex = 21;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.BackColor = System.Drawing.Color.Transparent;
            this.labelPhone.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(50, 298);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(69, 16);
            this.labelPhone.TabIndex = 20;
            this.labelPhone.Text = "Phone No:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(123, 206);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(194, 20);
            this.textBoxLastName.TabIndex = 19;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.BackColor = System.Drawing.Color.Transparent;
            this.labelLastName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.Location = new System.Drawing.Point(50, 208);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(75, 16);
            this.labelLastName.TabIndex = 18;
            this.labelLastName.Text = "Last Name:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(123, 160);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(194, 20);
            this.textBoxFirstName.TabIndex = 17;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.BackColor = System.Drawing.Color.Transparent;
            this.labelFirstName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.Location = new System.Drawing.Point(50, 162);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(76, 16);
            this.labelFirstName.TabIndex = 16;
            this.labelFirstName.Text = "First Name:";
            // 
            // labelEditCustomer
            // 
            this.labelEditCustomer.AutoSize = true;
            this.labelEditCustomer.BackColor = System.Drawing.Color.Transparent;
            this.labelEditCustomer.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditCustomer.Location = new System.Drawing.Point(112, 108);
            this.labelEditCustomer.Name = "labelEditCustomer";
            this.labelEditCustomer.Size = new System.Drawing.Size(205, 32);
            this.labelEditCustomer.TabIndex = 15;
            this.labelEditCustomer.Text = "Edit Customer";
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonReturn.BackgroundImage")));
            this.buttonReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonReturn.Location = new System.Drawing.Point(357, 12);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(36, 33);
            this.buttonReturn.TabIndex = 28;
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.ButtonReturn_Click);
            // 
            // FormEditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(422, 465);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonCancelAddCustomer);
            this.Controls.Add(this.buttonEditCustomer);
            this.Controls.Add(this.labelEmployee);
            this.Controls.Add(this.checkBoxEmployee);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelEditCustomer);
            this.Name = "FormEditCustomer";
            this.Text = "FormEditCustomer";
            this.Controls.SetChildIndex(this.pictureBoxLogo, 0);
            this.Controls.SetChildIndex(this.labelEditCustomer, 0);
            this.Controls.SetChildIndex(this.labelFirstName, 0);
            this.Controls.SetChildIndex(this.textBoxFirstName, 0);
            this.Controls.SetChildIndex(this.labelLastName, 0);
            this.Controls.SetChildIndex(this.textBoxLastName, 0);
            this.Controls.SetChildIndex(this.labelPhone, 0);
            this.Controls.SetChildIndex(this.textBoxPhone, 0);
            this.Controls.SetChildIndex(this.labelAddress, 0);
            this.Controls.SetChildIndex(this.textBoxAddress, 0);
            this.Controls.SetChildIndex(this.checkBoxEmployee, 0);
            this.Controls.SetChildIndex(this.labelEmployee, 0);
            this.Controls.SetChildIndex(this.buttonEditCustomer, 0);
            this.Controls.SetChildIndex(this.buttonCancelAddCustomer, 0);
            this.Controls.SetChildIndex(this.buttonReturn, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelAddCustomer;
        private System.Windows.Forms.Button buttonEditCustomer;
        private System.Windows.Forms.Label labelEmployee;
        private System.Windows.Forms.CheckBox checkBoxEmployee;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelEditCustomer;
        private System.Windows.Forms.Button buttonReturn;
    }
}