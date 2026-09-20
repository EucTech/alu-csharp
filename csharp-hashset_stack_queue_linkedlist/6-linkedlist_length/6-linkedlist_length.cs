using System.Collections.Generic;

class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        int length = 0;
        LinkedListNode<int> node = myLList.First;

        while (node != null)
        {
            length++;
            node = node.Next;
        }

        return length;
    }
}
