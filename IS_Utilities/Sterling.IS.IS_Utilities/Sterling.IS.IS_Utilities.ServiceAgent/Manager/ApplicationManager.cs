using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sterling.IS.Utilities.ServiceAgent.Entities;
using System.Data.Entity;

namespace Sterling.IS.Utilities.ServiceAgent.Manager
{
    public class ApplicationManager
    {
        ApplicationDbContext context = new ApplicationDbContext();
       
        public ApplicationManager()
        {
            
        }
        
        public Application GetAppById(int appId)
        {
            return (from d in context.Apps
                   where d.ID == appId
                   select d).Single();
        }
        public List<Application> GetApplications()
        {
            return context.Apps.ToList();

        }
        public List<Owner> GetOwners()
        {
            var owners = context.Owners.ToList();
           
            return owners;
        }
        public List<Application> GetApplicationsByOwnerId(int ownerID)
        {
            var list = new List<Application>();

            //list = (from d in context.Apps
            //       join a in context.OwnerMapper on d.ID equals a.ApplicationID
            //       where a.OwnerId == ownerID
            //       select d).ToList();

            return list;
        }
        public List<Utility> GetUtilitiesByAppId(int appId)
        {
            var list = new List<Utility>();
            list = (from d in context.Utilities
                   
                    where d.ApplicationId == appId
                    select d).ToList();
            return list;
        }
        public Owner GetOwnerById(int id){
            return (from d in context.Owners
                    where d.ID==id
                    select d).Single();
        }
        public void CreateApplication(Application app)
        {
            
           // app.ID = context.Apps.Count()+1;
            context.Apps.Add(app);
            context.SaveChanges();
        }
        public List<MenuItem> GetMenu()
        {
            return context.Menu.ToList();
        }

        public List<Utility> GetUtilities()
        {
            return context.Utilities.ToList();
        }

        public Application GetApplicationById(int id)
        {
            return context.Apps.Where(a => a.ID == id).Single();
        }

        public void UpdateApplication(Application app)
        {
          
            context.Entry(app).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteApplication(int id)
        {
            var app = context.Apps.Where(m => m.ID == id).Single();
            context.Apps.Remove(app);
            context.SaveChanges();
        }

        public void CreateDeveloper(Owner dev,List<int> lstApps)
        {
         
                context.Owners.Add(dev);
                context.SaveChanges();
                UpdateDeveloper(dev, lstApps);
        }

       



        public void UpdateDeveloper(Owner owner, List<int> lstApps)
        {
            context.Owners.Attach(owner);
            context.Entry(owner).Collection(a => a.Applications).Load();
            if (owner.Applications == null)
            {
                owner.Applications = new List<Application>();
               
            }
            
            for(int i=owner.Applications.Count()-1;i>=0;i--){
                 owner.Applications.Remove(owner.Applications[i]);
                
            }
            context.SaveChanges();
            foreach (int appId in lstApps)
            {
                var app = GetApplicationById(appId);
               
                
                owner.Applications.Add(app);
            }
          
         
             context.Entry(owner).State = EntityState.Modified;
             context.SaveChanges();
         
        }

     
      


        public void DeleteDeveloper(Owner owner)
        {
            context.Owners.Remove(owner);
            context.SaveChanges();
        }

        public List<Section> GetSectionsByAppId(int appId)
        {
            return GetApplicationById(appId).Sections;
        }

        public void InsertSection(Section section)
        {
            var app = GetAppById(section.ApplicationId);
            app.Sections.Add(section);
            context.Entry(app).State = EntityState.Modified;
            context.SaveChanges();
           
        }

        public object GetSectionById(int id)
        {
            return (from d in context.Sections
                    where d.Id == id
                    select d).Single();
        }

        public void UpdateSection(Section section)
        {
            context.Entry(section).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteSection(Section section)
        {
            context.Sections.Attach(section);
            context.Sections.Remove(section);
            context.SaveChanges();
        }
    }
}
