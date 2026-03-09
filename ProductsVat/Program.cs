namespace ProductsVat
{
    internal class Program
    {
        /// <summary>
        /// Reads a product price from the console, calculates the VAT (24%) and the
        /// total price including VAT, and prints the results formatted to 2 decimal places.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            // Δήλωση και αρχικοποίηση μεταβλητών
            const double VAT_RATE = 0.24D;
           

            double price = 0D;
            double vat = 0D;
            double total = 0D;
             

            // Εισαγωγή δεδομένων, data binding και validation
            Console.WriteLine("Δώστε την τιμή του προϊόντος:");
            if (!double.TryParse(Console.ReadLine(), out price) || price < 0)
            {
                Console.WriteLine("Μη έγκυρη είσοδος για τιμή του προϊόντος.");
                return;
            }

            // Μετατροπή και υπολογισμοί - Λογική του προγράμματο
            vat = price * VAT_RATE;
            total = price + vat;

            // Εμφάνιση αποτελέσματος
            Console.OutputEncoding = System.Text.Encoding.UTF8;  // Ensure correct display of the Euro symbol
            Console.WriteLine($"{"Τιμή χωρίς ΦΠΑ:",-20} {price:N2} \u20AC");
            Console.WriteLine($"{"ΦΠΑ(24%):",-20} {vat:N2} \u20AC");
            Console.WriteLine($"{"Τιμή με ΦΠΑ:",-20} {total:N2} \u20AC");
             

        }
    }
}
