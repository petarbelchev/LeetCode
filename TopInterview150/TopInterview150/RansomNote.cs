namespace TopInterview150;

public class RansomNote
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        Dictionary<char, int> ransomMap = GetMap(ransomNote);
        Dictionary<char, int> magazineMap = GetMap(magazine);

        foreach ((char key, int count) in ransomMap)
        {
            if (magazineMap.TryGetValue(key, out int availableCount) == false 
                || availableCount < count)
            {
                return false;
            }
        }

        return true;
    }

    static Dictionary<char, int> GetMap(string letters)
    {
        var map = new Dictionary<char, int>();

        foreach (char letter in letters)
        {
            if (map.ContainsKey(letter) == false)
                map[letter] = 0;

            map[letter]++;
        }

        return map;
    }
}
