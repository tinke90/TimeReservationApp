namespace TimeReservationApp {
    partial class Reservation {
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
            this.p_reservation_panel = new System.Windows.Forms.Panel();
            this.lb_reservation_title = new System.Windows.Forms.Label();
            this.tf_name = new System.Windows.Forms.TextBox();
            this.lb_reservation_name = new System.Windows.Forms.Label();
            this.bt_reservation_exit = new System.Windows.Forms.Button();
            this.cb_at = new System.Windows.Forms.ComboBox();
            this.cb_to = new System.Windows.Forms.ComboBox();
            this.between = new System.Windows.Forms.Label();
            this.tf_lastname = new System.Windows.Forms.TextBox();
            this.lb_lastname = new System.Windows.Forms.Label();
            this.lb_time = new System.Windows.Forms.Label();
            this.bt_reservation_cancel = new System.Windows.Forms.Button();
            this.bt_reservation_accept = new System.Windows.Forms.Button();
            this.cb_reservation = new System.Windows.Forms.ComboBox();
            this.lb_reservation = new System.Windows.Forms.Label();
            this.dt_datepicker = new System.Windows.Forms.DateTimePicker();
            this.lb_date = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.p_reservation_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_reservation_panel
            // 
            this.p_reservation_panel.BackColor = System.Drawing.Color.Black;
            this.p_reservation_panel.Controls.Add(this.bt_reservation_exit);
            this.p_reservation_panel.Controls.Add(this.lb_reservation_title);
            this.p_reservation_panel.Location = new System.Drawing.Point(0, 0);
            this.p_reservation_panel.Name = "p_reservation_panel";
            this.p_reservation_panel.Size = new System.Drawing.Size(330, 38);
            this.p_reservation_panel.TabIndex = 0;
            // 
            // lb_reservation_title
            // 
            this.lb_reservation_title.AutoSize = true;
            this.lb_reservation_title.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_reservation_title.ForeColor = System.Drawing.Color.White;
            this.lb_reservation_title.Location = new System.Drawing.Point(42, 10);
            this.lb_reservation_title.Name = "lb_reservation_title";
            this.lb_reservation_title.Size = new System.Drawing.Size(104, 16);
            this.lb_reservation_title.TabIndex = 0;
            this.lb_reservation_title.Text = "Sup lauta varaus";
            // 
            // tf_name
            // 
            this.tf_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tf_name.Location = new System.Drawing.Point(84, 75);
            this.tf_name.Name = "tf_name";
            this.tf_name.Size = new System.Drawing.Size(162, 23);
            this.tf_name.TabIndex = 2;
            // 
            // lb_reservation_name
            // 
            this.lb_reservation_name.AutoSize = true;
            this.lb_reservation_name.BackColor = System.Drawing.Color.Transparent;
            this.lb_reservation_name.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Italic);
            this.lb_reservation_name.ForeColor = System.Drawing.Color.White;
            this.lb_reservation_name.Location = new System.Drawing.Point(81, 59);
            this.lb_reservation_name.Name = "lb_reservation_name";
            this.lb_reservation_name.Size = new System.Drawing.Size(27, 13);
            this.lb_reservation_name.TabIndex = 2;
            this.lb_reservation_name.Text = "Nimi";
            // 
            // bt_reservation_exit
            // 
            this.bt_reservation_exit.BackColor = System.Drawing.Color.Transparent;
            this.bt_reservation_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_reservation_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_reservation_exit.ForeColor = System.Drawing.Color.White;
            this.bt_reservation_exit.Location = new System.Drawing.Point(296, 8);
            this.bt_reservation_exit.Name = "bt_reservation_exit";
            this.bt_reservation_exit.Size = new System.Drawing.Size(26, 23);
            this.bt_reservation_exit.TabIndex = 3;
            this.bt_reservation_exit.Text = "X";
            this.bt_reservation_exit.UseVisualStyleBackColor = false;
            // 
            // cb_at
            // 
            this.cb_at.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_at.FormattingEnabled = true;
            this.cb_at.Location = new System.Drawing.Point(84, 266);
            this.cb_at.Name = "cb_at";
            this.cb_at.Size = new System.Drawing.Size(68, 24);
            this.cb_at.TabIndex = 6;
            // 
            // cb_to
            // 
            this.cb_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_to.FormattingEnabled = true;
            this.cb_to.Location = new System.Drawing.Point(178, 266);
            this.cb_to.Name = "cb_to";
            this.cb_to.Size = new System.Drawing.Size(68, 24);
            this.cb_to.TabIndex = 7;
            // 
            // between
            // 
            this.between.AutoSize = true;
            this.between.BackColor = System.Drawing.Color.Transparent;
            this.between.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.between.ForeColor = System.Drawing.Color.White;
            this.between.Location = new System.Drawing.Point(158, 267);
            this.between.Name = "between";
            this.between.Size = new System.Drawing.Size(14, 19);
            this.between.TabIndex = 5;
            this.between.Text = "-";
            // 
            // tf_lastname
            // 
            this.tf_lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tf_lastname.Location = new System.Drawing.Point(84, 123);
            this.tf_lastname.Name = "tf_lastname";
            this.tf_lastname.Size = new System.Drawing.Size(162, 23);
            this.tf_lastname.TabIndex = 3;
            // 
            // lb_lastname
            // 
            this.lb_lastname.AutoSize = true;
            this.lb_lastname.BackColor = System.Drawing.Color.Transparent;
            this.lb_lastname.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Italic);
            this.lb_lastname.ForeColor = System.Drawing.Color.White;
            this.lb_lastname.Location = new System.Drawing.Point(81, 108);
            this.lb_lastname.Name = "lb_lastname";
            this.lb_lastname.Size = new System.Drawing.Size(50, 13);
            this.lb_lastname.TabIndex = 7;
            this.lb_lastname.Text = "Sukunimi";
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.BackColor = System.Drawing.Color.Transparent;
            this.lb_time.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Italic);
            this.lb_time.ForeColor = System.Drawing.Color.White;
            this.lb_time.Location = new System.Drawing.Point(81, 250);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(28, 13);
            this.lb_time.TabIndex = 8;
            this.lb_time.Text = "Aika";
            // 
            // bt_reservation_cancel
            // 
            this.bt_reservation_cancel.BackColor = System.Drawing.Color.Transparent;
            this.bt_reservation_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_reservation_cancel.ForeColor = System.Drawing.Color.White;
            this.bt_reservation_cancel.Location = new System.Drawing.Point(84, 307);
            this.bt_reservation_cancel.Name = "bt_reservation_cancel";
            this.bt_reservation_cancel.Size = new System.Drawing.Size(68, 23);
            this.bt_reservation_cancel.TabIndex = 9;
            this.bt_reservation_cancel.Text = "Peruuta";
            this.bt_reservation_cancel.UseVisualStyleBackColor = false;
            // 
            // bt_reservation_accept
            // 
            this.bt_reservation_accept.BackColor = System.Drawing.Color.Transparent;
            this.bt_reservation_accept.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_reservation_accept.ForeColor = System.Drawing.Color.White;
            this.bt_reservation_accept.Location = new System.Drawing.Point(178, 307);
            this.bt_reservation_accept.Name = "bt_reservation_accept";
            this.bt_reservation_accept.Size = new System.Drawing.Size(68, 23);
            this.bt_reservation_accept.TabIndex = 8;
            this.bt_reservation_accept.Text = "Hyväksy";
            this.bt_reservation_accept.UseVisualStyleBackColor = false;
            // 
            // cb_reservation
            // 
            this.cb_reservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_reservation.FormattingEnabled = true;
            this.cb_reservation.Location = new System.Drawing.Point(84, 173);
            this.cb_reservation.Name = "cb_reservation";
            this.cb_reservation.Size = new System.Drawing.Size(162, 24);
            this.cb_reservation.TabIndex = 4;
            // 
            // lb_reservation
            // 
            this.lb_reservation.AutoSize = true;
            this.lb_reservation.BackColor = System.Drawing.Color.Transparent;
            this.lb_reservation.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Italic);
            this.lb_reservation.ForeColor = System.Drawing.Color.White;
            this.lb_reservation.Location = new System.Drawing.Point(81, 155);
            this.lb_reservation.Name = "lb_reservation";
            this.lb_reservation.Size = new System.Drawing.Size(40, 13);
            this.lb_reservation.TabIndex = 13;
            this.lb_reservation.Text = "Varaus";
            // 
            // dt_datepicker
            // 
            this.dt_datepicker.Location = new System.Drawing.Point(84, 222);
            this.dt_datepicker.Name = "dt_datepicker";
            this.dt_datepicker.Size = new System.Drawing.Size(200, 20);
            this.dt_datepicker.TabIndex = 5;
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.BackColor = System.Drawing.Color.Transparent;
            this.lb_date.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Italic);
            this.lb_date.ForeColor = System.Drawing.Color.White;
            this.lb_date.Location = new System.Drawing.Point(81, 206);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(44, 13);
            this.lb_date.TabIndex = 15;
            this.lb_date.Text = "Päiväys";
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::TimeReservationApp.Properties.Resources.Reservation_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(330, 345);
            this.Controls.Add(this.lb_date);
            this.Controls.Add(this.dt_datepicker);
            this.Controls.Add(this.lb_reservation);
            this.Controls.Add(this.cb_reservation);
            this.Controls.Add(this.bt_reservation_accept);
            this.Controls.Add(this.bt_reservation_cancel);
            this.Controls.Add(this.lb_time);
            this.Controls.Add(this.lb_lastname);
            this.Controls.Add(this.tf_lastname);
            this.Controls.Add(this.between);
            this.Controls.Add(this.cb_to);
            this.Controls.Add(this.cb_at);
            this.Controls.Add(this.lb_reservation_name);
            this.Controls.Add(this.tf_name);
            this.Controls.Add(this.p_reservation_panel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservation";
            this.p_reservation_panel.ResumeLayout(false);
            this.p_reservation_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel p_reservation_panel;
        private System.Windows.Forms.Label lb_reservation_title;
        private System.Windows.Forms.TextBox tf_name;
        private System.Windows.Forms.Label lb_reservation_name;
        private System.Windows.Forms.Button bt_reservation_exit;
        private System.Windows.Forms.ComboBox cb_at;
        private System.Windows.Forms.ComboBox cb_to;
        private System.Windows.Forms.Label between;
        private System.Windows.Forms.TextBox tf_lastname;
        private System.Windows.Forms.Label lb_lastname;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.Button bt_reservation_cancel;
        private System.Windows.Forms.Button bt_reservation_accept;
        private System.Windows.Forms.ComboBox cb_reservation;
        private System.Windows.Forms.Label lb_reservation;
        private System.Windows.Forms.DateTimePicker dt_datepicker;
        private System.Windows.Forms.Label lb_date;
        private System.Windows.Forms.ToolTip toolTip;
    }
}