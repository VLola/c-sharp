using System;
using System.IO;
using static System.Console;

namespace Project_41
{
    public class Pay
    {
        public bool fullSerialization { get; set; } // Full serialization
        public double payDay { get; set; }          // payment per day
        public int days { get; set; }               // number of days
        public double fineDay { get; set; }         // a penalty for one day of delay in payment
        public int countDayDelay { get; set; }      // number of days to delay payment

        public double amountPayable;    // amount payable without penalty (calculated field)
        public double fine;            // penalty (calculated field)
        public double totalAmount;     // total amount due (calculated field)

        public Pay() { }
        public Pay(bool fullSerialization, double payDay, int days, double fineDay, int countDayDelay)
        {
            this.fullSerialization = fullSerialization;
            this.payDay = payDay;
            this.days = days;
            this.fineDay = fineDay;
            this.countDayDelay = countDayDelay;
        }
        public static bool Searializ(Pay pay)
        {
            if (pay.fullSerialization == true) return true;
            return false;
        }
        public double AmountPayable()
        {
            return days * fineDay;
        }
        public double Fine()
        {
            return fineDay * countDayDelay;
        }
        public double TotalAmount()
        {
            return AmountPayable() + Fine();
        }
        public void Serialize(BinaryWriter binary)
        {
            binary.Write(fullSerialization);
            binary.Write(payDay);
            binary.Write(days);
            binary.Write(fineDay);
            binary.Write(countDayDelay);

            if (Searializ(this))
            {
                binary.Write(amountPayable = AmountPayable());
                binary.Write(fine = Fine());
                binary.Write(totalAmount = TotalAmount());
            }
            WriteLine("Ok Serialize");
        }
        public static Pay Deserialize(BinaryReader binary)
        {
            var account = new Pay();

            account.fullSerialization = binary.ReadBoolean();
            account.payDay = binary.ReadDouble();
            account.days = binary.ReadInt32();
            account.fineDay = binary.ReadDouble();
            account.countDayDelay = binary.ReadInt32();

            if (Searializ(account))
            {
                account.amountPayable = binary.ReadDouble();
                account.fine = binary.ReadDouble();
                account.totalAmount = binary.ReadDouble();
            }

            WriteLine("Ok Deserialize");
            return account;
        }
        public override string ToString()
        {
            return $"payDay: {payDay}, days: {days}, fineDay: {fineDay}, countDayDelay: {countDayDelay}, amountPayable: {amountPayable}, fine: {fine}, totalAmount: {totalAmount}.";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                void Write(Pay account, string name_account)
                {
                    using (var file = File.Create(name_account))
                    using (var binary = new BinaryWriter(file))
                        account.Serialize(binary);
                }
                Pay Read(string name_account)
                {
                    using (var file = File.OpenRead(name_account))
                    using (var binary = new BinaryReader(file))
                        return Pay.Deserialize(binary);
                }

                Pay account_1 = new Pay(false, 150.0, 7, 5.0, 20);
                Write(account_1, "account_1");
                WriteLine(Read("account_1"));
                Pay account_2 = new Pay(true, 150.0, 7, 5.0, 20);
                Write(account_2, "account_2");
                WriteLine(Read("account_2"));
            }
            catch (Exception ex)
            {
                WriteLine(ex);
            }
        }
    }
}
