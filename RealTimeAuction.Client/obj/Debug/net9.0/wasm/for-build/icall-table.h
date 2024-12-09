#define ICALL_TABLE_corlib 1

static int corlib_icall_indexes [] = {
312,
319,
321,
323,
339,
352,
353,
354,
355,
356,
357,
358,
359,
360,
363,
364,
365,
558,
559,
560,
592,
593,
594,
621,
622,
623,
740,
741,
742,
743,
744,
745,
746,
749,
843,
844,
845,
846,
847,
848,
849,
850,
851,
854,
864,
865,
867,
869,
886,
889,
900,
908,
909,
910,
911,
912,
913,
914,
915,
916,
917,
918,
919,
920,
921,
922,
923,
924,
926,
927,
928,
929,
930,
931,
932,
1034,
1035,
1036,
1037,
1038,
1039,
1040,
1041,
1042,
1043,
1044,
1045,
1046,
1047,
1048,
1049,
1050,
1052,
1053,
1054,
1055,
1056,
1057,
1058,
1140,
1141,
1145,
1156,
1157,
1230,
1238,
1241,
1243,
1249,
1250,
1252,
1253,
1257,
1259,
1262,
1263,
1265,
1266,
1269,
1270,
1271,
1274,
1276,
1279,
1281,
1283,
1290,
1295,
1297,
1300,
1380,
1383,
1385,
1395,
1396,
1397,
1399,
1405,
1406,
1407,
1408,
1409,
1417,
1418,
1419,
1423,
1424,
1427,
1432,
1433,
1434,
1732,
1972,
1974,
1995,
1996,
15560,
15561,
15563,
15564,
15565,
15566,
15567,
15568,
15570,
15571,
15572,
15573,
15574,
15575,
15614,
15616,
15626,
15628,
15630,
15632,
15635,
15696,
15703,
15704,
15705,
15707,
15708,
15709,
15710,
15711,
15713,
15715,
15716,
15717,
18018,
18022,
18026,
18027,
18028,
18029,
27607,
27608,
27609,
27610,
27632,
27633,
27634,
27635,
27636,
27639,
27640,
27641,
27643,
27644,
27880,
27881,
27882,
27883,
28711,
28715,
28729,
28730,
28731,
28732,
28733,
28734,
28735,
28736,
28738,
29267,
29268,
29269,
29274,
29275,
29354,
29355,
29417,
29424,
29431,
29442,
29446,
29482,
29507,
29675,
29688,
29690,
29692,
29715,
29717,
29718,
29719,
29720,
29721,
29730,
29746,
29768,
29769,
29780,
29782,
29789,
29790,
29793,
29795,
29800,
29801,
29819,
29820,
29827,
29829,
29840,
29843,
29846,
29847,
29848,
29860,
29870,
29876,
29877,
29878,
29880,
29881,
29899,
29901,
29917,
29961,
29962,
29963,
29964,
29965,
29966,
29967,
29968,
29969,
29970,
29971,
29972,
29995,
30001,
30010,
30011,
30012,
30049,
30050,
30922,
30923,
30924,
31014,
31057,
31183,
31184,
31262,
31531,
31532,
31565,
31566,
31567,
31574,
31672,
31769,
31770,
33064,
33065,
34181,
34183,
34185,
34191,
34207,
36800,
36821,
36823,
36825,
};
void ves_icall_System_ArgIterator_Setup (int,int,int);
void ves_icall_System_ArgIterator_IntGetNextArg (int,int);
void ves_icall_System_ArgIterator_IntGetNextArgWithType (int,int,int);
int ves_icall_System_ArgIterator_IntGetNextArgType (int);
void ves_icall_System_Array_InternalCreate (int,int,int,int,int);
int ves_icall_System_Array_GetCorElementTypeOfElementTypeInternal (int);
int ves_icall_System_Array_IsValueOfElementTypeInternal (int,int);
int ves_icall_System_Array_CanChangePrimitive (int,int,int);
int ves_icall_System_Array_FastCopy (int,int,int,int,int);
int ves_icall_System_Array_GetLengthInternal_raw (int,int,int);
int ves_icall_System_Array_GetLowerBoundInternal_raw (int,int,int);
void ves_icall_System_Array_GetGenericValue_icall (int,int,int);
void ves_icall_System_Array_GetValueImpl_raw (int,int,int,int);
void ves_icall_System_Array_SetGenericValue_icall (int,int,int);
void ves_icall_System_Array_SetValueImpl_raw (int,int,int,int);
void ves_icall_System_Array_InitializeInternal_raw (int,int);
void ves_icall_System_Array_SetValueRelaxedImpl_raw (int,int,int,int);
void ves_icall_System_Runtime_RuntimeImports_ZeroMemory (int,int);
void ves_icall_System_Runtime_RuntimeImports_Memmove (int,int,int);
void ves_icall_System_Buffer_BulkMoveWithWriteBarrier (int,int,int,int);
int ves_icall_System_Delegate_AllocDelegateLike_internal_raw (int,int);
int ves_icall_System_Delegate_CreateDelegate_internal_raw (int,int,int,int,int);
int ves_icall_System_Delegate_GetVirtualMethod_internal_raw (int,int);
void ves_icall_System_Enum_GetEnumValuesAndNames_raw (int,int,int,int);
int ves_icall_System_Enum_InternalGetCorElementType (int);
void ves_icall_System_Enum_InternalGetUnderlyingType_raw (int,int,int);
int mono_environment_exitcode_get ();
void mono_environment_exitcode_set (int);
int ves_icall_System_Environment_get_ProcessorCount ();
int ves_icall_System_Environment_get_TickCount ();
int64_t ves_icall_System_Environment_get_TickCount64 ();
void ves_icall_System_Environment_Exit (int);
int ves_icall_System_Environment_GetCommandLineArgs_raw (int);
void ves_icall_System_Environment_FailFast_raw (int,int,int,int);
int ves_icall_System_GC_GetCollectionCount (int);
int ves_icall_System_GC_GetMaxGeneration ();
void ves_icall_System_GC_InternalCollect (int);
void ves_icall_System_GC_AddPressure (uint64_t);
void ves_icall_System_GC_RemovePressure (uint64_t);
void ves_icall_System_GC_register_ephemeron_array_raw (int,int);
int ves_icall_System_GC_get_ephemeron_tombstone_raw (int);
int64_t ves_icall_System_GC_GetAllocatedBytesForCurrentThread ();
int64_t ves_icall_System_GC_GetTotalAllocatedBytes_raw (int,int);
int ves_icall_System_GC_GetGeneration_raw (int,int);
void ves_icall_System_GC_WaitForPendingFinalizers ();
void ves_icall_System_GC_SuppressFinalize_raw (int,int);
void ves_icall_System_GC_ReRegisterForFinalize_raw (int,int);
int64_t ves_icall_System_GC_GetTotalMemory (int);
void ves_icall_System_GC_GetGCMemoryInfo (int,int,int,int,int,int);
int ves_icall_System_GC_AllocPinnedArray_raw (int,int,int);
int ves_icall_System_Object_MemberwiseClone_raw (int,int);
double ves_icall_System_Math_Acos (double);
double ves_icall_System_Math_Acosh (double);
double ves_icall_System_Math_Asin (double);
double ves_icall_System_Math_Asinh (double);
double ves_icall_System_Math_Atan (double);
double ves_icall_System_Math_Atan2 (double,double);
double ves_icall_System_Math_Atanh (double);
double ves_icall_System_Math_Cbrt (double);
double ves_icall_System_Math_Ceiling (double);
double ves_icall_System_Math_Cos (double);
double ves_icall_System_Math_Cosh (double);
double ves_icall_System_Math_Exp (double);
double ves_icall_System_Math_Floor (double);
double ves_icall_System_Math_Log (double);
double ves_icall_System_Math_Log10 (double);
double ves_icall_System_Math_Pow (double,double);
double ves_icall_System_Math_Sin (double);
double ves_icall_System_Math_Sinh (double);
double ves_icall_System_Math_Sqrt (double);
double ves_icall_System_Math_Tan (double);
double ves_icall_System_Math_Tanh (double);
double ves_icall_System_Math_FusedMultiplyAdd (double,double,double);
double ves_icall_System_Math_Log2 (double);
double ves_icall_System_Math_ModF (double,int);
float ves_icall_System_MathF_Acos (float);
float ves_icall_System_MathF_Acosh (float);
float ves_icall_System_MathF_Asin (float);
float ves_icall_System_MathF_Asinh (float);
float ves_icall_System_MathF_Atan (float);
float ves_icall_System_MathF_Atan2 (float,float);
float ves_icall_System_MathF_Atanh (float);
float ves_icall_System_MathF_Cbrt (float);
float ves_icall_System_MathF_Ceiling (float);
float ves_icall_System_MathF_Cos (float);
float ves_icall_System_MathF_Cosh (float);
float ves_icall_System_MathF_Exp (float);
float ves_icall_System_MathF_Floor (float);
float ves_icall_System_MathF_Log (float);
float ves_icall_System_MathF_Log10 (float);
float ves_icall_System_MathF_Pow (float,float);
float ves_icall_System_MathF_Sin (float);
float ves_icall_System_MathF_Sinh (float);
float ves_icall_System_MathF_Sqrt (float);
float ves_icall_System_MathF_Tan (float);
float ves_icall_System_MathF_Tanh (float);
float ves_icall_System_MathF_FusedMultiplyAdd (float,float,float);
float ves_icall_System_MathF_Log2 (float);
float ves_icall_System_MathF_ModF (float,int);
int ves_icall_System_RuntimeFieldHandle_GetValueDirect_raw (int,int,int,int,int);
void ves_icall_System_RuntimeFieldHandle_SetValueDirect_raw (int,int,int,int,int,int);
int ves_icall_RuntimeMethodHandle_GetFunctionPointer_raw (int,int);
void ves_icall_RuntimeMethodHandle_ReboxFromNullable_raw (int,int,int);
void ves_icall_RuntimeMethodHandle_ReboxToNullable_raw (int,int,int,int);
int ves_icall_RuntimeType_GetCorrespondingInflatedMethod_raw (int,int,int);
void ves_icall_RuntimeType_make_array_type_raw (int,int,int,int);
void ves_icall_RuntimeType_make_byref_type_raw (int,int,int);
void ves_icall_RuntimeType_make_pointer_type_raw (int,int,int);
void ves_icall_RuntimeType_MakeGenericType_raw (int,int,int,int);
int ves_icall_RuntimeType_GetMethodsByName_native_raw (int,int,int,int,int);
int ves_icall_RuntimeType_GetPropertiesByName_native_raw (int,int,int,int,int);
int ves_icall_RuntimeType_GetConstructors_native_raw (int,int,int);
void ves_icall_RuntimeType_GetInterfaceMapData_raw (int,int,int,int,int);
void ves_icall_RuntimeType_GetPacking_raw (int,int,int,int);
int ves_icall_System_RuntimeType_CreateInstanceInternal_raw (int,int);
void ves_icall_RuntimeType_GetDeclaringMethod_raw (int,int,int);
void ves_icall_System_RuntimeType_getFullName_raw (int,int,int,int,int);
void ves_icall_RuntimeType_GetGenericArgumentsInternal_raw (int,int,int,int);
int ves_icall_RuntimeType_GetGenericParameterPosition (int);
int ves_icall_RuntimeType_GetEvents_native_raw (int,int,int,int);
int ves_icall_RuntimeType_GetFields_native_raw (int,int,int,int,int);
void ves_icall_RuntimeType_GetInterfaces_raw (int,int,int);
int ves_icall_RuntimeType_GetNestedTypes_native_raw (int,int,int,int,int);
void ves_icall_RuntimeType_GetDeclaringType_raw (int,int,int);
void ves_icall_RuntimeType_GetName_raw (int,int,int);
void ves_icall_RuntimeType_GetNamespace_raw (int,int,int);
int ves_icall_RuntimeType_IsUnmanagedFunctionPointerInternal (int);
int ves_icall_RuntimeType_FunctionPointerReturnAndParameterTypes_raw (int,int);
int ves_icall_RuntimeType_GetFunctionPointerTypeModifiers_raw (int,int,int,int);
int ves_icall_RuntimeType_GetCallingConventionFromFunctionPointerInternal (int);
int ves_icall_RuntimeTypeHandle_GetAttributes (int);
int ves_icall_RuntimeTypeHandle_GetMetadataToken_raw (int,int);
void ves_icall_RuntimeTypeHandle_GetGenericTypeDefinition_impl_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_GetCorElementType (int);
int ves_icall_RuntimeTypeHandle_HasInstantiation (int);
int ves_icall_RuntimeTypeHandle_IsInstanceOfType_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_HasReferences_raw (int,int);
int ves_icall_RuntimeTypeHandle_GetArrayRank_raw (int,int);
void ves_icall_RuntimeTypeHandle_GetAssembly_raw (int,int,int);
void ves_icall_RuntimeTypeHandle_GetElementType_raw (int,int,int);
void ves_icall_RuntimeTypeHandle_GetModule_raw (int,int,int);
void ves_icall_RuntimeTypeHandle_GetBaseType_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_type_is_assignable_from_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_IsGenericTypeDefinition (int);
int ves_icall_RuntimeTypeHandle_GetGenericParameterInfo_raw (int,int);
int ves_icall_RuntimeTypeHandle_is_subclass_of_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_IsByRefLike_raw (int,int);
void ves_icall_System_RuntimeTypeHandle_internal_from_name_raw (int,int,int,int,int,int);
int ves_icall_System_String_FastAllocateString_raw (int,int);
int ves_icall_System_String_InternalIsInterned_raw (int,int);
int ves_icall_System_String_InternalIntern_raw (int,int);
int ves_icall_System_Type_internal_from_handle_raw (int,int);
int ves_icall_System_TypedReference_ToObject_raw (int,int);
void ves_icall_System_TypedReference_InternalMakeTypedReference_raw (int,int,int,int,int);
int ves_icall_System_ValueType_InternalGetHashCode_raw (int,int,int);
int ves_icall_System_ValueType_Equals_raw (int,int,int,int);
int ves_icall_System_Threading_Interlocked_CompareExchange_Int (int,int,int);
void ves_icall_System_Threading_Interlocked_CompareExchange_Object (int,int,int,int);
int ves_icall_System_Threading_Interlocked_Decrement_Int (int);
int64_t ves_icall_System_Threading_Interlocked_Decrement_Long (int);
int ves_icall_System_Threading_Interlocked_Increment_Int (int);
int64_t ves_icall_System_Threading_Interlocked_Increment_Long (int);
int ves_icall_System_Threading_Interlocked_Exchange_Int (int,int);
void ves_icall_System_Threading_Interlocked_Exchange_Object (int,int,int);
int64_t ves_icall_System_Threading_Interlocked_CompareExchange_Long (int,int64_t,int64_t);
int64_t ves_icall_System_Threading_Interlocked_Exchange_Long (int,int64_t);
int64_t ves_icall_System_Threading_Interlocked_Read_Long (int);
int ves_icall_System_Threading_Interlocked_Add_Int (int,int);
int64_t ves_icall_System_Threading_Interlocked_Add_Long (int,int64_t);
void ves_icall_System_Threading_Interlocked_MemoryBarrierProcessWide ();
void ves_icall_System_Threading_Monitor_Monitor_Enter_raw (int,int);
void mono_monitor_exit_icall_raw (int,int);
void ves_icall_System_Threading_Monitor_Monitor_pulse_raw (int,int);
void ves_icall_System_Threading_Monitor_Monitor_pulse_all_raw (int,int);
int ves_icall_System_Threading_Monitor_Monitor_wait_raw (int,int,int,int);
void ves_icall_System_Threading_Monitor_Monitor_try_enter_with_atomic_var_raw (int,int,int,int,int);
int64_t ves_icall_System_Threading_Monitor_Monitor_get_lock_contention_count ();
void ves_icall_System_Threading_Thread_StartInternal_raw (int,int,int);
uint64_t ves_icall_System_Threading_Thread_GetCurrentOSThreadId_raw (int);
void ves_icall_System_Threading_Thread_InitInternal_raw (int,int);
int ves_icall_System_Threading_Thread_GetCurrentThread ();
void ves_icall_System_Threading_InternalThread_Thread_free_internal_raw (int,int);
int ves_icall_System_Threading_Thread_GetState_raw (int,int);
void ves_icall_System_Threading_Thread_SetState_raw (int,int,int);
void ves_icall_System_Threading_Thread_ClrState_raw (int,int,int);
void ves_icall_System_Threading_Thread_SetName_icall_raw (int,int,int,int);
int ves_icall_System_Threading_Thread_YieldInternal ();
int ves_icall_System_Threading_Thread_Join_internal_raw (int,int,int);
void ves_icall_System_Threading_Thread_Interrupt_internal_raw (int,int);
void ves_icall_System_Threading_Thread_SetPriority_raw (int,int,int);
void ves_icall_System_Runtime_Loader_AssemblyLoadContext_PrepareForAssemblyLoadContextRelease_raw (int,int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_GetLoadContextForAssembly_raw (int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFile_raw (int,int,int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalInitializeNativeALC_raw (int,int,int,int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFromStream_raw (int,int,int,int,int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalGetLoadedAssemblies_raw (int);
int ves_icall_System_GCHandle_InternalAlloc_raw (int,int,int);
void ves_icall_System_GCHandle_InternalFree_raw (int,int);
int ves_icall_System_GCHandle_InternalGet_raw (int,int);
void ves_icall_System_GCHandle_InternalSet_raw (int,int,int);
int ves_icall_System_Runtime_InteropServices_Marshal_GetLastPInvokeError ();
void ves_icall_System_Runtime_InteropServices_Marshal_SetLastPInvokeError (int);
void ves_icall_System_Runtime_InteropServices_Marshal_DestroyStructure_raw (int,int,int);
int ves_icall_System_Runtime_InteropServices_Marshal_OffsetOf_raw (int,int,int);
void ves_icall_System_Runtime_InteropServices_Marshal_StructureToPtr_raw (int,int,int,int);
void ves_icall_System_Runtime_InteropServices_Marshal_PtrToStructureHelper_raw (int,int,int,int);
void ves_icall_System_Runtime_InteropServices_Marshal_GetDelegateForFunctionPointerInternal_raw (int,int,int,int);
int ves_icall_System_Runtime_InteropServices_Marshal_GetFunctionPointerForDelegateInternal_raw (int,int);
void ves_icall_System_Runtime_InteropServices_Marshal_Prelink_raw (int,int);
int ves_icall_System_Runtime_InteropServices_Marshal_SizeOfHelper_raw (int,int,int);
int ves_icall_System_Runtime_InteropServices_NativeLibrary_LoadFromPath_raw (int,int,int);
int ves_icall_System_Runtime_InteropServices_NativeLibrary_LoadByName_raw (int,int,int,int,int,int);
void ves_icall_System_Runtime_InteropServices_NativeLibrary_FreeLib_raw (int,int);
int ves_icall_System_Runtime_InteropServices_NativeLibrary_GetSymbol_raw (int,int,int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InternalGetHashCode_raw (int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetObjectValue_raw (int,int);
void ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_PrepareMethod_raw (int,int,int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetUninitializedObjectInternal_raw (int,int);
void ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InitializeArray_raw (int,int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetSpanDataFrom_raw (int,int,int,int);
void ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_RunClassConstructor_raw (int,int);
void ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_RunModuleConstructor_raw (int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_SufficientExecutionStack ();
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InternalBox_raw (int,int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_SizeOf_raw (int,int);
int ves_icall_System_Reflection_Assembly_GetExecutingAssembly_raw (int,int);
int ves_icall_System_Reflection_Assembly_GetCallingAssembly_raw (int);
int ves_icall_System_Reflection_Assembly_GetEntryAssembly_raw (int);
int ves_icall_System_Reflection_Assembly_InternalLoad_raw (int,int,int,int);
int ves_icall_System_Reflection_Assembly_InternalGetType_raw (int,int,int,int,int,int);
void ves_icall_System_Reflection_AssemblyName_FreeAssemblyName (int,int);
int ves_icall_System_Reflection_AssemblyName_GetNativeName (int);
int ves_icall_MonoCustomAttrs_GetCustomAttributesInternal_raw (int,int,int,int);
int ves_icall_MonoCustomAttrs_GetCustomAttributesDataInternal_raw (int,int);
int ves_icall_MonoCustomAttrs_IsDefinedInternal_raw (int,int,int);
int ves_icall_System_Reflection_FieldInfo_internal_from_handle_type_raw (int,int,int);
int ves_icall_System_Reflection_FieldInfo_get_marshal_info_raw (int,int);
int ves_icall_System_Reflection_LoaderAllocatorScout_Destroy (int);
int ves_icall_GetCurrentMethod_raw (int);
void ves_icall_System_Reflection_RuntimeAssembly_GetEntryPoint_raw (int,int,int);
void ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceNames_raw (int,int,int);
void ves_icall_System_Reflection_RuntimeAssembly_GetExportedTypes_raw (int,int,int);
void ves_icall_System_Reflection_RuntimeAssembly_GetTopLevelForwardedTypes_raw (int,int,int);
void ves_icall_System_Reflection_RuntimeAssembly_GetInfo_raw (int,int,int,int);
int ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceInfoInternal_raw (int,int,int,int);
int ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceInternal_raw (int,int,int,int,int);
void ves_icall_System_Reflection_Assembly_GetManifestModuleInternal_raw (int,int,int);
void ves_icall_System_Reflection_RuntimeAssembly_GetModulesInternal_raw (int,int,int);
int ves_icall_System_Reflection_Assembly_InternalGetReferencedAssemblies_raw (int,int);
void ves_icall_System_Reflection_RuntimeCustomAttributeData_ResolveArgumentsInternal_raw (int,int,int,int,int,int,int);
void ves_icall_RuntimeEventInfo_get_event_info_raw (int,int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_System_Reflection_EventInfo_internal_from_handle_type_raw (int,int,int);
int ves_icall_RuntimeFieldInfo_ResolveType_raw (int,int);
int ves_icall_RuntimeFieldInfo_GetParentType_raw (int,int,int);
int ves_icall_RuntimeFieldInfo_GetFieldOffset_raw (int,int);
int ves_icall_RuntimeFieldInfo_GetValueInternal_raw (int,int,int);
void ves_icall_RuntimeFieldInfo_SetValueInternal_raw (int,int,int,int);
int ves_icall_RuntimeFieldInfo_GetRawConstantValue_raw (int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_System_Reflection_FieldInfo_GetTypeModifiers_raw (int,int,int,int);
void ves_icall_get_method_info_raw (int,int,int);
int ves_icall_get_method_attributes (int);
int ves_icall_System_Reflection_MonoMethodInfo_get_parameter_info_raw (int,int,int);
int ves_icall_System_MonoMethodInfo_get_retval_marshal_raw (int,int);
int ves_icall_System_Reflection_RuntimeMethodInfo_GetMethodBodyInternal_raw (int,int);
int ves_icall_System_Reflection_RuntimeMethodInfo_GetMethodFromHandleInternalType_native_raw (int,int,int,int);
int ves_icall_RuntimeMethodInfo_get_name_raw (int,int);
int ves_icall_RuntimeMethodInfo_get_base_method_raw (int,int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_InternalInvoke_raw (int,int,int,int,int);
void ves_icall_RuntimeMethodInfo_GetPInvoke_raw (int,int,int,int,int);
int ves_icall_RuntimeMethodInfo_MakeGenericMethod_impl_raw (int,int,int);
int ves_icall_RuntimeMethodInfo_GetGenericArguments_raw (int,int);
int ves_icall_RuntimeMethodInfo_GetGenericMethodDefinition_raw (int,int);
int ves_icall_RuntimeMethodInfo_get_IsGenericMethodDefinition_raw (int,int);
int ves_icall_RuntimeMethodInfo_get_IsGenericMethod_raw (int,int);
void ves_icall_InvokeClassConstructor_raw (int,int);
int ves_icall_InternalInvoke_raw (int,int,int,int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_System_Reflection_RuntimeModule_GetMDStreamVersion_raw (int,int);
int ves_icall_System_Reflection_RuntimeModule_InternalGetTypes_raw (int,int);
void ves_icall_System_Reflection_RuntimeModule_GetGuidInternal_raw (int,int,int);
int ves_icall_System_Reflection_RuntimeModule_GetGlobalType_raw (int,int);
int ves_icall_System_Reflection_RuntimeModule_ResolveTypeToken_raw (int,int,int,int,int,int);
int ves_icall_System_Reflection_RuntimeModule_ResolveMethodToken_raw (int,int,int,int,int,int);
int ves_icall_System_Reflection_RuntimeModule_ResolveFieldToken_raw (int,int,int,int,int,int);
int ves_icall_System_Reflection_RuntimeModule_ResolveStringToken_raw (int,int,int,int);
int ves_icall_System_Reflection_RuntimeModule_ResolveMemberToken_raw (int,int,int,int,int,int);
int ves_icall_System_Reflection_RuntimeModule_ResolveSignature_raw (int,int,int,int);
void ves_icall_System_Reflection_RuntimeModule_GetPEKind_raw (int,int,int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_RuntimeParameterInfo_GetTypeModifiers_raw (int,int,int,int,int,int);
void ves_icall_RuntimePropertyInfo_get_property_info_raw (int,int,int,int);
int ves_icall_RuntimePropertyInfo_GetTypeModifiers_raw (int,int,int,int);
int ves_icall_property_info_get_default_value_raw (int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_System_Reflection_RuntimePropertyInfo_internal_from_handle_type_raw (int,int,int);
int ves_icall_AssemblyExtensions_ApplyUpdateEnabled (int);
int ves_icall_AssemblyExtensions_GetApplyUpdateCapabilities_raw (int);
void ves_icall_AssemblyExtensions_ApplyUpdate (int,int,int,int,int,int,int);
int ves_icall_CustomAttributeBuilder_GetBlob_raw (int,int,int,int,int,int,int,int);
void ves_icall_DynamicMethod_create_dynamic_method_raw (int,int,int,int,int);
void ves_icall_AssemblyBuilder_basic_init_raw (int,int);
void ves_icall_AssemblyBuilder_UpdateNativeCustomAttributes_raw (int,int);
void ves_icall_EnumBuilder_setup_enum_type_raw (int,int,int);
void ves_icall_ModuleBuilder_basic_init_raw (int,int);
void ves_icall_ModuleBuilder_set_wrappers_type_raw (int,int,int);
int ves_icall_ModuleBuilder_getUSIndex_raw (int,int,int);
int ves_icall_ModuleBuilder_getToken_raw (int,int,int,int);
int ves_icall_ModuleBuilder_getMethodToken_raw (int,int,int,int);
void ves_icall_ModuleBuilder_RegisterToken_raw (int,int,int,int);
int ves_icall_TypeBuilder_create_runtime_class_raw (int,int);
int ves_icall_SignatureHelper_get_signature_local_raw (int,int);
int ves_icall_SignatureHelper_get_signature_field_raw (int,int);
int ves_icall_System_IO_Stream_HasOverriddenBeginEndRead_raw (int,int);
int ves_icall_System_IO_Stream_HasOverriddenBeginEndWrite_raw (int,int);
int ves_icall_System_Diagnostics_Debugger_IsAttached_internal ();
int ves_icall_System_Diagnostics_Debugger_IsLogging ();
void ves_icall_System_Diagnostics_Debugger_Log (int,int,int);
int ves_icall_System_Diagnostics_StackFrame_GetFrameInfo (int,int,int,int,int,int,int,int);
void ves_icall_System_Diagnostics_StackTrace_GetTrace (int,int,int,int);
int ves_icall_Mono_RuntimeClassHandle_GetTypeFromClass (int);
void ves_icall_Mono_RuntimeGPtrArrayHandle_GPtrArrayFree (int);
int ves_icall_Mono_SafeStringMarshal_StringToUtf8 (int);
void ves_icall_Mono_SafeStringMarshal_GFree (int);
static void *corlib_icall_funcs [] = {
// token 312,
ves_icall_System_ArgIterator_Setup,
// token 319,
ves_icall_System_ArgIterator_IntGetNextArg,
// token 321,
ves_icall_System_ArgIterator_IntGetNextArgWithType,
// token 323,
ves_icall_System_ArgIterator_IntGetNextArgType,
// token 339,
ves_icall_System_Array_InternalCreate,
// token 352,
ves_icall_System_Array_GetCorElementTypeOfElementTypeInternal,
// token 353,
ves_icall_System_Array_IsValueOfElementTypeInternal,
// token 354,
ves_icall_System_Array_CanChangePrimitive,
// token 355,
ves_icall_System_Array_FastCopy,
// token 356,
ves_icall_System_Array_GetLengthInternal_raw,
// token 357,
ves_icall_System_Array_GetLowerBoundInternal_raw,
// token 358,
ves_icall_System_Array_GetGenericValue_icall,
// token 359,
ves_icall_System_Array_GetValueImpl_raw,
// token 360,
ves_icall_System_Array_SetGenericValue_icall,
// token 363,
ves_icall_System_Array_SetValueImpl_raw,
// token 364,
ves_icall_System_Array_InitializeInternal_raw,
// token 365,
ves_icall_System_Array_SetValueRelaxedImpl_raw,
// token 558,
ves_icall_System_Runtime_RuntimeImports_ZeroMemory,
// token 559,
ves_icall_System_Runtime_RuntimeImports_Memmove,
// token 560,
ves_icall_System_Buffer_BulkMoveWithWriteBarrier,
// token 592,
ves_icall_System_Delegate_AllocDelegateLike_internal_raw,
// token 593,
ves_icall_System_Delegate_CreateDelegate_internal_raw,
// token 594,
ves_icall_System_Delegate_GetVirtualMethod_internal_raw,
// token 621,
ves_icall_System_Enum_GetEnumValuesAndNames_raw,
// token 622,
ves_icall_System_Enum_InternalGetCorElementType,
// token 623,
ves_icall_System_Enum_InternalGetUnderlyingType_raw,
// token 740,
mono_environment_exitcode_get,
// token 741,
mono_environment_exitcode_set,
// token 742,
ves_icall_System_Environment_get_ProcessorCount,
// token 743,
ves_icall_System_Environment_get_TickCount,
// token 744,
ves_icall_System_Environment_get_TickCount64,
// token 745,
ves_icall_System_Environment_Exit,
// token 746,
ves_icall_System_Environment_GetCommandLineArgs_raw,
// token 749,
ves_icall_System_Environment_FailFast_raw,
// token 843,
ves_icall_System_GC_GetCollectionCount,
// token 844,
ves_icall_System_GC_GetMaxGeneration,
// token 845,
ves_icall_System_GC_InternalCollect,
// token 846,
ves_icall_System_GC_AddPressure,
// token 847,
ves_icall_System_GC_RemovePressure,
// token 848,
ves_icall_System_GC_register_ephemeron_array_raw,
// token 849,
ves_icall_System_GC_get_ephemeron_tombstone_raw,
// token 850,
ves_icall_System_GC_GetAllocatedBytesForCurrentThread,
// token 851,
ves_icall_System_GC_GetTotalAllocatedBytes_raw,
// token 854,
ves_icall_System_GC_GetGeneration_raw,
// token 864,
ves_icall_System_GC_WaitForPendingFinalizers,
// token 865,
ves_icall_System_GC_SuppressFinalize_raw,
// token 867,
ves_icall_System_GC_ReRegisterForFinalize_raw,
// token 869,
ves_icall_System_GC_GetTotalMemory,
// token 886,
ves_icall_System_GC_GetGCMemoryInfo,
// token 889,
ves_icall_System_GC_AllocPinnedArray_raw,
// token 900,
ves_icall_System_Object_MemberwiseClone_raw,
// token 908,
ves_icall_System_Math_Acos,
// token 909,
ves_icall_System_Math_Acosh,
// token 910,
ves_icall_System_Math_Asin,
// token 911,
ves_icall_System_Math_Asinh,
// token 912,
ves_icall_System_Math_Atan,
// token 913,
ves_icall_System_Math_Atan2,
// token 914,
ves_icall_System_Math_Atanh,
// token 915,
ves_icall_System_Math_Cbrt,
// token 916,
ves_icall_System_Math_Ceiling,
// token 917,
ves_icall_System_Math_Cos,
// token 918,
ves_icall_System_Math_Cosh,
// token 919,
ves_icall_System_Math_Exp,
// token 920,
ves_icall_System_Math_Floor,
// token 921,
ves_icall_System_Math_Log,
// token 922,
ves_icall_System_Math_Log10,
// token 923,
ves_icall_System_Math_Pow,
// token 924,
ves_icall_System_Math_Sin,
// token 926,
ves_icall_System_Math_Sinh,
// token 927,
ves_icall_System_Math_Sqrt,
// token 928,
ves_icall_System_Math_Tan,
// token 929,
ves_icall_System_Math_Tanh,
// token 930,
ves_icall_System_Math_FusedMultiplyAdd,
// token 931,
ves_icall_System_Math_Log2,
// token 932,
ves_icall_System_Math_ModF,
// token 1034,
ves_icall_System_MathF_Acos,
// token 1035,
ves_icall_System_MathF_Acosh,
// token 1036,
ves_icall_System_MathF_Asin,
// token 1037,
ves_icall_System_MathF_Asinh,
// token 1038,
ves_icall_System_MathF_Atan,
// token 1039,
ves_icall_System_MathF_Atan2,
// token 1040,
ves_icall_System_MathF_Atanh,
// token 1041,
ves_icall_System_MathF_Cbrt,
// token 1042,
ves_icall_System_MathF_Ceiling,
// token 1043,
ves_icall_System_MathF_Cos,
// token 1044,
ves_icall_System_MathF_Cosh,
// token 1045,
ves_icall_System_MathF_Exp,
// token 1046,
ves_icall_System_MathF_Floor,
// token 1047,
ves_icall_System_MathF_Log,
// token 1048,
ves_icall_System_MathF_Log10,
// token 1049,
ves_icall_System_MathF_Pow,
// token 1050,
ves_icall_System_MathF_Sin,
// token 1052,
ves_icall_System_MathF_Sinh,
// token 1053,
ves_icall_System_MathF_Sqrt,
// token 1054,
ves_icall_System_MathF_Tan,
// token 1055,
ves_icall_System_MathF_Tanh,
// token 1056,
ves_icall_System_MathF_FusedMultiplyAdd,
// token 1057,
ves_icall_System_MathF_Log2,
// token 1058,
ves_icall_System_MathF_ModF,
// token 1140,
ves_icall_System_RuntimeFieldHandle_GetValueDirect_raw,
// token 1141,
ves_icall_System_RuntimeFieldHandle_SetValueDirect_raw,
// token 1145,
ves_icall_RuntimeMethodHandle_GetFunctionPointer_raw,
// token 1156,
ves_icall_RuntimeMethodHandle_ReboxFromNullable_raw,
// token 1157,
ves_icall_RuntimeMethodHandle_ReboxToNullable_raw,
// token 1230,
ves_icall_RuntimeType_GetCorrespondingInflatedMethod_raw,
// token 1238,
ves_icall_RuntimeType_make_array_type_raw,
// token 1241,
ves_icall_RuntimeType_make_byref_type_raw,
// token 1243,
ves_icall_RuntimeType_make_pointer_type_raw,
// token 1249,
ves_icall_RuntimeType_MakeGenericType_raw,
// token 1250,
ves_icall_RuntimeType_GetMethodsByName_native_raw,
// token 1252,
ves_icall_RuntimeType_GetPropertiesByName_native_raw,
// token 1253,
ves_icall_RuntimeType_GetConstructors_native_raw,
// token 1257,
ves_icall_RuntimeType_GetInterfaceMapData_raw,
// token 1259,
ves_icall_RuntimeType_GetPacking_raw,
// token 1262,
ves_icall_System_RuntimeType_CreateInstanceInternal_raw,
// token 1263,
ves_icall_RuntimeType_GetDeclaringMethod_raw,
// token 1265,
ves_icall_System_RuntimeType_getFullName_raw,
// token 1266,
ves_icall_RuntimeType_GetGenericArgumentsInternal_raw,
// token 1269,
ves_icall_RuntimeType_GetGenericParameterPosition,
// token 1270,
ves_icall_RuntimeType_GetEvents_native_raw,
// token 1271,
ves_icall_RuntimeType_GetFields_native_raw,
// token 1274,
ves_icall_RuntimeType_GetInterfaces_raw,
// token 1276,
ves_icall_RuntimeType_GetNestedTypes_native_raw,
// token 1279,
ves_icall_RuntimeType_GetDeclaringType_raw,
// token 1281,
ves_icall_RuntimeType_GetName_raw,
// token 1283,
ves_icall_RuntimeType_GetNamespace_raw,
// token 1290,
ves_icall_RuntimeType_IsUnmanagedFunctionPointerInternal,
// token 1295,
ves_icall_RuntimeType_FunctionPointerReturnAndParameterTypes_raw,
// token 1297,
ves_icall_RuntimeType_GetFunctionPointerTypeModifiers_raw,
// token 1300,
ves_icall_RuntimeType_GetCallingConventionFromFunctionPointerInternal,
// token 1380,
ves_icall_RuntimeTypeHandle_GetAttributes,
// token 1383,
ves_icall_RuntimeTypeHandle_GetMetadataToken_raw,
// token 1385,
ves_icall_RuntimeTypeHandle_GetGenericTypeDefinition_impl_raw,
// token 1395,
ves_icall_RuntimeTypeHandle_GetCorElementType,
// token 1396,
ves_icall_RuntimeTypeHandle_HasInstantiation,
// token 1397,
ves_icall_RuntimeTypeHandle_IsInstanceOfType_raw,
// token 1399,
ves_icall_RuntimeTypeHandle_HasReferences_raw,
// token 1405,
ves_icall_RuntimeTypeHandle_GetArrayRank_raw,
// token 1406,
ves_icall_RuntimeTypeHandle_GetAssembly_raw,
// token 1407,
ves_icall_RuntimeTypeHandle_GetElementType_raw,
// token 1408,
ves_icall_RuntimeTypeHandle_GetModule_raw,
// token 1409,
ves_icall_RuntimeTypeHandle_GetBaseType_raw,
// token 1417,
ves_icall_RuntimeTypeHandle_type_is_assignable_from_raw,
// token 1418,
ves_icall_RuntimeTypeHandle_IsGenericTypeDefinition,
// token 1419,
ves_icall_RuntimeTypeHandle_GetGenericParameterInfo_raw,
// token 1423,
ves_icall_RuntimeTypeHandle_is_subclass_of_raw,
// token 1424,
ves_icall_RuntimeTypeHandle_IsByRefLike_raw,
// token 1427,
ves_icall_System_RuntimeTypeHandle_internal_from_name_raw,
// token 1432,
ves_icall_System_String_FastAllocateString_raw,
// token 1433,
ves_icall_System_String_InternalIsInterned_raw,
// token 1434,
ves_icall_System_String_InternalIntern_raw,
// token 1732,
ves_icall_System_Type_internal_from_handle_raw,
// token 1972,
ves_icall_System_TypedReference_ToObject_raw,
// token 1974,
ves_icall_System_TypedReference_InternalMakeTypedReference_raw,
// token 1995,
ves_icall_System_ValueType_InternalGetHashCode_raw,
// token 1996,
ves_icall_System_ValueType_Equals_raw,
// token 15560,
ves_icall_System_Threading_Interlocked_CompareExchange_Int,
// token 15561,
ves_icall_System_Threading_Interlocked_CompareExchange_Object,
// token 15563,
ves_icall_System_Threading_Interlocked_Decrement_Int,
// token 15564,
ves_icall_System_Threading_Interlocked_Decrement_Long,
// token 15565,
ves_icall_System_Threading_Interlocked_Increment_Int,
// token 15566,
ves_icall_System_Threading_Interlocked_Increment_Long,
// token 15567,
ves_icall_System_Threading_Interlocked_Exchange_Int,
// token 15568,
ves_icall_System_Threading_Interlocked_Exchange_Object,
// token 15570,
ves_icall_System_Threading_Interlocked_CompareExchange_Long,
// token 15571,
ves_icall_System_Threading_Interlocked_Exchange_Long,
// token 15572,
ves_icall_System_Threading_Interlocked_Read_Long,
// token 15573,
ves_icall_System_Threading_Interlocked_Add_Int,
// token 15574,
ves_icall_System_Threading_Interlocked_Add_Long,
// token 15575,
ves_icall_System_Threading_Interlocked_MemoryBarrierProcessWide,
// token 15614,
ves_icall_System_Threading_Monitor_Monitor_Enter_raw,
// token 15616,
mono_monitor_exit_icall_raw,
// token 15626,
ves_icall_System_Threading_Monitor_Monitor_pulse_raw,
// token 15628,
ves_icall_System_Threading_Monitor_Monitor_pulse_all_raw,
// token 15630,
ves_icall_System_Threading_Monitor_Monitor_wait_raw,
// token 15632,
ves_icall_System_Threading_Monitor_Monitor_try_enter_with_atomic_var_raw,
// token 15635,
ves_icall_System_Threading_Monitor_Monitor_get_lock_contention_count,
// token 15696,
ves_icall_System_Threading_Thread_StartInternal_raw,
// token 15703,
ves_icall_System_Threading_Thread_GetCurrentOSThreadId_raw,
// token 15704,
ves_icall_System_Threading_Thread_InitInternal_raw,
// token 15705,
ves_icall_System_Threading_Thread_GetCurrentThread,
// token 15707,
ves_icall_System_Threading_InternalThread_Thread_free_internal_raw,
// token 15708,
ves_icall_System_Threading_Thread_GetState_raw,
// token 15709,
ves_icall_System_Threading_Thread_SetState_raw,
// token 15710,
ves_icall_System_Threading_Thread_ClrState_raw,
// token 15711,
ves_icall_System_Threading_Thread_SetName_icall_raw,
// token 15713,
ves_icall_System_Threading_Thread_YieldInternal,
// token 15715,
ves_icall_System_Threading_Thread_Join_internal_raw,
// token 15716,
ves_icall_System_Threading_Thread_Interrupt_internal_raw,
// token 15717,
ves_icall_System_Threading_Thread_SetPriority_raw,
// token 18018,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_PrepareForAssemblyLoadContextRelease_raw,
// token 18022,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_GetLoadContextForAssembly_raw,
// token 18026,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFile_raw,
// token 18027,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalInitializeNativeALC_raw,
// token 18028,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFromStream_raw,
// token 18029,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalGetLoadedAssemblies_raw,
// token 27607,
ves_icall_System_GCHandle_InternalAlloc_raw,
// token 27608,
ves_icall_System_GCHandle_InternalFree_raw,
// token 27609,
ves_icall_System_GCHandle_InternalGet_raw,
// token 27610,
ves_icall_System_GCHandle_InternalSet_raw,
// token 27632,
ves_icall_System_Runtime_InteropServices_Marshal_GetLastPInvokeError,
// token 27633,
ves_icall_System_Runtime_InteropServices_Marshal_SetLastPInvokeError,
// token 27634,
ves_icall_System_Runtime_InteropServices_Marshal_DestroyStructure_raw,
// token 27635,
ves_icall_System_Runtime_InteropServices_Marshal_OffsetOf_raw,
// token 27636,
ves_icall_System_Runtime_InteropServices_Marshal_StructureToPtr_raw,
// token 27639,
ves_icall_System_Runtime_InteropServices_Marshal_PtrToStructureHelper_raw,
// token 27640,
ves_icall_System_Runtime_InteropServices_Marshal_GetDelegateForFunctionPointerInternal_raw,
// token 27641,
ves_icall_System_Runtime_InteropServices_Marshal_GetFunctionPointerForDelegateInternal_raw,
// token 27643,
ves_icall_System_Runtime_InteropServices_Marshal_Prelink_raw,
// token 27644,
ves_icall_System_Runtime_InteropServices_Marshal_SizeOfHelper_raw,
// token 27880,
ves_icall_System_Runtime_InteropServices_NativeLibrary_LoadFromPath_raw,
// token 27881,
ves_icall_System_Runtime_InteropServices_NativeLibrary_LoadByName_raw,
// token 27882,
ves_icall_System_Runtime_InteropServices_NativeLibrary_FreeLib_raw,
// token 27883,
ves_icall_System_Runtime_InteropServices_NativeLibrary_GetSymbol_raw,
// token 28711,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InternalGetHashCode_raw,
// token 28715,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetObjectValue_raw,
// token 28729,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_PrepareMethod_raw,
// token 28730,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetUninitializedObjectInternal_raw,
// token 28731,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InitializeArray_raw,
// token 28732,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetSpanDataFrom_raw,
// token 28733,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_RunClassConstructor_raw,
// token 28734,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_RunModuleConstructor_raw,
// token 28735,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_SufficientExecutionStack,
// token 28736,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InternalBox_raw,
// token 28738,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_SizeOf_raw,
// token 29267,
ves_icall_System_Reflection_Assembly_GetExecutingAssembly_raw,
// token 29268,
ves_icall_System_Reflection_Assembly_GetCallingAssembly_raw,
// token 29269,
ves_icall_System_Reflection_Assembly_GetEntryAssembly_raw,
// token 29274,
ves_icall_System_Reflection_Assembly_InternalLoad_raw,
// token 29275,
ves_icall_System_Reflection_Assembly_InternalGetType_raw,
// token 29354,
ves_icall_System_Reflection_AssemblyName_FreeAssemblyName,
// token 29355,
ves_icall_System_Reflection_AssemblyName_GetNativeName,
// token 29417,
ves_icall_MonoCustomAttrs_GetCustomAttributesInternal_raw,
// token 29424,
ves_icall_MonoCustomAttrs_GetCustomAttributesDataInternal_raw,
// token 29431,
ves_icall_MonoCustomAttrs_IsDefinedInternal_raw,
// token 29442,
ves_icall_System_Reflection_FieldInfo_internal_from_handle_type_raw,
// token 29446,
ves_icall_System_Reflection_FieldInfo_get_marshal_info_raw,
// token 29482,
ves_icall_System_Reflection_LoaderAllocatorScout_Destroy,
// token 29507,
ves_icall_GetCurrentMethod_raw,
// token 29675,
ves_icall_System_Reflection_RuntimeAssembly_GetEntryPoint_raw,
// token 29688,
ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceNames_raw,
// token 29690,
ves_icall_System_Reflection_RuntimeAssembly_GetExportedTypes_raw,
// token 29692,
ves_icall_System_Reflection_RuntimeAssembly_GetTopLevelForwardedTypes_raw,
// token 29715,
ves_icall_System_Reflection_RuntimeAssembly_GetInfo_raw,
// token 29717,
ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceInfoInternal_raw,
// token 29718,
ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceInternal_raw,
// token 29719,
ves_icall_System_Reflection_Assembly_GetManifestModuleInternal_raw,
// token 29720,
ves_icall_System_Reflection_RuntimeAssembly_GetModulesInternal_raw,
// token 29721,
ves_icall_System_Reflection_Assembly_InternalGetReferencedAssemblies_raw,
// token 29730,
ves_icall_System_Reflection_RuntimeCustomAttributeData_ResolveArgumentsInternal_raw,
// token 29746,
ves_icall_RuntimeEventInfo_get_event_info_raw,
// token 29768,
ves_icall_reflection_get_token_raw,
// token 29769,
ves_icall_System_Reflection_EventInfo_internal_from_handle_type_raw,
// token 29780,
ves_icall_RuntimeFieldInfo_ResolveType_raw,
// token 29782,
ves_icall_RuntimeFieldInfo_GetParentType_raw,
// token 29789,
ves_icall_RuntimeFieldInfo_GetFieldOffset_raw,
// token 29790,
ves_icall_RuntimeFieldInfo_GetValueInternal_raw,
// token 29793,
ves_icall_RuntimeFieldInfo_SetValueInternal_raw,
// token 29795,
ves_icall_RuntimeFieldInfo_GetRawConstantValue_raw,
// token 29800,
ves_icall_reflection_get_token_raw,
// token 29801,
ves_icall_System_Reflection_FieldInfo_GetTypeModifiers_raw,
// token 29819,
ves_icall_get_method_info_raw,
// token 29820,
ves_icall_get_method_attributes,
// token 29827,
ves_icall_System_Reflection_MonoMethodInfo_get_parameter_info_raw,
// token 29829,
ves_icall_System_MonoMethodInfo_get_retval_marshal_raw,
// token 29840,
ves_icall_System_Reflection_RuntimeMethodInfo_GetMethodBodyInternal_raw,
// token 29843,
ves_icall_System_Reflection_RuntimeMethodInfo_GetMethodFromHandleInternalType_native_raw,
// token 29846,
ves_icall_RuntimeMethodInfo_get_name_raw,
// token 29847,
ves_icall_RuntimeMethodInfo_get_base_method_raw,
// token 29848,
ves_icall_reflection_get_token_raw,
// token 29860,
ves_icall_InternalInvoke_raw,
// token 29870,
ves_icall_RuntimeMethodInfo_GetPInvoke_raw,
// token 29876,
ves_icall_RuntimeMethodInfo_MakeGenericMethod_impl_raw,
// token 29877,
ves_icall_RuntimeMethodInfo_GetGenericArguments_raw,
// token 29878,
ves_icall_RuntimeMethodInfo_GetGenericMethodDefinition_raw,
// token 29880,
ves_icall_RuntimeMethodInfo_get_IsGenericMethodDefinition_raw,
// token 29881,
ves_icall_RuntimeMethodInfo_get_IsGenericMethod_raw,
// token 29899,
ves_icall_InvokeClassConstructor_raw,
// token 29901,
ves_icall_InternalInvoke_raw,
// token 29917,
ves_icall_reflection_get_token_raw,
// token 29961,
ves_icall_reflection_get_token_raw,
// token 29962,
ves_icall_System_Reflection_RuntimeModule_GetMDStreamVersion_raw,
// token 29963,
ves_icall_System_Reflection_RuntimeModule_InternalGetTypes_raw,
// token 29964,
ves_icall_System_Reflection_RuntimeModule_GetGuidInternal_raw,
// token 29965,
ves_icall_System_Reflection_RuntimeModule_GetGlobalType_raw,
// token 29966,
ves_icall_System_Reflection_RuntimeModule_ResolveTypeToken_raw,
// token 29967,
ves_icall_System_Reflection_RuntimeModule_ResolveMethodToken_raw,
// token 29968,
ves_icall_System_Reflection_RuntimeModule_ResolveFieldToken_raw,
// token 29969,
ves_icall_System_Reflection_RuntimeModule_ResolveStringToken_raw,
// token 29970,
ves_icall_System_Reflection_RuntimeModule_ResolveMemberToken_raw,
// token 29971,
ves_icall_System_Reflection_RuntimeModule_ResolveSignature_raw,
// token 29972,
ves_icall_System_Reflection_RuntimeModule_GetPEKind_raw,
// token 29995,
ves_icall_reflection_get_token_raw,
// token 30001,
ves_icall_RuntimeParameterInfo_GetTypeModifiers_raw,
// token 30010,
ves_icall_RuntimePropertyInfo_get_property_info_raw,
// token 30011,
ves_icall_RuntimePropertyInfo_GetTypeModifiers_raw,
// token 30012,
ves_icall_property_info_get_default_value_raw,
// token 30049,
ves_icall_reflection_get_token_raw,
// token 30050,
ves_icall_System_Reflection_RuntimePropertyInfo_internal_from_handle_type_raw,
// token 30922,
ves_icall_AssemblyExtensions_ApplyUpdateEnabled,
// token 30923,
ves_icall_AssemblyExtensions_GetApplyUpdateCapabilities_raw,
// token 30924,
ves_icall_AssemblyExtensions_ApplyUpdate,
// token 31014,
ves_icall_CustomAttributeBuilder_GetBlob_raw,
// token 31057,
ves_icall_DynamicMethod_create_dynamic_method_raw,
// token 31183,
ves_icall_AssemblyBuilder_basic_init_raw,
// token 31184,
ves_icall_AssemblyBuilder_UpdateNativeCustomAttributes_raw,
// token 31262,
ves_icall_EnumBuilder_setup_enum_type_raw,
// token 31531,
ves_icall_ModuleBuilder_basic_init_raw,
// token 31532,
ves_icall_ModuleBuilder_set_wrappers_type_raw,
// token 31565,
ves_icall_ModuleBuilder_getUSIndex_raw,
// token 31566,
ves_icall_ModuleBuilder_getToken_raw,
// token 31567,
ves_icall_ModuleBuilder_getMethodToken_raw,
// token 31574,
ves_icall_ModuleBuilder_RegisterToken_raw,
// token 31672,
ves_icall_TypeBuilder_create_runtime_class_raw,
// token 31769,
ves_icall_SignatureHelper_get_signature_local_raw,
// token 31770,
ves_icall_SignatureHelper_get_signature_field_raw,
// token 33064,
ves_icall_System_IO_Stream_HasOverriddenBeginEndRead_raw,
// token 33065,
ves_icall_System_IO_Stream_HasOverriddenBeginEndWrite_raw,
// token 34181,
ves_icall_System_Diagnostics_Debugger_IsAttached_internal,
// token 34183,
ves_icall_System_Diagnostics_Debugger_IsLogging,
// token 34185,
ves_icall_System_Diagnostics_Debugger_Log,
// token 34191,
ves_icall_System_Diagnostics_StackFrame_GetFrameInfo,
// token 34207,
ves_icall_System_Diagnostics_StackTrace_GetTrace,
// token 36800,
ves_icall_Mono_RuntimeClassHandle_GetTypeFromClass,
// token 36821,
ves_icall_Mono_RuntimeGPtrArrayHandle_GPtrArrayFree,
// token 36823,
ves_icall_Mono_SafeStringMarshal_StringToUtf8,
// token 36825,
ves_icall_Mono_SafeStringMarshal_GFree,
};
static uint8_t corlib_icall_flags [] = {
0,
0,
0,
0,
0,
0,
0,
0,
0,
4,
4,
0,
4,
0,
4,
4,
4,
0,
0,
0,
4,
4,
4,
4,
0,
4,
0,
0,
0,
0,
0,
0,
4,
4,
0,
0,
0,
0,
0,
4,
4,
0,
4,
4,
0,
4,
4,
0,
0,
4,
4,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
0,
4,
4,
4,
4,
4,
4,
4,
0,
4,
4,
0,
0,
4,
4,
0,
0,
4,
4,
4,
4,
4,
4,
4,
4,
0,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
4,
4,
4,
4,
4,
4,
0,
4,
4,
4,
0,
4,
4,
4,
4,
4,
0,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
0,
0,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
0,
4,
4,
4,
4,
4,
4,
4,
0,
0,
4,
4,
4,
4,
4,
0,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
0,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
0,
4,
0,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
0,
0,
0,
0,
0,
0,
0,
0,
0,
};
