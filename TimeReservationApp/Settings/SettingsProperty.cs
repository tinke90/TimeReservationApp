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
using System.Text;
using System.Threading.Tasks;

namespace TimeReservationApp {
    class SettingsProperty {

        /// <summary>                                                                    //////////
        ///                               SettingsProperty                                      ///
        ///                 THIS CLASS IS USED TO HOLD SETTINGS PROPERTIES                      ///
        ///                                                                                     ///
        ///                             FUNCTIONALITITES:                                       ///
        ///                             - SettingsProperty(int _id, string _function,           ///
        ///                             string _use)                                            ///
        ///                             - GetId                                                 ///
        ///                             - GetFunction                                           ///
        ///                             - GetUse                                                ///
        /// </summary>                                                                   //////////

        int m_id;
        string m_function;
        string m_use;



        public SettingsProperty(int _id, string _function, string _use) {
        
            this.m_id = _id;
            this.m_function = _function;
            this.m_use = _use;
        
        }



        public int GetId {

            get => m_id;

        }




        public string GetFunction {
        
            get => m_function;
        
        }



        public string GetUse {
        
            get => m_use;
        
        }

    }
}
