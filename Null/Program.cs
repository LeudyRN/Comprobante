class SalesReceipt
{
    public string ReceiptNumber { get; set; }
    public DateTime Date { get; set; }
    public string CustomerName { get; set; }
    public string ProductName { get; set; }
    public decimal Price { get; set; }
    public decimal Cantidad {get; set;}

    public decimal total {get; set;}
}
class op{

static void Main()
{

    
    // Crea una nueva instancia de la clase SalesReceipt
    var receipt = new SalesReceipt();
    
    // Pide al usuario que ingrese la información del comprobante de ventas
    Console.WriteLine("Ingresa el número de comprobante: ");
    receipt.ReceiptNumber = Console.ReadLine();
    
    Console.WriteLine("Ingresa la fecha de emisión (formato dd/MM/yyyy): ");
    receipt.Date = DateTime.Parse(Console.ReadLine());
    
    Console.WriteLine("Ingresa el nombre del cliente: ");
    receipt.CustomerName = Console.ReadLine();
    
    Console.WriteLine("Ingresa el nombre del producto: ");
    receipt.ProductName = Console.ReadLine();
    
    Console.WriteLine("Ingresa el precio: ");
    receipt.Price = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese la cantidad consumida del producto: ");
    receipt.Cantidad = decimal.Parse(Console.ReadLine());

   

    if (receipt.Cantidad >= 1){
     
     receipt.total = receipt.Cantidad * receipt.Price;

    }
    
    // Muestra el comprobante de ventas en la consola
    Console.WriteLine();
    Console.WriteLine("Comprobante de venta");
    Console.WriteLine("-------------------");
    Console.WriteLine($"Número de comprobante: {receipt.ReceiptNumber}\n");
    Console.WriteLine($"Fecha de emisión: {receipt.Date:dd/MM/yyyy}\n");
    Console.WriteLine($"Cliente: {receipt.CustomerName}\n");
    Console.WriteLine($"Producto: {receipt.ProductName}\n");
    Console.WriteLine($"Precio: {receipt.Price:C}\n");
    Console.WriteLine($"Total a pagar: {receipt.total}\n");

     
    string op;

    Console.WriteLine("Quieres exportar tu comprobante?\n ");
    op = Console.ReadLine();

    if(op.ToLower() == "si"){

        utis.Exportar(receipt);
    }

    else{

        Environment.Exit(0);
    }

}


}

//Tolower