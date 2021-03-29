
namespace Марафон
{
    partial class FormAdminUsersList
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
            this.label6 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.timerMarathon = new System.Windows.Forms.Timer(this.components);
            this.labelTime = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.usersDataGrid = new System.Windows.Forms.DataGridView();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.allNumberLabel = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(582, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 25);
            this.label6.TabIndex = 79;
            this.label6.Text = "Фильтр по ролям:";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Gold;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdate.Location = new System.Drawing.Point(770, 325);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(109, 37);
            this.buttonUpdate.TabIndex = 78;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(694, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 25);
            this.label7.TabIndex = 83;
            this.label7.Text = "Поиск:";
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSort.FormattingEnabled = true;
            this.comboBoxSort.Items.AddRange(new object[] {
            "Any",
            "Имя",
            "Фамилия",
            "Email",
            "Роль"});
            this.comboBoxSort.Location = new System.Drawing.Point(770, 247);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(218, 28);
            this.comboBoxSort.TabIndex = 82;
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Items.AddRange(new object[] {
            "Any"});
            this.comboBoxRole.Location = new System.Drawing.Point(770, 196);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(218, 28);
            this.comboBoxRole.TabIndex = 81;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(596, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 25);
            this.label5.TabIndex = 80;
            this.label5.Text = "Сортировать по:";
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.BackColor = System.Drawing.Color.Gold;
            this.buttonAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddNew.Location = new System.Drawing.Point(15, 228);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(172, 61);
            this.buttonAddNew.TabIndex = 77;
            this.buttonAddNew.Text = "+ добавление\r\nнового";
            this.buttonAddNew.UseVisualStyleBackColor = false;
            this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
            // 
            // textBoxFind
            // 
            this.textBoxFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFind.Location = new System.Drawing.Point(770, 293);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(218, 26);
            this.textBoxFind.TabIndex = 84;
            // 
            // timerMarathon
            // 
            this.timerMarathon.Tick += new System.EventHandler(this.timerMarathon_Tick);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelTime.Location = new System.Drawing.Point(115, 15);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(765, 37);
            this.labelTime.TabIndex = 5;
            this.labelTime.Text = "4 дней 18 часов и 18 минут до старта марафона!";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(12, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(292, 29);
            this.label8.TabIndex = 68;
            this.label8.Text = "Всего пользователей:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumPurple;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.labelTime);
            this.panel3.Location = new System.Drawing.Point(-3, 630);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1005, 73);
            this.panel3.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(264, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Управление пользователями";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumPurple;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-1, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1005, 75);
            this.panel2.TabIndex = 67;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.Gold;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogout.Location = new System.Drawing.Point(885, 29);
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
            this.buttonBack.Location = new System.Drawing.Point(21, 29);
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
            this.panel4.Location = new System.Drawing.Point(-1, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1005, 102);
            this.panel4.TabIndex = 66;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Марафон.Properties.Resources.logo_2016_full_colour1;
            this.pictureBoxLogo.Location = new System.Drawing.Point(151, 4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(706, 92);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 7;
            this.pictureBoxLogo.TabStop = false;
            // 
            // usersDataGrid
            // 
            this.usersDataGrid.AllowUserToAddRows = false;
            this.usersDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usersDataGrid.BackgroundColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.usersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.usersDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.usersDataGrid.EnableHeadersVisualStyles = false;
            this.usersDataGrid.GridColor = System.Drawing.Color.MediumPurple;
            this.usersDataGrid.Location = new System.Drawing.Point(15, 377);
            this.usersDataGrid.Name = "usersDataGrid";
            this.usersDataGrid.ReadOnly = true;
            this.usersDataGrid.RowHeadersVisible = false;
            this.usersDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usersDataGrid.Size = new System.Drawing.Size(973, 247);
            this.usersDataGrid.TabIndex = 85;
            this.usersDataGrid.SelectionChanged += new System.EventHandler(this.usersDataGrid_SelectionChanged);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Gold;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.Location = new System.Drawing.Point(886, 325);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(102, 37);
            this.buttonEdit.TabIndex = 86;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // allNumberLabel
            // 
            this.allNumberLabel.AutoSize = true;
            this.allNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allNumberLabel.ForeColor = System.Drawing.Color.Black;
            this.allNumberLabel.Location = new System.Drawing.Point(299, 348);
            this.allNumberLabel.Name = "allNumberLabel";
            this.allNumberLabel.Size = new System.Drawing.Size(81, 25);
            this.allNumberLabel.TabIndex = 87;
            this.allNumberLabel.Text = "Статус";
            // 
            // FormAdminUsersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1000, 702);
            this.Controls.Add(this.allNumberLabel);
            this.Controls.Add(this.textBoxFind);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.usersDataGrid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxSort);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonAddNew);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.MaximumSize = new System.Drawing.Size(1016, 741);
            this.MinimumSize = new System.Drawing.Size(1016, 741);
            this.Name = "FormAdminUsersList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пользователи";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAdminUsersList_FormClosing);
            this.Load += new System.EventHandler(this.FormAdminUsersList_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxSort;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Timer timerMarathon;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.DataGridView usersDataGrid;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label allNumberLabel;
    }
}