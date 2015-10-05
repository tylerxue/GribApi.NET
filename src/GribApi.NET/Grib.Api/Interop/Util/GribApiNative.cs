﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Grib.Api.Interop.Util
{
    internal static class GribApiNative
    {
        [DllImport("Grib.Api.Native.dll", CharSet = CharSet.Ansi)]
        internal static extern void GetGribKeysIteratorName (StringBuilder name, IntPtr iter);
    }
}