// GENERATED FILE, DO NOT MODIFY");


uint32_t CompressionNative_Crc32 (uint32_t, void *, int32_t);

int32_t CompressionNative_Deflate (void *, int32_t);

int32_t CompressionNative_DeflateEnd (void *);

int32_t CompressionNative_DeflateInit2_ (void *, int32_t, int32_t, int32_t, int32_t, int32_t);

int32_t CompressionNative_Inflate (void *, int32_t);

int32_t CompressionNative_InflateEnd (void *);

int32_t CompressionNative_InflateInit2_ (void *, int32_t);

void GlobalizationNative_ChangeCase (void *, int32_t, void *, int32_t, int32_t);

void GlobalizationNative_ChangeCaseInvariant (void *, int32_t, void *, int32_t, int32_t);

void GlobalizationNative_ChangeCaseTurkish (void *, int32_t, void *, int32_t, int32_t);

void GlobalizationNative_CloseSortHandle (void *);

int32_t GlobalizationNative_CompareString (void *, void *, int32_t, void *, int32_t, int32_t);

int32_t GlobalizationNative_EndsWith (void *, void *, int32_t, void *, int32_t, int32_t, void *);

int32_t GlobalizationNative_EnumCalendarInfo (void *, void *, uint32_t, int32_t, void *);

int32_t GlobalizationNative_GetCalendarInfo (void *, uint32_t, int32_t, void *, int32_t);

int32_t GlobalizationNative_GetCalendars (void *, void *, int32_t);

int32_t GlobalizationNative_GetDefaultLocaleName (void *, int32_t);

int32_t GlobalizationNative_GetICUVersion ();

int32_t GlobalizationNative_GetJapaneseEraStartDate (int32_t, void *, void *, void *);

int32_t GlobalizationNative_GetLatestJapaneseEra ();

int32_t GlobalizationNative_GetLocaleInfoGroupingSizes (void *, uint32_t, void *, void *);

int32_t GlobalizationNative_GetLocaleInfoInt (void *, uint32_t, void *);

int32_t GlobalizationNative_GetLocaleInfoString (void *, uint32_t, void *, int32_t, void *);

int32_t GlobalizationNative_GetLocaleName (void *, void *, int32_t);

int32_t GlobalizationNative_GetLocales (void *, int32_t);

int32_t GlobalizationNative_GetLocaleTimeFormat (void *, int32_t, void *, int32_t);

int32_t GlobalizationNative_GetSortHandle (void *, void *);

int32_t GlobalizationNative_GetSortKey (void *, void *, int32_t, void *, int32_t, int32_t);

int32_t GlobalizationNative_GetSortVersion (void *);

int32_t GlobalizationNative_IndexOf (void *, void *, int32_t, void *, int32_t, int32_t, void *);

void GlobalizationNative_InitICUFunctions (void *, void *, void *, void *);

void GlobalizationNative_InitOrdinalCasingPage (int32_t, void *);

int32_t GlobalizationNative_IsNormalized (int32_t, void *, int32_t);

int32_t GlobalizationNative_IsPredefinedLocale (void *);

int32_t GlobalizationNative_LastIndexOf (void *, void *, int32_t, void *, int32_t, int32_t, void *);

int32_t GlobalizationNative_LoadICU ();

int32_t GlobalizationNative_NormalizeString (int32_t, void *, int32_t, void *, int32_t);

int32_t GlobalizationNative_StartsWith (void *, void *, int32_t, void *, int32_t, int32_t, void *);

int32_t GlobalizationNative_ToAscii (uint32_t, void *, int32_t, void *, int32_t);

int32_t GlobalizationNative_ToUnicode (uint32_t, void *, int32_t, void *, int32_t);

void * sqlite3_aggregate_context (void *, int32_t);

int32_t sqlite3_aggregate_count (void *);

int32_t sqlite3_backup_finish (void *);

void * sqlite3_backup_init (void *, void *, void *, void *);

int32_t sqlite3_backup_pagecount (void *);

int32_t sqlite3_backup_remaining (void *);

int32_t sqlite3_backup_step (void *, int32_t);

int32_t sqlite3_bind_blob (void *, int32_t, void *, int32_t, void *);

int32_t sqlite3_bind_double (void *, int32_t, double);

int32_t sqlite3_bind_int (void *, int32_t, int32_t);

int32_t sqlite3_bind_int64 (void *, int32_t, int64_t);

int32_t sqlite3_bind_null (void *, int32_t);

int32_t sqlite3_bind_parameter_count (void *);

int32_t sqlite3_bind_parameter_index (void *, void *);

void * sqlite3_bind_parameter_name (void *, int32_t);

int32_t sqlite3_bind_text (void *, int32_t, void *, int32_t, void *);

int32_t sqlite3_bind_text16 (void *, int32_t, void *, int32_t, void *);

int32_t sqlite3_bind_zeroblob (void *, int32_t, int32_t);

int32_t sqlite3_blob_bytes (void *);

int32_t sqlite3_blob_close (void *);

int32_t sqlite3_blob_open (void *, void *, void *, void *, int64_t, int32_t, void *);

int32_t sqlite3_blob_read (void *, void *, int32_t, int32_t);

int32_t sqlite3_blob_reopen (void *, int64_t);

int32_t sqlite3_blob_write (void *, void *, int32_t, int32_t);

int32_t sqlite3_busy_timeout (void *, int32_t);

int32_t sqlite3_changes (void *);

int32_t sqlite3_clear_bindings (void *);

int32_t sqlite3_close (void *);

int32_t sqlite3_close_v2 (void *);

void * sqlite3_column_blob (void *, int32_t);

int32_t sqlite3_column_bytes (void *, int32_t);

int32_t sqlite3_column_count (void *);

void * sqlite3_column_database_name (void *, int32_t);

void * sqlite3_column_decltype (void *, int32_t);

double sqlite3_column_double (void *, int32_t);

int32_t sqlite3_column_int (void *, int32_t);

int64_t sqlite3_column_int64 (void *, int32_t);

void * sqlite3_column_name (void *, int32_t);

void * sqlite3_column_origin_name (void *, int32_t);

void * sqlite3_column_table_name (void *, int32_t);

void * sqlite3_column_text (void *, int32_t);

int32_t sqlite3_column_type (void *, int32_t);

void * sqlite3_commit_hook (void *, void *, void *);

void * sqlite3_compileoption_get (int32_t);

int32_t sqlite3_compileoption_used (void *);

int32_t sqlite3_complete (void *);

int32_t sqlite3_create_collation (void *, void *, int32_t, void *, void *);

int32_t sqlite3_create_function_v2 (void *, void *, int32_t, int32_t, void *, void *, void *, void *, void *);

int32_t sqlite3_data_count (void *);

void * sqlite3_db_filename (void *, void *);

void * sqlite3_db_handle (void *);

int32_t sqlite3_db_readonly (void *, void *);

int32_t sqlite3_db_status (void *, int32_t, void *, void *, int32_t);

int32_t sqlite3_deserialize (void *, void *, void *, int64_t, int64_t, int32_t);

int32_t sqlite3_enable_load_extension (void *, int32_t);

int32_t sqlite3_enable_shared_cache (int32_t);

int32_t sqlite3_errcode (void *);

void * sqlite3_errmsg (void *);

void * sqlite3_errstr (int32_t);

int32_t sqlite3_exec (void *, void *, void *, void *, void *);

int32_t sqlite3_extended_errcode (void *);

int32_t sqlite3_extended_result_codes (void *, int32_t);

int32_t sqlite3_file_control (void *, void *, int32_t, void *);

int32_t sqlite3_finalize (void *);

void sqlite3_free (void *);

int32_t sqlite3_get_autocommit (void *);

int64_t sqlite3_hard_heap_limit64 (int64_t);

int32_t sqlite3_initialize ();

void sqlite3_interrupt (void *);

int32_t sqlite3_keyword_count ();

int32_t sqlite3_keyword_name (int32_t, void *, void *);

int64_t sqlite3_last_insert_rowid (void *);

void * sqlite3_libversion ();

int32_t sqlite3_libversion_number ();

int32_t sqlite3_limit (void *, int32_t, int32_t);

