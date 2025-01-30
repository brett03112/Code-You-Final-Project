Build started...
Build succeeded.
System.NotSupportedException: Generating idempotent scripts for migrations is not currently supported for SQLite. See https://go.microsoft.com/fwlink/?LinkId=723262 for more information and examples.
   at Microsoft.EntityFrameworkCore.Sqlite.Migrations.Internal.SqliteHistoryRepository.GetEndIfScript()
   at Microsoft.EntityFrameworkCore.Migrations.Internal.Migrator.GenerateScript(String fromMigration, String toMigration, MigrationsSqlGenerationOptions options)
   at Microsoft.EntityFrameworkCore.Design.Internal.MigrationsOperations.ScriptMigration(String fromMigration, String toMigration, MigrationsSqlGenerationOptions options, String contextType)
   at Microsoft.EntityFrameworkCore.Design.OperationExecutor.ScriptMigrationImpl(String fromMigration, String toMigration, Boolean idempotent, Boolean noTransactions, String contextType)
   at Microsoft.EntityFrameworkCore.Design.OperationExecutor.ScriptMigration.<>c__DisplayClass0_0.<.ctor>b__0()
   at Microsoft.EntityFrameworkCore.Design.OperationExecutor.OperationBase.<>c__DisplayClass3_0`1.<Execute>b__0()
   at Microsoft.EntityFrameworkCore.Design.OperationExecutor.OperationBase.Execute(Action action)
Generating idempotent scripts for migrations is not currently supported for SQLite. See https://go.microsoft.com/fwlink/?LinkId=723262 for more information and examples.
