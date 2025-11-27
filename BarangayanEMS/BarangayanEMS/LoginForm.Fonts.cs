// Pseudocode / Plan:
// 1. The ENC0033 error occurs because a 'const' field named 'segoeUIFontFamily' was removed while Debugging (Edit & Continue).
//    Deleting a compile-time const requires restarting the debug session. To avoid this problem in future edits,
//    replace compile-time constants that may be edited at runtime with a non-const alternative (e.g. static readonly).
// 2. Provide a small partial-class source file that (re)introduces the symbol as a `private static readonly string`.
//    - This keeps binary compatibility for most usages, but note: compile-time constant behavior (inlined literals)
//      is different from readonly fields. If other assemblies relied on inlining, a full rebuild may be required.
// 3. After applying the change, stop and restart the Visual Studio debug session (Edit & Continue cannot apply
//    the delete of a const field without restart). Rebuild the solution if necessary.
//
// Implementation:
// - Create a new partial file `LoginForm.Fonts.cs` that defines `segoeUIFontFamily` as a `static readonly` string.
// - This reduces the chance that small edits will require restarting the debug session in the future.

// NOTE: If you actually removed the original `const` declaration, you must fully stop debugging and rebuild once.
//       This file reintroduces the identifier as a readonly field to avoid future ENC0033 when modifying it.

using System;

namespace BarangayanEMS
{
    partial class LoginForm
    {
        // Replaces a previously-declared `const string segoeUIFontFamily = "...";`
        // Use `static readonly` instead of `const` so Edit & Continue is less likely to require a restart
        // when making non-breaking edits. If you must have a compile-time constant, keep it but be aware
        // that deleting it during a debug session will trigger ENC0033.
        private static readonly string segoeUIFontFamily = "Segoe UI";
    }
}