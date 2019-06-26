namespace SqlMigrationOperations.Contracts
{
    public class TriggerOnActionConstants
    {
        public const string AfterDelete = " AFTER DELETE ";
        public const string AfterInsert = " AFTER INSERT ";
        public const string AfterUpdate = " AFTER UPDATE ";

        public const string AfterInsertAndDelete = " AFTER INSERT, DELETE ";
        public const string AfterInsertAndUpdate = " AFTER INSERT, UPDATE ";
        public const string AfterUpdateAndDelete = " AFTER UPDATE, DELETE ";

        public const string AfterAllActions = " AFTER INSERT, UPDATE, DELETE ";

        public const string OnDelete = " FOR DELETE ";
        public const string OnInsert = " FOR INSERT ";
        public const string OnUpdate = " FOR UPDATE ";

        public const string OnInsertAndDelete = " FOR INSERT, DELETE ";
        public const string OnInsertAndUpdate = " FOR INSERT, UPDATE ";
        public const string OnUpdateAndDelete = " FOR UPDATE, DELETE ";

        public const string OnAllActions = " FOR INSERT, UPDATE, DELETE ";

        public const string InsteadOfDelete = " INSTEAD OF DELETE ";
        public const string InsteadOfInsert = " INSTEAD OF INSERT ";
        public const string InsteadOfUpdate = " INSTEAD OF UPDATE ";

        public const string InsteadOfInsertAndDelete = " INSTEAD OF INSERT, DELETE ";
        public const string InsteadOfInsertAndUpdate = " INSTEAD OF INSERT, UPDATE ";
        public const string InsteadOfUpdateAndDelete = " INSTEAD OF UPDATE, DELETE ";

        public const string InsteadOfAllActions = " INSTEAD OF INSERT, UPDATE, DELETE ";
    }
}
