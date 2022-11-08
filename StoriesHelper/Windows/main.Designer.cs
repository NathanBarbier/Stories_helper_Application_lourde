
namespace StoriesHelper.Windows
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.collaboratorsButton = new System.Windows.Forms.Button();
            this.sideBarBackground = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.DisconectButton = new System.Windows.Forms.Button();
            this.ApplicationNamePanel = new System.Windows.Forms.Panel();
            this.StoriesHelperLabel2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StoriesHelperLabel1 = new System.Windows.Forms.Label();
            this.organisationButton = new System.Windows.Forms.Button();
            this.sideBarBackground.SuspendLayout();
            this.ApplicationNamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // collaboratorsButton
            // 
            this.collaboratorsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.collaboratorsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collaboratorsButton.ForeColor = System.Drawing.Color.Black;
            this.collaboratorsButton.Location = new System.Drawing.Point(0, 261);
            this.collaboratorsButton.Margin = new System.Windows.Forms.Padding(2);
            this.collaboratorsButton.Name = "collaboratorsButton";
            this.collaboratorsButton.Size = new System.Drawing.Size(302, 110);
            this.collaboratorsButton.TabIndex = 2;
            this.collaboratorsButton.Text = "Collaborateurs";
            this.collaboratorsButton.UseVisualStyleBackColor = true;
            this.collaboratorsButton.Click += new System.EventHandler(this.collaboratorsButton_Click);
            this.collaboratorsButton.MouseEnter += new System.EventHandler(this.buttonEnter);
            this.collaboratorsButton.MouseLeave += new System.EventHandler(this.buttonLeave);
            // 
            // sideBarBackground
            // 
            this.sideBarBackground.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sideBarBackground.Controls.Add(this.button1);
            this.sideBarBackground.Controls.Add(this.button2);
            this.sideBarBackground.Controls.Add(this.DisconectButton);
            this.sideBarBackground.Controls.Add(this.ApplicationNamePanel);
            this.sideBarBackground.Controls.Add(this.organisationButton);
            this.sideBarBackground.Controls.Add(this.collaboratorsButton);
            this.sideBarBackground.ForeColor = System.Drawing.Color.DodgerBlue;
            this.sideBarBackground.Location = new System.Drawing.Point(-1, -1);
            this.sideBarBackground.Margin = new System.Windows.Forms.Padding(2);
            this.sideBarBackground.Name = "sideBarBackground";
            this.sideBarBackground.Size = new System.Drawing.Size(300, 901);
            this.sideBarBackground.TabIndex = 0;
            this.sideBarBackground.TabStop = true;
            this.sideBarBackground.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(0, 370);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(302, 110);
            this.button1.TabIndex = 6;
            this.button1.Text = "Journal d\'activité";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.LogButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(0, 846);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 56);
            this.button2.TabIndex = 4;
            this.button2.Text = "Quitter";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.QuitButton_Click);
            this.button2.MouseEnter += new System.EventHandler(this.buttonEnter);
            this.button2.MouseLeave += new System.EventHandler(this.buttonLeave);
            // 
            // DisconectButton
            // 
            this.DisconectButton.BackColor = System.Drawing.Color.Transparent;
            this.DisconectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DisconectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisconectButton.ForeColor = System.Drawing.Color.Black;
            this.DisconectButton.Location = new System.Drawing.Point(150, 846);
            this.DisconectButton.Margin = new System.Windows.Forms.Padding(2);
            this.DisconectButton.Name = "DisconectButton";
            this.DisconectButton.Size = new System.Drawing.Size(151, 56);
            this.DisconectButton.TabIndex = 5;
            this.DisconectButton.Text = "Déconnecter";
            this.DisconectButton.UseVisualStyleBackColor = false;
            this.DisconectButton.Click += new System.EventHandler(this.Disconnect_button_Click);
            this.DisconectButton.MouseEnter += new System.EventHandler(this.buttonEnter);
            this.DisconectButton.MouseLeave += new System.EventHandler(this.buttonLeave);
            // 
            // ApplicationNamePanel
            // 
            this.ApplicationNamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ApplicationNamePanel.Controls.Add(this.StoriesHelperLabel2);
            this.ApplicationNamePanel.Controls.Add(this.pictureBox1);
            this.ApplicationNamePanel.Controls.Add(this.StoriesHelperLabel1);
            this.ApplicationNamePanel.ForeColor = System.Drawing.SystemColors.Control;
            this.ApplicationNamePanel.Location = new System.Drawing.Point(1, 1);
            this.ApplicationNamePanel.Margin = new System.Windows.Forms.Padding(2);
            this.ApplicationNamePanel.Name = "ApplicationNamePanel";
            this.ApplicationNamePanel.Size = new System.Drawing.Size(301, 151);
            this.ApplicationNamePanel.TabIndex = 3;
            this.ApplicationNamePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // StoriesHelperLabel2
            // 
            this.StoriesHelperLabel2.AutoSize = true;
            this.StoriesHelperLabel2.Font = new System.Drawing.Font("Brush Script MT", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoriesHelperLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StoriesHelperLabel2.Location = new System.Drawing.Point(31, 71);
            this.StoriesHelperLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StoriesHelperLabel2.Name = "StoriesHelperLabel2";
            this.StoriesHelperLabel2.Size = new System.Drawing.Size(134, 59);
            this.StoriesHelperLabel2.TabIndex = 4;
            this.StoriesHelperLabel2.Text = "Helper";
            this.StoriesHelperLabel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(163, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(8);
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // StoriesHelperLabel1
            // 
            this.StoriesHelperLabel1.AutoSize = true;
            this.StoriesHelperLabel1.BackColor = System.Drawing.Color.Transparent;
            this.StoriesHelperLabel1.Font = new System.Drawing.Font("Brush Script MT", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoriesHelperLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StoriesHelperLabel1.Location = new System.Drawing.Point(8, 9);
            this.StoriesHelperLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StoriesHelperLabel1.Name = "StoriesHelperLabel1";
            this.StoriesHelperLabel1.Size = new System.Drawing.Size(144, 59);
            this.StoriesHelperLabel1.TabIndex = 3;
            this.StoriesHelperLabel1.Text = "Stories";
            this.StoriesHelperLabel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // organisationButton
            // 
            this.organisationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.organisationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.organisationButton.ForeColor = System.Drawing.Color.Black;
            this.organisationButton.Location = new System.Drawing.Point(0, 152);
            this.organisationButton.Margin = new System.Windows.Forms.Padding(2);
            this.organisationButton.Name = "organisationButton";
            this.organisationButton.Size = new System.Drawing.Size(302, 110);
            this.organisationButton.TabIndex = 1;
            this.organisationButton.Text = "Organisation";
            this.organisationButton.UseVisualStyleBackColor = true;
            this.organisationButton.Click += new System.EventHandler(this.organisationButton_Click);
            this.organisationButton.MouseEnter += new System.EventHandler(this.buttonEnter);
            this.organisationButton.MouseLeave += new System.EventHandler(this.buttonLeave);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1400, 900);
            this.Controls.Add(this.sideBarBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Storie Helper";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.sideBarBackground.ResumeLayout(false);
            this.ApplicationNamePanel.ResumeLayout(false);
            this.ApplicationNamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button collaboratorsButton;
        private System.Windows.Forms.Panel sideBarBackground;
        private System.Windows.Forms.Button organisationButton;
        private System.Windows.Forms.Panel ApplicationNamePanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label StoriesHelperLabel1;
        private System.Windows.Forms.Label StoriesHelperLabel2;
        private System.Windows.Forms.Button DisconectButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}