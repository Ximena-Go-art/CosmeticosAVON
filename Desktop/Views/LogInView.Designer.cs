namespace Desktop.Views
{
    partial class LogInView
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            TxtEmail = new TextBox();
            TxtPassword = new TextBox();
            CheckContraseña = new CheckBox();
            BtnIniciarSesion = new Button();
            BtnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.freepik_br_d2a507e3_8644_4ed5_999a_ad8e9f7e4b33;
            pictureBox1.Location = new Point(-37, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(421, 394);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(371, 130);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 2;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(371, 195);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(452, 123);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(296, 27);
            TxtEmail.TabIndex = 4;
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(452, 192);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '*';
            TxtPassword.Size = new Size(296, 27);
            TxtPassword.TabIndex = 5;
            // 
            // CheckContraseña
            // 
            CheckContraseña.AutoSize = true;
            CheckContraseña.ForeColor = SystemColors.ActiveCaptionText;
            CheckContraseña.Location = new Point(548, 246);
            CheckContraseña.Name = "CheckContraseña";
            CheckContraseña.Size = new Size(117, 24);
            CheckContraseña.TabIndex = 6;
            CheckContraseña.Text = "Ver Password";
            CheckContraseña.UseVisualStyleBackColor = true;
            CheckContraseña.CheckedChanged += CheckContraseña_CheckedChanged;
            // 
            // BtnIniciarSesion
            // 
            BtnIniciarSesion.ForeColor = SystemColors.ActiveCaptionText;
            BtnIniciarSesion.Location = new Point(425, 301);
            BtnIniciarSesion.Name = "BtnIniciarSesion";
            BtnIniciarSesion.Size = new Size(140, 27);
            BtnIniciarSesion.TabIndex = 7;
            BtnIniciarSesion.Text = "Iniciar sesión";
            BtnIniciarSesion.UseVisualStyleBackColor = true;
            BtnIniciarSesion.Click += BtnIniciarSesion_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.ForeColor = SystemColors.ActiveCaptionText;
            BtnCancelar.Location = new Point(608, 301);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(140, 27);
            BtnCancelar.TabIndex = 8;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // LogInView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.LightPink;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnIniciarSesion);
            Controls.Add(CheckContraseña);
            Controls.Add(TxtPassword);
            Controls.Add(TxtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            ForeColor = Color.LightPink;
            FormBorderStyle = FormBorderStyle.None;
            Name = "LogInView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogInView";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox TxtEmail;
        private TextBox TxtPassword;
        private CheckBox CheckContraseña;
        private Button BtnIniciarSesion;
        private Button BtnCancelar;
    }
}