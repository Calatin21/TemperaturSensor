namespace TemperaturSensor {
    public class TemperatureSensor {
        public double currentTemperature;
        public event EventHandler<TemperatureChangedEventArgs> TemperatureChanged;
        public void Measure(Form1 form) {
            Random rnd = new Random();
            double newTemperature = rnd.NextDouble() * (50 - (-30)) + -30;
            //Math.Round();
            if (currentTemperature != newTemperature) {
                currentTemperature = newTemperature;
                this.OnTemperatureChanged(currentTemperature, form);
            }
        }
        public void OnTemperatureChanged(double newTemperature, Form1 form) {
            if (TemperatureChanged != null) {
                TemperatureChanged(this, new TemperatureChangedEventArgs(newTemperature, form));
            }
        }
    }
}
