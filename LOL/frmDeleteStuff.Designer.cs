namespace LOL
{
    partial class frmDeleteStuff
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
            this.btnDeleteStuff = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtStuffId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDeleteStuff
            // 
            this.btnDeleteStuff.Location = new System.Drawing.Point(44, 72);
            this.btnDeleteStuff.Name = "btnDeleteStuff";
            this.btnDeleteStuff.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteStuff.TabIndex = 7;
            this.btnDeleteStuff.Text = "Delete";
            this.btnDeleteStuff.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(137, 72);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtStuffId
            // 
            this.txtStuffId.Location = new System.Drawing.Point(112, 28);
            this.txtStuffId.Name = "txtStuffId";
            this.txtStuffId.Size = new System.Drawing.Size(100, 22);
            this.txtStuffId.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "S_ID";
            // 
            // frmDeleteStuff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 110);
            this.Controls.Add(this.btnDeleteStuff);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtStuffId);
            this.Controls.Add(this.label1);
            this.Name = "frmDeleteStuff";
            this.Text = "frmDeleteStuff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteStuff;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtStuffId;
        private System.Windows.Forms.Label label1;
    }
}