int[] arrayLoaded;
int count = 8;

void Main()
{
	
	arrayLoaded = LoadArray();
	var sum = 0;
	foreach (var item in arrayLoaded)
	{
		Console.Write("{0}^2{1}", item, item == arrayLoaded[count-1] ? " = " : " + ");
	}
	
	Console.Write(sumArray(count-1));
	
	
}

int sumArray(int c)
{
	if (c == 0)
		return arrayLoaded[c];
	else
		return sumArray(c-1) + arrayLoaded[c] * arrayLoaded[c];
}

int[] LoadArray()
{
	int[] squareThese = new int[count];
	for (int i = 0; i < count; i++)
	{
		squareThese[i] = i + 1;
	}
	
	return squareThese;

}

