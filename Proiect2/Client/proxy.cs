﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PhotosAPI
{
    using System.Runtime.Serialization;


    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "MyPhotoTable", Namespace = "http://schemas.datacontract.org/2004/07/PhotosAPI", IsReference = true)]
    public partial class MyPhotoTable : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private string CategoryField;

        private System.DateTime Create_DateField;

        private string DescriptionField;

        private string EventField;

        private int IdField;

        private string NameField;

        private string PathField;

        private string PersonField;

        private string PlaceField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Category
        {
            get
            {
                return this.CategoryField;
            }
            set
            {
                this.CategoryField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Create_Date
        {
            get
            {
                return this.Create_DateField;
            }
            set
            {
                this.Create_DateField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Event
        {
            get
            {
                return this.EventField;
            }
            set
            {
                this.EventField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
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

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Path
        {
            get
            {
                return this.PathField;
            }
            set
            {
                this.PathField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Person
        {
            get
            {
                return this.PersonField;
            }
            set
            {
                this.PersonField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Place
        {
            get
            {
                return this.PlaceField;
            }
            set
            {
                this.PlaceField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName = "IService")]
public interface IService
{

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMyPhoto/GetAllInfo", ReplyAction = "http://tempuri.org/IMyPhoto/GetAllInfoResponse")]
    PhotosAPI.MyPhotoTable[] GetAllInfo();

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMyPhoto/GetAllInfo", ReplyAction = "http://tempuri.org/IMyPhoto/GetAllInfoResponse")]
    System.Threading.Tasks.Task<PhotosAPI.MyPhotoTable[]> GetAllInfoAsync();

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMyPhoto/submitPhoto", ReplyAction = "http://tempuri.org/IMyPhoto/submitPhotoResponse")]
    void submitPhoto(string name, string place, string people, string description, string picEvent, string category, System.DateTime createTime, string path);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMyPhoto/submitPhoto", ReplyAction = "http://tempuri.org/IMyPhoto/submitPhotoResponse")]
    System.Threading.Tasks.Task submitPhotoAsync(string name, string place, string people, string description, string picEvent, string category, System.DateTime createTime, string path);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMyPhoto/modifyPhoto", ReplyAction = "http://tempuri.org/IMyPhoto/modifyPhotoResponse")]
    void modifyPhoto(int id, string name, string place, string people, string description, string picEvent, string category, System.DateTime createTime, string path);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMyPhoto/modifyPhoto", ReplyAction = "http://tempuri.org/IMyPhoto/modifyPhotoResponse")]
    System.Threading.Tasks.Task modifyPhotoAsync(int id, string name, string place, string people, string description, string picEvent, string category, System.DateTime createTime, string path);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMyPhoto/getInfoById", ReplyAction = "http://tempuri.org/IMyPhoto/getInfoByIdResponse")]
    PhotosAPI.MyPhotoTable getInfoById(int id);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMyPhoto/getInfoById", ReplyAction = "http://tempuri.org/IMyPhoto/getInfoByIdResponse")]
    System.Threading.Tasks.Task<PhotosAPI.MyPhotoTable> getInfoByIdAsync(int id);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMyPhoto/GetInfoBySomething", ReplyAction = "http://tempuri.org/IMyPhoto/GetInfoBySomethingResponse")]
    PhotosAPI.MyPhotoTable[] GetInfoBySomething(string searchBy, string text);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMyPhoto/GetInfoBySomething", ReplyAction = "http://tempuri.org/IMyPhoto/GetInfoBySomethingResponse")]
    System.Threading.Tasks.Task<PhotosAPI.MyPhotoTable[]> GetInfoBySomethingAsync(string searchBy, string text);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMyPhoto/deletePhoto", ReplyAction = "http://tempuri.org/IMyPhoto/deletePhotoResponse")]
    void deletePhoto(PhotosAPI.MyPhotoTable myPhotoTable);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMyPhoto/deletePhoto", ReplyAction = "http://tempuri.org/IMyPhoto/deletePhotoResponse")]
    System.Threading.Tasks.Task deletePhotoAsync(PhotosAPI.MyPhotoTable myPhotoTable);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMyPhoto/modifyPath", ReplyAction = "http://tempuri.org/IMyPhoto/modifyPathResponse")]
    void modifyPath(int id, string fileName);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMyPhoto/modifyPath", ReplyAction = "http://tempuri.org/IMyPhoto/modifyPathResponse")]
    System.Threading.Tasks.Task modifyPathAsync(int id, string fileName);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMyPhoto/deletePhotoById", ReplyAction = "http://tempuri.org/IMyPhoto/deletePhotoByIdResponse")]
    void deletePhotoById(int id);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMyPhoto/deletePhotoById", ReplyAction = "http://tempuri.org/IMyPhoto/deletePhotoByIdResponse")]
    System.Threading.Tasks.Task deletePhotoByIdAsync(int id);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IServiceChannel : IService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class ServiceClient : System.ServiceModel.ClientBase<IService>, IService
{

    public ServiceClient()
    {
    }

    public ServiceClient(string endpointConfigurationName) :
            base(endpointConfigurationName)
    {
    }

    public ServiceClient(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
    {
    }

    public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
    {
    }

    public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
    {
    }

    public PhotosAPI.MyPhotoTable[] GetAllInfo()
    {
        return base.Channel.GetAllInfo();
    }

    public System.Threading.Tasks.Task<PhotosAPI.MyPhotoTable[]> GetAllInfoAsync()
    {
        return base.Channel.GetAllInfoAsync();
    }

    public void submitPhoto(string name, string place, string people, string description, string picEvent, string category, System.DateTime createTime, string path)
    {
        base.Channel.submitPhoto(name, place, people, description, picEvent, category, createTime, path);
    }

    public System.Threading.Tasks.Task submitPhotoAsync(string name, string place, string people, string description, string picEvent, string category, System.DateTime createTime, string path)
    {
        return base.Channel.submitPhotoAsync(name, place, people, description, picEvent, category, createTime, path);
    }

    public void modifyPhoto(int id, string name, string place, string people, string description, string picEvent, string category, System.DateTime createTime, string path)
    {
        base.Channel.modifyPhoto(id, name, place, people, description, picEvent, category, createTime, path);
    }

    public System.Threading.Tasks.Task modifyPhotoAsync(int id, string name, string place, string people, string description, string picEvent, string category, System.DateTime createTime, string path)
    {
        return base.Channel.modifyPhotoAsync(id, name, place, people, description, picEvent, category, createTime, path);
    }

    public PhotosAPI.MyPhotoTable getInfoById(int id)
    {
        return base.Channel.getInfoById(id);
    }

    public System.Threading.Tasks.Task<PhotosAPI.MyPhotoTable> getInfoByIdAsync(int id)
    {
        return base.Channel.getInfoByIdAsync(id);
    }

    public PhotosAPI.MyPhotoTable[] GetInfoBySomething(string searchBy, string text)
    {
        return base.Channel.GetInfoBySomething(searchBy, text);
    }

    public System.Threading.Tasks.Task<PhotosAPI.MyPhotoTable[]> GetInfoBySomethingAsync(string searchBy, string text)
    {
        return base.Channel.GetInfoBySomethingAsync(searchBy, text);
    }

    public void deletePhoto(PhotosAPI.MyPhotoTable myPhotoTable)
    {
        base.Channel.deletePhoto(myPhotoTable);
    }

    public System.Threading.Tasks.Task deletePhotoAsync(PhotosAPI.MyPhotoTable myPhotoTable)
    {
        return base.Channel.deletePhotoAsync(myPhotoTable);
    }

    public void modifyPath(int id, string fileName)
    {
        base.Channel.modifyPath(id, fileName);
    }

    public System.Threading.Tasks.Task modifyPathAsync(int id, string fileName)
    {
        return base.Channel.modifyPathAsync(id, fileName);
    }

    public void deletePhotoById(int id)
    {
        base.Channel.deletePhotoById(id);
    }

    public System.Threading.Tasks.Task deletePhotoByIdAsync(int id)
    {
        return base.Channel.deletePhotoByIdAsync(id);
    }
}
