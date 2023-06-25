namespace LOL
{
    partial class frmAddStuff
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
            this.Title = new System.Windows.Forms.Label();
            this.Environment = new System.Windows.Forms.Label();
            this.txtStuffEnvironment = new System.Windows.Forms.TextBox();
            this.txtStuffTitle = new System.Windows.Forms.TextBox();
            this.btnAddStuff = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(21, 18);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(33, 16);
            this.Title.TabIndex = 0;
            this.Title.Text = "Title";
            // 
            // Environment
            // 
            this.Environment.AutoSize = true;
            this.Environment.Location = new System.Drawing.Point(21, 54);
            this.Environment.Name = "Environment";
            this.Environment.Size = new System.Drawing.Size(81, 16);
            this.Environment.TabIndex = 1;
            this.Environment.Text = "Environment";
            // 
            // txtStuffEnvironment
            // 
            this.txtStuffEnvironment.Location = new System.Drawing.Point(116, 48);
            this.txtStuffEnvironment.Name = "txtStuffEnvironment";
            this.txtStuffEnvironment.Size = new System.Drawing.Size(100, 22);
            this.txtStuffEnvironment.TabIndex = 5;
            // 
            // txtStuffTitle
            // 
            this.txtStuffTitle.Location = new System.Drawing.Point(116, 15);
            this.txtStuffTitle.Name = "txtStuffTitle";
            this.txtStuffTitle.Size = new System.Drawing.Size(100, 22);
            this.txtStuffTitle.TabIndex = 4;
            // 
            // btnAddStuff
            // 
            this.btnAddStuff.Location = new System.Drawing.Point(27, 92);
            this.btnAddStuff.Name = "btnAddStuff";
            this.btnAddStuff.Size = new System.Drawing.Size(75, 23);
            this.btnAddStuff.TabIndex = 13;
            this.btnAddStuff.Text = "Add";
            this.btnAddStuff.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(127, 92);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmAddStuff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 127);
            this.Controls.Add(this.btnAddStuff);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtStuffEnvironment);
            this.Controls.Add(this.txtStuffTitle);
            this.Controls.Add(this.Environment);
            this.Controls.Add(this.Title);
            this.Name = "frmAddStuff";
            this.Text = "Add Stuff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Environment;
        private System.Windows.Forms.TextBox txtStuffEnvironment;
        private System.Windows.Forms.TextBox txtStuffTitle;
        private System.Windows.Forms.Button btnAddStuff;
        private System.Windows.Forms.Button btnCancel;
    }
}