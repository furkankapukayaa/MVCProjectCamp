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
    public class MessageManager : IMessageService
    {
        IMessageDAL _messageDAL;

        public MessageManager(IMessageDAL messageDAL)
        {
            _messageDAL = messageDAL;
        }

        public Message GetById(int id)
        {
            return _messageDAL.Get(x => x.MessageID == id);
        }

        public List<Message> GetList()
        {
            return _messageDAL.List(x => x.ReceiverMail == "furkan@gmail.com").Where(x => x.IsRead == true).ToList();
        }

        public List<Message> GetListInbox()
        {
            return _messageDAL.List(x => x.ReceiverMail == "furkan@gmail.com");
        }

        public List<Message> GetListSendbox()
        {
            return _messageDAL.List(x => x.SenderMail == "furkan@gmail.com");
        }

        public List<Message> GetListUnRead()
        {
            return _messageDAL.List(x => x.ReceiverMail == "furkan@gmail.com").Where(x => x.IsRead == false).ToList();
        }

        public void MessageAdd(Message message)
        {
            _messageDAL.Insert(message);
        }

        public void MessageDelete(Message message)
        {
            _messageDAL.Delete(message);
        }

        public void MessageUpdate(Message message)
        {
            _messageDAL.Update(message);
        }
    }
}
