using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRoverProject.Interfaces;

namespace MarsRoverProject.Business
{
    class Field : IField
    {
        public int FieldLimitX
        {
            get
            {
                return fieldLimitX;
            }
            set
            {
                fieldLimitX = value;
            }
        }

        public int FieldLimitY
        {
            get
            {
                return fieldLimitY;
            }
            set
            {
                fieldLimitY = value;
            }
        }

        private int fieldLimitX;
        private int fieldLimitY;

        public void CheckFieldLimits(IRover Rover)
        {
            var roverX = Rover.LocationX;
            var roverY = Rover.LocationY;

            if (roverX > fieldLimitX)
            {
                roverX = fieldLimitX;
            }
            if (roverY > fieldLimitY)
            {
                roverY = fieldLimitY;
            }
        }
    }
}
