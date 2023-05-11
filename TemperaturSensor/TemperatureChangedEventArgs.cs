namespace TemperaturSensor {
    public class TemperatureChangedEventArgs : EventArgs {
        public Form1 form { get; }
        public double NewTemperature { get; }
        public TemperatureChangedEventArgs(double NewTemperature, Form1 form) {
            this.NewTemperature = NewTemperature;
            this.form = form;
        }
    }
}
