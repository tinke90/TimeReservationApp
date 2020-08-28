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

using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace TimeReservationApp {
    class MainPageControls {

        /// <summary>                                                                    //////////
        ///                               MainPageControls                                      ///
        ///           THIS CLASS IS USED TO PROVIDE MainPageController FORM CONTROLLERS         ///
        ///                 
        ///                             FUNCTIONALITITES:                                       ///
        ///                             - MainPageControls(Button[] _buttons,                   ///
        ///                             TableLayoutPanel _layoutPanel, TextBox[] _textfields)   ///
        ///                             - LoadComponents()                                      ///
        ///                             - tf_textfield_functionality()                          ///
        ///                             - bt_reservation_click()                                ///
        ///                             - bt_cancel_click()                                     ///
        ///                             - bt_change_password_click()                            ///
        ///                             - bt_save_click()                                       ///
        ///                             - LoadUpdatedUserInformation()                          ///
        ///                             - UpdateReservationList()                               ///
        ///                             - ClearList()                                           ///
        /// </summary>                                                                   //////////

        string m_username;
        string m_name;
        string m_lastname;
        string m_birthdate;
        string m_email;
        string m_phone;

        Button bt_cancel;
        Button bt_save;
        Button bt_reservation;
        Button bt_main_change_passwd;

        static TableLayoutPanel m_layoutPanel;

        TextBox tf_username;
        TextBox tf_name;
        TextBox tf_lastname;
        TextBox tf_birthdate;
        TextBox tf_email;
        TextBox tf_phone;

        TextBox[] m_textfields;

        public MainPageControls(Button[] _buttons, TableLayoutPanel _layoutPanel, TextBox[] _textfields) {

            this.bt_cancel = _buttons[0];               // Button Cancel
            this.bt_save = _buttons[1];                 // Button Save
            this.bt_reservation = _buttons[2];          // Button Reservation
            this.bt_main_change_passwd = _buttons[3];   // Button change password

            m_layoutPanel = _layoutPanel;               // Listview reservation list

            this.tf_username = _textfields[0];          // TextBox username
            this.tf_name = _textfields[1];              // TextBox name
            this.tf_lastname = _textfields[2];          // TextBox lastname
            this.tf_birthdate = _textfields[3];         // TextBox birthdate
            this.tf_email = _textfields[4];             // TextBox email
            this.tf_phone = _textfields[5];             // TextBox phone

            // This list will be used for Check that
            // any of the fields are not left empty...
            this.m_textfields = _textfields;

            this.m_username = tf_username.Text;
            this.m_name = tf_name.Text;
            this.m_lastname = tf_lastname.Text;
            this.m_birthdate = tf_birthdate.Text;
            this.m_email = tf_email.Text;
            this.m_phone = tf_phone.Text;

        }



        public void LoadComponents() {

            bt_cancel.Enabled = false;
            bt_save.Enabled = false;

            tf_username.ReadOnly = true;                // We dont want to be able to modify username at all...
            tf_textfield_functionality();               // If text is changed -> activate save and cancel button...
            bt_cancel_click();                          // Cancel action...
            bt_save_click();                            // Save new provided information to profile...
            bt_change_password_click();                 // Open new password window form...
            bt_reservation_click();                     // Open Reservation window...

            UpdateReservationList();                    // Load reservations...

        }



        private void tf_textfield_functionality() {

            tf_name.TextChanged += (sender, e) => {

                bt_save.Enabled = true;
                bt_cancel.Enabled = true;

            };



            tf_lastname.TextChanged += (sender, e) => {

                bt_save.Enabled = true;
                bt_cancel.Enabled = true;

            };



            tf_birthdate.TextChanged += (sender, e) => {

                bt_save.Enabled = true;
                bt_cancel.Enabled = true;

            };



            tf_email.TextChanged += (sender, e) => {

                bt_save.Enabled = true;
                bt_cancel.Enabled = true;

            };



            tf_phone.TextChanged += (sender, e) => {

                bt_save.Enabled = true;
                bt_cancel.Enabled = true;

            };

        }



        private void bt_reservation_click() {

            bt_reservation.Click += (sender, e) => {

                Reservation _reservation = new Reservation();
                _reservation.TopMost = true;
                _reservation.Show();

            };

        }



        // Cancel action...
        private void bt_cancel_click() {

            bt_cancel.Click += (sender, e) => {

                tf_name.Text = m_name;
                tf_lastname.Text = m_lastname;
                tf_birthdate.Text = m_birthdate;
                tf_email.Text = m_email;
                tf_phone.Text = m_phone;

                bt_save.Enabled = false;
                bt_cancel.Enabled = false;

            };

        }



        // Change password functionality...
        private void bt_change_password_click() {

            bt_main_change_passwd.Click += (sender, e) => {

                ChangePassword _changePwd = new ChangePassword();
                _changePwd.TopMost = true;
                _changePwd.Show();

            };

        }



        // Update new provided data to database...
        private void bt_save_click() {

            bt_save.Click += (sender, e) => {

                m_username = tf_username.Text;
                m_name = tf_name.Text;
                m_lastname = tf_lastname.Text;
                m_birthdate = tf_birthdate.Text;
                m_email = tf_email.Text;
                m_phone = tf_phone.Text;

                string _query = "UPDATE Profile set FIRSTNAME = '"+ m_name + "', LASTNAME = '"+ m_lastname + "'," +
                "BIRTHDATE = '"+ m_birthdate + "', EMAIL = '" + m_email + "', PHONE = '" + m_phone + "' " +
                "where USERNAME = '"+ m_username + "'";

                SQLite.UpdateData(_query);

                LoadUpdatedUserInformation();               // Update textfields with new data...

                bt_save.Enabled = false;
                bt_cancel.Enabled = false;

            };

        }
        


        // Load new data to the textfields once
        // data has updated...
        private void LoadUpdatedUserInformation() {

            ArrayList _list = Settings.GetProfiles;

            foreach(Profile _profile in _list) {
                
                if(_profile.GetUsername.Equals(m_username)) {

                    tf_name.Text = _profile.GetFirstname;
                    tf_lastname.Text = _profile.GetLastname;
                    tf_birthdate.Text = _profile.GetBirthdate;
                    tf_email.Text = _profile.GetEmail;
                    tf_phone.Text = _profile.GetPhone;
                    break;

                }

            }

        }



        // Update reservation list panel...
        public static void UpdateReservationList() {

            ArrayList _list = SQLite.FetchReservation("SELECT * FROM Reservation");

            ClearList();

            Label _label;

            int _index = 0;

            int _location = 0;

            foreach(ReservationProperty _property in _list) {

                string[] _tmp = _property.GetTimeBetween.Split('|');
                string _time = _tmp[0].Trim() +" - " + _tmp[_tmp.Length-1].Trim();
                
                _label = new Label();
                _label.BackColor = Color.Transparent;
                _label.ForeColor = Color.White;
                _label.Size = new Size(324, 55);
                _label.BorderStyle = BorderStyle.FixedSingle;
                _label.AutoSize = false;
                _label.Location = new Point(0, _location);
                _label.Font = new Font("Times New Roman", 10, FontStyle.Bold);
                _label.Text = Translate.Language("Nimi: ") + _property.GetName + " - " +_property.GetLastname + "\n" +
                    Translate.Language("Varaus: ") + _property.GetReservation + "\n" +
                    Translate.Language("Varausaika: ") + _time;

                m_layoutPanel.Controls.Add(_label);
                _location += 60;
                _index++;

            }

        }



        // Clear the layout panel...
        private static void ClearList() {

            for(int i = 0; i < m_layoutPanel.Controls.Count; i++) {

                m_layoutPanel.Controls.RemoveAt(i);

            }

        }
    }
}
