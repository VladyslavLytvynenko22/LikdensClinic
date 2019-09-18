namespace LikdensClinic.View
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.відкритиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оновитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зареєструватиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flwLytPnlMain = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.відкритиToolStripMenuItem,
            this.видалитиToolStripMenuItem,
            this.оновитиToolStripMenuItem,
            this.зареєструватиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // відкритиToolStripMenuItem
            // 
            this.відкритиToolStripMenuItem.Name = "відкритиToolStripMenuItem";
            this.відкритиToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.відкритиToolStripMenuItem.Text = "Відкрити";
            this.відкритиToolStripMenuItem.Click += new System.EventHandler(this.відкритиToolStripMenuItem_Click);
            // 
            // видалитиToolStripMenuItem
            // 
            this.видалитиToolStripMenuItem.Name = "видалитиToolStripMenuItem";
            this.видалитиToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.видалитиToolStripMenuItem.Text = "Видалити";
            this.видалитиToolStripMenuItem.Click += new System.EventHandler(this.видалитиToolStripMenuItem_Click);
            // 
            // оновитиToolStripMenuItem
            // 
            this.оновитиToolStripMenuItem.Name = "оновитиToolStripMenuItem";
            this.оновитиToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.оновитиToolStripMenuItem.Text = "Оновити";
            this.оновитиToolStripMenuItem.Click += new System.EventHandler(this.оновитиToolStripMenuItem_Click);
            // 
            // зареєструватиToolStripMenuItem
            // 
            this.зареєструватиToolStripMenuItem.Name = "зареєструватиToolStripMenuItem";
            this.зареєструватиToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.зареєструватиToolStripMenuItem.Text = "Зареєструвати";
            this.зареєструватиToolStripMenuItem.Click += new System.EventHandler(this.зареєструватиToolStripMenuItem_Click);
            // 
            // flwLytPnlMain
            // 
            this.flwLytPnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flwLytPnlMain.AutoScroll = true;
            this.flwLytPnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.flwLytPnlMain.Location = new System.Drawing.Point(350, 42);
            this.flwLytPnlMain.Name = "flwLytPnlMain";
            this.flwLytPnlMain.Size = new System.Drawing.Size(300, 419);
            this.flwLytPnlMain.TabIndex = 7;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.flwLytPnlMain);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainView";
            this.Text = "Likdens Dental Clinic";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem відкритиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видалитиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оновитиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зареєструватиToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flwLytPnlMain;
    }
}