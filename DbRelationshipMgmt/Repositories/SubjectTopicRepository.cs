using Azure.Core;
using DbRelationshipMgmt.Data;
using DbRelationshipMgmt.Interface;
using DbRelationshipMgmt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DbRelationshipMgmt.Repositories
{
    public class SubjectTopicRepository : ISubjectTopic
    {
        private readonly MyAppDbContext _myAppDbContext;

        public SubjectTopicRepository(MyAppDbContext myAppDbContext)
        {
            _myAppDbContext = myAppDbContext;
        }


        public SubjectTopic AddTopic(SubjectTopic subjecttopic)
        {
          
             _myAppDbContext.SubjectTopics.Add(subjecttopic);
            _myAppDbContext.SaveChanges();
            return subjecttopic;
        }

        public List<SubjectTopic> GetallsubjectTpoic()
        {
            return _myAppDbContext.SubjectTopics.ToList();
        }

        public List<SubjectTopic> GetsubjecttopicsbyId(int id)
        {
            //return _myAppDbContext.SubjectTopics.Where(a => a.SubjectId == id).ToList();

            return _myAppDbContext.SubjectTopics.FromSqlRaw($"Select * from SubjectTopics where SubjectId = {id}").ToList();
        }

        public List<SubjectTopic> SearchsubjectTopic(string search)
        {
            //return _myAppDbContext.SubjectTopics.Where(n => n.SubjectTopicName.Contains(search)).ToList();

            return _myAppDbContext.SubjectTopics.FromSqlRaw($"Select * from SubjectTopics where SubjectTopicName like '%{search}%' ").ToList();
        }
    }
}
