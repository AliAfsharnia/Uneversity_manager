namespace LOL
{
    partial class frmAddEnvironment
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtEnvironmentTitle = new System.Windows.Forms.TextBox();
            this.txtEnvironmentType = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddEnvironment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type";
            // 
            // txtEnvironmentTitle
            // 
            this.txtEnvironmentTitle.Location = new System.Drawing.Point(125, 16);
            this.txtEnvironmentTitle.Name = "txtEnvironmentTitle";
            this.txtEnvironmentTitle.Size = new System.Drawing.Size(100, 22);
            this.txtEnvironmentTitle.TabIndex = 2;
            this.txtEnvironmentTitle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtEnvironmentType
            // 
            this.txtEnvironmentType.Location = new System.Drawing.Point(125, 49);
            this.txtEnvironmentType.Name = "txtEnvironmentType";
            this.txtEnvironmentType.Size = new System.Drawing.Size(100, 22);
            this.txtEnvironmentType.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(150, 94);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAddEnvironment
            // 
            this.btnAddEnvironment.Location = new System.Drawing.Point(50, 94);
            this.btnAddEnvironment.Name = "btnAddEnvironment";
            this.btnAddEnvironment.Size = new System.Drawing.Size(75, 23);
            this.btnAddEnvironment.TabIndex = 5;
            this.btnAddEnvironment.Text = "Add";
            this.btnAddEnvironment.UseVisualStyleBackColor = true;
            this.btnAddEnvironment.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmAddEnvironment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 122);
            this.Controls.Add(this.btnAddEnvironment);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtEnvironmentType);
            this.Controls.Add(this.txtEnvironmentTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAddEnvironment";
            this.Text = "Add Environment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEnvironmentTitle;
        private System.Windows.Forms.TextBox txtEnvironmentType;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddEnvironment;
    }
}