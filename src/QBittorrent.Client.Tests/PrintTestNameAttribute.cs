﻿using System;
using System.Reflection;
using Xunit.Sdk;

namespace QBittorrent.Client.Tests
{
    [AttributeUsage(AttributeTargets.Method)]
    public class PrintTestNameAttribute : BeforeAfterTestAttribute
    {
        public override void After(MethodInfo methodUnderTest)
        {
            Console.WriteLine("\tRunning test {0}.{1}...", methodUnderTest.DeclaringType.Name, methodUnderTest.Name);
            base.After(methodUnderTest);
        }
    }
}
