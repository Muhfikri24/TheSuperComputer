using System;
using System.Collections.Generic;
using System.Text;

namespace TheSuperComputer
{
    class Vga
    {
        private String brand;
        private int graphicsClock;
        private int memoryClock;

        public Vga(String brand,int grapicsClock,int memoryClock)
        {
            this.brand = brand;
            this.graphicsClock = grapicsClock;
            this.memoryClock = memoryClock;
        }
        public String getBrand()
        {
            return this.brand;
        }
        public int getGrapicsClock()
        {
            return this.graphicsClock;
        }
        public int getMemoryClock()
        {
            return this.memoryClock;
        }
        public override string ToString()
        {
            return $"Vga brand : {this.brand} ; Vga clock grapics : {this.graphicsClock} ; Vga clock memory : {this.memoryClock}";
        }
    }
}
