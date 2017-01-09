﻿namespace TCompiler.Types.CheckTypes.TCompileException
{
    /// <summary>
    /// Gets thrown when the user uses an inexistent command or uses the command in an invalid context
    /// </summary>
    public class InvalidCommandException : CompileException
    {
        /// <summary>
        /// Initializes a new InvalidCommandException
        /// </summary>
        /// <param name="line">The line in which the exception got thrown</param>
        /// <param name="command">The command that wasn't valid</param>
        /// <param name="message">The message to show the programmer</param>
        public InvalidCommandException(int line, string command, string message = "The entered Command ({0}) isn't valid!")
            : base(line, string.Format(message, command))
        {
            Command = command;
        }
        
        /// <summary>
        /// The invalid command
        /// </summary>
        // ReSharper disable once UnusedAutoPropertyAccessor.Local
        private string Command { get; }
    }
}