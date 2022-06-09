namespace CSharpAppSettingsPOC
{
    public class AppSettings
    {
        //[Required]
        public string? Key1 { get; set; }

        //[Optional]
        public string? Key2 { get; set; }

        // Get all values and check they are populated.
        public void Verify()
        {
            var properties = this.GetType().GetProperties();
                // This will allow for setting properties are "optional" or "required" via attribute
                //.Where(prop => Attribute.IsDefined(prop, typeof(RequiredAttribute)));
                //.Where(prop => !Attribute.IsDefined(prop, typeof(OptionalAttribute)));
            foreach (var property in properties)
            {
                var value = property.GetValue(this, null);
                if (string.IsNullOrEmpty(value?.ToString()))
                {
                    throw new Exception($"App setting '{property.Name}' is required.");
                }
            }
        }
    }
}