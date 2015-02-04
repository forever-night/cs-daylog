namespace EverydayLogForm
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
			this.lblTime = new System.Windows.Forms.Label();
			this.tbActivity = new System.Windows.Forms.TextBox();
			this.lblActivity = new System.Windows.Forms.Label();
			this.lblAboutTime = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.lblAboutDirectory = new System.Windows.Forms.Label();
			this.tbDirectory = new System.Windows.Forms.TextBox();
			this.lblCurrentDateTime = new System.Windows.Forms.Label();
			this.lblStatus = new System.Windows.Forms.Label();
			this.folderPath = new System.Windows.Forms.Button();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.lblDirectory = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblTime
			// 
			this.lblTime.AutoSize = true;
			this.lblTime.Location = new System.Drawing.Point(15, 52);
			this.lblTime.Name = "lblTime";
			this.lblTime.Size = new System.Drawing.Size(0, 13);
			this.lblTime.TabIndex = 0;
			// 
			// tbActivity
			// 
			this.tbActivity.Location = new System.Drawing.Point(126, 49);
			this.tbActivity.Name = "tbActivity";
			this.tbActivity.Size = new System.Drawing.Size(231, 20);
			this.tbActivity.TabIndex = 1;
			// 
			// lblActivity
			// 
			this.lblActivity.AutoSize = true;
			this.lblActivity.Enabled = false;
			this.lblActivity.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.lblActivity.Location = new System.Drawing.Point(126, 30);
			this.lblActivity.Name = "lblActivity";
			this.lblActivity.Size = new System.Drawing.Size(106, 13);
			this.lblActivity.TabIndex = 2;
			this.lblActivity.Text = "what are you doing?:";
			// 
			// lblAboutTime
			// 
			this.lblAboutTime.AutoSize = true;
			this.lblAboutTime.Enabled = false;
			this.lblAboutTime.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.lblAboutTime.Location = new System.Drawing.Point(15, 29);
			this.lblAboutTime.Name = "lblAboutTime";
			this.lblAboutTime.Size = new System.Drawing.Size(29, 13);
			this.lblAboutTime.TabIndex = 3;
			this.lblAboutTime.Text = "time:";
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(282, 131);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 4;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(282, 102);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 2;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// lblAboutDirectory
			// 
			this.lblAboutDirectory.AutoSize = true;
			this.lblAboutDirectory.Enabled = false;
			this.lblAboutDirectory.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.lblAboutDirectory.Location = new System.Drawing.Point(18, 89);
			this.lblAboutDirectory.Name = "lblAboutDirectory";
			this.lblAboutDirectory.Size = new System.Drawing.Size(91, 13);
			this.lblAboutDirectory.TabIndex = 7;
			this.lblAboutDirectory.Text = "Save to a folder...";
			// 
			// tbDirectory
			// 
			this.tbDirectory.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.tbDirectory.Location = new System.Drawing.Point(18, 105);
			this.tbDirectory.Name = "tbDirectory";
			this.tbDirectory.Size = new System.Drawing.Size(217, 20);
			this.tbDirectory.TabIndex = 3;
			// 
			// lblCurrentDateTime
			// 
			this.lblCurrentDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblCurrentDateTime.AutoSize = true;
			this.lblCurrentDateTime.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.lblCurrentDateTime.Location = new System.Drawing.Point(279, 10);
			this.lblCurrentDateTime.Name = "lblCurrentDateTime";
			this.lblCurrentDateTime.Size = new System.Drawing.Size(0, 13);
			this.lblCurrentDateTime.TabIndex = 9;
			this.lblCurrentDateTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.Enabled = false;
			this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblStatus.Location = new System.Drawing.Point(326, 90);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(0, 12);
			this.lblStatus.TabIndex = 10;
			// 
			// folderPath
			// 
			this.folderPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.folderPath.Location = new System.Drawing.Point(241, 102);
			this.folderPath.Name = "folderPath";
			this.folderPath.Size = new System.Drawing.Size(23, 23);
			this.folderPath.TabIndex = 11;
			this.folderPath.Text = "...";
			this.folderPath.UseVisualStyleBackColor = true;
			this.folderPath.Click += new System.EventHandler(this.folderPath_Click);
			// 
			// lblDirectory
			// 
			this.lblDirectory.AutoSize = true;
			this.lblDirectory.Location = new System.Drawing.Point(18, 131);
			this.lblDirectory.Name = "lblDirectory";
			this.lblDirectory.Size = new System.Drawing.Size(59, 13);
			this.lblDirectory.TabIndex = 12;
			this.lblDirectory.Text = "lblDirectory";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(369, 166);
			this.Controls.Add(this.lblDirectory);
			this.Controls.Add(this.folderPath);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.lblCurrentDateTime);
			this.Controls.Add(this.tbDirectory);
			this.Controls.Add(this.lblAboutDirectory);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.lblAboutTime);
			this.Controls.Add(this.lblActivity);
			this.Controls.Add(this.tbActivity);
			this.Controls.Add(this.lblTime);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximumSize = new System.Drawing.Size(385, 200);
			this.MinimumSize = new System.Drawing.Size(385, 200);
			this.Name = "Form1";
			this.Text = "EverydayLog";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTime;
		private System.Windows.Forms.TextBox tbActivity;
		private System.Windows.Forms.Label lblActivity;
		private System.Windows.Forms.Label lblAboutTime;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label lblAboutDirectory;
		private System.Windows.Forms.TextBox tbDirectory;
		private System.Windows.Forms.Label lblCurrentDateTime;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.Button folderPath;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.Label lblDirectory;

	}
}

