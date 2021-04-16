namespace guessinggame
{
    partial class GuessingGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areYouSureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.okToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.okToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.GuessBox = new System.Windows.Forms.TextBox();
            this.GuessButton = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(756, 73);
            this.label2.TabIndex = 2;
            this.label2.Text = "GUESSING GAME !!1!1!!";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.areYouSureToolStripMenuItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // areYouSureToolStripMenuItem
            // 
            this.areYouSureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yesToolStripMenuItem,
            this.noToolStripMenuItem});
            this.areYouSureToolStripMenuItem.Name = "areYouSureToolStripMenuItem";
            this.areYouSureToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.areYouSureToolStripMenuItem.Text = "Are you sure?";
            // 
            // yesToolStripMenuItem
            // 
            this.yesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reallyToolStripMenuItem});
            this.yesToolStripMenuItem.Name = "yesToolStripMenuItem";
            this.yesToolStripMenuItem.Size = new System.Drawing.Size(91, 22);
            this.yesToolStripMenuItem.Text = "Yes";
            // 
            // reallyToolStripMenuItem
            // 
            this.reallyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.okToolStripMenuItem});
            this.reallyToolStripMenuItem.Name = "reallyToolStripMenuItem";
            this.reallyToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.reallyToolStripMenuItem.Text = "Really?";
            // 
            // okToolStripMenuItem
            // 
            this.okToolStripMenuItem.Name = "okToolStripMenuItem";
            this.okToolStripMenuItem.Size = new System.Drawing.Size(89, 22);
            this.okToolStripMenuItem.Text = "Ok";
            // 
            // noToolStripMenuItem
            // 
            this.noToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.okToolStripMenuItem1});
            this.noToolStripMenuItem.Name = "noToolStripMenuItem";
            this.noToolStripMenuItem.Size = new System.Drawing.Size(91, 22);
            this.noToolStripMenuItem.Text = "No";
            // 
            // okToolStripMenuItem1
            // 
            this.okToolStripMenuItem1.Name = "okToolStripMenuItem1";
            this.okToolStripMenuItem1.Size = new System.Drawing.Size(87, 22);
            this.okToolStripMenuItem1.Text = "ok";
            // 
            // GuessBox
            // 
            this.GuessBox.Location = new System.Drawing.Point(333, 241);
            this.GuessBox.Name = "GuessBox";
            this.GuessBox.Size = new System.Drawing.Size(100, 20);
            this.GuessBox.TabIndex = 4;
            this.GuessBox.TextChanged += new System.EventHandler(this.GuessBox_TextChanged);
            // 
            // GuessButton
            // 
            this.GuessButton.Location = new System.Drawing.Point(342, 312);
            this.GuessButton.Name = "GuessButton";
            this.GuessButton.Size = new System.Drawing.Size(75, 23);
            this.GuessButton.TabIndex = 5;
            this.GuessButton.Text = "Guess";
            this.GuessButton.UseVisualStyleBackColor = true;
            this.GuessButton.Click += new System.EventHandler(this.GuessButton_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Black;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label.Location = new System.Drawing.Point(3, 120);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(214, 55);
            this.label.TabIndex = 6;
            this.label.Text = "Guesses";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(593, 120);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // GuessingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImage = global::guessinggame.Properties.Resources.terry_crews_is_jacked;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.GuessButton);
            this.Controls.Add(this.GuessBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GuessingGame";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GuessingGame_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem areYouSureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem okToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem okToolStripMenuItem1;
        private System.Windows.Forms.TextBox GuessBox;
        private System.Windows.Forms.Button GuessButton;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ListBox listBox1;
    }
}

