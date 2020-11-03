using OnlineApplianceStore.Business.Models.Input;
using OnlineApplianceStore.Business.Models.Output;
using OnlineApplianceStore.Data.DTO;
using System.Collections.Generic;

namespace OnlineApplianceStore.Business.Models.Mappings
{
    public interface ICustomerMapper
    {
        CustomerDto ToDto(CustomerInputModel inputModel);
        CustomerOutputModel ToOutputModel(CustomerDto customerDto);
        List<CustomerOutputModel> ToOutputModels(List<CustomerDto> customersDto);
    }
}