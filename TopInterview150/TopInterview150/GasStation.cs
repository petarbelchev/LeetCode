namespace TopInterview150;

public class GasStation
{
    public int CanCompleteCircuit(int[] gas, int[] cost)
    {
        int fuelOnleft = 0;
        int fuelOnRight = 0;
        int startStation = -1;

        for (int i = 0; i < gas.Length; i++)
        {
            int currFuel = gas[i] - cost[i];
            
            if (currFuel + fuelOnRight >= 0)
            {
                fuelOnRight += currFuel;
            
                if (startStation == -1)
                    startStation = i;
            }
            else
            {
                fuelOnleft += currFuel;
             
                if (startStation != -1)
                {
                    fuelOnleft += fuelOnRight;
                    fuelOnRight = 0;
                    startStation = -1;
                }
            }
        }

        if (fuelOnRight + fuelOnleft >= 0)
            return startStation;

        return -1;
    }
}
