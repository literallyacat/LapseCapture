namespace LapseCapture {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.CaptureIntervalChooser = new System.Windows.Forms.ComboBox();
            this.StartCapture = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Capture Interval";
            //
            // CaptureIntervalChooser
            //
            this.CaptureIntervalChooser.FormattingEnabled = true;
            this.CaptureIntervalChooser.Items.AddRange(new object[] {
            "30 Seconds",
            "1 Minute",
            "5 Minutes"});
            this.CaptureIntervalChooser.Location = new System.Drawing.Point(100, 6);
            this.CaptureIntervalChooser.Name = "CaptureIntervalChooser";
            this.CaptureIntervalChooser.Size = new System.Drawing.Size(121, 21);
            this.CaptureIntervalChooser.TabIndex = 1;
            //
            // StartCapture
            //
            this.StartCapture.Location = new System.Drawing.Point(227, 4);
            this.StartCapture.Name = "StartCapture";
            this.StartCapture.Size = new System.Drawing.Size(92, 23);
            this.StartCapture.TabIndex = 2;
            this.StartCapture.Text = "Start Capture";
            this.StartCapture.UseVisualStyleBackColor = true;
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 37);
            this.Controls.Add(this.StartCapture);
            this.Controls.Add(this.CaptureIntervalChooser);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Screen Lapse";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CaptureIntervalChooser;
        private System.Windows.Forms.Button StartCapture;
    }
}

