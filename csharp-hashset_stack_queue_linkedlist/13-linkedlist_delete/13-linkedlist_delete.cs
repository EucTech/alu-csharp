using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        if (index < 0)
            return;

        LinkedListNode<int> current = myLList.First;
        int position = 0;

        while (current != null)
        {
            if (position == index)
            {
                myLList.Remove(current);
                return;
            }

            current = current.Next;
            position++;
        }
    }
}
