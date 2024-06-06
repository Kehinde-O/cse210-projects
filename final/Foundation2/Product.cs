class Product{
    private string _name;
    private string _productId;
    private decimal _price;
    private int _quantity;

    public Product(string name, string productId, decimal price, int quantity = 1){
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public decimal GetTotalCost(){
        return _price * _quantity;
    }

    public string GetPackingLabel(){
        // return $"{_name}\t{_productId}\t${_price}\t{_quantity}\t${GetTotalCost()}";
        return string.Format("{0,-20}{1,-20}{2,-20}{3,-20}{4,-20}", _name, _productId, "$"+_price, _quantity, "$"+GetTotalCost());
    }
}