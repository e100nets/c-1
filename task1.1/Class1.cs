namespace logic
{
    public class Logic 
    {
        public double Distance(double boatSpeed, double flowSpeed, double timeOnRiver, double timeOnLake)
        {
            double distance;
            if (boatSpeed > 0 && timeOnLake > 0 && timeOnRiver > 0 && boatSpeed - flowSpeed > 0)
            
                distance = (boatSpeed - flowSpeed) * timeOnRiver + boatSpeed * timeOnLake;
            
            else
                distance = 0;

            return distance;
        }
    }
}
