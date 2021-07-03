using Blazor.Shared.Entities;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Blazor.Shared.Others
{
    public class SellerDetail : INotifyPropertyChanged
    {
        public string Barcode { set; get; }
        public string ProductName { set; get; }
        private int _quantity;
        public int Quantity
        {
            get => _quantity;
            set {
                SetProperty(ref _quantity, value);
                Amount = Price * _quantity;
            }
        }
        public int Price { set; get; }
        public int Amount { set; get; }
        public SellerDetail()
        {
            this.Price = 0;
            this.Quantity = 0;
        }
        public SellerDetail(Product product)
        {
            this.Barcode = product.Barcode;
            this.ProductName = product.Name;
            this.Price = product.Price;
            this.Amount = Price;
            this.Quantity = 1;            
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new
                             PropertyChangedEventArgs(propertyName));
        }
        bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string
                                                     propertyName = null)
        {
            if (Equals(storage, value))
            {
                return false;
            }

            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
