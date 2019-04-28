﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unity;

namespace Registration
{
    [TestClass]
    public class AsyncType : Unity.Specification.Async.Registration.Types.SpecificationTests
    {
        public override IUnityContainerAsync GetContainer()
        {
            return new UnityContainer();
        }
    }

    [TestClass]
    public class AsyncFactory : Unity.Specification.Async.Registration.Factory.SpecificationTests
    {
        public override IUnityContainerAsync GetContainer()
        {
            return new UnityContainer();
        }
    }

    [TestClass]
    public class AsyncInstance : Unity.Specification.Async.Registration.Instance.SpecificationTests
    {
        public override IUnityContainerAsync GetContainer()
        {
            return new UnityContainer();
        }
    }
}
