using GameManagement.MVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace GameManagement.MVC.DataAccess
{
    public class InMemoryTimeListRepository
    {
        public static List<TimeModel> listaTimes; 

        public InMemoryTimeListRepository()
        {
            if(listaTimes == null)
            {
                listaTimes = new List<TimeModel>();
            }
        }

        public IEnumerable<TimeModel> GetAllTimes()
        {
            return listaTimes.ToList();
        }

        public void AddTime(TimeModel _time)
        {
            _time.Id = AutoIncrementID();
            listaTimes.Add(_time);
        }

        public void DeleteTime(int _id)
        {
            var timeRemove = listaTimes.Where(t => t.Id ==_id).First();
            listaTimes.Remove(timeRemove);
        }

        public void UpdateTime(TimeModel _time)
        {
            var antigoTime = listaTimes.Where(t => t.Id == _time.Id).First();
            int index = listaTimes.IndexOf(antigoTime);
            listaTimes[index].Nome = _time.Nome;
        }

        public int AutoIncrementID()
        {
            if (listaTimes.Count() == 0)
            {
                return 1;
            }
            else
            {
                return listaTimes.Last().Id + 1;
            }     
        }

    }
}