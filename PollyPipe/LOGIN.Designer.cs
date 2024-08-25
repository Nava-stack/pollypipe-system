
namespace PollyPipe
{
    partial class LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Entr_Btn = new System.Windows.Forms.Button();
            this.UserBox = new System.Windows.Forms.TextBox();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-12, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(245, 251);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(260, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Name :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(269, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password  :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Entr_Btn
            // 
            this.Entr_Btn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Entr_Btn.Font = new System.Drawing.Font("Lucida Fax", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entr_Btn.ForeColor = System.Drawing.Color.BlueViolet;
            this.Entr_Btn.Location = new System.Drawing.Point(479, 182);
            this.Entr_Btn.Name = "Entr_Btn";
            this.Entr_Btn.Size = new System.Drawing.Size(153, 45);
            this.Entr_Btn.TabIndex = 5;
            this.Entr_Btn.Text = "LOGIN";
            this.Entr_Btn.UseVisualStyleBackColor = false;
            this.Entr_Btn.Click += new System.EventHandler(this.Entr_Btn_Click);
            // 
            // UserBox
            // 
            this.UserBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.UserBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UserBox.Location = new System.Drawing.Point(405, 81);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(227, 31);
            this.UserBox.TabIndex = 6;
            this.UserBox.TextChanged += new System.EventHandler(this.UserBox_TextChanged);
            // 
            // PassBox
            // 
            this.PassBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.PassBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PassBox.Location = new System.Drawing.Point(405, 119);
            this.PassBox.Name = "PassBox";
            this.PassBox.PasswordChar = '*';
            this.PassBox.Size = new System.Drawing.Size(227, 31);
            this.PassBox.TabIndex = 6;
            this.PassBox.TextChanged += new System.EventHandler(this.PassBox_TextChanged);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.exitBtn.Font = new System.Drawing.Font("Lucida Fax", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.BlueViolet;
            this.exitBtn.Location = new System.Drawing.Point(274, 182);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(153, 45);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "EXIT";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Turquoise;
            this.label3.Location = new System.Drawing.Point(149, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(401, 45);
            this.label3.TabIndex = 8;
            this.label3.Text = "POLLY PIPE LOGIN";
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(658, 257);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.UserBox);
            this.Controls.Add(this.Entr_Btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LOGIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.LOGIN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Entr_Btn;
        private System.Windows.Forms.TextBox UserBox;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label3;
    }
}