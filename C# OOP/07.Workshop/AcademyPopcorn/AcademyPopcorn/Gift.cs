﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    //class Gift - Homework Task 11
    class Gift : MovingObject
    {
        public new const string CollisionGroupString = "gift";

        public Gift(MatrixCoords topLeft)
            : base(topLeft, new char[,] { { '$' } }, new MatrixCoords(1,0))
        {
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "racket" ;
        }

        public override string GetCollisionGroupString()
        {
            return Gift.CollisionGroupString;
        }
    }
}
