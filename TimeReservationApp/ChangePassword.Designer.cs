namespace TimeReservationApp {
    partial class ChangePassword {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.p_change_panel = new System.Windows.Forms.Panel();
            this.lb_change_title = new System.Windows.Forms.Label();
            this.bt_change_minimize = new System.Windows.Forms.Button();
            this.bt_change_exit = new System.Windows.Forms.Button();
            this.tf_old_pwd = new System.Windows.Forms.TextBox();
            this.tf_new_pwd = new System.Windows.Forms.TextBox();
            this.tf_new_pwd_again = new System.Windows.Forms.TextBox();
            this.lb_old_pwd = new System.Windows.Forms.Label();
            this.lb_new_pwd = new System.Windows.Forms.Label();
            this.lb_new_pwd_again = new System.Windows.Forms.Label();
            this.bt_change = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.p_change_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_change_panel
            // 
            this.p_change_panel.BackColor = System.Drawing.Color.Black;
            this.p_change_panel.Controls.Add(this.lb_change_title);
            this.p_change_panel.Controls.Add(this.bt_change_minimize);
            this.p_change_panel.Controls.Add(this.bt_change_exit);
            this.p_change_panel.Location = new System.Drawing.Point(0, 0);
            this.p_change_panel.Name = "p_change_panel";
            this.p_change_panel.Size = new System.Drawing.Size(336, 38);
            this.p_change_panel.TabIndex = 0;
            // 
            // lb_change_title
            // 
            this.lb_change_title.AutoSize = true;
            this.lb_change_title.BackColor = System.Drawing.Color.Transparent;
            this.lb_change_title.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_change_title.ForeColor = System.Drawing.Color.White;
            this.lb_change_title.Location = new System.Drawing.Point(42, 10);
            this.lb_change_title.Name = "lb_change_title";
            this.lb_change_title.Size = new System.Drawing.Size(112, 16);
            this.lb_change_title.TabIndex = 2;
            this.lb_change_title.Text = "Vaihda salasana";
            // 
            // bt_change_minimize
            // 
            this.bt_change_minimize.BackColor = System.Drawing.Color.Transparent;
            this.bt_change_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_change_minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_change_minimize.ForeColor = System.Drawing.Color.White;
            this.bt_change_minimize.Location = new System.Drawing.Point(257, 8);
            this.bt_change_minimize.Name = "bt_change_minimize";
            this.bt_change_minimize.Size = new System.Drawing.Size(26, 23);
            this.bt_change_minimize.TabIndex = 1;
            this.bt_change_minimize.Text = "_";
            this.bt_change_minimize.UseVisualStyleBackColor = false;
            // 
            // bt_change_exit
            // 
            this.bt_change_exit.BackColor = System.Drawing.Color.Transparent;
            this.bt_change_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_change_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_change_exit.ForeColor = System.Drawing.Color.White;
            this.bt_change_exit.Location = new System.Drawing.Point(299, 8);
            this.bt_change_exit.Name = "bt_change_exit";
            this.bt_change_exit.Size = new System.Drawing.Size(26, 23);
            this.bt_change_exit.TabIndex = 0;
            this.bt_change_exit.Text = "X";
            this.bt_change_exit.UseVisualStyleBackColor = false;
            // 
            // tf_old_pwd
            // 
            this.tf_old_pwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_old_pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tf_old_pwd.Location = new System.Drawing.Point(105, 65);
            this.tf_old_pwd.Name = "tf_old_pwd";
            this.tf_old_pwd.PasswordChar = '*';
            this.tf_old_pwd.Size = new System.Drawing.Size(132, 23);
            this.tf_old_pwd.TabIndex = 1;
            this.tf_old_pwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tf_new_pwd
            // 
            this.tf_new_pwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_new_pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tf_new_pwd.Location = new System.Drawing.Point(105, 109);
            this.tf_new_pwd.Name = "tf_new_pwd";
            this.tf_new_pwd.PasswordChar = '*';
            this.tf_new_pwd.Size = new System.Drawing.Size(132, 23);
            this.tf_new_pwd.TabIndex = 2;
            this.tf_new_pwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tf_new_pwd_again
            // 
            this.tf_new_pwd_again.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_new_pwd_again.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tf_new_pwd_again.Location = new System.Drawing.Point(105, 153);
            this.tf_new_pwd_again.Name = "tf_new_pwd_again";
            this.tf_new_pwd_again.PasswordChar = '*';
            this.tf_new_pwd_again.Size = new System.Drawing.Size(132, 23);
            this.tf_new_pwd_again.TabIndex = 3;
            this.tf_new_pwd_again.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_old_pwd
            // 
            this.lb_old_pwd.AutoSize = true;
            this.lb_old_pwd.BackColor = System.Drawing.Color.Transparent;
            this.lb_old_pwd.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_old_pwd.ForeColor = System.Drawing.Color.White;
            this.lb_old_pwd.Location = new System.Drawing.Point(102, 48);
            this.lb_old_pwd.Name = "lb_old_pwd";
            this.lb_old_pwd.Size = new System.Drawing.Size(75, 14);
            this.lb_old_pwd.TabIndex = 4;
            this.lb_old_pwd.Text = "Vanha salasana";
            // 
            // lb_new_pwd
            // 
            this.lb_new_pwd.AutoSize = true;
            this.lb_new_pwd.BackColor = System.Drawing.Color.Transparent;
            this.lb_new_pwd.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_new_pwd.ForeColor = System.Drawing.Color.White;
            this.lb_new_pwd.Location = new System.Drawing.Point(101, 92);
            this.lb_new_pwd.Name = "lb_new_pwd";
            this.lb_new_pwd.Size = new System.Drawing.Size(67, 14);
            this.lb_new_pwd.TabIndex = 5;
            this.lb_new_pwd.Text = "Uusi salasana";
            // 
            // lb_new_pwd_again
            // 
            this.lb_new_pwd_again.AutoSize = true;
            this.lb_new_pwd_again.BackColor = System.Drawing.Color.Transparent;
            this.lb_new_pwd_again.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_new_pwd_again.ForeColor = System.Drawing.Color.White;
            this.lb_new_pwd_again.Location = new System.Drawing.Point(102, 136);
            this.lb_new_pwd_again.Name = "lb_new_pwd_again";
            this.lb_new_pwd_again.Size = new System.Drawing.Size(90, 14);
            this.lb_new_pwd_again.TabIndex = 6;
            this.lb_new_pwd_again.Text = "Salasana uudelleen";
            // 
            // bt_change
            // 
            this.bt_change.BackColor = System.Drawing.Color.Black;
            this.bt_change.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_change.ForeColor = System.Drawing.Color.White;
            this.bt_change.Location = new System.Drawing.Point(105, 184);
            this.bt_change.Name = "bt_change";
            this.bt_change.Size = new System.Drawing.Size(132, 23);
            this.bt_change.TabIndex = 7;
            this.bt_change.Text = "OK";
            this.bt_change.UseVisualStyleBackColor = false;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TimeReservationApp.Properties.Resources.change_passwd_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(336, 219);
            this.Controls.Add(this.bt_change);
            this.Controls.Add(this.lb_new_pwd_again);
            this.Controls.Add(this.lb_new_pwd);
            this.Controls.Add(this.lb_old_pwd);
            this.Controls.Add(this.tf_new_pwd_again);
            this.Controls.Add(this.tf_new_pwd);
            this.Controls.Add(this.tf_old_pwd);
            this.Controls.Add(this.p_change_panel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            this.p_change_panel.ResumeLayout(false);
            this.p_change_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel p_change_panel;
        private System.Windows.Forms.Button bt_change_exit;
        private System.Windows.Forms.Button bt_change_minimize;
        private System.Windows.Forms.TextBox tf_old_pwd;
        private System.Windows.Forms.TextBox tf_new_pwd;
        private System.Windows.Forms.TextBox tf_new_pwd_again;
        private System.Windows.Forms.Label lb_old_pwd;
        private System.Windows.Forms.Label lb_new_pwd;
        private System.Windows.Forms.Label lb_new_pwd_again;
        private System.Windows.Forms.Button bt_change;
        private System.Windows.Forms.Label lb_change_title;
        private System.Windows.Forms.ToolTip toolTip;
    }
}