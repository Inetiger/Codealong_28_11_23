using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codealong_28_11_23
{
    internal class Hest
    {
        private int _speed;
        private string _runNuber;

        public Hest(int speed, string runNuber)
        {
            _speed = speed;
            _runNuber = runNuber;
        }

        public int Speed()
        {
            return _speed;
        }
    }
}
