using BankTransactions.SerializationModels;
using ClubTreasurer.Data;
using ClubTreasurer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubTreasurer.Utilities
{
    public static class BankingUtils
    {
        public static async Task<bool> SaveGeorgeTransactionsToDB(ClubTreasurerContext context, List<GeorgeTransaction> georgeTransactions)
        {
            List<BankTransaction> transactions = new List<BankTransaction>();
            foreach (var transaction in georgeTransactions)
            {
                transactions.Add(new BankTransaction()
                {
                    ID = transaction.ReferenceNumber,
                    BookingDate = transaction.BookingDate,
                    Amount = (decimal)(transaction.Amount.Value * Math.Pow(10.00, -transaction.Amount.Precision)),
                    Reference = transaction.Reference,
                    Account = await GetOrCreateNewAccount(context, transaction),
                    TransactionCategory = await GetOrCreateNewCategory(context, transaction)
                });
            }

            try
            {
                foreach (var transaction in transactions)
                {
                    context.BankTransactions.AddIfNotExists(transaction, t => t.ID);
                }
                await context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                //tried to add duplicate data
                var test = ex;
                return false;
            }

        }

        private static async Task<BankAccount> GetOrCreateNewAccount(ClubTreasurerContext context, GeorgeTransaction transaction)
        {
            var account = await context.BankAccounts.FirstOrDefaultAsync(a => a.ID == transaction.PartnerAccount.Iban);
            if (account != null)
                return account;
            else
            {
                account = new BankAccount
                {
                    ID = transaction.PartnerAccount.Iban,
                    Name = transaction.PartnerName
                };

                context.BankAccounts.Add(account);
                await context.SaveChangesAsync();

                //try to assign it to a person
                var person = context.Persons.Where(p => p.FullName == transaction.PartnerName || p.FullNameReverse == transaction.PartnerName).FirstOrDefault();
                if (person != null)
                {
                    context.Attach(person).State = EntityState.Modified;
                    if (person.BankAccounts == null)
                    {
                        person.BankAccounts = new List<BankAccount>
                        {
                            account
                        };
                        await context.SaveChangesAsync();
                    }
                    else
                    {
                        person.BankAccounts.Add(account);
                    }

                }
                return account;
            }
        }

        private static async Task<BankTransactionCategory> GetOrCreateNewCategory(ClubTreasurerContext context, GeorgeTransaction transaction)
        {
            var category = await SearchByMultipleKeyword(context, transaction.Reference);
            if (category != null)
                return category;
            else category = await context.BankTransactionCategorys.FirstOrDefaultAsync(a => a.Name == "Undefined");
            if (category != null)
                return category;
            else
            {
                category = new BankTransactionCategory()
                {
                    Name = "Undefined",
                };
                context.BankTransactionCategorys.Add(category);
                await context.SaveChangesAsync();
            }
            return category;
        }

        public static async Task<BankTransactionCategory> SearchByMultipleKeyword(ClubTreasurerContext context, string reference)
        {
            string[] keywords = reference.Split(',');

            var allCategories = await context.BankTransactionCategorys.Where(c => c.KeyWords != null).ToListAsync();

            foreach (var category in allCategories)
            {
                if (category.KeyWords.Split(',').Any(s => reference.Contains(s, StringComparison.OrdinalIgnoreCase)))
                    return category;
            }

            return null;
        }
    }
}
