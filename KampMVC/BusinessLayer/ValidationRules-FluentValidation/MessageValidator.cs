using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules_FluentValidation
{
    public class MessageValidator:AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Bu Alanı Boş Geçemezsiniz.");
            //RuleFor(x => x.SenderMail).NotEmpty().WithMessage("Bu Alanı Boş Geçemezsiniz.");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Bu Alanı Boş Geçemezsiniz.");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Bu Alanı Boş Geçemezsiniz.");
            RuleFor(p => p.Subject).MinimumLength(3).WithMessage("En Az 3 Karakter Girişi Yapın.");
            RuleFor(p => p.Subject).MaximumLength(50).WithMessage("En Fazla 50 Karakter Girişi Yapın.");
            //RuleFor(c => c.SenderMail).EmailAddress().WithMessage("Mail Adresi Türünde Olmalıdır.");
            RuleFor(c => c.ReceiverMail).EmailAddress().WithMessage("Mail Adresi Türünde Olmalıdır.");
        }
    }
}
