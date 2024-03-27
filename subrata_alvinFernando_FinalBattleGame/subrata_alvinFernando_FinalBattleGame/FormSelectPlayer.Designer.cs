
namespace subrata_alvinFernando_FinalBattleGame
{
    partial class FormSelectPlayer
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
            this.radioButtonPlayer1 = new System.Windows.Forms.RadioButton();
            this.radioButtonPlayer2 = new System.Windows.Forms.RadioButton();
            this.pictureBoxPlayer1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlayer2 = new System.Windows.Forms.PictureBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.buttonPlay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer2)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonPlayer1
            // 
            this.radioButtonPlayer1.BackColor = System.Drawing.Color.Navy;
            this.radioButtonPlayer1.ForeColor = System.Drawing.Color.White;
            this.radioButtonPlayer1.Location = new System.Drawing.Point(12, 13);
            this.radioButtonPlayer1.Name = "radioButtonPlayer1";
            this.radioButtonPlayer1.Size = new System.Drawing.Size(271, 35);
            this.radioButtonPlayer1.TabIndex = 0;
            this.radioButtonPlayer1.TabStop = true;
            this.radioButtonPlayer1.Text = "Player1";
            this.radioButtonPlayer1.UseVisualStyleBackColor = false;
            this.radioButtonPlayer1.CheckedChanged += new System.EventHandler(this.radioButtonPlayer1_CheckedChanged);
            // 
            // radioButtonPlayer2
            // 
            this.radioButtonPlayer2.BackColor = System.Drawing.Color.DarkMagenta;
            this.radioButtonPlayer2.ForeColor = System.Drawing.Color.White;
            this.radioButtonPlayer2.Location = new System.Drawing.Point(310, 13);
            this.radioButtonPlayer2.Name = "radioButtonPlayer2";
            this.radioButtonPlayer2.Size = new System.Drawing.Size(271, 35);
            this.radioButtonPlayer2.TabIndex = 1;
            this.radioButtonPlayer2.TabStop = true;
            this.radioButtonPlayer2.Text = "Player2";
            this.radioButtonPlayer2.UseVisualStyleBackColor = false;
            // 
            // pictureBoxPlayer1
            // 
            this.pictureBoxPlayer1.BackColor = System.Drawing.Color.Navy;
            this.pictureBoxPlayer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPlayer1.Location = new System.Drawing.Point(12, 48);
            this.pictureBoxPlayer1.Name = "pictureBoxPlayer1";
            this.pictureBoxPlayer1.Size = new System.Drawing.Size(271, 174);
            this.pictureBoxPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlayer1.TabIndex = 2;
            this.pictureBoxPlayer1.TabStop = false;
            // 
            // pictureBoxPlayer2
            // 
            this.pictureBoxPlayer2.BackColor = System.Drawing.Color.DarkMagenta;
            this.pictureBoxPlayer2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPlayer2.Location = new System.Drawing.Point(310, 48);
            this.pictureBoxPlayer2.Name = "pictureBoxPlayer2";
            this.pictureBoxPlayer2.Size = new System.Drawing.Size(271, 174);
            this.pictureBoxPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlayer2.TabIndex = 3;
            this.pictureBoxPlayer2.TabStop = false;
            // 
            // labelDescription
            // 
            this.labelDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ForeColor = System.Drawing.Color.White;
            this.labelDescription.Location = new System.Drawing.Point(48, 252);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(483, 82);
            this.labelDescription.TabIndex = 4;
            this.labelDescription.Text = "Description";
            this.labelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonPlay.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay.Location = new System.Drawing.Point(200, 366);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(181, 46);
            this.buttonPlay.TabIndex = 5;
            this.buttonPlay.Text = "PLAY";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // FormSelectPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::subrata_alvinFernando_FinalBattleGame.Properties.Resources.game_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(593, 445);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.pictureBoxPlayer2);
            this.Controls.Add(this.pictureBoxPlayer1);
            this.Controls.Add(this.radioButtonPlayer2);
            this.Controls.Add(this.radioButtonPlayer1);
            this.Name = "FormSelectPlayer";
            this.Text = "Select Player";
            this.Load += new System.EventHandler(this.FormSelectPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonPlayer1;
        private System.Windows.Forms.RadioButton radioButtonPlayer2;
        private System.Windows.Forms.PictureBox pictureBoxPlayer1;
        private System.Windows.Forms.PictureBox pictureBoxPlayer2;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button buttonPlay;
    }
}