namespace TimeReservationApp {
    partial class Form1 {
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
            this.p_panel = new System.Windows.Forms.Panel();
            this.lb_title = new System.Windows.Forms.Label();
            this.bt_minimize = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            this.p_main_panel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bt_change_passwd = new System.Windows.Forms.Button();
            this.bt_main_logout = new System.Windows.Forms.Button();
            this.bt_main_makeReservation = new System.Windows.Forms.Button();
            this.bt_main_cancel = new System.Windows.Forms.Button();
            this.bt_main_save = new System.Windows.Forms.Button();
            this.p_main_userInfo = new System.Windows.Forms.Panel();
            this.tf_main_phone = new System.Windows.Forms.TextBox();
            this.tf_main_email = new System.Windows.Forms.TextBox();
            this.tf_main_birthdate = new System.Windows.Forms.TextBox();
            this.tf_main_lastname = new System.Windows.Forms.TextBox();
            this.tf_main_name = new System.Windows.Forms.TextBox();
            this.tf_main_username = new System.Windows.Forms.TextBox();
            this.lb_main_phone_p = new System.Windows.Forms.Label();
            this.lb_main_email_p = new System.Windows.Forms.Label();
            this.lb_main_birthdate_p = new System.Windows.Forms.Label();
            this.lb_main_lastname_p = new System.Windows.Forms.Label();
            this.lb_main_name_p = new System.Windows.Forms.Label();
            this.lb_main_username_p = new System.Windows.Forms.Label();
            this.lb_main_title = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.p_panel.SuspendLayout();
            this.p_main_panel.SuspendLayout();
            this.p_main_userInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_panel
            // 
            this.p_panel.BackColor = System.Drawing.Color.Black;
            this.p_panel.Controls.Add(this.lb_title);
            this.p_panel.Controls.Add(this.bt_minimize);
            this.p_panel.Controls.Add(this.bt_exit);
            this.p_panel.Location = new System.Drawing.Point(0, 0);
            this.p_panel.Name = "p_panel";
            this.p_panel.Size = new System.Drawing.Size(829, 38);
            this.p_panel.TabIndex = 0;
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.ForeColor = System.Drawing.Color.White;
            this.lb_title.Location = new System.Drawing.Point(42, 10);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(138, 16);
            this.lb_title.TabIndex = 3;
            this.lb_title.Text = "Ajanvaraus järjestelmä";
            // 
            // bt_minimize
            // 
            this.bt_minimize.BackColor = System.Drawing.Color.Transparent;
            this.bt_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_minimize.ForeColor = System.Drawing.Color.White;
            this.bt_minimize.Location = new System.Drawing.Point(750, 8);
            this.bt_minimize.Name = "bt_minimize";
            this.bt_minimize.Size = new System.Drawing.Size(26, 23);
            this.bt_minimize.TabIndex = 2;
            this.bt_minimize.Text = "_";
            this.toolTip.SetToolTip(this.bt_minimize, "Pienennä");
            this.bt_minimize.UseVisualStyleBackColor = false;
            // 
            // bt_exit
            // 
            this.bt_exit.BackColor = System.Drawing.Color.Transparent;
            this.bt_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_exit.ForeColor = System.Drawing.Color.White;
            this.bt_exit.Location = new System.Drawing.Point(792, 8);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(26, 23);
            this.bt_exit.TabIndex = 1;
            this.bt_exit.Text = "X";
            this.toolTip.SetToolTip(this.bt_exit, "Sulje");
            this.bt_exit.UseVisualStyleBackColor = false;
            // 
            // p_main_panel
            // 
            this.p_main_panel.Controls.Add(this.tableLayoutPanel1);
            this.p_main_panel.Controls.Add(this.bt_change_passwd);
            this.p_main_panel.Controls.Add(this.bt_main_logout);
            this.p_main_panel.Controls.Add(this.bt_main_makeReservation);
            this.p_main_panel.Controls.Add(this.bt_main_cancel);
            this.p_main_panel.Controls.Add(this.bt_main_save);
            this.p_main_panel.Controls.Add(this.p_main_userInfo);
            this.p_main_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_main_panel.Location = new System.Drawing.Point(74, 99);
            this.p_main_panel.Name = "p_main_panel";
            this.p_main_panel.Size = new System.Drawing.Size(680, 318);
            this.p_main_panel.TabIndex = 1;
            this.p_main_panel.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(338, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(328, 271);
            this.tableLayoutPanel1.TabIndex = 72;
            // 
            // bt_change_passwd
            // 
            this.bt_change_passwd.BackgroundImage = global::TimeReservationApp.Properties.Resources.settings_icon_rotor_UGL_icon;
            this.bt_change_passwd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_change_passwd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_change_passwd.Location = new System.Drawing.Point(221, 15);
            this.bt_change_passwd.Name = "bt_change_passwd";
            this.bt_change_passwd.Size = new System.Drawing.Size(20, 20);
            this.bt_change_passwd.TabIndex = 70;
            this.bt_change_passwd.UseVisualStyleBackColor = true;
            // 
            // bt_main_logout
            // 
            this.bt_main_logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_main_logout.Location = new System.Drawing.Point(566, 290);
            this.bt_main_logout.Name = "bt_main_logout";
            this.bt_main_logout.Size = new System.Drawing.Size(100, 23);
            this.bt_main_logout.TabIndex = 69;
            this.bt_main_logout.Text = "Ulos";
            this.bt_main_logout.UseVisualStyleBackColor = true;
            // 
            // bt_main_makeReservation
            // 
            this.bt_main_makeReservation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_main_makeReservation.Location = new System.Drawing.Point(338, 290);
            this.bt_main_makeReservation.Name = "bt_main_makeReservation";
            this.bt_main_makeReservation.Size = new System.Drawing.Size(100, 23);
            this.bt_main_makeReservation.TabIndex = 38;
            this.bt_main_makeReservation.Text = "Varaa aika";
            this.bt_main_makeReservation.UseVisualStyleBackColor = true;
            // 
            // bt_main_cancel
            // 
            this.bt_main_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_main_cancel.Location = new System.Drawing.Point(15, 290);
            this.bt_main_cancel.Name = "bt_main_cancel";
            this.bt_main_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_main_cancel.TabIndex = 9;
            this.bt_main_cancel.Text = "Peruuta";
            this.bt_main_cancel.UseVisualStyleBackColor = true;
            // 
            // bt_main_save
            // 
            this.bt_main_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_main_save.Location = new System.Drawing.Point(139, 290);
            this.bt_main_save.Name = "bt_main_save";
            this.bt_main_save.Size = new System.Drawing.Size(75, 23);
            this.bt_main_save.TabIndex = 8;
            this.bt_main_save.Text = "Tallenna";
            this.bt_main_save.UseVisualStyleBackColor = true;
            // 
            // p_main_userInfo
            // 
            this.p_main_userInfo.BackColor = System.Drawing.Color.DimGray;
            this.p_main_userInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p_main_userInfo.Controls.Add(this.tf_main_phone);
            this.p_main_userInfo.Controls.Add(this.tf_main_email);
            this.p_main_userInfo.Controls.Add(this.tf_main_birthdate);
            this.p_main_userInfo.Controls.Add(this.tf_main_lastname);
            this.p_main_userInfo.Controls.Add(this.tf_main_name);
            this.p_main_userInfo.Controls.Add(this.tf_main_username);
            this.p_main_userInfo.Controls.Add(this.lb_main_phone_p);
            this.p_main_userInfo.Controls.Add(this.lb_main_email_p);
            this.p_main_userInfo.Controls.Add(this.lb_main_birthdate_p);
            this.p_main_userInfo.Controls.Add(this.lb_main_lastname_p);
            this.p_main_userInfo.Controls.Add(this.lb_main_name_p);
            this.p_main_userInfo.Controls.Add(this.lb_main_username_p);
            this.p_main_userInfo.Controls.Add(this.lb_main_title);
            this.p_main_userInfo.Location = new System.Drawing.Point(15, 15);
            this.p_main_userInfo.Name = "p_main_userInfo";
            this.p_main_userInfo.Size = new System.Drawing.Size(200, 273);
            this.p_main_userInfo.TabIndex = 6;
            // 
            // tf_main_phone
            // 
            this.tf_main_phone.BackColor = System.Drawing.Color.Black;
            this.tf_main_phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_main_phone.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tf_main_phone.ForeColor = System.Drawing.Color.White;
            this.tf_main_phone.Location = new System.Drawing.Point(25, 236);
            this.tf_main_phone.Name = "tf_main_phone";
            this.tf_main_phone.Size = new System.Drawing.Size(144, 20);
            this.tf_main_phone.TabIndex = 34;
            this.tf_main_phone.Text = "test";
            // 
            // tf_main_email
            // 
            this.tf_main_email.BackColor = System.Drawing.Color.Black;
            this.tf_main_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_main_email.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tf_main_email.ForeColor = System.Drawing.Color.White;
            this.tf_main_email.Location = new System.Drawing.Point(25, 197);
            this.tf_main_email.Name = "tf_main_email";
            this.tf_main_email.Size = new System.Drawing.Size(144, 20);
            this.tf_main_email.TabIndex = 33;
            this.tf_main_email.Text = "test";
            // 
            // tf_main_birthdate
            // 
            this.tf_main_birthdate.BackColor = System.Drawing.Color.Black;
            this.tf_main_birthdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_main_birthdate.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tf_main_birthdate.ForeColor = System.Drawing.Color.White;
            this.tf_main_birthdate.Location = new System.Drawing.Point(25, 158);
            this.tf_main_birthdate.Name = "tf_main_birthdate";
            this.tf_main_birthdate.Size = new System.Drawing.Size(144, 20);
            this.tf_main_birthdate.TabIndex = 32;
            this.tf_main_birthdate.Text = "test";
            // 
            // tf_main_lastname
            // 
            this.tf_main_lastname.BackColor = System.Drawing.Color.Black;
            this.tf_main_lastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_main_lastname.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tf_main_lastname.ForeColor = System.Drawing.Color.White;
            this.tf_main_lastname.Location = new System.Drawing.Point(25, 119);
            this.tf_main_lastname.Name = "tf_main_lastname";
            this.tf_main_lastname.Size = new System.Drawing.Size(144, 20);
            this.tf_main_lastname.TabIndex = 31;
            this.tf_main_lastname.Text = "test";
            // 
            // tf_main_name
            // 
            this.tf_main_name.BackColor = System.Drawing.Color.Black;
            this.tf_main_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_main_name.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tf_main_name.ForeColor = System.Drawing.Color.White;
            this.tf_main_name.Location = new System.Drawing.Point(25, 80);
            this.tf_main_name.Name = "tf_main_name";
            this.tf_main_name.Size = new System.Drawing.Size(144, 20);
            this.tf_main_name.TabIndex = 30;
            this.tf_main_name.Text = "test";
            // 
            // tf_main_username
            // 
            this.tf_main_username.BackColor = System.Drawing.Color.Black;
            this.tf_main_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tf_main_username.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tf_main_username.ForeColor = System.Drawing.Color.White;
            this.tf_main_username.Location = new System.Drawing.Point(25, 41);
            this.tf_main_username.Name = "tf_main_username";
            this.tf_main_username.Size = new System.Drawing.Size(144, 20);
            this.tf_main_username.TabIndex = 29;
            this.tf_main_username.Text = "test";
            // 
            // lb_main_phone_p
            // 
            this.lb_main_phone_p.AutoSize = true;
            this.lb_main_phone_p.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_main_phone_p.ForeColor = System.Drawing.Color.White;
            this.lb_main_phone_p.Location = new System.Drawing.Point(24, 220);
            this.lb_main_phone_p.Name = "lb_main_phone_p";
            this.lb_main_phone_p.Size = new System.Drawing.Size(44, 13);
            this.lb_main_phone_p.TabIndex = 26;
            this.lb_main_phone_p.Text = "Puhelin";
            // 
            // lb_main_email_p
            // 
            this.lb_main_email_p.AutoSize = true;
            this.lb_main_email_p.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_main_email_p.ForeColor = System.Drawing.Color.White;
            this.lb_main_email_p.Location = new System.Drawing.Point(22, 181);
            this.lb_main_email_p.Name = "lb_main_email_p";
            this.lb_main_email_p.Size = new System.Drawing.Size(60, 13);
            this.lb_main_email_p.TabIndex = 25;
            this.lb_main_email_p.Text = "Sähköposti";
            // 
            // lb_main_birthdate_p
            // 
            this.lb_main_birthdate_p.AutoSize = true;
            this.lb_main_birthdate_p.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_main_birthdate_p.ForeColor = System.Drawing.Color.White;
            this.lb_main_birthdate_p.Location = new System.Drawing.Point(24, 142);
            this.lb_main_birthdate_p.Name = "lb_main_birthdate_p";
            this.lb_main_birthdate_p.Size = new System.Drawing.Size(72, 13);
            this.lb_main_birthdate_p.TabIndex = 24;
            this.lb_main_birthdate_p.Text = "Syntymäpäivä";
            // 
            // lb_main_lastname_p
            // 
            this.lb_main_lastname_p.AutoSize = true;
            this.lb_main_lastname_p.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_main_lastname_p.ForeColor = System.Drawing.Color.White;
            this.lb_main_lastname_p.Location = new System.Drawing.Point(24, 103);
            this.lb_main_lastname_p.Name = "lb_main_lastname_p";
            this.lb_main_lastname_p.Size = new System.Drawing.Size(50, 13);
            this.lb_main_lastname_p.TabIndex = 23;
            this.lb_main_lastname_p.Text = "Sukunimi";
            // 
            // lb_main_name_p
            // 
            this.lb_main_name_p.AutoSize = true;
            this.lb_main_name_p.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_main_name_p.ForeColor = System.Drawing.Color.White;
            this.lb_main_name_p.Location = new System.Drawing.Point(24, 64);
            this.lb_main_name_p.Name = "lb_main_name_p";
            this.lb_main_name_p.Size = new System.Drawing.Size(42, 13);
            this.lb_main_name_p.TabIndex = 22;
            this.lb_main_name_p.Text = "Etunimi";
            // 
            // lb_main_username_p
            // 
            this.lb_main_username_p.AutoSize = true;
            this.lb_main_username_p.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_main_username_p.ForeColor = System.Drawing.Color.White;
            this.lb_main_username_p.Location = new System.Drawing.Point(24, 25);
            this.lb_main_username_p.Name = "lb_main_username_p";
            this.lb_main_username_p.Size = new System.Drawing.Size(77, 13);
            this.lb_main_username_p.TabIndex = 21;
            this.lb_main_username_p.Text = "Käyttäjätunnus";
            // 
            // lb_main_title
            // 
            this.lb_main_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_main_title.ForeColor = System.Drawing.Color.White;
            this.lb_main_title.Location = new System.Drawing.Point(-2, 0);
            this.lb_main_title.Name = "lb_main_title";
            this.lb_main_title.Size = new System.Drawing.Size(200, 25);
            this.lb_main_title.TabIndex = 2;
            this.lb_main_title.Text = "          Tiedot          ";
            this.lb_main_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TimeReservationApp.Properties.Resources.landscape_background_balloon_e;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(829, 451);
            this.Controls.Add(this.p_main_panel);
            this.Controls.Add(this.p_panel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajan varaus applikaatio";
            this.p_panel.ResumeLayout(false);
            this.p_panel.PerformLayout();
            this.p_main_panel.ResumeLayout(false);
            this.p_main_userInfo.ResumeLayout(false);
            this.p_main_userInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bt_minimize;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Panel p_main_panel;
        private System.Windows.Forms.ToolTip toolTip;
        protected System.Windows.Forms.Panel p_panel;
        private System.Windows.Forms.Label lb_main_title;
        private System.Windows.Forms.Panel p_main_userInfo;
        private System.Windows.Forms.Label lb_main_username_p;
        private System.Windows.Forms.Label lb_main_phone_p;
        private System.Windows.Forms.Label lb_main_email_p;
        private System.Windows.Forms.Label lb_main_birthdate_p;
        private System.Windows.Forms.Label lb_main_lastname_p;
        private System.Windows.Forms.Label lb_main_name_p;
        private System.Windows.Forms.TextBox tf_main_birthdate;
        private System.Windows.Forms.TextBox tf_main_lastname;
        private System.Windows.Forms.TextBox tf_main_name;
        private System.Windows.Forms.TextBox tf_main_username;
        private System.Windows.Forms.TextBox tf_main_phone;
        private System.Windows.Forms.TextBox tf_main_email;
        private System.Windows.Forms.Button bt_main_cancel;
        private System.Windows.Forms.Button bt_main_save;
        private System.Windows.Forms.Button bt_main_makeReservation;
        private System.Windows.Forms.Button bt_main_logout;
        private System.Windows.Forms.Button bt_change_passwd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

