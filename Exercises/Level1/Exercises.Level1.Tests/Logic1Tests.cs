using Xunit;

namespace Exercises.Level1.Tests
{
    public class Logic1Tests
    {
        private Logic1 _logic1 = new Logic1();

        [Theory]
        [InlineData(false, 30, false)]
        [InlineData(true, 50, false)]
        [InlineData(true, 70, true)]
        [InlineData(false, 30, true)]
        [InlineData(true, 50, true)]
        [InlineData(true, 60, false)]
        [InlineData(false, 61, false)]
        [InlineData(true, 40, false)]
        [InlineData(false, 39, false)]
        [InlineData(true, 40, true)]
        [InlineData(false, 39, true)]
        [InlineData(false, 39, true)]
        public void CigarParty(bool expected, int cigars, bool isWeekend)
        {
            Assert.Equal(expected, _logic1.CigarParty(cigars, isWeekend));
        }

        [Theory]
        [InlineData(2, 5, 10)]
        [InlineData(0, 5, 2)]
        [InlineData(1, 5, 5)]
        [InlineData(1, 3, 3)]
        [InlineData(0, 10, 2)]
        [InlineData(0, 2, 9)]
        [InlineData(2, 9, 9)]
        [InlineData(2, 10, 5)]
        [InlineData(0, 2, 2)]
        [InlineData(1, 3, 7)]
        [InlineData(0, 2, 7)]
        [InlineData(0, 6, 2)]
        public void DateFashion(int expected, int you, int date)
        {
            Assert.Equal(expected, _logic1.DateFashion(you, date));
        }

        [Theory]
        [InlineData(true, 70, false)]
        [InlineData(false, 95, false)]
        [InlineData(true, 95, true)]
        [InlineData(true, 90, false)]
        [InlineData(false, 50, false)]
        [InlineData(false, 50, true)]
        [InlineData(false, 100, false)]
        [InlineData(true, 100, true)]
        [InlineData(false, 105, true)]
        [InlineData(false, 59, false)]
        [InlineData(false, 59, true)]
        [InlineData(true, 60, false)]
        public void SquirrelPlay(bool expected, int temp, bool isSummer)
        {
            Assert.Equal(expected, _logic1.SquirrelPlay(temp, isSummer));
        }

        [Theory]
        [InlineData(0, 60, false)]
        [InlineData(1, 65, false)]
        [InlineData(0, 65, true)]
        [InlineData(2, 85, false)]
        [InlineData(1, 85, true)]
        [InlineData(1, 70, false)]
        [InlineData(1, 75, true)]
        [InlineData(0, 40, false)]
        [InlineData(0, 40, true)]
        [InlineData(2, 90, false)]
        public void CaughtSpeeding(int expected, int speed, bool isBirthday)
        {
            Assert.Equal(expected, _logic1.CaughtSpeeding(speed, isBirthday));
        }

        [Theory]
        [InlineData(7, 3, 4)]
        [InlineData(20, 9, 4)]
        [InlineData(21, 10, 11)]
        [InlineData(9, 12, -3)]
        [InlineData(9, 4, 5)]
        [InlineData(20, 4, 6)]
        [InlineData(21, 14, 7)]
        [InlineData(20, 14, 6)]
        public void SortaSum(int expected, int a, int b)
        {
            Assert.Equal(expected, _logic1.SortaSum(a, b));
        }

        [Theory]
        [InlineData("7:00", 1, false)]
        [InlineData("7:00", 5, false)]
        [InlineData("10:00", 0, false)]
        [InlineData("10:00", 6, false)]
        [InlineData("off", 0, true)]
        [InlineData("off", 6, true)]
        [InlineData("10:00", 1, true)]
        [InlineData("10:00", 3, true)]
        [InlineData("10:00", 5, true)]
        public void AlarmClock(string expected, int day, bool vacation)
        {
            Assert.Equal(expected, _logic1.AlarmClock(day, vacation));
        }

        [Theory]
        [InlineData(true, 6, 4)]
        [InlineData(false, 4, 5)]
        [InlineData(true, 1, 5)]
        [InlineData(true, 1, 6)]
        [InlineData(false, 1, 8)]
        [InlineData(true, 1, 7)]
        [InlineData(false, 7, 5)]
        [InlineData(true, 8, 2)]
        [InlineData(true, 6, 6)]
        [InlineData(false, -6, 2)]
        [InlineData(true, -4, -10)]
        [InlineData(false, -7, 1)]
        [InlineData(true, 7, -1)]
        [InlineData(true, -6, 12)]
        [InlineData(false, -2, -4)]
        [InlineData(true, 7, 1)]
        [InlineData(false, 0, 9)]
        [InlineData(false, 8, 3)]
        [InlineData(true, 3, 3)]
        [InlineData(false, 3, 4)]
        public void Love6(bool expected, int a, int b)
        {
            Assert.Equal(expected, _logic1.Love6(a, b));
        }

