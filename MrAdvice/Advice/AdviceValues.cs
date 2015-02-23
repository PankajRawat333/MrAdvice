﻿#region Mr. Advice
// Mr. Advice
// A simple post build weaving package
// http://mradvice.arxone.com/
// Released under MIT license http://opensource.org/licenses/mit-license.php
#endregion
namespace ArxOne.MrAdvice.Advice
{
    using System;

    /// <summary>
    /// Parameters shared through all advices sharing a pointcut
    /// They are target object, parameters (in/ref/out) and return value
    /// </summary>
    internal class AdviceValues
    {
        /// <summary>
        /// Gets or sets the target (to which advices are applied).
        /// </summary>
        /// <value>
        /// The target object.
        /// </value>
        public object Target { get; set; }
        /// <summary>
        /// Gets or sets the type of the target.
        /// </summary>
        /// <value>
        /// The type of the target.
        /// </value>
        public Type TargetType { get; set; }
        /// <summary>
        /// Gets the parameters (directly used by invoke).
        /// In/ref/out parameters are stored here.
        /// </summary>
        /// <value>
        /// The parameters.
        /// </value>
        public object[] Parameters { get; private set; }
        /// <summary>
        /// Gets or sets the return value.
        /// </summary>
        /// <value>
        /// The return value.
        /// </value>
        public object ReturnValue { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdviceValues" /> class.
        /// </summary>
        /// <param name="target">The target.</param>
        /// <param name="targetType">Type of the target.</param>
        /// <param name="parameters">The parameters.</param>
        public AdviceValues(object target, Type targetType, object[] parameters)
        {
            Target = target;
            TargetType = targetType;
            Parameters = parameters;
        }
    }
}
