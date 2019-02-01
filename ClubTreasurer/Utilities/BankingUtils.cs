using BankTransactions.SerializationModels;
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
        public static async Task SaveGeorgeTransactionsToDB(ClubTreasurerContext context, List<GeorgeTransaction> georgeTransactions)
        {
            List<BankTransaction> transactions = new List<BankTransaction>();
            foreach (var transaction in georgeTransactions)
            {
                transactions.Add(new BankTransaction() {
                       Amount = (decimal)(transaction.Amount.Value * Math.Pow(10.00, -transaction.Amount.Precision)),
                       Reference = transaction.Reference,
                       ReferenceNumber = transaction.ReferenceNumber,
                       Account = await GetOrCreateNewAccount(context, transaction),
                       TransactionCategory = await GetOrCreateNewCategory(context, transaction)
                });
            }
            context.BankTransactions.AddRange(transactions);
            await context.SaveChangesAsync();
        }

        private static async Task<BankAccount> GetOrCreateNewAccount(ClubTreasurerContext context, GeorgeTransaction transaction)
        {
            var account = await context.BankAccounts.FirstOrDefaultAsync(a => a.IBAN == transaction.PartnerAccount.Iban);
            if (account != null)
                return account;
            else
            {
                account = new BankAccount
                {
                    IBAN = transaction.PartnerAccount.Iban,
                    Name = transaction.PartnerName
                };
                
                context.BankAccounts.Add(account);
                await context.SaveChangesAsync();

                //try to assign it to a person
                var person = context.Persons.Where(p => p.FullName == transaction.PartnerName).FirstOrDefault();
                if(person != null) { 
                    context.Attach(person).State = EntityState.Modified;
                    await context.SaveChangesAsync();
                }
                return account;
            }
        }

        private static async Task<BankTransactionCategory> GetOrCreateNewCategory(ClubTreasurerContext context, GeorgeTransaction transaction)
        {
            var category = await context.BankTransactionCategorys.FirstOrDefaultAsync(a => a.KeyWords.Contains(transaction.Reference));
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
    }
}
