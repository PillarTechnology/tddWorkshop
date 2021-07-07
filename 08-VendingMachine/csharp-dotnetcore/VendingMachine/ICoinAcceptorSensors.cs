namespace VendingMachine
{
    public interface ICoinAcceptorSensors
    {
        double WeightSensor(); // Returns weight in grams, +/- 0.1g
        int WidthSensor();     // Returns width in mm, +/- 0.5mm
    }
}