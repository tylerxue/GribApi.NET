﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grib.Api.Tests
{
    [TestFixture]
    public class Write
    {
        [Test]
        public void TestWrite()
        {
            if (File.Exists(Settings.OUT_GRIB))
            {
                File.Delete(Settings.OUT_GRIB);
            }

            int count = 0;

            using (var readFile = new GribFile(Settings.PACIFIC_WIND))
            {
                var msg = readFile.First();
                Assert.AreNotEqual(33, msg["latitudeOfFirstGridPoint"].AsDouble());
                msg["latitudeOfFirstGridPoint"].AsDouble(33);
                GribFile.Write(Settings.OUT_GRIB, msg);
            }

            using (var readFile = new GribFile(Settings.OUT_GRIB))
            {
                count = readFile.MessageCount;
                Assert.AreEqual(count, readFile.MessageCount);
                Assert.AreEqual(33, readFile.First()["latitudeOfFirstGridPoint"].AsDouble());
            }

            using (var readFile = new GribFile(Settings.GRIB))
            {
                GribFile.Write(Settings.OUT_GRIB, readFile as IEnumerable<GribMessage>, FileMode.Append);
                count += readFile.MessageCount;
            }

            using (var readFile = new GribFile(Settings.OUT_GRIB))
            {
                Assert.AreEqual(count, readFile.MessageCount);
                Assert.AreEqual(33, readFile.First()["latitudeOfFirstGridPoint"].AsDouble());
            }

        }
    }
}
