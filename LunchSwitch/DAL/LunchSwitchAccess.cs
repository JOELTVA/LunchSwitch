using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchSwitch.DAL
{
    class LunchSwitchAccess
    {

        LunchSwitchEDM db = new LunchSwitchEDM();

        //User
        public user FindUser(string userId)
        {
            try
            {
                return db.Users.Find(userId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AddUser(user u)
        {
            try
            {
                db.Users.Add(u);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteUser(string userId)
        {
            try
            {
                user u = FindUser(userId);
                db.Users.Remove(u);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateUser(string userId, string fullName, string city, string email, string mobileNr, string description)
        {
            try
            {
                user u = db.Users.Find(userId);
                u.fullName = fullName;
                u.city = city;
                u.email = email;
                u.mobileNr = mobileNr;
                u.description = description;
                db.Entry(u).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<user> FindAllUsers()
        {
            try
            {
                List<user> listUsers = (from u in db.Users select u).ToList();
                return listUsers;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<user> FindUserByCity(string city, user user)
        {
            try
            {
                List<user> listUsers = (from u in db.Users where u.city == city && u != user select u).ToList();
                return listUsers;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //Lunchbox
        public lunchbox FindLunchbox(long lunchBoxId)
        {
            try
            {
                return db.Lunchboxes.Find(lunchBoxId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AddLunchbox(lunchbox l)
        {
            try
            {
                db.Lunchboxes.Add(l);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteLunchbox(long lunchBoxId)
        {
            try
            {
                lunchbox l = FindLunchbox(lunchBoxId);
                db.Lunchboxes.Remove(l);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateLunchbox(long lunchBoxId, int quantity)
        {
            try
            {
                lunchbox l = db.Lunchboxes.Find(lunchBoxId);
                l.quantity = quantity;
                db.Entry(l).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<lunchbox> FindAllLunchboxes(user u)
        {
            try
            {
                List<lunchbox> listLunchboxes = (from l in db.Lunchboxes where l.user == u select l).ToList();
                return listLunchboxes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<lunchbox> FindLunchboxByFoodCategory(string foodCategory, user u)
        {
            try
            {
                List<lunchbox> listLunchbox = (from l in db.Lunchboxes where l.foodCategory == foodCategory && l.user != u select l).ToList();
                return listLunchbox;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Add methods: findAllLunchboxCities, findLunchboxByCity, findLunchboxByCityAndCategory
        //Don't need own queries only busniess logic that depends on already made queries! 
        public List<String> FindAllLunchboxesCitys()
        {
            List<String> cities = new List<String>();
            List<user> users = this.FindAllUsers();
            foreach(user u in users)
            {
                cities.Add(u.city);
            }
            return cities;
        }

        public List<lunchbox> FindLunchboxByCity(String city, user u)
        {
            List<user> users = this.FindUserByCity(city, u);
            List<lunchbox> lunchboxes = new List<lunchbox>();
            foreach(user user in users)
            {
                foreach(lunchbox l in this.FindAllLunchboxes(user))
                {
                    if(user.Equals(l.user))
                    {
                        lunchboxes.Add(l);
                    }
                }
            }
            return lunchboxes;
        }

        public List<lunchbox> FindLunchboxByCityAndCategory(String city, String foodCategory, user u)
        {
           List<lunchbox> lunchboxes = new List<lunchbox>();
            foreach(lunchbox l in FindLunchboxByCity(city, u))
            {
                if (l.foodCategory.Equals(foodCategory))
                {
                    lunchboxes.Add(l);
                }
            }
            return lunchboxes;
        }
        //methods-ending

        //Meetup
        public meetup FindMeetup(long meetupId)
        {
            try
            {
                return db.Meetups.Find(meetupId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AddMeetup(meetup m)
        {
            try
            {
                db.Meetups.Add(m);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteMeetup(long meetupId)
        {
            try
            {
                meetup m = FindMeetup(meetupId);
                db.Meetups.Remove(m);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<meetup> FindAllMeetups()
        {
            try
            {
                List<meetup> listMeetups = (from m in db.Meetups select m).ToList();
                return listMeetups;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //Rating

    }
}
