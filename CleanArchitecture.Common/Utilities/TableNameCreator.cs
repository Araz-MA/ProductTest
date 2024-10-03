namespace CleanArchitecture.Common.Utilities
{
    public static class TableNameCreator
    {
        const string PreName = "Rangarang";
        public static string CreateTableName(string tableName)
        {
            return string.Concat(PreName, "_", tableName);
        }
    }
}
