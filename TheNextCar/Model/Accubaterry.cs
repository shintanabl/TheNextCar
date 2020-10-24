using System;
using System.Collections.Generic;
using System.Text;

namespace TheNextCar.Model
{
    class Accubaterry
    {
        private int voltage;
        private Boolean stateOn = false;

        public Accubaterry(int voltage)
        {
            this.voltage = voltage;
        }

        public void turnOn()
        {
            this.stateOn = true;
        }

        public void turnOff()
        {
            this.stateOn = false;
        }

        public Boolean isOn()
        {
            return this.stateOn;
        }
    }
}
