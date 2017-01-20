﻿#region

using TCompiler.Types.CompilingTypes.ReturningCommand.Variable;

#endregion

namespace TCompiler.Types.CompilingTypes.Block
{
    /// <summary>
    ///     This is quite similar to a for loop, while it sets the defined variable to the limit and decreases it till 0<br />
    ///     Syntax: <br />
    ///     fortil limit variableName
    /// </summary>
    public class ForTilBlock : Block
    {
        /// <summary>
        ///     Initializes a new ForTilBlock
        /// </summary>
        /// <param name="endLabel">The end of the FortilBlock</param>
        /// <param name="limit">The limit (how often it gets repeated) and actually the start value for the variable</param>
        /// <param name="upperLabel">The beginning of the block (The label you jump to to repeat the block)</param>
        /// <param name="variable">The variable that gets decreased till it's zero</param>
        public ForTilBlock(Label endLabel, ByteVariableCall limit, Label upperLabel, ByteVariable variable)
            : base(endLabel, null)
        {
            Limit = limit;
            UpperLabel = upperLabel;
            Variable = variable;
        }

        /// <summary>
        ///     The limit (how often it gets repeated) and actually the start value for the variable
        /// </summary>
        public ByteVariableCall Limit { get; }

        /// <summary>
        ///     The variable that gets decreased till it's zero
        /// </summary>
        public ByteVariable Variable { get; }

        /// <summary>
        ///     The beginning of the block (The label you jump to to repeat the block)
        /// </summary>
        public Label UpperLabel { get; }
    }
}