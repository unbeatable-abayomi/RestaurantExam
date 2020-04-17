using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantExam
{
    class Restaurant
    {
        public string Name { get; set; }

        public string Address { get; set; }

        private double gratuity;

        public Restaurant (string name, string address,double grat)
        {
            Name = name;
            Address = address;
            Gratuity = grat;
        }

        public double Gratuity
        {
            get { return gratuity; }
            private set
            {
                if (value > 0.0)
               
                { gratuity = value; }

            }
        }

        public void GenerateRececipt()
        {

        }

    }
}