        [Theory]
        [InlineData(true, 5, false)]
        [InlineData(false, 11, false)]
        [InlineData(true, 11, true)]
        [InlineData(true, 10, false)]
        [InlineData(true, 10, true)]
        [InlineData(true, 9, false)]
        [InlineData(false, 9, true)]
        [InlineData(true, 1, false)]
        [InlineData(false, 0, false)]
        [InlineData(true, 0, true)]
        [InlineData(false, -1, false)]
        [InlineData(false, 99, false)]
        [InlineData(true, -99, true)]
        public void In1To10(bool expected, int n, bool outsideMode)
        {
            Assert.Equal(expected, _logic1.In1To10(n, outsideMode));
        }

        [Theory]
        [InlineData(true, 22)]
        [InlineData(true, 23)]
        [InlineData(false, 24)]
        [InlineData(false, 21)]
        [InlineData(true, 11)]
        [InlineData(true, 12)]
        [InlineData(false, 10)]
        [InlineData(false, 9)]
        [InlineData(false, 8)]
        [InlineData(true, 0)]
        [InlineData(true, 1)]
        [InlineData(false, 2)]
        [InlineData(true, 121)]
        [InlineData(true, 122)]
        [InlineData(false, 123)]
        [InlineData(false, 46)]
        [InlineData(false, 49)]
        [InlineData(false, 52)]
        [InlineData(false, 54)]
        [InlineData(true, 55)]
        public void SpecialEleven(bool expected, int n)
        {
            Assert.Equal(expected, _logic1.SpecialEleven(n));
        }

        [Theory]
        [InlineData(false, 20)]
        [InlineData(true, 21)]
        [InlineData(true, 22)]
        [InlineData(false, 23)]
        [InlineData(false, 25)]
        [InlineData(false, 30)]
        [InlineData(false, 31)]
        [InlineData(false, 59)]
        [InlineData(false, 60)]
        [InlineData(true, 61)]
        [InlineData(true, 62)]
        [InlineData(false, 1020)]
        [InlineData(true, 1021)]
        [InlineData(false, 1000)]
        [InlineData(true, 1001)]
        [InlineData(false, 50)]
        [InlineData(false, 55)]
        [InlineData(false, 40)]
        [InlineData(true, 41)]
        [InlineData(false, 39)]
        [InlineData(true, 42)]


        public void More20(bool expected, int n)
        {
            Assert.Equal(expected, _logic1.More20(n));
        }

        [Theory]
        [InlineData(true, 3)]
        [InlineData(true, 10)]
        [InlineData(false, 15)]
        [InlineData(true, 5)]
        [InlineData(true, 9)]
        [InlineData(false, 8)]
        [InlineData(false, 7)]
        [InlineData(true, 6)]
        [InlineData(false, 17)]
        [InlineData(true, 18)]
        [InlineData(false, 29)]
        [InlineData(true, 20)]
        [InlineData(true, 21)]
        [InlineData(false, 22)]
        [InlineData(false, 45)]
        [InlineData(true, 99)]
        public void Old35(bool expected, int n)
        {
            Assert.Equal(expected, _logic1.Old35(n));
        }

        [Theory]
        [InlineData(true, 18)]
        [InlineData(true, 19)]
        [InlineData(false, 20)]
        [InlineData(false, 8)]
        [InlineData(false, 17)]
        [InlineData(false, 23)]
        [InlineData(false, 25)]
        [InlineData(false, 30)]
        [InlineData(true, 58)]
        [InlineData(true, 59)]
        [InlineData(false, 60)]
        [InlineData(false, 61)]
        [InlineData(false, 62)]
        [InlineData(false, 1017)]
        [InlineData(true, 1018)]
        [InlineData(true, 1019)]
        [InlineData(false, 1020)]
        [InlineData(false, 1021)]
        [InlineData(false, 1022)]
        [InlineData(false, 1023)]
        [InlineData(false, 37)]
        public void Less20(bool expected, int n)
        {
            Assert.Equal(expected, _logic1.Less20(n));
        }

