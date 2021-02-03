using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDX.Windows;
using Render;
using Sound;
using Mesh;
using Physics;

namespace Pascal_Engine
{
    class GameBase
    {
        static void Main(string[] args)
        {
            RenderCore Game = new RenderCore();
            Game.Run();
        }
    }
}
