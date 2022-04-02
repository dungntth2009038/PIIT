using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PIIT.Data
{
    public class BitCoinDBContext: DbContext
    {
        public BitCoinDBContext() : base("name = BitcoinDbString")
        { }   
        public DbSet<BitCoin> BitCoins { get; set }
        public DbSet<Market> Markets { get; set }
    }
}