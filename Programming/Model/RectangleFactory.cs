using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class RectangleFactory
    {
        private static Random random = new Random();

        public static Rectangle Randomize()
        {
            int x = random.Next(0, 615); // Максимальная ширина CanvasPanel1
            int y = random.Next(0, 395); // Максимальная высота CanvasPanel1
            int width = random.Next(1, 100);
            int length = random.Next(1, 100);
            return new Rectangle(x, y, width, length);
        }
    }
}
