namespace TrafficLight
{
    partial class ContinueBTN
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
            this.StartBTN = new System.Windows.Forms.Button();
            this.StopBTN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ctrlTrafficLight1 = new TrafficLight.ctrlTrafficLight();
            this.SuspendLayout();
            // 
            // StartBTN
            // 
            this.StartBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartBTN.Location = new System.Drawing.Point(124, 343);
            this.StartBTN.Name = "StartBTN";
            this.StartBTN.Size = new System.Drawing.Size(75, 28);
            this.StartBTN.TabIndex = 2;
            this.StartBTN.Text = "Start";
            this.StartBTN.UseVisualStyleBackColor = true;
            this.StartBTN.Click += new System.EventHandler(this.StartBTN_Click);
            // 
            // StopBTN
            // 
            this.StopBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopBTN.Location = new System.Drawing.Point(21, 343);
            this.StopBTN.Name = "StopBTN";
            this.StopBTN.Size = new System.Drawing.Size(75, 28);
            this.StopBTN.TabIndex = 3;
            this.StopBTN.Text = "Stop";
            this.StopBTN.UseVisualStyleBackColor = true;
            this.StopBTN.Click += new System.EventHandler(this.StopBTN_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(60, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Continue";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ctrlTrafficLight1
            // 
            this.ctrlTrafficLight1.GreenTime = 5;
            this.ctrlTrafficLight1.Location = new System.Drawing.Point(60, 12);
            this.ctrlTrafficLight1.Name = "ctrlTrafficLight1";
            this.ctrlTrafficLight1.OrangeTime = 7;
            this.ctrlTrafficLight1.RedTime = 10;
            this.ctrlTrafficLight1.Size = new System.Drawing.Size(107, 291);
            this.ctrlTrafficLight1.TabIndex = 0;
            this.ctrlTrafficLight1.OnRedLightOn += new System.EventHandler(this.ctrlTrafficLight1_OnRedLightOn_1);
            this.ctrlTrafficLight1.OnOrangeLightOn += new System.EventHandler(this.ctrlTrafficLight1_OnOrangeLightOn);
            this.ctrlTrafficLight1.OnGreenLightOn += new System.EventHandler(this.ctrlTrafficLight1_OnGreenLightOn);
            // 
            // ContinueBTN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StopBTN);
            this.Controls.Add(this.StartBTN);
            this.Controls.Add(this.ctrlTrafficLight1);
            this.Name = "ContinueBTN";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlTrafficLight ctrlTrafficLight1;
        private System.Windows.Forms.Button StartBTN;
        private System.Windows.Forms.Button StopBTN;
        private System.Windows.Forms.Button button1;
    }
}

