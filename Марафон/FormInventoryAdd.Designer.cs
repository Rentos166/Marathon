
namespace Марафон
{
    partial class FormInventoryAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInventoryAdd));
            this.label1 = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.timerMarathon = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.downPanel = new System.Windows.Forms.Panel();
            this.souvenirTextBox = new System.Windows.Forms.MaskedTextBox();
            this.tshirtTextBox = new System.Windows.Forms.MaskedTextBox();
            this.waterTextBox = new System.Windows.Forms.MaskedTextBox();
            this.baseballTextBox = new System.Windows.Forms.MaskedTextBox();
            this.rfidTextBox = new System.Windows.Forms.MaskedTextBox();
            this.idTextBox = new System.Windows.Forms.MaskedTextBox();
            this.admissionLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.souvenirLabel = new System.Windows.Forms.Label();
            this.tshirtLabel = new System.Windows.Forms.Label();
            this.waterLabel = new System.Windows.Forms.Label();
            this.baseballCapLabel = new System.Windows.Forms.Label();
            this.rfidLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.downPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(236, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Поступление инвентаря";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelTime.Location = new System.Drawing.Point(45, 14);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(765, 37);
            this.labelTime.TabIndex = 6;
            this.labelTime.Text = "4 дней 18 часов и 18 минут до старта марафона!";
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.Gold;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogout.Location = new System.Drawing.Point(734, 13);
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
            this.buttonBack.Location = new System.Drawing.Point(16, 13);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(102, 57);
            this.buttonBack.TabIndex = 7;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.buttonLogout);
            this.panel4.Controls.Add(this.buttonBack);
            this.panel4.Controls.Add(this.pictureBoxLogo);
            this.panel4.Location = new System.Drawing.Point(0, -2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(850, 93);
            this.panel4.TabIndex = 270;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Марафон.Properties.Resources.logo_2016_full_colour1;
            this.pictureBoxLogo.Location = new System.Drawing.Point(151, 4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(553, 80);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 7;
            this.pictureBoxLogo.TabStop = false;
            // 
            // timerMarathon
            // 
            this.timerMarathon.Enabled = true;
            this.timerMarathon.Interval = 1000;
            this.timerMarathon.Tick += new System.EventHandler(this.timerMarathon_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumPurple;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(850, 70);
            this.panel2.TabIndex = 271;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Gold;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.ForeColor = System.Drawing.Color.Black;
            this.buttonSave.Location = new System.Drawing.Point(325, 471);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(208, 65);
            this.buttonSave.TabIndex = 213;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // downPanel
            // 
            this.downPanel.BackColor = System.Drawing.Color.MediumPurple;
            this.downPanel.Controls.Add(this.labelTime);
            this.downPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.downPanel.Location = new System.Drawing.Point(0, 565);
            this.downPanel.Name = "downPanel";
            this.downPanel.Size = new System.Drawing.Size(850, 60);
            this.downPanel.TabIndex = 210;
            // 
            // souvenirTextBox
            // 
            this.souvenirTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.souvenirTextBox.ForeColor = System.Drawing.Color.Navy;
            this.souvenirTextBox.Location = new System.Drawing.Point(426, 406);
            this.souvenirTextBox.Name = "souvenirTextBox";
            this.souvenirTextBox.Size = new System.Drawing.Size(183, 29);
            this.souvenirTextBox.TabIndex = 285;
            // 
            // tshirtTextBox
            // 
            this.tshirtTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tshirtTextBox.ForeColor = System.Drawing.Color.Navy;
            this.tshirtTextBox.Location = new System.Drawing.Point(426, 376);
            this.tshirtTextBox.Name = "tshirtTextBox";
            this.tshirtTextBox.Size = new System.Drawing.Size(183, 29);
            this.tshirtTextBox.TabIndex = 284;
            // 
            // waterTextBox
            // 
            this.waterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.waterTextBox.ForeColor = System.Drawing.Color.Navy;
            this.waterTextBox.Location = new System.Drawing.Point(426, 346);
            this.waterTextBox.Name = "waterTextBox";
            this.waterTextBox.Size = new System.Drawing.Size(183, 29);
            this.waterTextBox.TabIndex = 283;
            // 
            // baseballTextBox
            // 
            this.baseballTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baseballTextBox.ForeColor = System.Drawing.Color.Navy;
            this.baseballTextBox.Location = new System.Drawing.Point(426, 316);
            this.baseballTextBox.Name = "baseballTextBox";
            this.baseballTextBox.Size = new System.Drawing.Size(183, 29);
            this.baseballTextBox.TabIndex = 282;
            // 
            // rfidTextBox
            // 
            this.rfidTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rfidTextBox.ForeColor = System.Drawing.Color.Navy;
            this.rfidTextBox.Location = new System.Drawing.Point(426, 286);
            this.rfidTextBox.Name = "rfidTextBox";
            this.rfidTextBox.Size = new System.Drawing.Size(183, 29);
            this.rfidTextBox.TabIndex = 281;
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idTextBox.ForeColor = System.Drawing.Color.Navy;
            this.idTextBox.Location = new System.Drawing.Point(426, 256);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(183, 29);
            this.idTextBox.TabIndex = 280;
            // 
            // admissionLabel
            // 
            this.admissionLabel.BackColor = System.Drawing.Color.MediumPurple;
            this.admissionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.admissionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.admissionLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.admissionLabel.Location = new System.Drawing.Point(426, 226);
            this.admissionLabel.Name = "admissionLabel";
            this.admissionLabel.Size = new System.Drawing.Size(183, 30);
            this.admissionLabel.TabIndex = 279;
            this.admissionLabel.Text = "Поступление";
            this.admissionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.Color.MediumPurple;
            this.nameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nameLabel.Location = new System.Drawing.Point(243, 226);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(183, 30);
            this.nameLabel.TabIndex = 278;
            this.nameLabel.Text = "Наименование";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // souvenirLabel
            // 
            this.souvenirLabel.BackColor = System.Drawing.SystemColors.Control;
            this.souvenirLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.souvenirLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.souvenirLabel.ForeColor = System.Drawing.Color.Black;
            this.souvenirLabel.Location = new System.Drawing.Point(243, 406);
            this.souvenirLabel.Name = "souvenirLabel";
            this.souvenirLabel.Size = new System.Drawing.Size(183, 30);
            this.souvenirLabel.TabIndex = 277;
            this.souvenirLabel.Text = "Сувенирный буклет";
            this.souvenirLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tshirtLabel
            // 
            this.tshirtLabel.BackColor = System.Drawing.SystemColors.Control;
            this.tshirtLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tshirtLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tshirtLabel.ForeColor = System.Drawing.Color.Black;
            this.tshirtLabel.Location = new System.Drawing.Point(243, 376);
            this.tshirtLabel.Name = "tshirtLabel";
            this.tshirtLabel.Size = new System.Drawing.Size(183, 30);
            this.tshirtLabel.TabIndex = 276;
            this.tshirtLabel.Text = "Футболка";
            this.tshirtLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // waterLabel
            // 
            this.waterLabel.BackColor = System.Drawing.SystemColors.Control;
            this.waterLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.waterLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.waterLabel.ForeColor = System.Drawing.Color.Black;
            this.waterLabel.Location = new System.Drawing.Point(243, 346);
            this.waterLabel.Name = "waterLabel";
            this.waterLabel.Size = new System.Drawing.Size(183, 30);
            this.waterLabel.TabIndex = 275;
            this.waterLabel.Text = "Бутылка воды";
            this.waterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // baseballCapLabel
            // 
            this.baseballCapLabel.BackColor = System.Drawing.SystemColors.Control;
            this.baseballCapLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.baseballCapLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baseballCapLabel.ForeColor = System.Drawing.Color.Black;
            this.baseballCapLabel.Location = new System.Drawing.Point(243, 316);
            this.baseballCapLabel.Name = "baseballCapLabel";
            this.baseballCapLabel.Size = new System.Drawing.Size(183, 30);
            this.baseballCapLabel.TabIndex = 274;
            this.baseballCapLabel.Text = "Бейсболка";
            this.baseballCapLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rfidLabel
            // 
            this.rfidLabel.BackColor = System.Drawing.SystemColors.Control;
            this.rfidLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rfidLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rfidLabel.ForeColor = System.Drawing.Color.Black;
            this.rfidLabel.Location = new System.Drawing.Point(243, 286);
            this.rfidLabel.Name = "rfidLabel";
            this.rfidLabel.Size = new System.Drawing.Size(183, 30);
            this.rfidLabel.TabIndex = 273;
            this.rfidLabel.Text = "RFID браслет";
            this.rfidLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // idLabel
            // 
            this.idLabel.BackColor = System.Drawing.SystemColors.Control;
            this.idLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idLabel.ForeColor = System.Drawing.Color.Black;
            this.idLabel.Location = new System.Drawing.Point(243, 256);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(183, 30);
            this.idLabel.TabIndex = 272;
            this.idLabel.Text = "Номер бегуна";
            this.idLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormInventoryAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(850, 625);
            this.Controls.Add(this.souvenirTextBox);
            this.Controls.Add(this.tshirtTextBox);
            this.Controls.Add(this.waterTextBox);
            this.Controls.Add(this.baseballTextBox);
            this.Controls.Add(this.rfidTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.admissionLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.souvenirLabel);
            this.Controls.Add(this.tshirtLabel);
            this.Controls.Add(this.waterLabel);
            this.Controls.Add(this.baseballCapLabel);
            this.Controls.Add(this.rfidLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.downPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(866, 664);
            this.MinimumSize = new System.Drawing.Size(866, 664);
            this.Name = "FormInventoryAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поступление инвентаря";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormInventoryAdd_FormClosing);
            this.Load += new System.EventHandler(this.FormInventoryAdd_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.downPanel.ResumeLayout(false);
            this.downPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer timerMarathon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Panel downPanel;
        private System.Windows.Forms.MaskedTextBox souvenirTextBox;
        private System.Windows.Forms.MaskedTextBox tshirtTextBox;
        private System.Windows.Forms.MaskedTextBox waterTextBox;
        private System.Windows.Forms.MaskedTextBox baseballTextBox;
        private System.Windows.Forms.MaskedTextBox rfidTextBox;
        private System.Windows.Forms.MaskedTextBox idTextBox;
        private System.Windows.Forms.Label admissionLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label souvenirLabel;
        private System.Windows.Forms.Label tshirtLabel;
        private System.Windows.Forms.Label waterLabel;
        private System.Windows.Forms.Label baseballCapLabel;
        private System.Windows.Forms.Label rfidLabel;
        private System.Windows.Forms.Label idLabel;
    }
}