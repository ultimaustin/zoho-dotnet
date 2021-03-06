﻿namespace Teference.Zoho.Api
{
    #region Namespace

    using System.Threading.Tasks;

    #endregion

    public interface IZsContactPersonApi
    {
        Task<ZsContactPerson> GetAsync(string customerId, string contactPersonId);
        Task<ZsContactPerson> GetAsync(string authToken, string organizationId, string customerId, string contactPersonId);

        Task<ZsContactPersons> GetAllAsync(string customerId);
        Task<ZsContactPersons> GetAllAsync(string authToken, string organizationId, string customerId);

        Task<ZsContactPerson> CreateAsync(string customerId, ZsContactPersonInput createInput);
        Task<ZsContactPerson> CreateAsync(string authToken, string organizationId, string customerId, ZsContactPersonInput createInput);

        Task<ZsContactPerson> UpdateAsync(string customerId, string contactPersonId, ZsContactPersonInput updateInput);
        Task<ZsContactPerson> UpdateAsync(string authToken, string organizationId, string customerId, string contactPersonId, ZsContactPersonInput updateInput);

        Task<bool> DeleteAsync(string customerId, string contactPersonId);
        Task<bool> DeleteAsync(string authToken, string organizationId, string customerId, string contactPersonId);
    }
}