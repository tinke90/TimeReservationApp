using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeReservationApp {
    public partial class ChangePassword : Form {

        /// <summary>                                                                    //////////
        ///                               ChangePassword                                        ///
        ///                 THIS CLASS PROVIDE THE LAYOUT AND CONTROLLERS                       ///
        ///                 IN SAME CLASS FILE...                                               ///
        ///                 CLASS PROVIDES THE USER LOGINING AND STARTING                       ///
        ///                 THE MAIN PAGE...                                                    ///
        ///                                                                                     ///
        ///                             FUNCTIONALITITES:                                       ///
        ///                             - ChangePassword()                                      ///
        ///                             - LoadComponents()                                      ///
        ///                             - LoadTexts()                                           ///
        ///                             - bt_exit_click()                                       ///
        ///                             - bt_save_click()                                       ///
        ///                             - bt_change_click()                                     ///
        ///                             - UpdatePassword()                                      ///
        /// </summary>                                                                   //////////

        public ChangePassword() {
            InitializeComponent();

            LoadComponents();                       // Load components...
        }

        // Load button controls...
        private void LoadComponents() {
            bt_exit_click();                        // Button exit functionality...
            bt_save_click();                        // Button save functionality...
            bt_change_click();                      // Button change functionality...
            bt_change_minimize.Visible = false;

            Drag _drag = new Drag(this, p_change_panel);
            _drag.LoadFormDrag();

            LoadTexts();
        }

        // Load hint and object texts...
        private void LoadTexts() {
            lb_change_title.Text = Translate.Language("Vaihda salasana");
            lb_new_pwd.Text = Translate.Language("Uusi salasana");
            lb_new_pwd_again.Text = Translate.Language("Salasana uudelleen");
            lb_old_pwd.Text = Translate.Language("Vanha salasana");

            toolTip.SetToolTip(tf_new_pwd, Translate.Language("Uusi salasana"));
            toolTip.SetToolTip(tf_new_pwd_again, Translate.Language("Salasana uudelleen"));
            toolTip.SetToolTip(tf_old_pwd, Translate.Language("Vanha salasana"));
            toolTip.SetToolTip(bt_change, Translate.Language("Vaihda salasana"));
            toolTip.SetToolTip(bt_change_exit, Translate.Language("Sulje"));
        }

        private void bt_exit_click() {
            bt_change_exit.Click += (sender, e) => {
                this.Close();
            };
        }

        private void bt_save_click() {
            bt_change_minimize.Click += (sender, e) => {
                this.WindowState = FormWindowState.Minimized;
            };
        }

        private void bt_change_click() {
            bt_change.Click += (sender, e) => {
                if(tf_new_pwd.Text.Equals(tf_new_pwd_again.Text)) {
                    UpdatePassword();
                    this.Close();
                }
            };
        }

        // Profile password update functionality...
        private void UpdatePassword() {
            ArrayList _list = Settings.GetProfiles;
            foreach(Profile _profile in _list) {
                if(_profile.GetUsername.Equals(Settings.CurrentUser)) {
                    string _query = "UPDATE Profile SET PASSWORD = '" + tf_new_pwd.Text +
                        "' WHERE USERNAME = '"+_profile.GetUsername+"'";

                    if(tf_old_pwd.Text.Equals(_profile.GetPassowrd)) {
                        SQLite.UpdateData(_query);
                    }
                    
                    break;
                }
            }
        }
    }
}
