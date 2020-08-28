using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeReservationApp {
    public class Translate {

        /// <summary>                                                                    //////////
        ///                               Translate                                             ///
        ///                 THIS SIMPLE CLASS IS USED FOR THE TRANSLATE THE PROGRAM             ///
        ///                 LAYOUT TEXTS AND HINT TEXTS...                                      ///
        ///                                                                                     ///
        ///                             FUNCTIONALITITES:                                       ///
        ///                             - ApplicationLanguage                                   ///
        ///                             - Language(string _str)                                 ///
        /// </summary>                                                                   //////////

        static string m_language = "ENGLISH";
        static string m_defaultLanguage = "FINNISH";



        public static string ApplicationLanguage {

            get => m_language;
            set => m_language = value;

        }



        static string[] m_english = { 
            "Name",
            "Lastname",
            "Username",
            "Birthdate",
            "Email",
            "Phone",
            "Cance",
            "Save",
            "Reservation",
            "Logout",
            "Booking system",
            "Registry",
            "Password",
            "Password again",
            "User",
            "Register as a user",
            "Enter username",
            "Enter password",
            "Wrong password or username", 
            "Sup board",
            "Booking time",
            "Booking time cannot be over 3 hours.",
            "Booking time must be at least 1 hour.",
            "Details",
            "Change password",
            "New password",
            "Password again",
            "Old password",
            "Sup board booking",
            "Accept",
            "Login",
            "Login",
            "Logout",
            "Again",
            "First name",
            "Book time",
            "Time",
            "Date",
            "Close",
            "Minimize",
            "Enter phone number",
            "Enter email address",
            "Enter password again",
            "Make a sup board reservation",
            "Application restart is required to apply the new language settings.",
            "NOTICE",
            "Passwords do not match"
        };

        static string[] m_finnish = {
            "Nimi",
            "Sukunimi",
            "Käyttäjätunnus",
            "Syntymäpäivä",
            "Sähköposti",
            "Puhelin",
            "Peruuta",
            "Tallenna",
            "Varaus",
            "Ulos",
            "Ajanvaraus järjestelmä",
            "Rekisteröidy",
            "Salasana",
            "Salasana uudelleen",
            "Käyttäjä",
            "Rekisteröidy käyttäjäksi",
            "Syötä käyttäjätunnus",
            "Syötä salasana",
            "Väärä salasana tai käyttäjätunnus",
            "Sup lauta",
            "Varausaika",
            "Varaus aika ei voi olla yli 3 tuntia pitkä.",
            "Varaus aika tulee olla ainakin tunnin mittainen.",
            "Tiedot",
            "Vaihda salasana",
            "Uusi salasana",
            "Salasana uudelleen",
            "Vanha salasana",
            "Sup lauta varaus",
            "Hyväksy",
            "Kirjaudu",
            "Kirjaudu sisään",
            "Kirjaudu ulos",
            "Uudelleen",
            "Etunimi",
            "Varaa aika",
            "Aika",
            "Päiväys",
            "Sulje",
            "Pienennä",
            "Syötä puhelinnumero",
            "Syötä sähköpostiosoite",
            "Syötä salasana uudelleen",
            "Tee lautavaraus",
            "Sovellus käynnistetään uudellen jotta uudet kieliasetukset voidaan ottaa käyttöön.",
            "HUOMIO",
            "Salasanat eivät täsmää"
        };



        // Simple translator to the two language.
        public static string Language(string _str) {

            if(!m_language.Equals(m_defaultLanguage)) {

               for(int i = 0; i < m_finnish.Length; i++) {

                    if(m_finnish[i].ToLower().Equals(_str.ToLower())) {

                        return m_english[i];

                    }

                }

            }

            return _str;

        }
    }
}
