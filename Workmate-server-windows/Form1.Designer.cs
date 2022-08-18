namespace Workmate_server_windows
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.logs_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ClientsIP = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.avvio_win_ckb = new System.Windows.Forms.CheckBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.esporta_btn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // logs_txt
            // 
            this.logs_txt.Location = new System.Drawing.Point(12, 36);
            this.logs_txt.Multiline = true;
            this.logs_txt.Name = "logs_txt";
            this.logs_txt.ReadOnly = true;
            this.logs_txt.Size = new System.Drawing.Size(580, 402);
            this.logs_txt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Logs:";
            // 
            // ClientsIP
            // 
            this.ClientsIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientsIP.FormattingEnabled = true;
            this.ClientsIP.ItemHeight = 15;
            this.ClientsIP.Location = new System.Drawing.Point(609, 36);
            this.ClientsIP.Name = "ClientsIP";
            this.ClientsIP.Size = new System.Drawing.Size(179, 349);
            this.ClientsIP.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(609, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Clients IP:";
            // 
            // avvio_win_ckb
            // 
            this.avvio_win_ckb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.avvio_win_ckb.AutoSize = true;
            this.avvio_win_ckb.Location = new System.Drawing.Point(609, 391);
            this.avvio_win_ckb.Name = "avvio_win_ckb";
            this.avvio_win_ckb.Size = new System.Drawing.Size(159, 19);
            this.avvio_win_ckb.TabIndex = 4;
            this.avvio_win_ckb.Text = "Apri all\'avvio di Windows";
            this.avvio_win_ckb.UseVisualStyleBackColor = true;
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(700, 416);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(88, 23);
            this.save_btn.TabIndex = 5;
            this.save_btn.Text = "Salva";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // esporta_btn
            // 
            this.esporta_btn.Location = new System.Drawing.Point(606, 416);
            this.esporta_btn.Name = "esporta_btn";
            this.esporta_btn.Size = new System.Drawing.Size(88, 23);
            this.esporta_btn.TabIndex = 6;
            this.esporta_btn.Text = "Esporta logs";
            this.esporta_btn.UseVisualStyleBackColor = true;
            this.esporta_btn.Click += new System.EventHandler(this.esporta_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.esporta_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.avvio_win_ckb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClientsIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logs_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Workmate Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox logs_txt;
        private Label label1;
        private ListBox ClientsIP;
        private Label label2;
        private CheckBox avvio_win_ckb;
        private Button save_btn;
        private Button esporta_btn;
        private SaveFileDialog saveFileDialog1;
    }
}