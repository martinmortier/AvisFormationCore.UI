namespace Data
{
    public internal interface IContactRepository
    {
        public void SaveMessage(string nom, string email, string msg);
    }
}