namespace Medicine
{
    partial class FSredact
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
            this.farmGroups = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DVs = new System.Windows.Forms.ListBox();
            this.addFG = new System.Windows.Forms.Button();
            this.addDV = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // farmGroups
            // 
            this.farmGroups.FormattingEnabled = true;
            this.farmGroups.Location = new System.Drawing.Point(12, 25);
            this.farmGroups.Name = "farmGroups";
            this.farmGroups.Size = new System.Drawing.Size(223, 225);
            this.farmGroups.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фармакологические группы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Действующие вещества";
            // 
            // DVs
            // 
            this.DVs.FormattingEnabled = true;
            this.DVs.Location = new System.Drawing.Point(274, 25);
            this.DVs.Name = "DVs";
            this.DVs.Size = new System.Drawing.Size(223, 225);
            this.DVs.TabIndex = 3;
            // 
            // addFG
            // 
            this.addFG.Location = new System.Drawing.Point(12, 256);
            this.addFG.Name = "addFG";
            this.addFG.Size = new System.Drawing.Size(223, 36);
            this.addFG.TabIndex = 4;
            this.addFG.Text = "Добавить";
            this.addFG.UseVisualStyleBackColor = true;
            // 
            // addDV
            // 
            this.addDV.Location = new System.Drawing.Point(274, 256);
            this.addDV.Name = "addDV";
            this.addDV.Size = new System.Drawing.Size(223, 36);
            this.addDV.TabIndex = 5;
            this.addDV.Text = "Добавить";
            this.addDV.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(324, 313);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(173, 40);
            this.exit.TabIndex = 6;
            this.exit.Text = "Вернуться к выбору базы";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // FSredact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 367);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.addDV);
            this.Controls.Add(this.addFG);
            this.Controls.Add(this.DVs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.farmGroups);
            this.Name = "FSredact";
            this.Text = "Редактирование фармакологического справочника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox farmGroups;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox DVs;
        private System.Windows.Forms.Button addFG;
        private System.Windows.Forms.Button addDV;
        private System.Windows.Forms.Button exit;
    }
}