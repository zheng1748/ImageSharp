﻿// Copyright (c) Six Labors and contributors.
// Licensed under the GNU Affero General Public License, Version 3.

using SixLabors.ImageSharp.Processing;
using SixLabors.ImageSharp.Processing.Processors.Filters;
using Xunit;

namespace SixLabors.ImageSharp.Tests.Processing.Effects
{
    public class BrightnessTest : BaseImageOperationsExtensionTest
    {
        [Fact]
        public void Brightness_amount_BrightnessProcessorDefaultsSet()
        {
            this.operations.Brightness(1.5F);
            BrightnessProcessor processor = this.Verify<BrightnessProcessor>();

            Assert.Equal(1.5F, processor.Amount);
        }

        [Fact]
        public void Brightness_amount_rect_BrightnessProcessorDefaultsSet()
        {
            this.operations.Brightness(1.5F, this.rect);
            BrightnessProcessor processor = this.Verify<BrightnessProcessor>(this.rect);

            Assert.Equal(1.5F, processor.Amount);
        }
    }
}