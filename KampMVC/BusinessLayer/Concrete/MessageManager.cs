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
            throw new NotImplementedException();
        }

        public List<Message> GetListInbox()
        {
            return _messageDAL.List(x => x.ReceiverMail == "furkan@gmail.com");
        }

        public List<Message> GetListSendbox()
        {
            return _messageDAL.List(x => x.SenderMail == "furkan@gmail.com");
        }

        public void MessageAdd(Message message)
        {
            _messageDAL.Insert(message);
        }

        public void MessageDelete(Message message)
        {
            throw new NotImplementedException();
        }

        public void MessageUpdate(Message message)
        {
            throw new NotImplementedException();
        }
    }
}
