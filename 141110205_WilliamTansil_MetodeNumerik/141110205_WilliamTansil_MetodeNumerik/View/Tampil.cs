using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _141110205_WilliamTansil_MetodeNumerik.Rumus;
using System.Windows.Forms;

namespace _141110205_WilliamTansil_MetodeNumerik.View
{
    class Tampil
    {
        private float N, S, T, Error, Tracehold;
        public Tampil() 
        {
        
        }
        public Tampil(float _N, float _S, float _T, float _Error, float _Tracehold) 
        {
            
            N = _N; S = _S; T = _T; Error = _Error; Tracehold = _Tracehold;
            //continue
        }
        public void Cetak()
        {
            MessageBox.Show("test");
        }
    }
}
