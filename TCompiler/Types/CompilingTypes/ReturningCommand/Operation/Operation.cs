﻿namespace TCompiler.Types.CompilingTypes.ReturningCommand.Operation
{
    /// <summary>
    ///     The base class for every operation
    /// </summary>
    public abstract class Operation : ReturningCommand
    {
        /// <summary>
        ///     Initializes a new operation
        /// </summary>
        /// <param name="deactivateEa">A boolean that indicates wether the enableAll flag must get deactivated before the operation</param>
        /// <param name="activateEa">A boolean that indicates wether the enableAll flag must get activated after the operation</param>
        protected Operation(bool deactivateEa, bool activateEa)
            : base(deactivateEa, activateEa, null)
        {
        }
    }
}