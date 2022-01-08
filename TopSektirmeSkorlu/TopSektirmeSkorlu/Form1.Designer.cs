
namespace TopSektirmeSkorlu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sol = new System.Windows.Forms.PictureBox();
            this.sag = new System.Windows.Forms.PictureBox();
            this.sagUst = new System.Windows.Forms.PictureBox();
            this.solUst = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.play = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.skor = new System.Windows.Forms.Label();
            this.Spawn = new System.Windows.Forms.Timer(this.components);
            this.cubuk = new System.Windows.Forms.PictureBox();
            this.Movement = new System.Windows.Forms.Timer(this.components);
            this.SkorGuncelle = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sagUst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solUst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cubuk)).BeginInit();
            this.SuspendLayout();
            // 
            // sol
            // 
            this.sol.BackColor = System.Drawing.Color.Black;
            this.sol.Location = new System.Drawing.Point(0, 0);
            this.sol.Name = "sol";
            this.sol.Size = new System.Drawing.Size(30, 561);
            this.sol.TabIndex = 0;
            this.sol.TabStop = false;
            // 
            // sag
            // 
            this.sag.BackColor = System.Drawing.Color.Black;
            this.sag.Location = new System.Drawing.Point(758, 0);
            this.sag.Name = "sag";
            this.sag.Size = new System.Drawing.Size(30, 561);
            this.sag.TabIndex = 1;
            this.sag.TabStop = false;
            // 
            // sagUst
            // 
            this.sagUst.BackColor = System.Drawing.Color.Black;
            this.sagUst.Location = new System.Drawing.Point(508, 0);
            this.sagUst.Name = "sagUst";
            this.sagUst.Size = new System.Drawing.Size(250, 30);
            this.sagUst.TabIndex = 2;
            this.sagUst.TabStop = false;
            // 
            // solUst
            // 
            this.solUst.BackColor = System.Drawing.Color.Black;
            this.solUst.Location = new System.Drawing.Point(30, 0);
            this.solUst.Name = "solUst";
            this.solUst.Size = new System.Drawing.Size(250, 30);
            this.solUst.TabIndex = 3;
            this.solUst.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox5.Location = new System.Drawing.Point(0, 561);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(783, 40);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // play
            // 
            this.play.Location = new System.Drawing.Point(503, 561);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(75, 40);
            this.play.TabIndex = 5;
            this.play.Text = "PLAY";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // pause
            // 
            this.pause.Location = new System.Drawing.Point(616, 561);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(75, 40);
            this.pause.TabIndex = 6;
            this.pause.Text = "PAUSE";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // skor
            // 
            this.skor.AutoSize = true;
            this.skor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skor.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.skor.Location = new System.Drawing.Point(707, 33);
            this.skor.Name = "skor";
            this.skor.Size = new System.Drawing.Size(36, 42);
            this.skor.TabIndex = 7;
            this.skor.Text = "0";
            // 
            // Spawn
            // 
            this.Spawn.Enabled = true;
            this.Spawn.Interval = 1000;
            this.Spawn.Tick += new System.EventHandler(this.TimerEvent);
            // 
            // cubuk
            // 
            this.cubuk.BackColor = System.Drawing.Color.SandyBrown;
            this.cubuk.Location = new System.Drawing.Point(290, 525);
            this.cubuk.Name = "cubuk";
            this.cubuk.Size = new System.Drawing.Size(248, 30);
            this.cubuk.TabIndex = 8;
            this.cubuk.TabStop = false;
            // 
            // Movement
            // 
            this.Movement.Enabled = true;
            this.Movement.Interval = 10;
            this.Movement.Tick += new System.EventHandler(this.Movement_Tick);
            // 
            // SkorGuncelle
            // 
            this.SkorGuncelle.Enabled = true;
            this.SkorGuncelle.Tick += new System.EventHandler(this.GuncelSkor);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(788, 601);
            this.Controls.Add(this.cubuk);
            this.Controls.Add(this.skor);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.play);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.solUst);
            this.Controls.Add(this.sagUst);
            this.Controls.Add(this.sag);
            this.Controls.Add(this.sol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.sol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sagUst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solUst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cubuk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox sol;
        private System.Windows.Forms.PictureBox sag;
        private System.Windows.Forms.PictureBox sagUst;
        private System.Windows.Forms.PictureBox solUst;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Label skor;
        private System.Windows.Forms.Timer Spawn;
        private System.Windows.Forms.PictureBox cubuk;
        private System.Windows.Forms.Timer Movement;
        private System.Windows.Forms.Timer SkorGuncelle;
    }
}

