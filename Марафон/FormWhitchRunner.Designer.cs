namespace Марафон
{
    partial class FormWhitchRunner
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.timerMarathon = new System.Windows.Forms.Timer(this.components);
            this.buttonNewRunner = new System.Windows.Forms.Button();
            this.buttonRunnerBefore = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumPurple;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(-4, 139);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1005, 101);
            this.panel2.TabIndex = 24;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.buttonBack);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(-4, -2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1005, 143);
            this.panel4.TabIndex = 23;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Gold;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(21, 29);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(102, 57);
            this.buttonBack.TabIndex = 7;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumPurple;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.labelTime);
            this.panel3.Location = new System.Drawing.Point(-6, 598);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1005, 101);
            this.panel3.TabIndex = 22;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.ForeColor = System.Drawing.Color.GhostWhite;
            this.labelTime.Location = new System.Drawing.Point(199, 32);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(655, 37);
            this.labelTime.TabIndex = 5;
            this.labelTime.Text = "4 дней 18 часов и 18 минут до старта марафона!";
            // 
            // buttonNewRunner
            // 
            this.buttonNewRunner.BackColor = System.Drawing.Color.Gold;
            this.buttonNewRunner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewRunner.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNewRunner.Location = new System.Drawing.Point(244, 408);
            this.buttonNewRunner.Name = "buttonNewRunner";
            this.buttonNewRunner.Size = new System.Drawing.Size(451, 76);
            this.buttonNewRunner.TabIndex = 26;
            this.buttonNewRunner.Text = "Я новый участник";
            this.buttonNewRunner.UseVisualStyleBackColor = false;
            // 
            // buttonRunnerBefore
            // 
            this.buttonRunnerBefore.BackColor = System.Drawing.Color.Gold;
            this.buttonRunnerBefore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRunnerBefore.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRunnerBefore.Location = new System.Drawing.Point(244, 313);
            this.buttonRunnerBefore.Name = "buttonRunnerBefore";
            this.buttonRunnerBefore.Size = new System.Drawing.Size(451, 76);
            this.buttonRunnerBefore.TabIndex = 25;
            this.buttonRunnerBefore.Text = "Я участвовал ранее";
            this.buttonRunnerBefore.UseVisualStyleBackColor = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Gold;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogin.Location = new System.Drawing.Point(851, 512);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(133, 67);
            this.buttonLogin.TabIndex = 21;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Марафон.Properties.Resources.logo_2016_full_colour;
            this.pictureBox1.Location = new System.Drawing.Point(129, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(869, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FormWhitchRunner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(996, 700);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.buttonNewRunner);
            this.Controls.Add(this.buttonRunnerBefore);
            this.Controls.Add(this.buttonLogin);
            this.Name = "FormWhitchRunner";
            this.Text = "Проверка уже введенных бегунов";
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timerMarathon;
        private System.Windows.Forms.Button buttonNewRunner;
        private System.Windows.Forms.Button buttonRunnerBefore;
        private System.Windows.Forms.Button buttonLogin;
    }
}