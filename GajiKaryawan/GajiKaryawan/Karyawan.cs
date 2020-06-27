using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace GajiKaryawan
{
    public abstract class Karyawan
    {
        public string nik { get; set; }
        public string nama { get; set; }
        public abstract double Gaji{ get; }
    }
}
