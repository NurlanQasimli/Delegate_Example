List<int> list = 
[
1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16 
];

bool FilterMyList(int element)
{
    if (element%3==0)
    {
        return true;
    }
    return false;
}

List<int> newlist = GetElementsMoreThanAnumber(list,5);
Console.WriteLine(GetListAsString(newlist));

Console.WriteLine(GetListAsString(GetElementsFiltered(list, FilterMyList)));

Console.WriteLine(GetListAsString(GetElementsDivideByComparinNumber(list,4)));

List<int> GetElementsMoreThanAnumber(List<int> list, int comparing_number)
    {
        List<int> bigNumbers = new();
         Console.WriteLine($"Comparing number:{comparing_number}");
   
       // Random r = new(); //---> I create a random number.
       // int number = r.Next(1,50);

      //  Console.WriteLine($"Random Number:{number}");

        foreach (var item in list)
        {
            if (item > comparing_number)
            {
                bigNumbers.Add(item);
            }
        
    }
    return bigNumbers;
    }

List<int> GetElementsDivideByComparinNumber(List<int> list, int comparing_number)
    {
         Console.WriteLine("\n");
        List<int> Div3num = new();
    Console.Write($"Numbers in list that are divisible by {comparing_number}: ");
    foreach (var item in list)
        {
            if (item % comparing_number == 0)
            {
                Div3num.Add(item);
            }
        }
        return Div3num;
    }

string GetListAsString(List<int> list)
    {
        var str = "";
        foreach (var item in list)
        {
            str += item + ",";
        }
        str = str.TrimEnd(',');
        return str;
    }

List<int> GetElementsFiltered(List<int> list, FilterMyListDelegate filterMylistDelegate)
    {
        List<int> filterlist = new();
    Console.WriteLine();
    Console.Write($"Numbers in list that are divisible by 3:");
    foreach (var item in list)
        {
            if (filterMylistDelegate(item))
            {
                filterlist.Add(item);
            }
        }
        return filterlist;
    }

delegate bool FilterMyListDelegate(int element);
