namespace TrafficMessageReceiver2
{
    partial class ReceiverForm
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
            this.messageLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ServerLbl = new System.Windows.Forms.Label();
            this.Lbl = new System.Windows.Forms.Label();
            this.timerRetrive = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // messageLbl
            // 
            this.messageLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messageLbl.Location = new System.Drawing.Point(12, 84);
            this.messageLbl.Name = "messageLbl";
            this.messageLbl.Size = new System.Drawing.Size(444, 23);
            this.messageLbl.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "message";
            // 
            // ServerLbl
            // 
            this.ServerLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServerLbl.Location = new System.Drawing.Point(12, 23);
            this.ServerLbl.Name = "ServerLbl";
            this.ServerLbl.Size = new System.Drawing.Size(444, 23);
            this.ServerLbl.TabIndex = 2;
            // 
            // Lbl
            // 
            this.Lbl.AutoSize = true;
            this.Lbl.Location = new System.Drawing.Point(9, 10);
            this.Lbl.Name = "Lbl";
            this.Lbl.Size = new System.Drawing.Size(36, 13);
            this.Lbl.TabIndex = 1;
            this.Lbl.Text = "server";
            // 
            // timerRetrive
            // 
            this.timerRetrive.Interval = 10;
            this.timerRetrive.Tick += new System.EventHandler(this.timerRetrive_Tick);
            // 
            // ReceiverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 126);
            this.Controls.Add(this.Lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ServerLbl);
            this.Controls.Add(this.messageLbl);
            this.Name = "ReceiverForm";
            this.Text = "TrafficMessageReceiver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label messageLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ServerLbl;
        private System.Windows.Forms.Label Lbl;
        private System.Windows.Forms.Timer timerRetrive;
    }
}

