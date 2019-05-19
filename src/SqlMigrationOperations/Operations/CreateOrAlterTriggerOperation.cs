using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.EntityFrameworkCore.Storage;

namespace SqlMigrationOperations.Operations
{
    public static class CreateOrAlterTriggerOperationMigrationBuilderExtension
    {
        public static MigrationBuilder CreateOrAlterTrigger(
            this MigrationBuilder migrationBuilder,
            string triggerName,
            string triggerTable,
            string triggerFunction)
        {
            migrationBuilder.Operations.Add(
                new CreateOrAlterTriggerOperation
                {
                    TriggerFunction = triggerFunction,
                    TriggerName = triggerName,
                    TriggerTable = triggerTable,
                });

            return migrationBuilder;
        }
    }

    public class CreateOrAlterTriggerOperation : MigrationOperation
    {
        public string TriggerName { get; set; }

        public string TriggerTable { get; set; }

        public string TriggerFunction { get; set; }

        public virtual void Generate(
                    CreateOrAlterTriggerOperation operation,
                    MigrationCommandListBuilder builder,
                    MigrationsSqlGeneratorDependencies dependencies)
        {
            ISqlGenerationHelper sqlHelper = dependencies.SqlGenerationHelper;
            RelationalTypeMapping stringMapping = dependencies.TypeMappingSource.FindMapping(typeof(string));

            builder
                .Append("EXEC('")
                .Append("CREATE OR ALTER TRIGGER ")
                .Append(sqlHelper.DelimitIdentifier(operation.TriggerName))
                .Append(" ON ")
                .Append(sqlHelper.DelimitIdentifier(operation.TriggerTable))
                .Append(" FOR UPDATE AS BEGIN ")
                .Append(operation.TriggerFunction)
                .Append(" END;")
                .Append("');")
                .AppendLine(sqlHelper.StatementTerminator)
                .EndCommand();
        }
    }
}
