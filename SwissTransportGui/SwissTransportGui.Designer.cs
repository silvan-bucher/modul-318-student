﻿namespace SwissTransportGui
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelFrom = new System.Windows.Forms.Label();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.labelTo = new System.Windows.Forms.Label();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTime = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanelConnections = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSearchConnections = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(416, 507);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonSearchConnections);
            this.tabPage1.Controls.Add(this.tableLayoutPanelConnections);
            this.tabPage1.Controls.Add(this.dateTimePickerTime);
            this.tabPage1.Controls.Add(this.dateTimePickerDate);
            this.tabPage1.Controls.Add(this.labelTime);
            this.tabPage1.Controls.Add(this.labelDate);
            this.tabPage1.Controls.Add(this.textBoxTo);
            this.tabPage1.Controls.Add(this.labelTo);
            this.tabPage1.Controls.Add(this.textBoxFrom);
            this.tabPage1.Controls.Add(this.labelFrom);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(408, 481);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Verbindungen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(408, 481);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Abfahrtsplan";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(47, 11);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(140, 20);
            this.textBoxFrom.TabIndex = 1;
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
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(47, 46);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(140, 20);
            this.textBoxTo.TabIndex = 3;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(216, 14);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(38, 13);
            this.labelDate.TabIndex = 4;
            this.labelDate.Text = "Datum";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(217, 49);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(25, 13);
            this.labelTime.TabIndex = 5;
            this.labelTime.Text = "Zeit";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.CustomFormat = "";
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDate.Location = new System.Drawing.Point(260, 11);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(140, 20);
            this.dateTimePickerDate.TabIndex = 6;
            // 
            // dateTimePickerTime
            // 
            this.dateTimePickerTime.CustomFormat = "";
            this.dateTimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerTime.Location = new System.Drawing.Point(260, 46);
            this.dateTimePickerTime.Name = "dateTimePickerTime";
            this.dateTimePickerTime.ShowUpDown = true;
            this.dateTimePickerTime.Size = new System.Drawing.Size(140, 20);
            this.dateTimePickerTime.TabIndex = 7;
            // 
            // tableLayoutPanelConnections
            // 
            this.tableLayoutPanelConnections.ColumnCount = 3;
            this.tableLayoutPanelConnections.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.96144F));
            this.tableLayoutPanelConnections.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.tableLayoutPanelConnections.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanelConnections.Location = new System.Drawing.Point(11, 122);
            this.tableLayoutPanelConnections.Name = "tableLayoutPanelConnections";
            this.tableLayoutPanelConnections.RowCount = 1;
            this.tableLayoutPanelConnections.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelConnections.Size = new System.Drawing.Size(389, 351);
            this.tableLayoutPanelConnections.TabIndex = 8;
            // 
            // buttonSearchConnections
            // 
            this.buttonSearchConnections.Location = new System.Drawing.Point(11, 85);
            this.buttonSearchConnections.Name = "buttonSearchConnections";
            this.buttonSearchConnections.Size = new System.Drawing.Size(389, 23);
            this.buttonSearchConnections.TabIndex = 9;
            this.buttonSearchConnections.Text = "Suchen";
            this.buttonSearchConnections.UseVisualStyleBackColor = true;
            this.buttonSearchConnections.Click += new System.EventHandler(this.buttonSearchConnections_Click);
            // 
            // SwissTransportGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 507);
            this.Controls.Add(this.tabControl1);
            this.Name = "SwissTransportGui";
            this.Text = "SwissTransport";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerTime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelConnections;
        private System.Windows.Forms.Button buttonSearchConnections;
    }
}

