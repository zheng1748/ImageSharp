// Copyright (c) Six Labors and contributors.
// Licensed under the GNU Affero General Public License, Version 3.

using System.Globalization;

namespace SixLabors.ImageSharp.Metadata.Profiles.Exif
{
    internal sealed class ExifSignedLong : ExifValue<int>
    {
        public ExifSignedLong(ExifTagValue tag)
            : base(tag)
        {
        }

        private ExifSignedLong(ExifSignedLong value)
            : base(value)
        {
        }

        public override ExifDataType DataType => ExifDataType.SignedLong;

        protected override string StringValue => this.Value.ToString(CultureInfo.InvariantCulture);

        public override IExifValue DeepClone() => new ExifSignedLong(this);
    }
}
