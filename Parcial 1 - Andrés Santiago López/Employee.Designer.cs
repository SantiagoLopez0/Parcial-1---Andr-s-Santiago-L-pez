namespace Parcial_1___Andrés_Santiago_López
{
    partial class Employee
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.precioVentaInput = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cantidadPanesInput = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tipoDePanesCheckList = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nombreClienteInput = new System.Windows.Forms.TextBox();
            this.cedulaInput = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.volverLoginBtn = new System.Windows.Forms.Button();
            this.registrarVentaBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fechaInput = new System.Windows.Forms.DateTimePicker();
            this.registroRtxt = new System.Windows.Forms.RichTextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.precioVentaInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadPanesInput)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cedulaInput)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(352, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Producto";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.precioVentaInput);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cantidadPanesInput);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 422);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Producto";
            // 
            // precioVentaInput
            // 
            this.precioVentaInput.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.precioVentaInput.Location = new System.Drawing.Point(6, 345);
            this.precioVentaInput.Name = "precioVentaInput";
            this.precioVentaInput.Size = new System.Drawing.Size(266, 33);
            this.precioVentaInput.TabIndex = 2;
            this.precioVentaInput.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            this.precioVentaInput.Validating += new System.ComponentModel.CancelEventHandler(this.precioVentaInput_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 50);
            this.label6.TabIndex = 4;
            this.label6.Text = "Precio Total de la venta\r\n(Sin signos ni puntos)";
            this.label6.Click += new System.EventHandler(this.label3_Click);
            // 
            // cantidadPanesInput
            // 
            this.cantidadPanesInput.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cantidadPanesInput.Location = new System.Drawing.Point(6, 74);
            this.cantidadPanesInput.Name = "cantidadPanesInput";
            this.cantidadPanesInput.Size = new System.Drawing.Size(266, 33);
            this.cantidadPanesInput.TabIndex = 2;
            this.cantidadPanesInput.Validating += new System.ComponentModel.CancelEventHandler(this.cantidadPanesInput_Validating);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tipoDePanesCheckList);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(6, 138);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(294, 126);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Panes Seleccionados";
            // 
            // tipoDePanesCheckList
            // 
            this.tipoDePanesCheckList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tipoDePanesCheckList.FormattingEnabled = true;
            this.tipoDePanesCheckList.Items.AddRange(new object[] {
            "Aliñado",
            "No Aliñado",
            "Especial"});
            this.tipoDePanesCheckList.Location = new System.Drawing.Point(6, 37);
            this.tipoDePanesCheckList.Name = "tipoDePanesCheckList";
            this.tipoDePanesCheckList.Size = new System.Drawing.Size(267, 76);
            this.tipoDePanesCheckList.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cantidad de Panes";
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // nombreClienteInput
            // 
            this.nombreClienteInput.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nombreClienteInput.Location = new System.Drawing.Point(6, 74);
            this.nombreClienteInput.Name = "nombreClienteInput";
            this.nombreClienteInput.Size = new System.Drawing.Size(266, 33);
            this.nombreClienteInput.TabIndex = 1;
            this.nombreClienteInput.Validating += new System.ComponentModel.CancelEventHandler(this.nombreClienteInput_Validating);
            // 
            // cedulaInput
            // 
            this.cedulaInput.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cedulaInput.Location = new System.Drawing.Point(6, 166);
            this.cedulaInput.Name = "cedulaInput";
            this.cedulaInput.Size = new System.Drawing.Size(266, 33);
            this.cedulaInput.TabIndex = 2;
            this.cedulaInput.Validating += new System.ComponentModel.CancelEventHandler(this.cedulaInput_Validating);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.volverLoginBtn);
            this.groupBox2.Controls.Add(this.registrarVentaBtn);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.fechaInput);
            this.groupBox2.Controls.Add(this.nombreClienteInput);
            this.groupBox2.Controls.Add(this.cedulaInput);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(338, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 422);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente";
            // 
            // volverLoginBtn
            // 
            this.volverLoginBtn.Location = new System.Drawing.Point(70, 359);
            this.volverLoginBtn.Name = "volverLoginBtn";
            this.volverLoginBtn.Size = new System.Drawing.Size(153, 33);
            this.volverLoginBtn.TabIndex = 5;
            this.volverLoginBtn.Text = "Cerrar Sesión";
            this.volverLoginBtn.UseVisualStyleBackColor = true;
            this.volverLoginBtn.Click += new System.EventHandler(this.volverLoginBtn_Click);
            // 
            // registrarVentaBtn
            // 
            this.registrarVentaBtn.Location = new System.Drawing.Point(70, 320);
            this.registrarVentaBtn.Name = "registrarVentaBtn";
            this.registrarVentaBtn.Size = new System.Drawing.Size(153, 33);
            this.registrarVentaBtn.TabIndex = 5;
            this.registrarVentaBtn.Text = "Registrar Venta";
            this.registrarVentaBtn.UseVisualStyleBackColor = true;
            this.registrarVentaBtn.Click += new System.EventHandler(this.registrarVentaBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha de la venta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cedula";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre y Apellidos";
            // 
            // fechaInput
            // 
            this.fechaInput.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fechaInput.Location = new System.Drawing.Point(6, 257);
            this.fechaInput.Name = "fechaInput";
            this.fechaInput.Size = new System.Drawing.Size(266, 33);
            this.fechaInput.TabIndex = 3;
            this.fechaInput.Validating += new System.ComponentModel.CancelEventHandler(this.fechaInput_Validating);
            // 
            // registroRtxt
            // 
            this.registroRtxt.Location = new System.Drawing.Point(622, 98);
            this.registroRtxt.Name = "registroRtxt";
            this.registroRtxt.Size = new System.Drawing.Size(401, 409);
            this.registroRtxt.TabIndex = 4;
            this.registroRtxt.Text = "";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 519);
            this.Controls.Add(this.registroRtxt);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Employee";
            this.Text = "Employee";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.precioVentaInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadPanesInput)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cedulaInput)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nombreClienteInput;
        private System.Windows.Forms.NumericUpDown cedulaInput;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fechaInput;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckedListBox tipoDePanesCheckList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown precioVentaInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown cantidadPanesInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button volverLoginBtn;
        private System.Windows.Forms.Button registrarVentaBtn;
        private System.Windows.Forms.RichTextBox registroRtxt;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}