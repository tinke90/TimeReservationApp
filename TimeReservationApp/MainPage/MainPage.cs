/**
 * @ AUTHOR: Tinke990
 * PROGRAMMER: Tinke990
 * LAYOUT DESIGNER: Tinke990
 * CREATION YEAR: 2020
 * APPLICATION: TimeReservationApp
 * APPLICATION DESCRIPTION: Booking sup boards
 * 
 * ##############################################################################################
 * ###   LEGITIMACY, LICENSE AND AGREEMENTS: This software will be never                      ###
 * ###   used for commercial purpose. Software can be used only for purpose of practice       ###
 * ###   and in school projects and in hobbyist projects. Developer agree these terms and     ###
 * ###   conditions if and when the developer use this software partly or completely in any   ###
 * ###   of the programming projects. For breaking these above legal terms. The developer     ###
 * ###   is legally responsible to pay for the original creator 75% of all the incomes that   ###
 * ###   is gain by using this software.                                                      ###
 * ##############################################################################################
 * 
 * 
 * CONTACTS: 
 * Name: Jyri Tiihonen
 * Email(s): fintoy.flr@gmail.com | tinke990@gmail.com
 */

using Panel_Fade;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace TimeReservationApp {
    class MainPage {

        /// <summary>                                                                    //////////
        ///                               MainPage                                              ///
        ///                 THIS CLASS IS USED FOR THE MainPage WINDOW FORM LAYOUT              ///
        ///                 DESIGN CLASS, TO LOAD NECESSARIES BEFORE THE CONTROLS...            ///
        ///                                                                                     ///
        ///                             FUNCTIONALITITES:                                       ///
        ///                             - MainPage(Form _form, ArrayList _profiles)             ///
        ///                             - LoadComponents()                                      ///
        ///                             - LoadTexts()                                           ///
        ///                             - LoadData()                                            ///
        ///                             - LoadConfigs()                                         ///
        ///                             - bt_click_logout()                                     ///
        ///                                                                                     ///
        /// </summary>                                                                   //////////

        Label lb_main_title;

        ArrayList m_profiles;

        Label lb_main_profileInfo_p;
        Label lb_main_username_p;
        Label lb_main_name_p;
        Label lb_main_lastname_p;
        Label lb_main_birthdate_p;
        Label lb_main_email_p;
        Label lb_main_phone_p;

        TableLayoutPanel tlp_layoutPanel;

        TextBox tf_main_username;
        TextBox tf_main_name;
        TextBox tf_main_lastname;
        TextBox tf_main_birthdate;
        TextBox tf_main_email;
        TextBox tf_main_phone;

        Button bt_main_cancel;
        Button bt_main_save;
        Button bt_main_reservation;
        Button bt_main_logout;
        Button bt_main_change_passwd;

        Panel p_main_userInfo;
        static Panel p_main_panel;

        Form m_form = new Form();

        ToolTip toolTip;



        public MainPage(Form _form, ArrayList _profiles) {

            this.m_form = _form;

            m_profiles = _profiles;

            lb_main_title = new Label();
            p_main_panel = new FadePanel();
            p_main_userInfo = new FadePanel();

            lb_main_profileInfo_p = new Label();
            lb_main_username_p = new Label();
            lb_main_name_p = new Label();
            lb_main_lastname_p = new Label();
            lb_main_birthdate_p = new Label();
            lb_main_email_p = new Label();
            lb_main_phone_p = new Label();

            tlp_layoutPanel = new TableLayoutPanel();

            tf_main_username = new TextBox();
            tf_main_name = new TextBox();
            tf_main_lastname = new TextBox();
            tf_main_birthdate = new TextBox();
            tf_main_email = new TextBox();
            tf_main_phone = new TextBox();

            bt_main_cancel = new Button();
            bt_main_save = new Button();
            bt_main_reservation = new Button();
            bt_main_logout = new Button();
            bt_main_change_passwd = new Button();

            toolTip = new ToolTip();

        }



        public void LoadComponents() {

            LoadConfigs();
            LoadData();

            /**
             * These lists will be used in MainPageControls class...
             *  - _buttons
             *  - _textfields
             *  - _labelsTitle
             */
            Button[] _buttons = { bt_main_cancel, bt_main_save, bt_main_reservation, bt_main_change_passwd};

            TextBox[] _textfields = { tf_main_username, tf_main_name, tf_main_lastname,
            tf_main_birthdate, tf_main_email, tf_main_phone};
            
            // MainPageControls where all the magic happens...
            MainPageControls _controls = new MainPageControls(_buttons, tlp_layoutPanel, /*_labelsTitle, _labelsData,*/ _textfields);
            _controls.LoadComponents();

            bt_click_logout();                                              // Logout funtionality...

            LoadTexts();

        }



        private void LoadTexts() {

            toolTip.SetToolTip(bt_main_change_passwd, Translate.Language("Vaihda salasana"));
            toolTip.SetToolTip(bt_main_logout, Translate.Language("Kirjaudu ulos"));
            toolTip.SetToolTip(bt_main_save, Translate.Language("Tallenna"));
            toolTip.SetToolTip(bt_main_cancel, Translate.Language("Peruuta"));
            toolTip.SetToolTip(bt_main_reservation, Translate.Language("Tee lautavaraus"));

        }



        // Load profile and set data...
        private void LoadData() {

            foreach(Profile _profile in m_profiles) {

                if(_profile.GetUsername.Equals(Settings.CurrentUser)) {

                    tf_main_username.Text = _profile.GetUsername;           // Set username data
                    tf_main_email.Text = _profile.GetEmail;                 // Set email data
                    tf_main_phone.Text = _profile.GetPhone;                 // Set phone data
                    tf_main_name.Text = _profile.GetFirstname;              // Set name data
                    tf_main_lastname.Text = _profile.GetLastname;           // Set lastname data
                    tf_main_birthdate.Text = _profile.GetBirthdate;         // Set birthdate data

                }

            }

        }



        private void LoadConfigs() {

            /**
             * MAIN TITLE
             */
            lb_main_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_main_title.ForeColor = System.Drawing.Color.White;
            lb_main_title.Location = new System.Drawing.Point(-2, 0);
            lb_main_title.Name = "lb_main_title";
            lb_main_title.Size = new System.Drawing.Size(200, 25);
            lb_main_title.TabIndex = 2;
            lb_main_title.Text = "          "+Translate.Language("Tiedot")+"          ";
            lb_main_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;



            /**
             * PROFILE TITLES...
             * - USERNAME
             * - NAME
             * - LASTNAME
             * - BIRTHDATE
             * - EMAIL
             * - PHONE
             */
            lb_main_username_p.AutoSize = true;
            lb_main_username_p.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_main_username_p.ForeColor = System.Drawing.Color.White;
            lb_main_username_p.Location = new System.Drawing.Point(24, 25);
            lb_main_username_p.Name = "lb_main_username_p";
            lb_main_username_p.Size = new System.Drawing.Size(77, 13);
            lb_main_username_p.TabIndex = 21;
            lb_main_username_p.Text = Translate.Language("Käyttäjätunnus");

            lb_main_name_p.AutoSize = true;
            lb_main_name_p.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_main_name_p.ForeColor = System.Drawing.Color.White;
            lb_main_name_p.Location = new System.Drawing.Point(24, 64);
            lb_main_name_p.Name = "lb_main_name_p";
            lb_main_name_p.Size = new System.Drawing.Size(42, 13);
            lb_main_name_p.TabIndex = 22;
            lb_main_name_p.Text = Translate.Language("Etunimi");

            lb_main_lastname_p.AutoSize = true;
            lb_main_lastname_p.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_main_lastname_p.ForeColor = System.Drawing.Color.White;
            lb_main_lastname_p.Location = new System.Drawing.Point(24, 103);
            lb_main_lastname_p.Name = "lb_main_lastname_p";
            lb_main_lastname_p.Size = new System.Drawing.Size(50, 13);
            lb_main_lastname_p.TabIndex = 23;
            lb_main_lastname_p.Text = Translate.Language("Sukunimi");

            lb_main_birthdate_p.AutoSize = true;
            lb_main_birthdate_p.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_main_birthdate_p.ForeColor = System.Drawing.Color.White;
            lb_main_birthdate_p.Location = new System.Drawing.Point(24, 142);
            lb_main_birthdate_p.Name = "lb_main_birthdate_p";
            lb_main_birthdate_p.Size = new System.Drawing.Size(72, 13);
            lb_main_birthdate_p.TabIndex = 24;
            lb_main_birthdate_p.Text = Translate.Language("Syntymäpäivä");

            lb_main_email_p.AutoSize = true;
            lb_main_email_p.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_main_email_p.ForeColor = System.Drawing.Color.White;
            lb_main_email_p.Location = new System.Drawing.Point(22, 181);
            lb_main_email_p.Name = "lb_main_email_p";
            lb_main_email_p.Size = new System.Drawing.Size(60, 13);
            lb_main_email_p.TabIndex = 25;
            lb_main_email_p.Text = Translate.Language("Sähköposti");

            lb_main_phone_p.AutoSize = true;
            lb_main_phone_p.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_main_phone_p.ForeColor = System.Drawing.Color.White;
            lb_main_phone_p.Location = new System.Drawing.Point(24, 220);
            lb_main_phone_p.Name = "lb_main_phone_p";
            lb_main_phone_p.Size = new System.Drawing.Size(44, 13);
            lb_main_phone_p.TabIndex = 26;
            lb_main_phone_p.Text = Translate.Language("Puhelin");



            /**
             * TEXTBOXES
             * - USERNAME
             * - LASTNAME
             * - BIARTHDATE
             * - EMAIL
             * - PHONE
             */
            tf_main_name.BackColor = System.Drawing.Color.Black;
            tf_main_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tf_main_name.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tf_main_name.ForeColor = System.Drawing.Color.White;
            tf_main_name.Location = new System.Drawing.Point(25, 80);
            tf_main_name.Name = "tf_main_name";
            tf_main_name.Size = new System.Drawing.Size(144, 20);
            tf_main_name.TabIndex = 1;
            tf_main_name.Text = "-";

            tf_main_username.BackColor = System.Drawing.Color.Black;
            tf_main_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tf_main_username.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tf_main_username.Size = new System.Drawing.Size(120, 40);
            tf_main_username.ForeColor = System.Drawing.Color.White;
            tf_main_username.Name = "tf_main_username";
            tf_main_username.Location = new System.Drawing.Point(25, 41);
            tf_main_username.TabIndex = 10;
            tf_main_username.Text = "-";

            tf_main_lastname.BackColor = System.Drawing.Color.Black;
            tf_main_lastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tf_main_lastname.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tf_main_lastname.ForeColor = System.Drawing.Color.White;
            tf_main_lastname.Location = new System.Drawing.Point(25, 119);
            tf_main_lastname.Name = "tf_main_lastname";
            tf_main_lastname.Size = new System.Drawing.Size(144, 20);
            tf_main_lastname.TabIndex = 2;
            tf_main_lastname.Text = "-";

            tf_main_birthdate.BackColor = System.Drawing.Color.Black;
            tf_main_birthdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tf_main_birthdate.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tf_main_birthdate.ForeColor = System.Drawing.Color.White;
            tf_main_birthdate.Location = new System.Drawing.Point(25, 158);
            tf_main_birthdate.Name = "tf_main_birthdate";
            tf_main_birthdate.Size = new System.Drawing.Size(144, 20);
            tf_main_birthdate.TabIndex = 3;
            tf_main_birthdate.Text = "-";

            tf_main_email.BackColor = System.Drawing.Color.Black;
            tf_main_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tf_main_email.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tf_main_email.ForeColor = System.Drawing.Color.White;
            tf_main_email.Location = new System.Drawing.Point(25, 197);
            tf_main_email.Name = "tf_main_email";
            tf_main_email.Size = new System.Drawing.Size(144, 20);
            tf_main_email.TabIndex = 4;
            tf_main_email.Text = "-";

            tf_main_phone.BackColor = System.Drawing.Color.Black;
            tf_main_phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tf_main_phone.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tf_main_phone.ForeColor = System.Drawing.Color.White;
            tf_main_phone.Location = new System.Drawing.Point(25, 236);
            tf_main_phone.Name = "tf_main_phone";
            tf_main_phone.Size = new System.Drawing.Size(144, 20);
            tf_main_phone.TabIndex = 5;
            tf_main_phone.Text = "-";



            /**
             * BUTTONS
             * - RESERVATION BUTTON
             * - SAVE BUTTON
             * - CANCEL BUTTON
             * - BUTTON LOGOUT
             * - BUTTON CHANGE PASSWORD
             */
            bt_main_reservation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            bt_main_reservation.Location = new System.Drawing.Point(338, 290);
            bt_main_reservation.ForeColor = System.Drawing.Color.White;
            bt_main_reservation.Name = "bt_main_reservation";
            bt_main_reservation.Size = new System.Drawing.Size(100, 23);
            bt_main_reservation.TabIndex = 9;
            bt_main_reservation.Text = Translate.Language("Varaa aika");
            bt_main_reservation.UseVisualStyleBackColor = true;
            bt_main_reservation.Enabled = true;

            bt_main_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            bt_main_save.Location = new System.Drawing.Point(139, 290);
            bt_main_save.ForeColor = System.Drawing.Color.White;
            bt_main_save.Name = "bt_main_save";
            bt_main_save.Size = new System.Drawing.Size(75, 23);
            bt_main_save.TabIndex = 6;
            bt_main_save.Text = Translate.Language("Tallenna");
            bt_main_save.UseVisualStyleBackColor = true;
            bt_main_save.Enabled = true;

            bt_main_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            bt_main_cancel.Location = new System.Drawing.Point(15, 290);
            bt_main_cancel.ForeColor = System.Drawing.Color.White;
            bt_main_cancel.Name = "bt_main_cancel";
            bt_main_cancel.Size = new System.Drawing.Size(75, 23);
            bt_main_cancel.TabIndex = 7;
            bt_main_cancel.Text = Translate.Language("Peruuta");
            bt_main_cancel.UseVisualStyleBackColor = true;
            bt_main_cancel.Enabled = true;

            bt_main_logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            bt_main_logout.Location = new System.Drawing.Point(566, 290);
            bt_main_logout.ForeColor = System.Drawing.Color.White;
            bt_main_logout.Name = "bt_main_logout";
            bt_main_logout.Size = new System.Drawing.Size(100, 23);
            bt_main_logout.TabIndex = 8;
            bt_main_logout.Text = Translate.Language("Ulos");
            bt_main_logout.UseVisualStyleBackColor = true;
            bt_main_logout.Enabled = true;

            bt_main_change_passwd.BackgroundImage = global::TimeReservationApp.Properties.Resources.Settings_icon_rotor;
            bt_main_change_passwd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            bt_main_change_passwd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            bt_main_change_passwd.Location = new System.Drawing.Point(149, 41);
            bt_main_change_passwd.Name = "bt_change_passwd";
            bt_main_change_passwd.Size = new System.Drawing.Size(20, 20);
            bt_main_change_passwd.TabIndex = 70;
            bt_main_change_passwd.UseVisualStyleBackColor = true;
            bt_main_change_passwd.Enabled = true;

            tlp_layoutPanel.BackColor = System.Drawing.Color.Black;
            tlp_layoutPanel.Location = new System.Drawing.Point(338, 17);
            tlp_layoutPanel.Name = "tlp_layoutPanel";
            tlp_layoutPanel.Size = new System.Drawing.Size(328, 271);
            tlp_layoutPanel.TabIndex = 71;
            tlp_layoutPanel.AutoScroll = true;



            /**
             * USER INFO TABLE...
             * - UserInfo Panel
             */
            p_main_userInfo.BackColor = HalfTransparent.GetHalfTransparent;
            p_main_userInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            p_main_userInfo.Controls.Add(tf_main_phone);
            p_main_userInfo.Controls.Add(tf_main_email);
            p_main_userInfo.Controls.Add(tf_main_birthdate);
            p_main_userInfo.Controls.Add(tf_main_lastname);
            p_main_userInfo.Controls.Add(tf_main_name);
            p_main_userInfo.Controls.Add(tf_main_username);
            p_main_userInfo.Controls.Add(lb_main_phone_p);
            p_main_userInfo.Controls.Add(lb_main_email_p);
            p_main_userInfo.Controls.Add(lb_main_birthdate_p);
            p_main_userInfo.Controls.Add(lb_main_lastname_p);
            p_main_userInfo.Controls.Add(lb_main_name_p);
            p_main_userInfo.Controls.Add(lb_main_username_p);
            p_main_userInfo.Controls.Add(lb_main_title);
            p_main_userInfo.Controls.Add(bt_main_change_passwd);
            p_main_userInfo.Location = new System.Drawing.Point(15, 15);
            p_main_userInfo.Name = "p_main_userInfo";
            p_main_userInfo.Size = new System.Drawing.Size(200, 273);
            p_main_userInfo.TabIndex = 6;



            /**
             * MAIN TABLE...
             * - Main Panel
             */
            p_main_panel.Controls.Add(tlp_layoutPanel);
            p_main_panel.Controls.Add(bt_main_reservation);
            p_main_panel.Controls.Add(bt_main_cancel);
            p_main_panel.Controls.Add(bt_main_save);
            p_main_panel.Controls.Add(bt_main_logout);
            //p_main_panel.Controls.Add(bt_main_change_passwd);
            p_main_panel.Controls.Add(p_main_userInfo);
            p_main_panel.BackColor = HalfTransparent.GetHalfTransparent;
            p_main_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            p_main_panel.Location = new System.Drawing.Point(74, 99);
            p_main_panel.Name = "p_main_panel";
            p_main_panel.Size = new System.Drawing.Size(680, 318);
            p_main_panel.TabIndex = 1;
            p_main_panel.Visible = true;

            this.m_form.Controls.Add(p_main_panel);

        }



        // Button logout click functionality...
        public void bt_click_logout() {

            bt_main_logout.Click += (sender, e) => {

                m_form.Controls.Remove(p_main_panel);                   // Remove page from From1
                Login.Show(true);                                       // Display login page...

            };

        }



    }
}
