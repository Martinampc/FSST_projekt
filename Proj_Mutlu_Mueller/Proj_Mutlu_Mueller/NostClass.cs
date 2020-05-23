using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Mutlu_Mueller
{
    class Noten
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

        public Noten(bool m5er1 = false, bool m5er2 = false, bool m5er3 = false, bool m5er4 = false, bool m5er5 = false, //Konstruktor
                    bool e5er1 = false, bool e5er2 = false, bool e5er3 = false, bool e5er4 = false, bool e5er5 = false,
                    bool d5er1 = false, bool d5er2 = false, bool d5er3 = false, bool d5er4 = false, bool d5er5 = false)
        {
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
        }
        //get-set Methoden für alle variablen setzten
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
    }
}
    class Parkplatz
    {
        int _matheparkplatz = 0;     //gesamtanzahl der geparkten 5er in jedem Fach
        int _englischparkplatz = 0;
        int _deutschparkplatz = 0;
    }