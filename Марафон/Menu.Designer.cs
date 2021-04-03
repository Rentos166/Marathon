namespace Марафон
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panelCity = new System.Windows.Forms.Panel();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.panelTime = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.timerMarathon = new System.Windows.Forms.Timer(this.components);
            this.buttonAuthorization = new System.Windows.Forms.Button();
            this.buttonMore = new System.Windows.Forms.Button();
            this.buttonSponsor = new System.Windows.Forms.Button();
            this.buttonRunner = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelCity.SuspendLayout();
            this.panelTime.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCity
            // 
            this.panelCity.BackColor = System.Drawing.Color.MediumPurple;
            this.panelCity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCity.Controls.Add(this.labelDate);
            this.panelCity.Controls.Add(this.labelCity);
            this.panelCity.Location = new System.Drawing.Point(-105, 130);
            this.panelCity.Name = "panelCity";
            this.panelCity.Size = new System.Drawing.Size(1005, 96);
            this.panelCity.TabIndex = 8;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.ForeColor = System.Drawing.Color.GhostWhite;
            this.labelDate.Location = new System.Drawing.Point(437, 47);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(222, 31);
            this.labelDate.TabIndex = 4;
            this.labelDate.Text = "24 ноября 2016";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCity.ForeColor = System.Drawing.Color.GhostWhite;
            this.labelCity.Location = new System.Drawing.Point(354, 16);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(387, 31);
            this.labelCity.TabIndex = 3;
            this.labelCity.Text = "Кировская область, Россия";
            // 
            // panelTime
            // 
            this.panelTime.BackColor = System.Drawing.Color.MediumPurple;
            this.panelTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTime.Controls.Add(this.labelTime);
            this.panelTime.Location = new System.Drawing.Point(-104, 504);
            this.panelTime.Name = "panelTime";
            this.panelTime.Size = new System.Drawing.Size(1005, 89);
            this.panelTime.TabIndex = 9;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.ForeColor = System.Drawing.Color.GhostWhite;
            this.labelTime.Location = new System.Drawing.Point(168, 27);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(765, 37);
            this.labelTime.TabIndex = 5;
            this.labelTime.Text = "8 дней 15 часов и 18 минут до старта марафона!";
            // 
            // timerMarathon
            // 
            this.timerMarathon.Tick += new System.EventHandler(this.timerMarathon_Tick);
            // 
            // buttonAuthorization
            // 
            this.buttonAuthorization.BackColor = System.Drawing.Color.Yellow;
            this.buttonAuthorization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAuthorization.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAuthorization.Location = new System.Drawing.Point(742, 420);
            this.buttonAuthorization.Name = "buttonAuthorization";
            this.buttonAuthorization.Size = new System.Drawing.Size(133, 67);
            this.buttonAuthorization.TabIndex = 13;
            this.buttonAuthorization.Text = "Login";
            this.buttonAuthorization.UseVisualStyleBackColor = false;
            this.buttonAuthorization.Click += new System.EventHandler(this.buttonAuthorization_Click);
            // 
            // buttonMore
            // 
            this.buttonMore.BackColor = System.Drawing.Color.Yellow;
            this.buttonMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMore.Location = new System.Drawing.Point(216, 411);
            this.buttonMore.Name = "buttonMore";
            this.buttonMore.Size = new System.Drawing.Size(451, 76);
            this.buttonMore.TabIndex = 12;
            this.buttonMore.Text = "Я хочу узнать больше о событии";
            this.buttonMore.UseVisualStyleBackColor = false;
            this.buttonMore.Click += new System.EventHandler(this.buttonMore_Click);
            // 
            // buttonSponsor
            // 
            this.buttonSponsor.BackColor = System.Drawing.Color.Yellow;
            this.buttonSponsor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSponsor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSponsor.Location = new System.Drawing.Point(216, 329);
            this.buttonSponsor.Name = "buttonSponsor";
            this.buttonSponsor.Size = new System.Drawing.Size(451, 76);
            this.buttonSponsor.TabIndex = 11;
            this.buttonSponsor.Text = "Я хочу стать спонсором бегуна";
            this.buttonSponsor.UseVisualStyleBackColor = false;
            this.buttonSponsor.Click += new System.EventHandler(this.buttonSponsor_Click);
            // 
            // buttonRunner
            // 
            this.buttonRunner.BackColor = System.Drawing.Color.Yellow;
            this.buttonRunner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRunner.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRunner.Location = new System.Drawing.Point(216, 247);
            this.buttonRunner.Name = "buttonRunner";
            this.buttonRunner.Size = new System.Drawing.Size(451, 76);
            this.buttonRunner.TabIndex = 10;
            this.buttonRunner.Text = "Я хочу стать бегуном";
            this.buttonRunner.UseVisualStyleBackColor = false;
            this.buttonRunner.Click += new System.EventHandler(this.buttonRunner_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.White;
            this.panelLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelLogo.Controls.Add(this.pictureBoxLogo);
            this.panelLogo.Location = new System.Drawing.Point(-55, -4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(1005, 134);
            this.panelLogo.TabIndex = 14;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Марафон.Properties.Resources.logo_2016_full_colour;
            this.pictureBoxLogo.Location = new System.Drawing.Point(152, -2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(665, 149);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(894, 593);
            this.Controls.Add(this.panelLogo);
            this.Controls.Add(this.panelCity);
            this.Controls.Add(this.panelTime);
            this.Controls.Add(this.buttonAuthorization);
            this.Controls.Add(this.buttonMore);
            this.Controls.Add(this.buttonSponsor);
            this.Controls.Add(this.buttonRunner);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panelCity.ResumeLayout(false);
            this.panelCity.PerformLayout();
            this.panelTime.ResumeLayout(false);
            this.panelTime.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelCity;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Panel panelTime;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timerMarathon;
        private System.Windows.Forms.Button buttonAuthorization;
        private System.Windows.Forms.Button buttonMore;
        private System.Windows.Forms.Button buttonSponsor;
        private System.Windows.Forms.Button buttonRunner;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}

