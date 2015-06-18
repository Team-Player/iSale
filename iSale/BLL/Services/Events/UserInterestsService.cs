using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Models;
using BLL.Services.Events.Interfaces;
using iSale.Domain.Abstract;
using iSale.Domain.Entities;

namespace BLL.Services.Events
{
    public class UserInterestsService : IUserInterestsService
    {
        private ISaleRepository _repository;

        public UserInterestsService(ISaleRepository repository)
        {
            _repository = repository;
        }

        public void SaveInterests(User user, EditInterestModel model)
        {
            user.Interests.Clear();
            List<iSale.Domain.Entities.Interest> interests = _repository.Interests.ToList();
            iSale.Domain.Entities.Interest currInterest;
            foreach (var interest in model.Interests)
            {
                currInterest = interests.FirstOrDefault(i => i.Id == interest.Id);
                if (currInterest != null)
                {
                    user.Interests.Add(currInterest);
                }
            }
            _repository.SaveUser(user);
        }
    }
}
