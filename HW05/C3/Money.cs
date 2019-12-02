using System;
using System.Collections.Generic;
using System.Text;

namespace C3
{
    public class Money
    {
        int dollars, cents;

        public Money(int dollars, int cents)
        {
            this.dollars = (cents / 100);
            this.cents = cents % 100;
            this.dollars += dollars;
        }
        public Money(int cents)
        {
            dollars = (cents / 100);
            this.cents = cents % 100;
        }
        public int getDollars()
        {
            return dollars;
        }
        public int getCents()
        {
            return cents;
        }
        public override String ToString()
        {
            String str;
            str = "Your amount is: " + "$" + dollars + "." + cents + "";
            return str;
        }
        public bool equals(Money obj)
        {
                Money compare = (Money)obj;
                return this.dollars == compare.getDollars() && this.cents == compare.getCents();
        }
        public Money increment(Money money)
        {
            Money increment = new Money(this.dollars + money.getDollars(), this.cents + money.getCents());
            return increment;
        }
        public Money decrement(Money money)
        {
            Money decrement = new Money(money.getDollars()- this.dollars, this.cents - money.getCents());
            return decrement;
        }
       
    }































    //private int dollars;
    //private int cents;

    //public Money()
    //{
    //    dollars = 0;
    //    cents = 0;
    //}

    //public Money(int dollars)
    //{
    //    this.dollars = dollars;
    //    cents = 0;
    //}

    //public Money(int dollars, int cents)
    //{
    //    this.dollars = dollars;
    //    this.cents = cents;
    //    if (cents > 99)
    //    {
    //        int totalDollars = cents / 100;
    //        cents -= totalDollars * 100;
    //        dollars += totalDollars;
    //    }
    //}
    //public int getDollars()
    //{
    //    return dollars;
    //}

    //public int getCents()
    //{
    //    return cents;
    //}
    //public void setDollars(int newDollars)
    //{
    //    dollars = newDollars;
    //}

    //public void setCents(int newCents)
    //{
    //    cents = newCents;
    //    if (cents > 99)
    //    {

    //        int totalDollars = cents / 100;
    //        cents -= totalDollars * 100;
    //        dollars += totalDollars;
    //    }
    //}

    //public Money Increment(Money incrementAmount)
    //{
    //    dollars += incrementAmount.dollars;
    //    cents += incrementAmount.cents;
    //    if (cents > 99)
    //    {
    //        int totalDollars = cents / 100;
    //        cents -= totalDollars * 100;
    //        dollars += totalDollars;
    //    }

    //    return this;
    //}

    //public Money Decrement(Money decrementAmount)
    //{
    //    if (dollars < decrementAmount.dollars || (dollars == decrementAmount.dollars && cents < decrementAmount.cents))
    //    {
    //        dollars = 0;
    //        cents = 0;
    //        return this;
    //    }
    //    dollars -= decrementAmount.dollars;
    //    cents -= decrementAmount.cents;
    //    if (cents < 0)
    //    {
    //        cents += 100;
    //        dollars--;
    //    }

    //    return this;
    //}
    //public bool equals(Money other)
    //{
    //    return (dollars == other.dollars) && (cents == other.cents);
    //}

    //public String toString()
    //{
    //    return "$" + dollars + "." + cents;
    //}

}
