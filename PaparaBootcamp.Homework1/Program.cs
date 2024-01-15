
using PaparaBootcamp.Homework1.Entity;

namespace PaparaBootcamp.Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = Products();
            var customers = Customers();

            FromExample(products);
            WhereExample(products);
            OrderByExample(products);
            OrderByWithDescendingExample(products);
            GroupByExample(products);
            JoinExample(products, customers);
            DistinctExample(products);
            AnyExample(products);
            WhereAndJoinExample(products, customers);
            AllExample(products);
            TakeExample(products);
            TopThreeHighValues(products);
            TopHighStock(products);
            PriceInRange(products);
            SumExample(products);
            AverageExample(customers);
        }


        #region from ve select
        private static void FromExample(List<Product> products)
        {
            var productDatas = from product in products select product;
            Console.WriteLine("From and select example: ");
            foreach (var product in productDatas)
            {
                Console.WriteLine($"Product Id: {product.Id}, Product Name: {product.Name}");
            }
            Console.WriteLine("---------------------------------------------------");
        }
        #endregion

        #region Where Example
        private static void WhereExample(List<Product> products)
        {
            var productDatas = from product in products
                               where product.Price > 50
                               select product;
            Console.WriteLine("Where example: ");
            foreach (var product in productDatas)
            {
                Console.WriteLine($"Product Id: {product.Id}, Product Name: {product.Name}, Price: {product.Price}");
            }
            Console.WriteLine("---------------------------------------------------");
        }
        #endregion

        #region Order By
        //küçükten buyuge dogru siralama islemi yapar
        private static void OrderByExample(List<Product> products)
        {
            var productOrderBy = from product in products 
                                 orderby product.Price
                                 select product;
            Console.WriteLine("Order By example: ");
            foreach (var product in productOrderBy)
            {
                Console.WriteLine($"Product Id: {product.Id}, Product Name: {product.Name}, Price: {product.Price}");
            }
            Console.WriteLine("---------------------------------------------------");
        }
        #endregion

        #region Order by with descending
        //büyükten küçüğe sıralama işlemi yapar
        private static void OrderByWithDescendingExample(List<Product> products)
        {
            var productOrderByDescending = from product in products
                                           orderby product.Price descending
                                           select product;
            Console.WriteLine("Order By Descending example: ");
            foreach (var product in productOrderByDescending)
            {
                Console.WriteLine($"Product Id: {product.Id}, Product Name: {product.Name}, Price: {product.Price}");
            }
            Console.WriteLine("---------------------------------------------------");
        }
        #endregion
        
        #region Group By
            //price a göre grupladım. Sunuç olarak bana kew ve value değerlerini döndürdü. Yani price ve kaç tane olduğu
            private static void GroupByExample(List<Product> products)
        {
            var productsData = from product in products
                               group product by product.Price;
            Console.WriteLine("Group By example: ");
            foreach (var product in productsData)
            {
                Console.WriteLine("Product Price : " + product.Key + " Product Price Count : " + product.Count());
            }
            Console.WriteLine("---------------------------------------------------");
        }
        #endregion

        #region Join Example
        //iki tabloyu birleştirmek için kullanırız
        private static void JoinExample(List<Product> products, List<Customer> customers)
        {
            var joinExample = from customer in customers
                              join product in products on customer.Id equals product.CustomerId
                              select new
                              {
                                  CustomerId = customer.Id,
                                  CustomerName = customer.Name,
                                  ProductName = product.Name,
                                  ProductPrice = product.Price
                              };
            Console.WriteLine("Join example: ");
            foreach (var data in joinExample)
            {
                Console.WriteLine($"Customer: {data.CustomerName}, Product: {data.ProductName}, Price: {data.ProductPrice}");
            }
            Console.WriteLine("---------------------------------------------------");
        }
        #endregion

        #region Where and Join
        //ürünler içinde Customer adı Arzu olan Ürün var mıdır?
        private static void WhereAndJoinExample(List<Product> products, List<Customer> customers)
        {           
            Console.WriteLine("Join ve where example: ");
            var joinExample = from customer in customers
                              join product in products on customer.Id equals product.CustomerId
                              where customer.Name == "Arzu"
                              select new
                              {
                                  CustomerId = customer.Id,
                                  CustomerName = customer.Name,
                                  ProductName = product.Name,
                                  ProductPrice = product.Price

                              };

            foreach (var item in joinExample)
            {
                Console.WriteLine($"Customer Name :  {item.CustomerName}, Product Name : {item.ProductName}");
            }
            Console.WriteLine("---------------------------------------------------");
        }
        #endregion

        #region Distinct
        //aynı olan değerleri almaz bende bu örnekte farklı fiyatları buldurmaya çalıştım
        private static void DistinctExample(List<Product> products)
        {
            var distinctExample = (from product in products
                                   select product.Price).Distinct();
            Console.WriteLine("distinct example: ");
            foreach (var item in distinctExample)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------------------------------");
        }
        #endregion

        #region Any Example
        private static void AnyExample(List<Product> products)
        {
            //any var mı diye bir kontrol işlemidir ve bool değer döndürür.
            bool anyProductExample = products.Any(product => product.CustomerId == 2);
            Console.WriteLine("Ürünler içinde customer idsi 2 olan ürün var mıdır : " + anyProductExample);
        }
        #endregion

        #region All Example
        //All sorgusu da bool döner. Tabloda ki tüm değerleri kontrol eder ve hepsi aynı sonucu döndürüyorsa true değerini verir
        private static void AllExample(List<Product> products)
        {
            Console.WriteLine("All Example : ");
            bool allExample = products.All(item => item.Price > 0);
            Console.WriteLine(allExample);
            Console.WriteLine("---------------------------------------------------");
        }
        #endregion

        #region Take Example
        //take belli sayıda eleman döndürmek için kullanılır mesela ilk 3 değer gibi
        private static void TakeExample(List<Product> products)
        {
            var takeExample = products.Take(3);
            Console.WriteLine("Take example: ");
            foreach (var product in takeExample)
            {
                Console.WriteLine($"Product Id: {product.Id}, Product Name: {product.Name}");
            }
            Console.WriteLine("---------------------------------------------------");
        }
        #endregion

        #region OrderBy and Take Example
        private static void TopThreeHighValues(List<Product> products)
        {
            Console.WriteLine("Order By and Take Example : ");
            var topThreeHighValueProducts = (from product in products
                                             orderby product.Price descending
                                             select product).Take(3);
            foreach (var product in topThreeHighValueProducts)
            {
                Console.WriteLine($"Product Name : {product.Name}, Product Price : {product.Price}");
            }
            Console.WriteLine("---------------------------------------------------");
        }
        #endregion

        #region FirstOrDefault Example
        //First Example
        //bu sorguda stokta en çok olan ürünü bulmaya çalıştım
        private static void TopHighStock(List<Product> products)
        {
            Console.WriteLine("First Example : ");
            var TopHighStock = (from product in products
                                orderby product.Stock descending
                                select product).FirstOrDefault();
            Console.WriteLine($"Product Name : {TopHighStock!.Name}, Product Stock : {TopHighStock!.Stock}");
            Console.WriteLine("---------------------------------------------------");
        }
        #endregion

        #region In range
        //Fiyatı 10 ile 50 arasındaki ürünler
        private static void PriceInRange(List<Product> products)
        {
            Console.WriteLine("Fiyatı 10 ile 50 arasındaki ürünler : ");
            var priceInRange = products.Where(product => product.Price >= 10 && product.Price <= 50);
            foreach (var product in priceInRange)
            {
                Console.WriteLine($"Product Name : {product.Name}, Product Price : {product.Price}");
            }
            Console.WriteLine("---------------------------------------------------");
        }
        #endregion

        #region Sum Example
        //Id si 2 olan müşterinin yaptığı alışverişlerin toplam fiyatı
        private static void SumExample(List<Product> products)
        {
            Console.WriteLine("Id si 2 olan müşterinin yaptığı alışverişlerin toplam fiyatı : ");
            var sumPrice = products.Where(p => p.CustomerId == 2).Sum(p => p.Price);
            Console.WriteLine(sumPrice);
            Console.WriteLine("---------------------------------------------------");
        }
        #endregion

        #region Average Example
        private static void AverageExample(List<Customer> customers)
        {
            //Müşterilerin yas ortalaması
            Console.WriteLine("Musterilerin yas ortalaması");
            var averageCustomerAge = customers.Average(customer => customer.Age);
            Console.WriteLine(averageCustomerAge);
            Console.WriteLine("---------------------------------------------------");
        }
        #endregion




        #region Product datas
        public static List<Product> Products()
        {
            List<Product> products = new List<Product> { new Product { Id = 1, CustomerId= 2, Name = "Elma", Price = 10, Stock = 52 },
                new Product { Id = 2,Name = "Armut", CustomerId=1, Price = 20, Stock = 30 },
                new Product { Id = 3,Name = "Portakal", CustomerId= 4, Price = 14, Stock = 35 },
                new Product { Id = 4,Name = "Çilek", CustomerId= 3, Price = 50, Stock = 100 },
                new Product { Id = 5,Name = "Ayva", CustomerId= 4, Price = 40, Stock = 34 },
                new Product { Id = 6,Name = "Muz", CustomerId=1, Price = 60, Stock = 23 },
                new Product { Id = 7,Name = "Ananas", CustomerId= 4, Price = 120, Stock = 0 },
                new Product { Id = 8,Name = "Mandalina", CustomerId= 2, Price = 60, Stock = 46 }
            };

            return products;
        }

        #endregion

        #region Customer data
        public static List<Customer> Customers()
        {
            List<Customer> customers = new List<Customer> {  new Customer { Id = 1, Name="Arzu", Surname="Tepe",Age=24},
                new Customer { Id = 2, Name="Ayşe", Surname="Aslan",Age=54},
                new Customer { Id = 3, Name="Ahmet", Surname="Çalım",Age=27},
                new Customer { Id = 4, Name="Mehmet", Surname="Teker",Age=79}
            };
            return customers;
        }
        #endregion

    }



}


