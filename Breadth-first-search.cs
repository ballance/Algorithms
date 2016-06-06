void Main()
{
	BreadthFirstSearch();
}

Queue<Node> bfs = new Queue<Node>();

public class Node
{
	public int Id { get; set; }
	public int ParentId { get; set; }
	public Node LeftChild { get; set; }
	public Node RightChild { get; set; }

	public void Process()
	{
		Console.WriteLine("Processing " + this.Id);
	}
}

public void ProcessNodes()
{
	while (bfs.Count() > 0)
	{
		var item = bfs.Dequeue();
		
		item.Process();

		if (item.LeftChild != null)
		{
			bfs.Enqueue(item.LeftChild);
		}
		if (item.RightChild != null)
		{
			bfs.Enqueue(item.RightChild);
		}
	}
}

public Node InitializeTree()
{
	var headNode = new Node
	{
		Id = 10,
		LeftChild = new Node
		{
			Id = 4,
            LeftChild = new Node
			{
				Id = 2
			},
			RightChild = new Node
			{
				Id = 2
			}
		}
			
    };
	
	return headNode;
}

public void BreadthFirstSearch()
{
	Node headNode = InitializeTree();
	bfs.Enqueue(headNode);
	ProcessNodes();
}