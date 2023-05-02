namespace ChatServer
{
    partial class ServerForm
    {
        /// <summary>
				/// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>

        /// </summary>
        /// <param name="disposing">Значение true, если управляемые активы должны быть выведены из эксплуатации; Ложь в противном случае.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
				/// Метод, необходимый для поддержки дизайнера - не изменять
				/// его содержимое в редакторе кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.labelPort = new System.Windows.Forms.Label();
			this.textBoxPort = new System.Windows.Forms.TextBox();
			this.buttonStart = new System.Windows.Forms.Button();
			this.labelStatus = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelPort
			// 
			this.labelPort.AutoSize = true;
			this.labelPort.Location = new System.Drawing.Point(176, 9);
			this.labelPort.Name = "labelPort";
			this.labelPort.Size = new System.Drawing.Size(38, 13);
			this.labelPort.TabIndex = 1;
			this.labelPort.Text = "Порт :";
			// 
			// textBoxPort
			// 
			this.textBoxPort.Location = new System.Drawing.Point(220, 6);
			this.textBoxPort.Name = "textBoxPort";
			this.textBoxPort.Size = new System.Drawing.Size(108, 20);
			this.textBoxPort.TabIndex = 3;
			// 
			// buttonStart
			// 
			this.buttonStart.Location = new System.Drawing.Point(220, 49);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(108, 23);
			this.buttonStart.TabIndex = 4;
			this.buttonStart.Text = "Запустить сервер";
			this.buttonStart.UseVisualStyleBackColor = true;
			this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
			// 
			// labelStatus
			// 
			this.labelStatus.AutoSize = true;
			this.labelStatus.Location = new System.Drawing.Point(12, 31);
			this.labelStatus.Name = "labelStatus";
			this.labelStatus.Size = new System.Drawing.Size(103, 13);
			this.labelStatus.TabIndex = 5;
			this.labelStatus.Text = "Сервер не активен";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(340, 94);
			this.Controls.Add(this.labelStatus);
			this.Controls.Add(this.buttonStart);
			this.Controls.Add(this.textBoxPort);
			this.Controls.Add(this.labelPort);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "Server";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelStatus;
        private System.ComponentModel.BackgroundWorker backgroundWorkerUpdatelabel;
    }
}

