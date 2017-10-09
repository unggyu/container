// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.


using Microsoft.Practices.Unity;
using Unity.Attributes;

namespace Unity.Tests.Override
{
    public class MySimpleType
    {
        [Dependency]
        public int X { get; set; }
    }
}