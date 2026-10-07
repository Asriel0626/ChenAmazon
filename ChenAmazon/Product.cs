using System;
using System.Diagnostics.CodeAnalysis;

namespace ChenAmazon
{
    internal class Product
    {
        public static string MarketplaceName { get; } = "Amazon";

        private readonly string source;

        public string Source
        {
            get
            {
                return source;
            }
        }

        public string ProductID { get; init; } = "";

        private string productName = "";

        public required string ProductName
        {
            get
            {
                if (string.IsNullOrWhiteSpace(productName))
                {
                    return "Unnamed product";
                }

                return productName;
            }

            set
            {
                productName = (value ?? "").Trim();
            }
        }

        public string ProductDescription { get; set; } = "";

        public required string TrackingNumber;

        public string TrackingDisplay
        {
            get
            {
                if (string.IsNullOrWhiteSpace(TrackingNumber))
                {
                    return "Waiting for shipment";
                }

                return TrackingNumber;
            }
        }

        public Product()
        {
            source = MarketplaceName;
        }

        [SetsRequiredMembers]
        public Product(string productID, string productName)
        {
            ProductID = productID;
            ProductName = productName;
            ProductDescription = "No description";
            TrackingNumber = "";
            source = MarketplaceName;
        }

        [SetsRequiredMembers]
        public Product(
            string productID,
            string productName,
            string productDescription,
            string trackingNumber)
        {
            ProductID = productID;
            ProductName = productName;
            ProductDescription = productDescription;
            TrackingNumber = trackingNumber;
            source = MarketplaceName;
        }
    }
}






    

