namespace TeamBuilder.Models
{
    public static class FieldModel
    {
        static FieldModel()
        {
            //Todo add and read in any global config key values here.
            ConfigKey1 = "global config value";
        }

        public static string ConfigKey1 { get; private set; }
    }
}