int32_t sqlite3_load_extension (void *, void *, void *, void *);

void sqlite3_log (int32_t, void *);

void * sqlite3_malloc (int32_t);

void * sqlite3_malloc64 (int64_t);

int64_t sqlite3_memory_highwater (int32_t);

int64_t sqlite3_memory_used ();

void * sqlite3_next_stmt (void *, void *);

int32_t sqlite3_open (void *, void *);

int32_t sqlite3_open_v2 (void *, void *, int32_t, void *);

int32_t sqlite3_prepare_v2 (void *, void *, int32_t, void *, void *);

int32_t sqlite3_prepare_v3 (void *, void *, int32_t, uint32_t, void *, void *);

void * sqlite3_profile (void *, void *, void *);

void sqlite3_progress_handler (void *, int32_t, void *, void *);

void * sqlite3_realloc (void *, int32_t);

int32_t sqlite3_reset (void *);

void sqlite3_result_blob (void *, void *, int32_t, void *);

void sqlite3_result_double (void *, double);

void sqlite3_result_error (void *, void *, int32_t);

void sqlite3_result_error_code (void *, int32_t);

void sqlite3_result_error_nomem (void *);

void sqlite3_result_error_toobig (void *);

void sqlite3_result_int (void *, int32_t);

void sqlite3_result_int64 (void *, int64_t);

void sqlite3_result_null (void *);

void sqlite3_result_text (void *, void *, int32_t, void *);

void sqlite3_result_zeroblob (void *, int32_t);

void * sqlite3_rollback_hook (void *, void *, void *);

void * sqlite3_serialize (void *, void *, void *, int32_t);

int32_t sqlite3_set_authorizer (void *, void *, void *);

int32_t sqlite3_shutdown ();

int32_t sqlite3_snapshot_cmp (void *, void *);

void sqlite3_snapshot_free (void *);

int32_t sqlite3_snapshot_get (void *, void *, void *);

int32_t sqlite3_snapshot_open (void *, void *, void *);

int32_t sqlite3_snapshot_recover (void *, void *);

int64_t sqlite3_soft_heap_limit64 (int64_t);

void * sqlite3_sourceid ();

void * sqlite3_sql (void *);

int32_t sqlite3_status (int32_t, void *, void *, int32_t);

int32_t sqlite3_step (void *);

int32_t sqlite3_stmt_busy (void *);

int32_t sqlite3_stmt_isexplain (void *);

int32_t sqlite3_stmt_readonly (void *);

int32_t sqlite3_stmt_status (void *, int32_t, int32_t);

int32_t sqlite3_stricmp (void *, void *);

int32_t sqlite3_strnicmp (void *, void *, int32_t);

int32_t sqlite3_table_column_metadata (void *, void *, void *, void *, void *, void *, void *, void *, void *);

int32_t sqlite3_threadsafe ();

int32_t sqlite3_total_changes (void *);

void * sqlite3_trace (void *, void *, void *);

void * sqlite3_update_hook (void *, void *, void *);

void * sqlite3_user_data (void *);

void * sqlite3_value_blob (void *);

int32_t sqlite3_value_bytes (void *);

double sqlite3_value_double (void *);

int32_t sqlite3_value_int (void *);

int64_t sqlite3_value_int64 (void *);

void * sqlite3_value_text (void *);

int32_t sqlite3_value_type (void *);

void * sqlite3_vfs_find (void *);

int32_t sqlite3_wal_autocheckpoint (void *, int32_t);

int32_t sqlite3_wal_checkpoint (void *, void *);

int32_t sqlite3_wal_checkpoint_v2 (void *, void *, int32_t, void *, void *);

int32_t SystemNative_Access (void *, int32_t);

void * SystemNative_AlignedAlloc (void *, void *);

void SystemNative_AlignedFree (void *);

void * SystemNative_AlignedRealloc (void *, void *, void *);

void * SystemNative_Calloc (void *, void *);

int32_t SystemNative_CanGetHiddenFlag ();

int32_t SystemNative_ChDir (void *);

int32_t SystemNative_ChMod (void *, int32_t);

int32_t SystemNative_Close (void *);

int32_t SystemNative_CloseDir (void *);

int32_t SystemNative_ConvertErrorPalToPlatform (int32_t);

int32_t SystemNative_ConvertErrorPlatformToPal (int32_t);

int32_t SystemNative_CopyFile (void *, void *, int64_t);

void * SystemNative_Dup (void *);

int32_t SystemNative_FAllocate (void *, int64_t, int64_t);

int32_t SystemNative_FChflags (void *, uint32_t);

int32_t SystemNative_FChMod (void *, int32_t);

int32_t SystemNative_FcntlSetFD (void *, int32_t);

int32_t SystemNative_FLock (void *, int32_t);

void SystemNative_Free (void *);

void SystemNative_FreeEnviron (void *);

int32_t SystemNative_FStat (void *, void *);

int32_t SystemNative_FSync (void *);

int32_t SystemNative_FTruncate (void *, int64_t);

int32_t SystemNative_FUTimens (void *, void *);

int32_t SystemNative_GetAddressFamily (void *, int32_t, void *);

double SystemNative_GetCpuUtilization (void *);

int32_t SystemNative_GetCryptographicallySecureRandomBytes (void *, int32_t);

void * SystemNative_GetCwd (void *, int32_t);

void * SystemNative_GetDefaultSearchOrderPseudoHandle ();

void * SystemNative_GetEnv (void *);

void * SystemNative_GetEnviron ();

int32_t SystemNative_GetErrNo ();

uint32_t SystemNative_GetFileSystemType (void *);

int32_t SystemNative_GetIPv4Address (void *, int32_t, void *);

int32_t SystemNative_GetIPv6Address (void *, int32_t, void *, int32_t, void *);

void SystemNative_GetNonCryptographicallySecureRandomBytes (void *, int32_t);

int32_t SystemNative_GetPort (void *, int32_t, void *);

int32_t SystemNative_GetReadDirRBufferSize ();

int32_t SystemNative_GetSocketAddressSizes (void *, void *, void *, void *);

int64_t SystemNative_GetSystemTimeAsTicks ();

uint64_t SystemNative_GetTimestamp ();

void * SystemNative_GetTimeZoneData (void *, void *);

int32_t SystemNative_LChflags (void *, uint32_t);

int32_t SystemNative_LChflagsCanSetHiddenFlag ();

int32_t SystemNative_Link (void *, void *);

int32_t SystemNative_LockFileRegion (void *, int64_t, int64_t, int32_t);

void SystemNative_Log (void *, int32_t);

void SystemNative_LogError (void *, int32_t);

void SystemNative_LowLevelMonitor_Acquire (void *);

void * SystemNative_LowLevelMonitor_Create ();

void SystemNative_LowLevelMonitor_Destroy (void *);

void SystemNative_LowLevelMonitor_Release (void *);

void SystemNative_LowLevelMonitor_Signal_Release (void *);

int32_t SystemNative_LowLevelMonitor_TimedWait (void *, int32_t);

void SystemNative_LowLevelMonitor_Wait (void *);

int64_t SystemNative_LSeek (void *, int64_t, int32_t);

int32_t SystemNative_LStat (void *, void *);

int32_t SystemNative_MAdvise (void *, uint64_t, int32_t);

void * SystemNative_Malloc (void *);

int32_t SystemNative_MkDir (void *, int32_t);

void * SystemNative_MkdTemp (void *);

void * SystemNative_MksTemps (void *, int32_t);

void * SystemNative_MMap (void *, uint64_t, int32_t, int32_t, void *, int64_t);

int32_t SystemNative_MSync (void *, uint64_t, int32_t);

int32_t SystemNative_MUnmap (void *, uint64_t);

void * SystemNative_Open (void *, int32_t, int32_t);

void * SystemNative_OpenDir (void *);

int32_t SystemNative_PosixFAdvise (void *, int64_t, int64_t, int32_t);

int32_t SystemNative_PRead (void *, void *, int32_t, int64_t);

int64_t SystemNative_PReadV (void *, void *, int32_t, int64_t);

int32_t SystemNative_PWrite (void *, void *, int32_t, int64_t);

