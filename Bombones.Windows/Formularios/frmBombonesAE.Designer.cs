namespace Bombones.Windows.Formularios
{
    partial class frmBombonesAE
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBombonesAE));
            cboFabricas = new ComboBox();
            btnCancelar = new Button();
            btnOk = new Button();
            label10 = new Label();
            chkSuspendido = new CheckBox();
            txtNivelDeReposicion = new TextBox();
            label9 = new Label();
            txtStock = new TextBox();
            label7 = new Label();
            btnBuscarImagen = new Button();
            groupBox3 = new GroupBox();
            picImagen = new PictureBox();
            groupBox2 = new GroupBox();
            txtPrecioVta = new TextBox();
            txtPrecioCosto = new TextBox();
            label6 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            cboNueces = new ComboBox();
            cboRellenos = new ComboBox();
            cboChocolates = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtDescripcion = new TextBox();
            label8 = new Label();
            txtBombon = new TextBox();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picImagen).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // cboFabricas
            // 
            cboFabricas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFabricas.FormattingEnabled = true;
            cboFabricas.Location = new Point(169, 407);
            cboFabricas.Margin = new Padding(3, 4, 3, 4);
            cboFabricas.Name = "cboFabricas";
            cboFabricas.Size = new Size(241, 28);
            cboFabricas.TabIndex = 16;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.Cancelar;
            btnCancelar.Location = new Point(528, 607);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 72);
            btnCancelar.TabIndex = 26;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnOk
            // 
            btnOk.Image = (Image)resources.GetObject("btnOk.Image");
            btnOk.Location = new Point(149, 607);
            btnOk.Margin = new Padding(3, 4, 3, 4);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(330, 72);
            btnOk.TabIndex = 27;
            btnOk.Text = "Ok";
            btnOk.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(72, 411);
            label10.Name = "label10";
            label10.Size = new Size(59, 20);
            label10.TabIndex = 13;
            label10.Text = "Fábrica:";
            // 
            // chkSuspendido
            // 
            chkSuspendido.AutoSize = true;
            chkSuspendido.Location = new Point(618, 52);
            chkSuspendido.Margin = new Padding(3, 4, 3, 4);
            chkSuspendido.Name = "chkSuspendido";
            chkSuspendido.Size = new Size(109, 24);
            chkSuspendido.TabIndex = 25;
            chkSuspendido.Text = "Suspendido";
            chkSuspendido.UseVisualStyleBackColor = true;
            // 
            // txtNivelDeReposicion
            // 
            txtNivelDeReposicion.Location = new Point(391, 536);
            txtNivelDeReposicion.Margin = new Padding(3, 4, 3, 4);
            txtNivelDeReposicion.Name = "txtNivelDeReposicion";
            txtNivelDeReposicion.Size = new Size(98, 27);
            txtNivelDeReposicion.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(240, 543);
            label9.Name = "label9";
            label9.Size = new Size(144, 20);
            label9.TabIndex = 21;
            label9.Text = "Nivel de Reposición:";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(115, 536);
            txtStock.Margin = new Padding(3, 4, 3, 4);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(98, 27);
            txtStock.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(64, 540);
            label7.Name = "label7";
            label7.Size = new Size(48, 20);
            label7.TabIndex = 22;
            label7.Text = "Stock:";
            // 
            // btnBuscarImagen
            // 
            btnBuscarImagen.Image = Properties.Resources.Buscar;
            btnBuscarImagen.Location = new Point(529, 493);
            btnBuscarImagen.Margin = new Padding(3, 4, 3, 4);
            btnBuscarImagen.Name = "btnBuscarImagen";
            btnBuscarImagen.Size = new Size(208, 65);
            btnBuscarImagen.TabIndex = 20;
            btnBuscarImagen.Text = "Buscar";
            btnBuscarImagen.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscarImagen.UseVisualStyleBackColor = true;
            btnBuscarImagen.Click += btnBuscarImagen_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(picImagen);
            groupBox3.Location = new Point(526, 235);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(211, 251);
            groupBox3.TabIndex = 19;
            groupBox3.TabStop = false;
            groupBox3.Text = " Imágen ";
            // 
            // picImagen
            // 
            picImagen.Location = new Point(19, 28);
            picImagen.Margin = new Padding(3, 4, 3, 4);
            picImagen.Name = "picImagen";
            picImagen.Size = new Size(174, 203);
            picImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            picImagen.TabIndex = 0;
            picImagen.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtPrecioVta);
            groupBox2.Controls.Add(txtPrecioCosto);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(56, 439);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(433, 89);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = " Precios ";
            // 
            // txtPrecioVta
            // 
            txtPrecioVta.Location = new Point(299, 33);
            txtPrecioVta.Margin = new Padding(3, 4, 3, 4);
            txtPrecioVta.Name = "txtPrecioVta";
            txtPrecioVta.Size = new Size(114, 27);
            txtPrecioVta.TabIndex = 1;
            // 
            // txtPrecioCosto
            // 
            txtPrecioCosto.Location = new Point(93, 31);
            txtPrecioCosto.Margin = new Padding(3, 4, 3, 4);
            txtPrecioCosto.Name = "txtPrecioCosto";
            txtPrecioCosto.Size = new Size(114, 27);
            txtPrecioCosto.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(222, 36);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 0;
            label6.Text = "P. Vta.:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 33);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 0;
            label5.Text = "P. Costo:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboNueces);
            groupBox1.Controls.Add(cboRellenos);
            groupBox1.Controls.Add(cboChocolates);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(56, 235);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(433, 164);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = " Ingredientes ";
            // 
            // cboNueces
            // 
            cboNueces.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNueces.FormattingEnabled = true;
            cboNueces.Location = new Point(113, 117);
            cboNueces.Margin = new Padding(3, 4, 3, 4);
            cboNueces.Name = "cboNueces";
            cboNueces.Size = new Size(241, 28);
            cboNueces.TabIndex = 1;
            // 
            // cboRellenos
            // 
            cboRellenos.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRellenos.FormattingEnabled = true;
            cboRellenos.Location = new Point(113, 76);
            cboRellenos.Margin = new Padding(3, 4, 3, 4);
            cboRellenos.Name = "cboRellenos";
            cboRellenos.Size = new Size(241, 28);
            cboRellenos.TabIndex = 1;
            // 
            // cboChocolates
            // 
            cboChocolates.DropDownStyle = ComboBoxStyle.DropDownList;
            cboChocolates.FormattingEnabled = true;
            cboChocolates.Location = new Point(113, 32);
            cboChocolates.Margin = new Padding(3, 4, 3, 4);
            cboChocolates.Name = "cboChocolates";
            cboChocolates.Size = new Size(241, 28);
            cboChocolates.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 121);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 0;
            label4.Text = "Nuez:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 80);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 0;
            label3.Text = "Relleno:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 36);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 0;
            label2.Text = "Chocolate:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(128, 91);
            txtDescripcion.Margin = new Padding(3, 4, 3, 4);
            txtDescripcion.MaxLength = 256;
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(470, 120);
            txtDescripcion.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(47, 95);
            label8.Name = "label8";
            label8.Size = new Size(90, 20);
            label8.TabIndex = 12;
            label8.Text = "Descripción:";
            // 
            // txtBombon
            // 
            txtBombon.Location = new Point(128, 52);
            txtBombon.Margin = new Padding(3, 4, 3, 4);
            txtBombon.MaxLength = 120;
            txtBombon.Name = "txtBombon";
            txtBombon.Size = new Size(470, 27);
            txtBombon.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 56);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 11;
            label1.Text = "Bombón:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmBombonesAE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 709);
            Controls.Add(cboFabricas);
            Controls.Add(btnCancelar);
            Controls.Add(btnOk);
            Controls.Add(label10);
            Controls.Add(chkSuspendido);
            Controls.Add(txtNivelDeReposicion);
            Controls.Add(label9);
            Controls.Add(txtStock);
            Controls.Add(label7);
            Controls.Add(btnBuscarImagen);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtDescripcion);
            Controls.Add(label8);
            Controls.Add(txtBombon);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmBombonesAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmBombonesAE";
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picImagen).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboFabricas;
        private Button btnCancelar;
        private Button btnOk;
        private Label label10;
        private CheckBox chkSuspendido;
        private TextBox txtNivelDeReposicion;
        private Label label9;
        private TextBox txtStock;
        private Label label7;
        private Button btnBuscarImagen;
        private GroupBox groupBox3;
        private PictureBox picImagen;
        private GroupBox groupBox2;
        private TextBox txtPrecioVta;
        private TextBox txtPrecioCosto;
        private Label label6;
        private Label label5;
        private GroupBox groupBox1;
        private ComboBox cboNueces;
        private ComboBox cboRellenos;
        private ComboBox cboChocolates;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtDescripcion;
        private Label label8;
        private TextBox txtBombon;
        private Label label1;
        private ErrorProvider errorProvider1;
        private OpenFileDialog openFileDialog1;
    }
}