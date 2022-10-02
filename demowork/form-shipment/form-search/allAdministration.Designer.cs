namespace RPshipment.form_shipment.form_search
{
    partial class allAdministration
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
            this.panelAdministration = new System.Windows.Forms.Panel();
            this.iconBtnAdmin = new FontAwesome.Sharp.IconButton();
            this.paneltxtAdmin = new System.Windows.Forms.Panel();
            this.dgvAdministration = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.dbSHPadmin = new RPshipment.dbSHPadmin();
            this.dbSHPadminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.администрацияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.администрацияTableAdapter = new RPshipment.dbSHPadminTableAdapters.АдминистрацияTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelAdministration.SuspendLayout();
            this.paneltxtAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdministration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSHPadmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSHPadminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.администрацияBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAdministration
            // 
            this.panelAdministration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.panelAdministration.Controls.Add(this.iconBtnAdmin);
            this.panelAdministration.Controls.Add(this.paneltxtAdmin);
            this.panelAdministration.Location = new System.Drawing.Point(12, 12);
            this.panelAdministration.Name = "panelAdministration";
            this.panelAdministration.Size = new System.Drawing.Size(1276, 545);
            this.panelAdministration.TabIndex = 8;
            // 
            // iconBtnAdmin
            // 
            this.iconBtnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.iconBtnAdmin.FlatAppearance.BorderSize = 0;
            this.iconBtnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnAdmin.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconBtnAdmin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconBtnAdmin.IconChar = FontAwesome.Sharp.IconChar.Hackerrank;
            this.iconBtnAdmin.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconBtnAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnAdmin.IconSize = 40;
            this.iconBtnAdmin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconBtnAdmin.Location = new System.Drawing.Point(14, 377);
            this.iconBtnAdmin.Name = "iconBtnAdmin";
            this.iconBtnAdmin.Padding = new System.Windows.Forms.Padding(20);
            this.iconBtnAdmin.Size = new System.Drawing.Size(1248, 102);
            this.iconBtnAdmin.TabIndex = 31;
            this.iconBtnAdmin.Text = "База данных";
            this.iconBtnAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconBtnAdmin.UseVisualStyleBackColor = false;
            // 
            // paneltxtAdmin
            // 
            this.paneltxtAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.paneltxtAdmin.Controls.Add(this.dgvAdministration);
            this.paneltxtAdmin.Controls.Add(this.label10);
            this.paneltxtAdmin.Location = new System.Drawing.Point(14, 14);
            this.paneltxtAdmin.Margin = new System.Windows.Forms.Padding(0);
            this.paneltxtAdmin.Name = "paneltxtAdmin";
            this.paneltxtAdmin.Size = new System.Drawing.Size(1248, 360);
            this.paneltxtAdmin.TabIndex = 1;
            // 
            // dgvAdministration
            // 
            this.dgvAdministration.AllowUserToAddRows = false;
            this.dgvAdministration.AutoGenerateColumns = false;
            this.dgvAdministration.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.dgvAdministration.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdministration.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAdministration.ColumnHeadersHeight = 20;
            this.dgvAdministration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAdministration.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dgvAdministration.DataSource = this.администрацияBindingSource;
            this.dgvAdministration.EnableHeadersVisualStyles = false;
            this.dgvAdministration.GridColor = System.Drawing.Color.Black;
            this.dgvAdministration.Location = new System.Drawing.Point(3, 34);
            this.dgvAdministration.Name = "dgvAdministration";
            this.dgvAdministration.ReadOnly = true;
            this.dgvAdministration.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgvAdministration.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAdministration.Size = new System.Drawing.Size(1242, 311);
            this.dgvAdministration.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 0, 3, 2);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(3);
            this.label10.Size = new System.Drawing.Size(1248, 29);
            this.label10.TabIndex = 20;
            this.label10.Text = "Администрация";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dbSHPadmin
            // 
            this.dbSHPadmin.DataSetName = "dbSHPadmin";
            this.dbSHPadmin.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbSHPadminBindingSource
            // 
            this.dbSHPadminBindingSource.DataSource = this.dbSHPadmin;
            this.dbSHPadminBindingSource.Position = 0;
            // 
            // администрацияBindingSource
            // 
            this.администрацияBindingSource.DataMember = "Администрация";
            this.администрацияBindingSource.DataSource = this.dbSHPadminBindingSource;
            // 
            // администрацияTableAdapter
            // 
            this.администрацияTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 25;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // allAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1300, 565);
            this.Controls.Add(this.panelAdministration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "allAdministration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "allAdministration";
            this.Load += new System.EventHandler(this.allAdministration_Load);
            this.panelAdministration.ResumeLayout(false);
            this.paneltxtAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdministration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSHPadmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSHPadminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.администрацияBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAdministration;
        private FontAwesome.Sharp.IconButton iconBtnAdmin;
        private System.Windows.Forms.Panel paneltxtAdmin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvAdministration;
        private System.Windows.Forms.BindingSource dbSHPadminBindingSource;
        private dbSHPadmin dbSHPadmin;
        private System.Windows.Forms.BindingSource администрацияBindingSource;
        private dbSHPadminTableAdapters.АдминистрацияTableAdapter администрацияTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
    }
}