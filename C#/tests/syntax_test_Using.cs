/// SYNTAX TEST "Packages/C#/C#.sublime-syntax"
using System.Text;
/// <- keyword.control.import
///    ^ meta.path
///         ^ punctuation.separator.namespace
///            ^ meta.path
///              ^ punctuation.terminator
using static System.Math.Foo;
/// <- keyword.control.import
///      ^ keyword.control.import
///                  ^ meta.path
using Project = PC.MyCompany.Project;
/// <- keyword.control.import
///    ^ meta.path
///           ^ keyword.operator.assignment
using Wrapped = PC.MyCompany.Project.Wrapper<float>;
/// <- keyword.control.import
///    ^ meta.path
///           ^ keyword.operator.assignment
///                                            ^ storage.type

class Foo {

    static void UsingFont([Usage("help text")] string x)
///                        ^^^^^ variable.annotation
///                                  ^ string
///                                              ^ storage.type
///                                                   ^ variable.parameter
    {
        using (Font font3 = new Font("Arial", 10.0f))
///           ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ meta.group
///     ^ keyword.control.using
///           ^ punctuation.section.group.begin
///             ^ support.type
///                       ^ keyword.operator.assignment
///                                                 ^ punctuation.section.group.end
        {
///     ^ meta.method meta.block meta.block punctuation.section.block.begin
            // Use font3
            global::System.Console.WriteLine("foo");
///         ^ support.namespace
///               ^ punctuation.accessor.double-colon
        }
///     ^ meta.method meta.block meta.block punctuation.section.block.end

        using (Font font3 = new Font("Arial", 10.0f),
///     ^ keyword.control.using
///           ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ meta.group
///           ^ punctuation.section.group.begin
///                                                 ^ punctuation.separator
            font4 = new Font("Arial", 10.0f))
///         ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ meta.group
///                                         ^ punctuation.section.group.end
        {
///     ^ meta.method meta.block meta.block punctuation.section.block.begin
            // Use font3 and font4.
        }
///     ^ meta.method meta.block meta.block punctuation.section.block.end
    }

    public void dcsrmm(double[] val, int offsetval, int[] indx, int offsetindx, int[] pntrb, int offsetpntrb, double[] b, int offsetb, int ldb, double beta, double[] c, int offsetc, int ldc)
    {
        fixed (Double* bp = &b[offsetb])
///      ^ keyword.control.other.fixed
///           ^^^^^^^^^^^^^^^^^^^^^^^^^^ meta.group
///           ^ punctuation.section.group.begin
///              ^ support.type
///                  ^ keyword.operator.pointer
///                                    ^ punctuation.section.group.end

        fixed (var cp = &c[offsetc])
///      ^ keyword.control.other.fixed
///           ^^^^^^^^^^^^^^^^^^^^^^ meta.group
///           ^ punctuation.section.group.begin
///             ^ storage.type.variable
///                                ^ punctuation.section.group.end

        fixed (double* valp = &val[offsetval], bp = &b[offsetb], cp = &c[offsetc])
///      ^ keyword.control.other.fixed
///           ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ meta.group
///           ^ punctuation.section.group.begin
///              ^ storage.type
///                                          ^ punctuation.separator.variables
///                                                                              ^ punctuation.section.group.end
        {
            cblas_dcsrmm(valp, indxp, pntrbp, bp, ldb, beta, cp, ldc);
        }
    }
}


[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
///  ^ support.namespace
///    ^^ punctuation.accessor.double-colon
internal sealed partial class Test : global::System.Configuration.ApplicationSettingsBase {
///                                    ^ support.namespace
///                                        ^^ punctuation.accessor.double-colon

    private static Test defaultInstance = ((Test)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Test())));
///                                                ^ support.namespace
///                                                     ^^ punctuation.accessor.double-colon

    public static Test Default {
        [Tag]
///     ^^^^^ meta.annotation
///       ^ variable.annotation
        get {
///       ^ storage.type.function.accessor.get
            return defaultInstance;
        }
    }
}
