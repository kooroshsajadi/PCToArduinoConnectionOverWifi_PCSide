namespace Arduino
{
    partial class Form2
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
            this.LEDPanel1 = new System.Windows.Forms.Panel();
            this.LEDBtn1 = new System.Windows.Forms.Button();
            this.BulitInLEDGpBox = new System.Windows.Forms.GroupBox();
            this.Pin14LEDGpBox = new System.Windows.Forms.GroupBox();
            this.LEDPanel2 = new System.Windows.Forms.Panel();
            this.LEDBtn2 = new System.Windows.Forms.Button();
            this.PinD1GpBox = new System.Windows.Forms.GroupBox();
            this.LEDPanel3 = new System.Windows.Forms.Panel();
            this.LEDBtn3 = new System.Windows.Forms.Button();
            this.BulitInLEDGpBox.SuspendLayout();
            this.Pin14LEDGpBox.SuspendLayout();
            this.PinD1GpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // LEDPanel1
            // 
            this.LEDPanel1.BackgroundImage = global::Arduino.Properties.Resources.led_bulb_off;
            this.LEDPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LEDPanel1.Location = new System.Drawing.Point(6, 21);
            this.LEDPanel1.Name = "LEDPanel1";
            this.LEDPanel1.Size = new System.Drawing.Size(91, 100);
            this.LEDPanel1.TabIndex = 0;
            // 
            // LEDBtn1
            // 
            this.LEDBtn1.Location = new System.Drawing.Point(6, 127);
            this.LEDBtn1.Name = "LEDBtn1";
            this.LEDBtn1.Size = new System.Drawing.Size(91, 38);
            this.LEDBtn1.TabIndex = 1;
            this.LEDBtn1.Text = "turn on";
            this.LEDBtn1.UseVisualStyleBackColor = true;
            this.LEDBtn1.Click += new System.EventHandler(this.LEDBtn1_Click);
            // 
            // BulitInLEDGpBox
            // 
            this.BulitInLEDGpBox.Controls.Add(this.LEDPanel1);
            this.BulitInLEDGpBox.Controls.Add(this.LEDBtn1);
            this.BulitInLEDGpBox.Location = new System.Drawing.Point(250, 207);
            this.BulitInLEDGpBox.Name = "BulitInLEDGpBox";
            this.BulitInLEDGpBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BulitInLEDGpBox.Size = new System.Drawing.Size(103, 173);
            this.BulitInLEDGpBox.TabIndex = 2;
            this.BulitInLEDGpBox.TabStop = false;
            this.BulitInLEDGpBox.Text = "BUILTIN_LED";
            // 
            // Pin14LEDGpBox
            // 
            this.Pin14LEDGpBox.Controls.Add(this.LEDPanel2);
            this.Pin14LEDGpBox.Controls.Add(this.LEDBtn2);
            this.Pin14LEDGpBox.Location = new System.Drawing.Point(90, 32);
            this.Pin14LEDGpBox.Name = "Pin14LEDGpBox";
            this.Pin14LEDGpBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Pin14LEDGpBox.Size = new System.Drawing.Size(103, 173);
            this.Pin14LEDGpBox.TabIndex = 3;
            this.Pin14LEDGpBox.TabStop = false;
            this.Pin14LEDGpBox.Text = "PIN14_LED";
            // 
            // LEDPanel2
            // 
            this.LEDPanel2.BackgroundImage = global::Arduino.Properties.Resources.led_bulb_off;
            this.LEDPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LEDPanel2.Location = new System.Drawing.Point(6, 21);
            this.LEDPanel2.Name = "LEDPanel2";
            this.LEDPanel2.Size = new System.Drawing.Size(91, 100);
            this.LEDPanel2.TabIndex = 0;
            // 
            // LEDBtn2
            // 
            this.LEDBtn2.Location = new System.Drawing.Point(6, 127);
            this.LEDBtn2.Name = "LEDBtn2";
            this.LEDBtn2.Size = new System.Drawing.Size(91, 38);
            this.LEDBtn2.TabIndex = 1;
            this.LEDBtn2.Text = "turn on";
            this.LEDBtn2.UseVisualStyleBackColor = true;
            this.LEDBtn2.Click += new System.EventHandler(this.LEDBtn2_Click);
            // 
            // PinD1GpBox
            // 
            this.PinD1GpBox.Controls.Add(this.LEDPanel3);
            this.PinD1GpBox.Controls.Add(this.LEDBtn3);
            this.PinD1GpBox.Location = new System.Drawing.Point(410, 32);
            this.PinD1GpBox.MaximumSize = new System.Drawing.Size(103, 173);
            this.PinD1GpBox.MinimumSize = new System.Drawing.Size(103, 173);
            this.PinD1GpBox.Name = "PinD1GpBox";
            this.PinD1GpBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PinD1GpBox.Size = new System.Drawing.Size(103, 173);
            this.PinD1GpBox.TabIndex = 4;
            this.PinD1GpBox.TabStop = false;
            this.PinD1GpBox.Text = "PinD1_LED";
            // 
            // LEDPanel3
            // 
            this.LEDPanel3.BackgroundImage = global::Arduino.Properties.Resources.led_bulb_off;
            this.LEDPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LEDPanel3.Location = new System.Drawing.Point(6, 21);
            this.LEDPanel3.Name = "LEDPanel3";
            this.LEDPanel3.Size = new System.Drawing.Size(91, 100);
            this.LEDPanel3.TabIndex = 0;
            // 
            // LEDBtn3
            // 
            this.LEDBtn3.Location = new System.Drawing.Point(6, 127);
            this.LEDBtn3.Name = "LEDBtn3";
            this.LEDBtn3.Size = new System.Drawing.Size(91, 38);
            this.LEDBtn3.TabIndex = 1;
            this.LEDBtn3.Text = "turn on";
            this.LEDBtn3.UseVisualStyleBackColor = true;
            this.LEDBtn3.Click += new System.EventHandler(this.LEDBtn3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(598, 392);
            this.Controls.Add(this.PinD1GpBox);
            this.Controls.Add(this.Pin14LEDGpBox);
            this.Controls.Add(this.BulitInLEDGpBox);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(614, 431);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(614, 431);
            this.Name = "Form2";
            this.ShowIcon = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.BulitInLEDGpBox.ResumeLayout(false);
            this.Pin14LEDGpBox.ResumeLayout(false);
            this.PinD1GpBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LEDPanel1;
        private System.Windows.Forms.Button LEDBtn1;
        private System.Windows.Forms.GroupBox BulitInLEDGpBox;
        private System.Windows.Forms.GroupBox Pin14LEDGpBox;
        private System.Windows.Forms.Panel LEDPanel2;
        private System.Windows.Forms.Button LEDBtn2;
        private System.Windows.Forms.GroupBox PinD1GpBox;
        private System.Windows.Forms.Panel LEDPanel3;
        private System.Windows.Forms.Button LEDBtn3;
    }
}