        [Theory]
        [InlineData(true, 12)]
        [InlineData(false, 17)]
        [InlineData(true, 19)]
        [InlineData(true, 31)]
        [InlineData(false, 6)]
        [InlineData(true, 10)]
        [InlineData(true, 11)]
        [InlineData(true, 21)]
        [InlineData(true, 22)]
        [InlineData(false, 23)]
        [InlineData(false, 54)]
        [InlineData(false, 155)]
        [InlineData(true, 158)]
        [InlineData(false, 3)]
        [InlineData(true, 1)]
        public void NearTen(bool expected, int num)
        {
            Assert.Equal(expected, _logic1.NearTen(num));
        }

        [Theory]
        [InlineData(7, 3, 4)]
        [InlineData(19, 10, 13)]
        [InlineData(19, 13, 2)]
        [InlineData(19, 3, 19)]
        [InlineData(19, 13, 13)]
        [InlineData(20, 10, 10)]
        [InlineData(19, 6, 14)]
        [InlineData(19, 15, 2)]
        [InlineData(19, 19, 19)]
        [InlineData(19, 19, 20)]
        [InlineData(19, 2, 18)]
        [InlineData(16, 12, 4)]
        [InlineData(22, 2, 20)]
        [InlineData(19, 2, 17)]
        [InlineData(19, 2, 16)]
        [InlineData(13, 6, 7)]
        public void TeenSum(int expected, int a, int b)
        {
            Assert.Equal(expected, _logic1.TeenSum(a, b));
        }

        [Theory]
        [InlineData(true, false, false, false)]
        [InlineData(false, false, false, true)]
        [InlineData(false, true, false, false)]
        [InlineData(true, true, true, false)]
        [InlineData(true, false, true, false)]
        [InlineData(false, true, true, true)]
        public void AnswerCell(bool expected, bool isMorning, bool isMom, bool isAsleep)
        {
            Assert.Equal(expected, _logic1.AnswerCell(isMorning, isMom, isAsleep));
        }

        [Theory]
        [InlineData(1, 6, 8)]
        [InlineData(0, 3, 8)]
        [InlineData(2, 20, 6)]
        [InlineData(1, 11, 6)]
        [InlineData(0, 11, 4)]
        [InlineData(0, 4, 5)]
        [InlineData(1, 5, 5)]
        [InlineData(1, 6, 6)]
        [InlineData(2, 5, 10)]
        [InlineData(1, 5, 9)]
        [InlineData(0, 10, 4)]
        [InlineData(2, 10, 20)]
        public void TeaParty(int expected, int tea, int candy)
        {
            Assert.Equal(expected, _logic1.TeaParty(tea, candy));
        }

        [Theory]
        [InlineData("Fizz", "fig")]
        [InlineData("Buzz", "dib")]
        [InlineData("FizzBuzz", "fib")]
        [InlineData("abc", "abc")]
        [InlineData("Fizz", "fooo")]
        [InlineData("booo", "booo")]
        [InlineData("Buzz", "ooob")]
        [InlineData("FizzBuzz", "fooob")]
        [InlineData("Fizz", "f")]
        [InlineData("Buzz", "b")]
        [InlineData("Buzz", "abcb")]
        [InlineData("Hello", "Hello")]
        [InlineData("Buzz", "Hellob")]
        [InlineData("af", "af")]
        [InlineData("bf", "bf")]
        [InlineData("FizzBuzz", "fb")]
        public void FizzString(string expected, string str)
        {
            Assert.Equal(expected, _logic1.FizzString(str));
        }

        [Theory]
        [InlineData("1!", 1)]
        [InlineData("2!", 2)]
        [InlineData("Fizz!", 3)]
        [InlineData("4!", 4)]
        [InlineData("Buzz!", 5)]
        [InlineData("Fizz!", 6)]
        [InlineData("7!", 7)]
        [InlineData("8!", 8)]
        [InlineData("Fizz!", 9)]
        [InlineData("FizzBuzz!", 15)]
        [InlineData("16!", 16)]
        [InlineData("Fizz!", 18)]
        [InlineData("19!", 19)]
        [InlineData("Fizz!", 21)]
        [InlineData("44!", 44)]
        [InlineData("FizzBuzz!", 45)]
        [InlineData("Buzz!", 100)]
        public void FizzString2(string expected, int n)
        {
            Assert.Equal(expected, _logic1.FizzString2(n));
        }

