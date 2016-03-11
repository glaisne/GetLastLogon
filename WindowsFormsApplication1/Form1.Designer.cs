namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.lbl_Username = new System.Windows.Forms.Label();
            this.tbx_Username = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.dgv_DomainControllers = new System.Windows.Forms.DataGridView();
            this.dgv_LastLogonDate = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DomainControllers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LastLogonDate)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Location = new System.Drawing.Point(13, 13);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(77, 17);
            this.lbl_Username.TabIndex = 0;
            this.lbl_Username.Text = "Username:";
            // 
            // tbx_Username
            // 
            this.tbx_Username.Location = new System.Drawing.Point(97, 13);
            this.tbx_Username.Name = "tbx_Username";
            this.tbx_Username.Size = new System.Drawing.Size(214, 22);
            this.tbx_Username.TabIndex = 1;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(346, 11);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 2;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.OnClick);
            // 
            // dgv_DomainControllers
            // 
            this.dgv_DomainControllers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DomainControllers.Location = new System.Drawing.Point(16, 55);
            this.dgv_DomainControllers.Name = "dgv_DomainControllers";
            this.dgv_DomainControllers.RowTemplate.Height = 24;
            this.dgv_DomainControllers.Size = new System.Drawing.Size(824, 150);
            this.dgv_DomainControllers.TabIndex = 3;
            // 
            // dgv_LastLogonDate
            // 
            this.dgv_LastLogonDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LastLogonDate.Location = new System.Drawing.Point(16, 237);
            this.dgv_LastLogonDate.Name = "dgv_LastLogonDate";
            this.dgv_LastLogonDate.RowTemplate.Height = 24;
            this.dgv_LastLogonDate.Size = new System.Drawing.Size(824, 290);
            this.dgv_LastLogonDate.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 539);
            this.Controls.Add(this.dgv_LastLogonDate);
            this.Controls.Add(this.dgv_DomainControllers);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.tbx_Username);
            this.Controls.Add(this.lbl_Username);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DomainControllers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LastLogonDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.TextBox tbx_Username;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.DataGridView dgv_DomainControllers;
        private System.Windows.Forms.DataGridView dgv_LastLogonDate;
    }
}

