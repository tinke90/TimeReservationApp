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
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeReservationApp {
    public partial class Reservation : Form {

        /// <summary>                                                                    //////////
        ///                               Reservation                                           ///
        ///                 THIS CLASS PROVIDE LAYOUT DESIGN AND CONTROLS                       ///
        ///                 IN SAME CLASS...                                                    ///
        ///                 THIS CLASS ALLOWE USER TO BOOK SUP BOARDS...                        ///
        ///                 ALSO CHECK THE BOOKING SCHEDULE BEFORE LOADING                      ///
        ///                 AND PROVIDING THE BOOKING TIMES TO THE USER...                      ///
        ///                                                                                     ///
        ///                             FUNCTIONALITITES:                                       ///
        ///                             - Reservation()                                         ///
        ///                             - LoadComponents()                                      ///
        ///                             - LoadTexts()                                           ///
        ///                             - LoadReservationTime()                                 ///
        ///                             - bt_exit_click()                                       ///
        ///                             - bt_accept_reservation_click()                         ///
        ///                             - UpdateReservationList(string _reservedTimesList)      ///                                                          ///
        /// </summary>                                                                   //////////

        string[] m_times = n_Time.GetTestTimes;                  // Get list of times...



        public Reservation() {
            
            InitializeComponent();

            LoadComponents();
        
        }



        public void LoadComponents() {
        
            bt_reservation_cancel.BackColor = HalfTransparent.GetHalfTransparent;
            bt_reservation_accept.BackColor = HalfTransparent.GetHalfTransparent;

            LoadReservationTime();
            bt_exit_click();
            bt_accept_reservation_click();

            cb_reservation.Text = "1x "+ Translate.Language("Sup lauta");
            cb_reservation.Items.Add("1x "+ Translate.Language("Sup lauta"));
            cb_reservation.Items.Add("2x "+ Translate.Language("Sup lauta"));
            cb_reservation.DropDownStyle = ComboBoxStyle.DropDownList;

            cb_at.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_to.DropDownStyle = ComboBoxStyle.DropDownList;
            
            Drag _drag = new Drag(this, p_reservation_panel);
            _drag.LoadFormDrag();

            LoadTexts();
        
        }



        private void LoadTexts() {
        
            lb_reservation_title.Text = Translate.Language("Sup lauta varaus");
            lb_reservation_name.Text = Translate.Language("Nimi");
            lb_lastname.Text = Translate.Language("Sukunimi");
            lb_date.Text = Translate.Language("Päiväys");
            lb_time.Text = Translate.Language("Aika");
            bt_reservation_accept.Text = Translate.Language("Hyväksy");
            bt_reservation_cancel.Text = Translate.Language("Peruuta");
            lb_reservation.Text = Translate.Language("Varaus");

            toolTip.SetToolTip(bt_reservation_exit,Translate.Language("Sulje"));
        
        }



        // Load reservation time...
        private void LoadReservationTime() {
            
            bool _first = true;                                     // Set first available time to
                                                                    // start time value...
            int _index = 0;                                         // Set end time value 1 hour further of
                                                                    // start time value...
            int _reserved = 0;

            for(int i = 0; i < m_times.Length; i++) {

                // WHEN THIS IS NOT REQUIRED ANYMORE, REMOVE IT!!!
                int _manipulateTime = 0;

                string[] _tmp = n_Time.GetCurrentTime.Split(':');   // Split hours and minutes
                int _tmpHours = Convert.ToInt32(_tmp[0]) - _manipulateTime;           // Store hours
                int _tmpMinutes = Convert.ToInt32(_tmp[1]);         // Store minutes

                string[] _tmpTime = m_times[i].Split(':');          // Split hours and minutes
                int _timeHours = Convert.ToInt32(_tmpTime[0]);      // Store hours
                int _timeMinutes = Convert.ToInt32(_tmpTime[1]);    // Store minutes

                if(!Check.IsReserved(m_times[i])) {

                    // Check if placed time from list is greater than the current time
                    // or if the current hour is the same but the minutes are different...
                    if(_timeHours > _tmpHours || _timeMinutes > _tmpMinutes && _timeHours == _tmpHours) {

                        // Place first available item from the list to the
                        // start time to combobox text...
                        if(_first) {

                            cb_at.Items.Add(m_times[i]);
                            cb_to.Items.Add(m_times[i]);
                            cb_at.Text = m_times[i];

                            _first = false;
                            _index = i + 2;                             // index to place second item
                                                                        // to end time selector.
                        } else {
                       
                            cb_at.Items.Add(m_times[i]);                 // Place item to the start time selector
                            cb_to.Items.Add(m_times[i]);                 // Place item to the end time selector
                        
                        }

                        // Place the text or time in
                        // hour further...
                        if(_index == i) {
                        
                            //cb_to.Items.Add(_times[i]);                 // Place value
                            cb_to.Text = m_times[i];                     // Set text...
                        
                        }

                    }

                }

            }

        }



        /**
         * BUTTON EXIT FUNCTIONALITIES
         * - EXIT
         * - RESERVATION
         */
        private void bt_exit_click() {
         
            bt_reservation_cancel.Click += (sender, e) => {
            
                this.Close();
            
            };



            bt_reservation_exit.Click += (sender, e) => {
            
                this.Close();
            
            };
        }

        // Button accept reservation funtionality...
        private void bt_accept_reservation_click() {
           
            bt_reservation_accept.Click += (sender, e) => {

                if(string.IsNullOrEmpty(cb_at.Text) ||
                string.IsNullOrEmpty(cb_to.Text)) {
            
                    return; 
                
                }

                // Reservation start time...
                string[] _cb_atTime = cb_at.SelectedItem.ToString().Split(':');     // Start time selector
                string _atTimeHours = _cb_atTime[0];                                // Hours
                string _atTimeMinutes = _cb_atTime[1];                              // Minutes

                // Reservation end time...
                string[] _cb_toTime = cb_to.SelectedItem.ToString().Split(':');     // End time selector
                string _toTimeHours = _cb_toTime[0];                                // Hours
                string _toTimeMinutes = _cb_toTime[1];                              // Minutes

                string _reservedTimesList = "";

                int _indexAt = cb_at.SelectedIndex;                                 // Value start collecting
                int _indexTo = cb_to.SelectedIndex;                                 // Value end collecting...

                // Collect reserved slots between _indexAt and _indexTo
                for(int i = 0; i < cb_at.Items.Count; i++) {
                
                    if(i >= _indexAt && i <= _indexTo) {
                    
                        if(i + 1 > _indexTo) {
                        
                            _reservedTimesList += cb_at.Items[i];                   // Check if last pick, dont add
                        
                        } else {                                                    // the separator...
                       
                            _reservedTimesList += cb_at.Items[i] + " | ";           // Else store with separator...
                        
                        }                                                           // This is for, its alot easier to
                    
                    }                                                               // exctract the database column data 
                
                }                                                                   // and block already reserved slots...



                /**
                 * We want to make sure that the resevation time wont be greater than 3 hours max
                 * but either under 1 hour
                 * 
                 * If we meet the requirements, lets finish the reservation...
                 */
                if(cb_to.SelectedIndex > cb_at.SelectedIndex) {
                
                    if(cb_to.SelectedIndex - cb_at.SelectedIndex <= 5) {
                    
                        UpdateReservationList(_reservedTimesList);
                        MainPageControls.UpdateReservationList();
                        this.Close();
                    
                    } else {
                    
                        MessageBox.Show(Translate.Language("Varaus aika ei voi olla yli 3 tuntia pitkä."), "HOX!");
                    
                    }
                
                } else {
                
                    MessageBox.Show(Translate.Language("Varaus aika tulee olla ainakin tunnin mittainen."), "HOX!");

                }
                
            };

        }



        // Update reservation functionality...
        private void UpdateReservationList(string _reservedTimesList) {
        
            string _name = tf_name.Text;
            string _lastname = tf_lastname.Text;
            string _reservation = cb_reservation.Text;
            string _datePicker = dt_datepicker.Text;
            string _reserved_date = n_Time.GetCurrentDate;
            
            string _query = "INSERT INTO Reservation ('NAME','LASTNAME','RESERVATION'," +
                "'RESERVED_TIME', RESERVED_DATE,'DATE') values ('" + _name+"', '"+_lastname+"', '"+_reservation+"', " +
                "'"+ _reservedTimesList + "', '"+_datePicker+"', '"+_reserved_date+"')";

            SQLite.UpdateData(_query);                              // Update reservation list...
        
        }

    }

}
