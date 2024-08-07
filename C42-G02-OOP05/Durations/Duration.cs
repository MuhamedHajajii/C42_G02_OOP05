using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_OOP05.Durations
{
    internal class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Duration()
        {
            
        }

        public Duration(int hours, int minutes, int seconds)
        {
            this.Hours = hours;
            this.Minutes = minutes;
            this.Seconds = seconds;
            NormalizeTime();
        }

        public Duration(int totalSeconds)
        {
            this.Hours = totalSeconds / 3600;
            totalSeconds %= 3600;
            this.Minutes = totalSeconds / 60;
            this.Seconds = totalSeconds % 60;

        }
        private void NormalizeTime()
        {
            if (Seconds >= 60)
            {
                Minutes += Seconds / 60;
                Seconds %= 60;
            }

            if (Minutes >= 60)
            {
                Hours += Minutes / 60;
                Minutes %= 60;
            }
        }
        public override string ToString()
        {
            return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
        }

        public override bool Equals(object? obj)
        {
            return this == obj;
        }

        public override int GetHashCode()
        {
            return Hours+Minutes+Seconds;
        }

        #region overloading operators

        public static Duration operator +(Duration Left, Duration Right)
        {
            return new Duration()
            {
                Hours = Left.Hours + Right.Hours,
                Minutes = Left.Minutes + Right.Minutes,
                Seconds = Left.Seconds + Right.Seconds
            };
        }
        public static Duration operator +(Duration time, int totalSeconds)
        {
            Duration D = new Duration(totalSeconds);
            return new Duration()
            {
                Hours = time.Hours + D.Hours,
                Minutes = time.Minutes + D.Minutes,
                Seconds = time.Seconds + D.Seconds
            };
        }

        public static Duration operator +(int totalSeconds, Duration time)
        {
            Duration D = new Duration(totalSeconds);
            return new Duration()
            {
                Hours = time.Hours + D.Hours,
                Minutes = time.Minutes + D.Minutes,
                Seconds = time.Seconds + D.Seconds
            };
        }
        public static Duration operator ++(Duration time)
        {
            return new Duration()
            {
                Hours = time.Hours ,
                Minutes = time.Minutes +1,
                Seconds = time.Seconds
            };
        }

        public static Duration operator --(Duration time)
        {
            return new Duration()
            {
                Hours = time.Hours,
                Minutes = time.Minutes - 1,
                Seconds = time.Seconds
            };
        }

        public static Duration operator -(Duration Left, Duration Right)
        {
            return new Duration()
            {
                Hours = Left.Hours - Right.Hours,
                Minutes = Left.Minutes - Right.Minutes,
                Seconds = Left.Seconds - Right.Seconds
            };
        }

        public static bool operator >(Duration Left, Duration Right)
        {
            if(Left.Hours == Right.Hours)
            {
                if(Left.Minutes == Right.Minutes)
                    return Left.Seconds > Right.Seconds;
                 else
                    return Left.Minutes == Right.Minutes;
            }    else
                return Left.Hours > Right.Hours;

        }
        public static bool operator <(Duration Left, Duration Right)
        {
            if (Left.Hours == Right.Hours)
            {
                if (Left.Minutes == Right.Minutes)
                   return Left.Seconds < Right.Seconds;
                else
                    return Left.Minutes < Right.Minutes;
            }
            else
                return Left.Hours < Right.Hours;

        }

        public static bool operator <=(Duration Left, Duration Right)
        {
            if (Left.Hours == Right.Hours)
            {
                if (Left.Minutes == Right.Minutes)
                    return Left.Seconds < Right.Seconds;
                else
                    return Left.Minutes < Right.Minutes;
            }
            else
                return Left.Hours < Right.Hours;

        }
        public static bool operator >=(Duration Left, Duration Right)
        {
            if (Left.Hours == Right.Hours)
            {
                if (Left.Minutes == Right.Minutes)
                    return Left.Seconds < Right.Seconds;
                else
                    return Left.Minutes < Right.Minutes;
            }
            else
                return Left.Hours < Right.Hours;

        }

        public static bool operator true(Duration d)
        {
            if (d.Hours is not 0)
                return d.Hours > 0;
            else if (d.Minutes is not 0)
                return d.Minutes > 0;
            else if (d.Seconds is not 0)
                return d.Seconds > 0;
            else return false;
        }

        public static bool operator false(Duration d)
        {
            if (d.Hours is 0)
                return d.Hours == 0;
            else if (d.Minutes is 0)
                return d.Minutes == 0;
            else if (d.Seconds is 0)
                return d.Seconds == 0;
            else return true;
        }

        public static explicit operator DateTime(Duration d)
        {
            return new DateTime(1, 1, 1, d.Hours, d.Minutes, d.Seconds);
        }
        #endregion

    }
}
