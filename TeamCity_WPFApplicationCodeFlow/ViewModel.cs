using LiteDB;
using System.Collections.Generic;

namespace TeamCity_WPFApplicationCodeFlow
{
    internal class ViewModel
    {
        public LiteDatabase liteDatabase => new LiteDatabase(@"Filename=LiteDB.db; Connection=shared");
        public void Insert(Model modelObject)
        {
            using (liteDatabase)
            {
                var table = liteDatabase.GetCollection<Model>("TableName");

                table.Insert(modelObject);

                table.EnsureIndex(x => x.GuidID);
            }
        }

        public void Update(Model modelObject)
        {
            using (liteDatabase)
            {
                var issueCollection = liteDatabase.GetCollection<Model>("TableName");
                modelObject.FieldName1 = modelObject.FieldName1;
                issueCollection.Update(modelObject);
            }
        }

        public void Delete(Model modelObject)
        {
            using (liteDatabase)
            {
                var issues = liteDatabase.GetCollection<Model>("TableName");
                issues.Delete(modelObject.GuidID);
            }
        }

        public List<Model> GetAllData()
        {
            var modelsToReturn = new List<Model>();
            using (liteDatabase)
            {
                var modelItems = liteDatabase.GetCollection<Model>("TableName");
                var results = modelItems.FindAll();
                foreach (Model modelItem in results)
                {
                    modelsToReturn.Add(modelItem);
                }
                return modelsToReturn;
            }
        }
    }
}
