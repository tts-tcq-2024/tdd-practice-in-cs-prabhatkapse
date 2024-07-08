public class StringCalculator
{
  public int Add(string input)
  {
    if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
    {
    return 0;
    }

    if (input == 0)
    {
      return 0;
    }
    return -1;
  }
   
}

  