        [Theory]
        [InlineData(true, 1, 2, 3)]
        [InlineData(true, 3, 2, 1)]
        [InlineData(false, 3, 2, 2)]
        [InlineData(true, 2, 3, 1)]
        [InlineData(true, 5, 3, -2)]
        [InlineData(false, 5, 3, -3)]
        [InlineData(true, 2, 5, 3)]
        [InlineData(false, 9, 5, 5)]
        [InlineData(true, 9, 4, 5)]
        [InlineData(true, 5, 4, 9)]
        [InlineData(true, 3, 3, 0)]
        [InlineData(false, 3, 3, 2)]
        public void TwoAsOne(bool expected, int a, int b, int c)
        {
            Assert.Equal(expected, _logic1.TwoAsOne(a, b, c));
        }

        [Theory]
        [InlineData(true, 1, 2, 4, false)]
        [InlineData(false, 1, 2, 1, false)]
        [InlineData(true, 1, 1, 2, true)]
        [InlineData(false, 3, 2, 4, false)]
        [InlineData(true, 2, 3, 4, false)]
        [InlineData(true, 3, 2, 4, true)]
        [InlineData(false, 4, 2, 2, true)]
        [InlineData(false, 4, 5, 2, true)]
        [InlineData(true, 2, 4, 6, true)]
        [InlineData(true, 7, 9, 10, false)]
        [InlineData(true, 7, 5, 6, true)]
        [InlineData(false, 7, 5, 4, true)]
        public void InOrder(bool expected, int a, int b, int c, bool bOk)
        {
            Assert.Equal(expected, _logic1.InOrder(a, b, c, bOk));
        }

        [Theory]
        [InlineData(true, 2, 5, 11, false)]
        [InlineData(false, 5, 7, 6, false)]
        [InlineData(true, 5, 5, 7, true)]
        [InlineData(false, 5, 5, 7, false)]
        [InlineData(false, 2, 5, 4, false)]
        [InlineData(false, 3, 4, 3, false)]
        [InlineData(false, 3, 4, 3, true)]
        [InlineData(true, 3, 4, 4, true)]
        [InlineData(true, 1, 5, 5, true)]
        [InlineData(true, 5, 5, 5, true)]
        [InlineData(false, 2, 2, 1, true)]
        [InlineData(false, 9, 2, 2, true)]
        [InlineData(false, 0, 1, 0, true)]
        public void InOrderEqual(bool expected, int a, int b, int c, bool bOk)
        {
            Assert.Equal(expected, _logic1.InOrderEqual(a, b, c, bOk));
        }

        [Theory]
        [InlineData(true, 23, 19, 13)]
        [InlineData(false, 23, 19, 12)]
        [InlineData(true, 23, 19, 3)]
        [InlineData(true, 23, 19, 39)]
        [InlineData(false, 1, 2, 3)]
        [InlineData(true, 1, 1, 2)]
        [InlineData(true, 1, 2, 2)]
        [InlineData(false, 14, 25, 43)]
        [InlineData(true, 14, 25, 45)]
        [InlineData(false, 248, 106, 1002)]
        [InlineData(true, 248, 106, 1008)]
        [InlineData(true, 10, 11, 20)]
        [InlineData(true, 0, 11, 0)]
        public void LastDigit(bool expected, int a, int b, int c)
        {
            Assert.Equal(expected, _logic1.LastDigit(a, b, c));
        }

        [Theory]
        [InlineData(true, 1, 7, 11)]
        [InlineData(false, 1, 7, 10)]
        [InlineData(true, 11, 1, 7)]
        [InlineData(false, 10, 7, 1)]
        [InlineData(true, -10, 2, 2)]
        [InlineData(false, 2, 11, 11)]
        [InlineData(true, 3, 3, 30)]
        [InlineData(false, 3, 3, 3)]
        [InlineData(true, 10, 1, 11)]
        [InlineData(true, 10, 11, 1)]
        [InlineData(false, 10, 11, 2)]
        [InlineData(true, 3, 30, 3)]
        [InlineData(true, 2, 2, -8)]
        [InlineData(true, 2, 8, 12)]
        public void LessBy10(bool expected, int a, int b, int c)
        {
            Assert.Equal(expected, _logic1.LessBy10(a, b, c));
        }

        [Theory]
        [InlineData(5, 2, 3, true)]
        [InlineData(7, 3, 3, true)]
        [InlineData(6, 3, 3, false)]
        [InlineData(5, 2, 3, false)]
        [InlineData(9, 5, 4, true)]
        [InlineData(9, 5, 4, false)]
        [InlineData(11, 5, 5, true)]
        [InlineData(10, 5, 5, false)]
        [InlineData(7, 6, 6, true)]
        [InlineData(12, 6, 6, false)]
        [InlineData(7, 1, 6, true)]
        [InlineData(7, 6, 1, false)]
        public void WithoutDoubles(int expected, int die1, int die2, bool noDoubles)
        {
            Assert.Equal(expected, _logic1.WithoutDoubles(die1, die2, noDoubles));
        }

