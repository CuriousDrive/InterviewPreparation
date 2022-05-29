ListNode listNode1 = new ListNode();
listNode1.Value = 1;

ListNode listNode2 = new ListNode();
listNode2.Value = 2;
listNode1.Next = listNode2;

ListNode listNode4 = new ListNode();
listNode4.Value = 4;
listNode2.Next = listNode4;

// Inserting
while(listNode1 != null)
{
    Console.WriteLine(listNode1.Value);
        
    if(listNode1.Value == 2)
    {
        ListNode newListNode = new ListNode();
        newListNode.Value = 3;
        
        newListNode.Next = listNode1.Next;
        listNode1 = newListNode;
    }
    else
        listNode1 = listNode1.Next;
}

// Skipping/Removing
while(listNode1 != null)
{
    Console.WriteLine(listNode1.Value);
    if(listNode1.Value == 1)
        listNode1.Next = listNode1.Next.Next;
    else
        listNode1 = listNode1.Next;
}

public class ListNode
{
    public int Value {get; set;}
    public ListNode Next {get; set;}
}