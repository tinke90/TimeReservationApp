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
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;



namespace Panel_Fade {

    /// <summary>                                                                    //////////
    ///                               Panel_Fade                                            ///
    ///                 THIS CLASS IS USED FOR REDUCE THE FLICKERING                        ///
    ///                 OF THE PANELS WHEN SWITCHING BETWEEN PANELS                         ///
    ///                 OR CREATING AND LOADING NEW PANEL...                                ///
    ///                                                                                     ///
    ///                             FUNCTIONALITITES:                                       ///
    ///                             - FadePanel()                                           ///
    ///                             - t_Tick(object sender, EventArgs e)                    ///
    /// </summary>                                                                   //////////

    public class FadePanel : Panel {

        int _fade = 0;                                      // Fade value default zero

        Timer t = new Timer();                              // New timer...



        public FadePanel() {

            // Set control styles either true or false...
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
            ControlStyles.DoubleBuffer, true);
            t.Tick += new EventHandler(t_Tick);             // Create new timer event...
        
        }



        // Count fade value
        private void t_Tick(object sender, EventArgs e) {
        
            _fade += 8;                                     // Increase fade value by 8 in one time

            // If fade value is greater or equals than 255
            // set fade value and stop, else keep going...
            if(_fade >= 255) {
               
                _fade = 255;
                t.Enabled = false;
            
            }

            Invalidate();                                   // Invalidate and redraw...

        }

    }

}