class utis
{

    public static void Exportar(SalesReceipt per){
     
     var Plantilla = "";

     StreamReader sr = new StreamReader("Plantilla.html");
     Plantilla = sr.ReadToEnd();
     sr.Close();

    string fecha = per.Date.ToString("dd/MM/yyyy");
    string precio = per.Price.ToString("0.00");
    string cantidad = per.Cantidad.ToString("0.00");
    string total = per.total.ToString("0.00");

     Plantilla = Plantilla.Replace("ID#", per.ReceiptNumber);
     Plantilla = Plantilla.Replace("Fecha#", fecha);
     Plantilla = Plantilla.Replace("Nombre del Cliente#", per.CustomerName);
     Plantilla = Plantilla.Replace("Producto#", per.ProductName);
     Plantilla = Plantilla.Replace("Precio#", precio);
     Plantilla = Plantilla.Replace("Cantidad#", cantidad);
     Plantilla = Plantilla.Replace("Total#", total);


       System.IO.File.WriteAllText("Comprobante.html", Plantilla);

       var url = "Comprobante.html";
       var psl = new System.Diagnostics.ProcessStartInfo();
       psl.UseShellExecute = true;
       psl.FileName = url;
       System.Diagnostics.Process.Start(psl);

       Console.WriteLine("Comprobante Exportado");
     
    }


}