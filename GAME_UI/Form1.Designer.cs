namespace GAME_UI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ball = new System.Windows.Forms.PictureBox();
            this.slid = new System.Windows.Forms.PictureBox();
            this.vert = new System.Windows.Forms.Timer(this.components);
            this.horz = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slid)).BeginInit();
            this.SuspendLayout();
            // 
            // ball
            // 
            this.ball.Image = ((System.Drawing.Image)(resources.GetObject("ball.Image")));
            this.ball.Location = new System.Drawing.Point(12, 12);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(88, 79);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ball.TabIndex = 0;
            this.ball.TabStop = false;
            this.ball.Click += new System.EventHandler(this.ball_Click);
            // 
            // slid
            // 
            this.slid.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.slid.BackColor = System.Drawing.Color.Lime;
            this.slid.Location = new System.Drawing.Point(233, 414);
            this.slid.Name = "slid";
            this.slid.Size = new System.Drawing.Size(180, 15);
            this.slid.TabIndex = 1;
            this.slid.TabStop = false;
            // 
            // vert
            // 
            this.vert.Enabled = true;
            this.vert.Interval = 1;
            this.vert.Tick += new System.EventHandler(this.vert_Tick);
            // 
            // horz
            // 
            this.horz.Enabled = true;
            this.horz.Interval = 1;
            this.horz.Tick += new System.EventHandler(this.horz_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(917, 429);
            this.Controls.Add(this.slid);
            this.Controls.Add(this.ball);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox slid;
        private System.Windows.Forms.Timer vert;
        private System.Windows.Forms.Timer horz;
    }
}

