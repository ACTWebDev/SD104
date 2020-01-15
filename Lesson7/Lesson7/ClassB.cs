using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7
{
    class ClassB
    {
        

        public void SeemsHarmless()
        {
            ClassA classAObject = Program.classAObject;
            classAObject.state = 100;
        }

    }
}
