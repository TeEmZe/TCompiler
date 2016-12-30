﻿using System;
using TCompiler.Types.CompilingTypes.ReturningCommand.Variable;

namespace TCompiler.Types.CompilingTypes.ReturningCommand.Operation.TwoParameterOperation
{
    public class ShiftRight : TwoParameterOperation
    {
        private readonly Label _label;
        private readonly string _register;

        public ShiftRight(VariableCall paramA, VariableCall paramB, string register, Label label) : base(paramA, paramB)
        {
            _register = register;
            _label = label;
        }

        public ShiftRight(Tuple<VariableCall, VariableCall> pars, string register, Label label) : base(pars)
        {
            _register = register;
            _label = label;
        }

        public override string ToString()
            => $"{_paramB}\nmov {_register}, A\n{_paramA}\n{_label}:\n rrc A\naddc A, #0\ndjnz {_register}, {_label}";
    }
}