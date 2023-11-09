namespace WF_Minimarket
{
    partial class ClienteActualizar
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
            this.dgvConsultarCliente = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefonoClienteAc = new System.Windows.Forms.TextBox();
            this.txtCorreoClienteAc = new System.Windows.Forms.TextBox();
            this.txtApellidoClienteAc = new System.Windows.Forms.TextBox();
            this.txtNombreClienteAc = new System.Windows.Forms.TextBox();
            this.txtIdentificacionClienteAc = new System.Windows.Forms.TextBox();
            this.txtIdClienteAc = new System.Windows.Forms.TextBox();
            this.cbTipoDocumentoAcCliente = new System.Windows.Forms.ComboBox();
            this.BtnActualizarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarCliente)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvConsultarCliente
            // 
            this.dgvConsultarCliente.AllowUserToAddRows = false;
            this.dgvConsultarCliente.AllowUserToDeleteRows = false;
            this.dgvConsultarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarCliente.Location = new System.Drawing.Point(12, 12);
            this.dgvConsultarCliente.Name = "dgvConsultarCliente";
            this.dgvConsultarCliente.ReadOnly = true;
            this.dgvConsultarCliente.RowHeadersWidth = 51;
            this.dgvConsultarCliente.Size = new System.Drawing.Size(837, 252);
            this.dgvConsultarCliente.TabIndex = 2;
            this.dgvConsultarCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultarCliente_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtTelefonoClienteAc);
            this.groupBox2.Controls.Add(this.txtCorreoClienteAc);
            this.groupBox2.Controls.Add(this.txtApellidoClienteAc);
            this.groupBox2.Controls.Add(this.txtNombreClienteAc);
            this.groupBox2.Controls.Add(this.txtIdentificacionClienteAc);
            this.groupBox2.Controls.Add(this.txtIdClienteAc);
            this.groupBox2.Controls.Add(this.cbTipoDocumentoAcCliente);
            this.groupBox2.Controls.Add(this.BtnActualizarCliente);
            this.groupBox2.Location = new System.Drawing.Point(11, 269);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(832, 292);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(296, 23);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(246, 26);
            this.label10.TabIndex = 49;
            this.label10.Text = "ACTUALIZAR CLIENTE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(487, 116);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 48;
            this.label9.Text = "Nombre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(481, 193);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 47;
            this.label8.Text = "Telefono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(430, 117);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(494, 153);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 45;
            this.label6.Text = "Correo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 77);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 44;
            this.label5.Text = "Id Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Identificacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(430, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Tipo Documento";
            // 
            // txtTelefonoClienteAc
            // 
            this.txtTelefonoClienteAc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoClienteAc.Location = new System.Drawing.Point(561, 190);
            this.txtTelefonoClienteAc.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefonoClienteAc.Name = "txtTelefonoClienteAc";
            this.txtTelefonoClienteAc.Size = new System.Drawing.Size(194, 26);
            this.txtTelefonoClienteAc.TabIndex = 39;
            // 
            // txtCorreoClienteAc
            // 
            this.txtCorreoClienteAc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoClienteAc.Location = new System.Drawing.Point(561, 150);
            this.txtCorreoClienteAc.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreoClienteAc.Name = "txtCorreoClienteAc";
            this.txtCorreoClienteAc.Size = new System.Drawing.Size(194, 26);
            this.txtCorreoClienteAc.TabIndex = 37;
            // 
            // txtApellidoClienteAc
            // 
            this.txtApellidoClienteAc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoClienteAc.Location = new System.Drawing.Point(141, 155);
            this.txtApellidoClienteAc.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellidoClienteAc.Name = "txtApellidoClienteAc";
            this.txtApellidoClienteAc.Size = new System.Drawing.Size(185, 26);
            this.txtApellidoClienteAc.TabIndex = 36;
            // 
            // txtNombreClienteAc
            // 
            this.txtNombreClienteAc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreClienteAc.Location = new System.Drawing.Point(561, 112);
            this.txtNombreClienteAc.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreClienteAc.Name = "txtNombreClienteAc";
            this.txtNombreClienteAc.Size = new System.Drawing.Size(194, 26);
            this.txtNombreClienteAc.TabIndex = 35;
            // 
            // txtIdentificacionClienteAc
            // 
            this.txtIdentificacionClienteAc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificacionClienteAc.Location = new System.Drawing.Point(141, 112);
            this.txtIdentificacionClienteAc.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdentificacionClienteAc.Name = "txtIdentificacionClienteAc";
            this.txtIdentificacionClienteAc.Size = new System.Drawing.Size(185, 26);
            this.txtIdentificacionClienteAc.TabIndex = 34;
            // 
            // txtIdClienteAc
            // 
            this.txtIdClienteAc.Enabled = false;
            this.txtIdClienteAc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdClienteAc.Location = new System.Drawing.Point(141, 72);
            this.txtIdClienteAc.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdClienteAc.Name = "txtIdClienteAc";
            this.txtIdClienteAc.Size = new System.Drawing.Size(185, 26);
            this.txtIdClienteAc.TabIndex = 33;
            // 
            // cbTipoDocumentoAcCliente
            // 
            this.cbTipoDocumentoAcCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoDocumentoAcCliente.FormattingEnabled = true;
            this.cbTipoDocumentoAcCliente.Items.AddRange(new object[] {
            "CC",
            "PAS",
            "CE",
            "PEP"});
            this.cbTipoDocumentoAcCliente.Location = new System.Drawing.Point(561, 72);
            this.cbTipoDocumentoAcCliente.Margin = new System.Windows.Forms.Padding(2);
            this.cbTipoDocumentoAcCliente.Name = "cbTipoDocumentoAcCliente";
            this.cbTipoDocumentoAcCliente.Size = new System.Drawing.Size(194, 28);
            this.cbTipoDocumentoAcCliente.TabIndex = 32;
            // 
            // BtnActualizarCliente
            // 
            this.BtnActualizarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizarCliente.Location = new System.Drawing.Point(338, 232);
            this.BtnActualizarCliente.Name = "BtnActualizarCliente";
            this.BtnActualizarCliente.Size = new System.Drawing.Size(153, 50);
            this.BtnActualizarCliente.TabIndex = 31;
            this.BtnActualizarCliente.Text = "ACTUALIZAR";
            this.BtnActualizarCliente.UseVisualStyleBackColor = true;
            this.BtnActualizarCliente.Click += new System.EventHandler(this.BtnActualizarCliente_Click);
            // 
            // ClienteActualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 572);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvConsultarCliente);
            this.Name = "ClienteActualizar";
            this.Text = "ClienteActualizar";
            this.Load += new System.EventHandler(this.ClienteActualizar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarCliente)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultarCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefonoClienteAc;
        private System.Windows.Forms.TextBox txtCorreoClienteAc;
        private System.Windows.Forms.TextBox txtApellidoClienteAc;
        private System.Windows.Forms.TextBox txtNombreClienteAc;
        private System.Windows.Forms.TextBox txtIdentificacionClienteAc;
        private System.Windows.Forms.TextBox txtIdClienteAc;
        private System.Windows.Forms.ComboBox cbTipoDocumentoAcCliente;
        private System.Windows.Forms.Button BtnActualizarCliente;
    }
}