using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WFA_projLEDS
{
    class Leds
    {
        private byte estado;
        public Leds()
        {
            this.estado = 0;
        }
        public Leds(byte estado)
        {
            this.estado = estado;
        }
        public void acender(int led)
        {
            int potencia = led - 1;
            this.estado = (byte)((int)this.estado | (int)Math.Pow(2, potencia));
        }
        public void apagar(int led)
        {
            int potencia = led - 1;
            this.estado = (byte)((int)this.estado & (int)(255 - Math.Pow(2, potencia)));
        }
        public bool getEstado(int led)
        {

            byte checador = (byte)((int)this.estado & (int)Math.Pow(2, led - 1));
            return (checador !=0);
        }
        public byte getEstado()
        {
            return this.estado;
        }

    }
}
