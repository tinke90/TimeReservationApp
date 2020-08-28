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
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TimeReservationApp {
    class Settings {

        /// <summary>                                                                    //////////
        ///                               Settings                                              ///
        ///                 THIS CLASS IS USED TO HOLD SOME EXTREMETLY                          ///
        ///                 IMPORTANT DATA AND WORK AS A TOOL CLASS.                            ///
        ///                                                                                     ///
        ///                             FUNCTIONALITITES:                                       ///
        ///                             - GetProfiles                                           ///
        ///                             - CurrentUser                                           ///
        ///                             - DefaultUserText                                       ///
        ///                             - DefaultPasswdText                                     ///
        ///                             - CutDateOff(string _dateTime)                          ///
        ///                             - CutTimeOff(string _dateTime)                          ///
        ///                             - FormatTime(string _str)                               ///
        ///                             - SetLanguageButtonImage(string _language)              ///
        /// </summary>                                                                   //////////

        static string m_username;



        // Load profiles from the database...
        public static ArrayList GetProfiles {
        
            get => SQLite.FetchData("SELECT * FROM Profile");
        
        }



        public static string CurrentUser {

            get => m_username;
            set => m_username = value;

        }



        // Used to reset the empty text field in login page
        // just as well to clear the text field when its clicked...
        public static string DefaultUserText {
        
            get => Translate.Language("Käyttäjä");
        
        }



        // Used to reset the empty text field in login page
        // just as well to clear the text field when its clicked...
        public static string DefaultPasswdText {
        
            get => "1234";
        
        }



        // Return time only only {Hours & Minutes}...
        public static string CutDateOff(string _dateTime) {
        
            string[] _tmp = _dateTime.Split(' ');

            return FormatTime(_tmp[1]);
        
        }



        // Return Hours & Minutes only...
        private static string FormatTime(string _str) {
        
            string[] _delSeconds = _str.Split('.');
            return _delSeconds[0] + ":" + _delSeconds[1];
        
        }



        // Return the whole date...
        public static string CutTimeOff(string _dateTime) {
        
            string[] _tmp = _dateTime.Split(' ');

            return _tmp[0];
        
        }



        // Select proper background image to the switch langauge button...
        public static Bitmap SetLanguageButtonImage(string _language) {
            
            if(_language.Equals("FINNISH")) {

                return global::TimeReservationApp.Properties.Resources.finnish_icon;

            } else if(_language.Equals("ENGLISH")) {

                return global::TimeReservationApp.Properties.Resources.england_icon;

            }

            return null;

        }

    }
}
