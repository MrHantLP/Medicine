namespace Medicine
{
    partial class Main
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
            this.startRedact = new System.Windows.Forms.Button();
            this.startGym = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startRedact
            // 
            this.startRedact.Location = new System.Drawing.Point(75, 12);
            this.startRedact.Name = "startRedact";
            this.startRedact.Size = new System.Drawing.Size(360, 32);
            this.startRedact.TabIndex = 0;
            this.startRedact.Text = "Редактировать базы знаний";
            this.startRedact.UseVisualStyleBackColor = true;
            this.startRedact.Click += new System.EventHandler(this.startRedact_Click);
            // 
            // startGym
            // 
            this.startGym.Location = new System.Drawing.Point(75, 70);
            this.startGym.Name = "startGym";
            this.startGym.Size = new System.Drawing.Size(360, 32);
            this.startGym.TabIndex = 1;
            this.startGym.Text = "Запустить тренажёр";
            this.startGym.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 117);
            this.Controls.Add(this.startGym);
            this.Controls.Add(this.startRedact);
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startRedact;
        private System.Windows.Forms.Button startGym;
    }
}

