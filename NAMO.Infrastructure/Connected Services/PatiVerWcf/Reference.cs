﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторного создания кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PatiVerWcf
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PersonResponse", Namespace="http://schemas.datacontract.org/2004/07/PatiVer")]
    public partial class PersonResponse : object
    {
        
        private PatiVerWcf.PatientAttachment AttachmentDataField;
        
        private string MessageDataField;
        
        private PatiVerWcf.PatientData PatientDataField;
        
        private PatiVerWcf.Polis PolisDataField;
        
        private string SearchResultField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public PatiVerWcf.PatientAttachment AttachmentData
        {
            get
            {
                return this.AttachmentDataField;
            }
            set
            {
                this.AttachmentDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string MessageData
        {
            get
            {
                return this.MessageDataField;
            }
            set
            {
                this.MessageDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public PatiVerWcf.PatientData PatientData
        {
            get
            {
                return this.PatientDataField;
            }
            set
            {
                this.PatientDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public PatiVerWcf.Polis PolisData
        {
            get
            {
                return this.PolisDataField;
            }
            set
            {
                this.PolisDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string SearchResult
        {
            get
            {
                return this.SearchResultField;
            }
            set
            {
                this.SearchResultField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PatientAttachment", Namespace="http://schemas.datacontract.org/2004/07/PatiVer")]
    public partial class PatientAttachment : object
    {
        
        private System.Nullable<System.DateTime> BeginDateField;
        
        private string CodeMOField;
        
        private string DetachReasonField;
        
        private string DoctorSnilsField;
        
        private System.Nullable<System.DateTime> EndDateField;
        
        private string ReasonField;
        
        private string SectorField;
        
        private string SectorNameField;
        
        private string SectorTypeField;
        
        private string TypeField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.Nullable<System.DateTime> BeginDate
        {
            get
            {
                return this.BeginDateField;
            }
            set
            {
                this.BeginDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string CodeMO
        {
            get
            {
                return this.CodeMOField;
            }
            set
            {
                this.CodeMOField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string DetachReason
        {
            get
            {
                return this.DetachReasonField;
            }
            set
            {
                this.DetachReasonField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string DoctorSnils
        {
            get
            {
                return this.DoctorSnilsField;
            }
            set
            {
                this.DoctorSnilsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.Nullable<System.DateTime> EndDate
        {
            get
            {
                return this.EndDateField;
            }
            set
            {
                this.EndDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string Reason
        {
            get
            {
                return this.ReasonField;
            }
            set
            {
                this.ReasonField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string Sector
        {
            get
            {
                return this.SectorField;
            }
            set
            {
                this.SectorField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string SectorName
        {
            get
            {
                return this.SectorNameField;
            }
            set
            {
                this.SectorNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string SectorType
        {
            get
            {
                return this.SectorTypeField;
            }
            set
            {
                this.SectorTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string Type
        {
            get
            {
                return this.TypeField;
            }
            set
            {
                this.TypeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PatientData", Namespace="http://schemas.datacontract.org/2004/07/PatiVer")]
    public partial class PatientData : object
    {
        
        private System.Nullable<System.DateTime> BirthDateField;
        
        private string BirthPlaceField;
        
        private string CitizenshipField;
        
        private System.Nullable<System.DateTime> DocumentDateField;
        
        private string DocumentNumberField;
        
        private string DocumentOrgField;
        
        private string DocumentSeriesField;
        
        private string DocumentTypeField;
        
        private string ENPField;
        
        private string FomsIdField;
        
        private string NameField;
        
        private string PatronymicField;
        
        private string PhoneField;
        
        private PatiVerWcf.Address RegAddressField;
        
        private string SexField;
        
        private string SnilsField;
        
        private string SurnameField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.Nullable<System.DateTime> BirthDate
        {
            get
            {
                return this.BirthDateField;
            }
            set
            {
                this.BirthDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string BirthPlace
        {
            get
            {
                return this.BirthPlaceField;
            }
            set
            {
                this.BirthPlaceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string Citizenship
        {
            get
            {
                return this.CitizenshipField;
            }
            set
            {
                this.CitizenshipField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.Nullable<System.DateTime> DocumentDate
        {
            get
            {
                return this.DocumentDateField;
            }
            set
            {
                this.DocumentDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string DocumentNumber
        {
            get
            {
                return this.DocumentNumberField;
            }
            set
            {
                this.DocumentNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string DocumentOrg
        {
            get
            {
                return this.DocumentOrgField;
            }
            set
            {
                this.DocumentOrgField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string DocumentSeries
        {
            get
            {
                return this.DocumentSeriesField;
            }
            set
            {
                this.DocumentSeriesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string DocumentType
        {
            get
            {
                return this.DocumentTypeField;
            }
            set
            {
                this.DocumentTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string ENP
        {
            get
            {
                return this.ENPField;
            }
            set
            {
                this.ENPField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string FomsId
        {
            get
            {
                return this.FomsIdField;
            }
            set
            {
                this.FomsIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string Patronymic
        {
            get
            {
                return this.PatronymicField;
            }
            set
            {
                this.PatronymicField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string Phone
        {
            get
            {
                return this.PhoneField;
            }
            set
            {
                this.PhoneField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public PatiVerWcf.Address RegAddress
        {
            get
            {
                return this.RegAddressField;
            }
            set
            {
                this.RegAddressField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string Sex
        {
            get
            {
                return this.SexField;
            }
            set
            {
                this.SexField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string Snils
        {
            get
            {
                return this.SnilsField;
            }
            set
            {
                this.SnilsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string Surname
        {
            get
            {
                return this.SurnameField;
            }
            set
            {
                this.SurnameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Polis", Namespace="http://schemas.datacontract.org/2004/07/PatiVer")]
    public partial class Polis : object
    {
        
        private System.DateTime BeginDateField;
        
        private System.Nullable<System.DateTime> CloseDateField;
        
        private string CloseReasonField;
        
        private System.Nullable<System.DateTime> EndDateField;
        
        private string NumField;
        
        private string SMOField;
        
        private string TypeField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.DateTime BeginDate
        {
            get
            {
                return this.BeginDateField;
            }
            set
            {
                this.BeginDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.Nullable<System.DateTime> CloseDate
        {
            get
            {
                return this.CloseDateField;
            }
            set
            {
                this.CloseDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string CloseReason
        {
            get
            {
                return this.CloseReasonField;
            }
            set
            {
                this.CloseReasonField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.Nullable<System.DateTime> EndDate
        {
            get
            {
                return this.EndDateField;
            }
            set
            {
                this.EndDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string Num
        {
            get
            {
                return this.NumField;
            }
            set
            {
                this.NumField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string SMO
        {
            get
            {
                return this.SMOField;
            }
            set
            {
                this.SMOField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string Type
        {
            get
            {
                return this.TypeField;
            }
            set
            {
                this.TypeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Address", Namespace="http://schemas.datacontract.org/2004/07/PatiVer")]
    public partial class Address : object
    {
        
        private string CityField;
        
        private string CorpusField;
        
        private string FlatField;
        
        private string HouseField;
        
        private string KladrField;
        
        private string RegionField;
        
        private string StreetField;
        
        private string SubRegionField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string City
        {
            get
            {
                return this.CityField;
            }
            set
            {
                this.CityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string Corpus
        {
            get
            {
                return this.CorpusField;
            }
            set
            {
                this.CorpusField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string Flat
        {
            get
            {
                return this.FlatField;
            }
            set
            {
                this.FlatField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string House
        {
            get
            {
                return this.HouseField;
            }
            set
            {
                this.HouseField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string Kladr
        {
            get
            {
                return this.KladrField;
            }
            set
            {
                this.KladrField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string Region
        {
            get
            {
                return this.RegionField;
            }
            set
            {
                this.RegionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string Street
        {
            get
            {
                return this.StreetField;
            }
            set
            {
                this.StreetField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string SubRegion
        {
            get
            {
                return this.SubRegionField;
            }
            set
            {
                this.SubRegionField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PatiVerWcf.IWcfService")]
    public interface IWcfService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfService/GetPersonInfo_FIO", ReplyAction="http://tempuri.org/IWcfService/GetPersonInfo_FIOResponse")]
        PatiVerWcf.PersonResponse GetPersonInfo_FIO(string moId, string surname, string firstname, string patronymic, string birthday, string username, string password, bool isIPRAfirst, int MIS);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfService/GetPersonInfo_FIO", ReplyAction="http://tempuri.org/IWcfService/GetPersonInfo_FIOResponse")]
        System.Threading.Tasks.Task<PatiVerWcf.PersonResponse> GetPersonInfo_FIOAsync(string moId, string surname, string firstname, string patronymic, string birthday, string username, string password, bool isIPRAfirst, int MIS);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfService/GetPersonInfo_SNILS", ReplyAction="http://tempuri.org/IWcfService/GetPersonInfo_SNILSResponse")]
        PatiVerWcf.PersonResponse GetPersonInfo_SNILS(string moId, string snils, string username, string password, bool isIPRAfirst, int MIS);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfService/GetPersonInfo_SNILS", ReplyAction="http://tempuri.org/IWcfService/GetPersonInfo_SNILSResponse")]
        System.Threading.Tasks.Task<PatiVerWcf.PersonResponse> GetPersonInfo_SNILSAsync(string moId, string snils, string username, string password, bool isIPRAfirst, int MIS);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfService/GetPersonInfo_Polis", ReplyAction="http://tempuri.org/IWcfService/GetPersonInfo_PolisResponse")]
        PatiVerWcf.PersonResponse GetPersonInfo_Polis(string moId, string polis, string username, string password, bool isIPRAfirst, int MIS);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfService/GetPersonInfo_Polis", ReplyAction="http://tempuri.org/IWcfService/GetPersonInfo_PolisResponse")]
        System.Threading.Tasks.Task<PatiVerWcf.PersonResponse> GetPersonInfo_PolisAsync(string moId, string polis, string username, string password, bool isIPRAfirst, int MIS);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface IWcfServiceChannel : PatiVerWcf.IWcfService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class WcfServiceClient : System.ServiceModel.ClientBase<PatiVerWcf.IWcfService>, PatiVerWcf.IWcfService
    {
        
        /// <summary>
        /// Реализуйте этот разделяемый метод для настройки конечной точки службы.
        /// </summary>
        /// <param name="serviceEndpoint">Настраиваемая конечная точка</param>
        /// <param name="clientCredentials">Учетные данные клиента.</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public WcfServiceClient() : 
                base(WcfServiceClient.GetDefaultBinding(), WcfServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IWcfService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WcfServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(WcfServiceClient.GetBindingForEndpoint(endpointConfiguration), WcfServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WcfServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(WcfServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WcfServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(WcfServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WcfServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public PatiVerWcf.PersonResponse GetPersonInfo_FIO(string moId, string surname, string firstname, string patronymic, string birthday, string username, string password, bool isIPRAfirst, int MIS)
        {
            return base.Channel.GetPersonInfo_FIO(moId, surname, firstname, patronymic, birthday, username, password, isIPRAfirst, MIS);
        }
        
        public System.Threading.Tasks.Task<PatiVerWcf.PersonResponse> GetPersonInfo_FIOAsync(string moId, string surname, string firstname, string patronymic, string birthday, string username, string password, bool isIPRAfirst, int MIS)
        {
            return base.Channel.GetPersonInfo_FIOAsync(moId, surname, firstname, patronymic, birthday, username, password, isIPRAfirst, MIS);
        }
        
        public PatiVerWcf.PersonResponse GetPersonInfo_SNILS(string moId, string snils, string username, string password, bool isIPRAfirst, int MIS)
        {
            return base.Channel.GetPersonInfo_SNILS(moId, snils, username, password, isIPRAfirst, MIS);
        }
        
        public System.Threading.Tasks.Task<PatiVerWcf.PersonResponse> GetPersonInfo_SNILSAsync(string moId, string snils, string username, string password, bool isIPRAfirst, int MIS)
        {
            return base.Channel.GetPersonInfo_SNILSAsync(moId, snils, username, password, isIPRAfirst, MIS);
        }
        
        public PatiVerWcf.PersonResponse GetPersonInfo_Polis(string moId, string polis, string username, string password, bool isIPRAfirst, int MIS)
        {
            return base.Channel.GetPersonInfo_Polis(moId, polis, username, password, isIPRAfirst, MIS);
        }
        
        public System.Threading.Tasks.Task<PatiVerWcf.PersonResponse> GetPersonInfo_PolisAsync(string moId, string polis, string username, string password, bool isIPRAfirst, int MIS)
        {
            return base.Channel.GetPersonInfo_PolisAsync(moId, polis, username, password, isIPRAfirst, MIS);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IWcfService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Не удалось найти конечную точку с именем \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IWcfService))
            {
                return new System.ServiceModel.EndpointAddress("http://192.168.10.16:5588/PatiVerWcf.svc");
            }
            throw new System.InvalidOperationException(string.Format("Не удалось найти конечную точку с именем \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return WcfServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IWcfService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return WcfServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IWcfService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IWcfService,
        }
    }
}
