namespace RangeExceptions
{
    public class InvalidRangeException<T> : System.ApplicationException
    {
        private T start;
        private T end;

        public InvalidRangeException(T start, T end)
        {
            this.Start = start;
            this.End = end;
        }

        public T Start
        {
            get
            {
                return this.start;
            }

            set
            {
                this.start = value;
            }
        }

        public T End
        {
            get
            {
                return this.end;
            }

            set
            {
                this.end = value;
            }
        }

        public override string Message
        {
            get
            {
                string result;

                result = $"{typeof(T).Name} out of range (start {this.Start}, end {this.End})";

                return result;
            }
        }
    }
}
