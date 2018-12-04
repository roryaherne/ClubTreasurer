using BankTransactions.SerializationModels;
using ClubTreasurer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
                       Account = await GetOrCreateNewAccount(context, transaction)
                });
            }            
        }

        private static async Task<BankAccount> GetOrCreateNewAccount(ClubTreasurerContext context, GeorgeTransaction transaction)
        {
            var account = await context.BankAccounts.FirstOrDefaultAsync(a => a.IBAN == transaction.PartnerAccount.Iban);
            if (account != null)
                return account;
            else
            {
                account = new BankAccount();
                account.IBAN = transaction.PartnerAccount.Iban;
                account.Name = transaction.PartnerName;
                context.BankAccounts.Add(account);
                await context.SaveChangesAsync();
                return account;
            }
        }
    }
}
