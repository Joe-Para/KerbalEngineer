﻿// 
//     Kerbal Engineer Redux
// 
//     Copyright (C) 2014 CYBUTEK
// 
//     This program is free software: you can redistribute it and/or modify
//     it under the terms of the GNU General Public License as published by
//     the Free Software Foundation, either version 3 of the License, or
//     (at your option) any later version.
// 
//     This program is distributed in the hope that it will be useful,
//     but WITHOUT ANY WARRANTY; without even the implied warranty of
//     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//     GNU General Public License for more details.
// 
//     You should have received a copy of the GNU General Public License
//     along with this program.  If not, see <http://www.gnu.org/licenses/>.
// 

#region Using Directives

using KerbalEngineer.Helpers;

#endregion

namespace KerbalEngineer.Flight.Readouts.Orbital
{
    public class SemiMajorAxis : ReadoutModule
    {
        #region Constructors

        public SemiMajorAxis()
        {
            this.Name = "Semi-major Axis";
            this.Category = ReadoutCategory.GetCategory("Orbital");
            this.HelpString = "Shows the distance from the centre of an orbit to the farthest edge.";
            this.IsDefault = true;
        }

        #endregion

        #region Methods: public

        public override void Draw()
        {
            this.DrawLine(Units.ToDistance(FlightGlobals.ship_orbit.semiMajorAxis, 3));
        }

        #endregion
    }
}