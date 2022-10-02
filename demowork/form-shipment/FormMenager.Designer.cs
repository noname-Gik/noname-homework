namespace RPshipment.form_shipment
{
    partial class FormMenager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.iconBtnPass = new FontAwesome.Sharp.IconButton();
            this.iconBtnUpdate = new FontAwesome.Sharp.IconButton();
            this.iconBtnDelete = new FontAwesome.Sharp.IconButton();
            this.dgvMenager = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.почтаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.парольDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаВходаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаСбросаПароляDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаБлокировкаПользователяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.активностьDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.менеджерПоПродажамBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSHPmenager = new RPshipment.dbSHPmenager();
            this.panelClient = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mtxtnum = new System.Windows.Forms.MaskedTextBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbshpclass = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtOtch = new System.Windows.Forms.TextBox();
            this.txtFm = new System.Windows.Forms.TextBox();
            this.txtIm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.iconBtnAdd = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.менеджер_по_продажамTableAdapter = new RPshipment.dbSHPmenagerTableAdapters.Менеджер_по_продажамTableAdapter();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.менеджерПоПродажамBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSHPmenager)).BeginInit();
            this.panelClient.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.iconBtnPass);
            this.panelDesktop.Controls.Add(this.iconBtnUpdate);
            this.panelDesktop.Controls.Add(this.iconBtnDelete);
            this.panelDesktop.Controls.Add(this.dgvMenager);
            this.panelDesktop.Controls.Add(this.panelClient);
            this.panelDesktop.Controls.Add(this.lblTime);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1300, 565);
            this.panelDesktop.TabIndex = 4;
            // 
            // iconBtnPass
            // 
            this.iconBtnPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.iconBtnPass.FlatAppearance.BorderSize = 0;
            this.iconBtnPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnPass.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconBtnPass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconBtnPass.IconChar = FontAwesome.Sharp.IconChar.Grav;
            this.iconBtnPass.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconBtnPass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnPass.IconSize = 40;
            this.iconBtnPass.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconBtnPass.Location = new System.Drawing.Point(445, 460);
            this.iconBtnPass.Name = "iconBtnPass";
            this.iconBtnPass.Padding = new System.Windows.Forms.Padding(10);
            this.iconBtnPass.Size = new System.Drawing.Size(438, 93);
            this.iconBtnPass.TabIndex = 37;
            this.iconBtnPass.Text = "База данных";
            this.iconBtnPass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconBtnPass.UseVisualStyleBackColor = false;
            // 
            // iconBtnUpdate
            // 
            this.iconBtnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.iconBtnUpdate.FlatAppearance.BorderSize = 0;
            this.iconBtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnUpdate.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconBtnUpdate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconBtnUpdate.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.iconBtnUpdate.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconBtnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnUpdate.IconSize = 40;
            this.iconBtnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnUpdate.Location = new System.Drawing.Point(126, 460);
            this.iconBtnUpdate.Name = "iconBtnUpdate";
            this.iconBtnUpdate.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.iconBtnUpdate.Size = new System.Drawing.Size(313, 44);
            this.iconBtnUpdate.TabIndex = 35;
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
            this.iconBtnDelete.IconChar = FontAwesome.Sharp.IconChar.UserAltSlash;
            this.iconBtnDelete.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconBtnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnDelete.IconSize = 40;
            this.iconBtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnDelete.Location = new System.Drawing.Point(126, 509);
            this.iconBtnDelete.Name = "iconBtnDelete";
            this.iconBtnDelete.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.iconBtnDelete.Size = new System.Drawing.Size(313, 44);
            this.iconBtnDelete.TabIndex = 36;
            this.iconBtnDelete.Text = "Удалить";
            this.iconBtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnDelete.UseVisualStyleBackColor = false;
            this.iconBtnDelete.Click += new System.EventHandler(this.iconBtnDelete_Click);
            // 
            // dgvMenager
            // 
            this.dgvMenager.AllowUserToAddRows = false;
            this.dgvMenager.AutoGenerateColumns = false;
            this.dgvMenager.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.dgvMenager.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMenager.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMenager.ColumnHeadersHeight = 20;
            this.dgvMenager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMenager.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.должностьDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn,
            this.почтаDataGridViewTextBoxColumn,
            this.парольDataGridViewTextBoxColumn,
            this.датаВходаDataGridViewTextBoxColumn,
            this.датаСбросаПароляDataGridViewTextBoxColumn,
            this.датаБлокировкаПользователяDataGridViewTextBoxColumn,
            this.активностьDataGridViewCheckBoxColumn});
            this.dgvMenager.DataSource = this.менеджерПоПродажамBindingSource;
            this.dgvMenager.EnableHeadersVisualStyles = false;
            this.dgvMenager.GridColor = System.Drawing.Color.Black;
            this.dgvMenager.Location = new System.Drawing.Point(3, 3);
            this.dgvMenager.Name = "dgvMenager";
            this.dgvMenager.ReadOnly = true;
            this.dgvMenager.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgvMenager.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMenager.Size = new System.Drawing.Size(880, 451);
            this.dgvMenager.TabIndex = 34;
            this.dgvMenager.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenager_CellClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 25;
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            this.фамилияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            this.имяDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "отчество";
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            this.отчествоDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // должностьDataGridViewTextBoxColumn
            // 
            this.должностьDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.должностьDataGridViewTextBoxColumn.DataPropertyName = "должность";
            this.должностьDataGridViewTextBoxColumn.HeaderText = "должность";
            this.должностьDataGridViewTextBoxColumn.Name = "должностьDataGridViewTextBoxColumn";
            this.должностьDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "телефон";
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            this.телефонDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // почтаDataGridViewTextBoxColumn
            // 
            this.почтаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.почтаDataGridViewTextBoxColumn.DataPropertyName = "почта";
            this.почтаDataGridViewTextBoxColumn.HeaderText = "почта";
            this.почтаDataGridViewTextBoxColumn.Name = "почтаDataGridViewTextBoxColumn";
            this.почтаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // парольDataGridViewTextBoxColumn
            // 
            this.парольDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.парольDataGridViewTextBoxColumn.DataPropertyName = "пароль";
            this.парольDataGridViewTextBoxColumn.HeaderText = "пароль";
            this.парольDataGridViewTextBoxColumn.Name = "парольDataGridViewTextBoxColumn";
            this.парольDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаВходаDataGridViewTextBoxColumn
            // 
            this.датаВходаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.датаВходаDataGridViewTextBoxColumn.DataPropertyName = "дата входа";
            this.датаВходаDataGridViewTextBoxColumn.HeaderText = "дата входа";
            this.датаВходаDataGridViewTextBoxColumn.Name = "датаВходаDataGridViewTextBoxColumn";
            this.датаВходаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаСбросаПароляDataGridViewTextBoxColumn
            // 
            this.датаСбросаПароляDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.датаСбросаПароляDataGridViewTextBoxColumn.DataPropertyName = "дата сброса пароля";
            this.датаСбросаПароляDataGridViewTextBoxColumn.HeaderText = "дата сброса пароля";
            this.датаСбросаПароляDataGridViewTextBoxColumn.Name = "датаСбросаПароляDataGridViewTextBoxColumn";
            this.датаСбросаПароляDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаБлокировкаПользователяDataGridViewTextBoxColumn
            // 
            this.датаБлокировкаПользователяDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.датаБлокировкаПользователяDataGridViewTextBoxColumn.DataPropertyName = "дата блокировка пользователя";
            this.датаБлокировкаПользователяDataGridViewTextBoxColumn.HeaderText = "дата блокировка пользователя";
            this.датаБлокировкаПользователяDataGridViewTextBoxColumn.Name = "датаБлокировкаПользователяDataGridViewTextBoxColumn";
            this.датаБлокировкаПользователяDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // активностьDataGridViewCheckBoxColumn
            // 
            this.активностьDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.активностьDataGridViewCheckBoxColumn.DataPropertyName = "активность";
            this.активностьDataGridViewCheckBoxColumn.HeaderText = "активность";
            this.активностьDataGridViewCheckBoxColumn.Name = "активностьDataGridViewCheckBoxColumn";
            this.активностьDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // менеджерПоПродажамBindingSource
            // 
            this.менеджерПоПродажамBindingSource.DataMember = "Менеджер по продажам";
            this.менеджерПоПродажамBindingSource.DataSource = this.dbSHPmenager;
            // 
            // dbSHPmenager
            // 
            this.dbSHPmenager.DataSetName = "dbSHPmenager";
            this.dbSHPmenager.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelClient
            // 
            this.panelClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.panelClient.Controls.Add(this.panel3);
            this.panelClient.Controls.Add(this.panel2);
            this.panelClient.Controls.Add(this.panel1);
            this.panelClient.Controls.Add(this.iconBtnAdd);
            this.panelClient.Controls.Add(this.label1);
            this.panelClient.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelClient.Location = new System.Drawing.Point(889, 0);
            this.panelClient.Name = "panelClient";
            this.panelClient.Size = new System.Drawing.Size(411, 565);
            this.panelClient.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.panel3.Controls.Add(this.mtxtnum);
            this.panel3.Controls.Add(this.txtmail);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(18, 263);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(377, 72);
            this.panel3.TabIndex = 34;
            // 
            // mtxtnum
            // 
            this.mtxtnum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.mtxtnum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtnum.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mtxtnum.Location = new System.Drawing.Point(120, 10);
            this.mtxtnum.Mask = "+0-000-000-0000";
            this.mtxtnum.Name = "mtxtnum";
            this.mtxtnum.Size = new System.Drawing.Size(96, 20);
            this.mtxtnum.TabIndex = 33;
            // 
            // txtmail
            // 
            this.txtmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.txtmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtmail.Location = new System.Drawing.Point(120, 36);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(240, 20);
            this.txtmail.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(42, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 19);
            this.label7.TabIndex = 22;
            this.label7.Text = "почта :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(24, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "телефон :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cmbshpclass);
            this.panel2.Location = new System.Drawing.Point(18, 210);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(377, 47);
            this.panel2.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(32, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 19);
            this.label5.TabIndex = 34;
            this.label5.Text = "должность :";
            // 
            // cmbshpclass
            // 
            this.cmbshpclass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.cmbshpclass.DisplayMember = "ID";
            this.cmbshpclass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbshpclass.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbshpclass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmbshpclass.FormattingEnabled = true;
            this.cmbshpclass.Location = new System.Drawing.Point(146, 12);
            this.cmbshpclass.Name = "cmbshpclass";
            this.cmbshpclass.Size = new System.Drawing.Size(214, 22);
            this.cmbshpclass.TabIndex = 36;
            this.cmbshpclass.ValueMember = "ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.txtOtch);
            this.panel1.Controls.Add(this.txtFm);
            this.panel1.Controls.Add(this.txtIm);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(18, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 93);
            this.panel1.TabIndex = 22;
            // 
            // txtOtch
            // 
            this.txtOtch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.txtOtch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOtch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtOtch.Location = new System.Drawing.Point(146, 61);
            this.txtOtch.Name = "txtOtch";
            this.txtOtch.Size = new System.Drawing.Size(214, 20);
            this.txtOtch.TabIndex = 12;
            // 
            // txtFm
            // 
            this.txtFm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.txtFm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtFm.Location = new System.Drawing.Point(146, 9);
            this.txtFm.Name = "txtFm";
            this.txtFm.Size = new System.Drawing.Size(214, 20);
            this.txtFm.TabIndex = 10;
            // 
            // txtIm
            // 
            this.txtIm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.txtIm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtIm.Location = new System.Drawing.Point(146, 35);
            this.txtIm.Name = "txtIm";
            this.txtIm.Size = new System.Drawing.Size(214, 20);
            this.txtIm.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(50, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "фамилия :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(86, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "имя :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(41, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "отчество :";
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
            this.iconBtnAdd.Location = new System.Drawing.Point(18, 341);
            this.iconBtnAdd.Name = "iconBtnAdd";
            this.iconBtnAdd.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.iconBtnAdd.Size = new System.Drawing.Size(377, 62);
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
            this.label1.Location = new System.Drawing.Point(91, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Менеджер";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTime.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTime.Location = new System.Drawing.Point(1168, 525);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(120, 31);
            this.lblTime.TabIndex = 12;
            this.lblTime.Text = "00:00:00";
            // 
            // менеджер_по_продажамTableAdapter
            // 
            this.менеджер_по_продажамTableAdapter.ClearBeforeFill = true;
            // 
            // FormMenager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1300, 565);
            this.Controls.Add(this.panelDesktop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenager";
            this.Text = "Менеджер";
            this.Load += new System.EventHandler(this.FormMenager_Load);
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.менеджерПоПродажамBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSHPmenager)).EndInit();
            this.panelClient.ResumeLayout(false);
            this.panelClient.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Panel panelClient;
        private FontAwesome.Sharp.IconButton iconBtnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMenager;
        private FontAwesome.Sharp.IconButton iconBtnPass;
        private FontAwesome.Sharp.IconButton iconBtnUpdate;
        private FontAwesome.Sharp.IconButton iconBtnDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtOtch;
        private System.Windows.Forms.TextBox txtFm;
        private System.Windows.Forms.TextBox txtIm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MaskedTextBox mtxtnum;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbshpclass;
        private dbSHPmenager dbSHPmenager;
        private System.Windows.Forms.BindingSource менеджерПоПродажамBindingSource;
        private dbSHPmenagerTableAdapters.Менеджер_по_продажамTableAdapter менеджер_по_продажамTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn почтаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn парольDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаВходаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаСбросаПароляDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаБлокировкаПользователяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn активностьDataGridViewCheckBoxColumn;
    }
}