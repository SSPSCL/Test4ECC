using ECCServices.Interfaces;

namespace ECCServices.Services
{
    public class ANDGate : IANDGate
    {
        public bool AND (bool inputA, bool inputB)
        {
            return inputA && inputB;
        }

        public uint AND (uint inputA, uint inputB)
        {
            return inputA & inputB;
        }
    }
}
