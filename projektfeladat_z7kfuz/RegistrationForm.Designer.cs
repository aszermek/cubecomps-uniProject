namespace projektfeladat_z7kfuz
{
    partial class RegistrationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxWCAID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.birthdateAlert = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.cb222 = new System.Windows.Forms.CheckBox();
            this.cb333 = new System.Windows.Forms.CheckBox();
            this.cb444 = new System.Windows.Forms.CheckBox();
            this.cb555 = new System.Windows.Forms.CheckBox();
            this.cb666 = new System.Windows.Forms.CheckBox();
            this.cb777 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb333bld = new System.Windows.Forms.CheckBox();
            this.cb333fmc = new System.Windows.Forms.CheckBox();
            this.cb333oh = new System.Windows.Forms.CheckBox();
            this.cbMultibld = new System.Windows.Forms.CheckBox();
            this.cb555bld = new System.Windows.Forms.CheckBox();
            this.cb444bld = new System.Windows.Forms.CheckBox();
            this.cbSq1 = new System.Windows.Forms.CheckBox();
            this.cbSkewb = new System.Windows.Forms.CheckBox();
            this.cbPyra = new System.Windows.Forms.CheckBox();
            this.cbMega = new System.Windows.Forms.CheckBox();
            this.cbClock = new System.Windows.Forms.CheckBox();
            this.cb333feet = new System.Windows.Forms.CheckBox();
            this.helpWcaId = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név:";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxName.Location = new System.Drawing.Point(117, 9);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(182, 23);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            this.textBoxName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxName_Validating);
            // 
            // textBoxWCAID
            // 
            this.textBoxWCAID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWCAID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxWCAID.Location = new System.Drawing.Point(117, 38);
            this.textBoxWCAID.Name = "textBoxWCAID";
            this.textBoxWCAID.Size = new System.Drawing.Size(182, 23);
            this.textBoxWCAID.TabIndex = 3;
            this.textBoxWCAID.TextChanged += new System.EventHandler(this.textBoxWCAID_TextChanged);
            this.textBoxWCAID.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxWCAID_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "WCA ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(13, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ország:";
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxCountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxCountry.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Items.AddRange(new object[] {
            "Afganisztán",
            "Albánia",
            "Algéria",
            "Amerikai Egyesült Államok",
            "Andorra",
            "Angola",
            "Antigua és Barbuda",
            "Argentína",
            "Ausztrália",
            "Ausztria",
            "Azerbajdzsán",
            "Bahama-szigetek",
            "Bahrein",
            "Banglades",
            "Barbados",
            "Belgium",
            "Belize",
            "Benin",
            "Bhután",
            "Bolívia",
            "Bosznia-Hercegovina",
            "Botswana",
            "Brazília",
            "Brunei",
            "Bulgária",
            "Burkina Faso",
            "Burundi",
            "Chile",
            "Ciprus",
            "Comore-szigetek",
            "Costa Rica",
            "Csád",
            "Csehország",
            "Dánia",
            "Dél-afrikai Köztársaság",
            "Dél-Korea",
            "Dél-Szudán",
            "Dominika",
            "Dominikai Köztársaság",
            "Dzsibuti",
            "Ecuador",
            "Egyenlítői-Guinea",
            "Egyesült Arab Emirátus",
            "Egyesült Királyság",
            "Egyiptom",
            "Elefántcsontpart",
            "Eritrea",
            "Észak-Korea",
            "Észtország",
            "Etiópia",
            "Fehéroroszország",
            "Fidzsi-szigetek",
            "Finnország",
            "Franciaország",
            "Fülöp-szigetek",
            "Gabon",
            "Gambia",
            "Ghána",
            "Görögország",
            "Grenada",
            "Grúzia",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Hollandia",
            "Honduras",
            "Hongkong",
            "Horvátország",
            "India",
            "Indonézia",
            "Irak",
            "Irán",
            "Írország",
            "Izland",
            "Izrael",
            "Jamaica",
            "Japán",
            "Jemen",
            "Jordánia",
            "Kambodzsa",
            "Kamerun",
            "Kanada",
            "Katar",
            "Kazahsztán",
            "Kelet-Timor",
            "Kenya",
            "Kína",
            "Kirgizisztán",
            "Kiribati",
            "Kolumbia",
            "Kongói Demokratikus Köztársaság",
            "Kongói Köztársaság",
            "Koszovó",
            "Közép-afrikai Köztársaság",
            "Kuba",
            "Kuvait",
            "Laosz",
            "Lengyelország",
            "Lesotho",
            "Lettország",
            "Libanon",
            "Libéria",
            "Líbia",
            "Liechtenstein",
            "Litvánia",
            "Luxemburg",
            "Macedónia",
            "Madagaszkár",
            "Magyarország",
            "Makaó",
            "Malajzia",
            "Malawi",
            "Maldív-szigetek",
            "Mali",
            "Málta",
            "Marokkó",
            "Marshall-szigetek",
            "Mauritánia",
            "Mauritius",
            "Mexikó",
            "Mianmar",
            "Mikronézia",
            "Moldova",
            "Monaco",
            "Mongólia",
            "Montenegrő",
            "Mozambik",
            "Namíbia",
            "Nauru",
            "Németország",
            "Nepál",
            "Nicaragua",
            "Niger",
            "Nigéria",
            "Norvégia",
            "Olaszország",
            "Omán",
            "Oroszország",
            "Örményország",
            "Pakisztán",
            "Palau",
            "Palesztina",
            "Panama",
            "Pápua Új-Guinea",
            "Paraguay",
            "Peru",
            "Portugália",
            "Románia",
            "Ruanda",
            "Saint Kitts és Nevis",
            "Saint Vincent és a Grenadine-szigetek",
            "Salamon-szigetek",
            "Salvador",
            "San Marino",
            "Santa Lucia",
            "Sao Tomé és Príncipe",
            "Seychelle-szigetek",
            "Sierra Leone",
            "Spanyolország",
            "Srí Lanka",
            "Suriname",
            "Svájc",
            "Svédország",
            "Szamoa",
            "Szaúd-Arábia",
            "Szenegál",
            "Szerbia",
            "Szingapúr",
            "Szíria",
            "Szlovákia",
            "Szlovénia",
            "Szomália",
            "Szudán",
            "Szváziföld",
            "Tádzsikisztán",
            "Tajvan",
            "Tanzánia",
            "Thaiföld",
            "Togo",
            "Tonga",
            "Törökország",
            "Trinidad és Tobago",
            "Tunézia",
            "Tuvalu",
            "Türkmenisztán",
            "Uganda",
            "Új-Zéland",
            "Ukrajna",
            "Uruguay",
            "Üzbegisztán",
            "Vanuatu",
            "Vatikán",
            "Venezuela",
            "Vietnam",
            "Zambia",
            "Zimbabwe",
            "Zöld-foki Köztársaság"});
            this.comboBoxCountry.Location = new System.Drawing.Point(117, 67);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(182, 23);
            this.comboBoxCountry.TabIndex = 5;
            this.comboBoxCountry.TextChanged += new System.EventHandler(this.comboBoxCountry_TextChanged);
            this.comboBoxCountry.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxCountry_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(13, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Születési idő:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker.Location = new System.Drawing.Point(117, 96);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(182, 23);
            this.dateTimePicker.TabIndex = 7;
            this.dateTimePicker.UseWaitCursor = true;
            this.dateTimePicker.Value = new System.DateTime(2019, 5, 12, 0, 0, 0, 0);
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged_1);
            // 
            // birthdateAlert
            // 
            this.birthdateAlert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.birthdateAlert.AutoSize = true;
            this.birthdateAlert.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.birthdateAlert.ForeColor = System.Drawing.Color.Indigo;
            this.birthdateAlert.Location = new System.Drawing.Point(137, 122);
            this.birthdateAlert.Name = "birthdateAlert";
            this.birthdateAlert.Size = new System.Drawing.Size(162, 15);
            this.birthdateAlert.TabIndex = 8;
            this.birthdateAlert.Text = "Szülői beleegyezés szükséges!";
            this.birthdateAlert.Visible = false;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOK.Location = new System.Drawing.Point(224, 384);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 29);
            this.buttonOK.TabIndex = 11;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.CausesValidation = false;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCancel.Location = new System.Drawing.Point(143, 384);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 29);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Mégsem";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // cb222
            // 
            this.cb222.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb222.AutoSize = true;
            this.cb222.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb222.Location = new System.Drawing.Point(16, 177);
            this.cb222.Name = "cb222";
            this.cb222.Size = new System.Drawing.Size(54, 17);
            this.cb222.TabIndex = 13;
            this.cb222.Text = "2x2x2";
            this.cb222.UseVisualStyleBackColor = true;
            // 
            // cb333
            // 
            this.cb333.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb333.AutoSize = true;
            this.cb333.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb333.Location = new System.Drawing.Point(16, 200);
            this.cb333.Name = "cb333";
            this.cb333.Size = new System.Drawing.Size(54, 17);
            this.cb333.TabIndex = 14;
            this.cb333.Text = "3x3x3";
            this.cb333.UseVisualStyleBackColor = true;
            // 
            // cb444
            // 
            this.cb444.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb444.AutoSize = true;
            this.cb444.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb444.Location = new System.Drawing.Point(16, 223);
            this.cb444.Name = "cb444";
            this.cb444.Size = new System.Drawing.Size(54, 17);
            this.cb444.TabIndex = 15;
            this.cb444.Text = "4x4x4";
            this.cb444.UseVisualStyleBackColor = true;
            // 
            // cb555
            // 
            this.cb555.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb555.AutoSize = true;
            this.cb555.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb555.Location = new System.Drawing.Point(16, 246);
            this.cb555.Name = "cb555";
            this.cb555.Size = new System.Drawing.Size(54, 17);
            this.cb555.TabIndex = 16;
            this.cb555.Text = "5x5x5";
            this.cb555.UseVisualStyleBackColor = true;
            // 
            // cb666
            // 
            this.cb666.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb666.AutoSize = true;
            this.cb666.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb666.Location = new System.Drawing.Point(16, 269);
            this.cb666.Name = "cb666";
            this.cb666.Size = new System.Drawing.Size(54, 17);
            this.cb666.TabIndex = 17;
            this.cb666.Text = "6x6x6";
            this.cb666.UseVisualStyleBackColor = true;
            // 
            // cb777
            // 
            this.cb777.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb777.AutoSize = true;
            this.cb777.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb777.Location = new System.Drawing.Point(16, 292);
            this.cb777.Name = "cb777";
            this.cb777.Size = new System.Drawing.Size(54, 17);
            this.cb777.TabIndex = 18;
            this.cb777.Text = "7x7x7";
            this.cb777.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(13, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Versenyszámok:";
            // 
            // cb333bld
            // 
            this.cb333bld.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb333bld.AutoSize = true;
            this.cb333bld.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb333bld.Location = new System.Drawing.Point(16, 315);
            this.cb333bld.Name = "cb333bld";
            this.cb333bld.Size = new System.Drawing.Size(88, 17);
            this.cb333bld.TabIndex = 19;
            this.cb333bld.Text = "3x3x3 vakon";
            this.cb333bld.UseVisualStyleBackColor = true;
            // 
            // cb333fmc
            // 
            this.cb333fmc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb333fmc.AutoSize = true;
            this.cb333fmc.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb333fmc.Location = new System.Drawing.Point(16, 338);
            this.cb333fmc.Name = "cb333fmc";
            this.cb333fmc.Size = new System.Drawing.Size(49, 17);
            this.cb333fmc.TabIndex = 20;
            this.cb333fmc.Text = "FMC";
            this.cb333fmc.UseVisualStyleBackColor = true;
            // 
            // cb333oh
            // 
            this.cb333oh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb333oh.AutoSize = true;
            this.cb333oh.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb333oh.Location = new System.Drawing.Point(16, 361);
            this.cb333oh.Name = "cb333oh";
            this.cb333oh.Size = new System.Drawing.Size(109, 17);
            this.cb333oh.TabIndex = 21;
            this.cb333oh.Text = "3x3x3 egy kézzel";
            this.cb333oh.UseVisualStyleBackColor = true;
            // 
            // cbMultibld
            // 
            this.cbMultibld.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbMultibld.AutoSize = true;
            this.cbMultibld.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbMultibld.Location = new System.Drawing.Point(143, 361);
            this.cbMultibld.Name = "cbMultibld";
            this.cbMultibld.Size = new System.Drawing.Size(149, 17);
            this.cbMultibld.TabIndex = 30;
            this.cbMultibld.Text = "3x3x3 több kocka vakon";
            this.cbMultibld.UseVisualStyleBackColor = true;
            // 
            // cb555bld
            // 
            this.cb555bld.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb555bld.AutoSize = true;
            this.cb555bld.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb555bld.Location = new System.Drawing.Point(143, 338);
            this.cb555bld.Name = "cb555bld";
            this.cb555bld.Size = new System.Drawing.Size(88, 17);
            this.cb555bld.TabIndex = 29;
            this.cb555bld.Text = "5x5x5 vakon";
            this.cb555bld.UseVisualStyleBackColor = true;
            // 
            // cb444bld
            // 
            this.cb444bld.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb444bld.AutoSize = true;
            this.cb444bld.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb444bld.Location = new System.Drawing.Point(143, 315);
            this.cb444bld.Name = "cb444bld";
            this.cb444bld.Size = new System.Drawing.Size(88, 17);
            this.cb444bld.TabIndex = 28;
            this.cb444bld.Text = "4x4x4 vakon";
            this.cb444bld.UseVisualStyleBackColor = true;
            // 
            // cbSq1
            // 
            this.cbSq1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbSq1.AutoSize = true;
            this.cbSq1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbSq1.Location = new System.Drawing.Point(143, 292);
            this.cbSq1.Name = "cbSq1";
            this.cbSq1.Size = new System.Drawing.Size(72, 17);
            this.cbSq1.TabIndex = 27;
            this.cbSq1.Text = "Square-1";
            this.cbSq1.UseVisualStyleBackColor = true;
            // 
            // cbSkewb
            // 
            this.cbSkewb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbSkewb.AutoSize = true;
            this.cbSkewb.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbSkewb.Location = new System.Drawing.Point(143, 269);
            this.cbSkewb.Name = "cbSkewb";
            this.cbSkewb.Size = new System.Drawing.Size(60, 17);
            this.cbSkewb.TabIndex = 26;
            this.cbSkewb.Text = "Skewb";
            this.cbSkewb.UseVisualStyleBackColor = true;
            // 
            // cbPyra
            // 
            this.cbPyra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbPyra.AutoSize = true;
            this.cbPyra.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbPyra.Location = new System.Drawing.Point(143, 246);
            this.cbPyra.Name = "cbPyra";
            this.cbPyra.Size = new System.Drawing.Size(71, 17);
            this.cbPyra.TabIndex = 25;
            this.cbPyra.Text = "Pyraminx";
            this.cbPyra.UseVisualStyleBackColor = true;
            // 
            // cbMega
            // 
            this.cbMega.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbMega.AutoSize = true;
            this.cbMega.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbMega.Location = new System.Drawing.Point(143, 223);
            this.cbMega.Name = "cbMega";
            this.cbMega.Size = new System.Drawing.Size(79, 17);
            this.cbMega.TabIndex = 24;
            this.cbMega.Text = "Megaminx";
            this.cbMega.UseVisualStyleBackColor = true;
            // 
            // cbClock
            // 
            this.cbClock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbClock.AutoSize = true;
            this.cbClock.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbClock.Location = new System.Drawing.Point(143, 200);
            this.cbClock.Name = "cbClock";
            this.cbClock.Size = new System.Drawing.Size(54, 17);
            this.cbClock.TabIndex = 23;
            this.cbClock.Text = "Clock";
            this.cbClock.UseVisualStyleBackColor = true;
            // 
            // cb333feet
            // 
            this.cb333feet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb333feet.AutoSize = true;
            this.cb333feet.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb333feet.Location = new System.Drawing.Point(143, 177);
            this.cb333feet.Name = "cb333feet";
            this.cb333feet.Size = new System.Drawing.Size(89, 17);
            this.cb333feet.TabIndex = 22;
            this.cb333feet.Text = "3x3x3 lábbal";
            this.cb333feet.UseVisualStyleBackColor = true;
            // 
            // helpWcaId
            // 
            this.helpWcaId.AutoSize = true;
            this.helpWcaId.BackColor = System.Drawing.Color.Black;
            this.helpWcaId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.helpWcaId.ForeColor = System.Drawing.Color.White;
            this.helpWcaId.Location = new System.Drawing.Point(280, 42);
            this.helpWcaId.Name = "helpWcaId";
            this.helpWcaId.Size = new System.Drawing.Size(12, 15);
            this.helpWcaId.TabIndex = 31;
            this.helpWcaId.Text = "?";
            this.toolTip1.SetToolTip(this.helpWcaId, "Hagyd üresen, ha még nem volt versenyen.\r\nFormátum: 2018KISS03");
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 425);
            this.Controls.Add(this.helpWcaId);
            this.Controls.Add(this.cbMultibld);
            this.Controls.Add(this.cb555bld);
            this.Controls.Add(this.cb444bld);
            this.Controls.Add(this.cbSq1);
            this.Controls.Add(this.cbSkewb);
            this.Controls.Add(this.cbPyra);
            this.Controls.Add(this.cbMega);
            this.Controls.Add(this.cbClock);
            this.Controls.Add(this.cb333feet);
            this.Controls.Add(this.cb333oh);
            this.Controls.Add(this.cb333fmc);
            this.Controls.Add(this.cb333bld);
            this.Controls.Add(this.cb777);
            this.Controls.Add(this.cb666);
            this.Controls.Add(this.cb555);
            this.Controls.Add(this.cb444);
            this.Controls.Add(this.cb333);
            this.Controls.Add(this.cb222);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.birthdateAlert);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxCountry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxWCAID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MinimumSize = new System.Drawing.Size(327, 463);
            this.Name = "RegistrationForm";
            this.Text = "Új versenyző";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label birthdateAlert;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textBoxName;
        public System.Windows.Forms.TextBox textBoxWCAID;
        public System.Windows.Forms.ComboBox comboBoxCountry;
        public System.Windows.Forms.DateTimePicker dateTimePicker;
        public System.Windows.Forms.CheckBox cb222;
        public System.Windows.Forms.CheckBox cb333;
        public System.Windows.Forms.CheckBox cb444;
        public System.Windows.Forms.CheckBox cb555;
        public System.Windows.Forms.CheckBox cb666;
        public System.Windows.Forms.CheckBox cb777;
        public System.Windows.Forms.CheckBox cb333bld;
        public System.Windows.Forms.CheckBox cb333fmc;
        public System.Windows.Forms.CheckBox cb333oh;
        public System.Windows.Forms.CheckBox cbMultibld;
        public System.Windows.Forms.CheckBox cb555bld;
        public System.Windows.Forms.CheckBox cb444bld;
        public System.Windows.Forms.CheckBox cbSq1;
        public System.Windows.Forms.CheckBox cbSkewb;
        public System.Windows.Forms.CheckBox cbPyra;
        public System.Windows.Forms.CheckBox cbMega;
        public System.Windows.Forms.CheckBox cbClock;
        public System.Windows.Forms.CheckBox cb333feet;
        private System.Windows.Forms.Label helpWcaId;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}