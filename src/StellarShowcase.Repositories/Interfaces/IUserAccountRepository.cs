﻿using StellarShowcase.Domain.Dto;
using StellarShowcase.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StellarShowcase.Repositories.Interfaces
{
    public interface IUserAccountRepository
    {
        Task AddUserAccount(UserAccountDto userDto);

        Task<IEnumerable<UserAccountEntity>> GetUserAccounts();

        Task<UserAccountEntity> GetUserAccount(Guid id);

        Task CreateTrustline(Guid id, Guid issuerId, Guid assetId, decimal? limit = null);

        Task TransferAsset(Guid id, Guid issuerId, Guid assetId, string recipientAccountId, decimal amount, string memo = "");
    }
}
