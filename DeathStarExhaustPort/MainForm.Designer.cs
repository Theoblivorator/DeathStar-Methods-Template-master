namespace DeathStarExhaustPort
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.fullButton = new System.Windows.Forms.Button();
            this.partButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fullButton
            // 
            this.fullButton.Location = new System.Drawing.Point(436, 438);
            this.fullButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fullButton.Name = "fullButton";
            this.fullButton.Size = new System.Drawing.Size(50, 26);
            this.fullButton.TabIndex = 0;
            this.fullButton.Text = "Full";
            this.fullButton.UseVisualStyleBackColor = true;
            this.fullButton.Click += new System.EventHandler(this.fullButton_Click);
            // 
            // partButton
            // 
            this.partButton.Location = new System.Drawing.Point(436, 402);
            this.partButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.partButton.Name = "partButton";
            this.partButton.Size = new System.Drawing.Size(50, 26);
            this.partButton.TabIndex = 1;
            this.partButton.Text = "Part";
            this.partButton.UseVisualStyleBackColor = true;
            this.partButton.Click += new System.EventHandler(this.partButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::DeathStarExhaustPort.Properties.Resources.RebelSymbol;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(494, 472);
            this.Controls.Add(this.partButton);
            this.Controls.Add(this.fullButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Death Star Attack Plan";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Click += new System.EventHandler(this.MainForm_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fullButton;
        private System.Windows.Forms.Button partButton;
    }
}

