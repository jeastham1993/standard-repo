// ------------------------------------------------------------
// Copyright (c) James Eastham.
// ------------------------------------------------------------
using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage(
    "StyleCop.CSharp.MaintainabilityRules",
    "SA1119:StatementMustNotUseUnnecessaryParenthesis",
    Justification = "The code is more readable, especially when using parenthesis for the return statements.")]

[assembly: SuppressMessage(
    "StyleCop.CSharp.ReadabilityRules",
    "SA1124:DoNotUseRegions",
    Justification = "In large files region allows creating logical sections in the file for better readability.")]

[assembly: SuppressMessage(
    "Style",
    "IDE1006:Naming Styles",
    Justification = "Prefer SA1307-SA1307AccessibleFieldsMustBeginWithUpperCaseLetter over IDE:1006.")]

[assembly: SuppressMessage(
    "StyleCop.CSharp.NamingRules",
    "SA1309:Field names should not begin with underscore",
    Justification = "Prefer underscores for clarity of private properties.")]

[assembly: SuppressMessage(
    "StyleCop.CSharp.SpacingRules",
    "SA1011:ClosingSquareBracketsMustBeSpacedCorrectly",
    Justification = "Breaks nullable references types for arrays.")]