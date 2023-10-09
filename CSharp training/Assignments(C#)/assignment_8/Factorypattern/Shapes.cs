using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorypattern
{
    public interface IShapes
    {
        double GetValue();
        double GetArea();
        double GetPerimeter();
    }
}
