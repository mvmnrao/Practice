namespace TestWinApp
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
            this.btnShowMsg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowMsg
            // 
            this.btnShowMsg.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShowMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowMsg.ForeColor = System.Drawing.Color.Crimson;
            this.btnShowMsg.Location = new System.Drawing.Point(93, 113);
            this.btnShowMsg.Name = "btnShowMsg";
            this.btnShowMsg.Size = new System.Drawing.Size(132, 47);
            this.btnShowMsg.TabIndex = 0;
            this.btnShowMsg.Text = "Show Message";
            this.btnShowMsg.UseVisualStyleBackColor = false;
            this.btnShowMsg.Click += new System.EventHandler(this.btnShowMsg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.btnShowMsg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowMsg;
    }
}

