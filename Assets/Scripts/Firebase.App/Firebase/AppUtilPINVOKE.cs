using System;
using System.Runtime.InteropServices;

namespace Firebase
{
	internal class AppUtilPINVOKE
	{
		protected class SWIGExceptionHelper
		{
			public delegate void ExceptionDelegate(string message);

			public delegate void ExceptionArgumentDelegate(string message, string paramName);

			private static ExceptionDelegate applicationDelegate;

			private static ExceptionDelegate arithmeticDelegate;

			private static ExceptionDelegate divideByZeroDelegate;

			private static ExceptionDelegate indexOutOfRangeDelegate;

			private static ExceptionDelegate invalidCastDelegate;

			private static ExceptionDelegate invalidOperationDelegate;

			private static ExceptionDelegate ioDelegate;

			private static ExceptionDelegate nullReferenceDelegate;

			private static ExceptionDelegate outOfMemoryDelegate;

			private static ExceptionDelegate overflowDelegate;

			private static ExceptionDelegate systemDelegate;

			private static ExceptionArgumentDelegate argumentDelegate;

			private static ExceptionArgumentDelegate argumentNullDelegate;

			private static ExceptionArgumentDelegate argumentOutOfRangeDelegate;

			[PreserveSig]
			public static extern void SWIGRegisterExceptionCallbacks_AppUtil(ExceptionDelegate applicationDelegate, ExceptionDelegate arithmeticDelegate, ExceptionDelegate divideByZeroDelegate, ExceptionDelegate indexOutOfRangeDelegate, ExceptionDelegate invalidCastDelegate, ExceptionDelegate invalidOperationDelegate, ExceptionDelegate ioDelegate, ExceptionDelegate nullReferenceDelegate, ExceptionDelegate outOfMemoryDelegate, ExceptionDelegate overflowDelegate, ExceptionDelegate systemExceptionDelegate);

			[PreserveSig]
			public static extern void SWIGRegisterExceptionCallbacksArgument_AppUtil(ExceptionArgumentDelegate argumentDelegate, ExceptionArgumentDelegate argumentNullDelegate, ExceptionArgumentDelegate argumentOutOfRangeDelegate);

			[MonoPInvokeCallback(typeof(ExceptionDelegate))]
			private static void SetPendingApplicationException(string message)
			{
			}

			[MonoPInvokeCallback(typeof(ExceptionDelegate))]
			private static void SetPendingArithmeticException(string message)
			{
			}

			[MonoPInvokeCallback(typeof(ExceptionDelegate))]
			private static void SetPendingDivideByZeroException(string message)
			{
			}

			[MonoPInvokeCallback(typeof(ExceptionDelegate))]
			private static void SetPendingIndexOutOfRangeException(string message)
			{
			}

			[MonoPInvokeCallback(typeof(ExceptionDelegate))]
			private static void SetPendingInvalidCastException(string message)
			{
			}

			[MonoPInvokeCallback(typeof(ExceptionDelegate))]
			private static void SetPendingInvalidOperationException(string message)
			{
			}

			[MonoPInvokeCallback(typeof(ExceptionDelegate))]
			private static void SetPendingIOException(string message)
			{
			}

			[MonoPInvokeCallback(typeof(ExceptionDelegate))]
			private static void SetPendingNullReferenceException(string message)
			{
			}

			[MonoPInvokeCallback(typeof(ExceptionDelegate))]
			private static void SetPendingOutOfMemoryException(string message)
			{
			}

			[MonoPInvokeCallback(typeof(ExceptionDelegate))]
			private static void SetPendingOverflowException(string message)
			{
			}

			[MonoPInvokeCallback(typeof(ExceptionDelegate))]
			private static void SetPendingSystemException(string message)
			{
			}

			[MonoPInvokeCallback(typeof(ExceptionArgumentDelegate))]
			private static void SetPendingArgumentException(string message, string paramName)
			{
			}

			[MonoPInvokeCallback(typeof(ExceptionArgumentDelegate))]
			private static void SetPendingArgumentNullException(string message, string paramName)
			{
			}

			[MonoPInvokeCallback(typeof(ExceptionArgumentDelegate))]
			private static void SetPendingArgumentOutOfRangeException(string message, string paramName)
			{
			}

			static SWIGExceptionHelper()
			{
			}
		}

