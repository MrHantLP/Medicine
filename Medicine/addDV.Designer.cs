namespace Medicine
{
    partial class addDV
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
            this.currentFGLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.vsDVs = new System.Windows.Forms.ListBox();
            this.Notice = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addVsDVs = new System.Windows.Forms.Button();
            this.addNotice = new System.Windows.Forms.Button();
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
            this.label1.Size = new System.Drawing.Size(199, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Текущая фармакологическая группа:";
            // 
            // currentFGLabel
            // 
            this.currentFGLabel.AutoSize = true;
            this.currentFGLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentFGLabel.Location = new System.Drawing.Point(217, 9);
            this.currentFGLabel.Name = "currentFGLabel";
            this.currentFGLabel.Size = new System.Drawing.Size(35, 13);
            this.currentFGLabel.TabIndex = 1;
            this.currentFGLabel.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Название действущего вещества:";
            // 
            // DV
            // 
            this.DV.Location = new System.Drawing.Point(15, 52);
            this.DV.Name = "DV";
            this.DV.Size = new System.Drawing.Size(395, 20);
            this.DV.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Не совместимо с";
            // 
            // vsDVs
            // 
            this.vsDVs.FormattingEnabled = true;
            this.vsDVs.Location = new System.Drawing.Point(15, 105);
            this.vsDVs.Name = "vsDVs";
            this.vsDVs.Size = new System.Drawing.Size(158, 199);
            this.vsDVs.TabIndex = 5;
            // 
            // Notice
            // 
            this.Notice.FormattingEnabled = true;
            this.Notice.Location = new System.Drawing.Point(197, 105);
            this.Notice.Name = "Notice";
            this.Notice.Size = new System.Drawing.Size(213, 199);
            this.Notice.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Противопаказано при";
            // 
            // addVsDVs
            // 
            this.addVsDVs.Location = new System.Drawing.Point(15, 310);
            this.addVsDVs.Name = "addVsDVs";
            this.addVsDVs.Size = new System.Drawing.Size(158, 23);
            this.addVsDVs.TabIndex = 8;
            this.addVsDVs.Text = "Добавить";
            this.addVsDVs.UseVisualStyleBackColor = true;
            this.addVsDVs.Click += new System.EventHandler(this.addVsDVs_Click);
            // 
            // addNotice
            // 
            this.addNotice.Location = new System.Drawing.Point(197, 310);
            this.addNotice.Name = "addNotice";
            this.addNotice.Size = new System.Drawing.Size(213, 23);
            this.addNotice.TabIndex = 9;
            this.addNotice.Text = "Добавить";
            this.addNotice.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(443, 9);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(198, 40);
            this.add.TabIndex = 10;
            this.add.Text = "Добавить действующее вещество";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(443, 101);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(198, 40);
            this.delete.TabIndex = 11;
            this.delete.Text = "Удалить действующее вещество";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(443, 55);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(198, 40);
            this.cancel.TabIndex = 12;
            this.cancel.Text = "Вернуться к списку";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // addDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 345);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.addNotice);
            this.Controls.Add(this.addVsDVs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Notice);
            this.Controls.Add(this.vsDVs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.currentFGLabel);
            this.Controls.Add(this.label1);
            this.Name = "addDV";
            this.Text = "Добавление действующего вещества";
            this.Activated += new System.EventHandler(this.addDV_Activated);
            this.Load += new System.EventHandler(this.addDV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentFGLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox vsDVs;
        private System.Windows.Forms.ListBox Notice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addVsDVs;
        private System.Windows.Forms.Button addNotice;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button cancel;
    }
}