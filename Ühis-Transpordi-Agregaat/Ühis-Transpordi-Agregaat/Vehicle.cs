using System;
using System.Collections.Generic;
using System.Text;

namespace Ühis_Transpordi_Agregaat
{
    class Vehicle
    {
        public string type;
        public string lineNr;
        public string langitude;
        public string latitude;

        public void VehicleConstructor(string _type, string _lineNr, string _langitude, string _latitude)
        {
            type = _type;
            lineNr = _lineNr;
            langitude = _langitude;
            latitude = _latitude;
        }

    }
}
