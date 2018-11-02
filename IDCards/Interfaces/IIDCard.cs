using System;
using System.Collections.Generic;
using System.Text;

namespace IDCards.Interfaces
{
    interface IIDCard
    {
        string CardTitle { get; set; }
        string Name { get; set; }
        string DOB { get; set; }
        string Position { get; set; }
    }
}
