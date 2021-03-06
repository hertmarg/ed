﻿using System;
using System.Collections.Generic;
using Gtk;

namespace Tabla
{
    public class Bombo
    {
        private IList<int> bolas = new List<int>();
        private Random random = new Random();

        public Bombo()
        {
            for (int bola = 1; bola <= 90; bola++)
                bolas.Add(bola);
        }

        public int sacarbola()
        {
            int indexAleatorio = random.Next(bolas.Count);
            if (indexAleatorio < 0)
            {
                return -1;
            }
            else
            {
                int bola = bolas[indexAleatorio];
                bolas.RemoveAt(indexAleatorio);
                return bola;
            }
    
      }
    }
  }
