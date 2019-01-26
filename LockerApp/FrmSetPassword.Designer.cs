namespace LockerApp
{
    partial class FrmSetPassword
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPw1 = new System.Windows.Forms.TextBox();
            this.txtPw2 = new System.Windows.Forms.TextBox();
            this.txtOldPw = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(44, 119);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(165, 119);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Confrim password :";
            // 
            // txtPw1
            // 
            this.txtPw1.Location = new System.Drawing.Point(99, 28);
            this.txtPw1.Name = "txtPw1";
            this.txtPw1.Size = new System.Drawing.Size(157, 20);
            this.txtPw1.TabIndex = 4;
            this.txtPw1.UseSystemPasswordChar = true;
            // 
            // txtPw2
            // 
            this.txtPw2.Location = new System.Drawing.Point(99, 57);
            this.txtPw2.Name = "txtPw2";
            this.txtPw2.Size = new System.Drawing.Size(157, 20);
            this.txtPw2.TabIndex = 5;
            this.txtPw2.UseSystemPasswordChar = true;
            // 
            // txtOldPw
            // 
            this.txtOldPw.Location = new System.Drawing.Point(99, 89);
            this.txtOldPw.Name = "txtOldPw";
            this.txtOldPw.Size = new System.Drawing.Size(157, 20);
            this.txtOldPw.TabIndex = 7;
            this.txtOldPw.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Old password:";
            // 
            // FrmSetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 154);
            this.Controls.Add(this.txtOldPw);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPw2);
            this.Controls.Add(this.txtPw1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSetPassword";
            this.Text = "Locker Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPw1;
        private System.Windows.Forms.TextBox txtPw2;
        private System.Windows.Forms.TextBox txtOldPw;
        private System.Windows.Forms.Label label3;
    }
}