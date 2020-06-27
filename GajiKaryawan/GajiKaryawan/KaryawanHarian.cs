using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GajiKaryawan
{
    class KaryawanHarian : Karyawan
    {
        public double upahperjam { get; set; }
        public double jumlahjamkerja { get; set; }
        public override double Gaji { get { return upahperjam*jumlahjamkerja; } }
    }
}
