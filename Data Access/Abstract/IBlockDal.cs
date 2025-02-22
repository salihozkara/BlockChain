﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.Abstract
{
    public interface IBlockDal : IRepository<Block>
    {
        Block GetLastBlock();
        List<Block> GetBlocksWTransactions();
    }
}
