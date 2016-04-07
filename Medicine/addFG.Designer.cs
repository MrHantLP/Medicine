namespace Medicine
{
    partial class addFG
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
            this.label1 = new System.Windows.Forms.Label();
            this.FG = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название фармакологической группы:";
            // 
            // FG
            // 
            this.FG.Location = new System.Drawing.Point(15, 25);
            this.FG.Name = "FG";
            this.FG.Size = new System.Drawing.Size(414, 20);
            this.FG.TabIndex = 1;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(309, 53);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(120, 23);
            this.add.TabIndex = 2;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(57, 53);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(120, 23);
            this.delete.TabIndex = 3;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Visible = false;
            this.delete.Click += new System.EventHandler(this.cancel_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(183, 53);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(120, 23);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "Вернутся к списку";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click_1);
            // 
            // addFG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 88);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.FG);
            this.Controls.Add(this.label1);
            this.Name = "addFG";
            this.Text = "Добавление фармакологической группы";
            this.Activated += new System.EventHandler(this.addFG_Activated);
            this.Load += new System.EventHandler(this.addFG_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FG;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button cancel;
    }
}