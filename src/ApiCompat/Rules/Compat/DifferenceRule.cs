﻿using System.Composition;

namespace Microsoft.Cci.Differs.Rules
{
    internal abstract class DifferenceRule : Microsoft.Cci.Differs.DifferenceRule
    {
        [Import]
        public IDifferenceOperands Operands { get; set; }

        public string Contract => Operands?.Contract ?? "contract";
        public string Implementation => Operands?.Implementation ?? "implementation";
    }
}
