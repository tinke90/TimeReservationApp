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
    public class n_Time {

        /// <summary>                                                                    //////////
        ///                               n_Time                                                ///
        ///                 THIS CLASS IS USED TO RETURN THE TIME LIST OF                       ///
        ///                 BOOKING TIMES, ALSO TO RETURN CURRENT DATE AND TIME                 ///
        ///                                                                                     ///
        ///                             FUNCTIONALITITES:                                       ///
        ///                             - GetTimes                                              ///
        ///                             - GetTestTimes                                          ///
        ///                             - GetCurrentTime                                        ///
        ///                             - GetCurrentDate                                        ///
        /// </summary>                                                                   //////////

        static string[] _testTimes = { "00:00", "00:30", "1:00", "1:30", "2:00", "2:30", "3:00", "3:30", "4:00",
            "4:30", "5:00", "5:30", "6:00", "6:30", "7:00", "7:30", "8:00", "8:30", "9:00", "9:30", "10:00",
            "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30",
            "16:00", "16:30", "17:00", "17:30", "18:00", "18:30", "19:00", "19:30", "20:00", "20:30", "21:00",
            "21:30", "22:00", "22:30", "23:00", "23:30"};

        static string[] _times = { "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00",
                "15:30", "16:00", "16:30", "17:00", "17:30", "18:00", "18:30", "19:00" };




        public static string[] GetTimes {
        
            get => _times;
        
        }




        public static string[] GetTestTimes {
        
            get => _testTimes;
        
        }

        
        
        public static string GetCurrentTime {
        
            get => Settings.CutDateOff(DateTime.Now.ToString());
        
        }



        public static string GetCurrentDate {
        
            get => Settings.CutTimeOff(DateTime.Now.ToString());
        
        }

    }
}
