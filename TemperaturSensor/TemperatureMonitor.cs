namespace TemperaturSensor {
    public class TemperatureMonitor {
        public TemperatureMonitor(TemperatureSensor temperatureSensor) {
            temperatureSensor.TemperatureChanged += TemperatureSensor_TemperatureChanged;
        }
        private void TemperatureSensor_TemperatureChanged(object source, TemperatureChangedEventArgs e) {
            e.form.GetTextBox().Text= $"Neue Temperatur: {e.NewTemperature} C";
        }
    }
}
