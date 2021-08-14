using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRoverProject.Interfaces;

namespace MarsRoverProject.Business
{
    public class Field : IField
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

        public Field(int _fieldLimitX, int _fieldLimitY)
        {
            FieldLimitX = _fieldLimitX;
            FieldLimitY = _fieldLimitY;
        }

        /// <summary>
        /// Taking Rover
        /// Check Rover is outside of field
        /// </summary>
        /// <param name="Rover"></param>
        public void CheckFieldLimits(IRover Rover)
        {
            var roverX = Rover.LocationX;
            var roverY = Rover.LocationY;

            //Check Rover is outside of X plane
            if (roverX > fieldLimitX)
            {
                roverX = fieldLimitX;
            }
            else if (roverX < 0)
            {
                roverX = 0;
            }

            //Check Rover is outside of Y plane
            if (roverY > fieldLimitY)
            {
                roverY = fieldLimitY;
            }
            else if (roverY < 0)
            {
                roverY = 0;
            }
        }
    }
}
