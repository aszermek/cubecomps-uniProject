namespace projektfeladat_z7kfuz
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxRegion = new System.Windows.Forms.ComboBox();
            this.filterCompetitions = new System.Windows.Forms.TextBox();
            this.listBoxCompetitions = new System.Windows.Forms.ListBox();
            this.dgwCompetitors = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompetitorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WcaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnNew = new System.Windows.Forms.Button();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxVenue = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.picMultibld = new System.Windows.Forms.PictureBox();
            this.pic555bld = new System.Windows.Forms.PictureBox();
            this.pic444bld = new System.Windows.Forms.PictureBox();
            this.picSq1 = new System.Windows.Forms.PictureBox();
            this.picSkewb = new System.Windows.Forms.PictureBox();
            this.picPyra = new System.Windows.Forms.PictureBox();
            this.picMega = new System.Windows.Forms.PictureBox();
            this.picClock = new System.Windows.Forms.PictureBox();
            this.pic333feet = new System.Windows.Forms.PictureBox();
            this.pic333oh = new System.Windows.Forms.PictureBox();
            this.pic333fmc = new System.Windows.Forms.PictureBox();
            this.pic333bld = new System.Windows.Forms.PictureBox();
            this.pic777 = new System.Windows.Forms.PictureBox();
            this.pic666 = new System.Windows.Forms.PictureBox();
            this.pic555 = new System.Windows.Forms.PictureBox();
            this.pic444 = new System.Windows.Forms.PictureBox();
            this.pic333 = new System.Windows.Forms.PictureBox();
            this.pic222 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCompetitors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMultibld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic555bld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic444bld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSq1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSkewb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPyra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMega)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic333feet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic333oh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic333fmc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic333bld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic777)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic666)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic555)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic444)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic333)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic222)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Régió:";
            // 
            // comboBoxRegion
            // 
            this.comboBoxRegion.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxRegion.FormattingEnabled = true;
            this.comboBoxRegion.Location = new System.Drawing.Point(63, 10);
            this.comboBoxRegion.Name = "comboBoxRegion";
            this.comboBoxRegion.Size = new System.Drawing.Size(124, 21);
            this.comboBoxRegion.TabIndex = 1;
            this.comboBoxRegion.Text = "(összes)";
            this.comboBoxRegion.DropDown += new System.EventHandler(this.comboBoxRegion_DropDown);
            this.comboBoxRegion.SelectedIndexChanged += new System.EventHandler(this.comboBoxRegion_SelectedIndexChanged);
            // 
            // filterCompetitions
            // 
            this.filterCompetitions.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.filterCompetitions.Location = new System.Drawing.Point(12, 42);
            this.filterCompetitions.Name = "filterCompetitions";
            this.filterCompetitions.Size = new System.Drawing.Size(175, 22);
            this.filterCompetitions.TabIndex = 2;
            this.filterCompetitions.TextChanged += new System.EventHandler(this.filterCompetitions_TextChanged);
            // 
            // listBoxCompetitions
            // 
            this.listBoxCompetitions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxCompetitions.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxCompetitions.FormattingEnabled = true;
            this.listBoxCompetitions.ItemHeight = 15;
            this.listBoxCompetitions.Location = new System.Drawing.Point(12, 76);
            this.listBoxCompetitions.Name = "listBoxCompetitions";
            this.listBoxCompetitions.Size = new System.Drawing.Size(175, 514);
            this.listBoxCompetitions.TabIndex = 3;
            this.listBoxCompetitions.SelectedIndexChanged += new System.EventHandler(this.listBoxCompetitions_SelectedIndexChanged);
            // 
            // dgwCompetitors
            // 
            this.dgwCompetitors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwCompetitors.AutoGenerateColumns = false;
            this.dgwCompetitors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCompetitors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CompetitorName,
            this.WcaId,
            this.Country,
            this.BirthDate});
            this.dgwCompetitors.DataSource = this.bindingSource1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwCompetitors.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgwCompetitors.Location = new System.Drawing.Point(196, 128);
            this.dgwCompetitors.Name = "dgwCompetitors";
            this.dgwCompetitors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwCompetitors.Size = new System.Drawing.Size(502, 458);
            this.dgwCompetitors.TabIndex = 4;
            this.dgwCompetitors.SelectionChanged += new System.EventHandler(this.dgwCompetitors_SelectionChanged);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // CompetitorName
            // 
            this.CompetitorName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CompetitorName.DataPropertyName = "CompetitorName";
            this.CompetitorName.HeaderText = "Név";
            this.CompetitorName.Name = "CompetitorName";
            this.CompetitorName.Width = 51;
            // 
            // WcaId
            // 
            this.WcaId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.WcaId.DataPropertyName = "WcaId";
            this.WcaId.HeaderText = "WCA ID";
            this.WcaId.Name = "WcaId";
            this.WcaId.Width = 71;
            // 
            // Country
            // 
            this.Country.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Country.DataPropertyName = "Country";
            this.Country.HeaderText = "Ország";
            this.Country.Name = "Country";
            this.Country.Width = 68;
            // 
            // BirthDate
            // 
            this.BirthDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BirthDate.DataPropertyName = "BirthDate";
            this.BirthDate.HeaderText = "Születési idő";
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Width = 97;
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNew.Location = new System.Drawing.Point(710, 554);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(102, 32);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "Új versenyző";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCountry.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxCountry.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxCountry.Location = new System.Drawing.Point(482, 41);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.ReadOnly = true;
            this.textBoxCountry.Size = new System.Drawing.Size(330, 23);
            this.textBoxCountry.TabIndex = 7;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxCity.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxCity.Location = new System.Drawing.Point(482, 70);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.ReadOnly = true;
            this.textBoxCity.Size = new System.Drawing.Size(330, 23);
            this.textBoxCity.TabIndex = 9;
            // 
            // textBoxVenue
            // 
            this.textBoxVenue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxVenue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxVenue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxVenue.Location = new System.Drawing.Point(482, 99);
            this.textBoxVenue.Name = "textBoxVenue";
            this.textBoxVenue.ReadOnly = true;
            this.textBoxVenue.Size = new System.Drawing.Size(330, 23);
            this.textBoxVenue.TabIndex = 10;
            // 
            // picMultibld
            // 
            this.picMultibld.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMultibld.Image = global::projektfeladat_z7kfuz.Properties.Resources.multibld;
            this.picMultibld.Location = new System.Drawing.Point(782, 329);
            this.picMultibld.Margin = new System.Windows.Forms.Padding(0);
            this.picMultibld.MaximumSize = new System.Drawing.Size(50, 50);
            this.picMultibld.MinimumSize = new System.Drawing.Size(30, 30);
            this.picMultibld.Name = "picMultibld";
            this.picMultibld.Size = new System.Drawing.Size(30, 30);
            this.picMultibld.TabIndex = 33;
            this.picMultibld.TabStop = false;
            this.toolTip1.SetToolTip(this.picMultibld, "3x3x3 több kocka vakon");
            // 
            // pic555bld
            // 
            this.pic555bld.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic555bld.Image = global::projektfeladat_z7kfuz.Properties.Resources._555bld;
            this.pic555bld.Location = new System.Drawing.Point(746, 329);
            this.pic555bld.Margin = new System.Windows.Forms.Padding(0);
            this.pic555bld.MaximumSize = new System.Drawing.Size(50, 50);
            this.pic555bld.MinimumSize = new System.Drawing.Size(30, 30);
            this.pic555bld.Name = "pic555bld";
            this.pic555bld.Size = new System.Drawing.Size(30, 30);
            this.pic555bld.TabIndex = 32;
            this.pic555bld.TabStop = false;
            this.toolTip1.SetToolTip(this.pic555bld, "5x5x5 vakon");
            // 
            // pic444bld
            // 
            this.pic444bld.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic444bld.Image = global::projektfeladat_z7kfuz.Properties.Resources._444bld;
            this.pic444bld.Location = new System.Drawing.Point(710, 329);
            this.pic444bld.Margin = new System.Windows.Forms.Padding(0);
            this.pic444bld.MaximumSize = new System.Drawing.Size(50, 50);
            this.pic444bld.MinimumSize = new System.Drawing.Size(30, 30);
            this.pic444bld.Name = "pic444bld";
            this.pic444bld.Size = new System.Drawing.Size(30, 30);
            this.pic444bld.TabIndex = 31;
            this.pic444bld.TabStop = false;
            this.toolTip1.SetToolTip(this.pic444bld, "4x4x4 vakon");
            // 
            // picSq1
            // 
            this.picSq1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picSq1.Image = global::projektfeladat_z7kfuz.Properties.Resources.sq1;
            this.picSq1.Location = new System.Drawing.Point(782, 293);
            this.picSq1.Margin = new System.Windows.Forms.Padding(0);
            this.picSq1.MaximumSize = new System.Drawing.Size(50, 50);
            this.picSq1.MinimumSize = new System.Drawing.Size(30, 30);
            this.picSq1.Name = "picSq1";
            this.picSq1.Size = new System.Drawing.Size(30, 30);
            this.picSq1.TabIndex = 30;
            this.picSq1.TabStop = false;
            this.toolTip1.SetToolTip(this.picSq1, "Square-1");
            // 
            // picSkewb
            // 
            this.picSkewb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picSkewb.Image = global::projektfeladat_z7kfuz.Properties.Resources.skewb;
            this.picSkewb.Location = new System.Drawing.Point(746, 293);
            this.picSkewb.Margin = new System.Windows.Forms.Padding(0);
            this.picSkewb.MaximumSize = new System.Drawing.Size(50, 50);
            this.picSkewb.MinimumSize = new System.Drawing.Size(30, 30);
            this.picSkewb.Name = "picSkewb";
            this.picSkewb.Size = new System.Drawing.Size(30, 30);
            this.picSkewb.TabIndex = 29;
            this.picSkewb.TabStop = false;
            this.toolTip1.SetToolTip(this.picSkewb, "Skewb");
            // 
            // picPyra
            // 
            this.picPyra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picPyra.Image = global::projektfeladat_z7kfuz.Properties.Resources.pyra;
            this.picPyra.Location = new System.Drawing.Point(710, 293);
            this.picPyra.Margin = new System.Windows.Forms.Padding(0);
            this.picPyra.MaximumSize = new System.Drawing.Size(50, 50);
            this.picPyra.MinimumSize = new System.Drawing.Size(30, 30);
            this.picPyra.Name = "picPyra";
            this.picPyra.Size = new System.Drawing.Size(30, 30);
            this.picPyra.TabIndex = 28;
            this.picPyra.TabStop = false;
            this.toolTip1.SetToolTip(this.picPyra, "Pyraminx");
            // 
            // picMega
            // 
            this.picMega.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMega.Image = global::projektfeladat_z7kfuz.Properties.Resources.mega;
            this.picMega.Location = new System.Drawing.Point(782, 257);
            this.picMega.Margin = new System.Windows.Forms.Padding(0);
            this.picMega.MaximumSize = new System.Drawing.Size(50, 50);
            this.picMega.MinimumSize = new System.Drawing.Size(30, 30);
            this.picMega.Name = "picMega";
            this.picMega.Size = new System.Drawing.Size(30, 30);
            this.picMega.TabIndex = 27;
            this.picMega.TabStop = false;
            this.toolTip1.SetToolTip(this.picMega, "Megaminx");
            // 
            // picClock
            // 
            this.picClock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClock.Image = global::projektfeladat_z7kfuz.Properties.Resources.clock;
            this.picClock.Location = new System.Drawing.Point(746, 257);
            this.picClock.Margin = new System.Windows.Forms.Padding(0);
            this.picClock.MaximumSize = new System.Drawing.Size(50, 50);
            this.picClock.MinimumSize = new System.Drawing.Size(30, 30);
            this.picClock.Name = "picClock";
            this.picClock.Size = new System.Drawing.Size(30, 30);
            this.picClock.TabIndex = 26;
            this.picClock.TabStop = false;
            this.toolTip1.SetToolTip(this.picClock, "Clock");
            // 
            // pic333feet
            // 
            this.pic333feet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic333feet.Image = global::projektfeladat_z7kfuz.Properties.Resources._333feet;
            this.pic333feet.Location = new System.Drawing.Point(710, 257);
            this.pic333feet.Margin = new System.Windows.Forms.Padding(0);
            this.pic333feet.MaximumSize = new System.Drawing.Size(50, 50);
            this.pic333feet.MinimumSize = new System.Drawing.Size(30, 30);
            this.pic333feet.Name = "pic333feet";
            this.pic333feet.Size = new System.Drawing.Size(30, 30);
            this.pic333feet.TabIndex = 25;
            this.pic333feet.TabStop = false;
            this.toolTip1.SetToolTip(this.pic333feet, "3x3x3 lábbal");
            // 
            // pic333oh
            // 
            this.pic333oh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic333oh.Image = global::projektfeladat_z7kfuz.Properties.Resources._333oh;
            this.pic333oh.Location = new System.Drawing.Point(782, 221);
            this.pic333oh.Margin = new System.Windows.Forms.Padding(0);
            this.pic333oh.MaximumSize = new System.Drawing.Size(50, 50);
            this.pic333oh.MinimumSize = new System.Drawing.Size(30, 30);
            this.pic333oh.Name = "pic333oh";
            this.pic333oh.Size = new System.Drawing.Size(30, 30);
            this.pic333oh.TabIndex = 24;
            this.pic333oh.TabStop = false;
            this.toolTip1.SetToolTip(this.pic333oh, "3x3x3 egy kézzel");
            // 
            // pic333fmc
            // 
            this.pic333fmc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic333fmc.Image = global::projektfeladat_z7kfuz.Properties.Resources._333fmc;
            this.pic333fmc.Location = new System.Drawing.Point(746, 221);
            this.pic333fmc.Margin = new System.Windows.Forms.Padding(0);
            this.pic333fmc.MaximumSize = new System.Drawing.Size(50, 50);
            this.pic333fmc.MinimumSize = new System.Drawing.Size(30, 30);
            this.pic333fmc.Name = "pic333fmc";
            this.pic333fmc.Size = new System.Drawing.Size(30, 30);
            this.pic333fmc.TabIndex = 23;
            this.pic333fmc.TabStop = false;
            this.toolTip1.SetToolTip(this.pic333fmc, "FMC");
            // 
            // pic333bld
            // 
            this.pic333bld.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic333bld.Image = global::projektfeladat_z7kfuz.Properties.Resources._333bld;
            this.pic333bld.Location = new System.Drawing.Point(710, 221);
            this.pic333bld.Margin = new System.Windows.Forms.Padding(0);
            this.pic333bld.MaximumSize = new System.Drawing.Size(50, 50);
            this.pic333bld.MinimumSize = new System.Drawing.Size(30, 30);
            this.pic333bld.Name = "pic333bld";
            this.pic333bld.Size = new System.Drawing.Size(30, 30);
            this.pic333bld.TabIndex = 22;
            this.pic333bld.TabStop = false;
            this.toolTip1.SetToolTip(this.pic333bld, "3x3x3 vakon");
            // 
            // pic777
            // 
            this.pic777.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic777.Image = global::projektfeladat_z7kfuz.Properties.Resources._777;
            this.pic777.Location = new System.Drawing.Point(782, 185);
            this.pic777.Margin = new System.Windows.Forms.Padding(0);
            this.pic777.MaximumSize = new System.Drawing.Size(50, 50);
            this.pic777.MinimumSize = new System.Drawing.Size(30, 30);
            this.pic777.Name = "pic777";
            this.pic777.Size = new System.Drawing.Size(30, 30);
            this.pic777.TabIndex = 21;
            this.pic777.TabStop = false;
            this.toolTip1.SetToolTip(this.pic777, "7x7x7");
            // 
            // pic666
            // 
            this.pic666.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic666.Image = global::projektfeladat_z7kfuz.Properties.Resources._666;
            this.pic666.Location = new System.Drawing.Point(746, 185);
            this.pic666.Margin = new System.Windows.Forms.Padding(0);
            this.pic666.MaximumSize = new System.Drawing.Size(50, 50);
            this.pic666.MinimumSize = new System.Drawing.Size(30, 30);
            this.pic666.Name = "pic666";
            this.pic666.Size = new System.Drawing.Size(30, 30);
            this.pic666.TabIndex = 20;
            this.pic666.TabStop = false;
            this.toolTip1.SetToolTip(this.pic666, "6x6x6");
            // 
            // pic555
            // 
            this.pic555.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic555.Image = global::projektfeladat_z7kfuz.Properties.Resources._555;
            this.pic555.Location = new System.Drawing.Point(710, 185);
            this.pic555.Margin = new System.Windows.Forms.Padding(0);
            this.pic555.MaximumSize = new System.Drawing.Size(50, 50);
            this.pic555.MinimumSize = new System.Drawing.Size(30, 30);
            this.pic555.Name = "pic555";
            this.pic555.Size = new System.Drawing.Size(30, 30);
            this.pic555.TabIndex = 19;
            this.pic555.TabStop = false;
            this.toolTip1.SetToolTip(this.pic555, "5x5x5");
            // 
            // pic444
            // 
            this.pic444.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic444.Image = global::projektfeladat_z7kfuz.Properties.Resources._444;
            this.pic444.Location = new System.Drawing.Point(782, 149);
            this.pic444.Margin = new System.Windows.Forms.Padding(0);
            this.pic444.MaximumSize = new System.Drawing.Size(50, 50);
            this.pic444.MinimumSize = new System.Drawing.Size(30, 30);
            this.pic444.Name = "pic444";
            this.pic444.Size = new System.Drawing.Size(30, 30);
            this.pic444.TabIndex = 18;
            this.pic444.TabStop = false;
            this.toolTip1.SetToolTip(this.pic444, "4x4x4");
            // 
            // pic333
            // 
            this.pic333.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic333.Image = global::projektfeladat_z7kfuz.Properties.Resources._333;
            this.pic333.Location = new System.Drawing.Point(746, 149);
            this.pic333.Margin = new System.Windows.Forms.Padding(0);
            this.pic333.MaximumSize = new System.Drawing.Size(50, 50);
            this.pic333.MinimumSize = new System.Drawing.Size(30, 30);
            this.pic333.Name = "pic333";
            this.pic333.Size = new System.Drawing.Size(30, 30);
            this.pic333.TabIndex = 17;
            this.pic333.TabStop = false;
            this.toolTip1.SetToolTip(this.pic333, "3x3x3");
            // 
            // pic222
            // 
            this.pic222.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic222.Image = global::projektfeladat_z7kfuz.Properties.Resources._222;
            this.pic222.Location = new System.Drawing.Point(710, 149);
            this.pic222.Margin = new System.Windows.Forms.Padding(0);
            this.pic222.Name = "pic222";
            this.pic222.Size = new System.Drawing.Size(30, 30);
            this.pic222.TabIndex = 16;
            this.pic222.TabStop = false;
            this.toolTip1.SetToolTip(this.pic222, "2x2x2");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(196, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "World Cube Association");
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(423, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ország:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(431, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Város:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(418, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Helyszín:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(711, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Versenyszámok:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(418, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "Időpont:";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxDate.Location = new System.Drawing.Point(482, 12);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.ReadOnly = true;
            this.textBoxDate.Size = new System.Drawing.Size(330, 23);
            this.textBoxDate.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 602);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.picMultibld);
            this.Controls.Add(this.pic555bld);
            this.Controls.Add(this.pic444bld);
            this.Controls.Add(this.picSq1);
            this.Controls.Add(this.picSkewb);
            this.Controls.Add(this.picPyra);
            this.Controls.Add(this.picMega);
            this.Controls.Add(this.picClock);
            this.Controls.Add(this.pic333feet);
            this.Controls.Add(this.pic333oh);
            this.Controls.Add(this.pic333fmc);
            this.Controls.Add(this.pic333bld);
            this.Controls.Add(this.pic777);
            this.Controls.Add(this.pic666);
            this.Controls.Add(this.pic555);
            this.Controls.Add(this.pic444);
            this.Controls.Add(this.pic333);
            this.Controls.Add(this.pic222);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxVenue);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxCountry);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dgwCompetitors);
            this.Controls.Add(this.listBoxCompetitions);
            this.Controls.Add(this.filterCompetitions);
            this.Controls.Add(this.comboBoxRegion);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MinimumSize = new System.Drawing.Size(745, 450);
            this.Name = "Form1";
            this.Text = "Hivatalos WCA Rubik kocka versenyek, 2019. nyár";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCompetitors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMultibld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic555bld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic444bld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSq1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSkewb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPyra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMega)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic333feet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic333oh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic333fmc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic333bld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic777)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic666)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic555)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic444)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic333)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic222)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxRegion;
        private System.Windows.Forms.TextBox filterCompetitions;
        private System.Windows.Forms.ListBox listBoxCompetitions;
        private System.Windows.Forms.DataGridView dgwCompetitors;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxVenue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.PictureBox pic222;
        private System.Windows.Forms.PictureBox pic333;
        private System.Windows.Forms.PictureBox pic555;
        private System.Windows.Forms.PictureBox pic444;
        private System.Windows.Forms.PictureBox pic333fmc;
        private System.Windows.Forms.PictureBox pic333bld;
        private System.Windows.Forms.PictureBox pic777;
        private System.Windows.Forms.PictureBox pic666;
        private System.Windows.Forms.PictureBox pic444bld;
        private System.Windows.Forms.PictureBox picSq1;
        private System.Windows.Forms.PictureBox picSkewb;
        private System.Windows.Forms.PictureBox picPyra;
        private System.Windows.Forms.PictureBox picMega;
        private System.Windows.Forms.PictureBox picClock;
        private System.Windows.Forms.PictureBox pic333feet;
        private System.Windows.Forms.PictureBox pic333oh;
        private System.Windows.Forms.PictureBox picMultibld;
        private System.Windows.Forms.PictureBox pic555bld;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompetitorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn WcaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDate;
    }
}