int64_t SystemNative_PWriteV (void *, void *, int32_t, int64_t);

int32_t SystemNative_Read (void *, void *, int32_t);

int32_t SystemNative_ReadDirR (void *, void *, int32_t, void *);

int32_t SystemNative_ReadLink (void *, void *, int32_t);

void * SystemNative_Realloc (void *, void *);

int32_t SystemNative_Rename (void *, void *);

int32_t SystemNative_RmDir (void *);

int32_t SystemNative_SchedGetCpu ();

int32_t SystemNative_SetAddressFamily (void *, int32_t, int32_t);

void SystemNative_SetErrNo (int32_t);

int32_t SystemNative_SetIPv4Address (void *, int32_t, uint32_t);

int32_t SystemNative_SetIPv6Address (void *, int32_t, void *, int32_t, uint32_t);

int32_t SystemNative_SetPort (void *, int32_t, uint32_t);

void * SystemNative_ShmOpen (void *, int32_t, int32_t);

int32_t SystemNative_ShmUnlink (void *);

int32_t SystemNative_Stat (void *, void *);

void * SystemNative_StrErrorR (int32_t, void *, int32_t);

int32_t SystemNative_SymLink (void *, void *);

int64_t SystemNative_SysConf (int32_t);

void SystemNative_SysLog (int32_t, void *, void *);

uint32_t SystemNative_TryGetUInt32OSThreadId ();

int32_t SystemNative_Unlink (void *);

int32_t SystemNative_UTimensat (void *, void *);

