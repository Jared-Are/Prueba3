namespace pjFiguraHerencia
{
    partial class frmFigurasTridimensionales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFigurasTridimensionales));
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            txtRadio = new TextBox();
            lblVolumenE = new Label();
            lblAreaE = new Label();
            btnCalcularE = new Button();
            label1 = new Label();
            groupBox2 = new GroupBox();
            pictureBox2 = new PictureBox();
            txtLadoC = new TextBox();
            lblVolumenC = new Label();
            lblAreaC = new Label();
            btnCalcularC = new Button();
            label6 = new Label();
            groupBox3 = new GroupBox();
            pictureBox3 = new PictureBox();
            txtLadoT = new TextBox();
            lblVolumenT = new Label();
            lblAreaT = new Label();
            btnCalcularT = new Button();
            label9 = new Label();
            btnInicio = new Button();
            btnBorrar = new Button();
            btnSalir = new Button();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 224, 192);
            groupBox1.BackgroundImageLayout = ImageLayout.Zoom;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(txtRadio);
            groupBox1.Controls.Add(lblVolumenE);
            groupBox1.Controls.Add(lblAreaE);
            groupBox1.Controls.Add(btnCalcularE);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(283, 381);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Esfera";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(171, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(106, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // txtRadio
            // 
            txtRadio.Location = new Point(10, 88);
            txtRadio.Name = "txtRadio";
            txtRadio.Size = new Size(125, 29);
            txtRadio.TabIndex = 4;
            txtRadio.TextChanged += txtRadio_TextChanged;
            txtRadio.KeyPress += txtRadio_KeyPress;
            // 
            // lblVolumenE
            // 
            lblVolumenE.AutoSize = true;
            lblVolumenE.Location = new Point(10, 290);
            lblVolumenE.Name = "lblVolumenE";
            lblVolumenE.Size = new Size(185, 24);
            lblVolumenE.TabIndex = 3;
            lblVolumenE.Text = "El volumen de la esfera es: ";
            // 
            // lblAreaE
            // 
            lblAreaE.AutoSize = true;
            lblAreaE.Location = new Point(10, 244);
            lblAreaE.Name = "lblAreaE";
            lblAreaE.Size = new Size(151, 24);
            lblAreaE.TabIndex = 2;
            lblAreaE.Text = "El área de la esfera es:";
            // 
            // btnCalcularE
            // 
            btnCalcularE.Location = new Point(152, 157);
            btnCalcularE.Name = "btnCalcularE";
            btnCalcularE.Size = new Size(94, 41);
            btnCalcularE.TabIndex = 1;
            btnCalcularE.Text = "Calcular";
            btnCalcularE.UseVisualStyleBackColor = true;
            btnCalcularE.Click += btnCalcularE_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 56);
            label1.Name = "label1";
            label1.Size = new Size(51, 24);
            label1.TabIndex = 0;
            label1.Text = "Radio:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(255, 224, 192);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(txtLadoC);
            groupBox2.Controls.Add(lblVolumenC);
            groupBox2.Controls.Add(lblAreaC);
            groupBox2.Controls.Add(btnCalcularC);
            groupBox2.Controls.Add(label6);
            groupBox2.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(291, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(292, 381);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cubo";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(180, 28);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(106, 87);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // txtLadoC
            // 
            txtLadoC.Location = new Point(13, 88);
            txtLadoC.Name = "txtLadoC";
            txtLadoC.Size = new Size(125, 29);
            txtLadoC.TabIndex = 4;
            txtLadoC.TextChanged += txtLadoC_TextChanged;
            txtLadoC.KeyPress += txtLadoC_KeyPress;
            // 
            // lblVolumenC
            // 
            lblVolumenC.AutoSize = true;
            lblVolumenC.Location = new Point(6, 290);
            lblVolumenC.Name = "lblVolumenC";
            lblVolumenC.Size = new Size(162, 24);
            lblVolumenC.TabIndex = 3;
            lblVolumenC.Text = "El volumen del cubo es:";
            // 
            // lblAreaC
            // 
            lblAreaC.AutoSize = true;
            lblAreaC.Location = new Point(6, 244);
            lblAreaC.Name = "lblAreaC";
            lblAreaC.Size = new Size(132, 24);
            lblAreaC.TabIndex = 2;
            lblAreaC.Text = "El área del cubo es:";
            // 
            // btnCalcularC
            // 
            btnCalcularC.Location = new Point(163, 157);
            btnCalcularC.Name = "btnCalcularC";
            btnCalcularC.Size = new Size(94, 41);
            btnCalcularC.TabIndex = 1;
            btnCalcularC.Text = "Calcular";
            btnCalcularC.UseVisualStyleBackColor = true;
            btnCalcularC.Click += btnCalcularC_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 56);
            label6.Name = "label6";
            label6.Size = new Size(45, 24);
            label6.TabIndex = 0;
            label6.Text = "Lado:";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(255, 224, 192);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(pictureBox3);
            groupBox3.Controls.Add(txtLadoT);
            groupBox3.Controls.Add(lblVolumenT);
            groupBox3.Controls.Add(lblAreaT);
            groupBox3.Controls.Add(btnCalcularT);
            groupBox3.Controls.Add(label9);
            groupBox3.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(589, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(293, 381);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tetraedro";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(181, 28);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(106, 87);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // txtLadoT
            // 
            txtLadoT.Location = new Point(15, 88);
            txtLadoT.Name = "txtLadoT";
            txtLadoT.Size = new Size(125, 29);
            txtLadoT.TabIndex = 4;
            txtLadoT.TextChanged += txtLadoT_TextChanged;
            txtLadoT.KeyPress += txtLadoT_KeyPress;
            // 
            // lblVolumenT
            // 
            lblVolumenT.AutoSize = true;
            lblVolumenT.Location = new Point(6, 290);
            lblVolumenT.Name = "lblVolumenT";
            lblVolumenT.Size = new Size(191, 24);
            lblVolumenT.TabIndex = 3;
            lblVolumenT.Text = "El volumen del tetraedro es:";
            // 
            // lblAreaT
            // 
            lblAreaT.AutoSize = true;
            lblAreaT.Location = new Point(6, 244);
            lblAreaT.Name = "lblAreaT";
            lblAreaT.Size = new Size(161, 24);
            lblAreaT.TabIndex = 2;
            lblAreaT.Text = "El área del tetraedro es:";
            // 
            // btnCalcularT
            // 
            btnCalcularT.Location = new Point(162, 157);
            btnCalcularT.Name = "btnCalcularT";
            btnCalcularT.Size = new Size(94, 41);
            btnCalcularT.TabIndex = 1;
            btnCalcularT.Text = "Calcular";
            btnCalcularT.UseVisualStyleBackColor = true;
            btnCalcularT.Click += btnCalcularT_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 56);
            label9.Name = "label9";
            label9.Size = new Size(45, 24);
            label9.TabIndex = 0;
            label9.Text = "Lado:";
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.FromArgb(255, 224, 192);
            btnInicio.Location = new Point(771, 389);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(105, 49);
            btnInicio.TabIndex = 6;
            btnInicio.Text = "🏠";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.FromArgb(255, 224, 192);
            btnBorrar.Location = new Point(640, 389);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(101, 49);
            btnBorrar.TabIndex = 7;
            btnBorrar.Text = "🗑";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Red;
            btnSalir.Location = new Point(12, 409);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(136, 93);
            label3.Name = "label3";
            label3.Size = new Size(29, 24);
            label3.TabIndex = 6;
            label3.Text = "cm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(144, 93);
            label2.Name = "label2";
            label2.Size = new Size(29, 24);
            label2.TabIndex = 7;
            label2.Text = "cm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(146, 93);
            label4.Name = "label4";
            label4.Size = new Size(29, 24);
            label4.TabIndex = 8;
            label4.Text = "cm";
            // 
            // frmFigurasTridimensionales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            CausesValidation = false;
            ClientSize = new Size(888, 450);
            ControlBox = false;
            Controls.Add(btnSalir);
            Controls.Add(btnBorrar);
            Controls.Add(btnInicio);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "frmFigurasTridimensionales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Figuras Tridimensionales";
            Load += frmFigurasTridimensionales_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtRadio;
        private Label lblVolumenE;
        private Label lblAreaE;
        private Button btnCalcularE;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txtLadoC;
        private Label lblVolumenC;
        private Label lblAreaC;
        private Button btnCalcularC;
        private Label label6;
        private GroupBox groupBox3;
        private TextBox txtLadoT;
        private Label lblVolumenT;
        private Label lblAreaT;
        private Button btnCalcularT;
        private Label label9;
        private Button btnInicio;
        private Button btnBorrar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button btnSalir;
        private Label label3;
        private Label label2;
        private Label label4;
    }
}