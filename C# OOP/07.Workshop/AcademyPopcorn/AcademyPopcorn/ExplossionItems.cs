using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    // Homework - task 10
    // ExpolossionItems are produced when the ball hits ExplodingBlock;
    class ExplossionItems : Ball
    {
        public ExplossionItems(MatrixCoords topLeft, MatrixCoords speed)
            : base(topLeft, speed)
        { 
        }

        public override void Update()
        {
            this.IsDestroyed = true;
            this.UpdatePosition();
        }
    }
}
