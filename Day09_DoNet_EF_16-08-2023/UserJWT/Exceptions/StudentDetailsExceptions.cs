namespace UserJWT.Exceptions
{
    public class StudentDetailsExceptions :Exception
    {
        public static List<string> excetpionsmessages { get;  } = new List<string> { 
        
            "Student Not Found!",
            "User not found",
            "",
        };
    }
}
