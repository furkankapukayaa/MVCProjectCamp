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
    public class WriterLoginManager : IWriterLoginService
    {
        IWriterDAL _writerDAL;

        public WriterLoginManager(IWriterDAL writerDAL)
        {
            _writerDAL = writerDAL;
        }

        public Writer GetWriter(string username, string password)
        {
            return _writerDAL.Get(x => x.WriterMail == username && x.WriterPassword == password);
        }
    }
}
