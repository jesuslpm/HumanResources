namespace HumanResources.WindowsForms
{
    partial class EditEmployeeForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FirstNameControl = new System.Windows.Forms.TextBox();
            this.LastNameControl = new System.Windows.Forms.TextBox();
            this.AddressControl = new System.Windows.Forms.TextBox();
            this.HomePhoneNumberControl = new System.Windows.Forms.TextBox();
            this.CellPhoneNumberControl = new System.Windows.Forms.TextBox();
            this.BirthDateControl = new System.Windows.Forms.DateTimePicker();
            this.SaveButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.FormCancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha Nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Teléfono fijo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Teléfono móvil";
            // 
            // FirstNameControl
            // 
            this.FirstNameControl.Location = new System.Drawing.Point(130, 33);
            this.FirstNameControl.Name = "FirstNameControl";
            this.FirstNameControl.Size = new System.Drawing.Size(192, 20);
            this.FirstNameControl.TabIndex = 7;
            // 
            // LastNameControl
            // 
            this.LastNameControl.Location = new System.Drawing.Point(130, 60);
            this.LastNameControl.Name = "LastNameControl";
            this.LastNameControl.Size = new System.Drawing.Size(192, 20);
            this.LastNameControl.TabIndex = 8;
            // 
            // AddressControl
            // 
            this.AddressControl.Location = new System.Drawing.Point(130, 119);
            this.AddressControl.Name = "AddressControl";
            this.AddressControl.Size = new System.Drawing.Size(192, 20);
            this.AddressControl.TabIndex = 10;
            // 
            // HomePhoneNumberControl
            // 
            this.HomePhoneNumberControl.Location = new System.Drawing.Point(130, 152);
            this.HomePhoneNumberControl.Name = "HomePhoneNumberControl";
            this.HomePhoneNumberControl.Size = new System.Drawing.Size(192, 20);
            this.HomePhoneNumberControl.TabIndex = 11;
            // 
            // CellPhoneNumberControl
            // 
            this.CellPhoneNumberControl.Location = new System.Drawing.Point(130, 183);
            this.CellPhoneNumberControl.Name = "CellPhoneNumberControl";
            this.CellPhoneNumberControl.Size = new System.Drawing.Size(192, 20);
            this.CellPhoneNumberControl.TabIndex = 12;
            // 
            // BirthDateControl
            // 
            this.BirthDateControl.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthDateControl.Location = new System.Drawing.Point(130, 87);
            this.BirthDateControl.Name = "BirthDateControl";
            this.BirthDateControl.Size = new System.Drawing.Size(192, 20);
            this.BirthDateControl.TabIndex = 13;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(19, 224);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 14;
            this.SaveButton.Text = "Guardar";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 0;
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // FormCancelButton
            // 
            this.FormCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.FormCancelButton.Location = new System.Drawing.Point(110, 224);
            this.FormCancelButton.Name = "FormCancelButton";
            this.FormCancelButton.Size = new System.Drawing.Size(75, 23);
            this.FormCancelButton.TabIndex = 15;
            this.FormCancelButton.Text = "Cancelar";
            this.FormCancelButton.UseVisualStyleBackColor = true;
            this.FormCancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // EditEmployeeForm
            // 
            this.AcceptButton = this.SaveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.FormCancelButton;
            this.ClientSize = new System.Drawing.Size(382, 262);
            this.ControlBox = false;
            this.Controls.Add(this.FormCancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.BirthDateControl);
            this.Controls.Add(this.CellPhoneNumberControl);
            this.Controls.Add(this.HomePhoneNumberControl);
            this.Controls.Add(this.AddressControl);
            this.Controls.Add(this.LastNameControl);
            this.Controls.Add(this.FirstNameControl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.EditEmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FirstNameControl;
        private System.Windows.Forms.TextBox LastNameControl;
        private System.Windows.Forms.TextBox AddressControl;
        private System.Windows.Forms.TextBox HomePhoneNumberControl;
        private System.Windows.Forms.TextBox CellPhoneNumberControl;
        private System.Windows.Forms.DateTimePicker BirthDateControl;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button FormCancelButton;
    }
}