namespace GUI
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
            this.inword = new System.Windows.Forms.Button();
            this.innum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inword
            // 
            this.inword.Location = new System.Drawing.Point(323, 128);
            this.inword.Name = "inword";
            this.inword.Size = new System.Drawing.Size(75, 23);
            this.inword.TabIndex = 0;
            this.inword.Text = "Word";
            this.inword.UseVisualStyleBackColor = true;
            // 
            // innum
            // 
            this.innum.Location = new System.Drawing.Point(330, 231);
            this.innum.Name = "innum";
            this.innum.Size = new System.Drawing.Size(75, 23);
            this.innum.TabIndex = 1;
            this.innum.Text = "number";
            this.innum.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.innum);
            this.Controls.Add(this.inword);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button inword;
        private System.Windows.Forms.Button innum;
    }
}

