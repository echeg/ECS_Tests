using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;

namespace Unity.Entities
{
    static class BringYourOwnDelegate
    {
        // Declare the delegate that takes 12 parameters. T0 is used for the Entity argument
        [Unity.Entities.CodeGeneratedJobForEach.EntitiesForEachCompatible]
        public delegate void CustomForEachDelegate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
        (T0 t0, in T1 t1, in T2 t2, in T3 t3, in T4 t4, in T5 t5,
            in T6 t6, in T7 t7, in T8 t8, in T9 t9, in T10 t10, in T11 t11);

        // Declare the function overload
        public static TDescription ForEach<TDescription, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
            (this TDescription description, CustomForEachDelegate<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> codeToRun)
            where TDescription : struct, Unity.Entities.CodeGeneratedJobForEach.ISupportForEachWithUniversalDelegate =>
            LambdaForEachDescriptionConstructionMethods.ThrowCodeGenException<TDescription>();
    }
}