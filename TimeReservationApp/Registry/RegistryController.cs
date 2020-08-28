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
using System.Windows.Forms;

namespace TimeReservationApp {
    class RegistryController {

        /// <summary>                                                                    //////////
        ///                               RegistryController                                    ///
        ///                 THIS CLASS IS USED TO PROVIDE RegistryController FORM CONTROLLERS   ///
        ///                                                                                     ///
        ///                             FUNCTIONALITITES:                                       ///
        ///                             - RegistryController(Button[] _buttons,                 ///
        ///                             TextBox[] _textfields)                                  ///
        ///                             - LoadControllers()                                     ///
        ///                             - MouseHoverOn()                                        ///
        ///                             - MouseHoverOff()                                       ///
        /// </summary>                                                                   //////////


        Button bt_registry;
        Button bt_switch;

        TextBox tf_username;
        TextBox tf_password;
        TextBox tf_passwordAgain;
        TextBox tf_email;
        TextBox tf_phone;



        public RegistryController(Button[] _buttons, TextBox[] _textfields) {

            this.bt_registry = _buttons[0];
            this.bt_switch = _buttons[1];

            this.tf_username = _textfields[0];
            this.tf_password = _textfields[1];
            this.tf_passwordAgain = _textfields[2];
            this.tf_email = _textfields[3];
            this.tf_phone = _textfields[4];

        }



        // Load controllers...
        public void LoadControllers() {

            MouseHoverOff();
            MouseHoverOn();

        }



        // Mouse hover functionality...
        private void MouseHoverOn() {

            bt_switch.MouseHover += (sender, e) => {

                bt_switch.ForeColor = n_Color.HoverColor(true);

            };

        }


        // Mouse leave functinality...
        private void MouseHoverOff() {

            bt_switch.MouseLeave += (sender, e) => {

                bt_switch.ForeColor = n_Color.HoverColor(false);

            };

        }

    }
}
