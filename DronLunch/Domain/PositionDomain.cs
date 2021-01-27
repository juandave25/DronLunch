using System;
using System.Collections.Generic;
using System.Text;
using DronLunch.Model;
using DronLunch.Domain.Interfaces;

namespace DronLunch.Domain
{
    public class PositionDomain : IPositionDomain
    {
        public void MoveForward(Position position)
        {
            switch (position.Direction)
            {
                case "NORTH":
                    position.Yposition++;
                    break;
                case "SOUTH":
                    position.Yposition--;
                    break;
                case "EAST":
                    position.Xposition++;
                    break;
                case "WEST":
                    position.Xposition--;
                    break;
            }
        }

        public void TurnLeft(Position position)
        {
            switch (position.Direction)
            {
                case "NORTH":
                    position.Direction= "WEST";
                    break;
                case "SOUTH":
                    position.Direction = "EAST";
                    break;
                case "WEST":
                    position.Direction = "NORTH";
                    break;
                case "EAST":
                    position.Direction = "SOUTH";
                    break;
            }
        }

        public void TurnRight(Position position)
        {
            switch (position.Direction)
            {
                case "NORTH":
                    position.Direction = "EAST";
                    break;
                case "SOUTH":
                    position.Direction = "WEST";
                    break;
                case "WEST":
                    position.Direction = "SOUTH";
                    break;
                case "EAST":
                    position.Direction = "NORTH";
                    break;
            }
        }

    }
}
