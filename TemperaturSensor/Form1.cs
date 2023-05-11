namespace TemperaturSensor {
    public partial class Form1 : Form {
        internal TemperatureSensor ts;
        internal TemperatureMonitor tm;
        public Form1(TemperatureSensor ts, TemperatureMonitor tm) {
            InitializeComponent();
            this.tm = tm;
            this.ts = ts;
        }
        private void Form1_Load(object sender, EventArgs e) {

        }
        public TextBox GetTextBox() {
            return textBox1;
        }
        private void button1_Click(object sender, EventArgs e) {
            ts.Measure(this);
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            if (this.ts.currentTemperature < 0) {
                this.BackColor = Color.DeepSkyBlue;
            } else if (this.ts.currentTemperature > 25) {
                this.BackColor = Color.OrangeRed;
            } else {
                this.BackColor = Color.MintCream;
            }

        }

        private void label1_Click(object sender, EventArgs e) {

        }
    }
}