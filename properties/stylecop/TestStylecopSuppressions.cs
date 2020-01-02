// ------------------------------------------------------------
// Copyright (c) Workflow Doctor Ltd.
// ------------------------------------------------------------

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage(
    "StyleCop.CSharp.DocumentationRules",
    "SA1600:ElementsMustBeDocumented",
    Justification = "Skipping elements documentation rule for test code.")]

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage(
    "Naming",
    "CA1707:Identifiers should not contain underscores",
    Justification = "Underscores add clarity on exactly what is being tested.")]