int32_t SystemNative_Write (void *, void *, int32_t);
static PinvokeImport e_sqlite3_imports [] = {
    {"sqlite3_aggregate_context", sqlite3_aggregate_context}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_aggregate_count", sqlite3_aggregate_count}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_backup_finish", sqlite3_backup_finish}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_backup_init", sqlite3_backup_init}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_backup_pagecount", sqlite3_backup_pagecount}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_backup_remaining", sqlite3_backup_remaining}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_backup_step", sqlite3_backup_step}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_bind_blob", sqlite3_bind_blob}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_bind_double", sqlite3_bind_double}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_bind_int", sqlite3_bind_int}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_bind_int64", sqlite3_bind_int64}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_bind_null", sqlite3_bind_null}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_bind_parameter_count", sqlite3_bind_parameter_count}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_bind_parameter_index", sqlite3_bind_parameter_index}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_bind_parameter_name", sqlite3_bind_parameter_name}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_bind_text", sqlite3_bind_text}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_bind_text16", sqlite3_bind_text16}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_bind_zeroblob", sqlite3_bind_zeroblob}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_blob_bytes", sqlite3_blob_bytes}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_blob_close", sqlite3_blob_close}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_blob_open", sqlite3_blob_open}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_blob_read", sqlite3_blob_read}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_blob_reopen", sqlite3_blob_reopen}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_blob_write", sqlite3_blob_write}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_busy_timeout", sqlite3_busy_timeout}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_changes", sqlite3_changes}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_clear_bindings", sqlite3_clear_bindings}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_close", sqlite3_close}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_close_v2", sqlite3_close_v2}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_column_blob", sqlite3_column_blob}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_column_bytes", sqlite3_column_bytes}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_column_count", sqlite3_column_count}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_column_database_name", sqlite3_column_database_name}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_column_decltype", sqlite3_column_decltype}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_column_double", sqlite3_column_double}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_column_int", sqlite3_column_int}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_column_int64", sqlite3_column_int64}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_column_name", sqlite3_column_name}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_column_origin_name", sqlite3_column_origin_name}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_column_table_name", sqlite3_column_table_name}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_column_text", sqlite3_column_text}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_column_type", sqlite3_column_type}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_commit_hook", sqlite3_commit_hook}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_compileoption_get", sqlite3_compileoption_get}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_compileoption_used", sqlite3_compileoption_used}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_complete", sqlite3_complete}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_create_collation", sqlite3_create_collation}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_create_function_v2", sqlite3_create_function_v2}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_data_count", sqlite3_data_count}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_db_filename", sqlite3_db_filename}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_db_handle", sqlite3_db_handle}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_db_readonly", sqlite3_db_readonly}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_db_status", sqlite3_db_status}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_deserialize", sqlite3_deserialize}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_enable_load_extension", sqlite3_enable_load_extension}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_enable_shared_cache", sqlite3_enable_shared_cache}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_errcode", sqlite3_errcode}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_errmsg", sqlite3_errmsg}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_errstr", sqlite3_errstr}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_exec", sqlite3_exec}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_extended_errcode", sqlite3_extended_errcode}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_extended_result_codes", sqlite3_extended_result_codes}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_file_control", sqlite3_file_control}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_finalize", sqlite3_finalize}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_free", sqlite3_free}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_get_autocommit", sqlite3_get_autocommit}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_hard_heap_limit64", sqlite3_hard_heap_limit64}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_initialize", sqlite3_initialize}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_interrupt", sqlite3_interrupt}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_keyword_count", sqlite3_keyword_count}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_keyword_name", sqlite3_keyword_name}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_last_insert_rowid", sqlite3_last_insert_rowid}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_libversion", sqlite3_libversion}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_libversion_number", sqlite3_libversion_number}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_limit", sqlite3_limit}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_load_extension", sqlite3_load_extension}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_log", sqlite3_log}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_malloc", sqlite3_malloc}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_malloc64", sqlite3_malloc64}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_memory_highwater", sqlite3_memory_highwater}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_memory_used", sqlite3_memory_used}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_next_stmt", sqlite3_next_stmt}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_open", sqlite3_open}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_open_v2", sqlite3_open_v2}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_prepare_v2", sqlite3_prepare_v2}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_prepare_v3", sqlite3_prepare_v3}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_profile", sqlite3_profile}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_progress_handler", sqlite3_progress_handler}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_realloc", sqlite3_realloc}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_reset", sqlite3_reset}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_result_blob", sqlite3_result_blob}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_result_double", sqlite3_result_double}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_result_error", sqlite3_result_error}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_result_error_code", sqlite3_result_error_code}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_result_error_nomem", sqlite3_result_error_nomem}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_result_error_toobig", sqlite3_result_error_toobig}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_result_int", sqlite3_result_int}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_result_int64", sqlite3_result_int64}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_result_null", sqlite3_result_null}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_result_text", sqlite3_result_text}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_result_zeroblob", sqlite3_result_zeroblob}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_rollback_hook", sqlite3_rollback_hook}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_serialize", sqlite3_serialize}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_set_authorizer", sqlite3_set_authorizer}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_shutdown", sqlite3_shutdown}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_snapshot_cmp", sqlite3_snapshot_cmp}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_snapshot_free", sqlite3_snapshot_free}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_snapshot_get", sqlite3_snapshot_get}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_snapshot_open", sqlite3_snapshot_open}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_snapshot_recover", sqlite3_snapshot_recover}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_soft_heap_limit64", sqlite3_soft_heap_limit64}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_sourceid", sqlite3_sourceid}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_sql", sqlite3_sql}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_status", sqlite3_status}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_step", sqlite3_step}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_stmt_busy", sqlite3_stmt_busy}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_stmt_isexplain", sqlite3_stmt_isexplain}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_stmt_readonly", sqlite3_stmt_readonly}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_stmt_status", sqlite3_stmt_status}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_stricmp", sqlite3_stricmp}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_strnicmp", sqlite3_strnicmp}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_table_column_metadata", sqlite3_table_column_metadata}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_threadsafe", sqlite3_threadsafe}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_total_changes", sqlite3_total_changes}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_trace", sqlite3_trace}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_update_hook", sqlite3_update_hook}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_user_data", sqlite3_user_data}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_value_blob", sqlite3_value_blob}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_value_bytes", sqlite3_value_bytes}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_value_double", sqlite3_value_double}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_value_int", sqlite3_value_int}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_value_int64", sqlite3_value_int64}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_value_text", sqlite3_value_text}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_value_type", sqlite3_value_type}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_vfs_find", sqlite3_vfs_find}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_wal_autocheckpoint", sqlite3_wal_autocheckpoint}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_wal_checkpoint", sqlite3_wal_checkpoint}, // SQLitePCLRaw.provider.e_sqlite3
    {"sqlite3_wal_checkpoint_v2", sqlite3_wal_checkpoint_v2}, // SQLitePCLRaw.provider.e_sqlite3
    {NULL, NULL}
};
static PinvokeImport libSystem_Native_imports [] = {
    {"SystemNative_Access", SystemNative_Access}, // System.Private.CoreLib
    {"SystemNative_AlignedAlloc", SystemNative_AlignedAlloc}, // System.Private.CoreLib
    {"SystemNative_AlignedFree", SystemNative_AlignedFree}, // System.Private.CoreLib
    {"SystemNative_AlignedRealloc", SystemNative_AlignedRealloc}, // System.Private.CoreLib
    {"SystemNative_Calloc", SystemNative_Calloc}, // System.Private.CoreLib
    {"SystemNative_CanGetHiddenFlag", SystemNative_CanGetHiddenFlag}, // System.Private.CoreLib
    {"SystemNative_ChDir", SystemNative_ChDir}, // System.Private.CoreLib
    {"SystemNative_ChMod", SystemNative_ChMod}, // System.Private.CoreLib
    {"SystemNative_Close", SystemNative_Close}, // System.Private.CoreLib
    {"SystemNative_CloseDir", SystemNative_CloseDir}, // System.Private.CoreLib
    {"SystemNative_ConvertErrorPalToPlatform", SystemNative_ConvertErrorPalToPlatform}, // System.Console, System.IO.Compression.ZipFile, System.IO.MemoryMappedFiles, System.Net.Primitives, System.Private.CoreLib
    {"SystemNative_ConvertErrorPlatformToPal", SystemNative_ConvertErrorPlatformToPal}, // System.Console, System.IO.Compression.ZipFile, System.IO.MemoryMappedFiles, System.Net.Primitives, System.Private.CoreLib
    {"SystemNative_CopyFile", SystemNative_CopyFile}, // System.Private.CoreLib
    {"SystemNative_Dup", SystemNative_Dup}, // System.Console
    {"SystemNative_FAllocate", SystemNative_FAllocate}, // System.Private.CoreLib
    {"SystemNative_FChflags", SystemNative_FChflags}, // System.Private.CoreLib
    {"SystemNative_FChMod", SystemNative_FChMod}, // System.Private.CoreLib
    {"SystemNative_FcntlSetFD", SystemNative_FcntlSetFD}, // System.IO.MemoryMappedFiles
    {"SystemNative_FLock", SystemNative_FLock}, // System.Private.CoreLib
    {"SystemNative_Free", SystemNative_Free}, // System.Private.CoreLib
    {"SystemNative_FreeEnviron", SystemNative_FreeEnviron}, // System.Private.CoreLib
    {"SystemNative_FStat", SystemNative_FStat}, // System.IO.Compression.ZipFile, System.IO.MemoryMappedFiles, System.Private.CoreLib
    {"SystemNative_FSync", SystemNative_FSync}, // System.Private.CoreLib
    {"SystemNative_FTruncate", SystemNative_FTruncate}, // System.IO.MemoryMappedFiles, System.Private.CoreLib
    {"SystemNative_FUTimens", SystemNative_FUTimens}, // System.Private.CoreLib
    {"SystemNative_GetAddressFamily", SystemNative_GetAddressFamily}, // System.Net.Primitives
    {"SystemNative_GetCpuUtilization", SystemNative_GetCpuUtilization}, // System.Private.CoreLib
    {"SystemNative_GetCryptographicallySecureRandomBytes", SystemNative_GetCryptographicallySecureRandomBytes}, // System.Private.CoreLib, System.Security.Cryptography
    {"SystemNative_GetCwd", SystemNative_GetCwd}, // System.Private.CoreLib
    {"SystemNative_GetDefaultSearchOrderPseudoHandle", SystemNative_GetDefaultSearchOrderPseudoHandle}, // System.Private.CoreLib
    {"SystemNative_GetEnv", SystemNative_GetEnv}, // System.Private.CoreLib
    {"SystemNative_GetEnviron", SystemNative_GetEnviron}, // System.Private.CoreLib
    {"SystemNative_GetErrNo", SystemNative_GetErrNo}, // System.Private.CoreLib
    {"SystemNative_GetFileSystemType", SystemNative_GetFileSystemType}, // System.Private.CoreLib
    {"SystemNative_GetIPv4Address", SystemNative_GetIPv4Address}, // System.Net.Primitives
    {"SystemNative_GetIPv6Address", SystemNative_GetIPv6Address}, // System.Net.Primitives
    {"SystemNative_GetNonCryptographicallySecureRandomBytes", SystemNative_GetNonCryptographicallySecureRandomBytes}, // System.Private.CoreLib
    {"SystemNative_GetPort", SystemNative_GetPort}, // System.Net.Primitives
    {"SystemNative_GetReadDirRBufferSize", SystemNative_GetReadDirRBufferSize}, // System.Private.CoreLib
    {"SystemNative_GetSocketAddressSizes", SystemNative_GetSocketAddressSizes}, // System.Net.Primitives
    {"SystemNative_GetSystemTimeAsTicks", SystemNative_GetSystemTimeAsTicks}, // System.Private.CoreLib
    {"SystemNative_GetTimestamp", SystemNative_GetTimestamp}, // System.Private.CoreLib
    {"SystemNative_GetTimeZoneData", SystemNative_GetTimeZoneData}, // System.Private.CoreLib
    {"SystemNative_LChflags", SystemNative_LChflags}, // System.Private.CoreLib
    {"SystemNative_LChflagsCanSetHiddenFlag", SystemNative_LChflagsCanSetHiddenFlag}, // System.Private.CoreLib
    {"SystemNative_Link", SystemNative_Link}, // System.Private.CoreLib
    {"SystemNative_LockFileRegion", SystemNative_LockFileRegion}, // System.Private.CoreLib
    {"SystemNative_Log", SystemNative_Log}, // System.Private.CoreLib
    {"SystemNative_LogError", SystemNative_LogError}, // System.Private.CoreLib
    {"SystemNative_LowLevelMonitor_Acquire", SystemNative_LowLevelMonitor_Acquire}, // System.Private.CoreLib
    {"SystemNative_LowLevelMonitor_Create", SystemNative_LowLevelMonitor_Create}, // System.Private.CoreLib
    {"SystemNative_LowLevelMonitor_Destroy", SystemNative_LowLevelMonitor_Destroy}, // System.Private.CoreLib
    {"SystemNative_LowLevelMonitor_Release", SystemNative_LowLevelMonitor_Release}, // System.Private.CoreLib
    {"SystemNative_LowLevelMonitor_Signal_Release", SystemNative_LowLevelMonitor_Signal_Release}, // System.Private.CoreLib
    {"SystemNative_LowLevelMonitor_TimedWait", SystemNative_LowLevelMonitor_TimedWait}, // System.Private.CoreLib
    {"SystemNative_LowLevelMonitor_Wait", SystemNative_LowLevelMonitor_Wait}, // System.Private.CoreLib
    {"SystemNative_LSeek", SystemNative_LSeek}, // System.Private.CoreLib
    {"SystemNative_LStat", SystemNative_LStat}, // System.Private.CoreLib
    {"SystemNative_MAdvise", SystemNative_MAdvise}, // System.IO.MemoryMappedFiles
    {"SystemNative_Malloc", SystemNative_Malloc}, // System.Private.CoreLib
    {"SystemNative_MkDir", SystemNative_MkDir}, // System.Private.CoreLib
    {"SystemNative_MkdTemp", SystemNative_MkdTemp}, // System.Private.CoreLib
    {"SystemNative_MksTemps", SystemNative_MksTemps}, // System.Private.CoreLib
    {"SystemNative_MMap", SystemNative_MMap}, // System.IO.MemoryMappedFiles
    {"SystemNative_MSync", SystemNative_MSync}, // System.IO.MemoryMappedFiles
    {"SystemNative_MUnmap", SystemNative_MUnmap}, // System.IO.MemoryMappedFiles
    {"SystemNative_Open", SystemNative_Open}, // System.Private.CoreLib
    {"SystemNative_OpenDir", SystemNative_OpenDir}, // System.Private.CoreLib
    {"SystemNative_PosixFAdvise", SystemNative_PosixFAdvise}, // System.Private.CoreLib
    {"SystemNative_PRead", SystemNative_PRead}, // System.Private.CoreLib
    {"SystemNative_PReadV", SystemNative_PReadV}, // System.Private.CoreLib
    {"SystemNative_PWrite", SystemNative_PWrite}, // System.Private.CoreLib
    {"SystemNative_PWriteV", SystemNative_PWriteV}, // System.Private.CoreLib
    {"SystemNative_Read", SystemNative_Read}, // System.Private.CoreLib
    {"SystemNative_ReadDirR", SystemNative_ReadDirR}, // System.Private.CoreLib
    {"SystemNative_ReadLink", SystemNative_ReadLink}, // System.Private.CoreLib
    {"SystemNative_Realloc", SystemNative_Realloc}, // System.Private.CoreLib
    {"SystemNative_Rename", SystemNative_Rename}, // System.Private.CoreLib
    {"SystemNative_RmDir", SystemNative_RmDir}, // System.Private.CoreLib
    {"SystemNative_SchedGetCpu", SystemNative_SchedGetCpu}, // System.Private.CoreLib
    {"SystemNative_SetAddressFamily", SystemNative_SetAddressFamily}, // System.Net.Primitives
    {"SystemNative_SetErrNo", SystemNative_SetErrNo}, // System.Private.CoreLib
    {"SystemNative_SetIPv4Address", SystemNative_SetIPv4Address}, // System.Net.Primitives
    {"SystemNative_SetIPv6Address", SystemNative_SetIPv6Address}, // System.Net.Primitives
    {"SystemNative_SetPort", SystemNative_SetPort}, // System.Net.Primitives
    {"SystemNative_ShmOpen", SystemNative_ShmOpen}, // System.IO.MemoryMappedFiles
    {"SystemNative_ShmUnlink", SystemNative_ShmUnlink}, // System.IO.MemoryMappedFiles
    {"SystemNative_Stat", SystemNative_Stat}, // System.IO.Compression.ZipFile, System.Private.CoreLib
    {"SystemNative_StrErrorR", SystemNative_StrErrorR}, // System.Console, System.IO.Compression.ZipFile, System.IO.MemoryMappedFiles, System.Net.Primitives, System.Private.CoreLib
    {"SystemNative_SymLink", SystemNative_SymLink}, // System.Private.CoreLib
    {"SystemNative_SysConf", SystemNative_SysConf}, // System.IO.MemoryMappedFiles, System.Private.CoreLib
    {"SystemNative_SysLog", SystemNative_SysLog}, // System.Private.CoreLib
    {"SystemNative_TryGetUInt32OSThreadId", SystemNative_TryGetUInt32OSThreadId}, // System.Private.CoreLib
    {"SystemNative_Unlink", SystemNative_Unlink}, // System.IO.MemoryMappedFiles, System.Private.CoreLib
    {"SystemNative_UTimensat", SystemNative_UTimensat}, // System.Private.CoreLib
    {"SystemNative_Write", SystemNative_Write}, // System.Console, System.Private.CoreLib
    {NULL, NULL}
};
static PinvokeImport libSystem_IO_Compression_Native_imports [] = {
    {"CompressionNative_Crc32", CompressionNative_Crc32}, // System.IO.Compression
    {"CompressionNative_Deflate", CompressionNative_Deflate}, // System.IO.Compression, System.Net.WebSockets
    {"CompressionNative_DeflateEnd", CompressionNative_DeflateEnd}, // System.IO.Compression, System.Net.WebSockets
    {"CompressionNative_DeflateInit2_", CompressionNative_DeflateInit2_}, // System.IO.Compression, System.Net.WebSockets
    {"CompressionNative_Inflate", CompressionNative_Inflate}, // System.IO.Compression, System.Net.WebSockets
    {"CompressionNative_InflateEnd", CompressionNative_InflateEnd}, // System.IO.Compression, System.Net.WebSockets
    {"CompressionNative_InflateInit2_", CompressionNative_InflateInit2_}, // System.IO.Compression, System.Net.WebSockets
    {NULL, NULL}
};
static PinvokeImport libSystem_Globalization_Native_imports [] = {
    {"GlobalizationNative_ChangeCase", GlobalizationNative_ChangeCase}, // System.Private.CoreLib
    {"GlobalizationNative_ChangeCaseInvariant", GlobalizationNative_ChangeCaseInvariant}, // System.Private.CoreLib
    {"GlobalizationNative_ChangeCaseTurkish", GlobalizationNative_ChangeCaseTurkish}, // System.Private.CoreLib
    {"GlobalizationNative_CloseSortHandle", GlobalizationNative_CloseSortHandle}, // System.Private.CoreLib
    {"GlobalizationNative_CompareString", GlobalizationNative_CompareString}, // System.Private.CoreLib
    {"GlobalizationNative_EndsWith", GlobalizationNative_EndsWith}, // System.Private.CoreLib
    {"GlobalizationNative_EnumCalendarInfo", GlobalizationNative_EnumCalendarInfo}, // System.Private.CoreLib
    {"GlobalizationNative_GetCalendarInfo", GlobalizationNative_GetCalendarInfo}, // System.Private.CoreLib
    {"GlobalizationNative_GetCalendars", GlobalizationNative_GetCalendars}, // System.Private.CoreLib
    {"GlobalizationNative_GetDefaultLocaleName", GlobalizationNative_GetDefaultLocaleName}, // System.Private.CoreLib
    {"GlobalizationNative_GetICUVersion", GlobalizationNative_GetICUVersion}, // System.Private.CoreLib
    {"GlobalizationNative_GetJapaneseEraStartDate", GlobalizationNative_GetJapaneseEraStartDate}, // System.Private.CoreLib
    {"GlobalizationNative_GetLatestJapaneseEra", GlobalizationNative_GetLatestJapaneseEra}, // System.Private.CoreLib
    {"GlobalizationNative_GetLocaleInfoGroupingSizes", GlobalizationNative_GetLocaleInfoGroupingSizes}, // System.Private.CoreLib
    {"GlobalizationNative_GetLocaleInfoInt", GlobalizationNative_GetLocaleInfoInt}, // System.Private.CoreLib
    {"GlobalizationNative_GetLocaleInfoString", GlobalizationNative_GetLocaleInfoString}, // System.Private.CoreLib
    {"GlobalizationNative_GetLocaleName", GlobalizationNative_GetLocaleName}, // System.Private.CoreLib
    {"GlobalizationNative_GetLocales", GlobalizationNative_GetLocales}, // System.Private.CoreLib
    {"GlobalizationNative_GetLocaleTimeFormat", GlobalizationNative_GetLocaleTimeFormat}, // System.Private.CoreLib
    {"GlobalizationNative_GetSortHandle", GlobalizationNative_GetSortHandle}, // System.Private.CoreLib
    {"GlobalizationNative_GetSortKey", GlobalizationNative_GetSortKey}, // System.Private.CoreLib
    {"GlobalizationNative_GetSortVersion", GlobalizationNative_GetSortVersion}, // System.Private.CoreLib
    {"GlobalizationNative_IndexOf", GlobalizationNative_IndexOf}, // System.Private.CoreLib
    {"GlobalizationNative_InitICUFunctions", GlobalizationNative_InitICUFunctions}, // System.Private.CoreLib
    {"GlobalizationNative_InitOrdinalCasingPage", GlobalizationNative_InitOrdinalCasingPage}, // System.Private.CoreLib
    {"GlobalizationNative_IsNormalized", GlobalizationNative_IsNormalized}, // System.Private.CoreLib
    {"GlobalizationNative_IsPredefinedLocale", GlobalizationNative_IsPredefinedLocale}, // System.Private.CoreLib
    {"GlobalizationNative_LastIndexOf", GlobalizationNative_LastIndexOf}, // System.Private.CoreLib
    {"GlobalizationNative_LoadICU", GlobalizationNative_LoadICU}, // System.Private.CoreLib
    {"GlobalizationNative_NormalizeString", GlobalizationNative_NormalizeString}, // System.Private.CoreLib
    {"GlobalizationNative_StartsWith", GlobalizationNative_StartsWith}, // System.Private.CoreLib
    {"GlobalizationNative_ToAscii", GlobalizationNative_ToAscii}, // System.Private.CoreLib
    {"GlobalizationNative_ToUnicode", GlobalizationNative_ToUnicode}, // System.Private.CoreLib
    {NULL, NULL}
};

