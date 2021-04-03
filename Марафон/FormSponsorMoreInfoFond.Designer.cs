namespace Марафон
{
    partial class FormSponsorMoreInfoFond
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSponsorMoreInfoFond));
            this.richTextBoxInfo = new System.Windows.Forms.RichTextBox();
            this.textBoxFond = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxLogoFond = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoFond)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBoxInfo
            // 
            this.richTextBoxInfo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxInfo.Location = new System.Drawing.Point(322, 114);
            this.richTextBoxInfo.Name = "richTextBoxInfo";
            this.richTextBoxInfo.ReadOnly = true;
            this.richTextBoxInfo.Size = new System.Drawing.Size(422, 175);
            this.richTextBoxInfo.TabIndex = 34;
            this.richTextBoxInfo.Text = "";
            // 
            // textBoxFond
            // 
            this.textBoxFond.BackColor = System.Drawing.Color.SeaGreen;
            this.textBoxFond.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFond.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFond.ForeColor = System.Drawing.Color.White;
            this.textBoxFond.Location = new System.Drawing.Point(321, 76);
            this.textBoxFond.Multiline = true;
            this.textBoxFond.Name = "textBoxFond";
            this.textBoxFond.ReadOnly = true;
            this.textBoxFond.Size = new System.Drawing.Size(423, 42);
            this.textBoxFond.TabIndex = 37;
            this.textBoxFond.Text = "Выберите бегуна";
            this.textBoxFond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumPurple;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(-2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(767, 67);
            this.panel2.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(-5, 304);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 67);
            this.panel1.TabIndex = 35;
            // 
            // pictureBoxLogoFond
            // 
            this.pictureBoxLogoFond.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxLogoFond.Location = new System.Drawing.Point(12, 83);
            this.pictureBoxLogoFond.Name = "pictureBoxLogoFond";
            this.pictureBoxLogoFond.Size = new System.Drawing.Size(303, 206);
            this.pictureBoxLogoFond.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogoFond.TabIndex = 33;
            this.pictureBoxLogoFond.TabStop = false;
            // 
            // FormSponsorMoreInfoFond
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(761, 369);
            this.Controls.Add(this.richTextBoxInfo);
            this.Controls.Add(this.textBoxFond);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxLogoFond);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSponsorMoreInfoFond";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация о благотворительной организации";
            this.Load += new System.EventHandler(this.FormSponsorMoreInfoFond_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoFond)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxInfo;
        private System.Windows.Forms.TextBox textBoxFond;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxLogoFond;
    }
}