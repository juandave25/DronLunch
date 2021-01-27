using DronLunch.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DronLunch.Domain.Interfaces
{
    public interface IPositionDomain
    {
        Position MoveForward(Position position);
        Position TurnLeft(Position position);
        Position TurnRight(Position position);
    }
}