static void *pinvoke_tables[] = {
    (void*)e_sqlite3_imports, (void*)libSystem_Native_imports, (void*)libSystem_IO_Compression_Native_imports, (void*)libSystem_Globalization_Native_imports
};

static char *pinvoke_names[] =  {
    "e_sqlite3", "libSystem.Native", "libSystem.IO.Compression.Native", "libSystem.Globalization.Native"
};
#include <mono/utils/details/mono-error-types.h>
                #include <mono/metadata/assembly.h>
                #include <mono/utils/mono-error.h>
                #include <mono/metadata/object.h>
                #include <mono/utils/details/mono-logger-types.h>
                #include "runtime.h"
                InterpFtnDesc wasm_native_to_interp_ftndescs[20] = {};
typedef void (*WasmInterpEntrySig_0) (int*, int*, int*, int*, int*, int*);
int32_t wasm_native_to_interp_SQLitePCL_SQLitePCLRaw_provider_e_sqlite3_SQLite3Provider_e_sqlite3_exec_hook_bridge_impl (void * arg0, int32_t arg1, void * arg2, void * arg3) { 
  int32_t res;
  if (!(WasmInterpEntrySig_0)wasm_native_to_interp_ftndescs [0].func) {
   mono_wasm_marshal_get_managed_wrapper ("SQLitePCLRaw.provider.e_sqlite3","SQLitePCL", "SQLite3Provider_e_sqlite3", "exec_hook_bridge_impl", 4);
  }
  ((WasmInterpEntrySig_0)wasm_native_to_interp_ftndescs [0].func) ((int*)&res, (int*)&arg0, (int*)&arg1, (int*)&arg2, (int*)&arg3, wasm_native_to_interp_ftndescs [0].arg);
  return res;
}

