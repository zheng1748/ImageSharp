﻿// Copyright (c) Six Labors and contributors.
// Licensed under the GNU Affero General Public License, Version 3.

namespace SixLabors.ImageSharp.Metadata.Profiles.Icc
{
    /// <summary>
    /// Measurement Geometry
    /// </summary>
    internal enum IccMeasurementGeometry : uint
    {
        /// <summary>
        /// Unknown geometry
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// Geometry of 0°:45° or 45°:0°
        /// </summary>
        Degree0To45Or45To0 = 1,

        /// <summary>
        /// Geometry of 0°:d or d:0°
        /// </summary>
        Degree0ToDOrDTo0 = 2,
    }
}
