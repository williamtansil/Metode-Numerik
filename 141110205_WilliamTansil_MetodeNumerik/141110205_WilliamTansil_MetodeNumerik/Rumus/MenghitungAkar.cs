using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _141110205_WilliamTansil_MetodeNumerik.Rumus
{
    class MenghitungAkar
    {
        public struct Row 
        {
            public float Iterasi, S, T, Error;
        }
        private float N, S, T, Error, Tracehold;
        public MenghitungAkar() 
        {
            //continue
        }
        public MenghitungAkar(float _N, float _S, float _T, float _Tracehold) 
        {
            N = _N; S = _S; T = _T; Tracehold = _Tracehold; Error = T - S;
        }
        public List<Row> GetHasil() 
        {
            int _i = 0;
            List<Row> _hasil = new List<Row>();
            Row _baris = new Row();

            do {
                Error = Math.Abs(T - S);
                _baris.Iterasi = _i + 1;
                _baris.S = S;
                _baris.T = T;
                _baris.Error = Error;
                _i++;
                _hasil.Add(_baris);
                S = (S + T) / 2;
                T = N / S;
            } while (Error >= Tracehold);

            return _hasil;
        }
    }
}
