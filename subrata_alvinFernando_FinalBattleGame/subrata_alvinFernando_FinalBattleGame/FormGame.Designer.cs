
namespace subrata_alvinFernando_FinalBattleGame
{
    partial class FormGame
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startNewGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.continuePauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelData = new System.Windows.Forms.Panel();
            this.panelEnemy = new System.Windows.Forms.Panel();
            this.labelEnemyInfo = new System.Windows.Forms.Label();
            this.panelTime = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.panelPlayer = new System.Windows.Forms.Panel();
            this.linkLabelSelectArena = new System.Windows.Forms.LinkLabel();
            this.linkLabelSelectWeapon = new System.Windows.Forms.LinkLabel();
            this.labelPlayerInfo = new System.Windows.Forms.Label();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.timerEnemy = new System.Windows.Forms.Timer(this.components);
            this.timerWeapon = new System.Windows.Forms.Timer(this.components);
            this.timerWeaponEnemy = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxFirework = new System.Windows.Forms.PictureBox();
            this.pictureBoxUltimate = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panelData.SuspendLayout();
            this.panelEnemy.SuspendLayout();
            this.panelTime.SuspendLayout();
            this.panelPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFirework)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUltimate)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.YellowGreen;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(916, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startNewGameToolStripMenuItem,
            this.continuePauseToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // startNewGameToolStripMenuItem
            // 
            this.startNewGameToolStripMenuItem.Name = "startNewGameToolStripMenuItem";
            this.startNewGameToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.startNewGameToolStripMenuItem.Text = "Start New Game";
            this.startNewGameToolStripMenuItem.Click += new System.EventHandler(this.startNewGameToolStripMenuItem_Click);
            // 
            // continuePauseToolStripMenuItem
            // 
            this.continuePauseToolStripMenuItem.Name = "continuePauseToolStripMenuItem";
            this.continuePauseToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.continuePauseToolStripMenuItem.Text = "Continue/Pause";
            this.continuePauseToolStripMenuItem.Click += new System.EventHandler(this.continuePauseToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panelData
            // 
            this.panelData.BackColor = System.Drawing.Color.Transparent;
            this.panelData.Controls.Add(this.panelEnemy);
            this.panelData.Controls.Add(this.panelTime);
            this.panelData.Controls.Add(this.panelPlayer);
            this.panelData.Location = new System.Drawing.Point(20, 26);
            this.panelData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(886, 141);
            this.panelData.TabIndex = 1;
            // 
            // panelEnemy
            // 
            this.panelEnemy.BackColor = System.Drawing.Color.Black;
            this.panelEnemy.Controls.Add(this.labelEnemyInfo);
            this.panelEnemy.Location = new System.Drawing.Point(551, 11);
            this.panelEnemy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelEnemy.Name = "panelEnemy";
            this.panelEnemy.Size = new System.Drawing.Size(285, 122);
            this.panelEnemy.TabIndex = 2;
            // 
            // labelEnemyInfo
            // 
            this.labelEnemyInfo.AutoSize = true;
            this.labelEnemyInfo.ForeColor = System.Drawing.Color.Yellow;
            this.labelEnemyInfo.Location = new System.Drawing.Point(4, 0);
            this.labelEnemyInfo.Name = "labelEnemyInfo";
            this.labelEnemyInfo.Size = new System.Drawing.Size(78, 17);
            this.labelEnemyInfo.TabIndex = 0;
            this.labelEnemyInfo.Text = "Enemy Info";
            // 
            // panelTime
            // 
            this.panelTime.BackColor = System.Drawing.Color.Black;
            this.panelTime.Controls.Add(this.labelTime);
            this.panelTime.Location = new System.Drawing.Point(316, 14);
            this.panelTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTime.Name = "panelTime";
            this.panelTime.Size = new System.Drawing.Size(221, 61);
            this.panelTime.TabIndex = 1;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.Yellow;
            this.labelTime.Location = new System.Drawing.Point(10, 7);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(191, 52);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "00:00:00";
            // 
            // panelPlayer
            // 
            this.panelPlayer.BackColor = System.Drawing.Color.Black;
            this.panelPlayer.Controls.Add(this.linkLabelSelectArena);
            this.panelPlayer.Controls.Add(this.linkLabelSelectWeapon);
            this.panelPlayer.Controls.Add(this.labelPlayerInfo);
            this.panelPlayer.Location = new System.Drawing.Point(19, 14);
            this.panelPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelPlayer.Name = "panelPlayer";
            this.panelPlayer.Size = new System.Drawing.Size(285, 122);
            this.panelPlayer.TabIndex = 0;
            // 
            // linkLabelSelectArena
            // 
            this.linkLabelSelectArena.AutoSize = true;
            this.linkLabelSelectArena.LinkColor = System.Drawing.Color.Cyan;
            this.linkLabelSelectArena.Location = new System.Drawing.Point(4, 104);
            this.linkLabelSelectArena.Name = "linkLabelSelectArena";
            this.linkLabelSelectArena.Size = new System.Drawing.Size(89, 17);
            this.linkLabelSelectArena.TabIndex = 2;
            this.linkLabelSelectArena.TabStop = true;
            this.linkLabelSelectArena.Text = "Select Arena";
            this.linkLabelSelectArena.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSelectArena_LinkClicked);
            // 
            // linkLabelSelectWeapon
            // 
            this.linkLabelSelectWeapon.AutoSize = true;
            this.linkLabelSelectWeapon.LinkColor = System.Drawing.Color.Cyan;
            this.linkLabelSelectWeapon.Location = new System.Drawing.Point(174, 104);
            this.linkLabelSelectWeapon.Name = "linkLabelSelectWeapon";
            this.linkLabelSelectWeapon.Size = new System.Drawing.Size(104, 17);
            this.linkLabelSelectWeapon.TabIndex = 1;
            this.linkLabelSelectWeapon.TabStop = true;
            this.linkLabelSelectWeapon.Text = "Select Weapon";
            this.linkLabelSelectWeapon.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSelectWeapon_LinkClicked);
            // 
            // labelPlayerInfo
            // 
            this.labelPlayerInfo.AutoSize = true;
            this.labelPlayerInfo.ForeColor = System.Drawing.Color.Yellow;
            this.labelPlayerInfo.Location = new System.Drawing.Point(4, 0);
            this.labelPlayerInfo.Name = "labelPlayerInfo";
            this.labelPlayerInfo.Size = new System.Drawing.Size(75, 17);
            this.labelPlayerInfo.TabIndex = 0;
            this.labelPlayerInfo.Text = "Player Info";
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // timerEnemy
            // 
            this.timerEnemy.Tick += new System.EventHandler(this.timerEnemy_Tick);
            // 
            // timerWeapon
            // 
            this.timerWeapon.Tick += new System.EventHandler(this.timerWeapon_Tick);
            // 
            // timerWeaponEnemy
            // 
            this.timerWeaponEnemy.Tick += new System.EventHandler(this.timerWeaponEnemy_Tick);
            // 
            // pictureBoxFirework
            // 
            this.pictureBoxFirework.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxFirework.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxFirework.InitialImage = null;
            this.pictureBoxFirework.Location = new System.Drawing.Point(164, 164);
            this.pictureBoxFirework.Name = "pictureBoxFirework";
            this.pictureBoxFirework.Size = new System.Drawing.Size(752, 405);
            this.pictureBoxFirework.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFirework.TabIndex = 2;
            this.pictureBoxFirework.TabStop = false;
            // 
            // pictureBoxUltimate
            // 
            this.pictureBoxUltimate.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxUltimate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxUltimate.Location = new System.Drawing.Point(571, 164);
            this.pictureBoxUltimate.Name = "pictureBoxUltimate";
            this.pictureBoxUltimate.Size = new System.Drawing.Size(285, 405);
            this.pictureBoxUltimate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUltimate.TabIndex = 3;
            this.pictureBoxUltimate.TabStop = false;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::subrata_alvinFernando_FinalBattleGame.Properties.Resources.game_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(916, 568);
            this.Controls.Add(this.pictureBoxUltimate);
            this.Controls.Add(this.pictureBoxFirework);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelData);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormGame";
            this.Text = "Final Battle";
            this.Load += new System.EventHandler(this.FormGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGame_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelData.ResumeLayout(false);
            this.panelEnemy.ResumeLayout(false);
            this.panelEnemy.PerformLayout();
            this.panelTime.ResumeLayout(false);
            this.panelTime.PerformLayout();
            this.panelPlayer.ResumeLayout(false);
            this.panelPlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFirework)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUltimate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startNewGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem continuePauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Panel panelEnemy;
        private System.Windows.Forms.Label labelEnemyInfo;
        private System.Windows.Forms.Panel panelTime;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Panel panelPlayer;
        private System.Windows.Forms.LinkLabel linkLabelSelectWeapon;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Timer timerEnemy;
        private System.Windows.Forms.Timer timerWeapon;
        public System.Windows.Forms.Label labelPlayerInfo;
        private System.Windows.Forms.LinkLabel linkLabelSelectArena;
        private System.Windows.Forms.Timer timerWeaponEnemy;
        private System.Windows.Forms.PictureBox pictureBoxFirework;
        private System.Windows.Forms.PictureBox pictureBoxUltimate;
    }
}