typedef void (*WasmInterpEntrySig_1) (int*, int*, int*);
int32_t wasm_native_to_interp_SQLitePCL_SQLitePCLRaw_provider_e_sqlite3_SQLite3Provider_e_sqlite3_commit_hook_bridge_impl (void * arg0) { 
  int32_t res;
  if (!(WasmInterpEntrySig_1)wasm_native_to_interp_ftndescs [1].func) {
   mono_wasm_marshal_get_managed_wrapper ("SQLitePCLRaw.provider.e_sqlite3","SQLitePCL", "SQLite3Provider_e_sqlite3", "commit_hook_bridge_impl", 1);
  }
  ((WasmInterpEntrySig_1)wasm_native_to_interp_ftndescs [1].func) ((int*)&res, (int*)&arg0, wasm_native_to_interp_ftndescs [1].arg);
  return res;
}

typedef void (*WasmInterpEntrySig_2) (int*, int*, int*, int*);
void wasm_native_to_interp_SQLitePCL_SQLitePCLRaw_provider_e_sqlite3_SQLite3Provider_e_sqlite3_scalar_function_hook_bridge_impl (void * arg0, int32_t arg1, void * arg2) { 
  if (!(WasmInterpEntrySig_2)wasm_native_to_interp_ftndescs [2].func) {
   mono_wasm_marshal_get_managed_wrapper ("SQLitePCLRaw.provider.e_sqlite3","SQLitePCL", "SQLite3Provider_e_sqlite3", "scalar_function_hook_bridge_impl", 3);
  }
  ((WasmInterpEntrySig_2)wasm_native_to_interp_ftndescs [2].func) ((int*)&arg0, (int*)&arg1, (int*)&arg2, wasm_native_to_interp_ftndescs [2].arg);
}

typedef void (*WasmInterpEntrySig_3) (int*, int*, int*, int*);
void wasm_native_to_interp_SQLitePCL_SQLitePCLRaw_provider_e_sqlite3_SQLite3Provider_e_sqlite3_log_hook_bridge_impl (void * arg0, int32_t arg1, void * arg2) { 
  if (!(WasmInterpEntrySig_3)wasm_native_to_interp_ftndescs [3].func) {
   mono_wasm_marshal_get_managed_wrapper ("SQLitePCLRaw.provider.e_sqlite3","SQLitePCL", "SQLite3Provider_e_sqlite3", "log_hook_bridge_impl", 3);
  }
  ((WasmInterpEntrySig_3)wasm_native_to_interp_ftndescs [3].func) ((int*)&arg0, (int*)&arg1, (int*)&arg2, wasm_native_to_interp_ftndescs [3].arg);
}

typedef void (*WasmInterpEntrySig_4) (int*, int*, int*, int*);
void wasm_native_to_interp_SQLitePCL_SQLitePCLRaw_provider_e_sqlite3_SQLite3Provider_e_sqlite3_agg_function_step_hook_bridge_impl (void * arg0, int32_t arg1, void * arg2) { 
  if (!(WasmInterpEntrySig_4)wasm_native_to_interp_ftndescs [4].func) {
   mono_wasm_marshal_get_managed_wrapper ("SQLitePCLRaw.provider.e_sqlite3","SQLitePCL", "SQLite3Provider_e_sqlite3", "agg_function_step_hook_bridge_impl", 3);
  }
  ((WasmInterpEntrySig_4)wasm_native_to_interp_ftndescs [4].func) ((int*)&arg0, (int*)&arg1, (int*)&arg2, wasm_native_to_interp_ftndescs [4].arg);
}

typedef void (*WasmInterpEntrySig_5) (int*, int*);
void wasm_native_to_interp_SQLitePCL_SQLitePCLRaw_provider_e_sqlite3_SQLite3Provider_e_sqlite3_agg_function_final_hook_bridge_impl (void * arg0) { 
  if (!(WasmInterpEntrySig_5)wasm_native_to_interp_ftndescs [5].func) {
   mono_wasm_marshal_get_managed_wrapper ("SQLitePCLRaw.provider.e_sqlite3","SQLitePCL", "SQLite3Provider_e_sqlite3", "agg_function_final_hook_bridge_impl", 1);
  }
  ((WasmInterpEntrySig_5)wasm_native_to_interp_ftndescs [5].func) ((int*)&arg0, wasm_native_to_interp_ftndescs [5].arg);
}

typedef void (*WasmInterpEntrySig_6) (int*, int*, int*, int*, int*, int*, int*);
int32_t wasm_native_to_interp_SQLitePCL_SQLitePCLRaw_provider_e_sqlite3_SQLite3Provider_e_sqlite3_collation_hook_bridge_impl (void * arg0, int32_t arg1, void * arg2, int32_t arg3, void * arg4) { 
  int32_t res;
  if (!(WasmInterpEntrySig_6)wasm_native_to_interp_ftndescs [6].func) {
   mono_wasm_marshal_get_managed_wrapper ("SQLitePCLRaw.provider.e_sqlite3","SQLitePCL", "SQLite3Provider_e_sqlite3", "collation_hook_bridge_impl", 5);
  }
  ((WasmInterpEntrySig_6)wasm_native_to_interp_ftndescs [6].func) ((int*)&res, (int*)&arg0, (int*)&arg1, (int*)&arg2, (int*)&arg3, (int*)&arg4, wasm_native_to_interp_ftndescs [6].arg);
  return res;
}

typedef void (*WasmInterpEntrySig_7) (int*, int*, int*, int*, int*, int*);
void wasm_native_to_interp_SQLitePCL_SQLitePCLRaw_provider_e_sqlite3_SQLite3Provider_e_sqlite3_update_hook_bridge_impl (void * arg0, int32_t arg1, void * arg2, void * arg3, int64_t arg4) { 
  if (!(WasmInterpEntrySig_7)wasm_native_to_interp_ftndescs [7].func) {
   mono_wasm_marshal_get_managed_wrapper ("SQLitePCLRaw.provider.e_sqlite3","SQLitePCL", "SQLite3Provider_e_sqlite3", "update_hook_bridge_impl", 5);
  }
  ((WasmInterpEntrySig_7)wasm_native_to_interp_ftndescs [7].func) ((int*)&arg0, (int*)&arg1, (int*)&arg2, (int*)&arg3, (int*)&arg4, wasm_native_to_interp_ftndescs [7].arg);
}

