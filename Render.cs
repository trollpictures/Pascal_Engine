using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDX.Windows;

namespace Render
{
    public class RenderCore
    {
        RenderForm window;
        public RenderCore()
        {
            window = new RenderForm("PascalRender");
        }

        public void Run()
        {
            RenderLoop.Run(window, RenderCallback);
        }

        public void RenderCallback()
        {

        }
    }
}
