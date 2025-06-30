namespace Secao12.DevicesProgram.Devices
{
    internal class Scanner : Device, IScanner
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine($"Scanner processing: {document}");
        }

        public string Scan()
        {
            return "Scanner can result";
        }
    }
}
