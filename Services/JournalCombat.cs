namespace ArenaRPG.Services
{
    internal class JournalCombat: IDisposable
    {
        private StreamWriter _writer;

        public JournalCombat(string chemin)
        {
            _writer = new StreamWriter(chemin);
        }

        public void Ecrire(string message)
        {
            _writer.WriteLine(message);
        }

        public void Dispose()
        {
            _writer?.Dispose();
        }
    }
}
