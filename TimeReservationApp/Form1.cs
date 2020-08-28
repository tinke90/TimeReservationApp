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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeReservationApp {
    public partial class Form1 : Form {

        /// <summary>                                                                    //////////
        ///                               Form1                                                 ///
        ///                 THIS CLASS PROVIDE LAYOUT AND CONTROLS                              ///
        ///                 TO THE WINDOW FORM...                                               ///
        ///                 THE BEGINNING AND THE END OF IT ALL...                              ///
        ///                                                                                     ///
        ///                             FUNCTIONALITITES:                                       ///
        ///                             - Form1()                                               ///
        ///                             - LoadLanguageSettings()                                ///
        ///                             - LoadTexts()                                           ///
        ///                             - CreateNewDatabase()                                   ///
        ///                             - LoadComponents()                                      ///
        ///                             - LoadLoginTable()                                      ///
        ///                             - LoadRegistryTable()                                   ///
        ///                             - bt_exit_click()                                       ///
        ///                             - bt_minimize_click()                                   ///
        /// </summary>                                                                   //////////

        public Form1() {

            InitializeComponent();

            CreateNewDatabase();                                // Create new database only if its not exists...

            LoadLanguageSettings();                             // SET APPLICATION LANGUAGE IN LAUNCH...

            LoadComponents();

            LoadLoginTable();
            LoadRegistryTable();

            LoadTexts();

        }



        // SET APPLICATION LANGUAGE IN LAUNCH....
        private static void LoadLanguageSettings() {

            // FETCH LANGUAGE FROM DATABASE...
            ArrayList _settings = SQLite.FetchSettings("SELECT * FROM Settings where FUNCTION = 'LANGUAGE'");

            // IF DATABASE HAS HAS NO LANGUAGE SET
            // INSERT DEFAULT LANGUAGE...
            // DEFAULT LANGUAGE VALUE IS FINNISH...
            if(_settings.Count == 0) {

                SQLite.UpdateData("INSERT INTO Settings ('FUNCTION', 'USE') values ('LANGUAGE','FINNISH')");

            }

            // SET LANGUAGE VALUE GAIN FROM DATABASE...
            foreach(SettingsProperty _property in _settings) {
                
                Translate.ApplicationLanguage = _property.GetUse;
                Console.WriteLine(Translate.ApplicationLanguage);
                break;

            }

        }



        private void LoadTexts() {
        
            toolTip.SetToolTip(bt_exit,Translate.Language("Sulje"));
            toolTip.SetToolTip(bt_minimize,Translate.Language("Pienennä"));
            
            lb_title.Text = Translate.Language("Ajanvaraus järjestelmä");
            
        }



        private void CreateNewDatabase() {
            
            SQLite.CreateNewTable();
        
        }



        // Load components...
        private void LoadComponents() {
        
            Drag _drag = new Drag(this, p_panel);
            _drag.LoadFormDrag();

            bt_exit_click();
            bt_minimize_click();
        
        }



        // Load login table...
        private void LoadLoginTable() {
        
            Login _login = new Login(this);
            _login.LoadComponents();
        
        }



        // Load registry table...
        private void LoadRegistryTable() {
        
            Registry _reg = new Registry(this);
            _reg.LoadComponents();
        
        }



        // Load top exit button...
        private void bt_exit_click() {
        
            bt_exit.Click += (sender, e) => {
        
                this.Close();
            
            };    
        
        }



        // Load top minimize button...
        private void bt_minimize_click() {
        
            bt_minimize.Click += (sender, e) => {
            
                this.WindowState = FormWindowState.Minimized;
            
            };
        
        }

    }
}
