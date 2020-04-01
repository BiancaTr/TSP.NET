using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotosAPI
{
    public class APIClass
    {
        private readonly DatabaseModelContainer databaseModelContainer;

        public APIClass() => databaseModelContainer = new DatabaseModelContainer();

        public List<MyPhotoTable> GetAllInfo()
        {
            return databaseModelContainer.MyPhotoTableSet.ToList();
        }

        public void submitPhoto(string name, string place, string people, string description, string picEvent, string category, DateTime createTime, string path)
        {
            MyPhotoTable myPhotoTable = new MyPhotoTable()
            {
                Name = name,
                Place = place,
                Person = people,
                Description = description,
                Event = picEvent,
                Category = category,
                Create_Date = createTime,
                Path = path
            };
            databaseModelContainer.MyPhotoTableSet.Add(myPhotoTable);
            databaseModelContainer.SaveChanges();

        }

        public void modifyPhoto(int id, string name, string place, string people, string description, string picEvent, string category, DateTime createTime, string path)
        {
            MyPhotoTable myPhotoTable = getInfoById(id);
            myPhotoTable.Name = name;
            myPhotoTable.Place = place;
            myPhotoTable.Person = people;
            myPhotoTable.Description = description;
            myPhotoTable.Event = picEvent;
            myPhotoTable.Category = category;
            myPhotoTable.Create_Date = createTime;
            myPhotoTable.Path = path;
            databaseModelContainer.SaveChanges();
        }

        public MyPhotoTable getInfoById(int id)
        {
            return (from photo in databaseModelContainer.MyPhotoTableSet
                    where photo.Id == id
                    select photo).FirstOrDefault();

        }

        public List<MyPhotoTable> GetInfoBySomething(string searchBy, string text)
        {
            switch (searchBy)
            {

                case "Name":
                    return (from photo in databaseModelContainer.MyPhotoTableSet
                            where photo.Name == text
                            select photo).ToList();

                case "Event":
                    return (from photo in databaseModelContainer.MyPhotoTableSet
                            where photo.Event == text
                            select photo).ToList();

                case "Place":
                    return (from photo in databaseModelContainer.MyPhotoTableSet
                            where photo.Place == text
                            select photo).ToList();

                case "Description":
                    return (from photo in databaseModelContainer.MyPhotoTableSet
                            where photo.Description.Contains(text)
                            select photo).ToList();

                default:
                    return (from photo in databaseModelContainer.MyPhotoTableSet
                            where photo.Person.Contains(text)
                            select photo).ToList();

            }
        }

        public void deletePhoto(MyPhotoTable myPhotoTable)
        {
            databaseModelContainer.MyPhotoTableSet.Remove(myPhotoTable);
            databaseModelContainer.SaveChanges();
        }

        public void modifyPath(int id, string fileName)
        {
            MyPhotoTable photoToEdit = getInfoById(id);
            photoToEdit.Path = fileName;
            databaseModelContainer.SaveChanges();
        }
    }
}
