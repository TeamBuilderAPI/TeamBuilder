namespace TeamBuilder.Model
{
    public static class FieldModel
    {
        private static readonly string _configKey1;
        static FieldModel()
        {
            //Todo add and read in any global config key values here.
            _configKey1 = "global config value";
        }

        public static string ConfigKey1
        {
            get { return _configKey1; }
        }
    }
}