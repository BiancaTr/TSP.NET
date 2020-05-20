using PhotosAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotosWCF
{
    public class Service : IService
    {
        private readonly APIClass API;

        public Service()
        {
            API = new APIClass();
        }
        public void deletePhoto(MyPhotoTable myPhotoTable)
        {
           
            API.deletePhoto(myPhotoTable);
        }
        public void deletePhotoById(int id)
        {
            API.deletePhotoById(id);
        }

        public List<MyPhotoTable> GetAllInfo()
        {
            return API.GetAllInfo();
        }

        public MyPhotoTable getInfoById(int id)
        {
            return API.getInfoById(id);
        }

        public List<MyPhotoTable> GetInfoBySomething(string searchBy, string text)
        {
            return API.GetInfoBySomething(searchBy, text);
        }

        public void modifyPath(int id, string fileName)
        {
            API.modifyPath(id, fileName);
        }

        public void modifyPhoto(int id, string name, string place, string people, string description, string picEvent, string category, DateTime createTime, string path)
        {
            API.modifyPhoto(id, name, place, people, description, picEvent, category, createTime, path);
        }

        public void submitPhoto(string name, string place, string people, string description, string picEvent, string category, DateTime createTime, string path)
        {
            API.submitPhoto(name, place, people, description, picEvent, category, createTime, path);
        }
    }
}
