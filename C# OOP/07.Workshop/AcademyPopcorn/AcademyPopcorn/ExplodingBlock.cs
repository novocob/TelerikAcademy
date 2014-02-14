using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    // Homework - Task 10
    class ExplodingBlock : Block
    {
        public ExplodingBlock(MatrixCoords topLeft)
            : base(topLeft)
        {
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<GameObject> produceObjects = new List<GameObject>();
            if (this.IsDestroyed == true)
            {
                produceObjects.Add(new ExplossionItems(topLeft, new MatrixCoords(1, 0)));
                produceObjects.Add(new ExplossionItems(topLeft, new MatrixCoords(1, 1)));
                produceObjects.Add(new ExplossionItems(topLeft, new MatrixCoords(-1, 1)));
                produceObjects.Add(new ExplossionItems(topLeft, new MatrixCoords(1, -1)));
                produceObjects.Add(new ExplossionItems(topLeft, new MatrixCoords(0, 1)));
                produceObjects.Add(new ExplossionItems(topLeft, new MatrixCoords(-1, 0)));
                produceObjects.Add(new ExplossionItems(topLeft, new MatrixCoords(-1, -1)));
                produceObjects.Add(new ExplossionItems(topLeft, new MatrixCoords(0, -1)));
               
            }
            return produceObjects;
        } 
    }
}