		public class SWIGPendingException
		{
			[ThreadStatic]
			private static Exception pendingException;

			private static int numExceptionsPending;

			private static object exceptionsLock;

			public static bool Pending => false;

			public static void Set(Exception e)
			{
			}

			public static Exception Retrieve()
			{
				return null;
			}

			static SWIGPendingException()
			{
			}
		}

		protected class SWIGStringHelper
		{
			public delegate string SWIGStringDelegate(string message);

			private static SWIGStringDelegate stringDelegate;

			[PreserveSig]
			public static extern void SWIGRegisterStringCallback_AppUtil(SWIGStringDelegate stringDelegate);

			[MonoPInvokeCallback(typeof(SWIGStringDelegate))]
			private static string CreateString(string cString)
			{
				return null;
			}

			static SWIGStringHelper()
			{
			}
		}

		protected static SWIGExceptionHelper swigExceptionHelper;

		protected static SWIGStringHelper swigStringHelper;

		static AppUtilPINVOKE()
		{
		}

		[PreserveSig]
		public static extern void ExportFix();

		[PreserveSig]
		public static extern IntPtr new_FutureBase__SWIG_0();

		[PreserveSig]
		public static extern void delete_FutureBase(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr new_FutureBase__SWIG_1(HandleRef jarg1);

		[PreserveSig]
		public static extern void FutureBase_Release(HandleRef jarg1);

		[PreserveSig]
		public static extern int FutureBase_status(HandleRef jarg1);

		[PreserveSig]
		public static extern int FutureBase_error(HandleRef jarg1);

		[PreserveSig]
		public static extern string FutureBase_error_message(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr new_StringStringMap__SWIG_0();

		[PreserveSig]
		public static extern IntPtr new_StringStringMap__SWIG_1(HandleRef jarg1);

		[PreserveSig]
		public static extern uint StringStringMap_size(HandleRef jarg1);

		[PreserveSig]
		public static extern bool StringStringMap_empty(HandleRef jarg1);

		[PreserveSig]
		public static extern void StringStringMap_Clear(HandleRef jarg1);

		[PreserveSig]
		public static extern string StringStringMap_getitem(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern void StringStringMap_setitem(HandleRef jarg1, string jarg2, string jarg3);

		[PreserveSig]
		public static extern bool StringStringMap_ContainsKey(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern void StringStringMap_Add(HandleRef jarg1, string jarg2, string jarg3);

		[PreserveSig]
		public static extern bool StringStringMap_Remove(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern IntPtr StringStringMap_create_iterator_begin(HandleRef jarg1);

		[PreserveSig]
		public static extern string StringStringMap_get_next_key(HandleRef jarg1, IntPtr jarg2);

		[PreserveSig]
		public static extern void StringStringMap_destroy_iterator(HandleRef jarg1, IntPtr jarg2);

		[PreserveSig]
		public static extern void delete_StringStringMap(HandleRef jarg1);

		[PreserveSig]
		public static extern void StringList_Clear(HandleRef jarg1);

		[PreserveSig]
		public static extern void StringList_Add(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern uint StringList_size(HandleRef jarg1);

		[PreserveSig]
		public static extern uint StringList_capacity(HandleRef jarg1);

		[PreserveSig]
		public static extern void StringList_reserve(HandleRef jarg1, uint jarg2);

		[PreserveSig]
		public static extern IntPtr new_StringList__SWIG_0();

		[PreserveSig]
		public static extern IntPtr new_StringList__SWIG_1(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr new_StringList__SWIG_2(int jarg1);

		[PreserveSig]
		public static extern string StringList_getitemcopy(HandleRef jarg1, int jarg2);

		[PreserveSig]
		public static extern string StringList_getitem(HandleRef jarg1, int jarg2);

		[PreserveSig]
		public static extern void StringList_setitem(HandleRef jarg1, int jarg2, string jarg3);

		[PreserveSig]
		public static extern void StringList_AddRange(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern IntPtr StringList_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[PreserveSig]
		public static extern void StringList_Insert(HandleRef jarg1, int jarg2, string jarg3);

		[PreserveSig]
		public static extern void StringList_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern void StringList_RemoveAt(HandleRef jarg1, int jarg2);

		[PreserveSig]
		public static extern void StringList_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[PreserveSig]
		public static extern IntPtr StringList_Repeat(string jarg1, int jarg2);

		[PreserveSig]
		public static extern void StringList_Reverse__SWIG_0(HandleRef jarg1);

		[PreserveSig]
		public static extern void StringList_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[PreserveSig]
		public static extern void StringList_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern bool StringList_Contains(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern int StringList_IndexOf(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern int StringList_LastIndexOf(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern bool StringList_Remove(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern void delete_StringList(HandleRef jarg1);

		[PreserveSig]
		public static extern void CharVector_Clear(HandleRef jarg1);

		[PreserveSig]
		public static extern void CharVector_Add(HandleRef jarg1, byte jarg2);

		[PreserveSig]
		public static extern uint CharVector_size(HandleRef jarg1);

		[PreserveSig]
		public static extern uint CharVector_capacity(HandleRef jarg1);

		[PreserveSig]
		public static extern void CharVector_reserve(HandleRef jarg1, uint jarg2);

		[PreserveSig]
		public static extern IntPtr new_CharVector__SWIG_0();

		[PreserveSig]
		public static extern IntPtr new_CharVector__SWIG_1(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr new_CharVector__SWIG_2(int jarg1);

		[PreserveSig]
		public static extern byte CharVector_getitemcopy(HandleRef jarg1, int jarg2);

		[PreserveSig]
		public static extern byte CharVector_getitem(HandleRef jarg1, int jarg2);

		[PreserveSig]
		public static extern void CharVector_setitem(HandleRef jarg1, int jarg2, byte jarg3);

		[PreserveSig]
		public static extern void CharVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern IntPtr CharVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[PreserveSig]
		public static extern void CharVector_Insert(HandleRef jarg1, int jarg2, byte jarg3);

		[PreserveSig]
		public static extern void CharVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern void CharVector_RemoveAt(HandleRef jarg1, int jarg2);

		[PreserveSig]
		public static extern void CharVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[PreserveSig]
		public static extern IntPtr CharVector_Repeat(byte jarg1, int jarg2);

		[PreserveSig]
		public static extern void CharVector_Reverse__SWIG_0(HandleRef jarg1);

		[PreserveSig]
		public static extern void CharVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[PreserveSig]
		public static extern void CharVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern bool CharVector_Contains(HandleRef jarg1, byte jarg2);

		[PreserveSig]
		public static extern int CharVector_IndexOf(HandleRef jarg1, byte jarg2);

		[PreserveSig]
		public static extern int CharVector_LastIndexOf(HandleRef jarg1, byte jarg2);

		[PreserveSig]
		public static extern bool CharVector_Remove(HandleRef jarg1, byte jarg2);

		[PreserveSig]
		public static extern void delete_CharVector(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr new_FutureString();

		[PreserveSig]
		public static extern IntPtr FutureString_SWIG_OnCompletion(HandleRef jarg1, FutureString.SWIG_CompletionDelegate jarg2, int jarg3);

		[PreserveSig]
		public static extern void FutureString_SWIG_FreeCompletionData(HandleRef jarg1, IntPtr jarg2);

		[PreserveSig]
		public static extern string FutureString_GetResult(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_FutureString(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr new_FutureVoid();

		[PreserveSig]
		public static extern IntPtr FutureVoid_SWIG_OnCompletion(HandleRef jarg1, FutureVoid.SWIG_CompletionDelegate jarg2, int jarg3);

		[PreserveSig]
		public static extern void FutureVoid_SWIG_FreeCompletionData(HandleRef jarg1, IntPtr jarg2);

		[PreserveSig]
		public static extern void delete_FutureVoid(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr new_FutureBool();

		[PreserveSig]
		public static extern IntPtr FutureBool_SWIG_OnCompletion(HandleRef jarg1, FutureBool.SWIG_CompletionDelegate jarg2, int jarg3);

		[PreserveSig]
		public static extern void FutureBool_SWIG_FreeCompletionData(HandleRef jarg1, IntPtr jarg2);

		[PreserveSig]
		public static extern bool FutureBool_GetResult(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_FutureBool(HandleRef jarg1);

		[PreserveSig]
		internal static extern IntPtr new_AppOptionsInternal();

		[PreserveSig]
		internal static extern void AppOptionsInternal_SetDatabaseUrlInternal(HandleRef jarg1, string jarg2);

		[PreserveSig]
		internal static extern string AppOptionsInternal_GetDatabaseUrlInternal(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr AppOptionsInternal_LoadFromJsonConfig__SWIG_0(string jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern IntPtr AppOptionsInternal_LoadFromJsonConfig__SWIG_1(string jarg1);

		[PreserveSig]
		public static extern void AppOptionsInternal_AppId_set(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern string AppOptionsInternal_AppId_get(HandleRef jarg1);

		[PreserveSig]
		public static extern void AppOptionsInternal_ApiKey_set(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern string AppOptionsInternal_ApiKey_get(HandleRef jarg1);

		[PreserveSig]
		public static extern void AppOptionsInternal_MessageSenderId_set(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern string AppOptionsInternal_MessageSenderId_get(HandleRef jarg1);

		[PreserveSig]
		public static extern void AppOptionsInternal_StorageBucket_set(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern string AppOptionsInternal_StorageBucket_get(HandleRef jarg1);

		[PreserveSig]
		public static extern void AppOptionsInternal_ProjectId_set(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern string AppOptionsInternal_ProjectId_get(HandleRef jarg1);

		[PreserveSig]
		public static extern void AppOptionsInternal_PackageName_set(HandleRef jarg1, string jarg2);

		[PreserveSig]
		public static extern string AppOptionsInternal_PackageName_get(HandleRef jarg1);

		[PreserveSig]
		internal static extern void delete_AppOptionsInternal(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_FirebaseApp(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr FirebaseApp_options(HandleRef jarg1);

		[PreserveSig]
		internal static extern void FirebaseApp_SetDataCollectionDefaultEnabledInternal(HandleRef jarg1, bool jarg2);

		[PreserveSig]
		internal static extern bool FirebaseApp_IsDataCollectionDefaultEnabledInternal(HandleRef jarg1);

		[PreserveSig]
		public static extern string FirebaseApp_NameInternal_get(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr FirebaseApp_CreateInternal__SWIG_0();

		[PreserveSig]
		public static extern IntPtr FirebaseApp_CreateInternal__SWIG_1(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr FirebaseApp_CreateInternal__SWIG_2(HandleRef jarg1, string jarg2);

		[PreserveSig]
		internal static extern void FirebaseApp_ReleaseReferenceInternal(HandleRef jarg1);

		[PreserveSig]
		internal static extern void FirebaseApp_SetLogLevelInternal(int jarg1);

		[PreserveSig]
		internal static extern int FirebaseApp_GetLogLevelInternal();

		[PreserveSig]
		internal static extern void FirebaseApp_RegisterLibraryInternal(string jarg1, string jarg2);

		[PreserveSig]
		internal static extern void FirebaseApp_LogHeartbeatInternal(HandleRef jarg1);

		[PreserveSig]
		public static extern void FirebaseApp_AppSetDefaultConfigPath(string jarg1);

		[PreserveSig]
		public static extern string FirebaseApp_DefaultName_get();

		[PreserveSig]
		public static extern void SetLogLevel(int jarg1);

		[PreserveSig]
		public static extern int GetLogLevel();

		[PreserveSig]
		public static extern void PollCallbacks();

		[PreserveSig]
		public static extern void AppEnableLogCallback(bool jarg1);

		[PreserveSig]
		public static extern int AppGetLogLevel();

		[PreserveSig]
		public static extern void SetEnabledAllAppCallbacks(bool jarg1);

		[PreserveSig]
		public static extern void SetEnabledAppCallbackByName(string jarg1, bool jarg2);

		[PreserveSig]
		public static extern bool GetEnabledAppCallbackByName(string jarg1);

		[PreserveSig]
		public static extern void SetLogFunction(LogUtil.LogMessageDelegate jarg1);

		[PreserveSig]
		public static extern IntPtr AppOptionsLoadFromJsonConfig(string jarg1);

		[PreserveSig]
		public static extern int CheckAndroidDependencies();

		[PreserveSig]
		public static extern IntPtr FixAndroidDependencies();

		[PreserveSig]
		internal static extern void InitializePlayServicesInternal();

		[PreserveSig]
		internal static extern void TerminatePlayServicesInternal();

		[PreserveSig]
		public static extern IntPtr new_VariantVariantMap__SWIG_0();

		[PreserveSig]
		public static extern IntPtr new_VariantVariantMap__SWIG_1(HandleRef jarg1);

		[PreserveSig]
		public static extern uint VariantVariantMap_size(HandleRef jarg1);

		[PreserveSig]
		public static extern bool VariantVariantMap_empty(HandleRef jarg1);

		[PreserveSig]
		public static extern void VariantVariantMap_Clear(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr VariantVariantMap_getitem(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern void VariantVariantMap_setitem(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern bool VariantVariantMap_ContainsKey(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern void VariantVariantMap_Add(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern bool VariantVariantMap_Remove(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern IntPtr VariantVariantMap_create_iterator_begin(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr VariantVariantMap_get_next_key(HandleRef jarg1, IntPtr jarg2);

		[PreserveSig]
		public static extern void VariantVariantMap_destroy_iterator(HandleRef jarg1, IntPtr jarg2);

		[PreserveSig]
		public static extern void delete_VariantVariantMap(HandleRef jarg1);

		[PreserveSig]
		public static extern void VariantList_Clear(HandleRef jarg1);

		[PreserveSig]
		public static extern void VariantList_Add(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern uint VariantList_size(HandleRef jarg1);

		[PreserveSig]
		public static extern uint VariantList_capacity(HandleRef jarg1);

		[PreserveSig]
		public static extern void VariantList_reserve(HandleRef jarg1, uint jarg2);

		[PreserveSig]
		public static extern IntPtr new_VariantList__SWIG_0();

		[PreserveSig]
		public static extern IntPtr new_VariantList__SWIG_1(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr new_VariantList__SWIG_2(int jarg1);

		[PreserveSig]
		public static extern IntPtr VariantList_getitemcopy(HandleRef jarg1, int jarg2);

		[PreserveSig]
		public static extern IntPtr VariantList_getitem(HandleRef jarg1, int jarg2);

		[PreserveSig]
		public static extern void VariantList_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern void VariantList_AddRange(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		public static extern IntPtr VariantList_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[PreserveSig]
		public static extern void VariantList_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern void VariantList_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern void VariantList_RemoveAt(HandleRef jarg1, int jarg2);

		[PreserveSig]
		public static extern void VariantList_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[PreserveSig]
		public static extern IntPtr VariantList_Repeat(HandleRef jarg1, int jarg2);

		[PreserveSig]
		public static extern void VariantList_Reverse__SWIG_0(HandleRef jarg1);

		[PreserveSig]
		public static extern void VariantList_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[PreserveSig]
		public static extern void VariantList_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[PreserveSig]
		public static extern void delete_VariantList(HandleRef jarg1);

		[PreserveSig]
		public static extern void delete_Variant(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr Variant_Null();

		[PreserveSig]
		public static extern IntPtr Variant_EmptyVector();

		[PreserveSig]
		public static extern IntPtr Variant_EmptyMap();

		[PreserveSig]
		public static extern IntPtr Variant_EmptyMutableBlob(uint jarg1);

		[PreserveSig]
		public static extern int Variant_type(HandleRef jarg1);

		[PreserveSig]
		public static extern bool Variant_is_string(HandleRef jarg1);

		[PreserveSig]
		public static extern bool Variant_is_fundamental_type(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr Variant_AsString(HandleRef jarg1);

		[PreserveSig]
		public static extern uint Variant_blob_size(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr Variant_vector__SWIG_0(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr Variant_map__SWIG_0(HandleRef jarg1);

		[PreserveSig]
		public static extern long Variant_int64_value(HandleRef jarg1);

		[PreserveSig]
		public static extern double Variant_double_value(HandleRef jarg1);

		[PreserveSig]
		public static extern bool Variant_bool_value(HandleRef jarg1);

		[PreserveSig]
		public static extern string Variant_string_value(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr Variant_FromInt64(long jarg1);

		[PreserveSig]
		public static extern IntPtr Variant_FromDouble(double jarg1);

		[PreserveSig]
		public static extern IntPtr Variant_FromBool(bool jarg1);

		[PreserveSig]
		public static extern IntPtr Variant_FromString(string jarg1);

		[PreserveSig]
		public static extern IntPtr Variant_untyped_mutable_blob_data(HandleRef jarg1);

		[PreserveSig]
		public static extern IntPtr FutureString_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr FutureVoid_SWIGUpcast(IntPtr jarg1);

		[PreserveSig]
		public static extern IntPtr FutureBool_SWIGUpcast(IntPtr jarg1);
	}
}
