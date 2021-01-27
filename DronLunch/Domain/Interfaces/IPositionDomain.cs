using DronLunch.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DronLunch.Domain.Interfaces
{
    public interface IPositionDomain
    {
        void MoveForward(Position position);
        void TurnLeft(Position position);
        void TurnRight(Position position);
    }
}
