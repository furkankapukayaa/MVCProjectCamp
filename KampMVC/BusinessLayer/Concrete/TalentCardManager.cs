using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TalentCardManager : ITalentCardService
    {
        ITalentCardDal _talentcardDal;

        public TalentCardManager(ITalentCardDal talentcardDal)
        {
            _talentcardDal = talentcardDal;
        }

        public List<TalentCard> GetAll()
        {
            return _talentcardDal.List();
        }

        public TalentCard GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TalentCardAdd(TalentCard talentCard)
        {
            _talentcardDal.Insert(talentCard);
        }

        public void TalentCardDelete(TalentCard talentCard)
        {
            throw new NotImplementedException();
        }

        public void TalentCardUpdate(TalentCard talentCard)
        {
            throw new NotImplementedException();
        }
    }
}
