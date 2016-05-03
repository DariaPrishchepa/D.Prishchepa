using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class MetalAccount: BankAccount
    {
        //обезличенный металлический счет - тип металла, количество грамм, стоимость за грамм (текущий курс), возможность пополнять и обналичивать счет по текущему курсу
        public string Type { get; set; }
        public double MetalCosts { get; set; }
        public double TheNumberOfGrams { get; set; }

        public MetalAccount(int id, string client, string type, double metalCosts, double theNomberOfGrams): base(id, client)
        {

            Type = type;
            MetalCosts = metalCosts;
            TheNumberOfGrams = theNomberOfGrams;
            double firstBalance = TheNumberOfGrams*MetalCosts;
            Balance = firstBalance;
            FirstBalance = firstBalance;
        }

        public override void Refill(double theNumberOfGrams)
        {
            TheNumberOfGrams += theNumberOfGrams;
            double sum = theNumberOfGrams * MetalCosts;
            base.Refill(sum);
        }

        public override void WriteOff(double theNumberOfGrams)
        {
            if (TheNumberOfGrams - theNumberOfGrams >= 0)
            {
                TheNumberOfGrams += theNumberOfGrams;
                double sum = theNumberOfGrams*MetalCosts;
                base.WriteOff(sum);
            }
            else Console.WriteLine($"Вы пытаетесь продать больше, чем у Вас есть");
        }
    }
}
