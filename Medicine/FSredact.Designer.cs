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
            this.components = new System.ComponentModel.Container();
            this.farmGroups = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DVs = new System.Windows.Forms.ListBox();
            this.knowledgeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.knowledgeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // farmGroups
            // 
            this.farmGroups.DataSource = this.knowledgeBindingSource;
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
            // knowledgeBindingSource
            // 
            this.knowledgeBindingSource.DataSource = typeof(Medicine.Knowledge);
            // 
            // FSredact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 358);
            this.Controls.Add(this.DVs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.farmGroups);
            this.Name = "FSredact";
            this.Text = "Редактирование фармакологического справочника";
            ((System.ComponentModel.ISupportInitialize)(this.knowledgeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox farmGroups;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox DVs;
        private System.Windows.Forms.BindingSource knowledgeBindingSource;
    }
}