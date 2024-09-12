using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public static class IdGenerator
    {
        private static int _currentId = 0;

        public static int GetNextId()
        {
            return _currentId++;
        }
    }
}
