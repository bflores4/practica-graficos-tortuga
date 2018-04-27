using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace práctica_gráficos_de_tortuga
{
    class Tortuga
    {
        private bool _estadoLapiz; //lapiz arriba = false, abajo = true
        private int _enColumna;
        private int _enRenglon;
        private int _orientacion;

        public bool estadoLapiz { get { return _estadoLapiz; } }
        public int enColumna { get { return _enColumna; } }
        public int enRenglon { get { return _enRenglon; } }
        public int orientacion { get { return _orientacion; } } //0,1,2,3

        public Tortuga()
        {
            _enColumna = 0;
            _enRenglon = 0;
            _estadoLapiz = false;
            _orientacion = 1;
        }

        public bool cambiarEstadoLapiz()
        {
            return _estadoLapiz = !_estadoLapiz;
        }

        public int girarDerecha()
        {
            if (_orientacion == 3)
                return _orientacion = 0;
            else
                return _orientacion++;
        }

        public int girarIzquierda()
        {
            if (_orientacion == 0)
                return _orientacion = 3;
            else
                return _orientacion--;
        } 

        private bool avanzarCasilla()
        {
            bool posibleAvanzar;

            if (_enRenglon == 0 && _orientacion == 0 ||
                _enColumna == 0 && _orientacion == 3 ||
                _enRenglon == 19 && _orientacion == 2 ||
                _enColumna == 19 && _orientacion == 1 )
                posibleAvanzar = false;
            else

            switch (_orientacion)
            {
                case 0: _enRenglon++;
                    break;
                case 1: _enColumna
                    break;
                case 2:
                    break;
                default:
                    break;
            }

            return posibleAvanzar;
        }

        public void avanzarVariasCasillas(int numCasillas)
        {
            
        } 
    }
}