typedef void (*WasmInterpEntrySig_8) (int*, int*);
void wasm_native_to_interp_SQLitePCL_SQLitePCLRaw_provider_e_sqlite3_SQLite3Provider_e_sqlite3_rollback_hook_bridge_impl (void * arg0) { 
  if (!(WasmInterpEntrySig_8)wasm_native_to_interp_ftndescs [8].func) {
   mono_wasm_marshal_get_managed_wrapper ("SQLitePCLRaw.provider.e_sqlite3","SQLitePCL", "SQLite3Provider_e_sqlite3", "rollback_hook_bridge_impl", 1);
  }
  ((WasmInterpEntrySig_8)wasm_native_to_interp_ftndescs [8].func) ((int*)&arg0, wasm_native_to_interp_ftndescs [8].arg);
}

typedef void (*WasmInterpEntrySig_9) (int*, int*, int*);
void wasm_native_to_interp_SQLitePCL_SQLitePCLRaw_provider_e_sqlite3_SQLite3Provider_e_sqlite3_trace_hook_bridge_impl (void * arg0, void * arg1) { 
  if (!(WasmInterpEntrySig_9)wasm_native_to_interp_ftndescs [9].func) {
   mono_wasm_marshal_get_managed_wrapper ("SQLitePCLRaw.provider.e_sqlite3","SQLitePCL", "SQLite3Provider_e_sqlite3", "trace_hook_bridge_impl", 2);
  }
  ((WasmInterpEntrySig_9)wasm_native_to_interp_ftndescs [9].func) ((int*)&arg0, (int*)&arg1, wasm_native_to_interp_ftndescs [9].arg);
}

typedef void (*WasmInterpEntrySig_10) (int*, int*, int*, int*);
void wasm_native_to_interp_SQLitePCL_SQLitePCLRaw_provider_e_sqlite3_SQLite3Provider_e_sqlite3_profile_hook_bridge_impl (void * arg0, void * arg1, int64_t arg2) { 
  if (!(WasmInterpEntrySig_10)wasm_native_to_interp_ftndescs [10].func) {
   mono_wasm_marshal_get_managed_wrapper ("SQLitePCLRaw.provider.e_sqlite3","SQLitePCL", "SQLite3Provider_e_sqlite3", "profile_hook_bridge_impl", 3);
  }
  ((WasmInterpEntrySig_10)wasm_native_to_interp_ftndescs [10].func) ((int*)&arg0, (int*)&arg1, (int*)&arg2, wasm_native_to_interp_ftndescs [10].arg);
}

typedef void (*WasmInterpEntrySig_11) (int*, int*, int*);
int32_t wasm_native_to_interp_SQLitePCL_SQLitePCLRaw_provider_e_sqlite3_SQLite3Provider_e_sqlite3_progress_handler_hook_bridge_impl (void * arg0) { 
  int32_t res;
  if (!(WasmInterpEntrySig_11)wasm_native_to_interp_ftndescs [11].func) {
   mono_wasm_marshal_get_managed_wrapper ("SQLitePCLRaw.provider.e_sqlite3","SQLitePCL", "SQLite3Provider_e_sqlite3", "progress_handler_hook_bridge_impl", 1);
  }
  ((WasmInterpEntrySig_11)wasm_native_to_interp_ftndescs [11].func) ((int*)&res, (int*)&arg0, wasm_native_to_interp_ftndescs [11].arg);
  return res;
}

typedef void (*WasmInterpEntrySig_12) (int*, int*, int*, int*, int*, int*, int*, int*);
int32_t wasm_native_to_interp_SQLitePCL_SQLitePCLRaw_provider_e_sqlite3_SQLite3Provider_e_sqlite3_authorizer_hook_bridge_impl (void * arg0, int32_t arg1, void * arg2, void * arg3, void * arg4, void * arg5) { 
  int32_t res;
  if (!(WasmInterpEntrySig_12)wasm_native_to_interp_ftndescs [12].func) {
   mono_wasm_marshal_get_managed_wrapper ("SQLitePCLRaw.provider.e_sqlite3","SQLitePCL", "SQLite3Provider_e_sqlite3", "authorizer_hook_bridge_impl", 6);
  }
  ((WasmInterpEntrySig_12)wasm_native_to_interp_ftndescs [12].func) ((int*)&res, (int*)&arg0, (int*)&arg1, (int*)&arg2, (int*)&arg3, (int*)&arg4, (int*)&arg5, wasm_native_to_interp_ftndescs [12].arg);
  return res;
}

typedef void (*WasmInterpEntrySig_13) (int*, int*, int*, int*, int*, int*, int*, int*);
int32_t wasm_native_to_interp_Internal_Runtime_InteropServices_System_Private_CoreLib_ComponentActivator_LoadAssemblyAndGetFunctionPointer (void * arg0, void * arg1, void * arg2, void * arg3, void * arg4, void * arg5) { 
  int32_t res;
  if (!(WasmInterpEntrySig_13)wasm_native_to_interp_ftndescs [13].func) {
   mono_wasm_marshal_get_managed_wrapper ("System.Private.CoreLib","Internal.Runtime.InteropServices", "ComponentActivator", "LoadAssemblyAndGetFunctionPointer", 6);
  }
  ((WasmInterpEntrySig_13)wasm_native_to_interp_ftndescs [13].func) ((int*)&res, (int*)&arg0, (int*)&arg1, (int*)&arg2, (int*)&arg3, (int*)&arg4, (int*)&arg5, wasm_native_to_interp_ftndescs [13].arg);
  return res;
}

typedef void (*WasmInterpEntrySig_14) (int*, int*, int*, int*, int*);
int32_t wasm_native_to_interp_Internal_Runtime_InteropServices_System_Private_CoreLib_ComponentActivator_LoadAssembly (void * arg0, void * arg1, void * arg2) { 
  int32_t res;
  if (!(WasmInterpEntrySig_14)wasm_native_to_interp_ftndescs [14].func) {
   mono_wasm_marshal_get_managed_wrapper ("System.Private.CoreLib","Internal.Runtime.InteropServices", "ComponentActivator", "LoadAssembly", 3);
  }
  ((WasmInterpEntrySig_14)wasm_native_to_interp_ftndescs [14].func) ((int*)&res, (int*)&arg0, (int*)&arg1, (int*)&arg2, wasm_native_to_interp_ftndescs [14].arg);
  return res;
}

typedef void (*WasmInterpEntrySig_15) (int*, int*, int*, int*, int*, int*, int*, int*);
int32_t wasm_native_to_interp_Internal_Runtime_InteropServices_System_Private_CoreLib_ComponentActivator_LoadAssemblyBytes (void * arg0, void * arg1, void * arg2, void * arg3, void * arg4, void * arg5) { 
  int32_t res;
  if (!(WasmInterpEntrySig_15)wasm_native_to_interp_ftndescs [15].func) {
   mono_wasm_marshal_get_managed_wrapper ("System.Private.CoreLib","Internal.Runtime.InteropServices", "ComponentActivator", "LoadAssemblyBytes", 6);
  }
  ((WasmInterpEntrySig_15)wasm_native_to_interp_ftndescs [15].func) ((int*)&res, (int*)&arg0, (int*)&arg1, (int*)&arg2, (int*)&arg3, (int*)&arg4, (int*)&arg5, wasm_native_to_interp_ftndescs [15].arg);
  return res;
}

