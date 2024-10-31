using NAMO.Domain.Entities;

namespace NAMO.Application.Interfaces;

[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName = "NAMO.Persistence.ConnectedService.PatiVer.IWcfService")]
public interface IWcfService
{

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IWcfService/GetPersonInfo_FIO", ReplyAction = "http://tempuri.org/IWcfService/GetPersonInfo_FIOResponse")]
    System.Threading.Tasks.Task<PersonResponse> GetPersonInfo_FIOAsync(string moId, string surname, string firstname, string patronymic, string birthday, string username, string password, bool isIPRAfirst, int MIS);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IWcfService/GetPersonInfo_SNILS", ReplyAction = "http://tempuri.org/IWcfService/GetPersonInfo_SNILSResponse")]
    System.Threading.Tasks.Task<PersonResponse> GetPersonInfo_SNILSAsync(string moId, string snils, string username, string password, bool isIPRAfirst, int MIS);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IWcfService/GetPersonInfo_Polis", ReplyAction = "http://tempuri.org/IWcfService/GetPersonInfo_PolisResponse")]
    System.Threading.Tasks.Task<PersonResponse> GetPersonInfo_PolisAsync(string moId, string polis, string username, string password, bool isIPRAfirst, int MIS);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
public interface IWcfServiceChannel : IWcfService, System.ServiceModel.IClientChannel
{
}
