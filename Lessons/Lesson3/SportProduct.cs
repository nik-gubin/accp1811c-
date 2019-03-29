namespace Lesson3
{
    class SportProduct:Product
    {
        private string sport;

        public SportProduct():base(null)
        {
        }

        public string GetSport()
        {
            return sport;
        }
    }
}
