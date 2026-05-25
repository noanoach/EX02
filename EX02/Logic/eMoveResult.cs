using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX02.Logic
{
    internal enum eMoveResult
    {
        Success,
        OutOfRange,
        CellTaken,
        InvalidFormat,
        Quit
    }
}