﻿#region

using TCompiler.Enums;
using TCompiler.Types.CompilerTypes;

#endregion


namespace TCompiler.Types.CheckTypes.Error
{
    /// <summary>
    ///     An error for blocks (normally too many of one type [opening/closing])
    /// </summary>
    public class BlockError : Error
    {
        /// <summary>
        ///     Initializes a new BlockError
        /// </summary>
        /// <param name="dependsOn">The command the error depends on</param>
        /// <param name="message">The message to view the user</param>
        /// <param name="codeLine">The line the error occurred in</param>
        /// <param name="type">The type of the error</param>
        public BlockError (CommandType dependsOn, string message, CodeLine codeLine, ErrorType type)
            : base (dependsOn, message, codeLine, type) {}
    }
}