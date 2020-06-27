using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GajiKaryawan
{
    class Sales : Karyawan
    {
        public double jumlahpenjualan { get; set; }
        public double komisi { get; set; }

        public override double Gaji { get { return jumlahpenjualan*komisi; } }
    }
}
