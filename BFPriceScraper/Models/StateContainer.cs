namespace BFPriceScraper.Models
{
    public class StateContainer
    {
        private List<Product> _products = new List<Product>();

        public List<Product> Products
        {
            get => _products ?? new List<Product>();
            set
            {
                _products = value;
                NotifyStateChanged();
            }
        }

        public event Action? OnChange;

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
