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
            return _talentcardDal.Get(x => x.CardId == 1);
        }

        public void TalentCardAdd(TalentCard talentCard)
        {
            _talentcardDal.Insert(talentCard);
        }

        public void TalentCardDelete(TalentCard talentCard)
        {
            _talentcardDal.Delete(talentCard);
        }

        public void TalentCardUpdate(TalentCard talentCard)
        {
            _talentcardDal.Update(talentCard);
        }
    }
}
