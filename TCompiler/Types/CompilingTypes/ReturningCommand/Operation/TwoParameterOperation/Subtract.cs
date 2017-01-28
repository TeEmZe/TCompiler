﻿#region

using System.Text;
using TCompiler.AssembleHelp;

#endregion

namespace TCompiler.Types.CompilingTypes.ReturningCommand.Operation.TwoParameterOperation
{
    /// <summary>
    ///     Subtracts paramB from paramA<br />
    ///     Syntax:<br />
    ///     paramA - paramB
    /// </summary>
    public class Subtract : TwoParameterOperation
    {
        /// <summary>
        ///     Initiates a new Subtract operation
        /// </summary>
        /// <param name="paramA">The parameter to subtract paramB from</param>
        /// <param name="paramB">The parameter that is being subtracted from paramA</param>
        public Subtract(ReturningCommand paramA, ReturningCommand paramB) : base(paramA, paramB)
        {
        }

        /// <summary>
        ///     Evaluates the stuff to execute in assembler to make a Subtract operation
        /// </summary>
        /// <returns>The assembler code as a string</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(AssembleCodePreviews.MoveParametersIntoAb(ParamA, ParamB));
            sb.AppendLine("clr C");
            sb.AppendLine("subb A, 0F0h");
            return sb.ToString();
        }
    }
}