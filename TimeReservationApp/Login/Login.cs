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
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace TimeReservationApp {
    public class Login {

        /// <summary>                                                                    //////////
        ///                               Login                                                 ///
        ///                 THIS CLASS IS USED FOR THE Login WINDOW FORM LAYOUT                 ///
        ///                 DESIGN CLASS, TO LOAD NECESSARIES BEFORE THE CONTROLS...            ///
        ///                                                                                     ///
        ///                             FUNCTIONALITITES:                                       ///
        ///                             - Login(Form _form)                                     ///
        ///                             - LoadComponents()                                      ///
        ///                             - LoadTexts()                                           ///
        ///                             - Show(bool _option)                                    ///
        ///                             - LoadConfigs()                                         ///
        ///                             - Switch()                                              ///
        ///                             - bt_click_login()                                      ///
        ///                             - DisplayErrorLabel(string _message, bool _option)      ///
        ///                                                                                     ///
        /// </summary>                                                                   //////////


        Button bt_login;
        Button bt_log_switch;
        Button bt_change_language;
        TextBox tf_log_username;
        TextBox tf_log_password;
        static Panel p_log_table;
        Label lb_log_login;
        Label lb_log_accessDenied;
        ToolTip toolTip;

        Form m_form;



        public Login(Form _form) {

            bt_login = new Button();
            bt_log_switch = new Button();
            bt_change_language = new Button();
            tf_log_username = new TextBox();
            tf_log_password = new TextBox();
            p_log_table = new FadePanel();
            lb_log_login = new Label();
            lb_log_accessDenied = new Label();
            toolTip = new ToolTip();

            this.m_form = _form;

        }



        // Load components...
        public void LoadComponents() {

            LoadConfigs();                              // Load configs before any other...

            Button[] _buttons = { bt_login, bt_log_switch, bt_change_language };
            TextBox[] _textfields = { tf_log_username, tf_log_password };

            Label[] _labels = { lb_log_accessDenied };

            LoginController _controller = new LoginController(m_form, p_log_table, _buttons, _textfields, _labels);
            _controller.LoadControllers();

            p_log_table.Visible = true;

            //Switch();

            //bt_click_login();

            //DisplayErrorLabel(null, true);    // Dont display and do not provide

            LoadTexts();

        }



        private void LoadTexts() {

            toolTip.SetToolTip(bt_login, Translate.Language("Kirjaudu sisään"));
            toolTip.SetToolTip(tf_log_username, Translate.Language("Syötä käyttäjätunnus"));
            toolTip.SetToolTip(tf_log_password, Translate.Language("Syötä salasana"));
            toolTip.SetToolTip(bt_log_switch, Translate.Language("Rekisteröidy käyttäjäksi"));

        }



        // Show the login table...
        public static void Show(bool _option) {

            p_log_table.Visible = _option;

        }



        // Load configs...
        private void LoadConfigs() {

            /**
             * LABELS
             * - LOGIN
             * - ACCESS DENIED
             */
            lb_log_login.Text = Translate.Language("Kirjaudu");
            lb_log_login.Width = 199;
            lb_log_login.Height = 29;
            lb_log_login.Font = new Font("Times New Roman", 16, FontStyle.Underline);
            lb_log_login.Location = new Point(241, 77);
            lb_log_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lb_log_login.BackColor = Color.Transparent;
            lb_log_login.ForeColor = Color.White;

            lb_log_accessDenied.Text = Translate.Language("Default");
            lb_log_accessDenied.AutoSize = true;
            lb_log_accessDenied.Font = new Font("Times New Roman", 8, FontStyle.Bold);
            lb_log_accessDenied.Location = new Point(247, 255);
            lb_log_accessDenied.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lb_log_accessDenied.BackColor = Color.Transparent;
            lb_log_accessDenied.ForeColor = Color.Red;
            


            /**
             * USER TEXTFIELDS
             * - USERNAME
             * - PASSWROD
             */
            tf_log_username.Text = Translate.Language("Käyttäjä");
            tf_log_username.Width = 199;
            tf_log_username.Height = 23;
            tf_log_username.BorderStyle = BorderStyle.FixedSingle;
            tf_log_username.Location = new Point(241, 120);
            tf_log_username.Font = new Font("Arial", 10, FontStyle.Bold);
            tf_log_username.TextAlign = HorizontalAlignment.Center;
            tf_log_username.BackColor = Color.Black;
            tf_log_username.ForeColor = Color.White;
            tf_log_username.TabIndex = 1;

            tf_log_password.Text = "1234";
            tf_log_password.Width = 199;
            tf_log_password.Height = 23;
            tf_log_password.BorderStyle = BorderStyle.FixedSingle;
            tf_log_password.Location = new Point(241, 148);
            tf_log_password.PasswordChar = '*';
            tf_log_password.Font = new Font("Arial", 10, FontStyle.Bold);
            tf_log_password.TextAlign = HorizontalAlignment.Center;
            tf_log_password.BackColor = Color.Black;
            tf_log_password.ForeColor = Color.White;
            tf_log_password.TabIndex = 2;



            /**
             * BUTTONS
             * - SWITCH
             * - LOGIN
             */
            bt_log_switch.Text = Translate.Language("Rekisteröidy");
            bt_log_switch.Location = new Point(242, 177);
            bt_log_switch.FlatStyle = FlatStyle.Popup;
            bt_log_switch.Font = new Font("Arial", 8, FontStyle.Bold);
            bt_log_switch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            bt_log_switch.BackColor = Color.Transparent;
            bt_log_switch.ForeColor = Color.White;
            bt_log_switch.AutoSize = true;
            bt_log_switch.TabIndex = 3;

            bt_login.Text = Translate.Language("Kirjaudu");
            bt_login.Width = 199;
            bt_login.Height = 40;
            bt_login.Location = new Point(241, 210);
            bt_login.FlatStyle = FlatStyle.Popup;
            bt_login.Font = new Font("Arial", 10, FontStyle.Bold);
            bt_login.ForeColor = Color.White;
            bt_login.BackColor = HalfTransparent.GetHalfTransparent;
            bt_login.TabIndex = 4;

            bt_change_language.Text = Translate.Language("");
            
            bt_change_language.Width = 30;
            bt_change_language.Height = 30;
            bt_change_language.BackgroundImage = Settings.SetLanguageButtonImage(Translate.ApplicationLanguage);
            bt_change_language.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            bt_change_language.Location = new Point(642, 280);
            bt_change_language.FlatStyle = FlatStyle.Popup;
            bt_change_language.Font = new Font("Arial", 10, FontStyle.Bold);
            bt_change_language.ForeColor = Color.White;
            bt_change_language.BackColor = HalfTransparent.GetHalfTransparent;
            bt_change_language.TabIndex = 4;



            /**
             * MAIN PANEL
             * - TABLE
             */
            p_log_table.Width = 680;
            p_log_table.Height = 318;
            p_log_table.BackColor = HalfTransparent.GetHalfTransparent;
            p_log_table.Location = new Point(74,99);
            p_log_table.Controls.Add(bt_login);
            p_log_table.Controls.Add(tf_log_username);
            p_log_table.Controls.Add(tf_log_password);
            p_log_table.Controls.Add(bt_log_switch);
            p_log_table.Controls.Add(bt_change_language);
            p_log_table.Controls.Add(lb_log_login);
            p_log_table.Controls.Add(lb_log_accessDenied);



            /**
             * Add table to window form...
             */
            m_form.Controls.Add(p_log_table);
        }



        
    }
}
