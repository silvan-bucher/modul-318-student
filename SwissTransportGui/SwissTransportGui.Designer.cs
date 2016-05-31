namespace SwissTransportGui
{
    partial class SwissTransportGui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SwissTransportGui));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageConnections = new System.Windows.Forms.TabPage();
            this.dateTimePickerTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.buttonSearchConnections = new System.Windows.Forms.Button();
            this.tableLayoutPanelConnections = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.labelTo = new System.Windows.Forms.Label();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.labelFrom = new System.Windows.Forms.Label();
            this.tabPageDepartures = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelDepartures = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxStation = new System.Windows.Forms.TextBox();
            this.labelStation = new System.Windows.Forms.Label();
            this.tabPageMap = new System.Windows.Forms.TabPage();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.buttonSearchStation = new System.Windows.Forms.Button();
            this.textBoxStationSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.tabControl1.SuspendLayout();
            this.tabPageConnections.SuspendLayout();
            this.tabPageDepartures.SuspendLayout();
            this.tabPageMap.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageConnections);
            this.tabControl1.Controls.Add(this.tabPageDepartures);
            this.tabControl1.Controls.Add(this.tabPageMap);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(416, 279);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageConnections
            // 
            this.tabPageConnections.Controls.Add(this.dateTimePickerTime);
            this.tabPageConnections.Controls.Add(this.dateTimePickerDate);
            this.tabPageConnections.Controls.Add(this.labelTime);
            this.tabPageConnections.Controls.Add(this.labelDate);
            this.tabPageConnections.Controls.Add(this.buttonSearchConnections);
            this.tabPageConnections.Controls.Add(this.tableLayoutPanelConnections);
            this.tabPageConnections.Controls.Add(this.textBoxTo);
            this.tabPageConnections.Controls.Add(this.labelTo);
            this.tabPageConnections.Controls.Add(this.textBoxFrom);
            this.tabPageConnections.Controls.Add(this.labelFrom);
            this.tabPageConnections.Location = new System.Drawing.Point(4, 22);
            this.tabPageConnections.Name = "tabPageConnections";
            this.tabPageConnections.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConnections.Size = new System.Drawing.Size(408, 253);
            this.tabPageConnections.TabIndex = 0;
            this.tabPageConnections.Text = "Verbindungen";
            this.tabPageConnections.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerTime
            // 
            this.dateTimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerTime.Location = new System.Drawing.Point(246, 47);
            this.dateTimePickerTime.Name = "dateTimePickerTime";
            this.dateTimePickerTime.ShowUpDown = true;
            this.dateTimePickerTime.Size = new System.Drawing.Size(153, 20);
            this.dateTimePickerTime.TabIndex = 13;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDate.Location = new System.Drawing.Point(247, 11);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(153, 20);
            this.dateTimePickerDate.TabIndex = 12;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(203, 49);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(25, 13);
            this.labelTime.TabIndex = 11;
            this.labelTime.Text = "Zeit";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(203, 14);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(38, 13);
            this.labelDate.TabIndex = 10;
            this.labelDate.Text = "Datum";
            // 
            // buttonSearchConnections
            // 
            this.buttonSearchConnections.Location = new System.Drawing.Point(11, 83);
            this.buttonSearchConnections.Name = "buttonSearchConnections";
            this.buttonSearchConnections.Size = new System.Drawing.Size(389, 23);
            this.buttonSearchConnections.TabIndex = 9;
            this.buttonSearchConnections.Text = "Suchen";
            this.buttonSearchConnections.UseVisualStyleBackColor = true;
            this.buttonSearchConnections.Click += new System.EventHandler(this.buttonSearchConnections_Click);
            // 
            // tableLayoutPanelConnections
            // 
            this.tableLayoutPanelConnections.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelConnections.ColumnCount = 4;
            this.tableLayoutPanelConnections.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanelConnections.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanelConnections.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanelConnections.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanelConnections.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelConnections.Location = new System.Drawing.Point(11, 122);
            this.tableLayoutPanelConnections.Name = "tableLayoutPanelConnections";
            this.tableLayoutPanelConnections.RowCount = 1;
            this.tableLayoutPanelConnections.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelConnections.Size = new System.Drawing.Size(389, 121);
            this.tableLayoutPanelConnections.TabIndex = 8;
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(47, 46);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(150, 20);
            this.textBoxTo.TabIndex = 3;
            this.textBoxTo.TextChanged += new System.EventHandler(this.textBoxTo_TextChanged);
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(8, 49);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(33, 13);
            this.labelTo.TabIndex = 2;
            this.labelTo.Text = "Nach";
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(47, 11);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(150, 20);
            this.textBoxFrom.TabIndex = 1;
            this.textBoxFrom.TextChanged += new System.EventHandler(this.textBoxFrom_TextChanged);
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(8, 14);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(26, 13);
            this.labelFrom.TabIndex = 0;
            this.labelFrom.Text = "Von";
            // 
            // tabPageDepartures
            // 
            this.tabPageDepartures.Controls.Add(this.tableLayoutPanelDepartures);
            this.tabPageDepartures.Controls.Add(this.buttonSearch);
            this.tabPageDepartures.Controls.Add(this.textBoxStation);
            this.tabPageDepartures.Controls.Add(this.labelStation);
            this.tabPageDepartures.Location = new System.Drawing.Point(4, 22);
            this.tabPageDepartures.Name = "tabPageDepartures";
            this.tabPageDepartures.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDepartures.Size = new System.Drawing.Size(408, 253);
            this.tabPageDepartures.TabIndex = 1;
            this.tabPageDepartures.Text = "Abfahrtsplan";
            this.tabPageDepartures.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelDepartures
            // 
            this.tableLayoutPanelDepartures.AutoScroll = true;
            this.tableLayoutPanelDepartures.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelDepartures.ColumnCount = 3;
            this.tableLayoutPanelDepartures.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelDepartures.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tableLayoutPanelDepartures.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPanelDepartures.Location = new System.Drawing.Point(11, 87);
            this.tableLayoutPanelDepartures.Name = "tableLayoutPanelDepartures";
            this.tableLayoutPanelDepartures.RowCount = 1;
            this.tableLayoutPanelDepartures.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDepartures.Size = new System.Drawing.Size(389, 158);
            this.tableLayoutPanelDepartures.TabIndex = 3;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(11, 46);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(389, 23);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Suchen";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearchDepartures_Click);
            // 
            // textBoxStation
            // 
            this.textBoxStation.Location = new System.Drawing.Point(54, 11);
            this.textBoxStation.Name = "textBoxStation";
            this.textBoxStation.Size = new System.Drawing.Size(346, 20);
            this.textBoxStation.TabIndex = 1;
            this.textBoxStation.TextChanged += new System.EventHandler(this.textBoxStation_TextChanged);
            // 
            // labelStation
            // 
            this.labelStation.AutoSize = true;
            this.labelStation.Location = new System.Drawing.Point(8, 14);
            this.labelStation.Name = "labelStation";
            this.labelStation.Size = new System.Drawing.Size(40, 13);
            this.labelStation.TabIndex = 0;
            this.labelStation.Text = "Station";
            // 
            // tabPageMap
            // 
            this.tabPageMap.Controls.Add(this.map);
            this.tabPageMap.Controls.Add(this.buttonSearchStation);
            this.tabPageMap.Controls.Add(this.textBoxStationSearch);
            this.tabPageMap.Controls.Add(this.labelSearch);
            this.tabPageMap.Location = new System.Drawing.Point(4, 22);
            this.tabPageMap.Name = "tabPageMap";
            this.tabPageMap.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMap.Size = new System.Drawing.Size(408, 253);
            this.tabPageMap.TabIndex = 2;
            this.tabPageMap.Text = "Karte";
            this.tabPageMap.UseVisualStyleBackColor = true;
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemmory = 5;
            this.map.Location = new System.Drawing.Point(11, 88);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 20;
            this.map.MinZoom = 7;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(389, 157);
            this.map.TabIndex = 3;
            this.map.Zoom = 7D;
            // 
            // buttonSearchStation
            // 
            this.buttonSearchStation.Location = new System.Drawing.Point(11, 47);
            this.buttonSearchStation.Name = "buttonSearchStation";
            this.buttonSearchStation.Size = new System.Drawing.Size(389, 23);
            this.buttonSearchStation.TabIndex = 2;
            this.buttonSearchStation.Text = "Suchen";
            this.buttonSearchStation.UseVisualStyleBackColor = true;
            this.buttonSearchStation.Click += new System.EventHandler(this.buttonSearchStation_Click);
            // 
            // textBoxStationSearch
            // 
            this.textBoxStationSearch.Location = new System.Drawing.Point(52, 12);
            this.textBoxStationSearch.Name = "textBoxStationSearch";
            this.textBoxStationSearch.Size = new System.Drawing.Size(348, 20);
            this.textBoxStationSearch.TabIndex = 1;
            this.textBoxStationSearch.TextChanged += new System.EventHandler(this.textBoxStationSearch_TextChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(8, 15);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(40, 13);
            this.labelSearch.TabIndex = 0;
            this.labelSearch.Text = "Station";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // SwissTransportGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 279);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SwissTransportGui";
            this.Text = "SwissTransport";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageConnections.ResumeLayout(false);
            this.tabPageConnections.PerformLayout();
            this.tabPageDepartures.ResumeLayout(false);
            this.tabPageDepartures.PerformLayout();
            this.tabPageMap.ResumeLayout(false);
            this.tabPageMap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageConnections;
        private System.Windows.Forms.TabPage tabPageDepartures;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelConnections;
        private System.Windows.Forms.Button buttonSearchConnections;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxStation;
        private System.Windows.Forms.Label labelStation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDepartures;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerTime;
        private System.Windows.Forms.TabPage tabPageMap;
        private System.Windows.Forms.TextBox textBoxStationSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Button buttonSearchStation;
        private GMap.NET.WindowsForms.GMapControl map;
    }
}

