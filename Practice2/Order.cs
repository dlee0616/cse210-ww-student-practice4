using System;
using System.Collections.Generic;

namespace Practice2
{
    public class Order
    {
        public List<int> Products = new List<string>(){"laptop", "Shoes", "desk", "customer1"};
        //instance of shipping label 
        public string _shippingLabel;
        //instance of packing label
        public string _packingLabel; 
        //set packing label
        public void SetShippingLabel(string ShippingLabel)
        {
            _shippingLabel = ShippingLabel;
        }
        //return shipping label
        public void GetShippingLabel()
        {
            return _shippingLabel;
        }
        //set packing label
        public void SetPackingLabel(string PackingLabel)
        {
            _packingLabel = PackingLabel; 
        }
        //return packing label 
        public void GetPackingLabel()
        {
            return _packingLabel;
        }
        

    }


}