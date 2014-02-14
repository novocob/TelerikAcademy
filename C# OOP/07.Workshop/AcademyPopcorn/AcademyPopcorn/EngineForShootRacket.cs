using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    //class that inherits Engine - Homework Task 04
    class EngineForShootRacket : Engine
    {
        public EngineForShootRacket(IRenderer renderer, IUserInterface userInterface, int sleepTime)
            : base(renderer, userInterface, sleepTime)
        {
        }

        //method ShootPlayerRacket() - Homework Task 04
        public void ShootPlayerRacket() 
        {
        }
    }
}
