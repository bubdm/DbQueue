﻿using DbQueue;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.Common;

namespace Test.Mongo
{
    [TestClass()]
    public class QueueTests : Tests
    {
        public QueueTests() : base(App.Instance.Value.Services.GetService<IDbQueue>() as Dbq)
        {
        }
    }
}