﻿namespace Homework.DefiningClasses_Part2
{
    using System;
    using System.Collections.Generic;

    public class Path
    {
        private List<Point3D> sequence = new List<Point3D>();

        public List<Point3D> Sequence
        {
            get
            {
                return this.sequence;
            }

            set
            {
                this.sequence = value;
            }
        }
    }
}