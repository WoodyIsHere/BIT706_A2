namespace BIT706Assignment
{
    partial class FormAddCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddCustomer));
            this.labelAddCustomer = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.checkBoxEmployee = new System.Windows.Forms.CheckBox();
            this.labelEmployee = new System.Windows.Forms.Label();
            this.buttonAddCustomer = new System.Windows.Forms.Button();
            this.buttonCancelAddCustomer = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::BIT706Assignment.Properties.Resources.mybank;
            // 
            // labelAddCustomer
            // 
            this.labelAddCustomer.AutoSize = true;
            this.labelAddCustomer.BackColor = System.Drawing.Color.Transparent;
            this.labelAddCustomer.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddCustomer.Location = new System.Drawing.Point(114, 98);
            this.labelAddCustomer.Name = "labelAddCustomer";
            this.labelAddCustomer.Size = new System.Drawing.Size(206, 32);
            this.labelAddCustomer.TabIndex = 2;
            this.labelAddCustomer.Text = "Add Customer";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.BackColor = System.Drawing.Color.Transparent;
            this.labelFirstName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.Location = new System.Drawing.Point(53, 150);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(76, 16);
            this.labelFirstName.TabIndex = 3;
            this.labelFirstName.Text = "First Name:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(126, 148);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(194, 20);
            this.textBoxFirstName.TabIndex = 4;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(126, 201);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(194, 20);
            this.textBoxLastName.TabIndex = 6;
            this.textBoxLastName.TextChanged += new System.EventHandler(this.textBoxLastName_TextChanged);
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.BackColor = System.Drawing.Color.Transparent;
            this.labelLastName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.Location = new System.Drawing.Point(53, 203);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(75, 16);
            this.labelLastName.TabIndex = 5;
            this.labelLastName.Text = "Last Name:";
            this.labelLastName.Click += new System.EventHandler(this.labelLastName_Click);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(126, 314);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(194, 20);
            this.textBoxPhone.TabIndex = 8;
            this.textBoxPhone.TextChanged += new System.EventHandler(this.textBoxPhone_TextChanged);
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.BackColor = System.Drawing.Color.Transparent;
            this.labelPhone.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(53, 316);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(69, 16);
            this.labelPhone.TabIndex = 7;
            this.labelPhone.Text = "Phone No:";
            this.labelPhone.Click += new System.EventHandler(this.labelPhone_Click);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(126, 258);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(194, 20);
            this.textBoxAddress.TabIndex = 10;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.BackColor = System.Drawing.Color.Transparent;
            this.labelAddress.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(53, 260);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(60, 16);
            this.labelAddress.TabIndex = 9;
            this.labelAddress.Text = "Address:";
            // 
            // checkBoxEmployee
            // 
            this.checkBoxEmployee.AutoSize = true;
            this.checkBoxEmployee.Location = new System.Drawing.Point(132, 372);
            this.checkBoxEmployee.Name = "checkBoxEmployee";
            this.checkBoxEmployee.Size = new System.Drawing.Size(15, 14);
            this.checkBoxEmployee.TabIndex = 11;
            this.checkBoxEmployee.UseVisualStyleBackColor = true;
            // 
            // labelEmployee
            // 
            this.labelEmployee.AutoSize = true;
            this.labelEmployee.BackColor = System.Drawing.Color.Transparent;
            this.labelEmployee.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployee.Location = new System.Drawing.Point(59, 371);
            this.labelEmployee.Name = "labelEmployee";
            this.labelEmployee.Size = new System.Drawing.Size(70, 16);
            this.labelEmployee.TabIndex = 12;
            this.labelEmployee.Text = "Employee:";
            // 
            // buttonAddCustomer
            // 
            this.buttonAddCustomer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCustomer.Location = new System.Drawing.Point(196, 415);
            this.buttonAddCustomer.Name = "buttonAddCustomer";
            this.buttonAddCustomer.Size = new System.Drawing.Size(141, 36);
            this.buttonAddCustomer.TabIndex = 13;
            this.buttonAddCustomer.Text = "Add Customer";
            this.buttonAddCustomer.UseVisualStyleBackColor = true;
            this.buttonAddCustomer.Click += new System.EventHandler(this.ButtonAddCustomer_Click);
            // 
            // buttonCancelAddCustomer
            // 
            this.buttonCancelAddCustomer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelAddCustomer.Location = new System.Drawing.Point(12, 415);
            this.buttonCancelAddCustomer.Name = "buttonCancelAddCustomer";
            this.buttonCancelAddCustomer.Size = new System.Drawing.Size(141, 36);
            this.buttonCancelAddCustomer.TabIndex = 14;
            this.buttonCancelAddCustomer.Text = "Cancel";
            this.buttonCancelAddCustomer.UseVisualStyleBackColor = true;
            this.buttonCancelAddCustomer.Click += new System.EventHandler(this.ButtonCancelAddCustomer_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonReturn.BackgroundImage")));
            this.buttonReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonReturn.Location = new System.Drawing.Point(403, 12);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(36, 33);
            this.buttonReturn.TabIndex = 15;
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.ButtonReturn_Click);
            // 
            // FormAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(457, 505);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonCancelAddCustomer);
            this.Controls.Add(this.buttonAddCustomer);
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
            this.Controls.Add(this.labelAddCustomer);
            this.Name = "FormAddCustomer";
            this.Text = "FormAddCustomer";
            this.Load += new System.EventHandler(this.FormAddCustomer_Load);
            this.Controls.SetChildIndex(this.pictureBoxLogo, 0);
            this.Controls.SetChildIndex(this.labelAddCustomer, 0);
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
            this.Controls.SetChildIndex(this.buttonAddCustomer, 0);
            this.Controls.SetChildIndex(this.buttonCancelAddCustomer, 0);
            this.Controls.SetChildIndex(this.buttonReturn, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddCustomer;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.CheckBox checkBoxEmployee;
        private System.Windows.Forms.Label labelEmployee;
        private System.Windows.Forms.Button buttonAddCustomer;
        private System.Windows.Forms.Button buttonCancelAddCustomer;
        private System.Windows.Forms.Button buttonReturn;
    }
}