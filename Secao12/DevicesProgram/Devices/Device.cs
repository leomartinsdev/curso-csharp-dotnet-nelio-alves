namespace Secao12.DevicesProgram.Devices
{
    abstract class Device
    {
        public int SerialNumber { get; set; }
        public abstract void ProcessDoc(string document);
    }
}
