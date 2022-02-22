using System;

public class StoreException : System.Exception
{
    public StoreException(string message) :
    base(message)
    {
        if (inName.Length == 0)
        {
            throw new StoreException("Invalid Name");
        }
        Account a;
        try
        {
            a = new Account("John", "");
        }
        catch (StoreExceptionBadName nameException)
        {
            Console.WriteLine("Invalid name : " +
            nameException.Message);
        }
        catch (StoreExceptionBadAddress addrException)
        {
            Console.WriteLine("Invalid address : " +
            addrException.Message);
        }
        catch (System.Exception exception)
        {
            Console.WriteLine("System exception : " +
            exception.Message);
        }

    }

}
