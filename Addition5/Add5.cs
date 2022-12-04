namespace Addition5
{
    public class Add5
    {
        public static int[] Delete(int[] array)
        {
            int value = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    value++;
                }
            }

            int[] final = new int[array.Length - value];
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    final[count] = array[i];
                    count++;
                }
            }
            return final;
        }
       
    }
}



