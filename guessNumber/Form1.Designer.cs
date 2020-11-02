namespace guessNumber
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
            this.lbl = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblComp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.lbl.Location = new System.Drawing.Point(23, 40);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(160, 17);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Guess number from 1 to 100";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(42, 98);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(125, 20);
            this.tbUser.TabIndex = 1;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(66, 130);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblComp
            // 
            this.lblComp.AutoSize = true;
            this.lblComp.Location = new System.Drawing.Point(23, 69);
            this.lblComp.Name = "lblComp";
            this.lblComp.Size = new System.Drawing.Size(0, 13);
            this.lblComp.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 176);
            this.Controls.Add(this.lblComp);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.lbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblComp;
    }
}

