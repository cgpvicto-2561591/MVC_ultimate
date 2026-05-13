using System;
using System.Collections.Generic;
using System.Text;

namespace Bibli_Modele
{
    public class NumZone
    {
        private int _numero = 0;
        public event EventHandler EventNumZone;
        /// <summary>
        /// constructeur de NumZone
        /// </summary>
        /// <param name="numero"></param>
        public NumZone(int numero)
        {
            Numero = numero;
        }

        /// <summary>
        /// constructeur vide
        /// </summary>
        public NumZone()
        {
        }

        public void getNumZone(int valeur)
        {
            Numero = valeur;
        }

        /// <summary>
        /// override de ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Zone{_numero}";
        }
        /// <summary>
        /// get set _numero
        /// </summary>
        public int Numero { get => _numero;
            private set 
            {
                if (value < 0)
                {
                    value = 0;
                }
                if (value > 100)
                {
                    value = 100;
                }
                // il ne peut pas etre null okay
                _numero = value;
                EventNumZone?.Invoke(this, EventArgs.Empty);
            }  
        }
    }
}