typedef void (*WasmInterpEntrySig_16) (int*, int*, int*, int*, int*, int*, int*, int*);
int32_t wasm_native_to_interp_Internal_Runtime_InteropServices_System_Private_CoreLib_ComponentActivator_GetFunctionPointer (void * arg0, void * arg1, void * arg2, void * arg3, void * arg4, void * arg5) { 
  int32_t res;
  if (!(WasmInterpEntrySig_16)wasm_native_to_interp_ftndescs [16].func) {
   mono_wasm_marshal_get_managed_wrapper ("System.Private.CoreLib","Internal.Runtime.InteropServices", "ComponentActivator", "GetFunctionPointer", 6);
  }
  ((WasmInterpEntrySig_16)wasm_native_to_interp_ftndescs [16].func) ((int*)&res, (int*)&arg0, (int*)&arg1, (int*)&arg2, (int*)&arg3, (int*)&arg4, (int*)&arg5, wasm_native_to_interp_ftndescs [16].arg);
  return res;
}

typedef void (*WasmInterpEntrySig_17) (int*, int*, int*);
void wasm_native_to_interp_System_Globalization_System_Private_CoreLib_CalendarData_EnumCalendarInfoCallback (void * arg0, void * arg1) { 
  if (!(WasmInterpEntrySig_17)wasm_native_to_interp_ftndescs [17].func) {
   mono_wasm_marshal_get_managed_wrapper ("System.Private.CoreLib","System.Globalization", "CalendarData", "EnumCalendarInfoCallback", 2);
  }
  ((WasmInterpEntrySig_17)wasm_native_to_interp_ftndescs [17].func) ((int*)&arg0, (int*)&arg1, wasm_native_to_interp_ftndescs [17].arg);
}

typedef void (*WasmInterpEntrySig_18) (int*);
void wasm_native_to_interp_System_Threading_System_Private_CoreLib_ThreadPool_BackgroundJobHandler () { 
  if (!(WasmInterpEntrySig_18)wasm_native_to_interp_ftndescs [18].func) {
   mono_wasm_marshal_get_managed_wrapper ("System.Private.CoreLib","System.Threading", "ThreadPool", "BackgroundJobHandler", 0);
  }
  ((WasmInterpEntrySig_18)wasm_native_to_interp_ftndescs [18].func) (wasm_native_to_interp_ftndescs [18].arg);
}

typedef void (*WasmInterpEntrySig_19) (int*);
void wasm_native_to_interp_System_Threading_System_Private_CoreLib_TimerQueue_TimerHandler () { 
  if (!(WasmInterpEntrySig_19)wasm_native_to_interp_ftndescs [19].func) {
   mono_wasm_marshal_get_managed_wrapper ("System.Private.CoreLib","System.Threading", "TimerQueue", "TimerHandler", 0);
  }
  ((WasmInterpEntrySig_19)wasm_native_to_interp_ftndescs [19].func) (wasm_native_to_interp_ftndescs [19].arg);
}


static void *wasm_native_to_interp_funcs[] = {
    wasm_native_to_interp_SQLitePCL_SQLitePCLRaw_provider_e_sqlite3_SQLite3Provider_e_sqlite3_exec_hook_bridge_impl, wasm_native_to_interp_SQLitePCL_SQLitePCLRaw_provider_e_sqlite3_SQLite3Provider_e_sqlite3_commit_hook_bridge_impl, wasm_native_to_interp_SQLitePCL_SQLitePCLRaw_provider_e_sqlite3_SQLite3Provider_e_sqlite3_scalar_function_hook_bridge_impl, wasm_native_to_interp_SQLitePCL_SQLitePCLRaw_provider_e_sqlite3_SQLite3Provider_e_sqlite3_log_hook_bridge_impl, wasm_native_to_interp_SQLitePCL_SQLitePCLRaw_provider_e_sqlite3_SQLite3Provider_e_sqlite3_agg_function_step_hook_bridge_impl, wasm_native_to_interp_SQLitePCL_SQLitePCLRaw_provider_e_sqlite3_SQLite3Provider_e_sqlite3_agg_function_final_hook_bridge_impl, wasm_native_to_interp_SQLitePCL_SQLitePCLRaw_provider_e_sqlite3_SQLite3Provider_e_sqlite3_collation_hook_bridge_impl, wasm_native_to_interp_SQLitePCL_SQLitePCLRaw_provider_e_sqlite3_SQLite3Provider_e_sqlite3_update_hook_bridge_impl, wasm_native_to_interp_SQLitePCL_SQLitePCLRaw_provider_e_sqlite3_SQLite3Provider_e_sqlite3_rollback_hook_bridge_impl, wasm_native_to_interp_SQLitePCL_SQLitePCLRaw_provider_e_sqlite3_SQLite3Provider_e_sqlite3_trace_hook_bridge_impl, wasm_native_to_interp_SQLitePCL_SQLitePCLRaw_provider_e_sqlite3_SQLite3Provider_e_sqlite3_profile_hook_bridge_impl, wasm_native_to_interp_SQLitePCL_SQLitePCLRaw_provider_e_sqlite3_SQLite3Provider_e_sqlite3_progress_handler_hook_bridge_impl, wasm_native_to_interp_SQLitePCL_SQLitePCLRaw_provider_e_sqlite3_SQLite3Provider_e_sqlite3_authorizer_hook_bridge_impl, wasm_native_to_interp_Internal_Runtime_InteropServices_System_Private_CoreLib_ComponentActivator_LoadAssemblyAndGetFunctionPointer, wasm_native_to_interp_Internal_Runtime_InteropServices_System_Private_CoreLib_ComponentActivator_LoadAssembly, wasm_native_to_interp_Internal_Runtime_InteropServices_System_Private_CoreLib_ComponentActivator_LoadAssemblyBytes, wasm_native_to_interp_Internal_Runtime_InteropServices_System_Private_CoreLib_ComponentActivator_GetFunctionPointer, wasm_native_to_interp_System_Globalization_System_Private_CoreLib_CalendarData_EnumCalendarInfoCallback, wasm_native_to_interp_System_Threading_System_Private_CoreLib_ThreadPool_BackgroundJobHandler, wasm_native_to_interp_System_Threading_System_Private_CoreLib_TimerQueue_TimerHandler
};

// these strings need to match the keys generated in get_native_to_interp
static const char *wasm_native_to_interp_map[] = {
    "SQLitePCLRaw_provider_e_sqlite3_SQLite3Provider_e_sqlite3_exec_hook_bridge_impl", "SQLitePCLRaw_provider_e_sqlite3_SQLite3Provider_e_sqlite3_commit_hook_bridge_impl", "SQLitePCLRaw_provider_e_sqlite3_SQLite3Provider_e_sqlite3_scalar_function_hook_bridge_impl", "SQLitePCLRaw_provider_e_sqlite3_SQLite3Provider_e_sqlite3_log_hook_bridge_impl", "SQLitePCLRaw_provider_e_sqlite3_SQLite3Provider_e_sqlite3_agg_function_step_hook_bridge_impl", "SQLitePCLRaw_provider_e_sqlite3_SQLite3Provider_e_sqlite3_agg_function_final_hook_bridge_impl", "SQLitePCLRaw_provider_e_sqlite3_SQLite3Provider_e_sqlite3_collation_hook_bridge_impl", "SQLitePCLRaw_provider_e_sqlite3_SQLite3Provider_e_sqlite3_update_hook_bridge_impl", "SQLitePCLRaw_provider_e_sqlite3_SQLite3Provider_e_sqlite3_rollback_hook_bridge_impl", "SQLitePCLRaw_provider_e_sqlite3_SQLite3Provider_e_sqlite3_trace_hook_bridge_impl", "SQLitePCLRaw_provider_e_sqlite3_SQLite3Provider_e_sqlite3_profile_hook_bridge_impl", "SQLitePCLRaw_provider_e_sqlite3_SQLite3Provider_e_sqlite3_progress_handler_hook_bridge_impl", "SQLitePCLRaw_provider_e_sqlite3_SQLite3Provider_e_sqlite3_authorizer_hook_bridge_impl", "System_Private_CoreLib_ComponentActivator_LoadAssemblyAndGetFunctionPointer", "System_Private_CoreLib_ComponentActivator_LoadAssembly", "System_Private_CoreLib_ComponentActivator_LoadAssemblyBytes", "System_Private_CoreLib_ComponentActivator_GetFunctionPointer", "System_Private_CoreLib_CalendarData_EnumCalendarInfoCallback", "System_Private_CoreLib_ThreadPool_BackgroundJobHandler", "System_Private_CoreLib_TimerQueue_TimerHandler"
};
