namespace LOL
{
    partial class frmDeleteEnvironment
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
            this.txtEnvironmentTitle = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDeleteEnvironment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Environment Title:";
            // 
            // txtEnvironmentTitle
            // 
            this.txtEnvironmentTitle.Location = new System.Drawing.Point(151, 18);
            this.txtEnvironmentTitle.Name = "txtEnvironmentTitle";
            this.txtEnvironmentTitle.Size = new System.Drawing.Size(100, 22);
            this.txtEnvironmentTitle.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(163, 62);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDeleteEnvironment
            // 
            this.btnDeleteEnvironment.Location = new System.Drawing.Point(45, 62);
            this.btnDeleteEnvironment.Name = "btnDeleteEnvironment";
            this.btnDeleteEnvironment.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteEnvironment.TabIndex = 3;
            this.btnDeleteEnvironment.Text = "Delete";
            this.btnDeleteEnvironment.UseVisualStyleBackColor = true;
            // 
            // frmDeleteEnvironment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 88);
            this.Controls.Add(this.btnDeleteEnvironment);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtEnvironmentTitle);
            this.Controls.Add(this.label1);
            this.Name = "frmDeleteEnvironment";
            this.Text = "Delete Environment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEnvironmentTitle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDeleteEnvironment;
    }
}