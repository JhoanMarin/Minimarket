namespace WF_Minimarket
{
    partial class ProductoRegistrar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRegisDescripcionProducto = new System.Windows.Forms.TextBox();
            this.cmBoxUniMedi = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRegisProducto = new System.Windows.Forms.Button();
            this.txtRegisPrecioProducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRegisStockProducto = new System.Windows.Forms.TextBox();
            this.txtRegisMarcaProducto = new System.Windows.Forms.TextBox();
            this.txtRegisNombreProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmBoxCaProducto = new System.Windows.Forms.ComboBox();
            this.errorProRegisProducto = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProRegisProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRegisDescripcionProducto);
            this.groupBox1.Controls.Add(this.cmBoxUniMedi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnRegisProducto);
            this.groupBox1.Controls.Add(this.txtRegisPrecioProducto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtRegisStockProducto);
            this.groupBox1.Controls.Add(this.txtRegisMarcaProducto);
            this.groupBox1.Controls.Add(this.txtRegisNombreProducto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmBoxCaProducto);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(731, 426);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro Producto";
            // 
            // txtRegisDescripcionProducto
            // 
            this.txtRegisDescripcionProducto.Location = new System.Drawing.Point(506, 207);
            this.txtRegisDescripcionProducto.Name = "txtRegisDescripcionProducto";
            this.txtRegisDescripcionProducto.Size = new System.Drawing.Size(210, 26);
            this.txtRegisDescripcionProducto.TabIndex = 35;
            // 
            // cmBoxUniMedi
            // 
            this.cmBoxUniMedi.FormattingEnabled = true;
            this.cmBoxUniMedi.Items.AddRange(new object[] {
            "UND",
            "gr"});
            this.cmBoxUniMedi.Location = new System.Drawing.Point(560, 134);
            this.cmBoxUniMedi.Name = "cmBoxUniMedi";
            this.cmBoxUniMedi.Size = new System.Drawing.Size(162, 28);
            this.cmBoxUniMedi.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(390, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 22);
            this.label7.TabIndex = 33;
            this.label7.Text = "Descripcion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(390, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 22);
            this.label6.TabIndex = 32;
            this.label6.Text = "Unidad de Medida:";
            // 
            // btnRegisProducto
            // 
            this.btnRegisProducto.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRegisProducto.Location = new System.Drawing.Point(328, 371);
            this.btnRegisProducto.Name = "btnRegisProducto";
            this.btnRegisProducto.Size = new System.Drawing.Size(98, 35);
            this.btnRegisProducto.TabIndex = 31;
            this.btnRegisProducto.Text = "&Registrar";
            this.btnRegisProducto.UseVisualStyleBackColor = false;
            this.btnRegisProducto.Click += new System.EventHandler(this.btnRegisProducto_Click);
            // 
            // txtRegisPrecioProducto
            // 
            this.txtRegisPrecioProducto.Location = new System.Drawing.Point(158, 209);
            this.txtRegisPrecioProducto.Name = "txtRegisPrecioProducto";
            this.txtRegisPrecioProducto.Size = new System.Drawing.Size(192, 26);
            this.txtRegisPrecioProducto.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 22);
            this.label5.TabIndex = 29;
            this.label5.Text = "Precio De Venta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(390, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 22);
            this.label4.TabIndex = 28;
            this.label4.Text = "Stock:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 22);
            this.label3.TabIndex = 27;
            this.label3.Text = "Marca:";
            // 
            // txtRegisStockProducto
            // 
            this.txtRegisStockProducto.Location = new System.Drawing.Point(506, 77);
            this.txtRegisStockProducto.Name = "txtRegisStockProducto";
            this.txtRegisStockProducto.Size = new System.Drawing.Size(210, 26);
            this.txtRegisStockProducto.TabIndex = 26;
            // 
            // txtRegisMarcaProducto
            // 
            this.txtRegisMarcaProducto.Location = new System.Drawing.Point(103, 140);
            this.txtRegisMarcaProducto.Name = "txtRegisMarcaProducto";
            this.txtRegisMarcaProducto.Size = new System.Drawing.Size(210, 26);
            this.txtRegisMarcaProducto.TabIndex = 25;
            // 
            // txtRegisNombreProducto
            // 
            this.txtRegisNombreProducto.Location = new System.Drawing.Point(103, 276);
            this.txtRegisNombreProducto.Name = "txtRegisNombreProducto";
            this.txtRegisNombreProducto.Size = new System.Drawing.Size(256, 26);
            this.txtRegisNombreProducto.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "Categoria";
            // 
            // cmBoxCaProducto
            // 
            this.cmBoxCaProducto.FormattingEnabled = true;
            this.cmBoxCaProducto.Location = new System.Drawing.Point(109, 81);
            this.cmBoxCaProducto.Name = "cmBoxCaProducto";
            this.cmBoxCaProducto.Size = new System.Drawing.Size(133, 28);
            this.cmBoxCaProducto.TabIndex = 21;
            this.cmBoxCaProducto.SelectedIndexChanged += new System.EventHandler(this.cmBoxCaProducto_SelectedIndexChanged);
            // 
            // errorProRegisProducto
            // 
            this.errorProRegisProducto.ContainerControl = this;
            // 
            // ProductoRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProductoRegistrar";
            this.Text = "ProductoRegistrar";
            this.Load += new System.EventHandler(this.ProductoRegistrar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProRegisProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRegisPrecioProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRegisStockProducto;
        private System.Windows.Forms.TextBox txtRegisMarcaProducto;
        private System.Windows.Forms.TextBox txtRegisNombreProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmBoxCaProducto;
        private System.Windows.Forms.Button btnRegisProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmBoxUniMedi;
        private System.Windows.Forms.TextBox txtRegisDescripcionProducto;
        private System.Windows.Forms.ErrorProvider errorProRegisProducto;
    }
}