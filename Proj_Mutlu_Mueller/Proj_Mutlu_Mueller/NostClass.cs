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

        public Noten(bool m5er1 = false, bool m5er2 = false, bool m5er3 = false, bool m5er4 = false, bool m5er5 = false, 
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
    }
}
    class Parkplatz
    {
        int _matheparkplatz = 0;     //gesamtanzahl der geparkten 5er in jedem Fach
        int _englischparkplatz = 0;
        int _deutschparkplatz = 0;
    }