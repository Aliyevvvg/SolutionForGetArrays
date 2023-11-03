
string text="HelloOybekAkmalLLOybekAkmal";
string[] textToFind=new String[]{"Akmal","Oybek"};

Console.WriteLine(AddIndexContainiedValue(text,textToFind));

int[] AddIndexContainiedValue(string? text,string[]? toFindsource)
{
   List<int> ValueIndexs = new List<int>();
   for (int i = 0; i <= text.Length; i++)
   {
      
      var sourceTofind = GetAllInOne(toFindsource);
      if (sourceTofind is not null)
      {
         var substeredText = text.Substring(i, toFindsource[0].Length);
         if (Contains(sourceTofind, substeredText))
         {
            ValueIndexs.Add(i);
         }
      }
   }

   return ValueIndexs.ToArray();
}


//To checking contains or not value 
// This function returns true or false
bool Contains(string? valuToFind,string? source)
{
   if (source.Contains(valuToFind))
   {
      return true;
   }
   else
   {
      return false;
   }
}

//this function to get all in one from string Array
string GetAllInOne(string[]? source)
{
   string textInOne = null;
   foreach (var x in source)
   {
      textInOne += x;
   }

   return textInOne;
}