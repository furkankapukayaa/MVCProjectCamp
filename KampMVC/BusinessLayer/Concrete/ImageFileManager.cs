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
    public class ImageFileManager : IImageFileService
    {
        IImageFileDAL _imageFileDAL;

        public ImageFileManager(IImageFileDAL imageFileDAL)
        {
            _imageFileDAL = imageFileDAL;
        }

        public List<ImageFile> GetList()
        {
            return _imageFileDAL.List();
        }
    }
}
