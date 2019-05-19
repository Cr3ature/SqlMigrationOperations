using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.EntityFrameworkCore.Storage;

namespace SqlMigrationOperations.Operations
{
    public static class DropTriggerOperationMigrationBuilderExtension
    {
        internal static MigrationBuilder DropTrigger(
            this MigrationBuilder migrationBuilder,
            string triggerName)
        {
            migrationBuilder.Operations.Add(
                new DropTriggerOperation
                {
                    TriggerName = triggerName,
                });

            return migrationBuilder;
        }
    }

    public class DropTriggerOperation : MigrationOperation
    {
        public string TriggerName { get; set; }

        public virtual void Generate(
                   DropTriggerOperation operation,
                   MigrationCommandListBuilder builder,
                   MigrationsSqlGeneratorDependencies dependencies)
        {
            ISqlGenerationHelper sqlHelper = dependencies.SqlGenerationHelper;
            RelationalTypeMapping stringMapping = dependencies.TypeMappingSource.FindMapping(typeof(string));

            builder
                .Append("DROP TRIGGER ")
                .Append(sqlHelper.DelimitIdentifier(operation.TriggerName))
                .Append(";")
                .AppendLine(sqlHelper.StatementTerminator)
                .EndCommand();
        }
    }
}
