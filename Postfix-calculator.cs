void Main()
{
	var input = "1 2 +";
	//input = "4 5 7 2 + - *";
	input = "1 2 3 * +";
	var current = 0.0;

	if (String.IsNullOrWhiteSpace(input))
        {
		Console.WriteLine("Empty input is not valid");
		return;
	}
	var split = input.Split(' ');

	var s = new Stack<string>();
	foreach (var piece in split)
	{
		s.Push(piece);
	}
	
	Stack<string> operandStack = new Stack<string>();
	Stack<int> numStack = new Stack<int>();

	while (s.Count > 0)
	{
		var popped = s.Pop();

		if (popped == "+" ||
			popped == "-" ||
			popped == "*" ||
			popped == "/")
		{
			operandStack.Push(popped);
		}
		else
		{
			numStack.Push(Convert.ToInt32(popped));
		}
	}
	
	numStack = Reverse(numStack);

	while (operandStack.Count > 0)
	{
		string currentOperand = operandStack.Pop();
		double first = numStack.Pop();
		double second = current == 0.0 ? numStack.Pop(): current ;

		switch (currentOperand)
		{
			case "+":
				{
					current = first + second;
					break;
				}
			case "-":
				{
					current = first - second;
					break;
				}
			case "*":
				{
					current = first * second;
					break;
				}
			case "/":
				{
					current = first / second;
					break;
				}
	
			default:
				{
					break;
				}
		}
	}
	Console.WriteLine(current);
}

protected Stack<T> Reverse<T>(Stack<T> s)
{
	var rs = new Stack<T>();
	while (s.Count > 0)
	{
		rs.Push((T)s.Pop());
	}
	return rs;
}
