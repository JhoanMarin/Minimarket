namespace WF_Minimarket
{
    partial class categoriaRegistrar
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
            this.gbRegistroCategoria = new System.Windows.Forms.GroupBox();
            this.btnRegistrarCategoria = new System.Windows.Forms.Button();
            this.txtRegisDescripCategoria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRegisNombreCategoria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorCateRegis = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbRegistroCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorCateRegis)).BeginInit();
            this.SuspendLayout();
            // 
            // gbRegistroCategoria
            // 
            this.gbRegistroCategoria.Controls.Add(this.btnRegistrarCategoria);
            this.gbRegistroCategoria.Controls.Add(this.txtRegisDescripCategoria);
            this.gbRegistroCategoria.Controls.Add(this.label3);
            this.gbRegistroCategoria.Controls.Add(this.txtRegisNombreCategoria);
            this.gbRegistroCategoria.Controls.Add(this.label1);
            this.gbRegistroCategoria.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRegistroCategoria.Location = new System.Drawing.Point(12, 6);
            this.gbRegistroCategoria.Name = "gbRegistroCategoria";
            this.gbRegistroCategoria.Size = new System.Drawing.Size(783, 432);
            this.gbRegistroCategoria.TabIndex = 3;
            this.gbRegistroCategoria.TabStop = false;
            this.gbRegistroCategoria.Text = "Registrar Categoria";
            // 
            // btnRegistrarCategoria
            // 
            this.btnRegistrarCategoria.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRegistrarCategoria.Location = new System.Drawing.Point(359, 370);
            this.btnRegistrarCategoria.Name = "btnRegistrarCategoria";
            this.btnRegistrarCategoria.Size = new System.Drawing.Size(98, 35);
            this.btnRegistrarCategoria.TabIndex = 16;
            this.btnRegistrarCategoria.Text = "&Registrar";
            this.btnRegistrarCategoria.UseVisualStyleBackColor = false;
            this.btnRegistrarCategoria.Click += new System.EventHandler(this.btnRegistrarCategoria_Click);
            // 
            // txtRegisDescripCategoria
            // 
            this.txtRegisDescripCategoria.Location = new System.Drawing.Point(173, 150);
            this.txtRegisDescripCategoria.Name = "txtRegisDescripCategoria";
            this.txtRegisDescripCategoria.Size = new System.Drawing.Size(256, 28);
            this.txtRegisDescripCategoria.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descripción:";
            // 
            // txtRegisNombreCategoria
            // 
            this.txtRegisNombreCategoria.Location = new System.Drawing.Point(173, 48);
            this.txtRegisNombreCategoria.Name = "txtRegisNombreCategoria";
            this.txtRegisNombreCategoria.Size = new System.Drawing.Size(256, 28);
            this.txtRegisNombreCategoria.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // errorCateRegis
            // 
            this.errorCateRegis.ContainerControl = this;
            // 
            // categoriaRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbRegistroCategoria);
            this.Name = "categoriaRegistrar";
            this.Text = "categoriaRegistrar";
            this.Load += new System.EventHandler(this.categoriaRegistrar_Load);
            this.gbRegistroCategoria.ResumeLayout(false);
            this.gbRegistroCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorCateRegis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRegistroCategoria;
        private System.Windows.Forms.Button btnRegistrarCategoria;
        private System.Windows.Forms.TextBox txtRegisDescripCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRegisNombreCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorCateRegis;
    }
}