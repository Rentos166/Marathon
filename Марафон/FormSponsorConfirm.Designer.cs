namespace Марафон
{
    partial class FormSponsorConfirm
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timerMarathon = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.labelSum = new System.Windows.Forms.Label();
            this.textBoxFond = new System.Windows.Forms.TextBox();
            this.textBoxRunner = new System.Windows.Forms.TextBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.buttonBack);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(-5, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1005, 102);
            this.panel4.TabIndex = 36;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Марафон.Properties.Resources.logo_2016_full_colour;
            this.pictureBox1.Location = new System.Drawing.Point(151, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(847, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumPurple;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.labelTime);
            this.panel3.Location = new System.Drawing.Point(-7, 629);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1005, 73);
            this.panel3.TabIndex = 35;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(126, 14);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(765, 37);
            this.labelTime.TabIndex = 5;
            this.labelTime.Text = "4 дней 18 часов и 18 минут до старта марафона!";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumPurple;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-5, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1005, 161);
            this.panel2.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(126, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(789, 50);
            this.label2.TabIndex = 4;
            this.label2.Text = "Спасибо за поддержку бегуна в Marathon Skills 2016!\r\nВаше пожертвование поступит " +
    "в его благотворительную организацию.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(124, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(812, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Спасибо за Вашу спонсорскую поддержку!";
            // 
            // timerMarathon
            // 
            this.timerMarathon.Tick += new System.EventHandler(this.timerMarathon_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(422, 557);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 57);
            this.button1.TabIndex = 37;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSum.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelSum.Location = new System.Drawing.Point(409, 430);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(143, 73);
            this.labelSum.TabIndex = 41;
            this.labelSum.Text = "$50";
            this.labelSum.Click += new System.EventHandler(this.labelSum_Click);
            // 
            // textBoxFond
            // 
            this.textBoxFond.BackColor = System.Drawing.Color.SeaGreen;
            this.textBoxFond.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFond.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFond.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxFond.Location = new System.Drawing.Point(169, 355);
            this.textBoxFond.Name = "textBoxFond";
            this.textBoxFond.ReadOnly = true;
            this.textBoxFond.Size = new System.Drawing.Size(609, 33);
            this.textBoxFond.TabIndex = 40;
            this.textBoxFond.Text = "Фонд Кошек";
            this.textBoxFond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxRunner
            // 
            this.textBoxRunner.BackColor = System.Drawing.Color.SeaGreen;
            this.textBoxRunner.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRunner.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.textBoxRunner.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxRunner.Location = new System.Drawing.Point(169, 299);
            this.textBoxRunner.Name = "textBoxRunner";
            this.textBoxRunner.ReadOnly = true;
            this.textBoxRunner.Size = new System.Drawing.Size(609, 42);
            this.textBoxRunner.TabIndex = 39;
            this.textBoxRunner.Text = "Иван Прудов(204) из Russia";
            this.textBoxRunner.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormSponsorConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(998, 701);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.textBoxFond);
            this.Controls.Add(this.textBoxRunner);
            this.Name = "FormSponsorConfirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подтверждение спонсорства";
            this.Load += new System.EventHandler(this.FormSponsorConfirm_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerMarathon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.TextBox textBoxFond;
        private System.Windows.Forms.TextBox textBoxRunner;
    }
}