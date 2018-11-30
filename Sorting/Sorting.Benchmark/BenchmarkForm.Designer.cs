namespace Sort.Benchmark
{
	partial class BenchmarkForm
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
			this.menuStripBench = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuItemBench = new System.Windows.Forms.ToolStripMenuItem();
			this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.shuffleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStripBench.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStripBench
			// 
			this.menuStripBench.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemBench,
            this.optionsToolStripMenuItem,
            this.optionsToolStripMenuItem1});
			this.menuStripBench.Location = new System.Drawing.Point(0, 0);
			this.menuStripBench.Name = "menuStripBench";
			this.menuStripBench.Size = new System.Drawing.Size(553, 24);
			this.menuStripBench.TabIndex = 0;
			this.menuStripBench.Text = "menuStripBench";
			// 
			// toolStripMenuItemBench
			// 
			this.toolStripMenuItemBench.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.shuffleToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
			this.toolStripMenuItemBench.Name = "toolStripMenuItemBench";
			this.toolStripMenuItemBench.Size = new System.Drawing.Size(52, 20);
			this.toolStripMenuItemBench.Text = "Bench";
			// 
			// startToolStripMenuItem
			// 
			this.startToolStripMenuItem.Name = "startToolStripMenuItem";
			this.startToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.startToolStripMenuItem.Text = "Start";
			this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
			// 
			// stopToolStripMenuItem
			// 
			this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
			this.stopToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.stopToolStripMenuItem.Text = "Stop";
			this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
			// 
			// shuffleToolStripMenuItem
			// 
			this.shuffleToolStripMenuItem.Name = "shuffleToolStripMenuItem";
			this.shuffleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.shuffleToolStripMenuItem.Text = "Shuffle";
			this.shuffleToolStripMenuItem.Click += new System.EventHandler(this.shuffleToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
			// 
			// optionsToolStripMenuItem1
			// 
			this.optionsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem2});
			this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
			this.optionsToolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
			this.optionsToolStripMenuItem1.Text = "Options";
			// 
			// optionsToolStripMenuItem2
			// 
			this.optionsToolStripMenuItem2.Name = "optionsToolStripMenuItem2";
			this.optionsToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
			this.optionsToolStripMenuItem2.Text = "Options";
			this.optionsToolStripMenuItem2.Click += new System.EventHandler(this.optionsToolStripMenuItem2_Click);
			// 
			// BenchmarkForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(553, 374);
			this.Controls.Add(this.menuStripBench);
			this.MainMenuStrip = this.menuStripBench;
			this.Name = "BenchmarkForm";
			this.Text = "Sorting algorithms benchmark";
			this.menuStripBench.ResumeLayout(false);
			this.menuStripBench.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStripBench;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBench;
		private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem shuffleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem2;
	}
}