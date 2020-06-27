using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GajiKaryawan
{
    class KaryawanTetap : Karyawan
    {
        public double gajibulanan { get; set; }
        public override double Gaji { get{ return gajibulanan; } }
        
        
    }
}
