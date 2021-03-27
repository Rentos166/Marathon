
namespace Марафон
{
    partial class FormRunnerMyResults
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.downPanel = new System.Windows.Forms.Panel();
            this.timerMarathon = new System.Windows.Forms.Timer(this.components);
            this.showButton = new System.Windows.Forms.Button();
            this.ageLoadLabel = new System.Windows.Forms.Label();
            this.sexLoadLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.sexLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.resultDataGrid = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.downPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // downPanel
            // 
            this.downPanel.BackColor = System.Drawing.Color.MediumPurple;
            this.downPanel.Controls.Add(this.labelTime);
            this.downPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.downPanel.Location = new System.Drawing.Point(0, 545);
            this.downPanel.Name = "downPanel";
            this.downPanel.Size = new System.Drawing.Size(850, 60);
            this.downPanel.TabIndex = 68;
            // 
            // timerMarathon
            // 
            this.timerMarathon.Enabled = true;
            this.timerMarathon.Interval = 1000;
            this.timerMarathon.Tick += new System.EventHandler(this.timerMarathon_Tick);
            // 
            // showButton
            // 
            this.showButton.BackColor = System.Drawing.Color.Gold;
            this.showButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showButton.ForeColor = System.Drawing.Color.Black;
            this.showButton.Location = new System.Drawing.Point(267, 500);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(286, 30);
            this.showButton.TabIndex = 76;
            this.showButton.Text = "Показать все результаты";
            this.showButton.UseVisualStyleBackColor = false;
            // 
            // ageLoadLabel
            // 
            this.ageLoadLabel.AutoSize = true;
            this.ageLoadLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageLoadLabel.ForeColor = System.Drawing.Color.Navy;
            this.ageLoadLabel.Location = new System.Drawing.Point(568, 257);
            this.ageLoadLabel.Name = "ageLoadLabel";
            this.ageLoadLabel.Size = new System.Drawing.Size(60, 22);
            this.ageLoadLabel.TabIndex = 74;
            this.ageLoadLabel.Text = "18-29";
            this.ageLoadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sexLoadLabel
            // 
            this.sexLoadLabel.AutoSize = true;
            this.sexLoadLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sexLoadLabel.ForeColor = System.Drawing.Color.Navy;
            this.sexLoadLabel.Location = new System.Drawing.Point(251, 257);
            this.sexLoadLabel.Name = "sexLoadLabel";
            this.sexLoadLabel.Size = new System.Drawing.Size(85, 22);
            this.sexLoadLabel.TabIndex = 73;
            this.sexLoadLabel.Text = "мужской";
            this.sexLoadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageLabel.ForeColor = System.Drawing.Color.Navy;
            this.ageLabel.Location = new System.Drawing.Point(342, 257);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(229, 22);
            this.ageLabel.TabIndex = 72;
            this.ageLabel.Text = "Возрастная категория:";
            this.ageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sexLabel.ForeColor = System.Drawing.Color.Navy;
            this.sexLabel.Location = new System.Drawing.Point(200, 257);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(55, 22);
            this.sexLabel.TabIndex = 71;
            this.sexLabel.Text = "Пол:";
            this.sexLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.White;
            this.descriptionLabel.Location = new System.Drawing.Point(71, 50);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(691, 72);
            this.descriptionLabel.TabIndex = 70;
            this.descriptionLabel.Text = "Это - список всех ваших прошлых результатов гонки для Marathom Skills.\r\nОбщее мес" +
    "то сравнивает всех бегунов\r\nМесто по категории compares runners in the same gend" +
    "er and age categories.\r\n";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultDataGrid
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 14.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.resultDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.resultDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resultDataGrid.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.resultDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.resultDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 14.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.resultDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.resultDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDataGrid.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 14.25F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.resultDataGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.resultDataGrid.EnableHeadersVisualStyles = false;
            this.resultDataGrid.GridColor = System.Drawing.SystemColors.Control;
            this.resultDataGrid.Location = new System.Drawing.Point(6, 282);
            this.resultDataGrid.MultiSelect = false;
            this.resultDataGrid.Name = "resultDataGrid";
            this.resultDataGrid.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 14.25F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.resultDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.resultDataGrid.RowHeadersVisible = false;
            this.resultDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 14.25F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.resultDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.resultDataGrid.Size = new System.Drawing.Size(832, 212);
            this.resultDataGrid.TabIndex = 75;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumPurple;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.descriptionLabel);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(850, 138);
            this.panel2.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(289, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Мои результаты";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.buttonBack);
            this.panel4.Controls.Add(this.pictureBoxLogo);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(850, 107);
            this.panel4.TabIndex = 77;
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
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.ForeColor = System.Drawing.Color.GhostWhite;
            this.labelTime.Location = new System.Drawing.Point(43, 12);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(765, 37);
            this.labelTime.TabIndex = 6;
            this.labelTime.Text = "4 дней 18 часов и 18 минут до старта марафона!";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Марафон.Properties.Resources.logo_2016_full_colour;
            this.pictureBoxLogo.Location = new System.Drawing.Point(151, 4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(685, 92);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 7;
            this.pictureBoxLogo.TabStop = false;
            // 
            // FormRunnerMyResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(850, 605);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.downPanel);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.resultDataGrid);
            this.Controls.Add(this.ageLoadLabel);
            this.Controls.Add(this.sexLoadLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.sexLabel);
            this.MinimumSize = new System.Drawing.Size(866, 644);
            this.Name = "FormRunnerMyResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мои результаты";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRunnerMyResults_FormClosing);
            this.Load += new System.EventHandler(this.FormRunnerMyResults_Load);
            this.downPanel.ResumeLayout(false);
            this.downPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel downPanel;
        private System.Windows.Forms.Timer timerMarathon;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Label ageLoadLabel;
        private System.Windows.Forms.Label sexLoadLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.DataGridView resultDataGrid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelTime;
    }
}