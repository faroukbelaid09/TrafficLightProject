namespace TrafficLight
{
    partial class ctrlTrafficLight
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlTrafficLight));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TimerValue = new System.Windows.Forms.Label();
            this.LightTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TimerValue
            // 
            this.TimerValue.AutoSize = true;
            this.TimerValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerValue.ForeColor = System.Drawing.Color.Red;
            this.TimerValue.Location = new System.Drawing.Point(34, 262);
            this.TimerValue.Name = "TimerValue";
            this.TimerValue.Size = new System.Drawing.Size(29, 20);
            this.TimerValue.TabIndex = 1;
            this.TimerValue.Text = "??";
            // 
            // LightTimer
            // 
            this.LightTimer.Interval = 1000;
            this.LightTimer.Tick += new System.EventHandler(this.LightTimer_Tick);
            // 
            // ctrlTrafficLight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TimerValue);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ctrlTrafficLight";
            this.Size = new System.Drawing.Size(107, 291);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TimerValue;
        private System.Windows.Forms.Timer LightTimer;
    }
}
