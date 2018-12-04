using BankTransactions.SerializationModels;
using System;
using System.Collections.Generic;

namespace BankTransactions
{
    public static class ImportExport
    {
        public static List<GeorgeTransaction> ImportFromJson(string json)
        {
            return GeorgeTransaction.FromJson(json);
        }
    }
}
