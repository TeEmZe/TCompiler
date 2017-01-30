﻿#region

using System.Text;
using TCompiler.AssembleHelp;
using TCompiler.Settings;

#endregion

namespace TCompiler.Types.CompilingTypes.ReturningCommand.Operation.TwoParameterOperation.Compare
{
    /// <summary>
    ///     Indicates wether paramA is smaller than paramB<br />
    ///     Syntax:<br />
    ///     paramA &#60; paramB
    /// </summary>
    public class Smaller : Compare
    {
        /// <summary>
        ///     Initializes a new Smaller operation
        /// </summary>
        /// <param name="paramA">The smaller parameter</param>
        /// <param name="paramB">The bigger or equal parameter</param>
        public Smaller(ReturningCommand paramA, ReturningCommand paramB) : base(paramA, paramB)
        {
        }

        /// <summary>
        ///     Evaluates the stuff to execute in assembler to make a smaller comparison
        /// </summary>
        /// <returns>The assembler code as a string</returns>
        public override string ToString()
        {
            var notequal = GlobalProperties.Label;
            var end = GlobalProperties.Label;
            var bigger = GlobalProperties.Label;

            var sb = new StringBuilder();
            sb.AppendLine(AssembleCodePreviews.MoveParametersIntoAb(ParamA, ParamB));
            sb.AppendLine($"cjne A, 0F0h, {notequal.DestinationName}");
            sb.AppendLine("clr 0E0h.0");
            sb.AppendLine($"jmp {end.DestinationName}");
            sb.AppendLine(notequal.LabelMark());
            sb.AppendLine($"jnc {bigger.DestinationName}");
            sb.AppendLine("setb 0E0h.0");
            sb.AppendLine($"jmp {end.DestinationName}");
            sb.AppendLine(bigger.LabelMark());
            sb.AppendLine("clr 0E0h.0");
            sb.AppendLine(end.LabelMark());

            return sb.ToString();
        }
    }
}