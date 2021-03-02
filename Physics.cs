using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mesh;
using InternalVars;

namespace Physics
{
    public class PhysicsCore
    {
        float3 GlobalSpace;
        float3 LocalSpace;
        void StaticObj()
        {
            
        }
        void DynamicObj() 
        {
            
        }
    }
    public class Time
    {
        public float time() 
        {
            float ret = 0.00f;
            for (; ; ret += 0.01f)
            {
                return ret;
                Console.WriteLine(ret);
            }
        }
        
    }
}
