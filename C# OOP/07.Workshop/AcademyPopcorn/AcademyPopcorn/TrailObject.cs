using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    //class TrailObject - Homework Task 05
    class TrailObject : GameObject
    {
        public int LifeTime { get; set; }
        
        public TrailObject(MatrixCoords topLeft, char[,] body, int lifeTime) : base(topLeft, body)
        {
            this.LifeTime = lifeTime;
        }

        public override void Update()
        {
            this.LifeTime--;
            if (this.LifeTime <= 0)
            {
                this.IsDestroyed = true;
            }
        }
    }
}
