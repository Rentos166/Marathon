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
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelFondName = new System.Windows.Forms.Label();
            this.richTextBoxInfoBlago = new System.Windows.Forms.RichTextBox();
            this.pictureBoxLogoBlago = new System.Windows.Forms.PictureBox();
            this.buttonMore = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoBlago)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumPurple;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.labelFondName);
            this.panel2.Location = new System.Drawing.Point(-102, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(910, 74);
            this.panel2.TabIndex = 39;
            // 
            // labelFondName
            // 
            this.labelFondName.AutoSize = true;
            this.labelFondName.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFondName.ForeColor = System.Drawing.Color.White;
            this.labelFondName.Location = new System.Drawing.Point(367, 13);
            this.labelFondName.Name = "labelFondName";
            this.labelFondName.Size = new System.Drawing.Size(204, 43);
            this.labelFondName.TabIndex = 3;
            this.labelFondName.Text = "Фонд Кошек";
            this.labelFondName.Click += new System.EventHandler(this.labelFondName_Click);
            // 
            // richTextBoxInfoBlago
            // 
            this.richTextBoxInfoBlago.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxInfoBlago.Location = new System.Drawing.Point(12, 316);
            this.richTextBoxInfoBlago.Name = "richTextBoxInfoBlago";
            this.richTextBoxInfoBlago.ReadOnly = true;
            this.richTextBoxInfoBlago.Size = new System.Drawing.Size(735, 69);
            this.richTextBoxInfoBlago.TabIndex = 41;
            this.richTextBoxInfoBlago.Text = resources.GetString("richTextBoxInfoBlago.Text");
            this.richTextBoxInfoBlago.Visible = false;
            // 
            // pictureBoxLogoBlago
            // 
            this.pictureBoxLogoBlago.BackColor = System.Drawing.Color.White;
            this.pictureBoxLogoBlago.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxLogoBlago.Location = new System.Drawing.Point(275, 134);
            this.pictureBoxLogoBlago.Name = "pictureBoxLogoBlago";
            this.pictureBoxLogoBlago.Size = new System.Drawing.Size(188, 150);
            this.pictureBoxLogoBlago.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogoBlago.TabIndex = 40;
            this.pictureBoxLogoBlago.TabStop = false;
            this.pictureBoxLogoBlago.Visible = false;
            // 
            // buttonMore
            // 
            this.buttonMore.BackColor = System.Drawing.Color.Gold;
            this.buttonMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMore.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMore.Location = new System.Drawing.Point(593, 391);
            this.buttonMore.Name = "buttonMore";
            this.buttonMore.Size = new System.Drawing.Size(154, 35);
            this.buttonMore.TabIndex = 42;
            this.buttonMore.Text = "Узнать больше";
            this.buttonMore.UseVisualStyleBackColor = false;
            // 
            // FormSponsorMoreInfoFond
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(761, 434);
            this.Controls.Add(this.buttonMore);
            this.Controls.Add(this.richTextBoxInfoBlago);
            this.Controls.Add(this.pictureBoxLogoBlago);
            this.Controls.Add(this.panel2);
            this.Name = "FormSponsorMoreInfoFond";
            this.Text = "Информация о благотворительной организации";
            this.Load += new System.EventHandler(this.FormSponsorMoreInfoFond_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoBlago)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelFondName;
        private System.Windows.Forms.RichTextBox richTextBoxInfoBlago;
        private System.Windows.Forms.PictureBox pictureBoxLogoBlago;
        private System.Windows.Forms.Button buttonMore;
    }
}