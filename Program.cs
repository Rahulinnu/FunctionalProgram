using System;
namespace BasicFunction
{
    public class Program
    {
        public static void Main()
        {
            FlipCoin flip = new FlipCoin();
            flip.CalcFlipCoin();

            LeapYear leap = new LeapYear();
            leap.CalcLeapYear();

            PowerOfTwo pot1 = new PowerOfTwo();
            pot1.Pot();

            HarmonicNumber hm = new HarmonicNumber();
            hm.HaNu();

            Factors fa = new Factors();
            fa.Fact();

            QuotientReminder qr = new QuotientReminder();
            qr.QuRe();

            SwapNum sn = new SwapNum();
            sn.SwNu();

            EvenOdd eo = new EvenOdd();
            eo.EvOd();

            AlphaCons ac = new AlphaCons();
            ac.AlCo();

            LargestThree lt = new LargestThree();
            lt.LaTh();
        }
    }
}
