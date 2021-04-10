
namespace Марафон
{
    partial class FormPreviousResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPreviousResult));
            this.labelTime = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timerMarathon = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.timeNumberLabel = new System.Windows.Forms.Label();
            this.finishNumberLabel = new System.Windows.Forms.Label();
            this.runnerNumberLabel = new System.Windows.Forms.Label();
            this.raceDataGrid = new System.Windows.Forms.DataGridView();
            this.timeLabel = new System.Windows.Forms.Label();
            this.finishLabel = new System.Windows.Forms.Label();
            this.runnersLabel = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.ageComboBox = new System.Windows.Forms.ComboBox();
            this.distanceComboBox = new System.Windows.Forms.ComboBox();
            this.marathonComboBox = new System.Windows.Forms.ComboBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.sexLabel = new System.Windows.Forms.Label();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.marathonLabel = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelTime.Location = new System.Drawing.Point(122, 15);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(765, 37);
            this.labelTime.TabIndex = 5;
            this.labelTime.Text = "4 дней 18 часов и 18 минут до старта марафона!";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumPurple;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.labelTime);
            this.panel3.Location = new System.Drawing.Point(-8, 578);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1005, 80);
            this.panel3.TabIndex = 50;
            // 
            // timerMarathon
            // 
            this.timerMarathon.Tick += new System.EventHandler(this.timerMarathon_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumPurple;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-5, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1005, 78);
            this.panel2.TabIndex = 51;
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.buttonBack);
            this.panel4.Controls.Add(this.pictureBoxLogo);
            this.panel4.Location = new System.Drawing.Point(-5, -3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1005, 109);
            this.panel4.TabIndex = 47;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Gold;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.pictureBoxLogo.Size = new System.Drawing.Size(721, 92);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 7;
            this.pictureBoxLogo.TabStop = false;
            // 
            // timeNumberLabel
            // 
            this.timeNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeNumberLabel.ForeColor = System.Drawing.Color.Navy;
            this.timeNumberLabel.Location = new System.Drawing.Point(879, 318);
            this.timeNumberLabel.Name = "timeNumberLabel";
            this.timeNumberLabel.Size = new System.Drawing.Size(82, 22);
            this.timeNumberLabel.TabIndex = 72;
            this.timeNumberLabel.Text = "...";
            // 
            // finishNumberLabel
            // 
            this.finishNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.finishNumberLabel.ForeColor = System.Drawing.Color.Navy;
            this.finishNumberLabel.Location = new System.Drawing.Point(586, 316);
            this.finishNumberLabel.Name = "finishNumberLabel";
            this.finishNumberLabel.Size = new System.Drawing.Size(96, 22);
            this.finishNumberLabel.TabIndex = 71;
            this.finishNumberLabel.Text = "...";
            // 
            // runnerNumberLabel
            // 
            this.runnerNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.runnerNumberLabel.ForeColor = System.Drawing.Color.Navy;
            this.runnerNumberLabel.Location = new System.Drawing.Point(162, 318);
            this.runnerNumberLabel.Name = "runnerNumberLabel";
            this.runnerNumberLabel.Size = new System.Drawing.Size(72, 22);
            this.runnerNumberLabel.TabIndex = 70;
            this.runnerNumberLabel.Text = "...";
            // 
            // raceDataGrid
            // 
            this.raceDataGrid.AllowUserToAddRows = false;
            this.raceDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.raceDataGrid.BackgroundColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.raceDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.raceDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.raceDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.raceDataGrid.EnableHeadersVisualStyles = false;
            this.raceDataGrid.Location = new System.Drawing.Point(12, 354);
            this.raceDataGrid.Name = "raceDataGrid";
            this.raceDataGrid.RowHeadersVisible = false;
            this.raceDataGrid.Size = new System.Drawing.Size(966, 218);
            this.raceDataGrid.TabIndex = 69;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLabel.ForeColor = System.Drawing.Color.Navy;
            this.timeLabel.Location = new System.Drawing.Point(727, 316);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(156, 24);
            this.timeLabel.TabIndex = 68;
            this.timeLabel.Text = "Среднее время:";
            // 
            // finishLabel
            // 
            this.finishLabel.AutoSize = true;
            this.finishLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.finishLabel.ForeColor = System.Drawing.Color.Navy;
            this.finishLabel.Location = new System.Drawing.Point(293, 316);
            this.finishLabel.Name = "finishLabel";
            this.finishLabel.Size = new System.Drawing.Size(287, 24);
            this.finishLabel.TabIndex = 67;
            this.finishLabel.Text = "Всего бегунов финишировало:";
            // 
            // runnersLabel
            // 
            this.runnersLabel.AutoSize = true;
            this.runnersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.runnersLabel.ForeColor = System.Drawing.Color.Navy;
            this.runnersLabel.Location = new System.Drawing.Point(14, 316);
            this.runnersLabel.Name = "runnersLabel";
            this.runnersLabel.Size = new System.Drawing.Size(151, 24);
            this.runnersLabel.TabIndex = 66;
            this.runnersLabel.Text = "Всего бегунов: ";
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Gold;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.ForeColor = System.Drawing.Color.Black;
            this.buttonSearch.Location = new System.Drawing.Point(771, 244);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(84, 33);
            this.buttonSearch.TabIndex = 57;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // sexComboBox
            // 
            this.sexComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sexComboBox.ForeColor = System.Drawing.Color.Black;
            this.sexComboBox.FormattingEnabled = true;
            this.sexComboBox.Location = new System.Drawing.Point(581, 207);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(184, 32);
            this.sexComboBox.TabIndex = 65;
            // 
            // ageComboBox
            // 
            this.ageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ageComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageComboBox.ForeColor = System.Drawing.Color.Black;
            this.ageComboBox.FormattingEnabled = true;
            this.ageComboBox.Location = new System.Drawing.Point(581, 245);
            this.ageComboBox.Name = "ageComboBox";
            this.ageComboBox.Size = new System.Drawing.Size(184, 32);
            this.ageComboBox.TabIndex = 64;
            // 
            // distanceComboBox
            // 
            this.distanceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.distanceComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.distanceComboBox.ForeColor = System.Drawing.Color.Black;
            this.distanceComboBox.FormattingEnabled = true;
            this.distanceComboBox.Location = new System.Drawing.Point(254, 245);
            this.distanceComboBox.Name = "distanceComboBox";
            this.distanceComboBox.Size = new System.Drawing.Size(198, 32);
            this.distanceComboBox.TabIndex = 63;
            // 
            // marathonComboBox
            // 
            this.marathonComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.marathonComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.marathonComboBox.ForeColor = System.Drawing.Color.Black;
            this.marathonComboBox.FormattingEnabled = true;
            this.marathonComboBox.Location = new System.Drawing.Point(254, 207);
            this.marathonComboBox.Name = "marathonComboBox";
            this.marathonComboBox.Size = new System.Drawing.Size(198, 32);
            this.marathonComboBox.TabIndex = 62;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageLabel.ForeColor = System.Drawing.Color.Navy;
            this.ageLabel.Location = new System.Drawing.Point(467, 248);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(110, 24);
            this.ageLabel.TabIndex = 61;
            this.ageLabel.Text = "Категория:";
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sexLabel.ForeColor = System.Drawing.Color.Navy;
            this.sexLabel.Location = new System.Drawing.Point(528, 214);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(49, 24);
            this.sexLabel.TabIndex = 60;
            this.sexLabel.Text = "Пол:";
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.distanceLabel.ForeColor = System.Drawing.Color.Navy;
            this.distanceLabel.Location = new System.Drawing.Point(135, 248);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(113, 24);
            this.distanceLabel.TabIndex = 59;
            this.distanceLabel.Text = "Дистанция:";
            // 
            // marathonLabel
            // 
            this.marathonLabel.AutoSize = true;
            this.marathonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.marathonLabel.ForeColor = System.Drawing.Color.Navy;
            this.marathonLabel.Location = new System.Drawing.Point(150, 213);
            this.marathonLabel.Name = "marathonLabel";
            this.marathonLabel.Size = new System.Drawing.Size(98, 24);
            this.marathonLabel.TabIndex = 58;
            this.marathonLabel.Text = "Марафон:";
            // 
            // FormPreviousResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(990, 651);
            this.Controls.Add(this.ageComboBox);
            this.Controls.Add(this.marathonComboBox);
            this.Controls.Add(this.marathonLabel);
            this.Controls.Add(this.timeNumberLabel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.finishNumberLabel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.runnerNumberLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.raceDataGrid);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.finishLabel);
            this.Controls.Add(this.distanceLabel);
            this.Controls.Add(this.runnersLabel);
            this.Controls.Add(this.sexLabel);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.sexComboBox);
            this.Controls.Add(this.distanceComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPreviousResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Результаты прошедших гонок";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPreviousResult_FormClosing);
            this.Load += new System.EventHandler(this.FormPreviousResult_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Timer timerMarathon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label timeNumberLabel;
        private System.Windows.Forms.Label finishNumberLabel;
        private System.Windows.Forms.Label runnerNumberLabel;
        private System.Windows.Forms.DataGridView raceDataGrid;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label finishLabel;
        private System.Windows.Forms.Label runnersLabel;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ComboBox sexComboBox;
        private System.Windows.Forms.ComboBox ageComboBox;
        private System.Windows.Forms.ComboBox distanceComboBox;
        private System.Windows.Forms.ComboBox marathonComboBox;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.Label marathonLabel;
    }
}