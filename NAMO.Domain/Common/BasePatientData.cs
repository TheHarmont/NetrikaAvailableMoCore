using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAMO.Domain.Common
{
    public abstract class BasePatientData
    {
        //Никто не парился на счет защиты подобных данных, ну и я не стал
        public string CodeFoms { get; } = "";
        public string UsName { get; } = "";
        public string Pass { get; } = "";
        public bool IPRA { get; } = ;
        public int MIS { get; } = ;
    }
}
