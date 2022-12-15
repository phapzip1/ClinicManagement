namespace ClinicManagement.Classes
{
    public class ComboboxItem
    {
        public ComboboxItem(string text, object value)
        {
            Text = text;
            Value = value;
        }

        public string Text { get; }
        public object Value { get; }

        public override string ToString()
        {
            return Text;
        }
    }
}
