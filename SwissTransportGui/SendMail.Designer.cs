namespace SwissTransportGui
{
    partial class SendMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendMail));
            this.labelAddressee = new System.Windows.Forms.Label();
            this.textBoxAddressee = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAddressee
            // 
            this.labelAddressee.AutoSize = true;
            this.labelAddressee.Location = new System.Drawing.Point(12, 9);
            this.labelAddressee.Name = "labelAddressee";
            this.labelAddressee.Size = new System.Drawing.Size(58, 13);
            this.labelAddressee.TabIndex = 1;
            this.labelAddressee.Text = "Empfänger";
            // 
            // textBoxAddressee
            // 
            this.textBoxAddressee.Location = new System.Drawing.Point(76, 6);
            this.textBoxAddressee.Name = "textBoxAddressee";
            this.textBoxAddressee.Size = new System.Drawing.Size(290, 20);
            this.textBoxAddressee.TabIndex = 2;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(12, 41);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(351, 23);
            this.buttonSend.TabIndex = 5;
            this.buttonSend.Text = "Senden";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // SendMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 76);
            this.ControlBox = false;
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxAddressee);
            this.Controls.Add(this.labelAddressee);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SendMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Senden";
            this.Load += new System.EventHandler(this.SendMail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelAddressee;
        private System.Windows.Forms.TextBox textBoxAddressee;
        private System.Windows.Forms.Button buttonSend;
    }
}