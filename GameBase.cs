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
using InternalVars;

namespace Pascal_Engine
{
    class GameBase
    {
        static void Main(string[] args)
        {
            PhysicsCore Phys = new PhysicsCore();
            Time t = new Time();
            RenderCore Game = new RenderCore();
            Game.Run();
            t.time();
        }
    }
}
