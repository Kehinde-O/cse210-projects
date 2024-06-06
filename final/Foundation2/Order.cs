class Order{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer){
        _customer = customer;
    }

    public void AddProduct(Product product){
        _products.Add(product);
    }

    public decimal GetTotalCost(){
        decimal total = 0;
        foreach(Product product in _products){
            total += product.GetTotalCost();
        }
        if(_customer.IsInUSA()){
            total += 5m;
        }else{
            total += 35m;
        }
        return total;
    }

    public string GetPackingLabel(){
        string packingLabel = "";
        foreach(Product product in _products){
            packingLabel += product.GetPackingLabel()+" \n";
        }
        return packingLabel;
    }

    public string GetShippingLabel(){
        return $"{_customer.GetShippingLabel()}";
    }
}