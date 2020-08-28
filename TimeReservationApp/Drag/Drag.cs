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
using System.Windows.Forms;

namespace TimeReservationApp {
    public class Drag {

        /// <summary>                                                                    //////////
        ///                               Drag                                                  ///
        ///                 THIS CLASS IS USED TO CONTROL THE WINDOW FORM                       ///
        ///                 MOVEMENTS, DRAGIING WINDOW ONCE THE WINDOW FORM                     ///
        ///                 DEFAULT DRAGGING IS DISABLED AND TOP BAR HAS                        ///
        ///                 CUSTOMIZED                                                          ///
        ///                             FUNCTIONALITITES:                                       ///
        ///                             - Drag(Form _form, Panel _panel                         ///
        ///                             - LoadFormDrag()                                        ///
        ///                             - MouseDown()                                           ///
        ///                             - MouseUp()                                             ///
        ///                             - MouseMove()                                           ///
        ///                                                                                     ///
        /// </summary>                                                                   //////////

        Form m_form;
        Panel m_panel;

        bool m_mouseDown;
        Point m_lastLocation;

        public Drag()
        {
        }

        public Drag(Form _form, Panel _panel) {

            this.m_form = _form;
            this.m_panel = _panel;

        }



        public void LoadFormDrag() {

            MouseDown();                                // Load mouse down functionality
            MouseUp();                                  // Load mouse up functionality
            MouseMove();                                // Load mouse move functionality

        }



        // Mouse down functionality
        private void MouseDown() {

            m_panel.MouseDown += (sender, e) => {

                m_mouseDown = true;                     // Mouse is button has pressed...
                m_lastLocation = e.Location;            // Save the last mousedown location

            };

        }



        // Mouse up functionality
        private void MouseUp() {

            m_panel.MouseUp += (sender, e) => {

                m_mouseDown = false;                    // Mouse button has released...

            };

        }



        // Mouse move functionality
        private void MouseMove() {

            m_panel.MouseMove += (sender, e) => {

                if(m_mouseDown) {

                    // window form last location x - last saved location + mouse current moving location
                    // and window form last location y - last saved location + mouse current moving location
                    m_form.Location = new Point((m_form.Location.X - m_lastLocation.X) + e.X, 
                        (m_form.Location.Y - m_lastLocation.Y) + e.Y);

                }

            };

        }


    }
}
