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
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeReservationApp {
    class LoginController{

        /// <summary>                                                                    //////////
        ///                                 LoginController                                     ///
        ///           THIS CLASS IS USED TO PROVIDE LOGIN FORM CONTROLLERS                      ///
        ///                                                                                     ///
        ///                         FUNCTIONALITITES:                                           ///
        ///                          - LoginController(Form _form, Button[] _buttons,           ///
        ///                          TextBox[] _textfields, Label[] _labels)                    ///
        ///                          - LoadControllers()                                        ///
        ///                          - ChangeLanguage()                                         ///
        ///                          - MouseHoverOn()                                           ///
        ///                          - MouseHoverOff()                                          ///
        ///                          - TextfieldActive()                                        ///
        ///                          - TextfieldInactive()                                      ///
        /// </summary>                                                                   //////////

        Button bt_login;
        Button bt_switch;
        Button bt_change_language;

        TextBox tf_username;
        TextBox tf_password;

        Label lb_accessDenied;

        Panel pnl_panel;

        Form m_form;



        public LoginController(Form _form, Panel _panel, Button[] _buttons, TextBox[] _textfields, Label[] _labels) {

            this.m_form = _form;

            this.pnl_panel = _panel;

            this.bt_login = _buttons[0];
            this.bt_switch = _buttons[1];
            this.bt_change_language = _buttons[2];

            this.tf_username = _textfields[0];
            this.tf_password = _textfields[1];

            this.lb_accessDenied = _labels[0];

        }
        


        // Load controllers...
        public void LoadControllers() {

            MouseHoverOff();
            MouseHoverOn();
            TextfieldActive();
            TextfieldInactive();

            ChangeLanguage();

            Switch();

            bt_click_login();

            DisplayErrorLabel(null, true);                          // Dont display and do not provide

        }



        // Change language and provide used language by the country flag...
        private void ChangeLanguage() {

            bt_change_language.Click += (sender, e) => {

                DialogResult _result = MessageBox.Show(Translate.Language("Sovellus käynnistetään uudellen jotta uudet kieliasetukset voidaan ottaa käyttöön."),
                    Translate.Language("HUOMIO") + "!", MessageBoxButtons.OK);


                if(_result == DialogResult.OK) {

                    // Get current used language
                    string _language = Translate.ApplicationLanguage;

                    // Check current language change the language
                    if(_language.Equals("ENGLISH")) {

                        _language = "FINNISH";                                                  // Replace language
                        //Translate.ApplicationLanguage = _language;
                        SQLite.UpdateData("UPDATE Settings SET USE = '" + _language + "'");

                        // Set new image by the language...
                        bt_change_language.BackgroundImage = Settings.SetLanguageButtonImage(_language);

                    } else if(_language.Equals("FINNISH")) {

                        _language = "ENGLISH";                                                  // Replace language
                        //Translate.ApplicationLanguage = _language;
                        SQLite.UpdateData("UPDATE Settings SET USE = '" + _language + "'");

                        // Set new image by the language...
                        bt_change_language.BackgroundImage = Settings.SetLanguageButtonImage(_language);

                    }

                    try {

                        Process.Start("Launcher.exe");

                        m_form.Close();

                    } catch(Exception ex) {

                        Console.Error.WriteLine("\n\n{ EXECUTED FILE NOT FOUND... }\n\n+e");

                    }
                }

            };
        }



        // Mouse hover functionality...
        private void MouseHoverOn() {

            bt_switch.MouseHover += (sender, e) => {

                bt_switch.ForeColor = n_Color.HoverColor(true);

            };

        }

        // Mouse leave functionality...
        private void MouseHoverOff() {

            bt_switch.MouseLeave += (sender, e) => {

                bt_switch.ForeColor = n_Color.HoverColor(false);

            };

        }



        // Textfield cleaner when the textfield has activated...
        // Functionality to username textfields but also the same for the
        // password textfield...
        private void TextfieldActive() {

            tf_username.MouseClick += (sender, e) => {

                // If user click the textfield and its value is default or empty
                // replace the username text to the field...
                if(!string.IsNullOrEmpty(tf_username.Text) &&
                tf_username.Text.ToLower().Equals(Settings.DefaultUserText.ToLower())) {

                    tf_username.Text = "";
                    lb_accessDenied.Visible = false;

                    DisplayErrorLabel(null, false);                 // Dont display and do not provide

                }

            };



            // If user click the textfield and its value is default or empty
            // replace the password text to the field...
            tf_password.MouseClick += (sender, e) => {

                if(!string.IsNullOrEmpty(tf_password.Text) &&
                tf_password.Text.Equals(Settings.DefaultPasswdText)) {

                    tf_password.Text = "";
                    lb_accessDenied.Visible = false;
                    DisplayErrorLabel(null, false);                 // Dont display and do not provide

                }

            };
        }



        // Textfield autofill when the textfield has inactivated...
        // Functionality to username textfields but also the same for the
        // password textfield...
        private void TextfieldInactive() {

            tf_username.MouseLeave += (sender, e) => {

                // If user leave the textfield and it is empty
                // replace the username text to the field...
                if(string.IsNullOrEmpty(tf_username.Text)) {

                    tf_username.Text = Settings.DefaultUserText;

                }

            };



            tf_password.MouseLeave += (sender, e) => {

                // If user leave the textfield and it is empty
                // replace the password text to the field...
                //
                // Also make sure that there is no other (last active) members around...
                if(string.IsNullOrEmpty(tf_password.Text)) {

                    tf_password.Text = Settings.DefaultPasswdText;

                }

            };
        }



        // Switch functionality...
        private void Switch()
        {

            bt_switch.Click += (sender, e) => {

                Registry.Show(true);

                pnl_panel.Visible = false;
                tf_username.Text = Settings.DefaultUserText;
                tf_password.Text = Settings.DefaultPasswdText;

            };

        }



        // Login button click functionality...
        private void bt_click_login()
        {

            bt_login.Click += (sender, e) => {

                Console.WriteLine(DateTime.Now.ToString());

                // If users not exists, do nothing...
                if(!SQLite.UsersExists()) {

                    return;

                }

                string _user = tf_username.Text;
                string _passwd = tf_password.Text;

                // Confirm username and password...
                if(Check.ConfirmLogin(_user, _passwd)) {

                    Settings.CurrentUser = _user;

                    // Start main page after login...
                    // Load necessaries...
                    MainPage _main = new MainPage(m_form, Settings.GetProfiles);
                    _main.LoadComponents();

                    Login.Show(false);                                              // Hide login page...
                    tf_username.Text = Settings.DefaultUserText;                // Default values...
                    tf_password.Text = Settings.DefaultPasswdText;              // Default values...

                } else {

                    DisplayErrorLabel(Translate.Language("Väärä salasana tai käyttäjätunnus"), true);

                }

            };
        }

        private void DisplayErrorLabel(string _message, bool _option)
        {

            if(string.IsNullOrEmpty(_message)) {

                _message = "";

            }

            lb_accessDenied.Text = _message;
            lb_accessDenied.Visible = _option;

        }

    }
}
