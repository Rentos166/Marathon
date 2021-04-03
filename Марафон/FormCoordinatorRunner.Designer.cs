
namespace Марафон
{
    partial class FormCoordinatorRunner
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCoordinatorRunner));
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timerMarathon = new System.Windows.Forms.Timer(this.components);
            this.changeButton = new System.Windows.Forms.Button();
            this.emailButton = new System.Windows.Forms.Button();
            this.csvButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.runnersDataGrid = new System.Windows.Forms.DataGridView();
            this.totalNumberLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.distanceComboBox = new System.Windows.Forms.ComboBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.sortLabel = new System.Windows.Forms.Label();
            this.distanseLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.exportLabel = new System.Windows.Forms.Label();
            this.sortFilterLabel = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.runnersDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.buttonLogout);
            this.panel4.Controls.Add(this.buttonBack);
            this.panel4.Controls.Add(this.pictureBoxLogo);
            this.panel4.Location = new System.Drawing.Point(-6, -5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1005, 109);
            this.panel4.TabIndex = 52;
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
            this.panel3.Location = new System.Drawing.Point(-6, 673);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1005, 80);
            this.panel3.TabIndex = 53;
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
            this.panel2.Location = new System.Drawing.Point(-6, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1005, 78);
            this.panel2.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(232, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(552, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Предыдущие результаты гонок";
            // 
            // timerMarathon
            // 
            this.timerMarathon.Tick += new System.EventHandler(this.timerMarathon_Tick);
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.Gold;
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeButton.ForeColor = System.Drawing.Color.Black;
            this.changeButton.Location = new System.Drawing.Point(735, 351);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(231, 30);
            this.changeButton.TabIndex = 96;
            this.changeButton.Text = "Изменить";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // emailButton
            // 
            this.emailButton.BackColor = System.Drawing.Color.Gold;
            this.emailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emailButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailButton.ForeColor = System.Drawing.Color.Black;
            this.emailButton.Location = new System.Drawing.Point(735, 292);
            this.emailButton.Name = "emailButton";
            this.emailButton.Size = new System.Drawing.Size(231, 53);
            this.emailButton.TabIndex = 95;
            this.emailButton.Text = "E-mail список";
            this.emailButton.UseVisualStyleBackColor = false;
            this.emailButton.Click += new System.EventHandler(this.emailButton_Click);
            // 
            // csvButton
            // 
            this.csvButton.BackColor = System.Drawing.Color.Gold;
            this.csvButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.csvButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.csvButton.ForeColor = System.Drawing.Color.Black;
            this.csvButton.Location = new System.Drawing.Point(735, 248);
            this.csvButton.Name = "csvButton";
            this.csvButton.Size = new System.Drawing.Size(231, 38);
            this.csvButton.TabIndex = 94;
            this.csvButton.Text = "Детальная информация (CSV)";
            this.csvButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.csvButton.UseVisualStyleBackColor = false;
            this.csvButton.Click += new System.EventHandler(this.csvButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.Gold;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.refreshButton.ForeColor = System.Drawing.Color.Black;
            this.refreshButton.Location = new System.Drawing.Point(456, 343);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(139, 30);
            this.refreshButton.TabIndex = 82;
            this.refreshButton.Text = "Обновить";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // runnersDataGrid
            // 
            this.runnersDataGrid.AllowUserToAddRows = false;
            this.runnersDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.runnersDataGrid.BackgroundColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.runnersDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.runnersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.runnersDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.runnersDataGrid.EnableHeadersVisualStyles = false;
            this.runnersDataGrid.Location = new System.Drawing.Point(17, 409);
            this.runnersDataGrid.Name = "runnersDataGrid";
            this.runnersDataGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.runnersDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.runnersDataGrid.RowHeadersVisible = false;
            this.runnersDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.runnersDataGrid.Size = new System.Drawing.Size(949, 236);
            this.runnersDataGrid.TabIndex = 93;
            this.runnersDataGrid.SelectionChanged += new System.EventHandler(this.runnersDataGrid_SelectionChanged);
            // 
            // totalNumberLabel
            // 
            this.totalNumberLabel.AutoSize = true;
            this.totalNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalNumberLabel.ForeColor = System.Drawing.Color.Navy;
            this.totalNumberLabel.Location = new System.Drawing.Point(569, 382);
            this.totalNumberLabel.Name = "totalNumberLabel";
            this.totalNumberLabel.Size = new System.Drawing.Size(40, 24);
            this.totalNumberLabel.TabIndex = 92;
            this.totalNumberLabel.Text = "123";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalLabel.ForeColor = System.Drawing.Color.Navy;
            this.totalLabel.Location = new System.Drawing.Point(437, 382);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(126, 24);
            this.totalLabel.TabIndex = 91;
            this.totalLabel.Text = "Total runners:";
            // 
            // sortComboBox
            // 
            this.sortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortComboBox.ForeColor = System.Drawing.Color.Black;
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Location = new System.Drawing.Point(162, 351);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(170, 32);
            this.sortComboBox.TabIndex = 90;
            // 
            // distanceComboBox
            // 
            this.distanceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.distanceComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.distanceComboBox.ForeColor = System.Drawing.Color.Black;
            this.distanceComboBox.FormattingEnabled = true;
            this.distanceComboBox.Location = new System.Drawing.Point(162, 310);
            this.distanceComboBox.Name = "distanceComboBox";
            this.distanceComboBox.Size = new System.Drawing.Size(170, 32);
            this.distanceComboBox.TabIndex = 89;
            // 
            // statusComboBox
            // 
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusComboBox.ForeColor = System.Drawing.Color.Black;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(162, 271);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(170, 32);
            this.statusComboBox.TabIndex = 88;
            // 
            // sortLabel
            // 
            this.sortLabel.AutoSize = true;
            this.sortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortLabel.ForeColor = System.Drawing.Color.Navy;
            this.sortLabel.Location = new System.Drawing.Point(26, 351);
            this.sortLabel.Name = "sortLabel";
            this.sortLabel.Size = new System.Drawing.Size(135, 24);
            this.sortLabel.TabIndex = 87;
            this.sortLabel.Text = "Сортировать:";
            // 
            // distanseLabel
            // 
            this.distanseLabel.AutoSize = true;
            this.distanseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.distanseLabel.ForeColor = System.Drawing.Color.Navy;
            this.distanseLabel.Location = new System.Drawing.Point(49, 313);
            this.distanseLabel.Name = "distanseLabel";
            this.distanseLabel.Size = new System.Drawing.Size(113, 24);
            this.distanseLabel.TabIndex = 86;
            this.distanseLabel.Text = "Дистанция:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLabel.ForeColor = System.Drawing.Color.Navy;
            this.statusLabel.Location = new System.Drawing.Point(82, 274);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(77, 24);
            this.statusLabel.TabIndex = 85;
            this.statusLabel.Text = "Статус:";
            // 
            // exportLabel
            // 
            this.exportLabel.AutoSize = true;
            this.exportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exportLabel.ForeColor = System.Drawing.Color.Navy;
            this.exportLabel.Location = new System.Drawing.Point(785, 207);
            this.exportLabel.Name = "exportLabel";
            this.exportLabel.Size = new System.Drawing.Size(128, 29);
            this.exportLabel.TabIndex = 84;
            this.exportLabel.Text = "Выгрузка";
            // 
            // sortFilterLabel
            // 
            this.sortFilterLabel.AutoSize = true;
            this.sortFilterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortFilterLabel.ForeColor = System.Drawing.Color.Navy;
            this.sortFilterLabel.Location = new System.Drawing.Point(25, 230);
            this.sortFilterLabel.Name = "sortFilterLabel";
            this.sortFilterLabel.Size = new System.Drawing.Size(345, 29);
            this.sortFilterLabel.TabIndex = 83;
            this.sortFilterLabel.Text = "Сортировка и фильтрация";
            // 
            // FormCoordinatorRunner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(990, 747);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.emailButton);
            this.Controls.Add(this.csvButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.runnersDataGrid);
            this.Controls.Add(this.totalNumberLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.sortComboBox);
            this.Controls.Add(this.distanceComboBox);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.sortLabel);
            this.Controls.Add(this.distanseLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.exportLabel);
            this.Controls.Add(this.sortFilterLabel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCoordinatorRunner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Бегуны";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCoordinatorRunner_FormClosing);
            this.Load += new System.EventHandler(this.FormCoordinatorRunner_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.runnersDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerMarathon;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button emailButton;
        private System.Windows.Forms.Button csvButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.DataGridView runnersDataGrid;
        private System.Windows.Forms.Label totalNumberLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.ComboBox sortComboBox;
        private System.Windows.Forms.ComboBox distanceComboBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label sortLabel;
        private System.Windows.Forms.Label distanseLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label exportLabel;
        private System.Windows.Forms.Label sortFilterLabel;
        private System.Windows.Forms.Button buttonLogout;
    }
}