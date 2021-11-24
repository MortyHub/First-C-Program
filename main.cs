using System;

	class Program {

		static void Main(string[] args)
		{
			int score = 0;
			Console.WriteLine("Every Time You Type In LOL Your Score Goes Up By 5. To see your score, simply type in Score");
			while(true)
			{
				string x = Console.ReadLine();
				if(x == "LOL")
				{
					score += 5;					
				} else 
				{
					if(x == "Score")
					{
						Console.WriteLine(score);
					} else
					{
						Console.WriteLine("Invalid Command");
					}
				}
			}
		}
	}
