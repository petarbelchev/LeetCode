namespace TopInterview150;

public class H_Index
{
    public int HIndex(int[] citations)
    {
        int h = citations.Length;

        while (h > 0)
        {
            int incompatibleCount = citations.Length - h;

            for (int i = 0; i < citations.Length; i++)
            {
                if (citations[i] < h)
                    incompatibleCount--;

                if (incompatibleCount < 0)
                    break;
            }

            if (incompatibleCount >= 0)
                break;
            else
                h--;
        }

        return h;
    }
}
