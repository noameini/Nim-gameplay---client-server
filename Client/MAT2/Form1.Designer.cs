namespace Client
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.columnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolS2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolS3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolS4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolS5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolS6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolS7 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.columnsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(263, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // columnsToolStripMenuItem
            // 
            this.columnsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolS2,
            this.toolS3,
            this.toolS4,
            this.toolS5,
            this.toolS6,
            this.toolS7});
            this.columnsToolStripMenuItem.Name = "columnsToolStripMenuItem";
            this.columnsToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.columnsToolStripMenuItem.Text = "Columns";
            // 
            // toolS2
            // 
            this.toolS2.Name = "toolS2";
            this.toolS2.Size = new System.Drawing.Size(80, 22);
            this.toolS2.Text = "2";
            this.toolS2.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolS3
            // 
            this.toolS3.Name = "toolS3";
            this.toolS3.Size = new System.Drawing.Size(80, 22);
            this.toolS3.Text = "3";
            this.toolS3.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolS4
            // 
            this.toolS4.Name = "toolS4";
            this.toolS4.Size = new System.Drawing.Size(80, 22);
            this.toolS4.Text = "4";
            this.toolS4.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolS5
            // 
            this.toolS5.Name = "toolS5";
            this.toolS5.Size = new System.Drawing.Size(80, 22);
            this.toolS5.Text = "5";
            this.toolS5.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolS6
            // 
            this.toolS6.Name = "toolS6";
            this.toolS6.Size = new System.Drawing.Size(80, 22);
            this.toolS6.Text = "6";
            this.toolS6.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolS7
            // 
            this.toolS7.Name = "toolS7";
            this.toolS7.Size = new System.Drawing.Size(80, 22);
            this.toolS7.Text = "7";
            this.toolS7.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(263, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem columnsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolS2;
        private System.Windows.Forms.ToolStripMenuItem toolS3;
        private System.Windows.Forms.ToolStripMenuItem toolS4;
        private System.Windows.Forms.ToolStripMenuItem toolS5;
        private System.Windows.Forms.ToolStripMenuItem toolS6;
        private System.Windows.Forms.ToolStripMenuItem toolS7;
    }
}

