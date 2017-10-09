﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unity.Attributes;

namespace Microsoft.Practices.Unity.Tests.TestObjects
{
    public class ObjectWithStaticAndInstanceProperties
    {
        [Dependency]
        public static object StaticProperty { get; set; }

        [Dependency]
        public object InstanceProperty { get; set; }

        public void Validate()
        {
            Assert.IsNull(StaticProperty);
            Assert.IsNotNull(this.InstanceProperty);
        }
    }
}
