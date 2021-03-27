namespace Марафон
{
    partial class FormRunnerMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.timerMarathon = new System.Windows.Forms.Timer(this.components);
            this.buttonMySpon = new System.Windows.Forms.Button();
            this.buttonMyResult = new System.Windows.Forms.Button();
            this.buttonContacts = new System.Windows.Forms.Button();
            this.buttonRedProfile = new System.Windows.Forms.Button();
            this.buttonRegforMar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumPurple;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-6, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1005, 75);
            this.panel2.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(393, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Меню бегуна";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.buttonLogout);
            this.panel4.Controls.Add(this.buttonBack);
            this.panel4.Controls.Add(this.pictureBoxLogo);
            this.panel4.Location = new System.Drawing.Point(-5, -7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1005, 102);
            this.panel4.TabIndex = 25;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.Gold;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogout.Location = new System.Drawing.Point(885, 29);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(102, 57);
            this.buttonLogout.TabIndex = 8;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Gold;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(21, 29);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(102, 57);
            this.buttonBack.TabIndex = 7;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Марафон.Properties.Resources.logo_2016_full_colour;
            this.pictureBoxLogo.Location = new System.Drawing.Point(129, 4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(750, 92);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 7;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumPurple;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.labelTime);
            this.panel3.Location = new System.Drawing.Point(-7, 550);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1005, 79);
            this.panel3.TabIndex = 24;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.ForeColor = System.Drawing.Color.GhostWhite;
            this.labelTime.Location = new System.Drawing.Point(124, 18);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(765, 37);
            this.labelTime.TabIndex = 5;
            this.labelTime.Text = "4 дней 18 часов и 18 минут до старта марафона!";
            // 
            // timerMarathon
            // 
            this.timerMarathon.Tick += new System.EventHandler(this.timerMarathon_Tick);
            // 
            // buttonMySpon
            // 
            this.buttonMySpon.BackColor = System.Drawing.Color.Gold;
            this.buttonMySpon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMySpon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMySpon.Location = new System.Drawing.Point(511, 330);
            this.buttonMySpon.Name = "buttonMySpon";
            this.buttonMySpon.Size = new System.Drawing.Size(296, 71);
            this.buttonMySpon.TabIndex = 30;
            this.buttonMySpon.Text = "Мой спонсор";
            this.buttonMySpon.UseVisualStyleBackColor = false;
            // 
            // buttonMyResult
            // 
            this.buttonMyResult.BackColor = System.Drawing.Color.Gold;
            this.buttonMyResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMyResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMyResult.Location = new System.Drawing.Point(511, 223);
            this.buttonMyResult.Name = "buttonMyResult";
            this.buttonMyResult.Size = new System.Drawing.Size(296, 71);
            this.buttonMyResult.TabIndex = 29;
            this.buttonMyResult.Text = "Мои результаты";
            this.buttonMyResult.UseVisualStyleBackColor = false;
            // 
            // buttonContacts
            // 
            this.buttonContacts.BackColor = System.Drawing.Color.Gold;
            this.buttonContacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonContacts.Location = new System.Drawing.Point(147, 438);
            this.buttonContacts.Name = "buttonContacts";
            this.buttonContacts.Size = new System.Drawing.Size(296, 71);
            this.buttonContacts.TabIndex = 28;
            this.buttonContacts.Text = "Контакты";
            this.buttonContacts.UseVisualStyleBackColor = false;
            this.buttonContacts.Click += new System.EventHandler(this.buttonContacts_Click);
            // 
            // buttonRedProfile
            // 
            this.buttonRedProfile.BackColor = System.Drawing.Color.Gold;
            this.buttonRedProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRedProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRedProfile.Location = new System.Drawing.Point(147, 330);
            this.buttonRedProfile.Name = "buttonRedProfile";
            this.buttonRedProfile.Size = new System.Drawing.Size(296, 71);
            this.buttonRedProfile.TabIndex = 27;
            this.buttonRedProfile.Text = "Редактирование профиля";
            this.buttonRedProfile.UseVisualStyleBackColor = false;
            this.buttonRedProfile.Click += new System.EventHandler(this.buttonRedProfile_Click);
            // 
            // buttonRegforMar
            // 
            this.buttonRegforMar.BackColor = System.Drawing.Color.Gold;
            this.buttonRegforMar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegforMar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegforMar.Location = new System.Drawing.Point(147, 223);
            this.buttonRegforMar.Name = "buttonRegforMar";
            this.buttonRegforMar.Size = new System.Drawing.Size(296, 71);
            this.buttonRegforMar.TabIndex = 23;
            this.buttonRegforMar.Text = "Регистрация на марафон";
            this.buttonRegforMar.UseVisualStyleBackColor = false;
            this.buttonRegforMar.Click += new System.EventHandler(this.buttonRegforMar_Click);
            // 
            // FormRunnerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(992, 626);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.buttonMySpon);
            this.Controls.Add(this.buttonMyResult);
            this.Controls.Add(this.buttonContacts);
            this.Controls.Add(this.buttonRedProfile);
            this.Controls.Add(this.buttonRegforMar);
            this.Name = "FormRunnerMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню бегуна";
            this.Load += new System.EventHandler(this.FormRunnerMenu_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timerMarathon;
        private System.Windows.Forms.Button buttonMySpon;
        private System.Windows.Forms.Button buttonMyResult;
        private System.Windows.Forms.Button buttonContacts;
        private System.Windows.Forms.Button buttonRedProfile;
        private System.Windows.Forms.Button buttonRegforMar;
    }
}