namespace WF_Minimarket
{
    partial class CategoriaActualizar
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
            this.dgvConsultarCategoria = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtIdCatAc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnGuardarCategoria = new System.Windows.Forms.Button();
            this.txtDescripciónCategoriaAc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreCatAc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarCategoria)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvConsultarCategoria
            // 
            this.dgvConsultarCategoria.AllowUserToAddRows = false;
            this.dgvConsultarCategoria.AllowUserToDeleteRows = false;
            this.dgvConsultarCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarCategoria.Location = new System.Drawing.Point(12, 1);
            this.dgvConsultarCategoria.Name = "dgvConsultarCategoria";
            this.dgvConsultarCategoria.ReadOnly = true;
            this.dgvConsultarCategoria.RowHeadersWidth = 51;
            this.dgvConsultarCategoria.Size = new System.Drawing.Size(785, 194);
            this.dgvConsultarCategoria.TabIndex = 3;
            this.dgvConsultarCategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultarCategoria_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtIdCatAc);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.BtnGuardarCategoria);
            this.groupBox2.Controls.Add(this.txtDescripciónCategoriaAc);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtNombreCatAc);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 200);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(786, 261);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // txtIdCatAc
            // 
            this.txtIdCatAc.Enabled = false;
            this.txtIdCatAc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCatAc.Location = new System.Drawing.Point(156, 76);
            this.txtIdCatAc.Name = "txtIdCatAc";
            this.txtIdCatAc.Size = new System.Drawing.Size(198, 26);
            this.txtIdCatAc.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(244, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "ID";
            // 
            // BtnGuardarCategoria
            // 
            this.BtnGuardarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarCategoria.Location = new System.Drawing.Point(338, 209);
            this.BtnGuardarCategoria.Name = "BtnGuardarCategoria";
            this.BtnGuardarCategoria.Size = new System.Drawing.Size(150, 44);
            this.BtnGuardarCategoria.TabIndex = 18;
            this.BtnGuardarCategoria.Text = "Guardar";
            this.BtnGuardarCategoria.UseVisualStyleBackColor = true;
            this.BtnGuardarCategoria.Click += new System.EventHandler(this.BtnGuardarCategoria_Click);
            // 
            // txtDescripciónCategoriaAc
            // 
            this.txtDescripciónCategoriaAc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripciónCategoriaAc.Location = new System.Drawing.Point(268, 160);
            this.txtDescripciónCategoriaAc.Name = "txtDescripciónCategoriaAc";
            this.txtDescripciónCategoriaAc.Size = new System.Drawing.Size(299, 26);
            this.txtDescripciónCategoriaAc.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(376, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Descripción";
            // 
            // txtNombreCatAc
            // 
            this.txtNombreCatAc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCatAc.Location = new System.Drawing.Point(509, 76);
            this.txtNombreCatAc.Name = "txtNombreCatAc";
            this.txtNombreCatAc.Size = new System.Drawing.Size(198, 26);
            this.txtNombreCatAc.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(578, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nombre";
            // 
            // CategoriaActualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvConsultarCategoria);
            this.Name = "CategoriaActualizar";
            this.Text = "CategoriaActualizar";
            this.Load += new System.EventHandler(this.CategoriaActualizar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarCategoria)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultarCategoria;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtIdCatAc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnGuardarCategoria;
        private System.Windows.Forms.TextBox txtDescripciónCategoriaAc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombreCatAc;
        private System.Windows.Forms.Label label1;
    }
}