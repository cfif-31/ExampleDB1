
namespace ExampleDB.Forms
{
    partial class addUser
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
            this.btn_enter = new System.Windows.Forms.Button();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.dtp_dateofbird = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btn_enter
            // 
            this.btn_enter.Location = new System.Drawing.Point(12, 362);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(300, 23);
            this.btn_enter.TabIndex = 0;
            this.btn_enter.Text = "button1";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(111, 46);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(201, 20);
            this.tb_name.TabIndex = 1;
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(111, 82);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(201, 20);
            this.tb_pass.TabIndex = 2;
            // 
            // dtp_dateofbird
            // 
            this.dtp_dateofbird.Location = new System.Drawing.Point(111, 124);
            this.dtp_dateofbird.Name = "dtp_dateofbird";
            this.dtp_dateofbird.Size = new System.Drawing.Size(201, 20);
            this.dtp_dateofbird.TabIndex = 3;
            // 
            // addUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 397);
            this.Controls.Add(this.dtp_dateofbird);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.btn_enter);
            this.Name = "addUser";
            this.Text = "addUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.DateTimePicker dtp_dateofbird;
    }
}