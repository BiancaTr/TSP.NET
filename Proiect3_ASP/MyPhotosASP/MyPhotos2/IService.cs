using PhotosAPI;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace MyPhotosWCF
{
    [ServiceContract]
    public interface IMyPhoto
    {
        [OperationContract]
        List<MyPhotoTable> GetAllInfo();

        [OperationContract]
        void submitPhoto(string name, string place, string people, string description, string picEvent, string category, DateTime createTime, string path);

        [OperationContract]
        void modifyPhoto(int id, string name, string place, string people, string description, string picEvent, string category, DateTime createTime, string path);

        [OperationContract]
        MyPhotoTable getInfoById(int id);

        [OperationContract]
        List<MyPhotoTable> GetInfoBySomething(string searchBy, string text);

        [OperationContract]
        void deletePhoto(MyPhotoTable myPhotoTable);

        [OperationContract]
        void modifyPath(int id, string fileName);
        [OperationContract]
        void deletePhotoById(int id);

    }



    [ServiceContract]
    interface IService : IMyPhoto
    {
    }
}
