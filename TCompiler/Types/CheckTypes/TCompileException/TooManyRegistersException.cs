﻿#region

using System;

using TCompiler.Types.CompilerTypes;

#endregion


namespace TCompiler.Types.CheckTypes.TCompileException
{
    /// <summary>
    ///     Gets thrown when there were over 10 registers in use
    /// </summary>
    [Serializable]
    public class TooManyRegistersException : CompileException
    {
        /// <summary>
        ///     Initializes a new TooManyRegistersException
        /// </summary>
        /// <param name="codeLine">The line in which the exception got thrown</param>
        /// <param name="message">The message that is shown to the user</param>
        public TooManyRegistersException (
            CodeLine codeLine,
            string   message = "There are not enough Registers! You'll have to solve this differently.")
            : base (codeLine, message) {}
    }
}