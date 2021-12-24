namespace Lab1_4
{
    public class ArrayTasks
    {
        public static (int, int) FindMax(int[] array)
        {
            //Изначально max и count = 0
            int max = 0;
            int count = 0;

            //Если массив не пустой, то максимум будет первым элементом в массиве
            if(array.Length > 0)
            {
                max = array[0];
            }

            //Перебираем числа в массиве, и если i-й элемент массива больше максимума
            //То максимумом станет этот элемент массива
            //Если же максимум будет равен элементу массива, то count увеличивается на 1
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] > max)
                {
                    count = 1;
                    max = array[i];
                }
                else if (array[i] == max)
                {
                    count++;
                }
            }

            return (max, count);
        }
    }
}