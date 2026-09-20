using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        HashSet<int> different = new HashSet<int>(list1);
        different.SymmetricExceptWith(list2);

        List<int> result = new List<int>(different);
        result.Sort();

        return result;
    }
}
