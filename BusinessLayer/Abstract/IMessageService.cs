using EntitiyLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IMessageService
    {
        List<Message> GetListInbox();
        List<Message> GetListSendbox();
        void MessageAddBL(Message message);

        Message GetByID(int id);
        void MessageDelete(Category message);

        void MessageUpdate(Message message);

    }
}
