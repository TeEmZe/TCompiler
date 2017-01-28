﻿#region

using System;
using System.Text;
using TCompiler.AssembleHelp;

#endregion

namespace TCompiler.Types.CompilingTypes.ReturningCommand.Operation.TwoParameterOperation
{
    /// <summary>
    ///     Represents the logical or operation<br />
    ///     Syntax:<br />
    ///     paramA | paramB
    /// </summary>
    public class Or : TwoParameterOperation
    {
        /// <summary>
        ///     Initializes a new or operation
        /// </summary>
        /// <param name="pars">The parameter for the operation</param>
        public Or(Tuple<ReturningCommand, ReturningCommand> pars) : base(pars)
        {
        }

        public Or(ReturningCommand paramA, ReturningCommand paramB) : base(paramA, paramB)
        { }

        /// <summary>
        ///     Evaluates the stuff to execute in assembler to make a logical or operation
        /// </summary>
        /// <returns>The assembler code as a string</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(AssembleCodePreviews.MoveParametersIntoAb(ParamA, ParamB));
            sb.AppendLine("orl A, 0F0h");
            return sb.ToString();
        }
    }
}