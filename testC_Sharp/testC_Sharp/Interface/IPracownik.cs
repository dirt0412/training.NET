﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testC_Sharp.Classes;

namespace testC_Sharp.Interface
{
    public interface IPracownik 
    {
        double Wynagrodzenie(int godzinyPrzepracowane, double stawkaZaGodzine);
    }
}
