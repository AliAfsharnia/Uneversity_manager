namespace LOL
{
    partial class frmEditSuff
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
            this.btnEditStuff = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtstuffStatus = new System.Windows.Forms.TextBox();
            this.txtStuffTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStuffEnvironment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEditStuff
            // 
            this.btnEditStuff.Location = new System.Drawing.Point(44, 135);
            this.btnEditStuff.Name = "btnEditStuff";
            this.btnEditStuff.Size = new System.Drawing.Size(75, 23);
            this.btnEditStuff.TabIndex = 17;
            this.btnEditStuff.Text = "Edit";
            this.btnEditStuff.UseVisualStyleBackColor = true;
            this.btnEditStuff.Click += new System.EventHandler(this.btnEditStuff_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(144, 135);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtstuffStatus
            // 
            this.txtstuffStatus.Location = new System.Drawing.Point(113, 49);
            this.txtstuffStatus.Name = "txtstuffStatus";
            this.txtstuffStatus.Size = new System.Drawing.Size(100, 22);
            this.txtstuffStatus.TabIndex = 15;
            // 
            // txtStuffTitle
            // 
            this.txtStuffTitle.Location = new System.Drawing.Point(113, 12);
            this.txtStuffTitle.Name = "txtStuffTitle";
            this.txtStuffTitle.Size = new System.Drawing.Size(100, 22);
            this.txtStuffTitle.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Title";
            // 
            // txtStuffEnvironment
            // 
            this.txtStuffEnvironment.Location = new System.Drawing.Point(113, 87);
            this.txtStuffEnvironment.Name = "txtStuffEnvironment";
            this.txtStuffEnvironment.Size = new System.Drawing.Size(100, 22);
            this.txtStuffEnvironment.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Evironment";
            // 
            // frmEditSuff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 179);
            this.Controls.Add(this.txtStuffEnvironment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEditStuff);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtstuffStatus);
            this.Controls.Add(this.txtStuffTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmEditSuff";
            this.Text = "frmEditSuff";
            this.Load += new System.EventHandler(this.frmEditSuff_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditStuff;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtstuffStatus;
        private System.Windows.Forms.TextBox txtStuffTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStuffEnvironment;
        private System.Windows.Forms.Label label3;
    }
}