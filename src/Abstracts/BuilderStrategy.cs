﻿using System;
using Unity.Builder;
using Unity.Injection;
using Unity.Registration;
using Unity.Resolution;

namespace Unity.Strategies
{
    /// <summary>
    /// Represents a strategy in the chain of responsibility.
    /// Strategies are required to support both BuildUp and TearDown.
    /// </summary>
    public abstract class BuilderStrategy
    {
        #region Composition

        public virtual ResolveDelegate<BuilderContext>? BuildResolver(UnityContainer container, Type type, ImplicitRegistration registration, ResolveDelegate<BuilderContext>? seed) => seed;

        #endregion


        #region Build

        /// <summary>
        /// Called during the chain of responsibility for a build operation. The
        /// PreBuildUp method is called when the chain is being executed in the
        /// forward direction.
        /// </summary>
        /// <param name="context">Context of the build operation.</param>
        /// <returns>Returns intermediate value or policy</returns>
        public virtual void PreBuildUp(ref BuilderContext context)
        {
        }

        /// <summary>
        /// Called during the chain of responsibility for a build operation. The
        /// PostBuildUp method is called when the chain has finished the PreBuildUp
        /// phase and executes in reverse order from the PreBuildUp calls.
        /// </summary>
        /// <param name="context">Context of the build operation.</param>
        public virtual void PostBuildUp(ref BuilderContext context)
        {
        }

        #endregion


        #region Registration and Analysis

        /// <summary>
        /// Analyze registered type
        /// </summary>
        /// <param name="container">Reference to hosting container</param>
        /// <param name="type"></param>
        /// <param name="registration">Reference to registration</param>
        /// <param name="injectionMembers"></param>
        /// <returns>Returns true if this strategy will participate in building of registered type</returns>
        public virtual bool RequiredToBuildType(IUnityContainer container, Type type, ImplicitRegistration registration, params InjectionMember[]? injectionMembers)
        {
            return true;
        }

        /// <summary>
        /// Analyzes registered type
        /// </summary>
        /// <param name="container">Reference to hosting container</param>
        /// <param name="registration">Reference to registration</param>
        /// <returns>Returns true if this strategy will participate in building of registered type</returns>
        public virtual bool RequiredToResolveInstance(IUnityContainer container, ImplicitRegistration registration)
        {
            return false;
        }

        #endregion
    }
}