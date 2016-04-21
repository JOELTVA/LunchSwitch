using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchSwitch
{
    public class Controller
    {

        DAL.LunchSwitchAccess lsa = new DAL.LunchSwitchAccess(); //ska gå via LunchSwitchAccess i DAL istället och LunchSwitchAccess kallar på LunchSwitchEDM

        //User
        public user FindUser(string userId)
        {
            try
            {
                return lsa.FindUser(userId);
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
                lsa.AddUser(u);
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
                lsa.DeleteUser(userId);
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
                return lsa.FindAllUsers();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<user> FindUserByCity(string city, user u)
        {
            try
            {
                return lsa.FindUserByCity(city, u);
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
                return lsa.FindLunchbox(lunchBoxId);
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
                lsa.AddLunchbox(l);
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
                lsa.DeleteLunchbox(lunchBoxId);
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
                return lsa.FindAllLunchboxes(u);
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
                return lsa.FindLunchboxByFoodCategory(foodCategory, u);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<string> FindAllLunchboxesCitys()
        {
            try
            {
                return lsa.FindAllLunchboxesCitys();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<lunchbox> FindLunchboxByCity(string city, user u)
        {
            try
            {
                return lsa.FindLunchboxByCity(city, u);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<lunchbox> FindLunchboxByCityAndCategory(String city, String foodCategory, user u)
        {
            try
            {
                return lsa.FindLunchboxByCityAndCategory(city,foodCategory, u);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Meetup
        public meetup FindMeetup(long meetupId)
        {
            try
            {
                return lsa.FindMeetup(meetupId);
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
                lsa.AddMeetup(m);
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
                lsa.DeleteMeetup(meetupId);
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
                return lsa.FindAllMeetups();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
