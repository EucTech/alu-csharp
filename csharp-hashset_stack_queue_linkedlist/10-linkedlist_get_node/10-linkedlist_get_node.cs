using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        if (n < 0)
            return 0;

        LinkedListNode<int> node = myLList.First;
        int index = 0;

        while (node != null)
        {
            if (index == n)
                return node.Value;

            node = node.Next;
            index++;
        }

        return 0;
    }
}
