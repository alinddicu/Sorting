namespace Sort.Benchmark
{
	partial class OptionsForm
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
			this.maxValuesToSortTrackBar = new System.Windows.Forms.TrackBar();
			this.drawDelayTrackBar = new System.Windows.Forms.TrackBar();
			this.maxValuesToSortLabel = new System.Windows.Forms.Label();
			this.drawDelayLabel = new System.Windows.Forms.Label();
			this.saveButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.maxValuesToSortTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.drawDelayTrackBar)).BeginInit();
			this.SuspendLayout();
			// 
			// maxValuesToSortTrackBar
			// 
			this.maxValuesToSortTrackBar.LargeChange = 100;
			this.maxValuesToSortTrackBar.Location = new System.Drawing.Point(12, 53);
			this.maxValuesToSortTrackBar.Name = "maxValuesToSortTrackBar";
			this.maxValuesToSortTrackBar.Size = new System.Drawing.Size(260, 45);
			this.maxValuesToSortTrackBar.SmallChange = 100;
			this.maxValuesToSortTrackBar.TabIndex = 0;
			// 
			// drawDelayTrackBar
			// 
			this.drawDelayTrackBar.LargeChange = 50;
			this.drawDelayTrackBar.Location = new System.Drawing.Point(12, 117);
			this.drawDelayTrackBar.Name = "drawDelayTrackBar";
			this.drawDelayTrackBar.Size = new System.Drawing.Size(260, 45);
			this.drawDelayTrackBar.SmallChange = 50;
			this.drawDelayTrackBar.TabIndex = 1;
			// 
			// maxValuesToSortLabel
			// 
			this.maxValuesToSortLabel.AutoSize = true;
			this.maxValuesToSortLabel.Location = new System.Drawing.Point(13, 34);
			this.maxValuesToSortLabel.Name = "maxValuesToSortLabel";
			this.maxValuesToSortLabel.Size = new System.Drawing.Size(93, 13);
			this.maxValuesToSortLabel.TabIndex = 2;
			this.maxValuesToSortLabel.Text = "Max values to sort";
			// 
			// drawDelayLabel
			// 
			this.drawDelayLabel.AutoSize = true;
			this.drawDelayLabel.Location = new System.Drawing.Point(13, 101);
			this.drawDelayLabel.Name = "drawDelayLabel";
			this.drawDelayLabel.Size = new System.Drawing.Size(60, 13);
			this.drawDelayLabel.TabIndex = 3;
			this.drawDelayLabel.Text = "Draw delay";
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(197, 195);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(75, 23);
			this.saveButton.TabIndex = 4;
			this.saveButton.Text = "Save";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.Location = new System.Drawing.Point(116, 195);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 5;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// OptionsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 230);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.drawDelayLabel);
			this.Controls.Add(this.maxValuesToSortLabel);
			this.Controls.Add(this.drawDelayTrackBar);
			this.Controls.Add(this.maxValuesToSortTrackBar);
			this.Name = "OptionsForm";
			this.Text = "Options";
			((System.ComponentModel.ISupportInitialize)(this.maxValuesToSortTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.drawDelayTrackBar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TrackBar maxValuesToSortTrackBar;
		private System.Windows.Forms.TrackBar drawDelayTrackBar;
		private System.Windows.Forms.Label maxValuesToSortLabel;
		private System.Windows.Forms.Label drawDelayLabel;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Button cancelButton;
	}
}