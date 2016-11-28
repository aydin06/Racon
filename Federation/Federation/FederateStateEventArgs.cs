﻿/*
RACoN - RTI abstraction component for MS.NET (RACoN)
https://sites.google.com/site/okantopcu/racon

Copyright © Okan Topçu, 2009-2016
otot.support@outlook.com

This program is free software : you can redistribute it and / or modify
it under the terms of the GNU Lesser General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
GNU Lesser General Public License for more details.

You should have received a copy of the GNU Lesser General Public License
along with this program.If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Racon.Federation
{
  /// <summary>
  /// Encapsulates event arguments for Federate State changed event.
  /// </summary>
  /// <remarks>This class inherits the EventArgs class. It is used in delegates (function pointers) and event handlers (event handling methods).
  /// </remarks>
  /// 
  public class CFederateStateEventArgs : EventArgs
	{
    /// <summary>
    /// Federate State
    /// </summary>
    public FederateStates FdState;
    /// <summary>
    /// CFederateStateEventArgs constructor
    /// </summary>
    /// <param name="state">Federate State</param>
    /// 
    public CFederateStateEventArgs(FederateStates state)
		{
			this.FdState = state;
		}
	};
}
