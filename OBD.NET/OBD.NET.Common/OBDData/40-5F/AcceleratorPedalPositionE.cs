﻿using OBD.NET.Common.DataTypes;

namespace OBD.NET.Common.OBDData
{
    public class AcceleratorPedalPositionE : AbstractOBDData
    {
        #region Properties & Fields

        public Percent Position => new Percent(A / 2.55, 0, 100);

        #endregion

        #region Constructors

        public AcceleratorPedalPositionE()
            : base(0x4A, 1)
        { }

        #endregion
    }
}