namespace Model
{
    public class InvalidGameCreationParametersException: Exception
    {
        public InvalidGameCreationParametersException()
        {
            
        }    

        public InvalidGameCreationParametersException(string message): base(message)
        {

        }
    }
}
