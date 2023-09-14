namespace pjFiguraHerencia
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            btnFigTridimensional = new Button();
            btnFigBidimensional = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnFigTridimensional
            // 
            btnFigTridimensional.BackColor = Color.FromArgb(128, 128, 255);
            btnFigTridimensional.Location = new Point(345, 129);
            btnFigTridimensional.Margin = new Padding(3, 4, 3, 4);
            btnFigTridimensional.Name = "btnFigTridimensional";
            btnFigTridimensional.Size = new Size(194, 31);
            btnFigTridimensional.TabIndex = 5;
            btnFigTridimensional.Text = "Figuras Tridimensionales";
            btnFigTridimensional.UseVisualStyleBackColor = false;
            btnFigTridimensional.Click += btnFigTridimensional_Click;
            // 
            // btnFigBidimensional
            // 
            btnFigBidimensional.BackColor = Color.FromArgb(255, 128, 128);
            btnFigBidimensional.Location = new Point(110, 129);
            btnFigBidimensional.Margin = new Padding(3, 4, 3, 4);
            btnFigBidimensional.Name = "btnFigBidimensional";
            btnFigBidimensional.Size = new Size(177, 31);
            btnFigBidimensional.TabIndex = 4;
            btnFigBidimensional.Text = "Figuras Bidimensionales";
            btnFigBidimensional.UseVisualStyleBackColor = false;
            btnFigBidimensional.Click += btnFigBidimensional_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(192, 63);
            label1.Name = "label1";
            label1.Size = new Size(271, 32);
            label1.TabIndex = 3;
            label1.Text = "Calculadora de figuras";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(82, 167);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 126);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(345, 167);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(205, 126);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Red;
            btnSalir.Location = new Point(12, 302);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            CausesValidation = false;
            ClientSize = new Size(643, 343);
            ControlBox = false;
            Controls.Add(btnSalir);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnFigTridimensional);
            Controls.Add(btnFigBidimensional);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "frmMenu";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú principal";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFigTridimensional;
        private Button btnFigBidimensional;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnSalir;
    }
}