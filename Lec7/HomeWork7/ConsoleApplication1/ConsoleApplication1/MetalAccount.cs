using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    class MetalAccount : BankAccount
    {
        //обезличенный металлический счет - тип металла, количество грамм, стоимость за грамм (текущий курс), возможность пополнять и обналичивать счет по текущему курсу
        private double _metalCosts;
        public string Type { get; set; }

        public double MetalCosts
        {
            get { return _metalCosts; }
        }

        public double TheNumberOfGrams { get; set; }

        public MetalAccount(int id, string client, double firstBalance, string type, double metalCosts, double theNomberOfGrams) : base(id, client, firstBalance)
        {

            Type = type;
            _metalCosts = metalCosts;
            TheNumberOfGrams = theNomberOfGrams;

        }

        public override bool Refill(double sum)
        {
            //TheNumberOfGrams += theNumberOfGrams;
            //double sum = theNumberOfGrams * MetalCosts;
            if (base.Refill(sum)) return true;
            return false;
        }

    }
}

