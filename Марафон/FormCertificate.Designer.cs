
namespace Марафон
{
    partial class FormCertificate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCertificate));
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timerMarathon = new System.Windows.Forms.Timer(this.components);
            this.grayPanel = new System.Windows.Forms.Panel();
            this.raceComboBox = new System.Windows.Forms.ComboBox();
            this.raceLabel = new System.Windows.Forms.Label();
            this.notOkPanel = new System.Windows.Forms.Panel();
            this.errorLabel = new System.Windows.Forms.Label();
            this.apprivePictureBox = new System.Windows.Forms.PictureBox();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.congratulationsLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.certificateLabel = new System.Windows.Forms.Label();
            this.inLabel = new System.Windows.Forms.Label();
            this.marathonLabel = new System.Windows.Forms.Label();
            this.okPanek = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grayPanel.SuspendLayout();
            this.notOkPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apprivePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.okPanek.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.buttonLogout);
            this.panel4.Controls.Add(this.buttonBack);
            this.panel4.Controls.Add(this.pictureBoxLogo);
            this.panel4.Location = new System.Drawing.Point(-7, -6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1005, 109);
            this.panel4.TabIndex = 58;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.Gold;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogout.Location = new System.Drawing.Point(880, 29);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(102, 57);
            this.buttonLogout.TabIndex = 97;
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
            this.pictureBoxLogo.Location = new System.Drawing.Point(157, 10);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(692, 92);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 7;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumPurple;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.labelTime);
            this.panel3.Location = new System.Drawing.Point(-7, 672);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1005, 80);
            this.panel3.TabIndex = 59;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelTime.Location = new System.Drawing.Point(116, 21);
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
            this.panel2.Location = new System.Drawing.Point(-7, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1005, 78);
            this.panel2.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(395, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Сертификат";
            // 
            // timerMarathon
            // 
            this.timerMarathon.Tick += new System.EventHandler(this.timerMarathon_Tick);
            // 
            // grayPanel
            // 
            this.grayPanel.BackColor = System.Drawing.Color.SeaGreen;
            this.grayPanel.Controls.Add(this.raceComboBox);
            this.grayPanel.Controls.Add(this.raceLabel);
            this.grayPanel.Location = new System.Drawing.Point(-2, 172);
            this.grayPanel.Name = "grayPanel";
            this.grayPanel.Size = new System.Drawing.Size(1000, 80);
            this.grayPanel.TabIndex = 81;
            // 
            // raceComboBox
            // 
            this.raceComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raceComboBox.ForeColor = System.Drawing.Color.Black;
            this.raceComboBox.FormattingEnabled = true;
            this.raceComboBox.Location = new System.Drawing.Point(480, 27);
            this.raceComboBox.Name = "raceComboBox";
            this.raceComboBox.Size = new System.Drawing.Size(231, 32);
            this.raceComboBox.TabIndex = 30;
            this.raceComboBox.Text = "42km Полный марафон";
            this.raceComboBox.SelectedIndexChanged += new System.EventHandler(this.raceComboBox_SelectedIndexChanged);
            // 
            // raceLabel
            // 
            this.raceLabel.AutoSize = true;
            this.raceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.raceLabel.ForeColor = System.Drawing.Color.Navy;
            this.raceLabel.Location = new System.Drawing.Point(267, 26);
            this.raceLabel.Name = "raceLabel";
            this.raceLabel.Size = new System.Drawing.Size(207, 31);
            this.raceLabel.TabIndex = 6;
            this.raceLabel.Text = "Тип марафона:";
            // 
            // notOkPanel
            // 
            this.notOkPanel.Controls.Add(this.errorLabel);
            this.notOkPanel.Location = new System.Drawing.Point(83, 267);
            this.notOkPanel.Name = "notOkPanel";
            this.notOkPanel.Size = new System.Drawing.Size(826, 402);
            this.notOkPanel.TabIndex = 83;
            // 
            // errorLabel
            // 
            this.errorLabel.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold);
            this.errorLabel.ForeColor = System.Drawing.Color.Black;
            this.errorLabel.Location = new System.Drawing.Point(0, 149);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(823, 98);
            this.errorLabel.TabIndex = 0;
            this.errorLabel.Text = "Бегун не принимал участия в марафоне такого типа";
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // apprivePictureBox
            // 
            this.apprivePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("apprivePictureBox.Image")));
            this.apprivePictureBox.Location = new System.Drawing.Point(681, 276);
            this.apprivePictureBox.Name = "apprivePictureBox";
            this.apprivePictureBox.Size = new System.Drawing.Size(142, 123);
            this.apprivePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.apprivePictureBox.TabIndex = 78;
            this.apprivePictureBox.TabStop = false;
            // 
            // moneyLabel
            // 
            this.moneyLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.moneyLabel.ForeColor = System.Drawing.Color.Black;
            this.moneyLabel.Location = new System.Drawing.Point(192, 355);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.moneyLabel.Size = new System.Drawing.Size(483, 44);
            this.moneyLabel.TabIndex = 75;
            this.moneyLabel.Text = "Вы также заработали $1500 \r\nдля вашей благотворительной организации!";
            this.moneyLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // congratulationsLabel
            // 
            this.congratulationsLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.congratulationsLabel.ForeColor = System.Drawing.Color.Black;
            this.congratulationsLabel.Location = new System.Drawing.Point(87, 121);
            this.congratulationsLabel.Name = "congratulationsLabel";
            this.congratulationsLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.congratulationsLabel.Size = new System.Drawing.Size(648, 57);
            this.congratulationsLabel.TabIndex = 70;
            this.congratulationsLabel.Text = "Поздравляем Имя Фамилия с участием в 42km Полном марафоне. Ваши результаты время " +
    "4:32:15 и занятое место 183rd!";
            this.congratulationsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cityLabel
            // 
            this.cityLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cityLabel.ForeColor = System.Drawing.Color.Black;
            this.cityLabel.Location = new System.Drawing.Point(229, 301);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(400, 24);
            this.cityLabel.TabIndex = 74;
            this.cityLabel.Text = "Osaka, Japan";
            this.cityLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Location = new System.Drawing.Point(306, 2);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(240, 89);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 69;
            this.logoPictureBox.TabStop = false;
            // 
            // certificateLabel
            // 
            this.certificateLabel.AutoSize = true;
            this.certificateLabel.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.certificateLabel.ForeColor = System.Drawing.Color.Black;
            this.certificateLabel.Location = new System.Drawing.Point(217, 178);
            this.certificateLabel.Name = "certificateLabel";
            this.certificateLabel.Size = new System.Drawing.Size(412, 41);
            this.certificateLabel.TabIndex = 71;
            this.certificateLabel.Text = "Сертификат участника";
            // 
            // inLabel
            // 
            this.inLabel.AutoSize = true;
            this.inLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.inLabel.ForeColor = System.Drawing.Color.Black;
            this.inLabel.Location = new System.Drawing.Point(417, 229);
            this.inLabel.Name = "inLabel";
            this.inLabel.Size = new System.Drawing.Size(20, 22);
            this.inLabel.TabIndex = 72;
            this.inLabel.Text = "в";
            // 
            // marathonLabel
            // 
            this.marathonLabel.Font = new System.Drawing.Font("Arial", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.marathonLabel.ForeColor = System.Drawing.Color.Black;
            this.marathonLabel.Location = new System.Drawing.Point(224, 262);
            this.marathonLabel.Name = "marathonLabel";
            this.marathonLabel.Size = new System.Drawing.Size(419, 30);
            this.marathonLabel.TabIndex = 73;
            this.marathonLabel.Text = "Marathon Skills 2014";
            this.marathonLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // okPanek
            // 
            this.okPanek.Controls.Add(this.apprivePictureBox);
            this.okPanek.Controls.Add(this.moneyLabel);
            this.okPanek.Controls.Add(this.congratulationsLabel);
            this.okPanek.Controls.Add(this.cityLabel);
            this.okPanek.Controls.Add(this.logoPictureBox);
            this.okPanek.Controls.Add(this.certificateLabel);
            this.okPanek.Controls.Add(this.inLabel);
            this.okPanek.Controls.Add(this.marathonLabel);
            this.okPanek.Location = new System.Drawing.Point(80, 267);
            this.okPanek.Name = "okPanek";
            this.okPanek.Size = new System.Drawing.Size(826, 402);
            this.okPanek.TabIndex = 82;
            // 
            // FormCertificate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(990, 747);
            this.Controls.Add(this.notOkPanel);
            this.Controls.Add(this.okPanek);
            this.Controls.Add(this.grayPanel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.MaximumSize = new System.Drawing.Size(1006, 786);
            this.MinimumSize = new System.Drawing.Size(1006, 786);
            this.Name = "FormCertificate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сертификат бегуна";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCertificate_FormClosing);
            this.Load += new System.EventHandler(this.FormCertificate_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grayPanel.ResumeLayout(false);
            this.grayPanel.PerformLayout();
            this.notOkPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.apprivePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.okPanek.ResumeLayout(false);
            this.okPanek.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerMarathon;
        private System.Windows.Forms.Panel grayPanel;
        private System.Windows.Forms.ComboBox raceComboBox;
        private System.Windows.Forms.Label raceLabel;
        private System.Windows.Forms.Panel notOkPanel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.PictureBox apprivePictureBox;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Label congratulationsLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label certificateLabel;
        private System.Windows.Forms.Label inLabel;
        private System.Windows.Forms.Label marathonLabel;
        private System.Windows.Forms.Panel okPanek;
    }
}