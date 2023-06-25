namespace LOL
{
    partial class frmEditEnvironment
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
            this.btnEditEnvironment = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtEnvironmentType = new System.Windows.Forms.TextBox();
            this.txtEnvironmentTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEditEnvironment
            // 
            this.btnEditEnvironment.Location = new System.Drawing.Point(59, 91);
            this.btnEditEnvironment.Name = "btnEditEnvironment";
            this.btnEditEnvironment.Size = new System.Drawing.Size(75, 23);
            this.btnEditEnvironment.TabIndex = 11;
            this.btnEditEnvironment.Text = "Edit";
            this.btnEditEnvironment.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(159, 91);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtEnvironmentType
            // 
            this.txtEnvironmentType.Location = new System.Drawing.Point(134, 46);
            this.txtEnvironmentType.Name = "txtEnvironmentType";
            this.txtEnvironmentType.Size = new System.Drawing.Size(100, 22);
            this.txtEnvironmentType.TabIndex = 9;
            // 
            // txtEnvironmentTitle
            // 
            this.txtEnvironmentTitle.Location = new System.Drawing.Point(134, 13);
            this.txtEnvironmentTitle.Name = "txtEnvironmentTitle";
            this.txtEnvironmentTitle.Size = new System.Drawing.Size(100, 22);
            this.txtEnvironmentTitle.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Title";
            // 
            // frmEditEnvironment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 133);
            this.Controls.Add(this.btnEditEnvironment);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtEnvironmentType);
            this.Controls.Add(this.txtEnvironmentTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmEditEnvironment";
            this.Text = "Edit Environment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditEnvironment;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtEnvironmentType;
        private System.Windows.Forms.TextBox txtEnvironmentTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}