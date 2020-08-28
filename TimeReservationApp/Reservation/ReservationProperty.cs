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
    class ReservationProperty {

        /// <summary>                                                                    //////////
        ///                               ReservationProperty                                   ///
        ///                 THIS CLASS IS USED TO HOLD Resevation PROPERTIES                    ///
        ///                                                                                     ///
        ///                             FUNCTIONALITITES:                                       ///
        ///                             - ReservationProperty(int _id, string _name,            ///
        ///                             string _lastname, string _reservation,                  ///
        ///                             string _timeBetween, string _reserved_date,             ///
        ///                             string _date)                                           ///
        ///                             - GetId                                                 ///
        ///                             - GetName                                               ///
        ///                             - GetLastname                                           ///
        ///                             - GetReservation                                        ///
        ///                             - GetTimeBetween                                        ///
        ///                             - GetReservedDate                                       ///
        ///                             - GetDate                                               ///
        /// </summary>                                                                   //////////

        int m_id;
        string m_name;
        string m_lastname;
        string m_reservation;
        string m_timeBetween;
        string m_reserved_date;
        string m_date;



        public ReservationProperty(int _id, string _name, string _lastname,
            string _reservation, string _timeBetween, string _reserved_date, string _date) {

            this.m_id = _id;
            this.m_name = _name;
            this.m_lastname = _lastname;
            this.m_reservation = _reservation;
            this.m_timeBetween = _timeBetween;
            this.m_reserved_date = _reserved_date;
            this.m_date = _date;

        }



        public int GetId {
        
            get => m_id;
        
        }
        
        

        public string GetName {
        
            get => m_name;
        
        }
        
        
        
        public string GetLastname {
        
            get => m_lastname;
        
        }
        
        
        
        public string GetReservation {
        
            get => m_reservation;
        
        }
        
        
        
        public string GetTimeBetween {
        
            get => m_timeBetween;
        
        }
        
        
        public string GetReservedDate {
        
            get => m_reserved_date;
        
        }
        
        
        public string GetDate {
        
            get => m_date;
        
        }
    }
}
