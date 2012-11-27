namespace SeaFight
{
    partial class GameForm
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
            this.EnemyBackground = new System.Windows.Forms.PictureBox();
            this.CurrentShip1Label = new System.Windows.Forms.Label();
            this.CurrentShip1Info = new System.Windows.Forms.Label();
            this.CurrentShip2Label = new System.Windows.Forms.Label();
            this.CurrentShip2Info = new System.Windows.Forms.Label();
            this.CurrentShip3Label = new System.Windows.Forms.Label();
            this.CurrentShip3Info = new System.Windows.Forms.Label();
            this.CurrentShip4Label = new System.Windows.Forms.Label();
            this.CurrentShip4Info = new System.Windows.Forms.Label();
            this.CurrentInfo = new System.Windows.Forms.Label();
            this.CurrentBackground = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CurrentNickLabel = new System.Windows.Forms.Label();
            this.EnemyNickLabel = new System.Windows.Forms.Label();
            this.TurnAlertLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentBackground)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnemyBackground
            // 
            this.EnemyBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EnemyBackground.Location = new System.Drawing.Point(325, 48);
            this.EnemyBackground.Name = "EnemyBackground";
            this.EnemyBackground.Size = new System.Drawing.Size(250, 250);
            this.EnemyBackground.TabIndex = 1;
            this.EnemyBackground.TabStop = false;
            // 
            // CurrentShip1Label
            // 
            this.CurrentShip1Label.AutoSize = true;
            this.CurrentShip1Label.Location = new System.Drawing.Point(253, 28);
            this.CurrentShip1Label.Name = "CurrentShip1Label";
            this.CurrentShip1Label.Size = new System.Drawing.Size(13, 13);
            this.CurrentShip1Label.TabIndex = 21;
            this.CurrentShip1Label.Text = "0";
            this.CurrentShip1Label.Visible = false;
            // 
            // CurrentShip1Info
            // 
            this.CurrentShip1Info.AutoSize = true;
            this.CurrentShip1Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentShip1Info.Location = new System.Drawing.Point(227, 28);
            this.CurrentShip1Info.Name = "CurrentShip1Info";
            this.CurrentShip1Info.Size = new System.Drawing.Size(27, 13);
            this.CurrentShip1Info.TabIndex = 20;
            this.CurrentShip1Info.Text = "1R:";
            this.CurrentShip1Info.Visible = false;
            // 
            // CurrentShip2Label
            // 
            this.CurrentShip2Label.AutoSize = true;
            this.CurrentShip2Label.Location = new System.Drawing.Point(208, 28);
            this.CurrentShip2Label.Name = "CurrentShip2Label";
            this.CurrentShip2Label.Size = new System.Drawing.Size(13, 13);
            this.CurrentShip2Label.TabIndex = 19;
            this.CurrentShip2Label.Text = "0";
            this.CurrentShip2Label.Visible = false;
            // 
            // CurrentShip2Info
            // 
            this.CurrentShip2Info.AutoSize = true;
            this.CurrentShip2Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentShip2Info.Location = new System.Drawing.Point(185, 28);
            this.CurrentShip2Info.Name = "CurrentShip2Info";
            this.CurrentShip2Info.Size = new System.Drawing.Size(27, 13);
            this.CurrentShip2Info.TabIndex = 18;
            this.CurrentShip2Info.Text = "2R:";
            this.CurrentShip2Info.Visible = false;
            // 
            // CurrentShip3Label
            // 
            this.CurrentShip3Label.AutoSize = true;
            this.CurrentShip3Label.Location = new System.Drawing.Point(166, 28);
            this.CurrentShip3Label.Name = "CurrentShip3Label";
            this.CurrentShip3Label.Size = new System.Drawing.Size(13, 13);
            this.CurrentShip3Label.TabIndex = 17;
            this.CurrentShip3Label.Text = "0";
            this.CurrentShip3Label.Visible = false;
            // 
            // CurrentShip3Info
            // 
            this.CurrentShip3Info.AutoSize = true;
            this.CurrentShip3Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentShip3Info.Location = new System.Drawing.Point(142, 28);
            this.CurrentShip3Info.Name = "CurrentShip3Info";
            this.CurrentShip3Info.Size = new System.Drawing.Size(27, 13);
            this.CurrentShip3Info.TabIndex = 16;
            this.CurrentShip3Info.Text = "3R:";
            this.CurrentShip3Info.Visible = false;
            // 
            // CurrentShip4Label
            // 
            this.CurrentShip4Label.AutoSize = true;
            this.CurrentShip4Label.Location = new System.Drawing.Point(123, 28);
            this.CurrentShip4Label.Name = "CurrentShip4Label";
            this.CurrentShip4Label.Size = new System.Drawing.Size(13, 13);
            this.CurrentShip4Label.TabIndex = 15;
            this.CurrentShip4Label.Text = "0";
            this.CurrentShip4Label.Visible = false;
            // 
            // CurrentShip4Info
            // 
            this.CurrentShip4Info.AutoSize = true;
            this.CurrentShip4Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentShip4Info.Location = new System.Drawing.Point(99, 28);
            this.CurrentShip4Info.Name = "CurrentShip4Info";
            this.CurrentShip4Info.Size = new System.Drawing.Size(27, 13);
            this.CurrentShip4Info.TabIndex = 14;
            this.CurrentShip4Info.Text = "4R:";
            this.CurrentShip4Info.Visible = false;
            // 
            // CurrentInfo
            // 
            this.CurrentInfo.AutoSize = true;
            this.CurrentInfo.Location = new System.Drawing.Point(12, 28);
            this.CurrentInfo.Name = "CurrentInfo";
            this.CurrentInfo.Size = new System.Drawing.Size(81, 13);
            this.CurrentInfo.TabIndex = 13;
            this.CurrentInfo.Text = "You are missing";
            this.CurrentInfo.Visible = false;
            // 
            // CurrentBackground
            // 
            this.CurrentBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CurrentBackground.Location = new System.Drawing.Point(12, 48);
            this.CurrentBackground.Name = "CurrentBackground";
            this.CurrentBackground.Size = new System.Drawing.Size(250, 250);
            this.CurrentBackground.TabIndex = 12;
            this.CurrentBackground.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(567, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "0";
            this.label1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(541, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "1R:";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(522, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "0";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(499, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "2R:";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(480, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "0";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(456, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "3R:";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(437, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "0";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(413, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "4R:";
            this.label9.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enemy are missing";
            this.label2.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(596, 24);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.createToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.ResetToolStripMenuItemClick);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.createToolStripMenuItem.Text = "Create";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.CreateToolStripMenuItemClick);
            // 
            // CurrentNickLabel
            // 
            this.CurrentNickLabel.AutoSize = true;
            this.CurrentNickLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.CurrentNickLabel.Location = new System.Drawing.Point(12, 28);
            this.CurrentNickLabel.Name = "CurrentNickLabel";
            this.CurrentNickLabel.Size = new System.Drawing.Size(0, 17);
            this.CurrentNickLabel.TabIndex = 32;
            // 
            // EnemyNickLabel
            // 
            this.EnemyNickLabel.AutoSize = true;
            this.EnemyNickLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.EnemyNickLabel.Location = new System.Drawing.Point(322, 28);
            this.EnemyNickLabel.Name = "EnemyNickLabel";
            this.EnemyNickLabel.Size = new System.Drawing.Size(0, 17);
            this.EnemyNickLabel.TabIndex = 33;
            // 
            // TurnAlertLabel
            // 
            this.TurnAlertLabel.AutoSize = true;
            this.TurnAlertLabel.Location = new System.Drawing.Point(12, 302);
            this.TurnAlertLabel.Name = "TurnAlertLabel";
            this.TurnAlertLabel.Size = new System.Drawing.Size(0, 13);
            this.TurnAlertLabel.TabIndex = 34;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 324);
            this.Controls.Add(this.TurnAlertLabel);
            this.Controls.Add(this.EnemyNickLabel);
            this.Controls.Add(this.CurrentNickLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CurrentShip1Label);
            this.Controls.Add(this.CurrentShip1Info);
            this.Controls.Add(this.CurrentShip2Label);
            this.Controls.Add(this.CurrentShip2Info);
            this.Controls.Add(this.CurrentShip3Label);
            this.Controls.Add(this.CurrentShip3Info);
            this.Controls.Add(this.CurrentShip4Label);
            this.Controls.Add(this.CurrentShip4Info);
            this.Controls.Add(this.CurrentInfo);
            this.Controls.Add(this.CurrentBackground);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EnemyBackground);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GameForm";
            this.Text = "Sea Fight";
            ((System.ComponentModel.ISupportInitialize)(this.EnemyBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentBackground)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox EnemyBackground;
        private System.Windows.Forms.Label CurrentShip1Label;
        private System.Windows.Forms.Label CurrentShip1Info;
        private System.Windows.Forms.Label CurrentShip2Label;
        private System.Windows.Forms.Label CurrentShip2Info;
        private System.Windows.Forms.Label CurrentShip3Label;
        private System.Windows.Forms.Label CurrentShip3Info;
        private System.Windows.Forms.Label CurrentShip4Label;
        private System.Windows.Forms.Label CurrentShip4Info;
        private System.Windows.Forms.Label CurrentInfo;
        private System.Windows.Forms.PictureBox CurrentBackground;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.Label CurrentNickLabel;
        private System.Windows.Forms.Label EnemyNickLabel;
        private System.Windows.Forms.Label TurnAlertLabel;


    }
}

