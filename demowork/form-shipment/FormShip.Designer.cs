namespace RPshipment.form_shipment
{
    partial class FormShip
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelAllService = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvShip = new System.Windows.Forms.DataGridView();
            this.iconBtnWorkPos = new FontAwesome.Sharp.IconButton();
            this.iconBtnSpecial = new FontAwesome.Sharp.IconButton();
            this.iconBtnUpdate = new FontAwesome.Sharp.IconButton();
            this.iconBtnDelete = new FontAwesome.Sharp.IconButton();
            this.panelClient = new System.Windows.Forms.Panel();
            this.panelMainData = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnumroom = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbshpclass = new System.Windows.Forms.ComboBox();
            this.cmbshpsetting = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.iconBtnAdd = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDesktop.SuspendLayout();
            this.panelAllService.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShip)).BeginInit();
            this.panelClient.SuspendLayout();
            this.panelMainData.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.panelAllService);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1300, 565);
            this.panelDesktop.TabIndex = 1;
            // 
            // panelAllService
            // 
            this.panelAllService.Controls.Add(this.panel1);
            this.panelAllService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAllService.Location = new System.Drawing.Point(0, 0);
            this.panelAllService.Name = "panelAllService";
            this.panelAllService.Size = new System.Drawing.Size(1300, 565);
            this.panelAllService.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvShip);
            this.panel1.Controls.Add(this.iconBtnWorkPos);
            this.panel1.Controls.Add(this.iconBtnSpecial);
            this.panel1.Controls.Add(this.iconBtnUpdate);
            this.panel1.Controls.Add(this.iconBtnDelete);
            this.panel1.Controls.Add(this.panelClient);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 565);
            this.panel1.TabIndex = 1;
            // 
            // dgvShip
            // 
            this.dgvShip.AllowUserToAddRows = false;
            this.dgvShip.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.dgvShip.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShip.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShip.ColumnHeadersHeight = 20;
            this.dgvShip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvShip.EnableHeadersVisualStyles = false;
            this.dgvShip.GridColor = System.Drawing.Color.Black;
            this.dgvShip.Location = new System.Drawing.Point(3, 3);
            this.dgvShip.Name = "dgvShip";
            this.dgvShip.ReadOnly = true;
            this.dgvShip.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgvShip.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvShip.Size = new System.Drawing.Size(879, 400);
            this.dgvShip.TabIndex = 33;
            // 
            // iconBtnWorkPos
            // 
            this.iconBtnWorkPos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.iconBtnWorkPos.FlatAppearance.BorderSize = 0;
            this.iconBtnWorkPos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnWorkPos.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconBtnWorkPos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconBtnWorkPos.IconChar = FontAwesome.Sharp.IconChar.Whmcs;
            this.iconBtnWorkPos.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconBtnWorkPos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnWorkPos.IconSize = 40;
            this.iconBtnWorkPos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconBtnWorkPos.Location = new System.Drawing.Point(554, 409);
            this.iconBtnWorkPos.Name = "iconBtnWorkPos";
            this.iconBtnWorkPos.Padding = new System.Windows.Forms.Padding(30);
            this.iconBtnWorkPos.Size = new System.Drawing.Size(328, 144);
            this.iconBtnWorkPos.TabIndex = 31;
            this.iconBtnWorkPos.Text = "Характеристика корабля";
            this.iconBtnWorkPos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconBtnWorkPos.UseVisualStyleBackColor = false;
            // 
            // iconBtnSpecial
            // 
            this.iconBtnSpecial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.iconBtnSpecial.FlatAppearance.BorderSize = 0;
            this.iconBtnSpecial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnSpecial.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconBtnSpecial.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconBtnSpecial.IconChar = FontAwesome.Sharp.IconChar.Whmcs;
            this.iconBtnSpecial.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconBtnSpecial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnSpecial.IconSize = 40;
            this.iconBtnSpecial.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconBtnSpecial.Location = new System.Drawing.Point(344, 409);
            this.iconBtnSpecial.Name = "iconBtnSpecial";
            this.iconBtnSpecial.Padding = new System.Windows.Forms.Padding(30);
            this.iconBtnSpecial.Size = new System.Drawing.Size(204, 144);
            this.iconBtnSpecial.TabIndex = 30;
            this.iconBtnSpecial.Text = "Класс корабля";
            this.iconBtnSpecial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconBtnSpecial.UseVisualStyleBackColor = false;
            // 
            // iconBtnUpdate
            // 
            this.iconBtnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.iconBtnUpdate.FlatAppearance.BorderSize = 0;
            this.iconBtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnUpdate.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconBtnUpdate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconBtnUpdate.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.iconBtnUpdate.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconBtnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnUpdate.IconSize = 40;
            this.iconBtnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnUpdate.Location = new System.Drawing.Point(26, 409);
            this.iconBtnUpdate.Name = "iconBtnUpdate";
            this.iconBtnUpdate.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.iconBtnUpdate.Size = new System.Drawing.Size(312, 75);
            this.iconBtnUpdate.TabIndex = 28;
            this.iconBtnUpdate.Text = "Обновить";
            this.iconBtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnUpdate.UseVisualStyleBackColor = false;
            this.iconBtnUpdate.Click += new System.EventHandler(this.iconBtnUpdate_Click);
            // 
            // iconBtnDelete
            // 
            this.iconBtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.iconBtnDelete.FlatAppearance.BorderSize = 0;
            this.iconBtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnDelete.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconBtnDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconBtnDelete.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconBtnDelete.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconBtnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnDelete.IconSize = 40;
            this.iconBtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnDelete.Location = new System.Drawing.Point(26, 490);
            this.iconBtnDelete.Name = "iconBtnDelete";
            this.iconBtnDelete.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.iconBtnDelete.Size = new System.Drawing.Size(312, 63);
            this.iconBtnDelete.TabIndex = 29;
            this.iconBtnDelete.Text = "Удалить";
            this.iconBtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnDelete.UseVisualStyleBackColor = false;
            this.iconBtnDelete.Click += new System.EventHandler(this.iconBtnDelete_Click);
            // 
            // panelClient
            // 
            this.panelClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.panelClient.Controls.Add(this.panelMainData);
            this.panelClient.Controls.Add(this.iconBtnAdd);
            this.panelClient.Controls.Add(this.label1);
            this.panelClient.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelClient.Location = new System.Drawing.Point(889, 0);
            this.panelClient.Name = "panelClient";
            this.panelClient.Size = new System.Drawing.Size(411, 565);
            this.panelClient.TabIndex = 26;
            // 
            // panelMainData
            // 
            this.panelMainData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.panelMainData.Controls.Add(this.label7);
            this.panelMainData.Controls.Add(this.txtnumroom);
            this.panelMainData.Controls.Add(this.label9);
            this.panelMainData.Controls.Add(this.cmbshpclass);
            this.panelMainData.Controls.Add(this.cmbshpsetting);
            this.panelMainData.Controls.Add(this.label8);
            this.panelMainData.Location = new System.Drawing.Point(17, 171);
            this.panelMainData.Name = "panelMainData";
            this.panelMainData.Size = new System.Drawing.Size(377, 154);
            this.panelMainData.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(23, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "характеристика корабля :";
            // 
            // txtnumroom
            // 
            this.txtnumroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.txtnumroom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnumroom.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtnumroom.Location = new System.Drawing.Point(112, 115);
            this.txtnumroom.Name = "txtnumroom";
            this.txtnumroom.Size = new System.Drawing.Size(166, 20);
            this.txtnumroom.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(43, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 19);
            this.label9.TabIndex = 22;
            this.label9.Text = "цена :";
            // 
            // cmbshpclass
            // 
            this.cmbshpclass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.cmbshpclass.DisplayMember = "ID";
            this.cmbshpclass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbshpclass.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbshpclass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmbshpclass.FormattingEnabled = true;
            this.cmbshpclass.Location = new System.Drawing.Point(27, 36);
            this.cmbshpclass.Name = "cmbshpclass";
            this.cmbshpclass.Size = new System.Drawing.Size(317, 22);
            this.cmbshpclass.TabIndex = 35;
            this.cmbshpclass.ValueMember = "ID";
            // 
            // cmbshpsetting
            // 
            this.cmbshpsetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.cmbshpsetting.DisplayMember = "ID";
            this.cmbshpsetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbshpsetting.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbshpsetting.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmbshpsetting.FormattingEnabled = true;
            this.cmbshpsetting.Location = new System.Drawing.Point(27, 87);
            this.cmbshpsetting.Name = "cmbshpsetting";
            this.cmbshpsetting.Size = new System.Drawing.Size(317, 22);
            this.cmbshpsetting.TabIndex = 34;
            this.cmbshpsetting.ValueMember = "ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(23, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 19);
            this.label8.TabIndex = 21;
            this.label8.Text = "класс корабля :";
            // 
            // iconBtnAdd
            // 
            this.iconBtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.iconBtnAdd.FlatAppearance.BorderSize = 0;
            this.iconBtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnAdd.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconBtnAdd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconBtnAdd.IconChar = FontAwesome.Sharp.IconChar.Tv;
            this.iconBtnAdd.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconBtnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnAdd.IconSize = 40;
            this.iconBtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnAdd.Location = new System.Drawing.Point(17, 331);
            this.iconBtnAdd.Name = "iconBtnAdd";
            this.iconBtnAdd.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.iconBtnAdd.Size = new System.Drawing.Size(377, 72);
            this.iconBtnAdd.TabIndex = 16;
            this.iconBtnAdd.Text = "Добавить";
            this.iconBtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnAdd.UseVisualStyleBackColor = false;
            this.iconBtnAdd.Click += new System.EventHandler(this.iconBtnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(119, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Корабль";
            // 
            // FormShip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1300, 565);
            this.Controls.Add(this.panelDesktop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormShip";
            this.Text = "Корабли";
            this.panelDesktop.ResumeLayout(false);
            this.panelAllService.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShip)).EndInit();
            this.panelClient.ResumeLayout(false);
            this.panelClient.PerformLayout();
            this.panelMainData.ResumeLayout(false);
            this.panelMainData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelAllService;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvShip;
        private FontAwesome.Sharp.IconButton iconBtnWorkPos;
        private FontAwesome.Sharp.IconButton iconBtnSpecial;
        private FontAwesome.Sharp.IconButton iconBtnUpdate;
        private FontAwesome.Sharp.IconButton iconBtnDelete;
        private System.Windows.Forms.Panel panelClient;
        private System.Windows.Forms.ComboBox cmbshpclass;
        private System.Windows.Forms.ComboBox cmbshpsetting;
        private System.Windows.Forms.TextBox txtnumroom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelMainData;
        private FontAwesome.Sharp.IconButton iconBtnAdd;
        private System.Windows.Forms.Label label1;
    }
}