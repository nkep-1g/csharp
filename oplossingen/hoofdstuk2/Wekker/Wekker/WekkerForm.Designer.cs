namespace Wekker
{
    partial class WekkerForm
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
            this.uurOmhoogButton = new System.Windows.Forms.Button();
            this.uurOmlaagButton = new System.Windows.Forms.Button();
            this.alarmOmTextBox = new System.Windows.Forms.TextBox();
            this.minuutOmhoogButton = new System.Windows.Forms.Button();
            this.minuutOmlaagButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uurOmhoogButton
            // 
            this.uurOmhoogButton.Location = new System.Drawing.Point(20, 15);
            this.uurOmhoogButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uurOmhoogButton.Name = "uurOmhoogButton";
            this.uurOmhoogButton.Size = new System.Drawing.Size(33, 28);
            this.uurOmhoogButton.TabIndex = 0;
            this.uurOmhoogButton.Text = "+";
            this.uurOmhoogButton.UseVisualStyleBackColor = true;
            this.uurOmhoogButton.Click += new System.EventHandler(this.uurOmhoogButton_Click);
            // 
            // uurOmlaagButton
            // 
            this.uurOmlaagButton.Location = new System.Drawing.Point(20, 44);
            this.uurOmlaagButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uurOmlaagButton.Name = "uurOmlaagButton";
            this.uurOmlaagButton.Size = new System.Drawing.Size(33, 28);
            this.uurOmlaagButton.TabIndex = 1;
            this.uurOmlaagButton.Text = "-";
            this.uurOmlaagButton.UseVisualStyleBackColor = true;
            this.uurOmlaagButton.Click += new System.EventHandler(this.uurOmlaagButton_Click);
            // 
            // alarmOmTextBox
            // 
            this.alarmOmTextBox.BackColor = System.Drawing.Color.Black;
            this.alarmOmTextBox.Font = new System.Drawing.Font("Britannic Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarmOmTextBox.ForeColor = System.Drawing.Color.Lime;
            this.alarmOmTextBox.Location = new System.Drawing.Point(61, 15);
            this.alarmOmTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.alarmOmTextBox.Name = "alarmOmTextBox";
            this.alarmOmTextBox.Size = new System.Drawing.Size(148, 59);
            this.alarmOmTextBox.TabIndex = 2;
            this.alarmOmTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // minuutOmhoogButton
            // 
            this.minuutOmhoogButton.Location = new System.Drawing.Point(219, 15);
            this.minuutOmhoogButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.minuutOmhoogButton.Name = "minuutOmhoogButton";
            this.minuutOmhoogButton.Size = new System.Drawing.Size(33, 28);
            this.minuutOmhoogButton.TabIndex = 3;
            this.minuutOmhoogButton.Text = "+";
            this.minuutOmhoogButton.UseVisualStyleBackColor = true;
            this.minuutOmhoogButton.Click += new System.EventHandler(this.minuutOmhoogButton_Click);
            // 
            // minuutOmlaagButton
            // 
            this.minuutOmlaagButton.Location = new System.Drawing.Point(219, 44);
            this.minuutOmlaagButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.minuutOmlaagButton.Name = "minuutOmlaagButton";
            this.minuutOmlaagButton.Size = new System.Drawing.Size(33, 28);
            this.minuutOmlaagButton.TabIndex = 4;
            this.minuutOmlaagButton.Text = "-";
            this.minuutOmlaagButton.UseVisualStyleBackColor = true;
            this.minuutOmlaagButton.Click += new System.EventHandler(this.minuutOmlaagButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, -5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 20);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WekkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 95);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.minuutOmlaagButton);
            this.Controls.Add(this.minuutOmhoogButton);
            this.Controls.Add(this.alarmOmTextBox);
            this.Controls.Add(this.uurOmlaagButton);
            this.Controls.Add(this.uurOmhoogButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "WekkerForm";
            this.Text = "WekkerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uurOmhoogButton;
        private System.Windows.Forms.Button uurOmlaagButton;
        private System.Windows.Forms.TextBox alarmOmTextBox;
        private System.Windows.Forms.Button minuutOmhoogButton;
        private System.Windows.Forms.Button minuutOmlaagButton;
        private System.Windows.Forms.Button button1;
    }
}

