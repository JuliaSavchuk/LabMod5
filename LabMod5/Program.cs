namespace LabMod5
{
    public class Program
    {
        public static void Main()
        {
            Employee emp1 = new Employee("John Doe", 30, 50000);
            Employee emp2 = new Employee("Jane Smith", 28, 60000);

            Console.WriteLine(emp1);
            Console.WriteLine(emp2);

            emp1 += 5000;
            Console.WriteLine("After increment:");
            Console.WriteLine(emp1);

            emp2 -= 3000;
            Console.WriteLine("After decrement:");
            Console.WriteLine(emp2);

            Console.WriteLine("Salaries are equal: " + (emp1 == emp2));
            Console.WriteLine("Salaries are not equal: " + (emp1 != emp2));
            Console.WriteLine("emp1 has a lower salary than emp2: " + (emp1 < emp2));
            Console.WriteLine("emp1 has a higher salary than emp2: " + (emp1 > emp2));




            Matrix matrix1 = new Matrix(2, 2);
            matrix1[0, 0] = 1;
            matrix1[0, 1] = 2;
            matrix1[1, 0] = 3;
            matrix1[1, 1] = 4;

            Matrix matrix2 = new Matrix(2, 2);
            matrix2[0, 0] = 5;
            matrix2[0, 1] = 6;
            matrix2[1, 0] = 7;
            matrix2[1, 1] = 8;

            Console.WriteLine("Matrix 1:");
            Console.WriteLine(matrix1);
            Console.WriteLine("Matrix 2:");
            Console.WriteLine(matrix2);

            Matrix sum = matrix1 + matrix2;
            Console.WriteLine("Sum of Matrix 1 and Matrix 2:");
            Console.WriteLine(sum);

            Matrix diff = matrix1 - matrix2;
            Console.WriteLine("Difference of Matrix 1 and Matrix 2:");
            Console.WriteLine(diff);

            Matrix product = matrix1 * matrix2;
            Console.WriteLine("Product of Matrix 1 and Matrix 2:");
            Console.WriteLine(product);

            Matrix scalarMultiplication = matrix1 * 2;
            Console.WriteLine("Matrix 1 multiplied by 2:");
            Console.WriteLine(scalarMultiplication);

            Console.WriteLine("Matrices are equal: " + (matrix1 == matrix2));
            Console.WriteLine("Matrices are not equal: " + (matrix1 != matrix2));




            City city1 = new City("Kyiv", 2800000);
            City city2 = new City("Lviv", 720000);

            Console.WriteLine(city1);
            Console.WriteLine(city2);

            city1 += 50000;
            Console.WriteLine("After population increase:");
            Console.WriteLine(city1);

            city2 -= 20000;
            Console.WriteLine("After population decrease:");
            Console.WriteLine(city2);

            Console.WriteLine("Cities have equal population: " + (city1 == city2));
            Console.WriteLine("Cities do not have equal population: " + (city1 != city2));
            Console.WriteLine("city1 has a lower population than city2: " + (city1 < city2));
            Console.WriteLine("city1 has a higher population than city2: " + (city1 > city2));




            CreditCard card1 = new CreditCard("1234567812345678", "John Doe", "123", new DateTime(2025, 12, 31), 1000);
            CreditCard card2 = new CreditCard("8765432187654321", "Jane Smith", "456", new DateTime(2024, 11, 30), 2000);

            Console.WriteLine(card1);
            Console.WriteLine(card2);

            card1 += 500;
            Console.WriteLine("After deposit:");
            Console.WriteLine(card1);

            card2 -= 300;
            Console.WriteLine("After withdrawal:");
            Console.WriteLine(card2);

            Console.WriteLine("CVC codes are equal: " + (card1 == card2));
            Console.WriteLine("CVC codes are not equal: " + (card1 != card2));
            Console.WriteLine("card1 has a lower balance than card2: " + (card1 < card2));
            Console.WriteLine("card1 has a higher balance than card2: " + (card1 > card2));
        }
    }
}