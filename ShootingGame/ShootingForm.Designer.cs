namespace ShootingGame
{
    partial class ShootingForm
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
            this.btn_Shoot_Away = new System.Windows.Forms.Button();
            this.btn_Shoot = new System.Windows.Forms.Button();
            this.btn_spin = new System.Windows.Forms.Button();
            this.Btn_Load = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbGun = new System.Windows.Forms.PictureBox();
            this.pbTarget = new System.Windows.Forms.PictureBox();
            this.pb_Gun = new System.Windows.Forms.PictureBox();
            this.btn_try_Again = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTarget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Gun)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.groupBox1.Controls.Add(this.btn_Shoot_Away);
            this.groupBox1.Controls.Add(this.btn_Shoot);
            this.groupBox1.Controls.Add(this.btn_spin);
            this.groupBox1.Controls.Add(this.Btn_Load);
            this.groupBox1.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(315, 249);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(444, 263);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // btn_Shoot_Away
            // 
            this.btn_Shoot_Away.BackColor = System.Drawing.Color.Maroon;
            this.btn_Shoot_Away.Enabled = false;
            this.btn_Shoot_Away.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Shoot_Away.ForeColor = System.Drawing.Color.White;
            this.btn_Shoot_Away.Location = new System.Drawing.Point(85, 204);
            this.btn_Shoot_Away.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Shoot_Away.Name = "btn_Shoot_Away";
            this.btn_Shoot_Away.Size = new System.Drawing.Size(228, 52);
            this.btn_Shoot_Away.TabIndex = 7;
            this.btn_Shoot_Away.Text = "Shoot Away";
            this.btn_Shoot_Away.UseVisualStyleBackColor = false;
            this.btn_Shoot_Away.Click += new System.EventHandler(this.Btn_Shoot_away_Click);
            // 
            // btn_Shoot
            // 
            this.btn_Shoot.BackColor = System.Drawing.Color.Maroon;
            this.btn_Shoot.Enabled = false;
            this.btn_Shoot.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Shoot.ForeColor = System.Drawing.Color.White;
            this.btn_Shoot.Location = new System.Drawing.Point(85, 121);
            this.btn_Shoot.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Shoot.Name = "btn_Shoot";
            this.btn_Shoot.Size = new System.Drawing.Size(228, 52);
            this.btn_Shoot.TabIndex = 6;
            this.btn_Shoot.Text = "Shoot";
            this.btn_Shoot.UseVisualStyleBackColor = false;
            this.btn_Shoot.Click += new System.EventHandler(this.btn_Shoot_Click);
            // 
            // btn_spin
            // 
            this.btn_spin.BackColor = System.Drawing.Color.Maroon;
            this.btn_spin.Enabled = false;
            this.btn_spin.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_spin.ForeColor = System.Drawing.Color.White;
            this.btn_spin.Location = new System.Drawing.Point(220, 36);
            this.btn_spin.Margin = new System.Windows.Forms.Padding(4);
            this.btn_spin.Name = "btn_spin";
            this.btn_spin.Size = new System.Drawing.Size(152, 52);
            this.btn_spin.TabIndex = 5;
            this.btn_spin.Text = "Spin";
            this.btn_spin.UseVisualStyleBackColor = false;
            this.btn_spin.Click += new System.EventHandler(this.btn_Spin_Click);
            // 
            // Btn_Load
            // 
            this.Btn_Load.BackColor = System.Drawing.Color.Maroon;
            this.Btn_Load.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Load.ForeColor = System.Drawing.Color.White;
            this.Btn_Load.Location = new System.Drawing.Point(23, 36);
            this.Btn_Load.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Load.Name = "Btn_Load";
            this.Btn_Load.Size = new System.Drawing.Size(152, 52);
            this.Btn_Load.TabIndex = 4;
            this.Btn_Load.Text = "Load";
            this.Btn_Load.UseVisualStyleBackColor = false;
            this.Btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbGun
            // 
            this.pbGun.Location = new System.Drawing.Point(260, 108);
            this.pbGun.Margin = new System.Windows.Forms.Padding(4);
            this.pbGun.Name = "pbGun";
            this.pbGun.Size = new System.Drawing.Size(55, 30);
            this.pbGun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGun.TabIndex = 4;
            this.pbGun.TabStop = false;
            this.pbGun.Visible = false;
            // 
            // pbTarget
            // 
            this.pbTarget.Image = global::ShootingGame.Properties.Resources.target;
            this.pbTarget.Location = new System.Drawing.Point(757, 27);
            this.pbTarget.Margin = new System.Windows.Forms.Padding(4);
            this.pbTarget.Name = "pbTarget";
            this.pbTarget.Size = new System.Drawing.Size(221, 214);
            this.pbTarget.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTarget.TabIndex = 1;
            this.pbTarget.TabStop = false;
            // 
            // pb_Gun
            // 
            this.pb_Gun.Image = global::ShootingGame.Properties.Resources._1st;
            this.pb_Gun.Location = new System.Drawing.Point(5, 27);
            this.pb_Gun.Margin = new System.Windows.Forms.Padding(4);
            this.pb_Gun.Name = "pb_Gun";
            this.pb_Gun.Size = new System.Drawing.Size(249, 214);
            this.pb_Gun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Gun.TabIndex = 0;
            this.pb_Gun.TabStop = false;
            // 
            // btn_try_Again
            // 
            this.btn_try_Again.BackColor = System.Drawing.Color.Maroon;
            this.btn_try_Again.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_try_Again.ForeColor = System.Drawing.Color.White;
            this.btn_try_Again.Location = new System.Drawing.Point(35, 460);
            this.btn_try_Again.Margin = new System.Windows.Forms.Padding(4);
            this.btn_try_Again.Name = "btn_try_Again";
            this.btn_try_Again.Size = new System.Drawing.Size(152, 52);
            this.btn_try_Again.TabIndex = 5;
            this.btn_try_Again.Text = "Try Again";
            this.btn_try_Again.UseVisualStyleBackColor = false;
            this.btn_try_Again.Visible = false;
            this.btn_try_Again.Click += new System.EventHandler(this.btn_try_again_Click);
            // 
            // ShootingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btn_try_Again);
            this.Controls.Add(this.pbGun);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbTarget);
            this.Controls.Add(this.pb_Gun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ShootingForm";
            this.Text = "Shooting Area";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbGun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTarget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Gun)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Gun;
        private System.Windows.Forms.PictureBox pbTarget;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_Load;
        private System.Windows.Forms.Button btn_spin;
        private System.Windows.Forms.Button btn_Shoot;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbGun;
        private System.Windows.Forms.Button btn_try_Again;
        private System.Windows.Forms.Button btn_Shoot_Away;
    }
}

