using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeOOP
{
    class Car
    {
        // Car "has-a" Radio
        private Radio aRadio = new Radio();

        public void TurnOnRadio(bool onOff)
        {
            // Delegate call to inner object
            aRadio.Power(onOff);
        }
    }
}
