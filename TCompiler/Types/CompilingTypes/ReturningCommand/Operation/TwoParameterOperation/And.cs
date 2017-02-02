﻿#region

using System.Text;
using TCompiler.AssembleHelp;

#endregion

namespace TCompiler.Types.CompilingTypes.ReturningCommand.Operation.TwoParameterOperation
{
    /// <summary>
    ///     Evaluates the logical result of paramA and paramB<br />
    ///     Syntax:<br />
    ///     paramA & paramB
    /// </summary>
    public class And : TwoParameterOperation
    {
        /// <summary>
        /// Initiates a new and operation
        /// </summary>
        /// <param name="paramA">The first parameter for the and operation</param>
        /// <param name="paramB">The second parameter for the and operation</param>
        public And(ReturningCommand paramA, ReturningCommand paramB) : base (paramA, paramB)
        { }

        /// <summary>
        ///     Evaluates the stuff to execute in assembler to make a logical and
        /// </summary>
        /// <returns>The assembler code as a string</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(AssembleCodePreviews.MoveParametersIntoAb(ParamA, ParamB));
            sb.AppendLine("anl A, 0F0h");
            return sb.ToString();
        }
    }
}