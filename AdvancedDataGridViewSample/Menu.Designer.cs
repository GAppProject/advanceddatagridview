namespace AdvancedDataGridViewSample
{
    partial class Menu
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
            this.Example0 = new System.Windows.Forms.Button();
            this.Example1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Example0
            // 
            this.Example0.Location = new System.Drawing.Point(65, 44);
            this.Example0.Name = "Example0";
            this.Example0.Size = new System.Drawing.Size(92, 50);
            this.Example0.TabIndex = 0;
            this.Example0.Text = "Example0";
            this.Example0.UseVisualStyleBackColor = true;
            this.Example0.Click += new System.EventHandler(this.Example0_Click);
            // 
            // Example1
            // 
            this.Example1.Location = new System.Drawing.Point(163, 44);
            this.Example1.Name = "Example1";
            this.Example1.Size = new System.Drawing.Size(109, 50);
            this.Example1.TabIndex = 1;
            this.Example1.Text = "Example1";
            this.Example1.UseVisualStyleBackColor = true;
            this.Example1.Click += new System.EventHandler(this.Example1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 135);
            this.Controls.Add(this.Example1);
            this.Controls.Add(this.Example0);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Example0;
        private System.Windows.Forms.Button Example1;
    }
}