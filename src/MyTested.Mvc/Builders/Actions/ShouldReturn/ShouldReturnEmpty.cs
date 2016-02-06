﻿namespace MyTested.Mvc.Builders.Actions.ShouldReturn
{
    using Contracts.Base;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Class containing methods for testing EmptyResult.
    /// </summary>
    /// <typeparam name="TActionResult">Result from invoked action in ASP.NET MVC controller.</typeparam>
    public partial class ShouldReturnTestBuilder<TActionResult>
    {
        /// <summary>
        /// Tests whether action result is EmptyResult.
        /// </summary>
        /// <returns>Base test builder with action result.</returns>
        public IBaseTestBuilderWithActionResult<TActionResult> Empty()
        {
            this.ValidateActionReturnType<EmptyResult>();
            return this.NewAndProvideTestBuilder();
        }
    }
}
