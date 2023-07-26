namespace Alpha.Common.Exceptions
{
    public class AlphaNotFoundException : NotFoundException
    {
        public AlphaNotFoundException(string message)
            : base($" {message} .")
        {
        }
    }
}
