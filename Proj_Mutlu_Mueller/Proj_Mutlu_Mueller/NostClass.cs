using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Mutlu_Mueller
{
    public class Noten
    {
        bool _m5er1; //negative Mathenote in jahrgängen 1 bis 5
        bool _m5er2;
        bool _m5er3;
        bool _m5er4;
        bool _m5er5;

        bool _e5er1; //negative Englischnote in Jahrgängen 1 bis 5
        bool _e5er2;
        bool _e5er3;
        bool _e5er4;
        bool _e5er5;

        bool _d5er1; //negative Deutschnote in Jahrgängen 1 bis 5
        bool _d5er2;
        bool _d5er3;
        bool _d5er4;
        bool _d5er5;

        int _jahrgang; //Derzeitiger Jahrgang
        int _wiederholungen; //Anzahl der Klassenwiderholungen
        bool _fail; //unausbesserbarer Fehlschlag (Schulverweis)


        //Parkplätze für unsere unterstützten Fächer
        int _matheparkplatz;
        int _englischparkplatz;
        int _deutschparkplatz;

        public Noten(bool m5er1 = false, bool m5er2 = false, bool m5er3 = false, bool m5er4 = false, bool m5er5 = false, //Konstruktor
                    bool e5er1 = false, bool e5er2 = false, bool e5er3 = false, bool e5er4 = false, bool e5er5 = false,
                    bool d5er1 = false, bool d5er2 = false, bool d5er3 = false, bool d5er4 = false, bool d5er5 = false,
                    int jahrgang = 1, int wiederholungen = 0, bool fail = false,
                    int matheparkplatz = 0, int deutschparkplatz = 0, int englischparkplatz = 0)
        {
            if (jahrgang < 0 || jahrgang > 6)
            {
                throw new Exception("ungültiger jahrgang");
            }

            if (wiederholungen < 0 || wiederholungen > 3)
            {
                throw new Exception("Ungültige Anzahl der Wiederholungen");
            }

            _jahrgang = jahrgang;
            _wiederholungen = wiederholungen;
            _fail = fail;

            _d5er1 = d5er1;
            _d5er2 = d5er2;
            _d5er3 = d5er3;
            _d5er4 = d5er4;
            _d5er5 = d5er5;

            _e5er1 = e5er1;
            _e5er2 = e5er2;
            _e5er3 = e5er3;
            _e5er4 = e5er4;
            _e5er5 = e5er5;

            _m5er1 = m5er1;
            _m5er2 = m5er2;
            _m5er3 = m5er3;
            _m5er4 = m5er4;
            _m5er5 = m5er5;

            if (englischparkplatz < 0 || englischparkplatz > 2)
                throw new Exception("Ungültige Werte für den Englischparkplatz");

            if (deutschparkplatz < 0 || deutschparkplatz > 2)
                throw new Exception("Ungültige Werte für den deutschparkplatz");

            if (matheparkplatz < 0 || matheparkplatz > 2)
                throw new Exception("Ungültige Werte für den matheparkplatz");


            _matheparkplatz = matheparkplatz; // werte übergeben
            _deutschparkplatz = deutschparkplatz;
            _englischparkplatz = englischparkplatz;
        }
        //get-set Methoden für alle Noten variablen setzten
        public bool M5er1
        {
            get
            {
                return _m5er1;
            }
            set
            {
                _m5er1 = value;
            }
        }

        public bool M5er2
        {
            get
            {
                return _m5er2;
            }
            set
            {
                _m5er2 = value;
            }
        }

        public bool M5er3
        {
            get
            {
                return _m5er3;
            }
            set
            {
                _m5er3 = value;
            }
        }

        public bool M5er4
        {
            get
            {
                return _m5er4;
            }
            set
            {
                _m5er4 = value;
            }
        }

        public bool M5er5
        {
            get
            {
                return _m5er5;
            }
            set
            {
                _m5er5 = value;
            }
        }

        public bool E5er1
        {
            get
            {
                return _e5er1;
            }
            set
            {
                _e5er1 = value;
            }
        }

        public bool E5er2
        {
            get
            {
                return _e5er2;
            }
            set
            {
                _e5er2 = value;
            }
        }

        public bool E5er3
        {
            get
            {
                return _e5er3;
            }
            set
            {
                _e5er3 = value;
            }
        }

        public bool E5er4
        {
            get
            {
                return _e5er4;
            }
            set
            {
                _e5er4 = value;
            }
        }

        public bool E5er5
        {
            get
            {
                return _e5er5;
            }
            set
            {
                _e5er5 = value;
            }
        }

        public bool D5er1
        {
            get
            {
                return _d5er1;
            }
            set
            {
                _d5er1 = value;
            }
        }

        public bool D5er2
        {
            get
            {
                return _d5er2;
            }
            set
            {
                _d5er2 = value;
            }
        }
        public bool D5er3
        {
            get
            {
                return _d5er3;
            }
            set
            {
                _d5er3 = value;
            }
        }
        public bool D5er4
        {
            get
            {
                return _d5er4;
            }
            set
            {
                _d5er4 = value;
            }
        }
        public bool D5er5
        {
            get
            {
                return _d5er5;
            }
            set
            {
                _d5er5 = value;
            }
        }

        public bool Fail
        {
            get
            {
                if (_deutschparkplatz == 1 && _englischparkplatz == 1 && _matheparkplatz == 1 && _jahrgang == 6) //ende der 5. Klasse müssen alle Parkplätze gereumt sein
                {
                    _fail = true;
                }
                if (_deutschparkplatz >= 2 || _matheparkplatz >= 2 || _englischparkplatz >= 2) //Man dar nur einen 5er pro Fach haben
                {
                    _fail = true;
                }
                if (_wiederholungen >=3) // man darf nicht öfter als 2 mal sitzenbleiben
                {
                    _fail = true;
                }

                return _fail;
            }
            set
            {
                _fail = value;
            }
        }

        public int Wiederholungen
        {
            get
            {
                return _wiederholungen;
            }
            set
            {
                if (value < 0 || value > 3)
                {
                    throw new Exception("Ungültige Anzahl der Wiederholungen");
                }

                _wiederholungen = value;
            }
        }

        public int Jahrgang
        {
            get
            {
                return _jahrgang;
            }
            set
            {
                if (value < 0 || value > 6)
                {
                    throw new Exception("ungültiger jahrgang");
                }

                _jahrgang = value;
            }
        }

        public void Aufsteigen()
        {
            _jahrgang++;
        }
       
        public void Sitzenbleiben()
        {
            _wiederholungen++;
        }

        //Get Funktionen für Parkplätze
        public int Matheparkplatz
        {
            get
            {
                if (_m5er1 == true && _jahrgang == 2) //wenn der 5er nach einem Jahr nicht ausgebessert wird wird er auf den Parkplatz verschoben
                    _matheparkplatz++;
                if (_m5er2 == true && _jahrgang == 3)
                    _matheparkplatz++;
                if (_m5er3 == true && _jahrgang == 4)
                    _matheparkplatz++;
                if (_m5er4 == true && _jahrgang == 5)
                    _matheparkplatz++;
                if (_m5er5 == true && _jahrgang == 6)
                    _matheparkplatz++;


                return _matheparkplatz;
            }
        }

        public int Deutschparkplatz
        {
            get
            {
                if (_d5er1 == true && _jahrgang == 3) //wenn der 5er nach einem Jahr nicht ausgebessert wird wird er auf den Parkplatz verschoben
                    _deutschparkplatz++;
                if (_d5er2 == true && _jahrgang == 4)
                    _deutschparkplatz++;
                if (_d5er3 == true && _jahrgang == 5)
                    _deutschparkplatz++;
                if (_d5er4 == true && _jahrgang == 6)
                    _deutschparkplatz++;
                if (_d5er5 == true && _jahrgang == 6)
                    _deutschparkplatz++;

                return _deutschparkplatz;

            }
        }

        public int Englischparkplatz
        {
            get
            {
                if (_e5er1 == true && _jahrgang == 3) //wenn der 5er nach einem Jahr nicht ausgebessert wird wird er auf den Parkplatz verschoben
                    _englischparkplatz++;
                if (_e5er1 == true && _jahrgang == 4)
                    _englischparkplatz++;
                if (_e5er1 == true && _jahrgang == 5)
                    _englischparkplatz++;
                if (_e5er1 == true && _jahrgang == 6)
                    _englischparkplatz++;
                if (_e5er1 == true && _jahrgang == 6)
                    _englischparkplatz++;

                return _englischparkplatz;
            }
        }

        public bool Visible { get; set; }

       

        //funktionen zum managen der Parkplätze
        public void EnglischparkplatzAdd()
        {
            _englischparkplatz++;
            if (_englischparkplatz >= 2) //Es darf pro Fach nur ein 5er geparkt werden
                _fail = true;
        }

        public void DeutschparkplatzAdd()
        {
            _deutschparkplatz++;
            if (_deutschparkplatz >= 2) //Es darf pro Fach nur ein 5er geparkt werden
                _fail = true;
        }

        public void MatheparkplatzAdd()
        {
            _matheparkplatz++;
            if (_matheparkplatz >= 2) //Es darf pro Fach nur ein 5er geparkt werden
                _fail = true;
        }

        public void EnglischparkplatzRemove()
        {
            _englischparkplatz--;
            if (_englischparkplatz < 0)
                throw new Exception("Parkplatz erlaubt keine negativen Noten");
        }

        public void DeutschparkplatzRemove()
        {
            _deutschparkplatz--;
            if (_deutschparkplatz < 0)
                throw new Exception("Parkplatz erlaubt keine negativen Noten");
        }

        public void MatheparkplatzRemove()
        {
            _matheparkplatz--;
            if (_matheparkplatz < 0)
                throw new Exception("Parkplatz erlaubt keine negativen Noten");
        }


    }

}