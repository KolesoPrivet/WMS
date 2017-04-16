﻿namespace WMS.WinformsClient.Views
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gpBoxInternetConnectionCheck = new System.Windows.Forms.GroupBox();
            this.txtBoxCheckInternet = new System.Windows.Forms.TextBox();
            this.gpBoxMapView = new System.Windows.Forms.GroupBox();
            this.btnShwMap = new System.Windows.Forms.Button();
            this.gpBoxSearch = new System.Windows.Forms.GroupBox();
            this.comboBoxSNMap = new System.Windows.Forms.ComboBox();
            this.gpBoxSearchResult = new System.Windows.Forms.GroupBox();
            this.gpBoxLastActivity = new System.Windows.Forms.GroupBox();
            this.lbTimeOfLastActivity = new System.Windows.Forms.Label();
            this.txtBoxMapLastTime = new System.Windows.Forms.TextBox();
            this.lbValueOfLastActivity = new System.Windows.Forms.Label();
            this.lbDateOfLastActivity = new System.Windows.Forms.Label();
            this.txtBoxMapLastDate = new System.Windows.Forms.TextBox();
            this.txtBoxMapLastValue = new System.Windows.Forms.TextBox();
            this.txtBoxMapSStatus = new System.Windows.Forms.TextBox();
            this.txtBoxMapSType = new System.Windows.Forms.TextBox();
            this.lbSensorTypeForResultOfSearch = new System.Windows.Forms.Label();
            this.lbSensorState = new System.Windows.Forms.Label();
            this.lbSensorNameForSearch = new System.Windows.Forms.Label();
            this.grBoxMap = new System.Windows.Forms.GroupBox();
            this.sensorMap = new GMap.NET.WindowsForms.GMapControl();
            this.tabPageSensor = new System.Windows.Forms.TabPage();
            this.gpBoxGraphic = new System.Windows.Forms.GroupBox();
            this.unionChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gpBoxData = new System.Windows.Forms.GroupBox();
            this.grBoxDataView = new System.Windows.Forms.GroupBox();
            this.rButtonAllDates = new System.Windows.Forms.RadioButton();
            this.rButtonChooseDate = new System.Windows.Forms.RadioButton();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.rtbSensorsValue = new System.Windows.Forms.RichTextBox();
            this.gpBoxSensorIdentity = new System.Windows.Forms.GroupBox();
            this.grBoxCurrentSensor = new System.Windows.Forms.GroupBox();
            this.txtBoxCurrentSensor = new System.Windows.Forms.TextBox();
            this.progressBarLoadDataFromDB = new System.Windows.Forms.ProgressBar();
            this.gpBoxSensorsView = new System.Windows.Forms.GroupBox();
            this.rButtonAllSensors = new System.Windows.Forms.RadioButton();
            this.rButtonChooseSensors = new System.Windows.Forms.RadioButton();
            this.dgvSens = new System.Windows.Forms.DataGridView();
            this.btnRefreshDB = new System.Windows.Forms.Button();
            this.rtbAmountSensors = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Мониторинг = new System.Windows.Forms.TabPage();
            this.grBoxGettingData = new System.Windows.Forms.GroupBox();
            this.rtbSensorsCountQuiz = new System.Windows.Forms.RichTextBox();
            this.rtbDataCountQuiz = new System.Windows.Forms.RichTextBox();
            this.grBoxMonitoringFiltration = new System.Windows.Forms.GroupBox();
            this.btnFiltration = new System.Windows.Forms.Button();
            this.grBoxFiltrationBySensorName = new System.Windows.Forms.GroupBox();
            this.btnSelectSensorsForаFiltration = new System.Windows.Forms.Button();
            this.dgvQuizResult = new System.Windows.Forms.DataGridView();
            this.grBoxMonitoringMap = new System.Windows.Forms.GroupBox();
            this.sensorMonitoringMap = new GMap.NET.WindowsForms.GMapControl();
            this.grBoxMonitoringSettings = new System.Windows.Forms.GroupBox();
            this.gpBoxSensorQuery = new System.Windows.Forms.GroupBox();
            this.rtbSelectedSensorsCount = new System.Windows.Forms.RichTextBox();
            this.progressBarMonitoring = new System.Windows.Forms.ProgressBar();
            this.btnSelectSensorsForRequest = new System.Windows.Forms.Button();
            this.btnRequestNetwork = new System.Windows.Forms.Button();
            this.grBoxQuizResult = new System.Windows.Forms.GroupBox();
            this.radioBtnOnlySave = new System.Windows.Forms.RadioButton();
            this.radioBtnOnlyShow = new System.Windows.Forms.RadioButton();
            this.radioBtnSaveAndShow = new System.Windows.Forms.RadioButton();
            this.grBoxInterval = new System.Windows.Forms.GroupBox();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.rtbQuizNumber = new System.Windows.Forms.RichTextBox();
            this.comboBoxSelectQuizInterval = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIntervalFrom = new System.Windows.Forms.Label();
            this.grBoxMonitoringType = new System.Windows.Forms.GroupBox();
            this.comboBoxMonitoringType = new System.Windows.Forms.ComboBox();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.RestartMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.PropertiesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgramMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rtbLogs = new System.Windows.Forms.RichTextBox();
            this.grBoxLogs = new System.Windows.Forms.GroupBox();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gpBoxInternetConnectionCheck.SuspendLayout();
            this.gpBoxMapView.SuspendLayout();
            this.gpBoxSearch.SuspendLayout();
            this.gpBoxSearchResult.SuspendLayout();
            this.gpBoxLastActivity.SuspendLayout();
            this.grBoxMap.SuspendLayout();
            this.tabPageSensor.SuspendLayout();
            this.gpBoxGraphic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unionChart)).BeginInit();
            this.gpBoxData.SuspendLayout();
            this.grBoxDataView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.gpBoxSensorIdentity.SuspendLayout();
            this.grBoxCurrentSensor.SuspendLayout();
            this.gpBoxSensorsView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSens)).BeginInit();
            this.tabControl.SuspendLayout();
            this.Мониторинг.SuspendLayout();
            this.grBoxGettingData.SuspendLayout();
            this.grBoxMonitoringFiltration.SuspendLayout();
            this.grBoxFiltrationBySensorName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuizResult)).BeginInit();
            this.grBoxMonitoringMap.SuspendLayout();
            this.grBoxMonitoringSettings.SuspendLayout();
            this.gpBoxSensorQuery.SuspendLayout();
            this.grBoxQuizResult.SuspendLayout();
            this.grBoxInterval.SuspendLayout();
            this.grBoxMonitoringType.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.grBoxLogs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1084, 673);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Карта датчиков";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer1.Panel1.Controls.Add(this.gpBoxInternetConnectionCheck);
            this.splitContainer1.Panel1.Controls.Add(this.gpBoxMapView);
            this.splitContainer1.Panel1.Controls.Add(this.gpBoxSearch);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grBoxMap);
            this.splitContainer1.Size = new System.Drawing.Size(1078, 667);
            this.splitContainer1.SplitterDistance = 289;
            this.splitContainer1.TabIndex = 0;
            // 
            // gpBoxInternetConnectionCheck
            // 
            this.gpBoxInternetConnectionCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpBoxInternetConnectionCheck.Controls.Add(this.txtBoxCheckInternet);
            this.gpBoxInternetConnectionCheck.Location = new System.Drawing.Point(3, 613);
            this.gpBoxInternetConnectionCheck.Name = "gpBoxInternetConnectionCheck";
            this.gpBoxInternetConnectionCheck.Size = new System.Drawing.Size(283, 51);
            this.gpBoxInternetConnectionCheck.TabIndex = 22;
            this.gpBoxInternetConnectionCheck.TabStop = false;
            this.gpBoxInternetConnectionCheck.Text = "Подключение к сети Интернет";
            // 
            // txtBoxCheckInternet
            // 
            this.txtBoxCheckInternet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCheckInternet.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxCheckInternet.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBoxCheckInternet.Location = new System.Drawing.Point(6, 19);
            this.txtBoxCheckInternet.Name = "txtBoxCheckInternet";
            this.txtBoxCheckInternet.ReadOnly = true;
            this.txtBoxCheckInternet.Size = new System.Drawing.Size(271, 20);
            this.txtBoxCheckInternet.TabIndex = 19;
            this.txtBoxCheckInternet.TabStop = false;
            this.txtBoxCheckInternet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gpBoxMapView
            // 
            this.gpBoxMapView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpBoxMapView.Controls.Add(this.btnShwMap);
            this.gpBoxMapView.Location = new System.Drawing.Point(4, 260);
            this.gpBoxMapView.Name = "gpBoxMapView";
            this.gpBoxMapView.Size = new System.Drawing.Size(283, 57);
            this.gpBoxMapView.TabIndex = 21;
            this.gpBoxMapView.TabStop = false;
            this.gpBoxMapView.Text = "Отображение карты";
            // 
            // btnShwMap
            // 
            this.btnShwMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShwMap.Enabled = false;
            this.btnShwMap.Location = new System.Drawing.Point(6, 19);
            this.btnShwMap.Name = "btnShwMap";
            this.btnShwMap.Size = new System.Drawing.Size(271, 29);
            this.btnShwMap.TabIndex = 19;
            this.btnShwMap.Text = "Отобразить";
            this.btnShwMap.UseVisualStyleBackColor = true;
            this.btnShwMap.Click += new System.EventHandler(this.btnShwMap_Click);
            // 
            // gpBoxSearch
            // 
            this.gpBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpBoxSearch.Controls.Add(this.comboBoxSNMap);
            this.gpBoxSearch.Controls.Add(this.gpBoxSearchResult);
            this.gpBoxSearch.Controls.Add(this.lbSensorNameForSearch);
            this.gpBoxSearch.Location = new System.Drawing.Point(3, 14);
            this.gpBoxSearch.Name = "gpBoxSearch";
            this.gpBoxSearch.Size = new System.Drawing.Size(283, 240);
            this.gpBoxSearch.TabIndex = 20;
            this.gpBoxSearch.TabStop = false;
            this.gpBoxSearch.Text = " Поиск";
            // 
            // comboBoxSNMap
            // 
            this.comboBoxSNMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSNMap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSNMap.Enabled = false;
            this.comboBoxSNMap.FormattingEnabled = true;
            this.comboBoxSNMap.Location = new System.Drawing.Point(90, 19);
            this.comboBoxSNMap.Name = "comboBoxSNMap";
            this.comboBoxSNMap.Size = new System.Drawing.Size(181, 21);
            this.comboBoxSNMap.TabIndex = 20;
            this.comboBoxSNMap.SelectedIndexChanged += new System.EventHandler(this.comboBoxSNMap_SelectedIndexChanged);
            // 
            // gpBoxSearchResult
            // 
            this.gpBoxSearchResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpBoxSearchResult.Controls.Add(this.gpBoxLastActivity);
            this.gpBoxSearchResult.Controls.Add(this.txtBoxMapSStatus);
            this.gpBoxSearchResult.Controls.Add(this.txtBoxMapSType);
            this.gpBoxSearchResult.Controls.Add(this.lbSensorTypeForResultOfSearch);
            this.gpBoxSearchResult.Controls.Add(this.lbSensorState);
            this.gpBoxSearchResult.Location = new System.Drawing.Point(6, 48);
            this.gpBoxSearchResult.Name = "gpBoxSearchResult";
            this.gpBoxSearchResult.Size = new System.Drawing.Size(271, 184);
            this.gpBoxSearchResult.TabIndex = 19;
            this.gpBoxSearchResult.TabStop = false;
            this.gpBoxSearchResult.Text = "Результаты поиска";
            // 
            // gpBoxLastActivity
            // 
            this.gpBoxLastActivity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpBoxLastActivity.Controls.Add(this.lbTimeOfLastActivity);
            this.gpBoxLastActivity.Controls.Add(this.txtBoxMapLastTime);
            this.gpBoxLastActivity.Controls.Add(this.lbValueOfLastActivity);
            this.gpBoxLastActivity.Controls.Add(this.lbDateOfLastActivity);
            this.gpBoxLastActivity.Controls.Add(this.txtBoxMapLastDate);
            this.gpBoxLastActivity.Controls.Add(this.txtBoxMapLastValue);
            this.gpBoxLastActivity.Location = new System.Drawing.Point(6, 74);
            this.gpBoxLastActivity.Name = "gpBoxLastActivity";
            this.gpBoxLastActivity.Size = new System.Drawing.Size(259, 101);
            this.gpBoxLastActivity.TabIndex = 24;
            this.gpBoxLastActivity.TabStop = false;
            this.gpBoxLastActivity.Text = "Последняя активность";
            // 
            // lbTimeOfLastActivity
            // 
            this.lbTimeOfLastActivity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTimeOfLastActivity.AutoSize = true;
            this.lbTimeOfLastActivity.Location = new System.Drawing.Point(6, 48);
            this.lbTimeOfLastActivity.Name = "lbTimeOfLastActivity";
            this.lbTimeOfLastActivity.Size = new System.Drawing.Size(43, 13);
            this.lbTimeOfLastActivity.TabIndex = 27;
            this.lbTimeOfLastActivity.Text = "Время:";
            // 
            // txtBoxMapLastTime
            // 
            this.txtBoxMapLastTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxMapLastTime.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxMapLastTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBoxMapLastTime.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtBoxMapLastTime.Location = new System.Drawing.Point(78, 45);
            this.txtBoxMapLastTime.Name = "txtBoxMapLastTime";
            this.txtBoxMapLastTime.ReadOnly = true;
            this.txtBoxMapLastTime.Size = new System.Drawing.Size(175, 20);
            this.txtBoxMapLastTime.TabIndex = 26;
            this.txtBoxMapLastTime.TabStop = false;
            this.txtBoxMapLastTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbValueOfLastActivity
            // 
            this.lbValueOfLastActivity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbValueOfLastActivity.AutoSize = true;
            this.lbValueOfLastActivity.Location = new System.Drawing.Point(6, 74);
            this.lbValueOfLastActivity.Name = "lbValueOfLastActivity";
            this.lbValueOfLastActivity.Size = new System.Drawing.Size(58, 13);
            this.lbValueOfLastActivity.TabIndex = 25;
            this.lbValueOfLastActivity.Text = "Значение:";
            // 
            // lbDateOfLastActivity
            // 
            this.lbDateOfLastActivity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDateOfLastActivity.AutoSize = true;
            this.lbDateOfLastActivity.Location = new System.Drawing.Point(6, 22);
            this.lbDateOfLastActivity.Name = "lbDateOfLastActivity";
            this.lbDateOfLastActivity.Size = new System.Drawing.Size(36, 13);
            this.lbDateOfLastActivity.TabIndex = 24;
            this.lbDateOfLastActivity.Text = "Дата:";
            // 
            // txtBoxMapLastDate
            // 
            this.txtBoxMapLastDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxMapLastDate.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxMapLastDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBoxMapLastDate.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtBoxMapLastDate.Location = new System.Drawing.Point(78, 19);
            this.txtBoxMapLastDate.Name = "txtBoxMapLastDate";
            this.txtBoxMapLastDate.ReadOnly = true;
            this.txtBoxMapLastDate.Size = new System.Drawing.Size(175, 20);
            this.txtBoxMapLastDate.TabIndex = 19;
            this.txtBoxMapLastDate.TabStop = false;
            this.txtBoxMapLastDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxMapLastValue
            // 
            this.txtBoxMapLastValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxMapLastValue.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxMapLastValue.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBoxMapLastValue.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtBoxMapLastValue.Location = new System.Drawing.Point(78, 71);
            this.txtBoxMapLastValue.Name = "txtBoxMapLastValue";
            this.txtBoxMapLastValue.ReadOnly = true;
            this.txtBoxMapLastValue.Size = new System.Drawing.Size(175, 20);
            this.txtBoxMapLastValue.TabIndex = 23;
            this.txtBoxMapLastValue.TabStop = false;
            this.txtBoxMapLastValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxMapSStatus
            // 
            this.txtBoxMapSStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxMapSStatus.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxMapSStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBoxMapSStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtBoxMapSStatus.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtBoxMapSStatus.Location = new System.Drawing.Point(84, 48);
            this.txtBoxMapSStatus.Name = "txtBoxMapSStatus";
            this.txtBoxMapSStatus.ReadOnly = true;
            this.txtBoxMapSStatus.Size = new System.Drawing.Size(181, 20);
            this.txtBoxMapSStatus.TabIndex = 18;
            this.txtBoxMapSStatus.TabStop = false;
            this.txtBoxMapSStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxMapSType
            // 
            this.txtBoxMapSType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxMapSType.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxMapSType.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBoxMapSType.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtBoxMapSType.Location = new System.Drawing.Point(84, 22);
            this.txtBoxMapSType.Name = "txtBoxMapSType";
            this.txtBoxMapSType.ReadOnly = true;
            this.txtBoxMapSType.Size = new System.Drawing.Size(181, 20);
            this.txtBoxMapSType.TabIndex = 16;
            this.txtBoxMapSType.TabStop = false;
            this.txtBoxMapSType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbSensorTypeForResultOfSearch
            // 
            this.lbSensorTypeForResultOfSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSensorTypeForResultOfSearch.AutoSize = true;
            this.lbSensorTypeForResultOfSearch.Location = new System.Drawing.Point(6, 25);
            this.lbSensorTypeForResultOfSearch.Name = "lbSensorTypeForResultOfSearch";
            this.lbSensorTypeForResultOfSearch.Size = new System.Drawing.Size(72, 13);
            this.lbSensorTypeForResultOfSearch.TabIndex = 3;
            this.lbSensorTypeForResultOfSearch.Text = "Тип датчика:";
            // 
            // lbSensorState
            // 
            this.lbSensorState.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSensorState.AutoSize = true;
            this.lbSensorState.Location = new System.Drawing.Point(7, 51);
            this.lbSensorState.Name = "lbSensorState";
            this.lbSensorState.Size = new System.Drawing.Size(64, 13);
            this.lbSensorState.TabIndex = 17;
            this.lbSensorState.Text = "Состояние:";
            // 
            // lbSensorNameForSearch
            // 
            this.lbSensorNameForSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSensorNameForSearch.AutoSize = true;
            this.lbSensorNameForSearch.Location = new System.Drawing.Point(12, 24);
            this.lbSensorNameForSearch.Name = "lbSensorNameForSearch";
            this.lbSensorNameForSearch.Size = new System.Drawing.Size(60, 13);
            this.lbSensorNameForSearch.TabIndex = 1;
            this.lbSensorNameForSearch.Text = "Название:";
            // 
            // grBoxMap
            // 
            this.grBoxMap.Controls.Add(this.sensorMap);
            this.grBoxMap.Location = new System.Drawing.Point(3, 3);
            this.grBoxMap.Name = "grBoxMap";
            this.grBoxMap.Size = new System.Drawing.Size(778, 661);
            this.grBoxMap.TabIndex = 1;
            this.grBoxMap.TabStop = false;
            this.grBoxMap.Text = "Карта датчиков";
            // 
            // sensorMap
            // 
            this.sensorMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sensorMap.Bearing = 0F;
            this.sensorMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sensorMap.CanDragMap = true;
            this.sensorMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.sensorMap.GrayScaleMode = false;
            this.sensorMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.sensorMap.LevelsKeepInMemmory = 5;
            this.sensorMap.Location = new System.Drawing.Point(6, 19);
            this.sensorMap.MarkersEnabled = true;
            this.sensorMap.MaxZoom = 2;
            this.sensorMap.MinZoom = 2;
            this.sensorMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.sensorMap.Name = "sensorMap";
            this.sensorMap.NegativeMode = false;
            this.sensorMap.PolygonsEnabled = true;
            this.sensorMap.RetryLoadTile = 0;
            this.sensorMap.RoutesEnabled = true;
            this.sensorMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.sensorMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.sensorMap.ShowTileGridLines = false;
            this.sensorMap.Size = new System.Drawing.Size(766, 636);
            this.sensorMap.TabIndex = 0;
            this.sensorMap.Visible = false;
            this.sensorMap.Zoom = 0D;
            this.sensorMap.Load += new System.EventHandler(this.SettingMaps);
            // 
            // tabPageSensor
            // 
            this.tabPageSensor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageSensor.Controls.Add(this.gpBoxGraphic);
            this.tabPageSensor.Controls.Add(this.gpBoxData);
            this.tabPageSensor.Controls.Add(this.gpBoxSensorIdentity);
            this.tabPageSensor.Controls.Add(this.label3);
            this.tabPageSensor.Location = new System.Drawing.Point(4, 22);
            this.tabPageSensor.Name = "tabPageSensor";
            this.tabPageSensor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSensor.Size = new System.Drawing.Size(1084, 673);
            this.tabPageSensor.TabIndex = 0;
            this.tabPageSensor.Text = "Данные";
            // 
            // gpBoxGraphic
            // 
            this.gpBoxGraphic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpBoxGraphic.Controls.Add(this.unionChart);
            this.gpBoxGraphic.Location = new System.Drawing.Point(6, 336);
            this.gpBoxGraphic.Name = "gpBoxGraphic";
            this.gpBoxGraphic.Size = new System.Drawing.Size(1072, 331);
            this.gpBoxGraphic.TabIndex = 16;
            this.gpBoxGraphic.TabStop = false;
            this.gpBoxGraphic.Text = "График";
            // 
            // unionChart
            // 
            this.unionChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.unionChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.unionChart.Legends.Add(legend1);
            this.unionChart.Location = new System.Drawing.Point(6, 19);
            this.unionChart.Name = "unionChart";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Blue;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Датчик";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            this.unionChart.Series.Add(series1);
            this.unionChart.Size = new System.Drawing.Size(1060, 306);
            this.unionChart.TabIndex = 6;
            this.unionChart.Text = "chart1";
            // 
            // gpBoxData
            // 
            this.gpBoxData.Controls.Add(this.grBoxDataView);
            this.gpBoxData.Controls.Add(this.dgvData);
            this.gpBoxData.Controls.Add(this.rtbSensorsValue);
            this.gpBoxData.Location = new System.Drawing.Point(537, 6);
            this.gpBoxData.Name = "gpBoxData";
            this.gpBoxData.Size = new System.Drawing.Size(541, 324);
            this.gpBoxData.TabIndex = 14;
            this.gpBoxData.TabStop = false;
            this.gpBoxData.Text = "Данные";
            // 
            // grBoxDataView
            // 
            this.grBoxDataView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grBoxDataView.Controls.Add(this.rButtonAllDates);
            this.grBoxDataView.Controls.Add(this.rButtonChooseDate);
            this.grBoxDataView.Location = new System.Drawing.Point(6, 16);
            this.grBoxDataView.Name = "grBoxDataView";
            this.grBoxDataView.Size = new System.Drawing.Size(218, 53);
            this.grBoxDataView.TabIndex = 20;
            this.grBoxDataView.TabStop = false;
            this.grBoxDataView.Text = "Отобразить";
            // 
            // rButtonAllDates
            // 
            this.rButtonAllDates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rButtonAllDates.AutoSize = true;
            this.rButtonAllDates.Checked = true;
            this.rButtonAllDates.Enabled = false;
            this.rButtonAllDates.Location = new System.Drawing.Point(17, 24);
            this.rButtonAllDates.Name = "rButtonAllDates";
            this.rButtonAllDates.Size = new System.Drawing.Size(85, 17);
            this.rButtonAllDates.TabIndex = 17;
            this.rButtonAllDates.TabStop = true;
            this.rButtonAllDates.Text = "Все данные";
            this.rButtonAllDates.UseVisualStyleBackColor = true;
            this.rButtonAllDates.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rButtonAllDates_MouseClick);
            // 
            // rButtonChooseDate
            // 
            this.rButtonChooseDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rButtonChooseDate.AutoSize = true;
            this.rButtonChooseDate.Enabled = false;
            this.rButtonChooseDate.Location = new System.Drawing.Point(119, 24);
            this.rButtonChooseDate.Name = "rButtonChooseDate";
            this.rButtonChooseDate.Size = new System.Drawing.Size(81, 17);
            this.rButtonChooseDate.TabIndex = 18;
            this.rButtonChooseDate.TabStop = true;
            this.rButtonChooseDate.Text = "Выборочно";
            this.rButtonChooseDate.UseVisualStyleBackColor = true;
            this.rButtonChooseDate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rButtonChooseDate_MouseClick);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToResizeRows = false;
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(6, 102);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(529, 213);
            this.dgvData.TabIndex = 0;
            // 
            // rtbSensorsValue
            // 
            this.rtbSensorsValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbSensorsValue.BackColor = System.Drawing.SystemColors.Menu;
            this.rtbSensorsValue.Enabled = false;
            this.rtbSensorsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbSensorsValue.Location = new System.Drawing.Point(6, 73);
            this.rtbSensorsValue.Name = "rtbSensorsValue";
            this.rtbSensorsValue.Size = new System.Drawing.Size(218, 24);
            this.rtbSensorsValue.TabIndex = 10;
            this.rtbSensorsValue.Text = "Показаний датчика: 0";
            // 
            // gpBoxSensorIdentity
            // 
            this.gpBoxSensorIdentity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gpBoxSensorIdentity.Controls.Add(this.grBoxCurrentSensor);
            this.gpBoxSensorIdentity.Controls.Add(this.progressBarLoadDataFromDB);
            this.gpBoxSensorIdentity.Controls.Add(this.gpBoxSensorsView);
            this.gpBoxSensorIdentity.Controls.Add(this.dgvSens);
            this.gpBoxSensorIdentity.Controls.Add(this.btnRefreshDB);
            this.gpBoxSensorIdentity.Controls.Add(this.rtbAmountSensors);
            this.gpBoxSensorIdentity.Location = new System.Drawing.Point(6, 6);
            this.gpBoxSensorIdentity.Name = "gpBoxSensorIdentity";
            this.gpBoxSensorIdentity.Size = new System.Drawing.Size(525, 324);
            this.gpBoxSensorIdentity.TabIndex = 13;
            this.gpBoxSensorIdentity.TabStop = false;
            this.gpBoxSensorIdentity.Text = "Идентификация датчиков";
            // 
            // grBoxCurrentSensor
            // 
            this.grBoxCurrentSensor.Controls.Add(this.txtBoxCurrentSensor);
            this.grBoxCurrentSensor.Location = new System.Drawing.Point(230, 19);
            this.grBoxCurrentSensor.Name = "grBoxCurrentSensor";
            this.grBoxCurrentSensor.Size = new System.Drawing.Size(154, 49);
            this.grBoxCurrentSensor.TabIndex = 20;
            this.grBoxCurrentSensor.TabStop = false;
            this.grBoxCurrentSensor.Text = "Выбранный датчик";
            // 
            // txtBoxCurrentSensor
            // 
            this.txtBoxCurrentSensor.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxCurrentSensor.Location = new System.Drawing.Point(6, 23);
            this.txtBoxCurrentSensor.Name = "txtBoxCurrentSensor";
            this.txtBoxCurrentSensor.ReadOnly = true;
            this.txtBoxCurrentSensor.Size = new System.Drawing.Size(142, 20);
            this.txtBoxCurrentSensor.TabIndex = 22;
            this.txtBoxCurrentSensor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // progressBarLoadDataFromDB
            // 
            this.progressBarLoadDataFromDB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.progressBarLoadDataFromDB.BackColor = System.Drawing.Color.YellowGreen;
            this.progressBarLoadDataFromDB.Location = new System.Drawing.Point(230, 74);
            this.progressBarLoadDataFromDB.Name = "progressBarLoadDataFromDB";
            this.progressBarLoadDataFromDB.Size = new System.Drawing.Size(289, 23);
            this.progressBarLoadDataFromDB.TabIndex = 5;
            // 
            // gpBoxSensorsView
            // 
            this.gpBoxSensorsView.Controls.Add(this.rButtonAllSensors);
            this.gpBoxSensorsView.Controls.Add(this.rButtonChooseSensors);
            this.gpBoxSensorsView.Location = new System.Drawing.Point(6, 16);
            this.gpBoxSensorsView.Name = "gpBoxSensorsView";
            this.gpBoxSensorsView.Size = new System.Drawing.Size(218, 53);
            this.gpBoxSensorsView.TabIndex = 19;
            this.gpBoxSensorsView.TabStop = false;
            this.gpBoxSensorsView.Text = "Отобразить";
            // 
            // rButtonAllSensors
            // 
            this.rButtonAllSensors.AutoSize = true;
            this.rButtonAllSensors.Checked = true;
            this.rButtonAllSensors.Enabled = false;
            this.rButtonAllSensors.Location = new System.Drawing.Point(17, 24);
            this.rButtonAllSensors.Name = "rButtonAllSensors";
            this.rButtonAllSensors.Size = new System.Drawing.Size(87, 17);
            this.rButtonAllSensors.TabIndex = 17;
            this.rButtonAllSensors.TabStop = true;
            this.rButtonAllSensors.Text = "Все датчики";
            this.rButtonAllSensors.UseVisualStyleBackColor = true;
            this.rButtonAllSensors.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rButtonAllSensors_MouseClick);
            // 
            // rButtonChooseSensors
            // 
            this.rButtonChooseSensors.AutoSize = true;
            this.rButtonChooseSensors.Enabled = false;
            this.rButtonChooseSensors.Location = new System.Drawing.Point(119, 24);
            this.rButtonChooseSensors.Name = "rButtonChooseSensors";
            this.rButtonChooseSensors.Size = new System.Drawing.Size(81, 17);
            this.rButtonChooseSensors.TabIndex = 18;
            this.rButtonChooseSensors.TabStop = true;
            this.rButtonChooseSensors.Text = "Выборочно";
            this.rButtonChooseSensors.UseVisualStyleBackColor = true;
            this.rButtonChooseSensors.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rButtonChooseSensors_MouseClick);
            // 
            // dgvSens
            // 
            this.dgvSens.AllowUserToAddRows = false;
            this.dgvSens.AllowUserToDeleteRows = false;
            this.dgvSens.AllowUserToResizeRows = false;
            this.dgvSens.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvSens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSens.Location = new System.Drawing.Point(6, 102);
            this.dgvSens.MultiSelect = false;
            this.dgvSens.Name = "dgvSens";
            this.dgvSens.ReadOnly = true;
            this.dgvSens.RowHeadersVisible = false;
            this.dgvSens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSens.Size = new System.Drawing.Size(513, 213);
            this.dgvSens.TabIndex = 16;
            this.dgvSens.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSens_CellEnter);
            // 
            // btnRefreshDB
            // 
            this.btnRefreshDB.Location = new System.Drawing.Point(390, 16);
            this.btnRefreshDB.Name = "btnRefreshDB";
            this.btnRefreshDB.Size = new System.Drawing.Size(129, 53);
            this.btnRefreshDB.TabIndex = 13;
            this.btnRefreshDB.Text = "Получить данные";
            this.btnRefreshDB.UseVisualStyleBackColor = true;
            this.btnRefreshDB.Click += new System.EventHandler(this.btnRefreshDB_Click);
            // 
            // rtbAmountSensors
            // 
            this.rtbAmountSensors.BackColor = System.Drawing.SystemColors.Menu;
            this.rtbAmountSensors.Enabled = false;
            this.rtbAmountSensors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbAmountSensors.Location = new System.Drawing.Point(6, 75);
            this.rtbAmountSensors.Name = "rtbAmountSensors";
            this.rtbAmountSensors.Size = new System.Drawing.Size(218, 24);
            this.rtbAmountSensors.TabIndex = 15;
            this.rtbAmountSensors.Text = "Количество датчиков: 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.AccessibleName = "";
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageSensor);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.Мониторинг);
            this.tabControl.Location = new System.Drawing.Point(7, 30);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1092, 699);
            this.tabControl.TabIndex = 4;
            this.tabControl.Tag = "";
            // 
            // Мониторинг
            // 
            this.Мониторинг.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Мониторинг.Controls.Add(this.grBoxGettingData);
            this.Мониторинг.Controls.Add(this.grBoxMonitoringMap);
            this.Мониторинг.Controls.Add(this.grBoxMonitoringSettings);
            this.Мониторинг.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Мониторинг.Location = new System.Drawing.Point(4, 22);
            this.Мониторинг.Name = "Мониторинг";
            this.Мониторинг.Padding = new System.Windows.Forms.Padding(3);
            this.Мониторинг.Size = new System.Drawing.Size(1084, 673);
            this.Мониторинг.TabIndex = 2;
            this.Мониторинг.Text = "Мониторинг";
            // 
            // grBoxGettingData
            // 
            this.grBoxGettingData.Controls.Add(this.rtbSensorsCountQuiz);
            this.grBoxGettingData.Controls.Add(this.rtbDataCountQuiz);
            this.grBoxGettingData.Controls.Add(this.grBoxMonitoringFiltration);
            this.grBoxGettingData.Controls.Add(this.dgvQuizResult);
            this.grBoxGettingData.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grBoxGettingData.Location = new System.Drawing.Point(6, 331);
            this.grBoxGettingData.Name = "grBoxGettingData";
            this.grBoxGettingData.Size = new System.Drawing.Size(1071, 336);
            this.grBoxGettingData.TabIndex = 19;
            this.grBoxGettingData.TabStop = false;
            this.grBoxGettingData.Text = "Полученные данные";
            // 
            // rtbSensorsCountQuiz
            // 
            this.rtbSensorsCountQuiz.BackColor = System.Drawing.SystemColors.Menu;
            this.rtbSensorsCountQuiz.Enabled = false;
            this.rtbSensorsCountQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbSensorsCountQuiz.Location = new System.Drawing.Point(6, 207);
            this.rtbSensorsCountQuiz.Name = "rtbSensorsCountQuiz";
            this.rtbSensorsCountQuiz.Size = new System.Drawing.Size(218, 24);
            this.rtbSensorsCountQuiz.TabIndex = 17;
            this.rtbSensorsCountQuiz.Text = "Количество датчиков: 0";
            // 
            // rtbDataCountQuiz
            // 
            this.rtbDataCountQuiz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbDataCountQuiz.BackColor = System.Drawing.SystemColors.Menu;
            this.rtbDataCountQuiz.Enabled = false;
            this.rtbDataCountQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbDataCountQuiz.Location = new System.Drawing.Point(230, 207);
            this.rtbDataCountQuiz.Name = "rtbDataCountQuiz";
            this.rtbDataCountQuiz.Size = new System.Drawing.Size(218, 24);
            this.rtbDataCountQuiz.TabIndex = 11;
            this.rtbDataCountQuiz.Text = "Показаний датчика: 0";
            // 
            // grBoxMonitoringFiltration
            // 
            this.grBoxMonitoringFiltration.Controls.Add(this.btnFiltration);
            this.grBoxMonitoringFiltration.Controls.Add(this.grBoxFiltrationBySensorName);
            this.grBoxMonitoringFiltration.Location = new System.Drawing.Point(6, 237);
            this.grBoxMonitoringFiltration.Name = "grBoxMonitoringFiltration";
            this.grBoxMonitoringFiltration.Size = new System.Drawing.Size(1059, 94);
            this.grBoxMonitoringFiltration.TabIndex = 2;
            this.grBoxMonitoringFiltration.TabStop = false;
            this.grBoxMonitoringFiltration.Text = "Фильтрация";
            // 
            // btnFiltration
            // 
            this.btnFiltration.Location = new System.Drawing.Point(826, 13);
            this.btnFiltration.Name = "btnFiltration";
            this.btnFiltration.Size = new System.Drawing.Size(227, 75);
            this.btnFiltration.TabIndex = 28;
            this.btnFiltration.Text = "ОК";
            this.btnFiltration.UseVisualStyleBackColor = true;
            // 
            // grBoxFiltrationBySensorName
            // 
            this.grBoxFiltrationBySensorName.Controls.Add(this.btnSelectSensorsForаFiltration);
            this.grBoxFiltrationBySensorName.Location = new System.Drawing.Point(6, 19);
            this.grBoxFiltrationBySensorName.Name = "grBoxFiltrationBySensorName";
            this.grBoxFiltrationBySensorName.Size = new System.Drawing.Size(239, 69);
            this.grBoxFiltrationBySensorName.TabIndex = 0;
            this.grBoxFiltrationBySensorName.TabStop = false;
            this.grBoxFiltrationBySensorName.Text = "По названию датчика";
            // 
            // btnSelectSensorsForаFiltration
            // 
            this.btnSelectSensorsForаFiltration.Location = new System.Drawing.Point(6, 19);
            this.btnSelectSensorsForаFiltration.Name = "btnSelectSensorsForаFiltration";
            this.btnSelectSensorsForаFiltration.Size = new System.Drawing.Size(227, 44);
            this.btnSelectSensorsForаFiltration.TabIndex = 27;
            this.btnSelectSensorsForаFiltration.Text = "Выбрать";
            this.btnSelectSensorsForаFiltration.UseVisualStyleBackColor = true;
            // 
            // dgvQuizResult
            // 
            this.dgvQuizResult.AllowUserToAddRows = false;
            this.dgvQuizResult.AllowUserToDeleteRows = false;
            this.dgvQuizResult.AllowUserToResizeRows = false;
            this.dgvQuizResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuizResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuizResult.Location = new System.Drawing.Point(6, 19);
            this.dgvQuizResult.Name = "dgvQuizResult";
            this.dgvQuizResult.ReadOnly = true;
            this.dgvQuizResult.RowHeadersVisible = false;
            this.dgvQuizResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuizResult.Size = new System.Drawing.Size(1059, 182);
            this.dgvQuizResult.TabIndex = 1;
            // 
            // grBoxMonitoringMap
            // 
            this.grBoxMonitoringMap.Controls.Add(this.sensorMonitoringMap);
            this.grBoxMonitoringMap.Location = new System.Drawing.Point(448, 3);
            this.grBoxMonitoringMap.Name = "grBoxMonitoringMap";
            this.grBoxMonitoringMap.Size = new System.Drawing.Size(629, 322);
            this.grBoxMonitoringMap.TabIndex = 20;
            this.grBoxMonitoringMap.TabStop = false;
            this.grBoxMonitoringMap.Text = "Карта датчиков";
            // 
            // sensorMonitoringMap
            // 
            this.sensorMonitoringMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sensorMonitoringMap.Bearing = 0F;
            this.sensorMonitoringMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sensorMonitoringMap.CanDragMap = true;
            this.sensorMonitoringMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.sensorMonitoringMap.GrayScaleMode = false;
            this.sensorMonitoringMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.sensorMonitoringMap.LevelsKeepInMemmory = 5;
            this.sensorMonitoringMap.Location = new System.Drawing.Point(6, 19);
            this.sensorMonitoringMap.MarkersEnabled = true;
            this.sensorMonitoringMap.MaxZoom = 2;
            this.sensorMonitoringMap.MinZoom = 2;
            this.sensorMonitoringMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.sensorMonitoringMap.Name = "sensorMonitoringMap";
            this.sensorMonitoringMap.NegativeMode = false;
            this.sensorMonitoringMap.PolygonsEnabled = true;
            this.sensorMonitoringMap.RetryLoadTile = 0;
            this.sensorMonitoringMap.RoutesEnabled = true;
            this.sensorMonitoringMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.sensorMonitoringMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.sensorMonitoringMap.ShowTileGridLines = false;
            this.sensorMonitoringMap.Size = new System.Drawing.Size(617, 297);
            this.sensorMonitoringMap.TabIndex = 0;
            this.sensorMonitoringMap.Visible = false;
            this.sensorMonitoringMap.Zoom = 0D;
            this.sensorMonitoringMap.Load += new System.EventHandler(this.SettingMaps);
            // 
            // grBoxMonitoringSettings
            // 
            this.grBoxMonitoringSettings.Controls.Add(this.gpBoxSensorQuery);
            this.grBoxMonitoringSettings.Controls.Add(this.grBoxQuizResult);
            this.grBoxMonitoringSettings.Controls.Add(this.grBoxInterval);
            this.grBoxMonitoringSettings.Controls.Add(this.grBoxMonitoringType);
            this.grBoxMonitoringSettings.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grBoxMonitoringSettings.Location = new System.Drawing.Point(6, 3);
            this.grBoxMonitoringSettings.Name = "grBoxMonitoringSettings";
            this.grBoxMonitoringSettings.Size = new System.Drawing.Size(437, 322);
            this.grBoxMonitoringSettings.TabIndex = 0;
            this.grBoxMonitoringSettings.TabStop = false;
            this.grBoxMonitoringSettings.Text = "Настройки";
            // 
            // gpBoxSensorQuery
            // 
            this.gpBoxSensorQuery.Controls.Add(this.rtbSelectedSensorsCount);
            this.gpBoxSensorQuery.Controls.Add(this.progressBarMonitoring);
            this.gpBoxSensorQuery.Controls.Add(this.btnSelectSensorsForRequest);
            this.gpBoxSensorQuery.Controls.Add(this.btnRequestNetwork);
            this.gpBoxSensorQuery.Location = new System.Drawing.Point(6, 227);
            this.gpBoxSensorQuery.Name = "gpBoxSensorQuery";
            this.gpBoxSensorQuery.Size = new System.Drawing.Size(425, 89);
            this.gpBoxSensorQuery.TabIndex = 25;
            this.gpBoxSensorQuery.TabStop = false;
            this.gpBoxSensorQuery.Text = "Опрос";
            // 
            // rtbSelectedSensorsCount
            // 
            this.rtbSelectedSensorsCount.BackColor = System.Drawing.SystemColors.Menu;
            this.rtbSelectedSensorsCount.Enabled = false;
            this.rtbSelectedSensorsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbSelectedSensorsCount.Location = new System.Drawing.Point(6, 19);
            this.rtbSelectedSensorsCount.Name = "rtbSelectedSensorsCount";
            this.rtbSelectedSensorsCount.Size = new System.Drawing.Size(174, 24);
            this.rtbSelectedSensorsCount.TabIndex = 18;
            this.rtbSelectedSensorsCount.Text = "Датчиков выбрано: 0";
            // 
            // progressBarMonitoring
            // 
            this.progressBarMonitoring.Location = new System.Drawing.Point(186, 53);
            this.progressBarMonitoring.Name = "progressBarMonitoring";
            this.progressBarMonitoring.Size = new System.Drawing.Size(232, 29);
            this.progressBarMonitoring.TabIndex = 26;
            // 
            // btnSelectSensorsForRequest
            // 
            this.btnSelectSensorsForRequest.Location = new System.Drawing.Point(186, 19);
            this.btnSelectSensorsForRequest.Name = "btnSelectSensorsForRequest";
            this.btnSelectSensorsForRequest.Size = new System.Drawing.Size(233, 24);
            this.btnSelectSensorsForRequest.TabIndex = 26;
            this.btnSelectSensorsForRequest.Text = "Выбрать";
            this.btnSelectSensorsForRequest.UseVisualStyleBackColor = true;
            this.btnSelectSensorsForRequest.Click += new System.EventHandler(this.btnSelectSensorsForRequest_Click);
            // 
            // btnRequestNetwork
            // 
            this.btnRequestNetwork.Enabled = false;
            this.btnRequestNetwork.Location = new System.Drawing.Point(5, 53);
            this.btnRequestNetwork.Name = "btnRequestNetwork";
            this.btnRequestNetwork.Size = new System.Drawing.Size(175, 29);
            this.btnRequestNetwork.TabIndex = 23;
            this.btnRequestNetwork.Text = "Опросить";
            this.btnRequestNetwork.UseVisualStyleBackColor = true;
            this.btnRequestNetwork.Click += new System.EventHandler(this.btnRequestNetwork_Click);
            // 
            // grBoxQuizResult
            // 
            this.grBoxQuizResult.Controls.Add(this.radioBtnOnlySave);
            this.grBoxQuizResult.Controls.Add(this.radioBtnOnlyShow);
            this.grBoxQuizResult.Controls.Add(this.radioBtnSaveAndShow);
            this.grBoxQuizResult.Location = new System.Drawing.Point(6, 153);
            this.grBoxQuizResult.Name = "grBoxQuizResult";
            this.grBoxQuizResult.Size = new System.Drawing.Size(425, 68);
            this.grBoxQuizResult.TabIndex = 29;
            this.grBoxQuizResult.TabStop = false;
            this.grBoxQuizResult.Text = "Результаты опроса";
            // 
            // radioBtnOnlySave
            // 
            this.radioBtnOnlySave.AutoSize = true;
            this.radioBtnOnlySave.Location = new System.Drawing.Point(9, 45);
            this.radioBtnOnlySave.Name = "radioBtnOnlySave";
            this.radioBtnOnlySave.Size = new System.Drawing.Size(145, 17);
            this.radioBtnOnlySave.TabIndex = 2;
            this.radioBtnOnlySave.Text = "Только сохранить в БД";
            this.radioBtnOnlySave.UseVisualStyleBackColor = true;
            this.radioBtnOnlySave.Click += new System.EventHandler(this.radioBtnOnlySave_Click);
            // 
            // radioBtnOnlyShow
            // 
            this.radioBtnOnlyShow.AutoSize = true;
            this.radioBtnOnlyShow.Checked = true;
            this.radioBtnOnlyShow.Location = new System.Drawing.Point(9, 22);
            this.radioBtnOnlyShow.Name = "radioBtnOnlyShow";
            this.radioBtnOnlyShow.Size = new System.Drawing.Size(123, 17);
            this.radioBtnOnlyShow.TabIndex = 1;
            this.radioBtnOnlyShow.TabStop = true;
            this.radioBtnOnlyShow.Text = "Только отобразить";
            this.radioBtnOnlyShow.UseVisualStyleBackColor = true;
            this.radioBtnOnlyShow.Click += new System.EventHandler(this.radioBtnOnlyShow_Click);
            // 
            // radioBtnSaveAndShow
            // 
            this.radioBtnSaveAndShow.AutoSize = true;
            this.radioBtnSaveAndShow.Location = new System.Drawing.Point(242, 22);
            this.radioBtnSaveAndShow.Name = "radioBtnSaveAndShow";
            this.radioBtnSaveAndShow.Size = new System.Drawing.Size(177, 17);
            this.radioBtnSaveAndShow.TabIndex = 0;
            this.radioBtnSaveAndShow.Text = "Отобразить и сохранить в БД";
            this.radioBtnSaveAndShow.UseVisualStyleBackColor = true;
            this.radioBtnSaveAndShow.Click += new System.EventHandler(this.radioBtnSaveAndShow_Click);
            // 
            // grBoxInterval
            // 
            this.grBoxInterval.Controls.Add(this.dtpTo);
            this.grBoxInterval.Controls.Add(this.dtpFrom);
            this.grBoxInterval.Controls.Add(this.rtbQuizNumber);
            this.grBoxInterval.Controls.Add(this.comboBoxSelectQuizInterval);
            this.grBoxInterval.Controls.Add(this.label1);
            this.grBoxInterval.Controls.Add(this.lblIntervalFrom);
            this.grBoxInterval.Location = new System.Drawing.Point(6, 75);
            this.grBoxInterval.Name = "grBoxInterval";
            this.grBoxInterval.Size = new System.Drawing.Size(425, 72);
            this.grBoxInterval.TabIndex = 28;
            this.grBoxInterval.TabStop = false;
            this.grBoxInterval.Text = "Интервал";
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTo.Location = new System.Drawing.Point(37, 45);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(63, 20);
            this.dtpTo.TabIndex = 17;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFrom.Location = new System.Drawing.Point(37, 16);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(63, 20);
            this.dtpFrom.TabIndex = 6;
            // 
            // rtbQuizNumber
            // 
            this.rtbQuizNumber.BackColor = System.Drawing.SystemColors.Menu;
            this.rtbQuizNumber.Enabled = false;
            this.rtbQuizNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbQuizNumber.Location = new System.Drawing.Point(119, 15);
            this.rtbQuizNumber.Name = "rtbQuizNumber";
            this.rtbQuizNumber.Size = new System.Drawing.Size(294, 24);
            this.rtbQuizNumber.TabIndex = 16;
            this.rtbQuizNumber.Text = "Сеть будет опрошена: 0 раз";
            // 
            // comboBoxSelectQuizInterval
            // 
            this.comboBoxSelectQuizInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectQuizInterval.FormattingEnabled = true;
            this.comboBoxSelectQuizInterval.Location = new System.Drawing.Point(119, 45);
            this.comboBoxSelectQuizInterval.Name = "comboBoxSelectQuizInterval";
            this.comboBoxSelectQuizInterval.Size = new System.Drawing.Size(294, 21);
            this.comboBoxSelectQuizInterval.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "До:";
            // 
            // lblIntervalFrom
            // 
            this.lblIntervalFrom.AutoSize = true;
            this.lblIntervalFrom.Location = new System.Drawing.Point(6, 22);
            this.lblIntervalFrom.Name = "lblIntervalFrom";
            this.lblIntervalFrom.Size = new System.Drawing.Size(23, 13);
            this.lblIntervalFrom.TabIndex = 2;
            this.lblIntervalFrom.Text = "От:";
            // 
            // grBoxMonitoringType
            // 
            this.grBoxMonitoringType.Controls.Add(this.comboBoxMonitoringType);
            this.grBoxMonitoringType.Location = new System.Drawing.Point(6, 19);
            this.grBoxMonitoringType.Name = "grBoxMonitoringType";
            this.grBoxMonitoringType.Size = new System.Drawing.Size(425, 50);
            this.grBoxMonitoringType.TabIndex = 26;
            this.grBoxMonitoringType.TabStop = false;
            this.grBoxMonitoringType.Text = "Тип мониторинга";
            // 
            // comboBoxMonitoringType
            // 
            this.comboBoxMonitoringType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMonitoringType.FormattingEnabled = true;
            this.comboBoxMonitoringType.Location = new System.Drawing.Point(5, 19);
            this.comboBoxMonitoringType.Name = "comboBoxMonitoringType";
            this.comboBoxMonitoringType.Size = new System.Drawing.Size(414, 21);
            this.comboBoxMonitoringType.TabIndex = 0;
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveAsMenu,
            this.RestartMenu,
            this.ExitMenu});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(48, 20);
            this.FileMenu.Text = "Файл";
            // 
            // SaveAsMenu
            // 
            this.SaveAsMenu.Enabled = false;
            this.SaveAsMenu.Name = "SaveAsMenu";
            this.SaveAsMenu.Size = new System.Drawing.Size(179, 22);
            this.SaveAsMenu.Text = "Сохранить в Excel...";
            this.SaveAsMenu.Click += new System.EventHandler(this.SaveAsMenu_Click);
            // 
            // RestartMenu
            // 
            this.RestartMenu.Name = "RestartMenu";
            this.RestartMenu.Size = new System.Drawing.Size(179, 22);
            this.RestartMenu.Text = "Перезагрузка";
            this.RestartMenu.Click += new System.EventHandler(this.RestartMenu_Click);
            // 
            // ExitMenu
            // 
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.Size = new System.Drawing.Size(179, 22);
            this.ExitMenu.Text = "Выход";
            this.ExitMenu.Click += new System.EventHandler(this.ExitMenu_Click);
            // 
            // PropertiesMenu
            // 
            this.PropertiesMenu.Name = "PropertiesMenu";
            this.PropertiesMenu.Size = new System.Drawing.Size(79, 20);
            this.PropertiesMenu.Text = "Настройки";
            // 
            // HelpMenu
            // 
            this.HelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutProgramMenu});
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.Size = new System.Drawing.Size(68, 20);
            this.HelpMenu.Text = "Помощь";
            // 
            // AboutProgramMenu
            // 
            this.AboutProgramMenu.Name = "AboutProgramMenu";
            this.AboutProgramMenu.Size = new System.Drawing.Size(149, 22);
            this.AboutProgramMenu.Text = "О программе";
            this.AboutProgramMenu.Click += new System.EventHandler(this.AboutProgramMenu_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.PropertiesMenu,
            this.HelpMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(203, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rtbLogs
            // 
            this.rtbLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbLogs.BackColor = System.Drawing.SystemColors.GrayText;
            this.rtbLogs.ForeColor = System.Drawing.SystemColors.Info;
            this.rtbLogs.Location = new System.Drawing.Point(6, 19);
            this.rtbLogs.Name = "rtbLogs";
            this.rtbLogs.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbLogs.Size = new System.Drawing.Size(1071, 139);
            this.rtbLogs.TabIndex = 5;
            this.rtbLogs.Text = "";
            // 
            // grBoxLogs
            // 
            this.grBoxLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grBoxLogs.Controls.Add(this.rtbLogs);
            this.grBoxLogs.Location = new System.Drawing.Point(11, 735);
            this.grBoxLogs.Name = "grBoxLogs";
            this.grBoxLogs.Size = new System.Drawing.Size(1083, 164);
            this.grBoxLogs.TabIndex = 5;
            this.grBoxLogs.TabStop = false;
            this.grBoxLogs.Text = "Вывод";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 911);
            this.Controls.Add(this.grBoxLogs);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Беспроводная система мониторинга WMS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gpBoxInternetConnectionCheck.ResumeLayout(false);
            this.gpBoxInternetConnectionCheck.PerformLayout();
            this.gpBoxMapView.ResumeLayout(false);
            this.gpBoxSearch.ResumeLayout(false);
            this.gpBoxSearch.PerformLayout();
            this.gpBoxSearchResult.ResumeLayout(false);
            this.gpBoxSearchResult.PerformLayout();
            this.gpBoxLastActivity.ResumeLayout(false);
            this.gpBoxLastActivity.PerformLayout();
            this.grBoxMap.ResumeLayout(false);
            this.tabPageSensor.ResumeLayout(false);
            this.tabPageSensor.PerformLayout();
            this.gpBoxGraphic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.unionChart)).EndInit();
            this.gpBoxData.ResumeLayout(false);
            this.grBoxDataView.ResumeLayout(false);
            this.grBoxDataView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.gpBoxSensorIdentity.ResumeLayout(false);
            this.grBoxCurrentSensor.ResumeLayout(false);
            this.grBoxCurrentSensor.PerformLayout();
            this.gpBoxSensorsView.ResumeLayout(false);
            this.gpBoxSensorsView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSens)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.Мониторинг.ResumeLayout(false);
            this.grBoxGettingData.ResumeLayout(false);
            this.grBoxMonitoringFiltration.ResumeLayout(false);
            this.grBoxFiltrationBySensorName.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuizResult)).EndInit();
            this.grBoxMonitoringMap.ResumeLayout(false);
            this.grBoxMonitoringSettings.ResumeLayout(false);
            this.gpBoxSensorQuery.ResumeLayout(false);
            this.grBoxQuizResult.ResumeLayout(false);
            this.grBoxQuizResult.PerformLayout();
            this.grBoxInterval.ResumeLayout(false);
            this.grBoxInterval.PerformLayout();
            this.grBoxMonitoringType.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grBoxLogs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gpBoxInternetConnectionCheck;
        private System.Windows.Forms.TextBox txtBoxCheckInternet;
        private System.Windows.Forms.GroupBox gpBoxMapView;
        private System.Windows.Forms.Button btnShwMap;
        private System.Windows.Forms.GroupBox gpBoxSearch;
        private System.Windows.Forms.GroupBox gpBoxSearchResult;
        private System.Windows.Forms.TextBox txtBoxMapSStatus;
        private System.Windows.Forms.TextBox txtBoxMapSType;
        private System.Windows.Forms.Label lbSensorTypeForResultOfSearch;
        private System.Windows.Forms.Label lbSensorState;
        private System.Windows.Forms.Label lbSensorNameForSearch;
        private GMap.NET.WindowsForms.GMapControl sensorMap;
        private System.Windows.Forms.TabPage tabPageSensor;
        private System.Windows.Forms.GroupBox gpBoxGraphic;
        private System.Windows.Forms.DataVisualization.Charting.Chart unionChart;
        private System.Windows.Forms.GroupBox gpBoxData;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.RichTextBox rtbSensorsValue;
        private System.Windows.Forms.GroupBox gpBoxSensorIdentity;
        private System.Windows.Forms.DataGridView dgvSens;
        private System.Windows.Forms.Button btnRefreshDB;
        private System.Windows.Forms.RichTextBox rtbAmountSensors;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem ExitMenu;
        private System.Windows.Forms.ToolStripMenuItem PropertiesMenu;
        private System.Windows.Forms.ToolStripMenuItem HelpMenu;
        private System.Windows.Forms.ToolStripMenuItem AboutProgramMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox comboBoxSNMap;
        private System.Windows.Forms.TextBox txtBoxMapLastValue;
        private System.Windows.Forms.TextBox txtBoxMapLastDate;
        private System.Windows.Forms.GroupBox gpBoxLastActivity;
        private System.Windows.Forms.Label lbValueOfLastActivity;
        private System.Windows.Forms.Label lbDateOfLastActivity;
        private System.Windows.Forms.Label lbTimeOfLastActivity;
        private System.Windows.Forms.TextBox txtBoxMapLastTime;
        private System.Windows.Forms.ToolStripMenuItem RestartMenu;
        private System.Windows.Forms.TabPage Мониторинг;
        private System.Windows.Forms.GroupBox grBoxMonitoringSettings;
        private System.Windows.Forms.GroupBox gpBoxSensorsView;
        private System.Windows.Forms.RadioButton rButtonAllSensors;
        private System.Windows.Forms.RadioButton rButtonChooseSensors;
        private System.Windows.Forms.ProgressBar progressBarLoadDataFromDB;
        private System.Windows.Forms.GroupBox grBoxDataView;
        private System.Windows.Forms.RadioButton rButtonAllDates;
        private System.Windows.Forms.RadioButton rButtonChooseDate;
        private System.Windows.Forms.GroupBox grBoxCurrentSensor;
        private System.Windows.Forms.TextBox txtBoxCurrentSensor;
        private System.Windows.Forms.GroupBox grBoxGettingData;
        private System.Windows.Forms.DataGridView dgvQuizResult;
        private System.Windows.Forms.GroupBox grBoxMonitoringFiltration;
        private System.Windows.Forms.RichTextBox rtbLogs;
        private System.Windows.Forms.GroupBox grBoxLogs;
        private System.Windows.Forms.ToolStripMenuItem SaveAsMenu;
        private System.Windows.Forms.GroupBox grBoxMonitoringType;
        private System.Windows.Forms.ComboBox comboBoxMonitoringType;
        private System.Windows.Forms.GroupBox gpBoxSensorQuery;
        private System.Windows.Forms.ProgressBar progressBarMonitoring;
        private System.Windows.Forms.Button btnSelectSensorsForRequest;
        private System.Windows.Forms.Button btnRequestNetwork;
        private System.Windows.Forms.GroupBox grBoxMonitoringMap;
        private GMap.NET.WindowsForms.GMapControl sensorMonitoringMap;
        private System.Windows.Forms.GroupBox grBoxMap;
        private System.Windows.Forms.GroupBox grBoxInterval;
        private System.Windows.Forms.ComboBox comboBoxSelectQuizInterval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIntervalFrom;
        private System.Windows.Forms.GroupBox grBoxQuizResult;
        private System.Windows.Forms.RadioButton radioBtnOnlySave;
        private System.Windows.Forms.RadioButton radioBtnOnlyShow;
        private System.Windows.Forms.RadioButton radioBtnSaveAndShow;
        private System.Windows.Forms.RichTextBox rtbSensorsCountQuiz;
        private System.Windows.Forms.RichTextBox rtbDataCountQuiz;
        private System.Windows.Forms.RichTextBox rtbSelectedSensorsCount;
        private System.Windows.Forms.RichTextBox rtbQuizNumber;
        private System.Windows.Forms.Button btnFiltration;
        private System.Windows.Forms.GroupBox grBoxFiltrationBySensorName;
        private System.Windows.Forms.Button btnSelectSensorsForаFiltration;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
    }
}

