namespace AfterCompilation
{
    class Program
    {
        delegate int Mix(int n);
        static Mix[] Build()
        {
            Bonus bonus = new Bonus();
            bonus.bonus = 5;
            Mix[] rows = new Mix[3];
            for (int i = 0; i < 3; i++)
            {
                Level l1 = new Level();
                l1.level = i;
                l1.b1 = bonus;
                rows[i] = l1.Func;  
                
                    
                
            }
            bonus.bonus = 50; 
            return rows;
        }
        static void Main(string[] args)
        {
            Mix[] rows = Build();

            Console.WriteLine(rows[0](2));
            Console.WriteLine(rows[1](2)); 
            Console.WriteLine(rows[2](2)); 
            Console.WriteLine(rows[0](0)); 

        }
    }
}