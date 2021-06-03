using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules_FluentValidation
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Mail Adresini Boş Geçemezsiniz.");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu Adını Boş Geçemezsiniz.");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("En Az 3 Karakter Girişi Yapın.");
            RuleFor(x => x.Subject).MaximumLength(50).WithMessage("En Fazla 3 Karakter Girişi Yapın.");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı Adını Boş Geçemezsiniz.");
            RuleFor(x => x.Message).NotEmpty().WithMessage("Mesaj Kısmını Boş Geçemezsiniz.");
            RuleFor(x => x.Message).MinimumLength(10).WithMessage("En Az 10 Karakter Girişi Yapın.");
            RuleFor(x => x.Message).MaximumLength(250).WithMessage("En Fazla 250 Karakter Girişi Yapın.");
            RuleFor(c => c.UserMail).EmailAddress().WithMessage("Mail Adresi Türünde Olmalıdır.");
        }
    }
}
