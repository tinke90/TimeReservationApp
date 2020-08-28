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
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeReservationApp {
    class HalfTransparent {

        /// <summary>                                                                    //////////
        ///                               HALF TRANSPARENT                                      ///
        ///                 THIS CLASS IS USED GIVE HALFTRANSPARENT BLACK                       ///
        ///                 COLOR...                                                            ///
        ///                             FUNCTIONALITITES:                                       ///
        ///                             - GetHalfTransparent                                    ///
        ///                             - Half_Transparen(int _A, Color _color)                 ///
        ///                                                                                     ///
        /// </summary>                                                                   //////////

        public static Color GetHalfTransparent {

            get => Half_Transparent(127, Color.Black);

        }

        private static Color Half_Transparent(int _A, Color _color) {

            return Color.FromArgb(_A, _color.R, _color.G, _color.B);

        }
    }
}
