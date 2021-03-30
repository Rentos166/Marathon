namespace Марафон
{
    partial class FormMoreInfo
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBMR = new System.Windows.Forms.Button();
            this.buttonBlagoFond = new System.Windows.Forms.Button();
            this.buttonTimeMar = new System.Windows.Forms.Button();
            this.buttonBMI = new System.Windows.Forms.Button();
            this.buttonOldRes = new System.Windows.Forms.Button();
            this.buttonMarathon = new System.Windows.Forms.Button();
            this.timerMarathon = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.buttonBack);
            this.panel4.Controls.Add(this.pictureBoxLogo);
            this.panel4.Location = new System.Drawing.Point(-5, -3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1005, 102);
            this.panel4.TabIndex = 17;
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumPurple;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.labelTime);
            this.panel3.Location = new System.Drawing.Point(-7, 627);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1005, 73);
            this.panel3.TabIndex = 16;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.ForeColor = System.Drawing.Color.GhostWhite;
            this.labelTime.Location = new System.Drawing.Point(124, 14);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(765, 37);
            this.labelTime.TabIndex = 5;
            this.labelTime.Text = "4 дней 18 часов и 18 минут до старта марафона!";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumPurple;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-6, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1005, 97);
            this.panel2.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(302, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Подробная информация";
            // 
            // buttonBMR
            // 
            this.buttonBMR.BackColor = System.Drawing.Color.Gold;
            this.buttonBMR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBMR.Location = new System.Drawing.Point(509, 490);
            this.buttonBMR.Name = "buttonBMR";
            this.buttonBMR.Size = new System.Drawing.Size(360, 76);
            this.buttonBMR.TabIndex = 24;
            this.buttonBMR.Text = "BMR калькулятор";
            this.buttonBMR.UseVisualStyleBackColor = false;
            this.buttonBMR.Click += new System.EventHandler(this.buttonBMR_Click);
            // 
            // buttonBlagoFond
            // 
            this.buttonBlagoFond.BackColor = System.Drawing.Color.Gold;
            this.buttonBlagoFond.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBlagoFond.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBlagoFond.Location = new System.Drawing.Point(509, 366);
            this.buttonBlagoFond.Name = "buttonBlagoFond";
            this.buttonBlagoFond.Size = new System.Drawing.Size(360, 76);
            this.buttonBlagoFond.TabIndex = 23;
            this.buttonBlagoFond.Text = "Список благотворительных организаций";
            this.buttonBlagoFond.UseVisualStyleBackColor = false;
            this.buttonBlagoFond.Click += new System.EventHandler(this.buttonBlagoFond_Click);
            // 
            // buttonTimeMar
            // 
            this.buttonTimeMar.BackColor = System.Drawing.Color.Gold;
            this.buttonTimeMar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimeMar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTimeMar.Location = new System.Drawing.Point(509, 248);
            this.buttonTimeMar.Name = "buttonTimeMar";
            this.buttonTimeMar.Size = new System.Drawing.Size(360, 76);
            this.buttonTimeMar.TabIndex = 22;
            this.buttonTimeMar.Text = "Насколько долгий марафон";
            this.buttonTimeMar.UseVisualStyleBackColor = false;
            this.buttonTimeMar.Click += new System.EventHandler(this.buttonTimeMar_Click);
            // 
            // buttonBMI
            // 
            this.buttonBMI.BackColor = System.Drawing.Color.Gold;
            this.buttonBMI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBMI.Location = new System.Drawing.Point(124, 490);
            this.buttonBMI.Name = "buttonBMI";
            this.buttonBMI.Size = new System.Drawing.Size(360, 76);
            this.buttonBMI.TabIndex = 21;
            this.buttonBMI.Text = "BMI калькулятор";
            this.buttonBMI.UseVisualStyleBackColor = false;
            this.buttonBMI.Click += new System.EventHandler(this.buttonBMI_Click);
            // 
            // buttonOldRes
            // 
            this.buttonOldRes.BackColor = System.Drawing.Color.Gold;
            this.buttonOldRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOldRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOldRes.Location = new System.Drawing.Point(124, 366);
            this.buttonOldRes.Name = "buttonOldRes";
            this.buttonOldRes.Size = new System.Drawing.Size(360, 76);
            this.buttonOldRes.TabIndex = 20;
            this.buttonOldRes.Text = "Предыдущие результаты";
            this.buttonOldRes.UseVisualStyleBackColor = false;
            this.buttonOldRes.Click += new System.EventHandler(this.buttonOldRes_Click);
            // 
            // buttonMarathon
            // 
            this.buttonMarathon.BackColor = System.Drawing.Color.Gold;
            this.buttonMarathon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMarathon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMarathon.Location = new System.Drawing.Point(124, 248);
            this.buttonMarathon.Name = "buttonMarathon";
            this.buttonMarathon.Size = new System.Drawing.Size(360, 76);
            this.buttonMarathon.TabIndex = 19;
            this.buttonMarathon.Text = "Marathon Skills 2016";
            this.buttonMarathon.UseVisualStyleBackColor = false;
            this.buttonMarathon.Click += new System.EventHandler(this.buttonMarathon_Click);
            // 
            // timerMarathon
            // 
            this.timerMarathon.Tick += new System.EventHandler(this.timerMarathon_Tick);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Марафон.Properties.Resources.logo_2016_full_colour;
            this.pictureBoxLogo.Location = new System.Drawing.Point(129, 4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(869, 92);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 7;
            this.pictureBoxLogo.TabStop = false;
            // 
            // FormMoreInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(995, 698);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonBMR);
            this.Controls.Add(this.buttonBlagoFond);
            this.Controls.Add(this.buttonTimeMar);
            this.Controls.Add(this.buttonBMI);
            this.Controls.Add(this.buttonOldRes);
            this.Controls.Add(this.buttonMarathon);
            this.Name = "FormMoreInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подробная информация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMoreInfo_FormClosing);
            this.Load += new System.EventHandler(this.FormMoreInfo_Load);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBMR;
        private System.Windows.Forms.Button buttonBlagoFond;
        private System.Windows.Forms.Button buttonTimeMar;
        private System.Windows.Forms.Button buttonBMI;
        private System.Windows.Forms.Button buttonOldRes;
        private System.Windows.Forms.Button buttonMarathon;
        private System.Windows.Forms.Timer timerMarathon;
    }
}