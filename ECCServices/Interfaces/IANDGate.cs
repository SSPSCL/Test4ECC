namespace ECCServices.Interfaces
{
    public interface IANDGate
    {
        bool AND (bool inputA, bool inputB);

        uint AND (uint inputA, uint inputB);
    }
}
