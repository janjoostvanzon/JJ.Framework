﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JJ.Framework.Configuration.Tests
{
    [TestClass]
    public class AppSettingsTest
    {
        [TestMethod]
        public void Test_AppSettings()
        {
            int value = AppSettingsReader<IMySettings>.Get(x => x.MySetting);
        }
    }
}
