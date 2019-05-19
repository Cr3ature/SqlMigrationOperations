using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using SqlMigrationOperations.Operations;

namespace SqlMigrationOperations
{
    public class SqlMigrationOperationsGenerator: SqlServerMigrationsSqlGenerator
    {
        public SqlMigrationOperationsGenerator(
           MigrationsSqlGeneratorDependencies dependencies,
           IMigrationsAnnotationProvider migrationsAnnotations)
           : base(dependencies, migrationsAnnotations)
        {
        }

        protected override void Generate(
           MigrationOperation operation,
           IModel model,
           MigrationCommandListBuilder builder)
        {
            if (operation is CreateOrAlterTriggerOperation createOrAlterTriggerOperation)
            {
                createOrAlterTriggerOperation.Generate(createOrAlterTriggerOperation, builder, Dependencies);
            }
            else if (operation is DropTriggerOperation dropTriggerOperation)
            {
                dropTriggerOperation.Generate(dropTriggerOperation, builder, Dependencies);
            }
            else
            {
                base.Generate(operation, model, builder);
            }
        }
    }
}
