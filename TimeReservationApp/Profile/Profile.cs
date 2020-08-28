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
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TimeReservationApp {
    class Profile {

        /// <summary>                                                                    //////////
        ///                               Profile                                               ///
        ///                 THIS CLASS IS USED HOLD Profile PROPERTIES                          ///
        ///                                                                                     ///
        ///                             FUNCTIONALITITES:                                       ///
        ///                             - Profile(int _id, string _username, string _password,  ///
        ///                                string _email, string _phone, bool _lastActive,      ///
        ///                                string _firstname, string _lastname,                 ///
        ///                                string _birthdate)                                   ///
        ///                             - GetId                                                 ///
        ///                             - GetUsername                                           ///
        ///                             - GetPassowrd                                           ///
        ///                             - GetEmail                                              ///
        ///                             - GetPhone                                              ///
        ///                             - GetLastActive                                         ///
        ///                             - GetFirstname                                          ///
        ///                             - GetLastname                                           ///
        ///                             - GetBirthdate                                          ///
        /// </summary>                                                                   //////////

        int m_id;
        string m_username;
        string m_password;
        string m_email;
        string m_phone;
        bool m_lastActive;
        string m_firstname;
        string m_lastname;
        string m_birthdate;



        public Profile(int _id, string _username, string _password,
            string _email, string _phone, bool _lastActive, string _firstname,
            string _lastname, string _birthdate) {

            this.m_id = _id;
            this.m_username = _username;
            this.m_password = _password;
            this.m_email = _email;
            this.m_phone = _phone;
            this.m_lastActive = _lastActive;
            this.m_firstname = _firstname;
            this.m_lastname = _lastname;
            this.m_birthdate = _birthdate;

        }



        public int GetId {

            get => m_id;

        }



        public string GetUsername {

            get => m_username;

        }



        public string GetPassowrd {

            get => m_password;

        }



        public string GetEmail {

            get => m_email;

        }



        public string GetPhone {

            get => m_phone;

        }



        public bool GetLastActive {

            get => m_lastActive;

        }



        public string GetFirstname {
        
            get => m_firstname;
        
        }



        public string GetLastname {
        
            get => m_lastname;
        
        }



        public string GetBirthdate {
        
            get => m_birthdate;
        
        }

    }

}
