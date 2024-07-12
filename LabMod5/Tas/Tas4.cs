using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabMod5
{
    public class CreditCard
    {
        private string cardNumber;
        private string cardHolderName;
        private string cvc;
        private DateTime expiryDate;
        private decimal balance;

        public string CardNumber
        {
            get => cardNumber;
            set
            {
                if (value.Length == 16 && long.TryParse(value, out _))
                {
                    cardNumber = value;
                }
                else
                {
                    throw new ArgumentException("Invalid card number.");
                }
            }
        }

        public string CardHolderName
        {
            get => cardHolderName;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    cardHolderName = value;
                }
                else
                {
                    throw new ArgumentException("Card holder name cannot be empty.");
                }
            }
        }

        public string CVC
        {
            get => cvc;
            set
            {
                if (value.Length == 3 && int.TryParse(value, out _))
                {
                    cvc = value;
                }
                else
                {
                    throw new ArgumentException("Invalid CVC.");
                }
            }
        }

        public DateTime ExpiryDate
        {
            get => expiryDate;
            set
            {
                if (value > DateTime.Now)
                {
                    expiryDate = value;
                }
                else
                {
                    throw new ArgumentException("Expiry date must be in the future.");
                }
            }
        }

        public decimal Balance
        {
            get => balance;
            set => balance = value;
        }

        public CreditCard(string cardNumber, string cardHolderName, string cvc, DateTime expiryDate, decimal balance)
        {
            CardNumber = cardNumber;
            CardHolderName = cardHolderName;
            CVC = cvc;
            ExpiryDate = expiryDate;
            Balance = balance;
        }

        // Перевантаження оператора +
        public static CreditCard operator +(CreditCard card, decimal amount)
        {
            return new CreditCard(card.CardNumber, card.CardHolderName, card.CVC, card.ExpiryDate, card.Balance + amount);
        }

        // Перевантаження оператора -
        public static CreditCard operator -(CreditCard card, decimal amount)
        {
            return new CreditCard(card.CardNumber, card.CardHolderName, card.CVC, card.ExpiryDate, card.Balance - amount);
        }

        // Перевантаження оператора ==
        public static bool operator ==(CreditCard card1, CreditCard card2)
        {
            return card1.CVC == card2.CVC;
        }

        // Перевантаження оператора !=
        public static bool operator !=(CreditCard card1, CreditCard card2)
        {
            return card1.CVC != card2.CVC;
        }

        // Перевантаження оператора <
        public static bool operator <(CreditCard card1, CreditCard card2)
        {
            return card1.Balance < card2.Balance;
        }

        // Перевантаження оператора >
        public static bool operator >(CreditCard card1, CreditCard card2)
        {
            return card1.Balance > card2.Balance;
        }

        // Перевизначення методу Equals
        public override bool Equals(object obj)
        {
            if (obj is CreditCard)
            {
                CreditCard card = (CreditCard)obj;
                return this.CVC == card.CVC;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return CVC.GetHashCode();
        }

        public override string ToString()
        {
            return $"Card Number: {CardNumber}, Card Holder: {CardHolderName}, CVC: {CVC}, Expiry Date: {ExpiryDate:MM/yy}, Balance: {Balance:C}";
        }
    }

}
