namespace Analizator_Funkcji_Fx
{
    partial class Analizator
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.PB_WybierzKolorLiniiWykresu = new System.Windows.Forms.Button();
            this.PB_WybierzKolorTlaWykresu = new System.Windows.Forms.Button();
            this.PB_TabelarycznaWizualizacjaWartosciFx = new System.Windows.Forms.Button();
            this.PB_GraficznaWizualizacjaFx = new System.Windows.Forms.Button();
            this.PB_WybranyKolorLinii = new System.Windows.Forms.TextBox();
            this.PB_wkl = new System.Windows.Forms.Label();
            this.PB_WybranyKolorTla = new System.Windows.Forms.TextBox();
            this.PB_wkt = new System.Windows.Forms.Label();
            this.PB_slw = new System.Windows.Forms.Label();
            this.PB_NazwaFormularza = new System.Windows.Forms.Label();
            this.PB_GruboscLiniiWykresu = new System.Windows.Forms.TrackBar();
            this.PB_glw = new System.Windows.Forms.Label();
            this.PB_OdrecznaDefinicjaGrubosciLinii = new System.Windows.Forms.TextBox();
            this.PB_glwul = new System.Windows.Forms.Label();
            this.PB_WziernikWzorcaLinii = new System.Windows.Forms.TextBox();
            this.PB_wwl = new System.Windows.Forms.Label();
            this.PB_TabelaWartosciFunkcjiFx = new System.Windows.Forms.DataGridView();
            this.PB_Xd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PB_Xg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PB_WartoscZmienejX = new System.Windows.Forms.TextBox();
            this.PB_DolnaGranicaPrzedzialuFD = new System.Windows.Forms.TextBox();
            this.PB_GornaGranicaPrazedzialuFG = new System.Windows.Forms.TextBox();
            this.PB_KrokPrzyrostuHFX = new System.Windows.Forms.TextBox();
            this.PB_wzx = new System.Windows.Forms.Label();
            this.PB_dgpxd = new System.Windows.Forms.Label();
            this.PB_ggpfg = new System.Windows.Forms.Label();
            this.PB_kphx = new System.Windows.Forms.Label();
            this.PB_WykreslLinieUWBezOpisu = new System.Windows.Forms.RadioButton();
            this.PB_WykreslLinieUWZOpisem = new System.Windows.Forms.RadioButton();
            this.PB_WykresPrzebieguFunkcji = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PB_WybranyStylLinii = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.PB_ObliczenieWartosciFunkcjiWPrzedziale = new System.Windows.Forms.Button();
            this.PB_wf_x = new System.Windows.Forms.Label();
            this.PB_Fx_wynik = new System.Windows.Forms.Label();
            this.PB_GrupaWyboruPodpisuWykresu = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_GruboscLiniiWykresu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_TabelaWartosciFunkcjiFx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_WykresPrzebieguFunkcji)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.PB_GrupaWyboruPodpisuWykresu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PB_WybierzKolorLiniiWykresu
            // 
            this.PB_WybierzKolorLiniiWykresu.Location = new System.Drawing.Point(38, 32);
            this.PB_WybierzKolorLiniiWykresu.Name = "PB_WybierzKolorLiniiWykresu";
            this.PB_WybierzKolorLiniiWykresu.Size = new System.Drawing.Size(82, 55);
            this.PB_WybierzKolorLiniiWykresu.TabIndex = 0;
            this.PB_WybierzKolorLiniiWykresu.Text = "Zdefiniuj kolor linii wykresu";
            this.PB_WybierzKolorLiniiWykresu.UseVisualStyleBackColor = true;
            this.PB_WybierzKolorLiniiWykresu.Click += new System.EventHandler(this.PB_WybierzKolorLiniiWykresu_Click);
            // 
            // PB_WybierzKolorTlaWykresu
            // 
            this.PB_WybierzKolorTlaWykresu.Location = new System.Drawing.Point(248, 32);
            this.PB_WybierzKolorTlaWykresu.Name = "PB_WybierzKolorTlaWykresu";
            this.PB_WybierzKolorTlaWykresu.Size = new System.Drawing.Size(86, 55);
            this.PB_WybierzKolorTlaWykresu.TabIndex = 1;
            this.PB_WybierzKolorTlaWykresu.Text = "Wybierz kolor tła wykresu";
            this.PB_WybierzKolorTlaWykresu.UseVisualStyleBackColor = true;
            this.PB_WybierzKolorTlaWykresu.Click += new System.EventHandler(this.PB_WybierzKolorTlaWykresu_Click);
            // 
            // PB_TabelarycznaWizualizacjaWartosciFx
            // 
            this.PB_TabelarycznaWizualizacjaWartosciFx.Location = new System.Drawing.Point(594, 309);
            this.PB_TabelarycznaWizualizacjaWartosciFx.Name = "PB_TabelarycznaWizualizacjaWartosciFx";
            this.PB_TabelarycznaWizualizacjaWartosciFx.Size = new System.Drawing.Size(130, 46);
            this.PB_TabelarycznaWizualizacjaWartosciFx.TabIndex = 3;
            this.PB_TabelarycznaWizualizacjaWartosciFx.Text = "Tabelaryczna wizualizacja F(x)";
            this.PB_TabelarycznaWizualizacjaWartosciFx.UseVisualStyleBackColor = true;
            this.PB_TabelarycznaWizualizacjaWartosciFx.Click += new System.EventHandler(this.PB_TabelarycznaWizualizacjaWartosciFx_Click);
            // 
            // PB_GraficznaWizualizacjaFx
            // 
            this.PB_GraficznaWizualizacjaFx.Location = new System.Drawing.Point(594, 361);
            this.PB_GraficznaWizualizacjaFx.Name = "PB_GraficznaWizualizacjaFx";
            this.PB_GraficznaWizualizacjaFx.Size = new System.Drawing.Size(130, 46);
            this.PB_GraficznaWizualizacjaFx.TabIndex = 4;
            this.PB_GraficznaWizualizacjaFx.Text = "Graficzna wizualizacja (zastosuj zmiany)";
            this.PB_GraficznaWizualizacjaFx.UseVisualStyleBackColor = true;
            this.PB_GraficznaWizualizacjaFx.Click += new System.EventHandler(this.PB_GraficznaWizualizacjaFx_Click);
            // 
            // PB_WybranyKolorLinii
            // 
            this.PB_WybranyKolorLinii.BackColor = System.Drawing.Color.Fuchsia;
            this.PB_WybranyKolorLinii.Enabled = false;
            this.PB_WybranyKolorLinii.Location = new System.Drawing.Point(138, 67);
            this.PB_WybranyKolorLinii.Name = "PB_WybranyKolorLinii";
            this.PB_WybranyKolorLinii.Size = new System.Drawing.Size(89, 20);
            this.PB_WybranyKolorLinii.TabIndex = 6;
            // 
            // PB_wkl
            // 
            this.PB_wkl.Location = new System.Drawing.Point(135, 32);
            this.PB_wkl.Name = "PB_wkl";
            this.PB_wkl.Size = new System.Drawing.Size(92, 30);
            this.PB_wkl.TabIndex = 7;
            this.PB_wkl.Text = "Wybrany kolor linii wykresu";
            this.PB_wkl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PB_WybranyKolorTla
            // 
            this.PB_WybranyKolorTla.BackColor = System.Drawing.Color.Azure;
            this.PB_WybranyKolorTla.Enabled = false;
            this.PB_WybranyKolorTla.Location = new System.Drawing.Point(352, 67);
            this.PB_WybranyKolorTla.Name = "PB_WybranyKolorTla";
            this.PB_WybranyKolorTla.Size = new System.Drawing.Size(88, 20);
            this.PB_WybranyKolorTla.TabIndex = 8;
            // 
            // PB_wkt
            // 
            this.PB_wkt.Location = new System.Drawing.Point(352, 32);
            this.PB_wkt.Name = "PB_wkt";
            this.PB_wkt.Size = new System.Drawing.Size(88, 30);
            this.PB_wkt.TabIndex = 9;
            this.PB_wkt.Text = "Wybrany kolor tła wykresu";
            this.PB_wkt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PB_slw
            // 
            this.PB_slw.Location = new System.Drawing.Point(493, 31);
            this.PB_slw.Name = "PB_slw";
            this.PB_slw.Size = new System.Drawing.Size(78, 30);
            this.PB_slw.TabIndex = 10;
            this.PB_slw.Text = "Styl linii wykresu";
            this.PB_slw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PB_NazwaFormularza
            // 
            this.PB_NazwaFormularza.AutoSize = true;
            this.PB_NazwaFormularza.Font = new System.Drawing.Font("Verdana", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PB_NazwaFormularza.Location = new System.Drawing.Point(293, 9);
            this.PB_NazwaFormularza.Name = "PB_NazwaFormularza";
            this.PB_NazwaFormularza.Size = new System.Drawing.Size(184, 17);
            this.PB_NazwaFormularza.TabIndex = 11;
            this.PB_NazwaFormularza.Text = "Analizator funkcji F(x)";
            // 
            // PB_GruboscLiniiWykresu
            // 
            this.PB_GruboscLiniiWykresu.Location = new System.Drawing.Point(605, 64);
            this.PB_GruboscLiniiWykresu.Maximum = 5;
            this.PB_GruboscLiniiWykresu.Name = "PB_GruboscLiniiWykresu";
            this.PB_GruboscLiniiWykresu.Size = new System.Drawing.Size(109, 45);
            this.PB_GruboscLiniiWykresu.TabIndex = 12;
            this.PB_GruboscLiniiWykresu.Scroll += new System.EventHandler(this.PB_GruboscLiniiWykresu_Scroll);
            // 
            // PB_glw
            // 
            this.PB_glw.Location = new System.Drawing.Point(611, 32);
            this.PB_glw.Name = "PB_glw";
            this.PB_glw.Size = new System.Drawing.Size(91, 29);
            this.PB_glw.TabIndex = 13;
            this.PB_glw.Text = "Grubość linii wykresu";
            this.PB_glw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PB_OdrecznaDefinicjaGrubosciLinii
            // 
            this.PB_OdrecznaDefinicjaGrubosciLinii.Location = new System.Drawing.Point(614, 130);
            this.PB_OdrecznaDefinicjaGrubosciLinii.Name = "PB_OdrecznaDefinicjaGrubosciLinii";
            this.PB_OdrecznaDefinicjaGrubosciLinii.Size = new System.Drawing.Size(88, 20);
            this.PB_OdrecznaDefinicjaGrubosciLinii.TabIndex = 14;
            this.PB_OdrecznaDefinicjaGrubosciLinii.TextChanged += new System.EventHandler(this.PB_OdrecznaDefinicjaGrubosciLinii_TextChanged);
            // 
            // PB_glwul
            // 
            this.PB_glwul.Location = new System.Drawing.Point(605, 97);
            this.PB_glwul.Name = "PB_glwul";
            this.PB_glwul.Size = new System.Drawing.Size(109, 28);
            this.PB_glwul.TabIndex = 15;
            this.PB_glwul.Text = "Grubość linii wykresu ustalana liczbowo";
            this.PB_glwul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PB_WziernikWzorcaLinii
            // 
            this.PB_WziernikWzorcaLinii.Enabled = false;
            this.PB_WziernikWzorcaLinii.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PB_WziernikWzorcaLinii.Location = new System.Drawing.Point(614, 181);
            this.PB_WziernikWzorcaLinii.Name = "PB_WziernikWzorcaLinii";
            this.PB_WziernikWzorcaLinii.Size = new System.Drawing.Size(88, 29);
            this.PB_WziernikWzorcaLinii.TabIndex = 16;
            // 
            // PB_wwl
            // 
            this.PB_wwl.AutoSize = true;
            this.PB_wwl.Location = new System.Drawing.Point(611, 161);
            this.PB_wwl.Name = "PB_wwl";
            this.PB_wwl.Size = new System.Drawing.Size(102, 13);
            this.PB_wwl.TabIndex = 17;
            this.PB_wwl.Text = "Wziernik wzorca linii";
            // 
            // PB_TabelaWartosciFunkcjiFx
            // 
            this.PB_TabelaWartosciFunkcjiFx.AllowUserToAddRows = false;
            this.PB_TabelaWartosciFunkcjiFx.AllowUserToDeleteRows = false;
            this.PB_TabelaWartosciFunkcjiFx.AllowUserToResizeColumns = false;
            this.PB_TabelaWartosciFunkcjiFx.AllowUserToResizeRows = false;
            this.PB_TabelaWartosciFunkcjiFx.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.PB_TabelaWartosciFunkcjiFx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PB_TabelaWartosciFunkcjiFx.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PB_Xd,
            this.PB_Xg});
            this.PB_TabelaWartosciFunkcjiFx.Location = new System.Drawing.Point(262, 112);
            this.PB_TabelaWartosciFunkcjiFx.Name = "PB_TabelaWartosciFunkcjiFx";
            this.PB_TabelaWartosciFunkcjiFx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PB_TabelaWartosciFunkcjiFx.Size = new System.Drawing.Size(236, 216);
            this.PB_TabelaWartosciFunkcjiFx.TabIndex = 18;
            this.PB_TabelaWartosciFunkcjiFx.Visible = false;
            // 
            // PB_Xd
            // 
            this.PB_Xd.HeaderText = "Współrzędna X";
            this.PB_Xd.Name = "PB_Xd";
            this.PB_Xd.ReadOnly = true;
            this.PB_Xd.Width = 97;
            // 
            // PB_Xg
            // 
            this.PB_Xg.HeaderText = "Współrzędna Y";
            this.PB_Xg.Name = "PB_Xg";
            this.PB_Xg.ReadOnly = true;
            this.PB_Xg.Width = 97;
            // 
            // PB_WartoscZmienejX
            // 
            this.PB_WartoscZmienejX.Location = new System.Drawing.Point(38, 130);
            this.PB_WartoscZmienejX.Name = "PB_WartoscZmienejX";
            this.PB_WartoscZmienejX.Size = new System.Drawing.Size(122, 20);
            this.PB_WartoscZmienejX.TabIndex = 19;
            // 
            // PB_DolnaGranicaPrzedzialuFD
            // 
            this.PB_DolnaGranicaPrzedzialuFD.Location = new System.Drawing.Point(38, 211);
            this.PB_DolnaGranicaPrzedzialuFD.Name = "PB_DolnaGranicaPrzedzialuFD";
            this.PB_DolnaGranicaPrzedzialuFD.Size = new System.Drawing.Size(122, 20);
            this.PB_DolnaGranicaPrzedzialuFD.TabIndex = 20;
            // 
            // PB_GornaGranicaPrazedzialuFG
            // 
            this.PB_GornaGranicaPrazedzialuFG.Location = new System.Drawing.Point(38, 289);
            this.PB_GornaGranicaPrazedzialuFG.Name = "PB_GornaGranicaPrazedzialuFG";
            this.PB_GornaGranicaPrazedzialuFG.Size = new System.Drawing.Size(122, 20);
            this.PB_GornaGranicaPrazedzialuFG.TabIndex = 21;
            // 
            // PB_KrokPrzyrostuHFX
            // 
            this.PB_KrokPrzyrostuHFX.Location = new System.Drawing.Point(38, 379);
            this.PB_KrokPrzyrostuHFX.Name = "PB_KrokPrzyrostuHFX";
            this.PB_KrokPrzyrostuHFX.Size = new System.Drawing.Size(122, 20);
            this.PB_KrokPrzyrostuHFX.TabIndex = 22;
            // 
            // PB_wzx
            // 
            this.PB_wzx.AutoSize = true;
            this.PB_wzx.Location = new System.Drawing.Point(52, 112);
            this.PB_wzx.Name = "PB_wzx";
            this.PB_wzx.Size = new System.Drawing.Size(95, 13);
            this.PB_wzx.TabIndex = 23;
            this.PB_wzx.Text = "Wartość zmienej X";
            // 
            // PB_dgpxd
            // 
            this.PB_dgpxd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PB_dgpxd.Location = new System.Drawing.Point(38, 161);
            this.PB_dgpxd.Name = "PB_dgpxd";
            this.PB_dgpxd.Size = new System.Drawing.Size(122, 47);
            this.PB_dgpxd.TabIndex = 24;
            this.PB_dgpxd.Text = "Dolna granica przedziału F(d)";
            this.PB_dgpxd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PB_ggpfg
            // 
            this.PB_ggpfg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PB_ggpfg.Location = new System.Drawing.Point(38, 234);
            this.PB_ggpfg.Name = "PB_ggpfg";
            this.PB_ggpfg.Size = new System.Drawing.Size(122, 52);
            this.PB_ggpfg.TabIndex = 25;
            this.PB_ggpfg.Text = "Górna granica przedziału F(g)";
            this.PB_ggpfg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PB_kphx
            // 
            this.PB_kphx.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PB_kphx.Location = new System.Drawing.Point(38, 327);
            this.PB_kphx.Name = "PB_kphx";
            this.PB_kphx.Size = new System.Drawing.Size(122, 51);
            this.PB_kphx.TabIndex = 26;
            this.PB_kphx.Text = "Krok Przyrostu (h) zmienej X";
            this.PB_kphx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PB_WykreslLinieUWBezOpisu
            // 
            this.PB_WykreslLinieUWBezOpisu.AutoSize = true;
            this.PB_WykreslLinieUWBezOpisu.Location = new System.Drawing.Point(6, 50);
            this.PB_WykreslLinieUWBezOpisu.Name = "PB_WykreslLinieUWBezOpisu";
            this.PB_WykreslLinieUWBezOpisu.Size = new System.Drawing.Size(223, 17);
            this.PB_WykreslLinieUWBezOpisu.TabIndex = 28;
            this.PB_WykreslLinieUWBezOpisu.Text = "Linie osi układu współrzędnych bez opisu";
            this.PB_WykreslLinieUWBezOpisu.UseVisualStyleBackColor = true;
            this.PB_WykreslLinieUWBezOpisu.CheckedChanged += new System.EventHandler(this.PB_WykreslLinieUWBezOpisu_CheckedChanged);
            // 
            // PB_WykreslLinieUWZOpisem
            // 
            this.PB_WykreslLinieUWZOpisem.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.PB_WykreslLinieUWZOpisem.AutoSize = true;
            this.PB_WykreslLinieUWZOpisem.Checked = true;
            this.PB_WykreslLinieUWZOpisem.Location = new System.Drawing.Point(6, 27);
            this.PB_WykreslLinieUWZOpisem.Name = "PB_WykreslLinieUWZOpisem";
            this.PB_WykreslLinieUWZOpisem.Size = new System.Drawing.Size(219, 17);
            this.PB_WykreslLinieUWZOpisem.TabIndex = 29;
            this.PB_WykreslLinieUWZOpisem.TabStop = true;
            this.PB_WykreslLinieUWZOpisem.Text = "Linie osi układu współrzędnych z opisem";
            this.PB_WykreslLinieUWZOpisem.UseVisualStyleBackColor = true;
            this.PB_WykreslLinieUWZOpisem.CheckedChanged += new System.EventHandler(this.PB_WykreslLinieUWZOpisem_CheckedChanged);
            // 
            // PB_WykresPrzebieguFunkcji
            // 
            this.PB_WykresPrzebieguFunkcji.BackColor = System.Drawing.Color.Azure;
            chartArea1.Name = "ChartArea1";
            this.PB_WykresPrzebieguFunkcji.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.PB_WykresPrzebieguFunkcji.Legends.Add(legend1);
            this.PB_WykresPrzebieguFunkcji.Location = new System.Drawing.Point(182, 112);
            this.PB_WykresPrzebieguFunkcji.Name = "PB_WykresPrzebieguFunkcji";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.PB_WykresPrzebieguFunkcji.Series.Add(series1);
            this.PB_WykresPrzebieguFunkcji.Size = new System.Drawing.Size(389, 216);
            this.PB_WykresPrzebieguFunkcji.TabIndex = 31;
            this.PB_WykresPrzebieguFunkcji.Text = "chart1";
            this.PB_WykresPrzebieguFunkcji.Visible = false;
            // 
            // PB_WybranyStylLinii
            // 
            this.PB_WybranyStylLinii.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PB_WybranyStylLinii.FormattingEnabled = true;
            this.PB_WybranyStylLinii.Items.AddRange(new object[] {
            "- - - - - - - - - - - -",
            "- ˑ - ˑ - ˑ - ˑ - ˑ - ˑ -",
            "- ˑˑ - ˑˑ - ˑˑ - ˑˑ - ˑ",
            "ˑˑˑˑˑˑˑˑˑˑˑˑˑˑˑˑˑˑˑˑˑˑˑ",
            "——————————"});
            this.PB_WybranyStylLinii.Location = new System.Drawing.Point(478, 67);
            this.PB_WybranyStylLinii.Name = "PB_WybranyStylLinii";
            this.PB_WybranyStylLinii.Size = new System.Drawing.Size(108, 24);
            this.PB_WybranyStylLinii.TabIndex = 32;
            this.PB_WybranyStylLinii.Text = "——————————";
            this.PB_WybranyStylLinii.SelectedIndexChanged += new System.EventHandler(this.PB_WybranyStylLinii_SelectedIndexChanged_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PB_ObliczenieWartosciFunkcjiWPrzedziale
            // 
            this.PB_ObliczenieWartosciFunkcjiWPrzedziale.Location = new System.Drawing.Point(594, 256);
            this.PB_ObliczenieWartosciFunkcjiWPrzedziale.Name = "PB_ObliczenieWartosciFunkcjiWPrzedziale";
            this.PB_ObliczenieWartosciFunkcjiWPrzedziale.Size = new System.Drawing.Size(130, 46);
            this.PB_ObliczenieWartosciFunkcjiWPrzedziale.TabIndex = 33;
            this.PB_ObliczenieWartosciFunkcjiWPrzedziale.Text = "Oblicz wartości funkcji F(x) dla zadanego X";
            this.PB_ObliczenieWartosciFunkcjiWPrzedziale.UseVisualStyleBackColor = true;
            this.PB_ObliczenieWartosciFunkcjiWPrzedziale.Click += new System.EventHandler(this.PB_ObliczenieWartosciFunkcjiWPrzedziale_Click);
            // 
            // PB_wf_x
            // 
            this.PB_wf_x.AutoSize = true;
            this.PB_wf_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PB_wf_x.Location = new System.Drawing.Point(594, 234);
            this.PB_wf_x.Name = "PB_wf_x";
            this.PB_wf_x.Size = new System.Drawing.Size(43, 13);
            this.PB_wf_x.TabIndex = 35;
            this.PB_wf_x.Text = "F(x) = ";
            this.PB_wf_x.Visible = false;
            // 
            // PB_Fx_wynik
            // 
            this.PB_Fx_wynik.AutoSize = true;
            this.PB_Fx_wynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PB_Fx_wynik.Location = new System.Drawing.Point(642, 234);
            this.PB_Fx_wynik.Name = "PB_Fx_wynik";
            this.PB_Fx_wynik.Size = new System.Drawing.Size(0, 13);
            this.PB_Fx_wynik.TabIndex = 36;
            this.PB_Fx_wynik.Visible = false;
            // 
            // PB_GrupaWyboruPodpisuWykresu
            // 
            this.PB_GrupaWyboruPodpisuWykresu.Controls.Add(this.PB_WykreslLinieUWBezOpisu);
            this.PB_GrupaWyboruPodpisuWykresu.Controls.Add(this.PB_WykreslLinieUWZOpisem);
            this.PB_GrupaWyboruPodpisuWykresu.Location = new System.Drawing.Point(215, 334);
            this.PB_GrupaWyboruPodpisuWykresu.Name = "PB_GrupaWyboruPodpisuWykresu";
            this.PB_GrupaWyboruPodpisuWykresu.Size = new System.Drawing.Size(315, 73);
            this.PB_GrupaWyboruPodpisuWykresu.TabIndex = 37;
            this.PB_GrupaWyboruPodpisuWykresu.TabStop = false;
            this.PB_GrupaWyboruPodpisuWykresu.Text = "Wykreślenie osi układu współrzędnych i ich opisu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 411);
            this.Controls.Add(this.PB_GrupaWyboruPodpisuWykresu);
            this.Controls.Add(this.PB_Fx_wynik);
            this.Controls.Add(this.PB_wf_x);
            this.Controls.Add(this.PB_ObliczenieWartosciFunkcjiWPrzedziale);
            this.Controls.Add(this.PB_WybranyStylLinii);
            this.Controls.Add(this.PB_WykresPrzebieguFunkcji);
            this.Controls.Add(this.PB_kphx);
            this.Controls.Add(this.PB_ggpfg);
            this.Controls.Add(this.PB_dgpxd);
            this.Controls.Add(this.PB_wzx);
            this.Controls.Add(this.PB_KrokPrzyrostuHFX);
            this.Controls.Add(this.PB_GornaGranicaPrazedzialuFG);
            this.Controls.Add(this.PB_DolnaGranicaPrzedzialuFD);
            this.Controls.Add(this.PB_WartoscZmienejX);
            this.Controls.Add(this.PB_TabelaWartosciFunkcjiFx);
            this.Controls.Add(this.PB_wwl);
            this.Controls.Add(this.PB_WziernikWzorcaLinii);
            this.Controls.Add(this.PB_glwul);
            this.Controls.Add(this.PB_OdrecznaDefinicjaGrubosciLinii);
            this.Controls.Add(this.PB_glw);
            this.Controls.Add(this.PB_GruboscLiniiWykresu);
            this.Controls.Add(this.PB_NazwaFormularza);
            this.Controls.Add(this.PB_slw);
            this.Controls.Add(this.PB_wkt);
            this.Controls.Add(this.PB_WybranyKolorTla);
            this.Controls.Add(this.PB_wkl);
            this.Controls.Add(this.PB_WybranyKolorLinii);
            this.Controls.Add(this.PB_GraficznaWizualizacjaFx);
            this.Controls.Add(this.PB_TabelarycznaWizualizacjaWartosciFx);
            this.Controls.Add(this.PB_WybierzKolorTlaWykresu);
            this.Controls.Add(this.PB_WybierzKolorLiniiWykresu);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PB_GruboscLiniiWykresu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_TabelaWartosciFunkcjiFx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_WykresPrzebieguFunkcji)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.PB_GrupaWyboruPodpisuWykresu.ResumeLayout(false);
            this.PB_GrupaWyboruPodpisuWykresu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PB_WybierzKolorLiniiWykresu;
        private System.Windows.Forms.Button PB_WybierzKolorTlaWykresu;
        private System.Windows.Forms.Button PB_TabelarycznaWizualizacjaWartosciFx;
        private System.Windows.Forms.Button PB_GraficznaWizualizacjaFx;
        private System.Windows.Forms.TextBox PB_WybranyKolorLinii;
        private System.Windows.Forms.Label PB_wkl;
        private System.Windows.Forms.TextBox PB_WybranyKolorTla;
        private System.Windows.Forms.Label PB_wkt;
        private System.Windows.Forms.Label PB_slw;
        private System.Windows.Forms.Label PB_NazwaFormularza;
        private System.Windows.Forms.TrackBar PB_GruboscLiniiWykresu;
        private System.Windows.Forms.Label PB_glw;
        private System.Windows.Forms.TextBox PB_OdrecznaDefinicjaGrubosciLinii;
        private System.Windows.Forms.Label PB_glwul;
        private System.Windows.Forms.TextBox PB_WziernikWzorcaLinii;
        private System.Windows.Forms.Label PB_wwl;
        private System.Windows.Forms.DataGridView PB_TabelaWartosciFunkcjiFx;
        private System.Windows.Forms.TextBox PB_WartoscZmienejX;
        private System.Windows.Forms.TextBox PB_DolnaGranicaPrzedzialuFD;
        private System.Windows.Forms.TextBox PB_GornaGranicaPrazedzialuFG;
        private System.Windows.Forms.TextBox PB_KrokPrzyrostuHFX;
        private System.Windows.Forms.Label PB_wzx;
        private System.Windows.Forms.Label PB_dgpxd;
        private System.Windows.Forms.Label PB_ggpfg;
        private System.Windows.Forms.Label PB_kphx;
        private System.Windows.Forms.RadioButton PB_WykreslLinieUWBezOpisu;
        private System.Windows.Forms.RadioButton PB_WykreslLinieUWZOpisem;
        private System.Windows.Forms.DataVisualization.Charting.Chart PB_WykresPrzebieguFunkcji;
        private System.Windows.Forms.ComboBox PB_WybranyStylLinii;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button PB_ObliczenieWartosciFunkcjiWPrzedziale;
        private System.Windows.Forms.DataGridViewTextBoxColumn PB_Xd;
        private System.Windows.Forms.DataGridViewTextBoxColumn PB_Xg;
        private System.Windows.Forms.Label PB_wf_x;
        private System.Windows.Forms.Label PB_Fx_wynik;
        private System.Windows.Forms.GroupBox PB_GrupaWyboruPodpisuWykresu;
    }
}

