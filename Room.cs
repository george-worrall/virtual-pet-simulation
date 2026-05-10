namespace VirtualPetSimulation.Models
{
    public class Room
    {
        public double AmbientTemp { get; private set; }   // Target temperature
        public double CurrentTemp { get; private set; }   // Actual temperature

        public Room(double ambientTemp, double currentTemp)
        {
            AmbientTemp = ambientTemp;
            CurrentTemp = currentTemp;
        }

        // User heat action — warms room instantly by 1 degree
        public void HeatRoom()
        {
            CurrentTemp += 1;
        }

        // User cool action — cools room instantly by 1 degree
        public void CoolRoom()
        {
            CurrentTemp -= 1;
        }

        // Natural temperature drift back to ambient
        public void UpdateTemperature()
        {
            if (Math.Abs(CurrentTemp - AmbientTemp) < 0.01)
                return;

            if (CurrentTemp > AmbientTemp)
                CurrentTemp -= 0.01;
            else if (CurrentTemp < AmbientTemp)
                CurrentTemp += 0.01;
        }
    }
}
