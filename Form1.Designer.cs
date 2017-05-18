namespace WindowsFormsChromaFireflyImage
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
            this._mButtonQuit = new System.Windows.Forms.Button();
            this._mPicture = new System.Windows.Forms.PictureBox();
            this._mButtonLoad = new System.Windows.Forms.Button();
            this._mTimerAnimation = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._mPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // _mButtonQuit
            // 
            this._mButtonQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._mButtonQuit.Location = new System.Drawing.Point(457, 306);
            this._mButtonQuit.Name = "_mButtonQuit";
            this._mButtonQuit.Size = new System.Drawing.Size(75, 23);
            this._mButtonQuit.TabIndex = 0;
            this._mButtonQuit.Text = "Quit";
            this._mButtonQuit.UseVisualStyleBackColor = true;
            this._mButtonQuit.Click += new System.EventHandler(this._mButtonQuit_Click);
            // 
            // _mPicture
            // 
            this._mPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._mPicture.Location = new System.Drawing.Point(12, 41);
            this._mPicture.Name = "_mPicture";
            this._mPicture.Size = new System.Drawing.Size(520, 259);
            this._mPicture.TabIndex = 1;
            this._mPicture.TabStop = false;
            // 
            // _mButtonLoad
            // 
            this._mButtonLoad.Location = new System.Drawing.Point(12, 12);
            this._mButtonLoad.Name = "_mButtonLoad";
            this._mButtonLoad.Size = new System.Drawing.Size(75, 23);
            this._mButtonLoad.TabIndex = 2;
            this._mButtonLoad.Text = "Load";
            this._mButtonLoad.UseVisualStyleBackColor = true;
            this._mButtonLoad.Click += new System.EventHandler(this._mButtonLoad_Click);
            // 
            // _mTimerAnimation
            // 
            this._mTimerAnimation.Interval = 30;
            this._mTimerAnimation.Tick += new System.EventHandler(this._mTimerAnimation_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 341);
            this.Controls.Add(this._mButtonLoad);
            this.Controls.Add(this._mPicture);
            this.Controls.Add(this._mButtonQuit);
            this.Name = "Form1";
            this.Text = "Chroma Firefly Image";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._mPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _mButtonQuit;
        private System.Windows.Forms.PictureBox _mPicture;
        private System.Windows.Forms.Button _mButtonLoad;
        private System.Windows.Forms.Timer _mTimerAnimation;
    }
}

