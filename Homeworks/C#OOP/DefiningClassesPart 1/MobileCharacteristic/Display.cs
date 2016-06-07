namespace MobileCharacteristic
{
    public class Display
    {
        private string size;
        private int numberOfColors;
        public Display(string size)
        {
            this.Size = size;
        }
        public string Size
        {
            get
            {
                return this.size;
            }
            set
            {
                this.size = value;
            }
        }
        public int NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                this.numberOfColors = value;
            }
        }

        public override string ToString()
        {
            return this.Size + " " + this.NumberOfColors + " ";
        }
    }
}