using System;
/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/
class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
  }
  public Node CopyRandomList(Node head) {
        //create copy of all original nodes and their next pointers
        //store the original nodes and next pointers in a map
        //change pointers in the original list to point to corresponding values in copied list
        //change random pointers in the copied list to point to original node list        
      if(head==null){
            return null;
        }
        Node curr=head;
        Node CloneCurr=null;
        Dictionary<Node, Node> map=new Dictionary<Node,Node>();
        while(curr!=null){
            CloneCurr=new Node(curr.val);
            map.Add(curr,CloneCurr);
            curr=curr.next;
        }
        curr=head;
        
        while(curr!=null){
            CloneCurr=map[curr];
            if(curr.next!=null){
                CloneCurr.next=map[curr.next];
            }
            if(curr.random!=null){
                CloneCurr.random=map[curr.random];
            }
            curr=curr.next;
        }
        return map[head];
    }
}
