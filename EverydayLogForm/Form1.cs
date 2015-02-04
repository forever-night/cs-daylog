using System;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace EverydayLogForm
{
	public partial class Form1 : Form
	{
		string fileName, time, toWrite, readBytes;	
		string fullPath;	// will contain fileName
		string logPath;		// fullPath w/out fileName
		string defaultPath = @"D:\test\";

		
		string directoryForPath =
			Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
			@"\everydaylogsavepath.txt";


		public Form1()
		{
			System.Windows.Forms.Timer clock = new System.Windows.Forms.Timer();
			clock.Interval = 1000;
			clock.Tick += ChangeTime;

			clock.Start();

			
			fileName = DateTime.Now.ToString("dd-MM") + ".txt";		


			InitializeComponent();

			System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
			timer.Interval = 900000;	// 15 minutes
			timer.Tick += OnTick;

			timer.Start();

			
			lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
			
			
			logPath = CheckLogPath();
			if (logPath == "0")
				lblDirectory.Text = defaultPath + DateTime.Now.ToString("dd-MM") + ".txt";
			else
				lblDirectory.Text = logPath + DateTime.Now.ToString("dd-MM") + ".txt";
		}

		
		public string CheckLogPath()
		{			
			StreamWriter writer = new StreamWriter(directoryForPath, true);

			writer.Write(String.Empty);
			writer.Flush();
			writer.Close();

			StreamReader readLogPath = new StreamReader(directoryForPath);

			readBytes = readLogPath.ReadLine();			

			readLogPath.Close();


			if (readBytes != null)
				logPath = readBytes;
			else
				logPath = "0";

			return logPath;
		}

		
		private void OnTick(Object o, EventArgs e)
		{
			Console.Beep(600, 600);
			time = DateTime.Now.ToString("HH:mm:ss");
			lblTime.Text = time;
			lblStatus.Text = "";
		}

		
		private void ChangeTime(Object o, EventArgs e)
		{
			lblCurrentDateTime.Text = DateTime.Now.ToString("dd/MM, HH:mm:ss");
		}


		// hotkeys
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (keyData == (Keys.Control | Keys.S))
				btnSave.PerformClick();

			if (keyData == Keys.Escape)
				btnClose.PerformClick();


			return base.ProcessCmdKey(ref msg, keyData);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			fileName = DateTime.Now.ToString("dd-MM") + ".txt";

			
			if (!lblDirectory.Text.EndsWith(@".txt"))
				fullPath = lblDirectory.Text + fileName;
			else
				fullPath = lblDirectory.Text;


			StreamWriter writer = new StreamWriter(fullPath, true);
			toWrite = tbActivity.Text;

			// ! don't use string time instead of lblTime.Text, returns null
			writer.WriteLine("[" + lblTime.Text + "]   " + toWrite);		
			writer.Flush();
			writer.Close();

			tbActivity.Clear();
			lblStatus.Text = "saved";
		}


		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		
		private void folderPath_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				this.lblDirectory.Text = folderBrowserDialog1.SelectedPath;

				logPath = lblDirectory.Text;
				if (!logPath.EndsWith(@"\"))
					logPath += @"\";

				
				StreamWriter savePathWriter = new StreamWriter(directoryForPath, false);
			
				savePathWriter.Write(logPath);
				savePathWriter.Flush();
				savePathWriter.Close();

				
				if (!lblDirectory.Text.EndsWith(@"\"))
					lblDirectory.Text += @"\";
				

				lblDirectory.Text += DateTime.Now.ToString("dd-MM") + ".txt";
			}
		}
	}
}
