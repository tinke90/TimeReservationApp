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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeReservationApp {
    public class Check {

        /// <summary>                                                                    //////////
        ///                                 CHECK CLASS                                         ///
        ///                 THIS CLASS IS USED TO CHECK IF TRUE OR FALSE                        ///
        ///                 USED TO ANTICIPATE THE SITUATION WHERE                              ///
        ///                 CHECKING IS REQUIRED OR DESIRABLE                                   ///
        ///                             FUNCTIONALITITES:                                       ///
        ///                             - IfEmptyOrNull(TextBox[] _list)                        ///
        ///                             - IfContainsChars(string _str)                          ///
        ///                             - LastActiveMember()                                    ///
        ///                             - GetLastActiveMember                                   ///
        ///                             - ConfirmLogin(string _username, string _password)      ///
        ///                             - IsReserved(string _str)                               ///
        /// </summary>                                                                   //////////

        static int m_lastActiveMember = -1;

        static string[] m_chars = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j",
        "k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z","å","ä","ö"};



        // Check if any of the required textfields are empty...
        public static bool IfEmptyOrNull(TextBox[] _list) {

            foreach(TextBox _text in _list) {

                if(string.IsNullOrEmpty(_text.Text)) {
                    return true;
                }

            }

            return false;
        }



        // Check if string contains characters...
        public static bool IfContainsChars(string _str) {

            foreach(string _text in m_chars) {
        
                if(_str.ToLower().Contains(_text)) {
                    return true;
                }

            }

            return false;
        }



        // Check the last active member...
        public static int LastActiveMember() {

            ArrayList _list = SQLite.FetchData("SELECT * FROM Profile");

            foreach(Profile _profile in _list) {

                if(_profile.GetLastActive) {

                    m_lastActiveMember = _profile.GetId;
                    return _profile.GetId;

                }

            }

            return 0;
        }

        public static int GetLastActiveMember {

            get => m_lastActiveMember;

        }



        // Check login access...
        public static bool ConfirmLogin(string _username, string _password) {

            ArrayList _profiles = SQLite.FetchData("SELECT * FROM Profile");


            foreach(Profile _profile in _profiles) {

                if(_profile.GetUsername.Equals(_username) && 

                    _profile.GetPassowrd.Equals(_password)) {
                    return true;

                }
            }

            return false;
        }



        /**
         * Check if time is reserved
         * block the usage...
         * 
         * Compare starting time to end time...
        */
        public static bool IsReserved(string _str) {

            ArrayList _tempList = SQLite.FetchReservation("SELECT * FROM Reservation where DATE = '"+n_Time.GetCurrentDate+"'");

            foreach(ReservationProperty _property in _tempList) {

                if(_property.GetTimeBetween.Contains(_str)) {

                    return true;

                }
            }

            return false;
        }

    }
}
