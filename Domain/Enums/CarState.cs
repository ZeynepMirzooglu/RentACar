using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enums;

public enum CarState
{
    //Kiralamaya Uygun
    Available = 1,
    //Araba kirada
    Rented = 2,
    //Araba bakımda
    Maintenance = 3

}
