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
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeReservationApp {
    public class Registry {

        /// <summary>                                                                    //////////
        ///                               Registry                                              ///
        ///                 THIS CLASS IS USED FOR THE Registry WINDOW FORM LAYOUT              ///
        ///                 DESIGN CLASS, TO LOAD NECESSARIES BEFORE THE CONTROLS...            ///
        ///                                                                                     ///
        ///                             FUNCTIONALITITES:                                       ///
        ///                             - Registry(Form _form)                                  ///
        ///                             - LoadComponents()                                      ///
        ///                             - LoadTexts()                                           ///
        ///                             - Show(bool _option)                                    ///
        ///                             - LoadConfigs()                                         ///
        ///                             - Switch()                                              ///
        ///                             - bt_registry_click()                                   ///
        ///                             - CreateNewUser()                                       ///
        ///                             - ClearTextFields()                                     ///
        /// </summary>                                                                   //////////


        Button bt_registry;
        Button bt_reg_switch;
        TextBox tf_reg_username;
        TextBox tf_reg_password;
        TextBox tf_reg_passwordAgain;
        TextBox tf_reg_email;
        TextBox tf_reg_phone;
        static Panel p_reg_table;

        Label lb_reg_registry;
        Label lb_reg_username;
        Label lb_reg_password;
        Label lb_reg_passwordAgain;
        Label lb_reg_email;
        Label lb_reg_phone;

        Label lb_reg_username_err;
        Label lb_reg_password_err;
        Label lb_reg_passwordAgain_err;
        Label lb_reg_email_err;
        Label lb_reg_phone_err;

        ToolTip toolTip;

        Form m_form;



        public Registry(Form _form) {

            bt_registry = new Button();
            bt_reg_switch = new Button();
            
            tf_reg_username = new TextBox();
            tf_reg_password = new TextBox();
            tf_reg_passwordAgain = new TextBox();
            tf_reg_email = new TextBox();
            tf_reg_phone = new TextBox();
            
            p_reg_table = new FadePanel();
            
            lb_reg_registry = new Label();
            lb_reg_username = new Label();
            lb_reg_password = new Label();
            lb_reg_passwordAgain = new Label();
            lb_reg_email = new Label();
            lb_reg_phone = new Label();

            lb_reg_username_err = new Label();
            lb_reg_password_err = new Label();
            lb_reg_passwordAgain_err = new Label();
            lb_reg_email_err = new Label();
            lb_reg_phone_err = new Label();

            toolTip = new ToolTip();

            this.m_form = _form;                                // Place form

            LoadComponents();                                   // Load components

            p_reg_table.Visible = false;                        // Hide registry table in default...

            Switch();                                           // Load switch functionality...

        }



        // Load components...
        public void LoadComponents() {

            LoadConfigs();                                      // Load configs before any other...

            Button[] _buttons = { bt_registry, bt_reg_switch};
            TextBox[] _textfields = { tf_reg_username, tf_reg_password, tf_reg_passwordAgain,
            tf_reg_email, tf_reg_phone};

            RegistryController _controller = new RegistryController(_buttons, _textfields);
            _controller.LoadControllers();

            bt_registry_click();

            LoadTexts();

            tf_password_again_click();

        }



        private void LoadTexts() {

            toolTip.SetToolTip(bt_registry, Translate.Language("Rekisteröidy käyttäjäksi"));
            toolTip.SetToolTip(tf_reg_username, Translate.Language("Syötä käyttäjätunnus"));
            toolTip.SetToolTip(tf_reg_password, Translate.Language("Syötä salasana"));
            toolTip.SetToolTip(tf_reg_phone, Translate.Language("Syötä puhelinnumero"));
            toolTip.SetToolTip(tf_reg_email, Translate.Language("Syötä sähköpostiosoite"));
            toolTip.SetToolTip(tf_reg_passwordAgain, Translate.Language("Syötä salasana uudelleen"));
            toolTip.SetToolTip(bt_reg_switch, Translate.Language("Kirjaudu sisään"));
            
        }



        // Enable or disable visibility of the registry window form...
        public static void Show(bool _option) {

            p_reg_table.Visible = _option;

        }



        // Load buttons, textfields, panel and labels placements and settings...
        private void LoadConfigs() {

            /**
             * Table title...
             */
            lb_reg_registry.Text = Translate.Language("Rekisteröidy");
            lb_reg_registry.Width = 199;
            lb_reg_registry.Height = 29;
            lb_reg_registry.Font = new Font("Times New Roman", 16, FontStyle.Underline);
            lb_reg_registry.Location = new Point(241, 25);
            lb_reg_registry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lb_reg_registry.BackColor = Color.Transparent;
            lb_reg_registry.ForeColor = Color.White;



            
            lb_reg_username_err.Text = "*";
            lb_reg_username_err.Width = 71;
            lb_reg_username_err.Height = 13;
            lb_reg_username_err.Font = new Font("Times New Roman", 8, FontStyle.Bold);
            lb_reg_username_err.Location = new Point(385, 73);
            lb_reg_username_err.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lb_reg_username_err.BackColor = Color.Transparent;
            lb_reg_username_err.ForeColor = Color.Red;
            lb_reg_username_err.AutoSize = false;
            lb_reg_username_err.TextAlign = ContentAlignment.MiddleRight;
            lb_reg_username_err.Visible = false;

            lb_reg_password_err.Text = "*";
            lb_reg_password_err.Width = 71;
            lb_reg_password_err.Height = 13;
            lb_reg_password_err.Font = new Font("Times New Roman", 8, FontStyle.Bold);
            lb_reg_password_err.Location = new Point(385, 102);
            lb_reg_password_err.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lb_reg_password_err.BackColor = Color.Transparent;
            lb_reg_password_err.ForeColor = Color.Red;
            lb_reg_password_err.AutoSize = false;
            lb_reg_password_err.TextAlign = ContentAlignment.MiddleRight;
            lb_reg_password_err.Visible = false;

            lb_reg_passwordAgain_err.Text = "*";
            lb_reg_passwordAgain_err.Width = 71;
            lb_reg_passwordAgain_err.Height = 13;
            lb_reg_passwordAgain_err.Font = new Font("Times New Roman", 8, FontStyle.Bold);
            lb_reg_passwordAgain_err.Location = new Point(385, 131);
            lb_reg_passwordAgain_err.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lb_reg_passwordAgain_err.BackColor = Color.Transparent;
            lb_reg_passwordAgain_err.ForeColor = Color.Red;
            lb_reg_passwordAgain_err.AutoSize = false;
            lb_reg_passwordAgain_err.TextAlign = ContentAlignment.MiddleRight;
            lb_reg_passwordAgain_err.Visible = false;

            lb_reg_email_err.Text = "*";
            lb_reg_email_err.Width = 71;
            lb_reg_email_err.Height = 13;
            lb_reg_email_err.Font = new Font("Times New Roman", 8, FontStyle.Bold);
            lb_reg_email_err.Location = new Point(385, 160);
            lb_reg_email_err.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lb_reg_email_err.BackColor = Color.Transparent;
            lb_reg_email_err.ForeColor = Color.Red;
            lb_reg_email_err.AutoSize = false;
            lb_reg_email_err.TextAlign = ContentAlignment.MiddleRight;
            lb_reg_email_err.Visible = false;

            lb_reg_phone_err.Text = "*";
            lb_reg_phone_err.Width = 71;
            lb_reg_phone_err.Height = 13;
            lb_reg_phone_err.Font = new Font("Times New Roman", 8, FontStyle.Bold);
            lb_reg_phone_err.Location = new Point(385, 189);
            lb_reg_phone_err.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lb_reg_phone_err.BackColor = Color.Transparent;
            lb_reg_phone_err.ForeColor = Color.Red;
            lb_reg_phone_err.AutoSize = false;
            lb_reg_phone_err.TextAlign = ContentAlignment.MiddleRight;
            lb_reg_phone_err.Visible = false;



            /**
             * Labels to display the required data...
             * - Username
             * - Password
             * - Password again
             * - Email
             * - Phone number
             */
            lb_reg_username.Text = Translate.Language("KÄYTTÄJÄ").ToUpper();
            lb_reg_username.Width = 71;
            lb_reg_username.Height = 13;
            lb_reg_username.Font = new Font("Times New Roman", 8);
            lb_reg_username.Location = new Point(170, 73);
            lb_reg_username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lb_reg_username.BackColor = Color.Transparent;
            lb_reg_username.ForeColor = Color.White;
            lb_reg_username.AutoSize = false;
            lb_reg_username.TextAlign = ContentAlignment.MiddleRight;

            lb_reg_password.Text = Translate.Language("SALASANA").ToUpper();
            lb_reg_password.Width = 71;
            lb_reg_password.Height = 13;
            lb_reg_password.Font = new Font("Times New Roman", 8);
            lb_reg_password.Location = new Point(170, 102);
            lb_reg_password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lb_reg_password.BackColor = Color.Transparent;
            lb_reg_password.ForeColor = Color.White;
            lb_reg_password.AutoSize = false;
            lb_reg_password.TextAlign = ContentAlignment.MiddleRight;

            lb_reg_passwordAgain.Text = Translate.Language("UUDELLEEN").ToUpper();
            lb_reg_passwordAgain.Width = 71;
            lb_reg_passwordAgain.Height = 13;
            lb_reg_passwordAgain.Font = new Font("Times New Roman", 8);
            lb_reg_passwordAgain.Location = new Point(170, 131);
            lb_reg_passwordAgain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lb_reg_passwordAgain.BackColor = Color.Transparent;
            lb_reg_passwordAgain.ForeColor = Color.White;
            lb_reg_passwordAgain.AutoSize = false;
            lb_reg_passwordAgain.TextAlign = ContentAlignment.MiddleRight;

            lb_reg_email.Text = Translate.Language("EMAIL").ToUpper();
            lb_reg_email.Width = 71;
            lb_reg_email.Height = 13;
            lb_reg_email.Font = new Font("Times New Roman", 8);
            lb_reg_email.Location = new Point(170, 160);
            lb_reg_email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lb_reg_email.BackColor = Color.Transparent;
            lb_reg_email.ForeColor = Color.White;
            lb_reg_email.AutoSize = false;
            lb_reg_email.TextAlign = ContentAlignment.MiddleRight;

            lb_reg_phone.Text = Translate.Language("PUHELIN").ToUpper();
            lb_reg_phone.Width = 71;
            lb_reg_phone.Height = 13;
            lb_reg_phone.Font = new Font("Times New Roman", 8);
            lb_reg_phone.Location = new Point(170, 189);
            lb_reg_phone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lb_reg_phone.BackColor = Color.Transparent;
            lb_reg_phone.ForeColor = Color.White;
            lb_reg_phone.AutoSize = false;
            lb_reg_phone.TextAlign = ContentAlignment.MiddleRight;



            /**
             * User textfields to receive the data...
             * - Username
             * - Password
             * - Password again
             * - Email
             * - Phone number
             */
            tf_reg_username.Text = "";
            tf_reg_username.Width = 199;
            tf_reg_username.Height = 23;
            tf_reg_username.BorderStyle = BorderStyle.FixedSingle;
            tf_reg_username.Location = new Point(241, 68);
            tf_reg_username.Font = new Font("Arial", 10, FontStyle.Bold);
            tf_reg_username.TextAlign = HorizontalAlignment.Center;
            tf_reg_username.BackColor = Color.Black;
            tf_reg_username.ForeColor = Color.White;

            tf_reg_password.Text = "";
            tf_reg_password.Width = 199;
            tf_reg_password.Height = 23;
            tf_reg_password.BorderStyle = BorderStyle.FixedSingle;
            tf_reg_password.Location = new Point(241, 97);
            tf_reg_password.PasswordChar = '*';
            tf_reg_password.Font = new Font("Arial", 10, FontStyle.Bold);
            tf_reg_password.TextAlign = HorizontalAlignment.Center;
            tf_reg_password.BackColor = Color.Black;
            tf_reg_password.ForeColor = Color.White;

            tf_reg_passwordAgain.Text = "";
            tf_reg_passwordAgain.Width = 199;
            tf_reg_passwordAgain.Height = 23;
            tf_reg_passwordAgain.BorderStyle = BorderStyle.FixedSingle;
            tf_reg_passwordAgain.Location = new Point(241, 126);
            tf_reg_passwordAgain.PasswordChar = '*';
            tf_reg_passwordAgain.Font = new Font("Arial", 10, FontStyle.Bold);
            tf_reg_passwordAgain.TextAlign = HorizontalAlignment.Center;
            tf_reg_passwordAgain.BackColor = Color.Black;
            tf_reg_passwordAgain.ForeColor = Color.White;

            tf_reg_email.Text = "";
            tf_reg_email.Width = 199;
            tf_reg_email.Height = 23;
            tf_reg_email.BorderStyle = BorderStyle.FixedSingle;
            tf_reg_email.Location = new Point(241, 155);
            tf_reg_email.Font = new Font("Arial", 10, FontStyle.Bold);
            tf_reg_email.TextAlign = HorizontalAlignment.Center;
            tf_reg_email.BackColor = Color.Black;
            tf_reg_email.ForeColor = Color.White;

            tf_reg_phone.Text = "";
            tf_reg_phone.Width = 199;
            tf_reg_phone.Height = 23;
            tf_reg_phone.BorderStyle = BorderStyle.FixedSingle;
            tf_reg_phone.Location = new Point(241, 184);
            tf_reg_phone.Font = new Font("Arial", 10, FontStyle.Bold);
            tf_reg_phone.TextAlign = HorizontalAlignment.Center;
            tf_reg_phone.BackColor = Color.Black;
            tf_reg_phone.ForeColor = Color.White;



            /**
             * Switch method between registration table and login table....
             */
            bt_reg_switch.Text = Translate.Language("Kirjaudu");
            bt_reg_switch.Location = new Point(241, 212);
            bt_reg_switch.FlatStyle = FlatStyle.Popup;
            bt_reg_switch.Font = new Font("Arial", 8, FontStyle.Bold);
            bt_reg_switch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            bt_reg_switch.BackColor = Color.Transparent;
            bt_reg_switch.ForeColor = Color.White;



            /**
             * Registry button...
             */
            bt_registry.Text = Translate.Language("Rekisteröidy");
            bt_registry.Width = 199;
            bt_registry.Height = 40;
            bt_registry.Location = new Point(241, 240);
            bt_registry.FlatStyle = FlatStyle.Popup;
            bt_registry.Font = new Font("Arial", 10, FontStyle.Bold);
            bt_registry.ForeColor = Color.White;
            bt_registry.BackColor = HalfTransparent.GetHalfTransparent;



            /**
             * Main table...
             */
            p_reg_table.Width = 680;
            p_reg_table.Height = 318;
            p_reg_table.BackColor = HalfTransparent.GetHalfTransparent;
            p_reg_table.Location = new Point(74, 99);
            p_reg_table.Controls.Add(bt_registry);
            p_reg_table.Controls.Add(bt_reg_switch);
            p_reg_table.Controls.Add(tf_reg_username);
            p_reg_table.Controls.Add(tf_reg_password);
            p_reg_table.Controls.Add(tf_reg_passwordAgain);
            p_reg_table.Controls.Add(tf_reg_email);
            p_reg_table.Controls.Add(tf_reg_phone);
            p_reg_table.Controls.Add(lb_reg_username);
            p_reg_table.Controls.Add(lb_reg_password);
            p_reg_table.Controls.Add(lb_reg_passwordAgain);
            p_reg_table.Controls.Add(lb_reg_email);
            p_reg_table.Controls.Add(lb_reg_phone);
            p_reg_table.Controls.Add(lb_reg_registry);
            p_reg_table.Controls.Add(lb_reg_username_err);
            p_reg_table.Controls.Add(lb_reg_password_err);
            p_reg_table.Controls.Add(lb_reg_passwordAgain_err);
            p_reg_table.Controls.Add(lb_reg_email_err);
            p_reg_table.Controls.Add(lb_reg_phone_err);



            /**
             * Add table to window form...
             */
            m_form.Controls.Add(p_reg_table);

        }



        // Switch functionality...
        private void Switch() {

            bt_reg_switch.Click += (sender, e) => {

                Login.Show(true);
                p_reg_table.Visible = false;
                ClearTextFields();

            };

        }



        // Registry button functionality...
        private void bt_registry_click() {

            bt_registry.Click += (sender, e) => {

                CreateNewUser();    

            };

        }



        private void tf_password_again_click()
        {

            tf_reg_passwordAgain.Click += (sender, e) => {

                // Re-set the default hint thext to the password again textfield...
                toolTip.SetToolTip(tf_reg_passwordAgain, Translate.Language("Syötä salasana uudelleen"));

            };

        }



        private void CreateNewUser() {

            HideErrorPointers();

            // Create textfield list to check if any of fields include text...
            TextBox[] _list = { tf_reg_username, tf_reg_password, tf_reg_passwordAgain,
            tf_reg_email, tf_reg_phone};
            
            // Check that all the textfields include data...
            if(Check.IfEmptyOrNull(_list)) {

                DisplayLackOfDataTextFields();
                return;
            
            }

            // Check that the passwords match...
            if(!tf_reg_password.Text.Equals(tf_reg_passwordAgain.Text)) {

                lb_reg_passwordAgain_err.Visible = true;
                toolTip.SetToolTip(tf_reg_passwordAgain, Translate.Language("Salasanat eivät täsmää"));
                return;
            
            }

            // Check that email field contains @ in some point...
            if(!tf_reg_email.Text.Contains("@")) {

                lb_reg_email_err.Visible = true;
                return;
            
            }

            // Check that the phone field does not contains any chars...
            if(Check.IfContainsChars(tf_reg_phone.Text) && tf_reg_phone.Text.Length == 10) {

                return;
            
            }

            string _user = tf_reg_username.Text;
            string _passwd = tf_reg_password.Text;
            string _email = tf_reg_email.Text;
            string _phone = tf_reg_phone.Text;

            string _query = "Insert into Profile ('USERNAME', 'PASSWORD', 'EMAIL', 'PHONE', 'LAST_ACTIVE'," +
                " 'FIRSTNAME', 'LASTNAME', 'BIRTHDATE')" +
                " values ('"+_user+"', '"+_passwd+"', '"+_email+"', '"+_phone+"', '"+true+"'," +
                "'-', '-', '-')";

            // No active members is 0
            /*if(Check.LastActiveMember() >= 1) {
                int _id = Check.GetLastActiveMember;

                SQLite.UpdateData("UPDATE Profile set LAST_ACTIVE = 'False' where ID = "+_id);
            }*/

            // Create new profile and insert profile to active...
            SQLite.UpdateData(_query);
            ClearTextFields();

        }



        private void DisplayLackOfDataTextFields()
        {

            Label[] _labels = { lb_reg_username_err, lb_reg_password_err, lb_reg_passwordAgain_err,
            lb_reg_email_err, lb_reg_phone_err };

            TextBox[] _texts = { tf_reg_username, tf_reg_password, tf_reg_passwordAgain, tf_reg_email, tf_reg_phone };

            // Go through all the text fields one by one checking
            // if all are filled properly...
            for(int i = 0; i < _texts.Length; i++) {

                if(string.IsNullOrEmpty(_texts[i].Text)) {

                    // Display error pointer in
                    // each empty field while checking...
                    _labels[i].Visible = true;

                }

            }

        }




        // Clear textfields to provide succesfull
        // profile creation...
        private void ClearTextFields() {

            tf_reg_username.Text = "";
            tf_reg_password.Text = "";
            tf_reg_passwordAgain.Text = "";
            tf_reg_email.Text = "";
            tf_reg_phone.Text = "";

        }



        // Hide to re-display the
        // existing lack of data text fields.
        private void HideErrorPointers()
        {

            lb_reg_username_err.Visible = false;
            lb_reg_password_err.Visible = false;
            lb_reg_passwordAgain_err.Visible = false;
            lb_reg_email_err.Visible = false;
            lb_reg_phone_err.Visible = false;

        }

    }

}