        [Theory]
        [InlineData(3, 2, 3)]
        [InlineData(6, 6, 2)]
        [InlineData(3, 3, 2)]
        [InlineData(12, 8, 12)]
        [InlineData(7, 7, 12)]
        [InlineData(6, 11, 6)]
        [InlineData(2, 2, 7)]
        [InlineData(0, 7, 7)]
        [InlineData(9, 9, 1)]
        [InlineData(9, 9, 14)]
        [InlineData(2, 1, 2)]
        public void MaxMod5(int expected, int a, int b)
        {
            Assert.Equal(expected, _logic1.MaxMod5(a, b));
        }

        [Theory]
        [InlineData(10, 2, 2, 2)]
        [InlineData(0, 2, 2, 1)]
        [InlineData(5, 0, 0, 0)]
        [InlineData(1, 2, 0, 0)]
        [InlineData(5, 1, 1, 1)]
        [InlineData(0, 1, 2, 1)]
        [InlineData(1, 1, 2, 0)]
        [InlineData(1, 0, 2, 2)]
        [InlineData(1, 1, 2, 2)]
        [InlineData(0, 0, 2, 0)]
        [InlineData(0, 1, 1, 2)]
        public void RedTicket(int expected, int a, int b, int c)
        {
            Assert.Equal(expected, _logic1.RedTicket(a, b, c));
        }

        [Theory]
        [InlineData(0, 1, 2, 3)]
        [InlineData(20, 2, 2, 2)]
        [InlineData(10, 1, 1, 2)]
        [InlineData(10, 2, 1, 1)]
        [InlineData(10, 1, 2, 1)]
        [InlineData(0, 3, 2, 1)]
        [InlineData(20, 0, 0, 0)]
        [InlineData(10, 2, 0, 0)]
        [InlineData(0, 0, 9, 10)]
        [InlineData(10, 0, 10, 0)]
        [InlineData(20, 9, 9, 9)]
        [InlineData(10, 9, 0, 9)]
        public void GreenTicket(int expected, int a, int b, int c)
        {
            Assert.Equal(expected, _logic1.GreenTicket(a, b, c));
        }

        [Theory]
        [InlineData(10, 9, 1, 0)]
        [InlineData(0, 9, 2, 0)]
        [InlineData(10, 6, 1, 4)]
        [InlineData(0, 6, 1, 5)]
        [InlineData(10, 10, 0, 0)]
        [InlineData(5, 15, 0, 5)]
        [InlineData(10, 5, 15, 5)]
        [InlineData(5, 4, 11, 1)]
        [InlineData(5, 13, 2, 3)]
        [InlineData(0, 8, 4, 3)]
        [InlineData(10, 8, 4, 2)]
        [InlineData(0, 8, 4, 1)]
        public void BlueTicket(int expected, int a, int b, int c)
        {
            Assert.Equal(expected, _logic1.BlueTicket(a, b, c));
        }

        [Theory]
        [InlineData(true, 12, 23)]
        [InlineData(false, 12, 43)]
        [InlineData(false, 12, 44)]
        [InlineData(true, 23, 12)]
        [InlineData(true, 23, 39)]
        [InlineData(false, 23, 19)]
        [InlineData(true, 30, 90)]
        [InlineData(false, 30, 91)]
        [InlineData(true, 55, 55)]
        [InlineData(false, 55, 44)]
        public void ShareDigit(bool expected, int a, int b)
        {
            Assert.Equal(expected, _logic1.ShareDigit(a, b));
        }

        [Theory]
        [InlineData(5, 2, 3)]
        [InlineData(8, 8, 3)]
        [InlineData(9, 8, 1)]
        [InlineData(50, 11, 39)]
        [InlineData(11, 11, 99)]
        [InlineData(0, 0, 0)]
        [InlineData(99, 99, 0)]
        [InlineData(99, 99, 1)]
        [InlineData(124, 123, 1)]
        [InlineData(1, 1, 123)]
        [InlineData(83, 23, 60)]
        [InlineData(23, 23, 80)]
        [InlineData(9001, 9000, 1)]
        [InlineData(90000001, 90000000, 1)]
        [InlineData(9000, 9000, 1000)]
        public void SumLimit(int expected, int a, int b)
        {
            Assert.Equal(expected, _logic1.SumLimit(a, b));
        }
    }
}
