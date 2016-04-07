namespace Medicine
{
    partial class addVsDVs
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
            this.DVs = new System.Windows.Forms.ComboBox();
            this.DV = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DVs
            // 
            this.DVs.FormattingEnabled = true;
            this.DVs.Location = new System.Drawing.Point(15, 45);
            this.DVs.Name = "DVs";
            this.DVs.Size = new System.Drawing.Size(211, 21);
            this.DVs.TabIndex = 0;
            // 
            // DV
            // 
            this.DV.AutoSize = true;
            this.DV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DV.Location = new System.Drawing.Point(12, 9);
            this.DV.Name = "DV";
            this.DV.Size = new System.Drawing.Size(35, 13);
            this.DV.TabIndex = 1;
            this.DV.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Несовместимо с";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(338, 4);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(126, 28);
            this.add.TabIndex = 11;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(338, 38);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(126, 28);
            this.cancel.TabIndex = 12;
            this.cancel.Text = "Вернуться";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(338, 72);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(126, 28);
            this.delete.TabIndex = 13;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // addVsDVs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 113);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DV);
            this.Controls.Add(this.DVs);
            this.Name = "addVsDVs";
            this.Text = "Добавление несовместимого действующего вещества";
            this.Load += new System.EventHandler(this.addVsDVs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DVs;
        private System.Windows.Forms.Label DV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button delete;
    }
}