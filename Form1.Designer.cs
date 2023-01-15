namespace CMD_Simple
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
            this.resetTCP = new System.Windows.Forms.Button();
            this.loopBack = new System.Windows.Forms.Button();
            this.pingGoogle = new System.Windows.Forms.Button();
            this.ipConfig = new System.Windows.Forms.Button();
            this.netStat = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // resetTCP
            // 
            this.resetTCP.Location = new System.Drawing.Point(665, 290);
            this.resetTCP.Name = "resetTCP";
            this.resetTCP.Size = new System.Drawing.Size(123, 50);
            this.resetTCP.TabIndex = 4;
            this.resetTCP.Text = "Reset TCP/IP";
            this.resetTCP.UseVisualStyleBackColor = true;
            this.resetTCP.Click += new System.EventHandler(this.resetTCP_Click);
            // 
            // loopBack
            // 
            this.loopBack.Location = new System.Drawing.Point(665, 12);
            this.loopBack.Name = "loopBack";
            this.loopBack.Size = new System.Drawing.Size(123, 50);
            this.loopBack.TabIndex = 5;
            this.loopBack.Text = "TCP/IP Test";
            this.loopBack.UseVisualStyleBackColor = true;
            this.loopBack.Click += new System.EventHandler(this.loopBack_Click);
            // 
            // pingGoogle
            // 
            this.pingGoogle.Location = new System.Drawing.Point(665, 77);
            this.pingGoogle.Name = "pingGoogle";
            this.pingGoogle.Size = new System.Drawing.Size(123, 50);
            this.pingGoogle.TabIndex = 6;
            this.pingGoogle.Text = "Internet Connectivity";
            this.pingGoogle.UseVisualStyleBackColor = true;
            this.pingGoogle.Click += new System.EventHandler(this.pingGoogle_Click);
            // 
            // ipConfig
            // 
            this.ipConfig.Location = new System.Drawing.Point(665, 149);
            this.ipConfig.Name = "ipConfig";
            this.ipConfig.Size = new System.Drawing.Size(123, 50);
            this.ipConfig.TabIndex = 7;
            this.ipConfig.Text = "IP Config";
            this.ipConfig.UseVisualStyleBackColor = true;
            this.ipConfig.Click += new System.EventHandler(this.ipConfig_Click);
            // 
            // netStat
            // 
            this.netStat.Location = new System.Drawing.Point(665, 220);
            this.netStat.Name = "netStat";
            this.netStat.Size = new System.Drawing.Size(123, 50);
            this.netStat.TabIndex = 8;
            this.netStat.Text = "NetStat";
            this.netStat.UseVisualStyleBackColor = true;
            this.netStat.Click += new System.EventHandler(this.netStat_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(327, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(244, 23);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.netStat);
            this.Controls.Add(this.ipConfig);
            this.Controls.Add(this.pingGoogle);
            this.Controls.Add(this.loopBack);
            this.Controls.Add(this.resetTCP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button resetTCP;
        private Button loopBack;
        private Button pingGoogle;
        private Button ipConfig;
        private Button netStat;
        private TextBox textBox1;
    }
}