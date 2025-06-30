namespace Secao12.DevicesProgram.Devices
{
    internal class ComboDevice : Device, IScanner, IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine($"Combo deviceprint {document}");
        }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine($"Combo device processing: {document}");
        }

        public string Scan()
        {
            return "Combo deivce scan result";
        }
    }
}
