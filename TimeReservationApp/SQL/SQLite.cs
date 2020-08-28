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
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeReservationApp {
    public class SQLite {

        /// <summary>                                                                    //////////
        ///                               SQLite                                                ///
        ///                 THIS CLASS IS USED FOR ANYTHING THAT HAS DO                         ///
        ///                 WITH THE DATABASE, UPDATE, CREATE NEW DATABASE                      ///
        ///                 DELETE DATABASE OR FETCH DATA FROM THE DATABASE                     ///
        ///                                                                                     ///
        ///                             FUNCTIONALITITES:                                       ///
        ///                             - CreateNewTable()                                      ///
        ///                             - FetchData(string _query)                              ///
        ///                             - FetchReservation(string _query)                       ///
        ///                             - UpdateData(string _query)                             ///
        ///                             - FetchSettings(string _query)                          ///
        ///                             - UsersExists()                                         ///
        /// </summary>                                                                   //////////

        static ArrayList m_data;
        static ArrayList m_reservation_data;
        static ArrayList m_settings_data;

        static SQLiteConnection m_connection;
        static SQLiteCommand m_command;

        static string m_URL = @"\Users\"+Environment.UserName+@"\Documents\TimeReservationApp\Database";
        static string m_FILE = m_URL+"\\database.db";

        static string m_TABLE = "Profile";
        static string m_RESERVATION = "Reservation";
        static string m_SETTINGS = "Settings";
        


        /**
         * Create 3 new table to database if not exists...
         * - Profile
         * - Settings
         * - Reservation
         */
        public static void CreateNewTable() {
            
            try {

                if(!Directory.Exists(m_URL)) {
                
                    Directory.CreateDirectory(m_URL);
                
                }

                if(!File.Exists(m_FILE)) {
                
                    SQLiteConnection.CreateFile(m_FILE);
                
                }

                string _createProfileTable = "CREATE TABLE IF NOT EXISTS " + m_TABLE +
                    " (ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT," +
                    "USERNAME VARCHAR(50) NOT NULL," +
                    "PASSWORD VARCHAR(50) NOT NULL," +
                    "EMAIL VARCHAR(20) NOT NULL," +
                    "PHONE VARCHAR(20) NOT NULL," +
                    "LAST_ACTIVE VARCHAR(20) NOT NULL," +
                    "FIRSTNAME VARCHAR(50) NOT NULL," +
                    "LASTNAME VARCHAR(50) NOT NULL," +
                    "BIRTHDATE VARCHAR(50) NOT NULL)";

                string _createReservationTable = "CREATE TABLE IF NOT EXISTS "+ m_RESERVATION+
                    " (ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT," +
                    "NAME VARCHAR(100) NOT NULL," +
                    "LASTNAME VARCHAR(100) NOT NULL," +
                    "RESERVATION VARCHAR(100) NOT NULL," +
                    "RESERVED_TIME VARCHAR(100) NOT NULL," +
                    "RESERVED_DATE VARCHAR(100) NOT NULL," +
                    "DATE VARCHAR(100) NOT NULL)";

                string _createSettingsTable = "CREATE TABLE IF NOT EXISTS "+ m_SETTINGS +
                    " (ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT," +
                    "FUNCTION VARCHAR(100) NOT NULL," +
                    "USE VARCHAR(100) NOT NULL)";

                m_connection = new SQLiteConnection("Data source="+ m_FILE);
                m_command = new SQLiteCommand(m_connection);
                m_connection.Open();
                        
                m_command.CommandText = _createProfileTable;
                m_command.ExecuteNonQuery();

                m_command.CommandText = _createReservationTable;
                m_command.ExecuteNonQuery();

                m_command.CommandText = _createSettingsTable;
                m_command.ExecuteNonQuery();

                m_connection.Close();

            } catch(Exception e) {

                Console.WriteLine(e);

            }

        }



        // Fetch data from Profile table...
        public static ArrayList FetchData(string _query) {
            
            if(string.IsNullOrEmpty(_query)) {
        
                return null;
            
            }

            m_reservation_data = new ArrayList();
          
            using(m_connection = new SQLiteConnection("Data source=" + m_FILE)) {

                using(m_command = new SQLiteCommand(m_connection)) {
                
                    m_connection.Open();

                    m_command.CommandText = _query;

                    using(SQLiteDataReader _reader = m_command.ExecuteReader()) {
                  
                        while(_reader.Read()) {
                        
                            bool _active = false;

                            // If user is either active or not, place the
                            // value to variable _active...
                            if(_reader["LAST_ACTIVE"].ToString().Equals("True")) {
                            
                                _active = true;
                            
                            } else {
                            
                                _active = false;
                            
                            }

                            m_reservation_data.Add(new Profile(
                                Convert.ToInt32(_reader["ID"].ToString()),
                                _reader["USERNAME"].ToString(),
                                _reader["PASSWORD"].ToString(),
                                _reader["EMAIL"].ToString(),
                                _reader["PHONE"].ToString(),
                                _active,
                                _reader["FIRSTNAME"].ToString(),
                                _reader["LASTNAME"].ToString(),
                                _reader["BIRTHDATE"].ToString()));

                        }

                    }

                }

                m_connection.Close();

            }

            return m_reservation_data;

        }




        // Fetch data from Reservation table
        public static ArrayList FetchReservation(string _query) {

            if(string.IsNullOrEmpty(_query)) {
        
                return null;
            
            }

            m_data = new ArrayList();
            
            using(m_connection = new SQLiteConnection("Data source=" + m_FILE)) {
            
                using(m_command = new SQLiteCommand(m_connection)) {
                
                    m_connection.Open();

                    m_command.CommandText = _query;

                    using(SQLiteDataReader _reader = m_command.ExecuteReader()) {
                    
                        while(_reader.Read()) {
                        
                            // Storing data from the database table Profile
                            m_data.Add(new ReservationProperty(
                                Convert.ToInt32(_reader["ID"].ToString()),
                                _reader["NAME"].ToString(),
                                _reader["LASTNAME"].ToString(),
                                _reader["RESERVATION"].ToString(),
                                _reader["RESERVED_TIME"].ToString(),
                                _reader["RESERVED_DATE"].ToString(),
                                _reader["DATE"].ToString()));

                        }

                    }

                }

                m_connection.Close();

            }

            return m_data;

        }



        // Update any table or data in database...
        public static void UpdateData(string _query) {

            try {

                if(string.IsNullOrEmpty(_query)) {

                    return;

                }

                using(m_connection = new SQLiteConnection("Data source=" + m_FILE)) {

                    using(m_command = new SQLiteCommand(m_connection)) {

                        m_connection.Open();

                        m_command.CommandText = _query;
                        m_command.ExecuteNonQuery();

                        m_connection.Close();

                    }

                }

            }catch(Exception e){

                Console.WriteLine(e);

            }

        }



        // Fetch data from Settings table...
        public static ArrayList FetchSettings(string _query) {

            if(string.IsNullOrEmpty(_query)) {
            
                return null;
            
            }

            m_settings_data = new ArrayList();
            
            using(m_connection = new SQLiteConnection("Data source="+m_FILE)) {
            
                using(m_command = new SQLiteCommand(m_connection)) {
                
                    m_connection.Open();

                    m_command.CommandText = _query;

                    using(SQLiteDataReader _reader = m_command.ExecuteReader()) {
                    
                        while(_reader.Read()) {
                        
                            m_settings_data.Add(new SettingsProperty(
                                Convert.ToInt32(_reader["ID"].ToString()),
                                _reader["FUNCTION"].ToString(),
                                _reader["USE"].ToString()));

                        }

                    }

                    m_connection.Close();

                }
            }

            return m_settings_data;

        }



        // Fetch data from table Profile and check
        // if any profiles exists.
        public static bool UsersExists() {

            string _query = "SELECT * FROM Profile";

            try {

                if(SQLite.FetchData(_query).Count > 0) {

                    return true;

                }

            } catch(Exception e) {

                Console.Error.WriteLine("No currently users available...");
                return false;

            }

            return false;

        }

    }
}
