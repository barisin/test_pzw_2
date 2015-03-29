using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_pzw2
{
    public class Date
    {
        public int day, month, year;

        public Date()
        {
            day = 0;
            month = 0;
            year = 0;
        }

        public Date(int d, int m, int y)
        {
            day = d;
            month = m;
            year = y;
        }

        public string getMonthName()
        {
            string name;
            switch(month)
            {
                case 1:
                    {
                        name = "Siječanj";
                        break;
                    }
                case 2:
                    {
                        name = "Valjača";
                        break;
                    }
                case 3:
                    {
                        name = "Ožujak";
                        break;
                    }
                case 4:
                    {
                        name = "Travanj";
                        break;
                    }
                case 5:
                    {
                        name = "Svibanj";
                        break;
                    }
                case 6:
                    {
                        name = "Lipanj";
                        break;
                    }
                case 7:
                    {
                        name = "Srpanj";
                        break;
                    }
                case 8:
                    {
                        name = "Kolokvoz";
                        break;
                    }
                case 9:
                    {
                        name = "Rujan";
                        break;
                    }
                case 10:
                    {
                        name = "Listopad";
                        break;
                    }
                case 11:
                    {
                        name = "Studeni";
                        break;
                    }
                case 12:
                    {
                        name = "Prosinac";
                        break;
                    }
                default:
                    {
                        name = "";
                        break;
                    }
            }

            return name;
        }

        public bool isLeapYear()
        {
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                return true;
            else
                return false;
        }

        public int getNumberOfRemaingDaysInMonth()
        {
            int broj;
            switch(month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    {
                        broj = 31 - day;
                        break;
                    }
                case 4:
                case 6:
                case 9:
                case 11:
                    {
                        broj = 30 - day;
                        break;
                    }
                case 2:
                    {
                        if (isLeapYear())
                            broj = 28 - day;
                        else
                            broj = 29 - day;
                        break;
                    }
                default:
                    {
                        broj = -1;
                        break;
                    }
            }

            return broj;
        }
    }
}
