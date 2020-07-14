
namespace GettingStarted
{
    public class ElectionData
    {
        private string state;
        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public string candidate;
        public string Candidate
        {
            get { return candidate; }
            set { candidate = value; }
        }

        private double electors;
        public double Electors
        {
            get { return electors; }
            set { electors = value; }
        }
    }
}
