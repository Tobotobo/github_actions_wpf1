using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    public interface ICalcService
    {
        int Sum(int a, int b);
        int Product(int a, int b);
    }
}
