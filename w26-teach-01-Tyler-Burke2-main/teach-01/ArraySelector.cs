namespace teach_01;

public static class ArraySelector
{
    public static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        int[] result = new int[select.Length];
        int index1 = 0;
        int index2 = 0;

        for (int i = 0; i < select.Length; i++)
        {
            if (select[i] ==1)
            {
                result[i] =list1[index1];
                index1++;
            }
            else
            {
                result[i] = list2[index2];
                index2++;
            }
        }
        return result;
    }

    public static char[] ListSelector(char[] list1, char[] list2, int[] select)
    {
        char[] result = new char[select.Length];
        int index1 = 0;
        int index2 = 0;
        
        for (int i = 0; i < select.Length; i++)
        {
            if (select[i] == 1)
            {
                result[i] = list1[index1];
                index1++;
            }
            else
            {
                result[i] = list2[index2];
                index2++;
            }
        }
        return result;
    }
}