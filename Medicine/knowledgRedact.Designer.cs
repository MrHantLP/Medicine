namespace Medicine
{
    partial class knowledgRedact
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
            this.redactFS = new System.Windows.Forms.Button();
            this.redactBaseOfKnow = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // redactFS
            // 
            this.redactFS.Location = new System.Drawing.Point(30, 22);
            this.redactFS.Name = "redactFS";
            this.redactFS.Size = new System.Drawing.Size(400, 45);
            this.redactFS.TabIndex = 0;
            this.redactFS.Text = "Редактировать фармакологический справочник";
            this.redactFS.UseVisualStyleBackColor = true;
            this.redactFS.Click += new System.EventHandler(this.redactFS_Click);
            // 
            // redactBaseOfKnow
            // 
            this.redactBaseOfKnow.Location = new System.Drawing.Point(30, 96);
            this.redactBaseOfKnow.Name = "redactBaseOfKnow";
            this.redactBaseOfKnow.Size = new System.Drawing.Size(400, 45);
            this.redactBaseOfKnow.TabIndex = 1;
            this.redactBaseOfKnow.Text = "Редактировать базу знаний о лечении заболеваний";
            this.redactBaseOfKnow.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(378, 154);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(116, 35);
            this.exit.TabIndex = 2;
            this.exit.Text = "Вернуться к главному меню";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // knowledgRedact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 201);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.redactBaseOfKnow);
            this.Controls.Add(this.redactFS);
            this.Name = "knowledgRedact";
            this.Text = "Редактор баз знаний";
            this.Load += new System.EventHandler(this.knowledgRedact_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button redactFS;
        private System.Windows.Forms.Button redactBaseOfKnow;
        private System.Windows.Forms.Button exit;
    }
}