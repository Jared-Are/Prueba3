namespace pjFiguraHerencia
{
    partial class frmFigurasBidimensionales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFigurasBidimensionales));
            groupBox2 = new GroupBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            txtLado = new TextBox();
            lblPerimetroCu = new Label();
            lblAreaCu = new Label();
            btnCalcularCu = new Button();
            label6 = new Label();
            groupBox3 = new GroupBox();
            pictureBox3 = new PictureBox();
            label7 = new Label();
            txtAltura = new TextBox();
            label5 = new Label();
            txtBase = new TextBox();
            label2 = new Label();
            lblPerimetroTr = new Label();
            lblAreaTr = new Label();
            btnCalcularT = new Button();
            label9 = new Label();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            txtRadio = new TextBox();
            lblPerimetroCi = new Label();
            lblAreaCi = new Label();
            btnCalcularCi = new Button();
            label1 = new Label();
            btnInicio = new Button();
            btnSalir = new Button();
            btnBorrar = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtLado);
            groupBox2.Controls.Add(lblPerimetroCu);
            groupBox2.Controls.Add(lblAreaCu);
            groupBox2.Controls.Add(btnCalcularCu);
            groupBox2.Controls.Add(label6);
            groupBox2.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(296, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(292, 381);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cuadrado";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(180, 33);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(106, 87);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(137, 91);
            label4.Name = "label4";
            label4.Size = new Size(29, 24);
            label4.TabIndex = 7;
            label4.Text = "cm";
            // 
            // txtLado
            // 
            txtLado.Location = new Point(6, 91);
            txtLado.Name = "txtLado";
            txtLado.Size = new Size(125, 29);
            txtLado.TabIndex = 6;
            txtLado.TextChanged += txtLado_TextChanged;
            txtLado.KeyPress += txtLado_KeyPress;
            // 
            // lblPerimetroCu
            // 
            lblPerimetroCu.AutoSize = true;
            lblPerimetroCu.Location = new Point(6, 290);
            lblPerimetroCu.Name = "lblPerimetroCu";
            lblPerimetroCu.Size = new Size(197, 24);
            lblPerimetroCu.TabIndex = 3;
            lblPerimetroCu.Text = "El perímetro del cuadrado es:";
            // 
            // lblAreaCu
            // 
            lblAreaCu.AutoSize = true;
            lblAreaCu.Location = new Point(6, 244);
            lblAreaCu.Name = "lblAreaCu";
            lblAreaCu.Size = new Size(160, 24);
            lblAreaCu.TabIndex = 2;
            lblAreaCu.Text = "El área del cuadrado es:";
            // 
            // btnCalcularCu
            // 
            btnCalcularCu.Location = new Point(164, 192);
            btnCalcularCu.Name = "btnCalcularCu";
            btnCalcularCu.Size = new Size(94, 41);
            btnCalcularCu.TabIndex = 1;
            btnCalcularCu.Text = "Calcular";
            btnCalcularCu.UseVisualStyleBackColor = true;
            btnCalcularCu.Click += btnCalcularCu_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 56);
            label6.Name = "label6";
            label6.Size = new Size(45, 24);
            label6.TabIndex = 0;
            label6.Text = "Lado:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(pictureBox3);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txtAltura);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(txtBase);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(lblPerimetroTr);
            groupBox3.Controls.Add(lblAreaTr);
            groupBox3.Controls.Add(btnCalcularT);
            groupBox3.Controls.Add(label9);
            groupBox3.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(594, 5);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(293, 381);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Triángulo";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(181, 33);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(106, 87);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(148, 162);
            label7.Name = "label7";
            label7.Size = new Size(29, 24);
            label7.TabIndex = 10;
            label7.Text = "cm";
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(17, 159);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(125, 29);
            txtAltura.TabIndex = 9;
            txtAltura.TextChanged += txtAltura_TextChanged;
            txtAltura.KeyPress += txtAltura_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(148, 91);
            label5.Name = "label5";
            label5.Size = new Size(29, 24);
            label5.TabIndex = 8;
            label5.Text = "cm";
            // 
            // txtBase
            // 
            txtBase.Location = new Point(17, 94);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(125, 29);
            txtBase.TabIndex = 7;
            txtBase.TextChanged += txtBase_TextChanged;
            txtBase.KeyPress += txtBase_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 127);
            label2.Name = "label2";
            label2.Size = new Size(53, 24);
            label2.TabIndex = 5;
            label2.Text = "Altura:";
            // 
            // lblPerimetroTr
            // 
            lblPerimetroTr.AutoSize = true;
            lblPerimetroTr.Location = new Point(6, 290);
            lblPerimetroTr.Name = "lblPerimetroTr";
            lblPerimetroTr.Size = new Size(198, 24);
            lblPerimetroTr.TabIndex = 3;
            lblPerimetroTr.Text = "El perímetro del triángulo es:";
            // 
            // lblAreaTr
            // 
            lblAreaTr.AutoSize = true;
            lblAreaTr.Location = new Point(6, 244);
            lblAreaTr.Name = "lblAreaTr";
            lblAreaTr.Size = new Size(161, 24);
            lblAreaTr.TabIndex = 2;
            lblAreaTr.Text = "El área del triángulo es:";
            // 
            // btnCalcularT
            // 
            btnCalcularT.Location = new Point(171, 192);
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
            label9.Location = new Point(17, 56);
            label9.Name = "label9";
            label9.Size = new Size(43, 24);
            label9.TabIndex = 0;
            label9.Text = "Base:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtRadio);
            groupBox1.Controls.Add(lblPerimetroCi);
            groupBox1.Controls.Add(lblAreaCi);
            groupBox1.Controls.Add(btnCalcularCi);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(7, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(283, 381);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Círculo";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(172, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(106, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(137, 91);
            label3.Name = "label3";
            label3.Size = new Size(29, 24);
            label3.TabIndex = 5;
            label3.Text = "cm";
            // 
            // txtRadio
            // 
            txtRadio.Location = new Point(6, 88);
            txtRadio.Name = "txtRadio";
            txtRadio.Size = new Size(125, 29);
            txtRadio.TabIndex = 4;
            txtRadio.TextChanged += txtRadio_TextChanged;
            txtRadio.KeyPress += txtRadio_KeyPress;
            // 
            // lblPerimetroCi
            // 
            lblPerimetroCi.AutoSize = true;
            lblPerimetroCi.Location = new Point(8, 290);
            lblPerimetroCi.Name = "lblPerimetroCi";
            lblPerimetroCi.Size = new Size(185, 24);
            lblPerimetroCi.TabIndex = 3;
            lblPerimetroCi.Text = "El perímetro del círculo es: ";
            // 
            // lblAreaCi
            // 
            lblAreaCi.AutoSize = true;
            lblAreaCi.Location = new Point(6, 244);
            lblAreaCi.Name = "lblAreaCi";
            lblAreaCi.Size = new Size(144, 24);
            lblAreaCi.TabIndex = 2;
            lblAreaCi.Text = "El área del círculo es:";
            // 
            // btnCalcularCi
            // 
            btnCalcularCi.ForeColor = SystemColors.ActiveCaptionText;
            btnCalcularCi.Location = new Point(163, 192);
            btnCalcularCi.Name = "btnCalcularCi";
            btnCalcularCi.Size = new Size(94, 41);
            btnCalcularCi.TabIndex = 1;
            btnCalcularCi.Text = "Calcular";
            btnCalcularCi.UseVisualStyleBackColor = true;
            btnCalcularCi.Click += btnCalcularCi_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 56);
            label1.Name = "label1";
            label1.Size = new Size(51, 24);
            label1.TabIndex = 0;
            label1.Text = "Radio:";
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.FromArgb(255, 224, 192);
            btnInicio.Location = new Point(765, 392);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(105, 49);
            btnInicio.TabIndex = 7;
            btnInicio.Text = "🏠";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Red;
            btnSalir.Location = new Point(15, 402);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.FromArgb(255, 224, 192);
            btnBorrar.Location = new Point(658, 392);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(101, 49);
            btnBorrar.TabIndex = 10;
            btnBorrar.Text = "🗑";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // frmFigurasBidimensionales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            CausesValidation = false;
            ClientSize = new Size(888, 450);
            ControlBox = false;
            Controls.Add(btnBorrar);
            Controls.Add(btnSalir);
            Controls.Add(btnInicio);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "frmFigurasBidimensionales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Figuras Bidimensionales";
            Load += frmFigurasBidimensionales_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox2;
        private Label lblPerimetroCu;
        private Label lblAreaCu;
        private Button btnCalcularCu;
        private Label label6;
        private GroupBox groupBox3;
        private Label lblPerimetroTr;
        private Label lblAreaTr;
        private Button btnCalcularT;
        private Label label9;
        private GroupBox groupBox1;
        private TextBox txtRadio;
        private Label lblPerimetroCi;
        private Label lblAreaCi;
        private Button btnCalcularCi;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtLado;
        private Label label7;
        private TextBox txtAltura;
        private Label label5;
        private TextBox txtBase;
        private Button btnInicio;
        private Button btnSalir;
        private Button btnBorrar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}